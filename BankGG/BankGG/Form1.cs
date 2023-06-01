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

        
        private void addAccbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 f = new Form2();
                f.Show();
            }
            catch(Exception eg)
            {
                MessageBox.Show("Unable to create account"+eg);
            }
        }

        private void fetchdetailsbtn_Click(object sender, EventArgs e)
        {
            DetailsForm f = new DetailsForm();
            f.Show();
        }

        private void delAccbtn_Click(object sender, EventArgs e)
        {
            DeleteForm f = new DeleteForm();
            f.Show();
        }

        private void withbtn_Click(object sender, EventArgs e)
        {
            Withdraw wd = new Withdraw();
            wd.Show();
        }
    }
}
