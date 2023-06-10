
namespace BankGG
{
    partial class Withdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdraw));
            this.AccnoTB = new System.Windows.Forms.MaskedTextBox();
            this.WithAmountMB = new System.Windows.Forms.MaskedTextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.AccountBallbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Balancelbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.enteraccnolbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.WithBtn = new Guna.UI2.WinForms.Guna2Button();
            this.FormCloseBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // AccnoTB
            // 
            this.AccnoTB.Location = new System.Drawing.Point(297, 143);
            this.AccnoTB.Margin = new System.Windows.Forms.Padding(4);
            this.AccnoTB.Mask = "0000000000";
            this.AccnoTB.Name = "AccnoTB";
            this.AccnoTB.Size = new System.Drawing.Size(189, 22);
            this.AccnoTB.TabIndex = 2;
            // 
            // WithAmountMB
            // 
            this.WithAmountMB.Location = new System.Drawing.Point(297, 143);
            this.WithAmountMB.Margin = new System.Windows.Forms.Padding(4);
            this.WithAmountMB.Mask = "00000";
            this.WithAmountMB.Name = "WithAmountMB";
            this.WithAmountMB.Size = new System.Drawing.Size(189, 22);
            this.WithAmountMB.TabIndex = 5;
            this.WithAmountMB.Visible = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 40;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // AccountBallbl
            // 
            this.AccountBallbl.AutoSize = false;
            this.AccountBallbl.BackColor = System.Drawing.Color.Transparent;
            this.AccountBallbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountBallbl.ForeColor = System.Drawing.Color.White;
            this.AccountBallbl.Location = new System.Drawing.Point(246, 69);
            this.AccountBallbl.Name = "AccountBallbl";
            this.AccountBallbl.Size = new System.Drawing.Size(202, 50);
            this.AccountBallbl.TabIndex = 7;
            this.AccountBallbl.Text = "Account Balance:-";
            this.AccountBallbl.Visible = false;
            // 
            // Balancelbl
            // 
            this.Balancelbl.AutoSize = false;
            this.Balancelbl.BackColor = System.Drawing.Color.Transparent;
            this.Balancelbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balancelbl.ForeColor = System.Drawing.Color.White;
            this.Balancelbl.Location = new System.Drawing.Point(415, 69);
            this.Balancelbl.Name = "Balancelbl";
            this.Balancelbl.Size = new System.Drawing.Size(202, 50);
            this.Balancelbl.TabIndex = 8;
            this.Balancelbl.Text = "0";
            this.Balancelbl.Visible = false;
            // 
            // enteraccnolbl
            // 
            this.enteraccnolbl.AutoSize = false;
            this.enteraccnolbl.BackColor = System.Drawing.Color.Transparent;
            this.enteraccnolbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enteraccnolbl.ForeColor = System.Drawing.Color.White;
            this.enteraccnolbl.Location = new System.Drawing.Point(88, 125);
            this.enteraccnolbl.Name = "enteraccnolbl";
            this.enteraccnolbl.Size = new System.Drawing.Size(202, 50);
            this.enteraccnolbl.TabIndex = 9;
            this.enteraccnolbl.Text = "Enter account no:";
            this.enteraccnolbl.Click += new System.EventHandler(this.enteraccnolbl_Click);
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
            this.SearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchBtn.FillColor = System.Drawing.Color.Crimson;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(297, 203);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(180, 45);
            this.SearchBtn.TabIndex = 10;
            this.SearchBtn.Text = "SearchBtn";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click_1);
            // 
            // WithBtn
            // 
            this.WithBtn.Animated = true;
            this.WithBtn.AutoRoundedCorners = true;
            this.WithBtn.BackColor = System.Drawing.Color.Transparent;
            this.WithBtn.BorderRadius = 21;
            this.WithBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WithBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WithBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WithBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WithBtn.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.WithBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WithBtn.ForeColor = System.Drawing.Color.White;
            this.WithBtn.Location = new System.Drawing.Point(297, 203);
            this.WithBtn.Name = "WithBtn";
            this.WithBtn.Size = new System.Drawing.Size(180, 45);
            this.WithBtn.TabIndex = 11;
            this.WithBtn.Text = "WithDraw";
            this.WithBtn.Visible = false;
            this.WithBtn.Click += new System.EventHandler(this.WithBtn_Click);
            // 
            // FormCloseBtn
            // 
            this.FormCloseBtn.Animated = true;
            this.FormCloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.FormCloseBtn.BorderRadius = 5;
            this.FormCloseBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FormCloseBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FormCloseBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FormCloseBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FormCloseBtn.FillColor = System.Drawing.Color.Red;
            this.FormCloseBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormCloseBtn.ForeColor = System.Drawing.Color.White;
            this.FormCloseBtn.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.FormCloseBtn.Location = new System.Drawing.Point(1003, 12);
            this.FormCloseBtn.Name = "FormCloseBtn";
            this.FormCloseBtn.Size = new System.Drawing.Size(52, 45);
            this.FormCloseBtn.TabIndex = 29;
            this.FormCloseBtn.Text = "X";
            this.FormCloseBtn.Click += new System.EventHandler(this.FormCloseBtn_Click);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.FormCloseBtn);
            this.Controls.Add(this.WithBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.WithAmountMB);
            this.Controls.Add(this.enteraccnolbl);
            this.Controls.Add(this.Balancelbl);
            this.Controls.Add(this.AccountBallbl);
            this.Controls.Add(this.AccnoTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox AccnoTB;
        private System.Windows.Forms.MaskedTextBox WithAmountMB;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel enteraccnolbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel Balancelbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel AccountBallbl;
        private Guna.UI2.WinForms.Guna2Button WithBtn;
        private Guna.UI2.WinForms.Guna2Button FormCloseBtn;
    }
}