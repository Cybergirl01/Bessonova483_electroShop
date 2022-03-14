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
    public partial class FormUpdateObject : Form
    {
        Bessonova483_ElectroShopDataSet.ObjectsDataTable objects;
        Bessonova483_ElectroShopDataSet.ObjectsRow ObjectsRow;
        public FormUpdateObject()
        {
            InitializeComponent();
        }
        /// <summary>
        /// назад в меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Загрузка формы 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormUpdateObject_Load(object sender, EventArgs e)
        {
            objects = objectsTableAdapter2.GetData();
            dataGridViewObjects.DataSource = objects;
            textBoxNameObject.Enabled = false;
            comboBoxCategory.Enabled = false;
            comboBoxCompany.Enabled = false;
            dateTimePickerMade.Enabled = false;
            dateTimePickerResolution.Enabled = false;
            this.dataGridViewObjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewObjects.Select();		//Выбрать первую строку
        }
        /// <summary>
        /// Обновление цены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdate_Click(object sender, EventArgs e)
        {if (textBoxCost.Text == "")
            {
                MessageBox.Show("Заполните цену.");
            }
            string cost = textBoxCost.Text;
            ObjectsRow.Cost = Convert.ToDecimal(cost);
            try
            {
                objectsTableAdapter2.Update(ObjectsRow);
                MessageBox.Show("Операция прошла удачно.");
            }
            catch
            {
                MessageBox.Show("Операция прошла не удачно.");
                return;
            }
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
            textBoxNameObject.Text = dataGridViewObjects.Rows[numRow].Cells[1].Value.ToString();
            comboBoxCategory.Text = dataGridViewObjects.Rows[numRow].Cells[2].Value.ToString();
            comboBoxCompany.Text = dataGridViewObjects.Rows[numRow].Cells[3].Value.ToString();
            dateTimePickerMade.Value = Convert.ToDateTime(dataGridViewObjects.Rows[numRow].Cells[4].Value);
            dateTimePickerResolution.Value = Convert.ToDateTime(dataGridViewObjects.Rows[numRow].Cells[5].Value);
            textBoxCost.Text = dataGridViewObjects.Rows[numRow].Cells[6].Value.ToString();

        }
    }
}
