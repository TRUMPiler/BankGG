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
    public partial class DetailsForm : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lebgS2v5HdHhJvVhaocd0yrS0YdN74XkvXS2tx9z",
            BasePath = "https://bankggs-113b4-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient customer;
        public DetailsForm()
        {
            InitializeComponent();
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            customer = new FireSharp.FirebaseClient(config);
        }

        private void FormcloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Detailsbtn_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == null)
            {
                MessageBox.Show("Please enter the account No");
                this.Close();
            }

            try
            {
                FirebaseResponse responseGetdata = await customer.GetTaskAsync("Bankdetails/" + maskedTextBox1.Text);
                GGdata accountdata = responseGetdata.ResultAs<GGdata>();

                Accnolbl.Visible = false;
                maskedTextBox1.Visible = false;
                Detailsbtn.Visible = false;
                AccoNo.Visible = true;
                AccountNoislbl.Visible = true;
                AccountNameislbl.Visible = true;
                AccNamelbl.Visible = true;
                birthdateislbl.Visible = true;
                Birthdatelbl.Visible = true;
                emaillbl.Visible = true;
                Emailislbl.Visible = true;
                Addressislbl.Visible = true;
                Addresslbl.Visible = true;
                Amountislbl.Visible = true;
                Amount.Visible = true;
                Accounttypeislbl.Visible = true;
                Accounttype.Visible = true;
                AccoNo.Text = accountdata.ID.ToString();
                AccNamelbl.Text = accountdata.Name;
                Birthdatelbl.Text = accountdata.BirthDate;
                emaillbl.Text = accountdata.Email;
                Addresslbl.Text = accountdata.address;
                Amount.Text = accountdata.Amount;
                Accounttype.Text = accountdata.AccountType;
            }
            catch(NullReferenceException){

                MessageBox.Show("Account not Found Or Network is unstable");
                this.Close();

            }
               
            
                
            
                
            
                
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FORMcloseBTNN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
