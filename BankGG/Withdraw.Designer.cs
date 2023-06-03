
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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.AccNolbl = new System.Windows.Forms.Label();
            this.AccnoTB = new System.Windows.Forms.MaskedTextBox();
            this.AccountBallbl = new System.Windows.Forms.Label();
            this.Balancelbl = new System.Windows.Forms.Label();
            this.WithAmountMB = new System.Windows.Forms.MaskedTextBox();
            this.WithdrawBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(261, 178);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AccNolbl
            // 
            this.AccNolbl.AutoSize = true;
            this.AccNolbl.Location = new System.Drawing.Point(246, 83);
            this.AccNolbl.Name = "AccNolbl";
            this.AccNolbl.Size = new System.Drawing.Size(90, 13);
            this.AccNolbl.TabIndex = 1;
            this.AccNolbl.Text = "Enter Account no";
            // 
            // AccnoTB
            // 
            this.AccnoTB.Location = new System.Drawing.Point(223, 116);
            this.AccnoTB.Mask = "0000000000";
            this.AccnoTB.Name = "AccnoTB";
            this.AccnoTB.Size = new System.Drawing.Size(143, 20);
            this.AccnoTB.TabIndex = 2;
            // 
            // AccountBallbl
            // 
            this.AccountBallbl.AutoSize = true;
            this.AccountBallbl.Location = new System.Drawing.Point(179, 56);
            this.AccountBallbl.Name = "AccountBallbl";
            this.AccountBallbl.Size = new System.Drawing.Size(95, 13);
            this.AccountBallbl.TabIndex = 3;
            this.AccountBallbl.Text = "Account Balance:-";
            this.AccountBallbl.Visible = false;
            // 
            // Balancelbl
            // 
            this.Balancelbl.AutoSize = true;
            this.Balancelbl.Location = new System.Drawing.Point(271, 56);
            this.Balancelbl.Name = "Balancelbl";
            this.Balancelbl.Size = new System.Drawing.Size(13, 13);
            this.Balancelbl.TabIndex = 4;
            this.Balancelbl.Text = "0";
            this.Balancelbl.Visible = false;
            // 
            // WithAmountMB
            // 
            this.WithAmountMB.Location = new System.Drawing.Point(223, 116);
            this.WithAmountMB.Mask = "00000";
            this.WithAmountMB.Name = "WithAmountMB";
            this.WithAmountMB.Size = new System.Drawing.Size(143, 20);
            this.WithAmountMB.TabIndex = 5;
            this.WithAmountMB.Visible = false;
            // 
            // WithdrawBtn
            // 
            this.WithdrawBtn.Location = new System.Drawing.Point(261, 207);
            this.WithdrawBtn.Name = "WithdrawBtn";
            this.WithdrawBtn.Size = new System.Drawing.Size(75, 23);
            this.WithdrawBtn.TabIndex = 6;
            this.WithdrawBtn.Text = "WithDraw";
            this.WithdrawBtn.UseVisualStyleBackColor = true;
            this.WithdrawBtn.Visible = false;
            this.WithdrawBtn.Click += new System.EventHandler(this.WithdrawBtn_Click);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WithdrawBtn);
            this.Controls.Add(this.WithAmountMB);
            this.Controls.Add(this.Balancelbl);
            this.Controls.Add(this.AccountBallbl);
            this.Controls.Add(this.AccnoTB);
            this.Controls.Add(this.AccNolbl);
            this.Controls.Add(this.SearchBtn);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label AccNolbl;
        private System.Windows.Forms.MaskedTextBox AccnoTB;
        private System.Windows.Forms.Label AccountBallbl;
        private System.Windows.Forms.Label Balancelbl;
        private System.Windows.Forms.MaskedTextBox WithAmountMB;
        private System.Windows.Forms.Button WithdrawBtn;
    }
}