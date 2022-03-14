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
    public partial class FormManagerSale : Form
    {
        Bessonova483_ElectroShopDataSet.UsersDataTable datauser;
        Bessonova483_ElectroShopDataSet.UsersRow rowuser;

        public FormManagerSale()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Выйти из системы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Открытие формы профиля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonProfile_Click(object sender, EventArgs e)
        {
            FormManagerProductProfile fprofile = new FormManagerProductProfile();
            this.Hide();
            fprofile.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// открытие формы для работы с клиентами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClientWork_Click(object sender, EventArgs e)
        {
            FormClientWork fClient = new FormClientWork();
            this.Hide();
            fClient.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormManagerSale_Load(object sender, EventArgs e)
        {
            //Получили все данные
            datauser = this.usersTableAdapter1.GetData();
            //Ищем профиль того аккаунта, который вошел в систему
            rowuser = datauser.FindByID(ClassTotal.idUser);
           
        }
        /// <summary>
        /// Открытие формы добавления товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddObject_Click(object sender, EventArgs e)
        {
            FormObjectAdd fAddObject = new FormObjectAdd();
            this.Hide();
            fAddObject.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// Открытие формы заказов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOrders_Click(object sender, EventArgs e)
        {
            FormOrders fOrders = new FormOrders();
            this.Hide();
            fOrders.ShowDialog();
            this.Show();
        }
    }
}
