using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        FinancialCrmEntities db = new FinancialCrmEntities();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            var values = db.Users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
            if (values != null)
            {
                FrmDashboard frm = new FrmDashboard();
                FrmSettings settings = new FrmSettings();
                settings.username = username;
                settings.password = password;
                frm.UserName = username;
                frm.Password = password;
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hatalı Giriş", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }


        }
    }
}
