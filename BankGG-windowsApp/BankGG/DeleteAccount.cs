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

     

        private void Form5_Load(object sender, EventArgs e)
        {
            customer = new FireSharp.FirebaseClient(config);
        }

     

        private async void SearchBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                FirebaseResponse responseGetdata = await customer.GetTaskAsync("Bankdetails/" + maskedTextBox1.Text); ;
                GGdata accountdata = responseGetdata.ResultAs<GGdata>();








                amount = Convert.ToInt32(accountdata.Amount);
                Acconolbl.Visible = false;
                maskedTextBox1.Visible = false;
                SearchBtn.Visible = false;
                AccNamelbl.Visible = true;
                AccountNameislbl.Visible = true;
                DeleteBtn.Visible = true;
                AccoNo.Visible = true;
                AccountNoislbl.Visible = true;
                AccoNo.Text = accountdata.ID.ToString();
                AccNamelbl.Text = accountdata.Name;
            }
            catch (NullReferenceException es)
            {
                MessageBox.Show("Account not found or an network is unstable");
            }
        }

        private async void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            if(amount == 0)
            {
                try
                {
                    if(MessageBox.Show("Are you sure You want to delete your account", "Confirmation", MessageBoxButtons.OKCancel)==DialogResult.OK)
                    {
                        FirebaseResponse response1 = await customer.DeleteTaskAsync("Bankdetails/" + maskedTextBox1.Text);
                        MessageBox.Show("Account Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Account deletion operation was Cancelled by the user");
                    }
                    
                   
                }
                catch (NullReferenceException eg)
                {
                    MessageBox.Show("Could not delete the account Operation failed");
                }
            }
            else
            {
                MessageBox.Show("Account balance is not Zero for account to be delete please withdraw all cash for Account to be deleted");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
