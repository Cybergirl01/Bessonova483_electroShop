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
    public partial class FormAuthorization : Form
    {
        int TimeLeft;
        int falseentercount = 0;

    
        Bessonova483_ElectroShopDataSet.UsersDataTable users;
        Bessonova483_ElectroShopDataSet.HistoryLoginRow historyLogin;
        Bessonova483_ElectroShopDataSet.HistoryLoginDataTable histories;

        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string log, pas;
            pas = this.textBoxPas.Text;
            log = this.textBoxLog.Text;
            users = this.usersTableAdapter1.GetData();
            DateTime dt = DateTime.Now;
            TimeSpan span = dt.TimeOfDay;

            var filter = users.Where(rec => rec.Email == log && rec.Password == pas);
            if (filter.Count() == 0)
            {
                MessageBox.Show("Таких данных нет.");
                try
                {
                    historyLoginTableAdapter1.Insert(log, span, false);
                }
                catch
                {
                    MessageBox.Show("Ошибка в истории входа.");
                }
                falseentercount++;
                if (falseentercount >= 3)
                {
                    switch (falseentercount)
                    {
                        case 3:
                            MessageBox.Show("Вы заблокированны в течении 15 сек.");
                            TimeLeft = 15;
                            timersecleft.Start();

                            break;
                        case 4:
                            MessageBox.Show("Вы заблокированны в течении 20 сек.");
                            TimeLeft = 20;
                            timersecleft2.Start();

                            break;
                        case 5:
                            MessageBox.Show("Вы ввели неверный пароль или логин в третий раз. Программа закрывается.");
                            falseentercount = 0;
                            this.Close();
                            break;
                    }
                }
            }

            else
            {
                try
                {
                    historyLoginTableAdapter1.Insert(log, span, true);
                }
                catch
                {
                    MessageBox.Show("Ошибка в истории входа");
                }
                ClassTotal.idUser = filter.ElementAt(0).ID;
                ClassTotal.idRole = filter.ElementAt(0).IDRole;
                ClassTotal.login = filter.ElementAt(0).Email;
                switch (ClassTotal.idRole)
                {
                    case 1:
                        MessageBox.Show("Вы вошли как менеджер по продажи.");
                        FormManagerSale fm = new FormManagerSale();
                        this.Hide();
                        fm.ShowDialog();
                        this.Show();
                        break;
                    case 2:
                        MessageBox.Show("Вы вошли как Главный менеджер.");
                        FormGlavManager fGM = new FormGlavManager();
                        this.Hide();
                        fGM.ShowDialog();
                        this.Show();
                        break;
                    case 3:
                        MessageBox.Show("Вы вошли как Администратор.");
                        FormAdmin fa = new FormAdmin();
                        this.Hide();
                        fa.ShowDialog();
                        this.Show();
                        break;

                }

            }
        }

        private void buttonClosetheProgramm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timersecleft_Tick(object sender, EventArgs e)
        {
            if (TimeLeft > 0)
            {
                this.textBoxLog.Enabled = false;
                this.textBoxPas.Enabled = false;
                this.buttonLogIn.Enabled = false;
                this.checkBoxShowPass.Enabled = false;
                TimeLeft = TimeLeft - 1;
            }
            else
            {
                this.textBoxLog.Enabled = true;
                this.textBoxPas.Enabled = true;
                this.buttonLogIn.Enabled = true;
                this.checkBoxShowPass.Enabled = true;
                timersecleft.Stop();
            }
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            users = this.usersTableAdapter1.GetData();
            histories = this.historyLoginTableAdapter1.GetData();

            try
            {

                for (int i = 0; i < histories.Count; i++)
                {
                    historyLogin = histories.ElementAt(i);
                    this.historyLoginTableAdapter1.Delete(historyLogin.ID, historyLogin.Login, historyLogin.TimeLog, historyLogin.Result);
                }
            }
            catch
            {
                MessageBox.Show("Не удалось удалить из истории входов.");

            }

            this.checkBoxShowPass.Checked = false;
            this.textBoxPas.PasswordChar = '*';
        }

        private void timersecleft2_Tick(object sender, EventArgs e)
        {
            if (TimeLeft > 0)
            {
                this.textBoxLog.Enabled = false;
                this.textBoxPas.Enabled = false;
                this.buttonLogIn.Enabled = false;
                this.checkBoxShowPass.Enabled = false;
                TimeLeft = TimeLeft - 1;
            }
            else
            {
                this.textBoxLog.Enabled = true;
                this.textBoxPas.Enabled = true;
                this.buttonLogIn.Enabled = true;
                this.checkBoxShowPass.Enabled = true;
                timersecleft2.Stop();
            }
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                this.textBoxPas.PasswordChar = (char)0;
            }
            else
            {
                this.textBoxPas.PasswordChar = '*';
            }
        }
    }
}
