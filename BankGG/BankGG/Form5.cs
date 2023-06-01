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
    public partial class DeleteForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lebgS2v5HdHhJvVhaocd0yrS0YdN74XkvXS2tx9z",
            BasePath = "https://bankggs-113b4-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient customer;
        int amount = 0;
        public DeleteForm()
        {
            InitializeComponent();
        }

        private async void SearchBtn_Click(object sender, EventArgs e)
        {

            try
            {
                FirebaseResponse responseGetdata = await customer.GetTaskAsync("Bankdetails/" + maskedTextBox1.Text); ;
                GGdata accountdata = responseGetdata.ResultAs<GGdata>();




                DataTable accountinfo = new DataTable();
                accountinfo.Columns.Add("Account no");
                accountinfo.Columns.Add("Name");
                accountinfo.Columns.Add("Birth Date");
                accountinfo.Columns.Add("Email");
                accountinfo.Columns.Add("Address");
                accountinfo.Columns.Add("Amount");
                accountinfo.Columns.Add("Account Type");

                DataRow InfoRow = accountinfo.NewRow();
                InfoRow["Account no"] = accountdata.ID;
                InfoRow["Name"] = accountdata.Name;
                InfoRow["Birth Date"] = accountdata.BirthDate;
                InfoRow["Email"] = accountdata.Email;
                InfoRow["Address"] = accountdata.address;
                InfoRow["Amount"] = accountdata.Amount;
                InfoRow["Account Type"] = accountdata.AccountType;
                accountinfo.Rows.Add(InfoRow);
                amount = Convert.ToInt32(accountdata.Amount);
                dataGridView1.Visible = true;
                dataGridView1.DataSource = accountinfo;
                SearchBtn.Visible = false;
                dataGridView1.Visible = true;
                DeleteBtn.Visible = true;
            }
            catch(NullReferenceException es)
            {
                MessageBox.Show("Account not found or an network is unstable");
            }
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            customer = new FireSharp.FirebaseClient(config);
        }

        private async void  DeleteBtn_Click(object sender, EventArgs e)
        {
            if (amount==0)
            {
                try
                {
                    FirebaseResponse response1 = await customer.DeleteTaskAsync("Bankdetails/" + maskedTextBox1.Text);
                    MessageBox.Show("Account Deleted");
                }catch(NullReferenceException eg)
                {
                    MessageBox.Show("Could not delete the account Operation failed");
                }
            }
            else 
            {
                MessageBox.Show("Account balance is not Zero for account to be delete please withdraw all cash for Account to be deleted");
            }
        }
    }
}
