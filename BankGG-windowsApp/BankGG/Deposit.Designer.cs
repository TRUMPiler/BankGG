
namespace BankGG
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.AccnoTB = new System.Windows.Forms.MaskedTextBox();
            this.DepositAmountTB = new System.Windows.Forms.MaskedTextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Balancelbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AccountBallbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.enteraccnolbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DepositAmountBtn = new Guna.UI2.WinForms.Guna2Button();
            this.FormCloseBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // AccnoTB
            // 
            this.AccnoTB.Location = new System.Drawing.Point(297, 85);
            this.AccnoTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AccnoTB.Mask = "0000000000";
            this.AccnoTB.Name = "AccnoTB";
            this.AccnoTB.Size = new System.Drawing.Size(153, 22);
            this.AccnoTB.TabIndex = 0;
            // 
            // DepositAmountTB
            // 
            this.DepositAmountTB.Location = new System.Drawing.Point(297, 85);
            this.DepositAmountTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DepositAmountTB.Mask = "00000";
            this.DepositAmountTB.Name = "DepositAmountTB";
            this.DepositAmountTB.Size = new System.Drawing.Size(153, 22);
            this.DepositAmountTB.TabIndex = 5;
            this.DepositAmountTB.Visible = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 40;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Balancelbl
            // 
            this.Balancelbl.AutoSize = false;
            this.Balancelbl.BackColor = System.Drawing.Color.Transparent;
            this.Balancelbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balancelbl.ForeColor = System.Drawing.Color.White;
            this.Balancelbl.Location = new System.Drawing.Point(293, 28);
            this.Balancelbl.Name = "Balancelbl";
            this.Balancelbl.Size = new System.Drawing.Size(202, 50);
            this.Balancelbl.TabIndex = 10;
            this.Balancelbl.Text = "0";
            this.Balancelbl.Visible = false;
            // 
            // AccountBallbl
            // 
            this.AccountBallbl.AutoSize = false;
            this.AccountBallbl.BackColor = System.Drawing.Color.Transparent;
            this.AccountBallbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountBallbl.ForeColor = System.Drawing.Color.White;
            this.AccountBallbl.Location = new System.Drawing.Point(124, 28);
            this.AccountBallbl.Name = "AccountBallbl";
            this.AccountBallbl.Size = new System.Drawing.Size(202, 50);
            this.AccountBallbl.TabIndex = 9;
            this.AccountBallbl.Text = "Account Balance:-";
            this.AccountBallbl.Visible = false;
            // 
            // enteraccnolbl
            // 
            this.enteraccnolbl.AutoSize = false;
            this.enteraccnolbl.BackColor = System.Drawing.Color.Transparent;
            this.enteraccnolbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enteraccnolbl.ForeColor = System.Drawing.Color.White;
            this.enteraccnolbl.Location = new System.Drawing.Point(88, 84);
            this.enteraccnolbl.Name = "enteraccnolbl";
            this.enteraccnolbl.Size = new System.Drawing.Size(202, 50);
            this.enteraccnolbl.TabIndex = 11;
            this.enteraccnolbl.Text = "Enter account no:";
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
            this.SearchBtn.FillColor = System.Drawing.Color.DarkBlue;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.HoverState.FillColor = System.Drawing.Color.Black;
            this.SearchBtn.Location = new System.Drawing.Point(270, 140);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(180, 45);
            this.SearchBtn.TabIndex = 12;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click_1);
            // 
            // DepositAmountBtn
            // 
            this.DepositAmountBtn.Animated = true;
            this.DepositAmountBtn.AutoRoundedCorners = true;
            this.DepositAmountBtn.BackColor = System.Drawing.Color.Transparent;
            this.DepositAmountBtn.BorderRadius = 21;
            this.DepositAmountBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DepositAmountBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DepositAmountBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DepositAmountBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DepositAmountBtn.FillColor = System.Drawing.Color.GreenYellow;
            this.DepositAmountBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DepositAmountBtn.ForeColor = System.Drawing.Color.Black;
            this.DepositAmountBtn.HoverState.FillColor = System.Drawing.Color.Black;
            this.DepositAmountBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.DepositAmountBtn.Location = new System.Drawing.Point(270, 218);
            this.DepositAmountBtn.Name = "DepositAmountBtn";
            this.DepositAmountBtn.Size = new System.Drawing.Size(180, 45);
            this.DepositAmountBtn.TabIndex = 13;
            this.DepositAmountBtn.Text = "Deposit";
            this.DepositAmountBtn.Visible = false;
            this.DepositAmountBtn.Click += new System.EventHandler(this.DepositAmountBtn_Click_1);
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
            this.FormCloseBtn.TabIndex = 30;
            this.FormCloseBtn.Text = "X";
            this.FormCloseBtn.Click += new System.EventHandler(this.FormCloseBtn_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.FormCloseBtn);
            this.Controls.Add(this.DepositAmountBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.enteraccnolbl);
            this.Controls.Add(this.Balancelbl);
            this.Controls.Add(this.AccountBallbl);
            this.Controls.Add(this.DepositAmountTB);
            this.Controls.Add(this.AccnoTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox AccnoTB;
        private System.Windows.Forms.MaskedTextBox DepositAmountTB;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Balancelbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel AccountBallbl;
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel enteraccnolbl;
        private Guna.UI2.WinForms.Guna2Button DepositAmountBtn;
        private Guna.UI2.WinForms.Guna2Button FormCloseBtn;
    }
}