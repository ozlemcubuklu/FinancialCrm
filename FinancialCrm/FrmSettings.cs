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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        public string username;
        public string password;
        public void List()
        {
            var values = db.Users.Select(i => new { UserName = i.Username }).ToList();
            dataGridView1.DataSource = values;
        }
        private void FrmSettings_Load(object sender, EventArgs e)
        {


            if (username != null || password != null)
            {
                txtUserName.Text = username;
                txtPassword.Text = password;
            }
            List();


        }
        FinancialCrmEntities  db=new FinancialCrmEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            string degisenusername=txtUserName.Text;
            string degisenpassword=txtPassword.Text;

            var value = db.Users.Where(i => i.Username == username && i.Password == password).FirstOrDefault();
            if (value!=null)
            {

 value.Username = degisenusername;
            value.Password = degisenpassword;  db.SaveChanges();
                txtUserName.Text = value.Username;
                txtPassword.Text = value.Password;
            }
            else
            {
                MessageBox.Show("Böyle Bir Kullanıcı Mevcut degil..", "Yeni Kullanıcı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            List();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newuser=txtUserName.Text;
            string newpassword=txtPassword.Text;
            var value = db.Users.Where(i=>i.Username==newuser).FirstOrDefault();
            if (value!=null)
            {
                MessageBox.Show("Böyle Bir Kullanıcı Mevcut..","Yeni Kullanıcı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                Users user = new Users() { Username = newuser, Password = newpassword };

                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Kayıt Eklendi..", "Yeni Kullanıcı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            List();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSpending frm = new FrmSpending();
            frm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frmbank frm = new Frmbank();
            frm.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FrmBillings frm = new FrmBillings();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
         
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UserLogin frm = new UserLogin();
            frm.Show();
            this.Hide();
        }
    }
}
