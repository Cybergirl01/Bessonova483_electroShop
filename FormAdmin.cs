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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            FormHistoryLogin formHistory = new FormHistoryLogin();
            this.Hide();
            formHistory.ShowDialog();
            this.Show();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormAccountWork formAccount = new FormAccountWork();
            this.Hide();
            formAccount.ShowDialog();
            this.Show();
        }
    }
}
