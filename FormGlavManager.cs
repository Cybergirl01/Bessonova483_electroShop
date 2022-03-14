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
    public partial class FormGlavManager : Form
    {
        public FormGlavManager()
        {
            InitializeComponent();
        }
        Bessonova483_ElectroShopDataSet.UsersDataTable users;
        Bessonova483_ElectroShopDataSet.UsersRow rowusers;

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
            FormGlavManagerProfile fGprofile = new FormGlavManagerProfile();
            this.Hide();
            fGprofile.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGlavManager_Load(object sender, EventArgs e)
        {
            //Получили все данные
            users = this.usersTableAdapter1.GetData();
            //Ищем профиль того аккаунта, который вошел в систему
            rowusers = users.FindByID(ClassTotal.idUser);
          
        }
        /// <summary>
        /// Открытие формы для работы с документами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDocumentWork_Click(object sender, EventArgs e)
        {
            FormCreateDoc fDoc = new FormCreateDoc();
            this.Hide();
            fDoc.ShowDialog();
            this.Show();
        }
/// <summary>
/// Открытие формы к каталогу
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void buttonObjects_Click(object sender, EventArgs e)
        {
            FormObjects fCatalog = new FormObjects();
            this.Hide();
            fCatalog.ShowDialog();
            this.Show();
        }
    }
}
