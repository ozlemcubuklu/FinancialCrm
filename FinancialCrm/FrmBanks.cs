﻿using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        public string UserName;
        public string Password;
        FinancialCrmEntities db =new FinancialCrmEntities();
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            var ziraatbankBalance = db.Banks.Where(x=>x.BankTitle== "Ziraat Bankası").Select(y=>y.BankBalance).FirstOrDefault();
            var vakifbankBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).FirstOrDefault();
            var isbankasiBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();
            lblVakifBankBalance.Text = vakifbankBalance.ToString() + " TL";
            lblİsBankBalance.Text = isbankasiBalance.ToString() + " TL";
            lblZiraatBankBalance.Text = ziraatbankBalance.ToString() + " TL";



            //banka hareketleri
            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + "  " + bankProcess1.Amount + bankProcess1.ProcessDate;


            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + "  " + bankProcess2.Amount + bankProcess2.ProcessDate;  

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + "  " + bankProcess3.Amount + bankProcess3.ProcessDate;
             var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + "  " + bankProcess4.Amount + bankProcess4.ProcessDate;
            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + "  " + bankProcess5.Amount + bankProcess5.ProcessDate;

        }

        private void button2_Click(object sender, EventArgs e)
        {   
            Frmbank frm =  new  Frmbank();
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
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBillings frm = new FrmBillings();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
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
            UserLogin frm = new UserLogin();
            frm.Show();
            this.Hide();
        }
    }
}
