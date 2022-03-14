using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bessonova483_ElectroShop
{
    public partial class FormObjects : Form
    {
       
        public FormObjects()
        {
            InitializeComponent();
          
        }
        Bessonova483_ElectroShopDataSet.ObjectsDataTable objects;
        Bessonova483_ElectroShopDataSet.CategoryDataTable categories;
        
        /// <summary>
        /// Назад в меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Фильтрация по комбобоксу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int searchcat = comboBoxCategory.SelectedIndex;        //Индекс элемента в списке
            if (searchcat == 0)
            {
                this.dataGridViewObjects.DataSource = objects;
            }
            else
            {
                var filterTrue = objects.Where(rec => rec.IDCategory == searchcat);
                this.dataGridViewObjects.DataSource = filterTrue.CopyToDataTable();
            }

        }
     
        /// <summary>
        /// Фильтр по текстбоксу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchString = this.textBoxSearch.Text;
            var filter = objects.Where(rec => rec.Title.Contains(searchString));
            if (filter.Count() != 0)
            {
                this.dataGridViewObjects.DataSource = filter.CopyToDataTable();
                this.dataGridViewObjects.Columns["ID"].Visible = false;
            }
            else
            {
                this.dataGridViewObjects.DataSource = null;
            }


        }
        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormObjects_Load(object sender, EventArgs e)
        {
            categories = categoryTableAdapter1.GetData();
            //Настроить список
            objects = objectsTableAdapter1.GetData();
            dataGridViewObjects.DataSource = objects;
            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = "Title";
            comboBoxCategory.ValueMember = "ID";
            comboBoxCategory.SelectedIndex = 0;			//Изначально - все
            comboBoxCategory_SelectedIndexChanged(null, null);	//Получить параметры фильтрации

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            FormOrders orders = new FormOrders();
            this.Hide();
            orders.ShowDialog();
            this.Show();
        }
    }
}
