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
    public partial class FormGlavManagerProfile : Form
    {
     
        public FormGlavManagerProfile()
        {
            InitializeComponent();
           
        }
        Bessonova483_ElectroShopDataSet.UsersDataTable users;
        Bessonova483_ElectroShopDataSet.UsersRow rowUser;
        /// <summary>
        /// назад в главное меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Обновление профиля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Заполнить строку-шаблон данными из элементов формы
            string name = textBoxFirstName.Text;
            string lastname = textBoxLastname.Text;
            string patromynic = textBoxPatromynic.Text;

            if (name == "" || lastname == "" || patromynic == "")
            {
                MessageBox.Show("Не заполнили имя, отчество или фамилию");
                return;
            }

            rowUser.Name = name;
            rowUser.Surname = lastname;
            rowUser.Patronymic = patromynic;
            rowUser.IDGender = (int)comboBoxGender.SelectedValue;
            rowUser.RegistrationDate = dateTimePickerRegisted.Value.ToString();

            try
            {
                //Перенести измененные данные в БД
                usersTableAdapter1.Update(rowUser);
                MessageBox.Show("Ваш профиль обновлен в системе");

                buttonBack.Enabled = true;		//Открыт доступ к функционалу менеджера
            }
            catch
            {
                MessageBox.Show("Ошибка при обновлении профиля");
            }
        }
        /// <summary>
        /// Подготовка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGlavManagerProfile_Load(object sender, EventArgs e)
        {
            //Начальные настройки интерфейса

            buttonBack.Enabled = true;

            //Данные из таблицы Users, которые нельзя менять
            users = this.usersTableAdapter1.GetData();
            rowUser = users.FindByID(ClassTotal.idUser);
            labelNumID.Text = "Ваш номер: " + rowUser.ID.ToString();
            labelLog_Email.Text = "Ваш логин: " + rowUser.Email;
            labelPass.Text = "Ваш пароль: " + rowUser.Password;
            dateTimePickerRegisted.Value = Convert.ToDateTime(rowUser.RegistrationDate);
            checkBoxStatus.Checked = rowUser.Active;
            //Настройка списков

            comboBoxGender.DataSource = genderTableAdapter1.GetData();
            comboBoxGender.DisplayMember = "Title";
            comboBoxGender.ValueMember = "ID";


            buttonUpdate.Visible = true;
           
            //Перенос данных из записи в элементы интерфейса
            textBoxPatromynic.Text = rowUser.Patronymic.ToString();
            textBoxFirstName.Text = rowUser.Name;
            textBoxLastname.Text = rowUser.Surname;
            comboBoxGender.SelectedValue = rowUser.IDGender;
        }
    }
}
