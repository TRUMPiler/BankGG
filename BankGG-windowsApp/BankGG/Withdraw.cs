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
    public partial class Withdraw : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lebgS2v5HdHhJvVhaocd0yrS0YdN74XkvXS2tx9z",
            BasePath = "https://bankggs-113b4-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient customer;
        int amount = 0;
        public Withdraw()
        {
            InitializeComponent();
        }
        GGdata accountdata = null;
        

        private void Withdraw_Load(object sender, EventArgs e)
        {
            customer = new FireSharp.FirebaseClient(config);
        }

        private async void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(WithAmountMB.Text)<=amount)
            {
                var UpdatedAmount = new GGdata
                {
                    ID = accountdata.ID,
                    Name = accountdata.Name,
                    Email = accountdata.Email,
                    address = accountdata.address,
                    AccountType = accountdata.AccountType,
                    Amount = Convert.ToString(amount - Convert.ToInt32(WithAmountMB.Text)),
                    BirthDate =accountdata.BirthDate
                };
                try
                {
                    FirebaseResponse responseUpdate = await customer.UpdateTaskAsync("Bankdetails/" + accountdata.ID, UpdatedAmount);
                    GGdata Updatedata = responseUpdate.ResultAs<GGdata>();
                    MessageBox.Show("Withdrawal Success" );
                }
                catch(NullReferenceException es)
                {
                    MessageBox.Show("Withdrawal Failed");
                }
            }
            else
            {
                MessageBox.Show("Amount Insufficient or invalid");
                this.Close();
            }
            this.Close();
        }

        private async void SearchBtn_Click_1(object sender, EventArgs e)
        {

            try
            {
                FirebaseResponse responseGetdata = await customer.GetTaskAsync("Bankdetails/" + AccnoTB.Text); ;
                accountdata = responseGetdata.ResultAs<GGdata>();








                amount = Convert.ToInt32(accountdata.Amount);
                Balancelbl.Text = Convert.ToString(amount);
                SearchBtn.Visible = false;
                enteraccnolbl.Visible = false;
                AccnoTB.Visible = false;
                WithAmountMB.Visible = true;
                WithBtn.Visible = true;
                Balancelbl.Visible = true;
                AccountBallbl.Visible = true;
            }
            catch (NullReferenceException es)
            {
                MessageBox.Show("Account not found or an network is unstable");
                this.Close();
            }
        }

        private async void WithBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(WithAmountMB.Text) <= amount)
            {
                var UpdatedAmount = new GGdata
                {
                    ID = accountdata.ID,
                    Name = accountdata.Name,
                    Email = accountdata.Email,
                    address = accountdata.address,
                    AccountType = accountdata.AccountType,
                    Amount = Convert.ToString(amount - Convert.ToInt32(WithAmountMB.Text)),
                    BirthDate = accountdata.BirthDate
                };
                try
                {
                    FirebaseResponse responseUpdate = await customer.UpdateTaskAsync("Bankdetails/" + accountdata.ID, UpdatedAmount);
                    GGdata Updatedata = responseUpdate.ResultAs<GGdata>();
                    MessageBox.Show("Withdrawal Success");
                }
                catch (NullReferenceException es)
                {
                    MessageBox.Show("Withdrawal Failed");
                }
            }
            else
            {
                MessageBox.Show("Amount Insufficient or invalid");
                this.Close();
            }
            this.Close();
        }

        private void FormCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
