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
    public partial class FormHistoryLogin : Form
    {
        public FormHistoryLogin()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Bessonova483_ElectroShopDataSet.HistoryLoginDataTable loginHistorydata;
        private void FormHistoryLogin_Load(object sender, EventArgs e)
        {
            loginHistorydata = this.historyLoginTableAdapter1.GetData();
            this.dataGridViewHistory.DataSource = loginHistorydata;
            this.dataGridViewHistory.Columns["ID"].Visible = false;
            this.dataGridViewHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.labelFound.Text = "Общее кол-во входов: " + loginHistorydata.Count;
            this.comboBoxFilter.Text = this.comboBoxFilter.Items[0].ToString();
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxFilter.Text)
            {
                case "Все":
                    this.dataGridViewHistory.DataSource = loginHistorydata;
                    this.dataGridViewHistory.Text = "Общее кол-во входов:" + loginHistorydata.Count;
                    break;
                case "Успешные":
                    var filterTrue = loginHistorydata.Where(rec => rec.Result == true);
                    this.dataGridViewHistory.DataSource = filterTrue.CopyToDataTable();
                    this.labelFound.Text = "Общее кол-во успешным входов:" + filterTrue.Count();
                    break;
                case "Неуспешные":
                    var filterFalse = loginHistorydata.Where(rec => rec.Result == false);
                    this.dataGridViewHistory.DataSource = filterFalse.CopyToDataTable();
                    this.labelFound.Text = "Общее кол-во неуспешным входов:" + filterFalse.Count();
                    break;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchString = this.textBoxSearch.Text;
            var filter = loginHistorydata.Where(rec => rec.Login.Contains(searchString));
            if (filter.Count() != 0)
            {
                this.dataGridViewHistory.DataSource = filter.CopyToDataTable();
                this.dataGridViewHistory.Columns["ID"].Visible = false;
            }
            else
            {
                this.dataGridViewHistory.DataSource = null;
            }
            this.labelFound.Text = "Кол-во найденых входов:" + filter.Count();
        }
    }
}
