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
        Bessonova483_ElectroShopDataSet.ClientsDataTable Clients;
        Bessonova483_ElectroShopDataSet.ObjectsRow objectsRow;
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
            dataGridViewObjects.DataSource = objectsinorder;
            Clients = clientsTableAdapter2.GetData();
            comboBoxClient.DataSource = Clients;
            comboBoxClient.DisplayMember = "Surname";
            comboBoxClient.ValueMember = "ID";


        }
        /// <summary>
        /// Заказ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFormOrder_Click(object sender, EventArgs e)
        {
            int idClient = (int)comboBoxClient.SelectedIndex + 1;
            int idObject = Convert.ToInt32(textBoxID.Text);
            int count = (int)numericUpDownCount.Value;
            try
            {
                ordersTableAdapter1.Insert(idClient, idObject, count, Convert.ToDecimal(textBoxItog.Text));
                MessageBox.Show("Операция прошла успешно.");
            }
            catch
            {
                MessageBox.Show("Операция прошла не успешно. Что-то не так.");
                return;
            }


        }
        /// <summary>
        /// кол-во штук
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {
            decimal summaTotal;
            decimal sum;
            objectsRow = objectsinorder.FindByID(Convert.ToInt32(textBoxID.Text));
            sum = Convert.ToDecimal(objectsRow.Cost);
            summaTotal = sum * numericUpDownCount.Value;
            this.textBoxItog.Text = summaTotal.ToString();

        }
        /// <summary>
        /// Извлечение данных из таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewObjects_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex;				//Получить номер выбранной строки
            //Отобразить в контейнере значения нужных полей
            textBoxID.Text = dataGridViewObjects.Rows[numRow].Cells[0].Value.ToString();
            textBoxObject.Text = dataGridViewObjects.Rows[numRow].Cells[1].Value.ToString();
            textBoxCost.Text = dataGridViewObjects.Rows[numRow].Cells[6].Value.ToString();

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
    }
 }

