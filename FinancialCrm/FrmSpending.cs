using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmSpending : Form
    {
        public FrmSpending()
        {
            InitializeComponent();
        }

        public string UserName;
        public string Password;
        public void SpendingList()
        {
            var categories = db.TblCategories.ToList();
       
            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryId";


            var values = db.Spendings.Select((x => new
            {
                SpendingTitle = x.SpendingTitle,
                SpendingAmount = x.SpendingAmount,
                SpendingDate = x.SpendingDate,
                SpendingCategory = x.TblCategories.CategoryName
            })).ToList();
            dataGridView1.DataSource = values;


            var totalspendingbalance = db.Spendings.Sum(x => x.SpendingAmount);
            var totalbalance = db.Banks.Sum(x => x.BankBalance);
            lbltotalBalance.Text = totalbalance.ToString() + " TL";
            lblSpendingSum.Text = totalspendingbalance.ToString() + " TL";      lblSpendingSum.Text = totalspendingbalance.ToString() + " TL";
        }
        FinancialCrmEntities db=new FinancialCrmEntities();
        private void FrmSpending_Load(object sender, EventArgs e)
        {
            SpendingList();

           
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {

      
                int id = int.Parse(comboBox1.SelectedValue.ToString());
                var values = db.Spendings.Where(i => i.CategoryId == id).Select((x => new
                {
                    SpendingTitle = x.SpendingTitle,
                    SpendingAmount = x.SpendingAmount,
                    SpendingDate = x.SpendingDate,
                    SpendingCategory = x.TblCategories.CategoryName
                })).ToList();
            dataGridView1.DataSource = values;
        
           
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            DateTime period = DateTime.Parse(dtDate.Text);

            Spendings bills = new Spendings();
            bills.SpendingTitle = title;
            bills.SpendingAmount = amount;
            bills.SpendingDate = period;
            bills.CategoryId = int.Parse(comboBox1.SelectedValue.ToString());
            db.Spendings.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı bir şekilde yapıldı.", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SpendingList();
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var removevalue = db.Spendings.Find(id);
            db.Spendings.Remove(removevalue);
            db.SaveChanges();
            MessageBox.Show("Gider Başarılı bir şekilde sistemden silindi.", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            Frmbank frm = new Frmbank();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBillings frm = new FrmBillings();
            frm.Show();
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
            FrmBanks frm=new FrmBanks();
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
            UserLogin frm=new UserLogin();
            frm.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
