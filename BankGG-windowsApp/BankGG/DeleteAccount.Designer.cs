
namespace BankGG
{
    partial class DeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteForm));
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Acconolbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AccNamelbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AccountNameislbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AccoNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AccountNoislbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(277, 121);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox1.Mask = "0000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(177, 22);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 40;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Acconolbl
            // 
            this.Acconolbl.AutoSize = false;
            this.Acconolbl.BackColor = System.Drawing.Color.Transparent;
            this.Acconolbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acconolbl.ForeColor = System.Drawing.Color.White;
            this.Acconolbl.Location = new System.Drawing.Point(61, 121);
            this.Acconolbl.Name = "Acconolbl";
            this.Acconolbl.Size = new System.Drawing.Size(219, 30);
            this.Acconolbl.TabIndex = 5;
            this.Acconolbl.Text = "Enter Account No:";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Animated = true;
            this.SearchBtn.AutoRoundedCorners = true;
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.BorderRadius = 21;
            this.SearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchBtn.FillColor = System.Drawing.Color.ForestGreen;
            this.SearchBtn.FillColor2 = System.Drawing.Color.PaleGreen;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(264, 181);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(180, 45);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "Search Account";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click_1);
            // 
            // AccNamelbl
            // 
            this.AccNamelbl.AutoSize = false;
            this.AccNamelbl.BackColor = System.Drawing.Color.Transparent;
            this.AccNamelbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNamelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AccNamelbl.Location = new System.Drawing.Point(233, 123);
            this.AccNamelbl.Name = "AccNamelbl";
            this.AccNamelbl.Size = new System.Drawing.Size(287, 52);
            this.AccNamelbl.TabIndex = 38;
            this.AccNamelbl.Text = "0";
            this.AccNamelbl.Visible = false;
            // 
            // AccountNameislbl
            // 
            this.AccountNameislbl.AutoSize = false;
            this.AccountNameislbl.BackColor = System.Drawing.Color.Transparent;
            this.AccountNameislbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNameislbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AccountNameislbl.Location = new System.Drawing.Point(61, 122);
            this.AccountNameislbl.Name = "AccountNameislbl";
            this.AccountNameislbl.Size = new System.Drawing.Size(184, 87);
            this.AccountNameislbl.TabIndex = 37;
            this.AccountNameislbl.Text = "Holder Name:";
            this.AccountNameislbl.Visible = false;
            // 
            // AccoNo
            // 
            this.AccoNo.AutoSize = false;
            this.AccoNo.BackColor = System.Drawing.Color.Transparent;
            this.AccoNo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccoNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AccoNo.Location = new System.Drawing.Point(233, 63);
            this.AccoNo.Name = "AccoNo";
            this.AccoNo.Size = new System.Drawing.Size(133, 52);
            this.AccoNo.TabIndex = 36;
            this.AccoNo.Text = "0";
            this.AccoNo.Visible = false;
            // 
            // AccountNoislbl
            // 
            this.AccountNoislbl.AutoSize = false;
            this.AccountNoislbl.BackColor = System.Drawing.Color.Transparent;
            this.AccountNoislbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNoislbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AccountNoislbl.Location = new System.Drawing.Point(61, 63);
            this.AccountNoislbl.Name = "AccountNoislbl";
            this.AccountNoislbl.Size = new System.Drawing.Size(156, 52);
            this.AccountNoislbl.TabIndex = 35;
            this.AccountNoislbl.Text = "Account No:";
            this.AccountNoislbl.Visible = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Animated = true;
            this.DeleteBtn.AutoRoundedCorners = true;
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.BorderRadius = 21;
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.FillColor = System.Drawing.Color.Red;
            this.DeleteBtn.FillColor2 = System.Drawing.Color.Gold;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(264, 281);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(180, 45);
            this.DeleteBtn.TabIndex = 39;
            this.DeleteBtn.Text = "Delete Account";
            this.DeleteBtn.Visible = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click_1);
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
            this.guna2Button1.Location = new System.Drawing.Point(819, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(52, 45);
            this.guna2Button1.TabIndex = 40;
            this.guna2Button1.Text = "X";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 530);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AccNamelbl);
            this.Controls.Add(this.AccountNameislbl);
            this.Controls.Add(this.AccoNo);
            this.Controls.Add(this.AccountNoislbl);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.Acconolbl);
            this.Controls.Add(this.maskedTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Account";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientButton SearchBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel Acconolbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel AccNamelbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel AccountNameislbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel AccoNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel AccountNoislbl;
        private Guna.UI2.WinForms.Guna2GradientButton DeleteBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}