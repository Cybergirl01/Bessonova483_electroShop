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
    public partial class FormManagerProductProfile : Form
    {

        //По таблице Users
        Bessonova483_ElectroShopDataSet.UsersDataTable dataUsers;	//все данные из таблицы Users
        Bessonova483_ElectroShopDataSet.UsersRow rowUser;			//Отдельная строка таблицы

        public FormManagerProductProfile()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
        /// <summary>
        /// Загрузка данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormManagerProductProfile_Load(object sender, EventArgs e)
        {
            //Начальные настройки интерфейса
           
            buttonBack.Enabled = true;

            //Данные из таблицы Users, которые нельзя менять
            dataUsers = this.usersTableAdapter1.GetData();
            rowUser = dataUsers.FindByID(ClassTotal.idUser);
            labelNumID.Text = "Ваш номер: " + rowUser.ID.ToString();
            labelLog_Email.Text = "Ваш логин: " + rowUser.Email;
            labelPass.Text = "Ваш пароль: " + rowUser.Password;
            dateTimePickerRegisted.Value = Convert.ToDateTime(rowUser.RegistrationDate);
            checkBoxStatus.Checked = rowUser.Active;
            //Настройка списков
            
            comboBoxGender.DataSource = genderTableAdapter2.GetData();
            comboBoxGender.DisplayMember = "Title";
            comboBoxGender.ValueMember = "ID";

        
                    buttonUpdate.Visible = true;
                    
                    //Поиск среди них запись с нужным ID
           
                    //Перенос данных из записи в элементы интерфейса
                    textBoxPatromynic.Text = rowUser.Patronymic.ToString();
                    textBoxFirstName.Text = rowUser.Name;
                    textBoxLastname.Text = rowUser.Surname;
                    comboBoxGender.SelectedValue = rowUser.IDGender;
           
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
            


            if (name == "" || lastname == "" || patromynic =="")
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

       
    }
}
