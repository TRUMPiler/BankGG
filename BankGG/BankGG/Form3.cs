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
    public partial class Form3 : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lebgS2v5HdHhJvVhaocd0yrS0YdN74XkvXS2tx9z",
            BasePath = "https://bankggs-113b4-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient customer;
        public Form3()
        {
            InitializeComponent();
        }

        private async void retriveBtn_Click(object sender, EventArgs e)
        {
            if(maskedTextBox1.Text==null)
            {
                MessageBox.Show("Please enter the account No");
                this.Close();
            }

            DataTable accountinfo = new DataTable();
            accountinfo.Columns.Add("Account no");
            accountinfo.Columns.Add("Name");
            accountinfo.Columns.Add("Birth Date");
            accountinfo.Columns.Add("Email");
            accountinfo.Columns.Add("Address");
            accountinfo.Columns.Add("Amount");
            accountinfo.Columns.Add("Account Type");

            try
            {
                FirebaseResponse responseGetdata = await customer.GetTaskAsync("Bankdetails/" + maskedTextBox1.Text);
                GGdata accountdata = responseGetdata.ResultAs<GGdata>();
            
            DataRow InfoRow = accountinfo.NewRow();
            InfoRow["Account no"] = accountdata.ID;
            InfoRow["Name"] = accountdata.Name;
            InfoRow["Birth Date"] = accountdata.BirthDate;
            InfoRow["Email"] = accountdata.Email;
            InfoRow["Address"] = accountdata.address;
            InfoRow["Amount"] = accountdata.Amount;
            InfoRow["Account Type"] = accountdata.AccountType;
            accountinfo.Rows.Add(InfoRow);
           
            dataGridView1.Visible = true;
            dataGridView1.DataSource = accountinfo;
            }
            catch (NullReferenceException ef)
            {
                MessageBox.Show("didnt work" + e);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            customer = new FireSharp.FirebaseClient(config);
        }

        private void FormcloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
