
namespace BankGG
{
    partial class DetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsForm));
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Accnolbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Detailsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.FORMcloseBTNN = new Guna.UI2.WinForms.Guna2Button();
            this.AccountNoislbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AccoNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AccNamelbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AccountNameislbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Birthdatelbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.birthdateislbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.emaillbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Emailislbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Addresslbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Addressislbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Amount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Amountislbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Accounttype = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Accounttypeislbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(328, 121);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox1.Mask = "0000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox1.Size = new System.Drawing.Size(239, 22);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 40;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Accnolbl
            // 
            this.Accnolbl.BackColor = System.Drawing.Color.Transparent;
            this.Accnolbl.ForeColor = System.Drawing.Color.White;
            this.Accnolbl.Location = new System.Drawing.Point(199, 121);
            this.Accnolbl.Name = "Accnolbl";
            this.Accnolbl.Size = new System.Drawing.Size(122, 18);
            this.Accnolbl.TabIndex = 8;
            this.Accnolbl.Text = "<strong>Enter Account No</strong>";
            // 
            // Detailsbtn
            // 
            this.Detailsbtn.Animated = true;
            this.Detailsbtn.AutoRoundedCorners = true;
            this.Detailsbtn.BackColor = System.Drawing.Color.Transparent;
            this.Detailsbtn.BorderRadius = 21;
            this.Detailsbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Detailsbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Detailsbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Detailsbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Detailsbtn.FillColor = System.Drawing.Color.Navy;
            this.Detailsbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detailsbtn.ForeColor = System.Drawing.Color.White;
            this.Detailsbtn.HoverState.FillColor = System.Drawing.Color.GreenYellow;
            this.Detailsbtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Detailsbtn.Location = new System.Drawing.Point(344, 210);
            this.Detailsbtn.Name = "Detailsbtn";
            this.Detailsbtn.Size = new System.Drawing.Size(180, 45);
            this.Detailsbtn.TabIndex = 9;
            this.Detailsbtn.Text = "See Details";
            this.Detailsbtn.Click += new System.EventHandler(this.Detailsbtn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2Button1.Location = new System.Drawing.Point(1003, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(52, 45);
            this.guna2Button1.TabIndex = 29;
            this.guna2Button1.Text = "X";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // FORMcloseBTNN
            // 
            this.FORMcloseBTNN.Animated = true;
            this.FORMcloseBTNN.AnimatedGIF = true;
            this.FORMcloseBTNN.AutoRoundedCorners = true;
            this.FORMcloseBTNN.BackColor = System.Drawing.Color.Transparent;
            this.FORMcloseBTNN.BorderRadius = 21;
            this.FORMcloseBTNN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FORMcloseBTNN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FORMcloseBTNN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FORMcloseBTNN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FORMcloseBTNN.FillColor = System.Drawing.Color.Red;
            this.FORMcloseBTNN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FORMcloseBTNN.ForeColor = System.Drawing.Color.White;
            this.FORMcloseBTNN.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.FORMcloseBTNN.HoverState.ForeColor = System.Drawing.Color.White;
            this.FORMcloseBTNN.Location = new System.Drawing.Point(358, 452);
            this.FORMcloseBTNN.Name = "FORMcloseBTNN";
            this.FORMcloseBTNN.Size = new System.Drawing.Size(180, 45);
            this.FORMcloseBTNN.TabIndex = 30;
            this.FORMcloseBTNN.Text = "Go back";
            this.FORMcloseBTNN.Click += new System.EventHandler(this.FORMcloseBTNN_Click);
            // 
            // AccountNoislbl
            // 
            this.AccountNoislbl.AutoSize = false;
            this.AccountNoislbl.BackColor = System.Drawing.Color.Transparent;
            this.AccountNoislbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNoislbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AccountNoislbl.Location = new System.Drawing.Point(38, 32);
            this.AccountNoislbl.Name = "AccountNoislbl";
            this.AccountNoislbl.Size = new System.Drawing.Size(156, 52);
            this.AccountNoislbl.TabIndex = 31;
            this.AccountNoislbl.Text = "Account No:";
            this.AccountNoislbl.Visible = false;
            // 
            // AccoNo
            // 
            this.AccoNo.AutoSize = false;
            this.AccoNo.BackColor = System.Drawing.Color.Transparent;
            this.AccoNo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccoNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AccoNo.Location = new System.Drawing.Point(210, 32);
            this.AccoNo.Name = "AccoNo";
            this.AccoNo.Size = new System.Drawing.Size(133, 52);
            this.AccoNo.TabIndex = 32;
            this.AccoNo.Text = "0";
            this.AccoNo.Visible = false;
            // 
            // AccNamelbl
            // 
            this.AccNamelbl.AutoSize = false;
            this.AccNamelbl.BackColor = System.Drawing.Color.Transparent;
            this.AccNamelbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNamelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AccNamelbl.Location = new System.Drawing.Point(210, 92);
            this.AccNamelbl.Name = "AccNamelbl";
            this.AccNamelbl.Size = new System.Drawing.Size(287, 52);
            this.AccNamelbl.TabIndex = 34;
            this.AccNamelbl.Text = "0";
            this.AccNamelbl.Visible = false;
            // 
            // AccountNameislbl
            // 
            this.AccountNameislbl.AutoSize = false;
            this.AccountNameislbl.BackColor = System.Drawing.Color.Transparent;
            this.AccountNameislbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNameislbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AccountNameislbl.Location = new System.Drawing.Point(38, 91);
            this.AccountNameislbl.Name = "AccountNameislbl";
            this.AccountNameislbl.Size = new System.Drawing.Size(184, 87);
            this.AccountNameislbl.TabIndex = 33;
            this.AccountNameislbl.Text = "Holder Name:";
            this.AccountNameislbl.Visible = false;
            // 
            // Birthdatelbl
            // 
            this.Birthdatelbl.AutoSize = false;
            this.Birthdatelbl.BackColor = System.Drawing.Color.Transparent;
            this.Birthdatelbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthdatelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Birthdatelbl.Location = new System.Drawing.Point(210, 150);
            this.Birthdatelbl.Name = "Birthdatelbl";
            this.Birthdatelbl.Size = new System.Drawing.Size(258, 52);
            this.Birthdatelbl.TabIndex = 36;
            this.Birthdatelbl.Text = "0";
            this.Birthdatelbl.Visible = false;
            // 
            // birthdateislbl
            // 
            this.birthdateislbl.AutoSize = false;
            this.birthdateislbl.BackColor = System.Drawing.Color.Transparent;
            this.birthdateislbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateislbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.birthdateislbl.Location = new System.Drawing.Point(38, 150);
            this.birthdateislbl.Name = "birthdateislbl";
            this.birthdateislbl.Size = new System.Drawing.Size(156, 52);
            this.birthdateislbl.TabIndex = 35;
            this.birthdateislbl.Text = "BirthDate:";
            this.birthdateislbl.Visible = false;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = false;
            this.emaillbl.BackColor = System.Drawing.Color.Transparent;
            this.emaillbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emaillbl.Location = new System.Drawing.Point(210, 210);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(314, 52);
            this.emaillbl.TabIndex = 38;
            this.emaillbl.Text = "0";
            this.emaillbl.Visible = false;
            // 
            // Emailislbl
            // 
            this.Emailislbl.AutoSize = false;
            this.Emailislbl.BackColor = System.Drawing.Color.Transparent;
            this.Emailislbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailislbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Emailislbl.Location = new System.Drawing.Point(38, 208);
            this.Emailislbl.Name = "Emailislbl";
            this.Emailislbl.Size = new System.Drawing.Size(156, 52);
            this.Emailislbl.TabIndex = 37;
            this.Emailislbl.Text = "Email:";
            this.Emailislbl.Visible = false;
            // 
            // Addresslbl
            // 
            this.Addresslbl.AutoSize = false;
            this.Addresslbl.BackColor = System.Drawing.Color.Transparent;
            this.Addresslbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresslbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Addresslbl.Location = new System.Drawing.Point(210, 268);
            this.Addresslbl.Name = "Addresslbl";
            this.Addresslbl.Size = new System.Drawing.Size(314, 178);
            this.Addresslbl.TabIndex = 40;
            this.Addresslbl.Text = "0";
            this.Addresslbl.Visible = false;
            // 
            // Addressislbl
            // 
            this.Addressislbl.AutoSize = false;
            this.Addressislbl.BackColor = System.Drawing.Color.Transparent;
            this.Addressislbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addressislbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Addressislbl.Location = new System.Drawing.Point(38, 266);
            this.Addressislbl.Name = "Addressislbl";
            this.Addressislbl.Size = new System.Drawing.Size(156, 52);
            this.Addressislbl.TabIndex = 39;
            this.Addressislbl.Text = "Address:";
            this.Addressislbl.Visible = false;
            // 
            // Amount
            // 
            this.Amount.AutoSize = false;
            this.Amount.BackColor = System.Drawing.Color.Transparent;
            this.Amount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Amount.Location = new System.Drawing.Point(850, 105);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(133, 52);
            this.Amount.TabIndex = 42;
            this.Amount.Text = "0";
            this.Amount.Visible = false;
            // 
            // Amountislbl
            // 
            this.Amountislbl.AutoSize = false;
            this.Amountislbl.BackColor = System.Drawing.Color.Transparent;
            this.Amountislbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountislbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Amountislbl.Location = new System.Drawing.Point(678, 103);
            this.Amountislbl.Name = "Amountislbl";
            this.Amountislbl.Size = new System.Drawing.Size(157, 52);
            this.Amountislbl.TabIndex = 41;
            this.Amountislbl.Text = "Amount:";
            this.Amountislbl.Visible = false;
            // 
            // Accounttype
            // 
            this.Accounttype.AutoSize = false;
            this.Accounttype.BackColor = System.Drawing.Color.Transparent;
            this.Accounttype.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accounttype.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Accounttype.Location = new System.Drawing.Point(850, 152);
            this.Accounttype.Name = "Accounttype";
            this.Accounttype.Size = new System.Drawing.Size(133, 52);
            this.Accounttype.TabIndex = 44;
            this.Accounttype.Text = "0";
            this.Accounttype.Visible = false;
            // 
            // Accounttypeislbl
            // 
            this.Accounttypeislbl.AutoSize = false;
            this.Accounttypeislbl.BackColor = System.Drawing.Color.Transparent;
            this.Accounttypeislbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accounttypeislbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Accounttypeislbl.Location = new System.Drawing.Point(678, 150);
            this.Accounttypeislbl.Name = "Accounttypeislbl";
            this.Accounttypeislbl.Size = new System.Drawing.Size(157, 52);
            this.Accounttypeislbl.TabIndex = 43;
            this.Accounttypeislbl.Text = "Account type:";
            this.Accounttypeislbl.Visible = false;
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Accounttype);
            this.Controls.Add(this.Accounttypeislbl);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Amountislbl);
            this.Controls.Add(this.Addresslbl);
            this.Controls.Add(this.Addressislbl);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.Emailislbl);
            this.Controls.Add(this.Birthdatelbl);
            this.Controls.Add(this.birthdateislbl);
            this.Controls.Add(this.AccNamelbl);
            this.Controls.Add(this.AccountNameislbl);
            this.Controls.Add(this.AccoNo);
            this.Controls.Add(this.AccountNoislbl);
            this.Controls.Add(this.FORMcloseBTNN);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.Detailsbtn);
            this.Controls.Add(this.Accnolbl);
            this.Controls.Add(this.maskedTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Details";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Accnolbl;
        private Guna.UI2.WinForms.Guna2Button Detailsbtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button FORMcloseBTNN;
        private Guna.UI2.WinForms.Guna2HtmlLabel Birthdatelbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel birthdateislbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel AccNamelbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel AccountNameislbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel AccoNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel AccountNoislbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel Accounttype;
        private Guna.UI2.WinForms.Guna2HtmlLabel Accounttypeislbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel Amount;
        private Guna.UI2.WinForms.Guna2HtmlLabel Amountislbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel Addresslbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel Addressislbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel emaillbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel Emailislbl;
    }
}