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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories form=new FrmCategories();
            form.Show();
            this.Hide();

        }
        FinancialCrmEntities db=new FinancialCrmEntities();

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.TblCategories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
  
            TblCategories bills = new TblCategories();
            bills.CategoryName = title;
            db.TblCategories.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı bir şekilde eklendi.", "Kategori", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var removevalue = db.TblCategories.Find(id);
            db.TblCategories.Remove(removevalue);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı bir şekilde sistemden silindi.", "Kategori", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
         
            int id = int.Parse(txtBillId.Text);
            var updatevalue = db.TblCategories.Find(id);

            updatevalue.CategoryName = title;

            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı bir şekilde sistemde güncellendi.", "Kategori", MessageBoxButtons.OK, MessageBoxIcon.Information);


            var values = db.TblCategories.ToList();
            dataGridView1.DataSource = values;
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

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSpending frm = new FrmSpending();
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
            UserLogin frm = new UserLogin();
            frm.Show();
            this.Hide();
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {

        }
    }
}
