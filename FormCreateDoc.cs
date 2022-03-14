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
        Bessonova483_ElectroShopDataSethome.OrdersDataTable orders;
        Bessonova483_ElectroShopDataSethome.ClientsDataTable client;
        Bessonova483_ElectroShopDataSethome.ClientsRow ClientsRow;
        private void dataGridViewOrders_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex;				//Получить номер выбранной строки
            //Отобразить в контейнере значения нужных полей
            textBoxIDorder.Text = dataGridViewOrders.Rows[numRow].Cells[1].Value.ToString();
            textBoxIDClient.Text = dataGridViewOrders.Rows[numRow].Cells[2].Value.ToString();
            textBoxIDObject.Text = dataGridViewOrders.Rows[numRow].Cells[3].Value.ToString();
            textBoxCount.Text = Convert.ToString(dataGridViewOrders.Rows[numRow].Cells[4].Value);
            textBoxSum.Text=Convert.ToString(dataGridViewOrders.Rows[numRow].Cells[5].Value);
            
        }

        private void buttonСreate_Click(object sender, EventArgs e)
        { int idOrder = Convert.ToInt32(textBoxIDorder.Text);
            ClientsRow = client.FindByID(Convert.ToInt32(textBoxIDClient));
            string FIO = ClientsRow.Surname + " " + ClientsRow.Name + " " + ClientsRow.Patronymic;
            DateTime date = DateTime.Now;
            string path = System.Windows.Forms.Application.StartupPath;
            string fileNamePattern = path + @"\Ресурсы\Otchet.docx";
            string fileNameTarget = path + @"\Ресурсы\Otchetdoc" + idOrder + ".doc";
            System.IO.File.Copy(fileNamePattern, fileNameTarget, true);

            try
            {
                word.Application wordApp = new word.Application();
                wordApp.Visible = false;
                word.Document worddoc = null;
                worddoc = wordApp.Documents.Open(fileNameTarget);
                worddoc.Activate();
                word.Bookmarks bookmarks = worddoc.Bookmarks;
                worddoc.Bookmarks["IDOrder"].Range.Text = idOrder.ToString();
                worddoc.Bookmarks["IDDate"].Range.Text = DateTime.Now.ToString();
                worddoc.Bookmarks["IDOtchet"].Range.Text = idOrder.ToString();
                worddoc.Bookmarks["IDClientr"].Range.Text = FIO.ToString();
                worddoc.Bookmarks["Timedelivering"].Range.Text = "10";
                worddoc.Bookmarks["Getorderdate"].Range.Text = Convert.ToString(date.AddDays(10.0));
                worddoc.Close();
                wordApp.Quit();
            }
            catch
            {
                MessageBox.Show("Отсутствует приложение Word");
                return;
            }
        }

        private void FormCreateDoc_Load(object sender, EventArgs e)
        {
            client = clientsTableAdapter1.GetData();
            dataGridViewOrders.DataSource = client;
            this.dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Select();		//Выбрать первую строку


        }
    }
}
