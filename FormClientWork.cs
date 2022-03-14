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
    public partial class FormClientWork : Form
    {
        Bessonova483_ElectroShopDataSet.UsersDataTable users;
        Bessonova483_ElectroShopDataSet.ListofClientsDataTableDataTable dataClients;
        Bessonova483_ElectroShopDataSet.ClientsRow rowClient;

        public FormClientWork()
        {
            InitializeComponent();
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
           
            string surname = textBoxSurname.Text;
            string name = textBoxName.Text;
            string patronymic = textBoxPatronymic.Text;
            int idGender = (int)comboBoxGender.SelectedValue;
            DateTime dateReg = DateTime.Now;
            DateTime datebirth = DateTime.Now;
            string phone = maskedTextBoxPhone.Text;
            int idClient = Convert.ToInt32(textBoxIdClient.Text);
            //Поиск совпадений по данным
            var filter = dataClients.Where(rec => rec.Email == email && rec.Phone == phone);
            if (filter.Count() == 0)	//Нет записей – совпадение логина+пароля не найдено
            {
                try
                {
                    clientsTableAdapter1.Insert(surname, name, patronymic, idGender, datebirth, phone, dateReg, email);
                    client_ManagerTableAdapter1.Insert(idClient, ClassTotal.idUser);
                    MessageBox.Show("Данные о новом клиенте успешно сохранены в БД");
                    FormClientWork_Load(null, null);		//Обновить данные в таблице
                }
                catch
                {
                    MessageBox.Show("При добавлении нового клиента возникли проблемы");
                    return;
                }
            }
            else				//Данные в БД есть
            {
                MessageBox.Show("Такой клиент уже зарегистрирован." +
                                                    Environment.NewLine + " Введите другие данные");
                return;
            }
        }

        private void FormClientWork_Load(object sender, EventArgs e)
        {
            //Получение всех записей из таблицы Users
            dataClients = this.listofClientsDataTableTableAdapter1.GetDataByIDManager(ClassTotal.idUser);
           
            //Отобразить полученные записи в компоненте
            this.dataGridViewListClient.DataSource = dataClients;
            //Выделять всю строку
            this.dataGridViewListClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListClient.Select();		//Выбрать первую строку
            
            this.comboBoxGender.DataSource = this.genderTableAdapter1.GetData();
            this.comboBoxGender.DisplayMember = "Title";
            this.comboBoxGender.ValueMember = "ID";

        }

        private void buttonUpdateClient_Click(object sender, EventArgs e)
        {

            string email = textBoxEmail.Text;

            string surname = textBoxSurname.Text;
            string name = textBoxName.Text;
            string patronymic = textBoxPatronymic.Text;
    
          
            string phone = maskedTextBoxPhone.Text;

            if (name == "" || surname == "" || patronymic == "")
            {
                MessageBox.Show("Не заполнили имя, отчество или фамилию");
                return;
            }



            rowClient.Name = name;
            rowClient.Surname = surname;
            rowClient.Patronymic = patronymic;
            rowClient.IDGender = (int)comboBoxGender.SelectedValue;
            rowClient.BirthDate = dateTimePickerBirth.Value;
            rowClient.Phone = maskedTextBoxPhone.Text;
            rowClient.Email = textBoxEmail.Text;
            //Поиск совпадений по данным
            var filter = dataClients.Where(rec => rec.Email == email && rec.Phone == phone);
            if (filter.Count() == 0)	//Нет записей – совпадение логина+пароля не найдено
            {
                try
                {
                    clientsTableAdapter1.Update(rowClient);
                    MessageBox.Show("Данные о новом клиенте успешно сохранены в БД");
                    FormClientWork_Load(null, null);		//Обновить данные в таблице
                }
                catch
                {
                    MessageBox.Show("При добавлении нового клиента возникли проблемы");
                    return;
                }
            }
            else				//Данные в БД есть
            {
                MessageBox.Show("Такой клиент уже зарегистрирован." +
                                                    Environment.NewLine + " Введите другие данные");
                return;
            }
        }

        private void dataGridViewListClient_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex;				//Получить номер выбранной строки
            //Отобразить в контейнере значения нужных полей
            textBoxEmail.Text = dataGridViewListClient.Rows[numRow].Cells[6].Value.ToString();
            
            textBoxSurname.Text = dataGridViewListClient.Rows[numRow].Cells[2].Value.ToString();
            textBoxName.Text = dataGridViewListClient.Rows[numRow].Cells[3].Value.ToString();
            textBoxPatronymic.Text = dataGridViewListClient.Rows[numRow].Cells[4].Value.ToString();
            comboBoxGender.SelectedValue = Convert.ToInt32(dataGridViewListClient.Rows[numRow].Cells[9].Value.ToString());
            dateTimePickerBirth.Value = Convert.ToDateTime(dataGridViewListClient.Rows[numRow].Cells[8].Value.ToString());
            maskedTextBoxPhone.Text = dataGridViewListClient.Rows[numRow].Cells[5].Value.ToString();
            dateTimePickerRegisted.Value = Convert.ToDateTime(dataGridViewListClient.Rows[numRow].Cells[7].Value.ToString());
        }

        private void buttonRegClient_Click(object sender, EventArgs e)
        {
            textBoxEmail.Text = textBoxName.Text = textBoxPatronymic.Text = textBoxSurname.Text = maskedTextBoxPhone.Text = textBoxIdClient.Text = "";
            dateTimePickerBirth.Value = dateTimePickerRegisted.Value = DateTime.Now;
        }
    }
 }
    

