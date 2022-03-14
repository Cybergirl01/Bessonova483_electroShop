using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;

namespace Bessonova483_ElectroShop
{
    public partial class FormCreateDoc : Form
    {
        public FormCreateDoc()
        {
            InitializeComponent();
        }
        static string path = System.Windows.Forms.Application.StartupPath;
        Bessonova483_ElectroShopDataSet.OrdersDataTable orders;
        Bessonova483_ElectroShopDataSet.ClientsDataTable client;
        Bessonova483_ElectroShopDataSet.ClientsRow ClientsRow;
        word.Application wordApp;
        word.Bookmarks bookmarks;
        word.Document worddoc;
        /// <summary>
        /// Извлечение из таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewOrders_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex;				//Получить номер выбранной строки
            //Отобразить в контейнере значения нужных полей
            textBoxIDorder.Text = dataGridViewOrders.Rows[numRow].Cells[0].Value.ToString();
            textBoxIDClient.Text = dataGridViewOrders.Rows[numRow].Cells[1].Value.ToString();
            textBoxIDObject.Text = dataGridViewOrders.Rows[numRow].Cells[2].Value.ToString();
            textBoxCount.Text = Convert.ToString(dataGridViewOrders.Rows[numRow].Cells[3].Value);
            textBoxSum.Text=Convert.ToString(dataGridViewOrders.Rows[numRow].Cells[4].Value);
            
        }
        /// <summary>
        /// Создание отчета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonСreate_Click(object sender, EventArgs e)
        {   int idOrder = Convert.ToInt32(textBoxIDorder.Text);
            ClientsRow = client.FindByID(Convert.ToInt32(textBoxIDClient.Text));
            string FIO = ClientsRow.Surname + " " + ClientsRow.Name + " " + ClientsRow.Patronymic;
            DateTime date = DateTime.Now;
            string fileNamePattern = path + @"\Ресурсы\Otchet.docx";
            string fileNameTarget = path + @"\Ресурсы\Otchetdoc\" + idOrder + ".doc";
            try
            {
                System.IO.File.Copy(fileNamePattern, fileNameTarget, true);
            }
            catch
            {
                MessageBox.Show("Не удалось копировать шаблон");
                return;
            }
            

            try
            {
                wordApp = new word.Application();
                wordApp.Visible = false;
                worddoc = null;
                worddoc = wordApp.Documents.Open(fileNameTarget);
                worddoc.Activate();
                bookmarks = worddoc.Bookmarks;
                worddoc.Bookmarks["IDOrder"].Range.Text = idOrder.ToString();
                worddoc.Bookmarks["IDDate"].Range.Text = DateTime.Now.ToString();
                worddoc.Bookmarks["IDOtchet"].Range.Text = idOrder.ToString();
                worddoc.Bookmarks["IDClient"].Range.Text = FIO.ToString();
                worddoc.Bookmarks["Timedelivering"].Range.Text = "10";
                worddoc.Bookmarks["Getorderdate"].Range.Text = Convert.ToString(date.AddDays(10.0));
                worddoc.Close();
                wordApp.Quit();
            }
            catch
            {
                MessageBox.Show("Отсутствует приложение Word");
                worddoc.Close();
                wordApp.Quit();
                return;
            }
            worddoc.Close();
            wordApp.Quit();
        }
        /// <summary>
        /// Загрызка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCreateDoc_Load(object sender, EventArgs e)
        {
            client = clientsTableAdapter2.GetData();
            orders = ordersTableAdapter1.GetData();
            dataGridViewOrders.DataSource = orders;
            this.dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Select();		//Выбрать первую строку


        }
        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
