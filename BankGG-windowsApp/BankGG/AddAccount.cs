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
    public partial class AddAccount : Form
    {
        string status = "";
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lebgS2v5HdHhJvVhaocd0yrS0YdN74XkvXS2tx9z",
            BasePath = "https://bankggs-113b4-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient customer;
        public AddAccount()
        {
            InitializeComponent();
        }

        private async void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (FirstNtext.Text == null || SecondNtext.Text == null || ThirdNtext.Text == null || accTypeCB.SelectedText == null || Adresstext.Text == null || Emailtext.Text == null || maskedTextBox1.Text == null || Birthdate.SelectionStart == null)
            {
                MessageBox.Show("fill all details");
            }
            else
            {
                string date = Birthdate.SelectionRange.Start.ToString();
                Data get = new Data();

                try
                {
                    FirebaseResponse respBack = await customer.GetTaskAsync("AccountNos");
                    get = respBack.ResultAs<Data>();
                }
                catch (NullReferenceException eg)
                {
                    MessageBox.Show("couldn't fetch details for Adding your account please try again later");
                    this.Close();
                }

                var datalayer = new GGdata
                {
                    ID = get.LastAccountnoadded + 1,
                    Name = FirstNtext.Text + " " + SecondNtext.Text + " " + ThirdNtext.Text,
                    Email = Emailtext.Text,
                    address = Adresstext.Text,
                    AccountType = accTypeCB.SelectedItem.ToString(),
                    Amount = maskedTextBox1.Text,
                    BirthDate = date
                };
                var obj = new Data
                {
                    LastAccountnoadded = datalayer.ID
                };
                try
                {
                    SetResponse respGive = await customer.SetTaskAsync("Bankdetails/" + datalayer.ID, datalayer);
                    GGdata result = respGive.ResultAs<GGdata>();
                    respGive = await customer.SetTaskAsync("AccountNos", obj);
                    Data result1 = respGive.ResultAs<Data>();
                    MessageBox.Show("Bank Account of " + result.Name + " created succesfully");
                }
                catch (NullReferenceException es)
                {
                    MessageBox.Show("An error occoured while Adding account");
                    this.Close();
                }

                this.Close();
            }
            
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            customer = new FireSharp.FirebaseClient(config);

            
          
            if (customer!=null)
                {
                    status = "connected";
                }
                else
                {
                    status = "Not connected";
                MessageBox.Show(status+"\n form cannot opened");
                this.Close();
            }
           
        }
    }
}
