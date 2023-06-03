using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace BankGG
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        
       
  

        private void withbtn_Click(object sender, EventArgs e)
        {
            Withdraw wd = new Withdraw();
            wd.Show();
        }

        private void depbtn_Click(object sender, EventArgs e)
        {
            Deposit d = new Deposit();
            d.Show();
        }

      

        private void AddAccountBtn_Click_1(object sender, EventArgs e)
        {

            try
            {
                AddAccount f = new AddAccount();
                f.Show();
            }
            catch (Exception eg)
            {
                MessageBox.Show("Unable to create account" + eg);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteForm f = new DeleteForm();
            f.Show();
        }

        private void ViewDetails_Click(object sender, EventArgs e)
        {
            DetailsForm f = new DetailsForm();
            f.Show();
        }

        private void WithCashBtn_Click(object sender, EventArgs e)
        {
            Withdraw wd = new Withdraw();
            wd.Show();
        }

        private void Depositbtn_Click(object sender, EventArgs e)
        {
            Deposit f = new Deposit();
            f.Show();
        }

        private void FormCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
