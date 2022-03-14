using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bessonova483_ElectroShop
{
    public partial class FormAccountWork : Form
    {
        public FormAccountWork()
        {
            InitializeComponent();
        }
        Bessonova483_ElectroShopDataSet.UsersDataTable users;

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAccountWork_Load(object sender, EventArgs e)
        {
            //Получение всех записей из таблицы Users
            users = this.usersTableAdapter1.GetData();
            //Отбор только с ролью менеджер по продажи (1) и главный менеджер (2)
            var filter = users.Where(rec => rec.IDRole == 1 || rec.IDRole == 2);
            //Количество записей
            int totalCount = filter.Count();
            //Отобразить полученные записи в компоненте
            this.dataGridViewListAccount.DataSource = filter.CopyToDataTable();
            //Выделять всю строку
            this.dataGridViewListAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListAccount.Select();		//Выбрать первую строку
            //Настроить список ролей в ComboBox
            this.comboBoxRole.DataSource = this.rolesTableAdapter1.GetData();
            this.comboBoxRole.DisplayMember = "Title";	//Видеть
            this.comboBoxRole.ValueMember = "ID";		//Получить
            this.comboBoxGender.DataSource = this.genderTableAdapter1.GetData();
            this.comboBoxGender.DisplayMember = "Title";
            this.comboBoxGender.ValueMember = "ID";
            
            this.groupBoxAccountRegister.Enabled = false;		//Недоступно для изменения
            this.buttonSave.Enabled = false;			//Заблокировано внесение изменений
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.groupBoxAccountRegister.Enabled = true;	//Доступно для изменения
            textBoxEmail.Text = "";
            textBoxPass.Text = "";
            textBoxName.Text = "";
            textBoxPatronymic.Text = "";
            textBoxSurname.Text = "";
            this.checkBoxSystem.Checked = true;
            this.buttonSave.Enabled = true;		//Разблокировано внесение изменений
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string log = textBoxEmail.Text;
            string pas = textBoxPass.Text;
            string surname = textBoxSurname.Text;
            string name = textBoxName.Text;
            string patronymic = textBoxPatronymic.Text;
            int idGender = (int)comboBoxGender.SelectedValue;
            string dateReg = Convert.ToString(DateTime.Now);
            bool active = Convert.ToBoolean(checkBoxSystem.Checked);
            //Контроль корректности заполнения полей
            if (String.IsNullOrEmpty(log) || String.IsNullOrEmpty(pas))
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            int pos = log.IndexOf('@');
            if (pos < 0)
            {
                MessageBox.Show("В логине отсутствуют обязательный символ @");
                return;
            }
            pos = log.IndexOf('.');
            if (pos < 0)
            {
                MessageBox.Show("В логине отсутствуют обязательный символ .");
                return;
            }
            int paslength = pas.Length;
            if (paslength < 6)
            {
                MessageBox.Show("В пароле должно быть не менее 6 символов.");
                return;
            }
            string pass = pas;
            for (int i = 0; i < pass.Length; ++i)
            {
                if (!char.IsLetter(pass[i]))
                {
                    MessageBox.Show("В пароле должны содержатся только латинские буквы, цифры.");
                    return;
                }
            }

            //for (int i = 0; i < pass.Length; ++i)
            //{
            //    if (char.IsLetter(pass[i]) && pass.Any(x => !char.IsDigit(x)))
            //    {
            //        MessageBox.Show("В пароле должно содержатся хотя бы одна цифра.");
            //        return;
            //    }
            //}

            if ((int)comboBoxRole.SelectedValue == 3)
            {
                MessageBox.Show("Нельзя добавлять нового организатора."
                    + Environment.NewLine + "Выберите другою роль");
                return;
            }
            //Поиск совпадений по данным
            var filter = users.Where(rec => rec.Email == log && rec.Password == pas);
            if (filter.Count() == 0)	//Нет записей – совпадение логина+пароля не найдено
            {
                try
                {
                    usersTableAdapter1.Insert(log, pas, surname, name, patronymic,idGender,dateReg, active, (int)comboBoxRole.SelectedValue);
                    MessageBox.Show("Данные о новом пользователе успешно сохранены в БД");
                    FormAccountWork_Load(null, null);		//Обновить данные в таблице
                }
                catch
                {
                    MessageBox.Show("При добавлении нового пользователя возникли проблемы");
                    return;
                }
            }
            else				//Данные в БД есть
            {
                MessageBox.Show("Такой пользователь уже зарегистрирован в системе." +
                                                    Environment.NewLine + " Введите другие данные");
                return;
            }

        }
        /// <summary>
        /// Извлечение данных из таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewListAccount_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex;				//Получить номер выбранной строки
            //Отобразить в контейнере значения нужных полей
            textBoxEmail.Text = dataGridViewListAccount.Rows[numRow].Cells[1].Value.ToString();
            textBoxPass.Text = dataGridViewListAccount.Rows[numRow].Cells[2].Value.ToString();
            textBoxSurname.Text = dataGridViewListAccount.Rows[numRow].Cells[3].Value.ToString();
            textBoxName.Text = dataGridViewListAccount.Rows[numRow].Cells[4].Value.ToString();
            textBoxPatronymic.Text = dataGridViewListAccount.Rows[numRow].Cells[5].Value.ToString();
            comboBoxGender.SelectedValue = Convert.ToInt32(dataGridViewListAccount.Rows[numRow].Cells[6].Value.ToString());
            textBoxRegisted.Text = dataGridViewListAccount.Rows[numRow].Cells[7].Value.ToString();
            //Отобразить название роли по ее номеру
            comboBoxRole.SelectedValue = (int)dataGridViewListAccount.Rows[numRow].Cells[9].Value;

            checkBoxSystem.Checked = Convert.ToBoolean(dataGridViewListAccount.Rows[numRow].Cells[8].Value);
        }
    }
}

