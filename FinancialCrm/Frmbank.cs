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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinancialCrm
{
    public partial class Frmbank : Form
    {
        public Frmbank()
        {
            InitializeComponent();
        }

        private void Frmbank_Load(object sender, EventArgs e)
        {
            Bank();
        }
        FinancialCrmEntities db = new FinancialCrmEntities();
        public void Bank()
        {
            var categories = db.Banks.ToList();

            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "BankTitle";
            comboBox1.ValueMember = "BankId";


            var values = db.Banks.ToList();
            dataGridView1.DataSource = values;




        }

        private void txtBillTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBillId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            Banks banks = new Banks();
            banks.BankTitle = txtBankTitle.Text;
            banks.BankAccountNumber = txtBankHesapNo.Text;
            banks.BankBalance = 0;
            db.Banks.Add(banks);
            db.SaveChanges();
            MessageBox.Show("Hesap No Başarı ile Eklendi.");
            Bank();

        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            var values = db.Banks.Where(x => x.BankId == int.Parse(txtBankId.Text)).FirstOrDefault();
            if (values != null)
            {
                values.BankTitle = txtBankTitle.Text;
                values.BankAccountNumber = txtBankHesapNo.Text;
                db.SaveChanges();

            }
            else
            {
                MessageBox.Show("Böyle Bir hesaba ulaşılamıyor.");
            }
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            var values = db.Banks.Where(x => x.BankId == int.Parse(txtBankId.Text)).FirstOrDefault();
            if (values != null)
            {
                db.Banks.Remove(values);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Böyle Bir hesaba ulaşılamıyor.");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBakiye_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProcessType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var bankprocess = new BankProcesses();
            bankprocess.BankId = int.Parse(comboBox1.SelectedValue.ToString());
            bankprocess.ProcessDate = DateTime.Now;
            bankprocess.Amount = int.Parse(txtBakiye.Text);
            bankprocess.Description = txtDescription.Text;
            bankprocess.ProcessType = cmbProcessType.Text;
            db.BankProcesses.Add(bankprocess);

            var values = db.Banks.Where(i=>i.BankId==bankprocess.BankId).FirstOrDefault();
            if (cmbProcessType.Text=="Gelen Havale")
            {
                values.BankBalance+=int.Parse(txtBakiye.Text);
            }
            if (cmbProcessType.Text == "Giden Havale")
            {
                values.BankBalance -= int.Parse(txtBakiye.Text);
            }
            db.SaveChanges(); Bank();
            MessageBox.Show("İşleminiz Başarıyla gerçekleştirilmiştir.");
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories form = new FrmCategories();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmbank form = new Frmbank();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBillings form = new FrmBillings();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSpending frm = new FrmSpending();
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
            FrmSettings frm = new FrmSettings();
         
            frm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
        }
    }
}
