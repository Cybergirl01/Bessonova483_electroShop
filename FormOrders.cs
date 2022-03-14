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
    public partial class FormOrders : Form
    {
        Bessonova483_ElectroShopDataSet.ObjectsDataTable objectsinorder;
        Bessonova483_ElectroShopDataSet.ClientsRow Clients;
        decimal finsum;
        public FormOrders()
        {
            InitializeComponent();
        }
        /// <summary>
        /// загузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormOrders_Load(object sender, EventArgs e)
        {
            objectsinorder = objectsTableAdapter1.GetData();
            comboBoxObject.DataSource = objectsinorder;
            comboBoxObject.DisplayMember = "Title";
            comboBoxObject.ValueMember = "ID";
            Clients = clientsTableAdapter2.GetData().FindByID(ClassTotal.idUser);
            comboBoxClient.DataSource = Clients;
            comboBoxClient.DisplayMember = "Surname" + " " + "Name" + " " + "Patronymic";
            comboBoxClient.ValueMember = "ID";

        }
        /// <summary>
        /// Заказ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFormOrder_Click(object sender, EventArgs e)
        {
            int idClient = (int)comboBoxClient.SelectedIndex;
            int idObject = (int)comboBoxObject.SelectedIndex;

            int count = (int)numericUpDownCount.Value;

            decimal fin = Convert.ToDecimal(textBoxFInalSum.Text);

            try
            {
                ordersTableAdapter1.Insert(idClient, idObject, count, fin);
                MessageBox.Show("Операция прошла успешно.");
            }
            catch
            {
                MessageBox.Show("Операция прошла не успешно. Что-то не так.");
                return;
            }

        }
        /// <summary>
        /// Изменение суммы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal summaTotal;
            decimal sum;
            int index = comboBoxObject.SelectedIndex;		//Индекс элемента в списке
            if (index == -1)
            {
                MessageBox.Show("Выбирите товар.");
            }
            else
            {
                var filter = objectsinorder.Where(x => x.ID == index);
                sum = filter.ElementAt(0).Cost;

                if (numericUpDownCount.Value == 0)
                {
                    summaTotal = sum;
                }
                summaTotal = sum * numericUpDownCount.Value;
                this.labelItogo.Text = summaTotal.ToString();

            }
        }
    }
}
