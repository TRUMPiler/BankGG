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
    public partial class Form1 : Form
    {
        public Form1()
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
            Form3 f = new Form3();
            f.Show();
        }

        private void delAccbtn_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
        }
    }
}
