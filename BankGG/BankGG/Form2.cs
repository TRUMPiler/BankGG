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
    public partial class Form2 : Form
    {
        string status = "";
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lebgS2v5HdHhJvVhaocd0yrS0YdN74XkvXS2tx9z",
            BasePath = "https://bankggs-113b4-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient customer;
        public Form2()
        {
            InitializeComponent();
        }

        private async void SubmitBtn_Click(object sender, EventArgs e)
        {
            string date = Birthdate.SelectionRange.Start.ToString();
            var datalayer = new GGdata
            {
                Name = FirstNtext.Text + " " + SecondNtext.Text + " " + ThirdNtext.Text,
                Email = Emailtext.Text,
                address = Adresstext.Text,
                AccountType = accTypeCB.SelectedItem.ToString(),
                Amount = maskedTextBox1.Text,
                BirthDate = date
            };
            SetResponse resp = await customer.SetTaskAsync("Bankdetails",datalayer);
            GGdata result = resp.ResultAs<GGdata>();
            MessageBox.Show("data inserted of "+result.Name);
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            customer = new FireSharp.FirebaseClient(config);
            
                if(customer!=null)
                {
                    status = "connected";
                }
                else
                {
                    status = "Not connected";
                }
            MessageBox.Show(status);
        }
    }
}
