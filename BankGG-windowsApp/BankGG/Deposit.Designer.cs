
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
            this.AccnoTB = new System.Windows.Forms.MaskedTextBox();
            this.EnterAcclbl = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.AccBalancelbl = new System.Windows.Forms.Label();
            this.Balancelbl = new System.Windows.Forms.Label();
            this.DepositAmountTB = new System.Windows.Forms.MaskedTextBox();
            this.DepositAmountBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccnoTB
            // 
            this.AccnoTB.Location = new System.Drawing.Point(223, 69);
            this.AccnoTB.Mask = "0000000000";
            this.AccnoTB.Name = "AccnoTB";
            this.AccnoTB.Size = new System.Drawing.Size(116, 20);
            this.AccnoTB.TabIndex = 0;
            // 
            // EnterAcclbl
            // 
            this.EnterAcclbl.AutoSize = true;
            this.EnterAcclbl.Location = new System.Drawing.Point(125, 76);
            this.EnterAcclbl.Name = "EnterAcclbl";
            this.EnterAcclbl.Size = new System.Drawing.Size(92, 13);
            this.EnterAcclbl.TabIndex = 1;
            this.EnterAcclbl.Text = "Enter Account No";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(206, 119);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AccBalancelbl
            // 
            this.AccBalancelbl.AutoSize = true;
            this.AccBalancelbl.Location = new System.Drawing.Point(125, 49);
            this.AccBalancelbl.Name = "AccBalancelbl";
            this.AccBalancelbl.Size = new System.Drawing.Size(102, 13);
            this.AccBalancelbl.TabIndex = 3;
            this.AccBalancelbl.Text = "Account Balance is:";
            this.AccBalancelbl.Visible = false;
            // 
            // Balancelbl
            // 
            this.Balancelbl.AutoSize = true;
            this.Balancelbl.Location = new System.Drawing.Point(233, 53);
            this.Balancelbl.Name = "Balancelbl";
            this.Balancelbl.Size = new System.Drawing.Size(13, 13);
            this.Balancelbl.TabIndex = 4;
            this.Balancelbl.Text = "0";
            this.Balancelbl.Visible = false;
            // 
            // DepositAmountTB
            // 
            this.DepositAmountTB.Location = new System.Drawing.Point(223, 69);
            this.DepositAmountTB.Mask = "00000";
            this.DepositAmountTB.Name = "DepositAmountTB";
            this.DepositAmountTB.Size = new System.Drawing.Size(116, 20);
            this.DepositAmountTB.TabIndex = 5;
            this.DepositAmountTB.Visible = false;
            // 
            // DepositAmountBtn
            // 
            this.DepositAmountBtn.Location = new System.Drawing.Point(206, 119);
            this.DepositAmountBtn.Name = "DepositAmountBtn";
            this.DepositAmountBtn.Size = new System.Drawing.Size(75, 23);
            this.DepositAmountBtn.TabIndex = 6;
            this.DepositAmountBtn.Text = "Deposit";
            this.DepositAmountBtn.UseVisualStyleBackColor = true;
            this.DepositAmountBtn.Visible = false;
            this.DepositAmountBtn.Click += new System.EventHandler(this.DepositAmountBtn_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DepositAmountBtn);
            this.Controls.Add(this.DepositAmountTB);
            this.Controls.Add(this.Balancelbl);
            this.Controls.Add(this.AccBalancelbl);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.EnterAcclbl);
            this.Controls.Add(this.AccnoTB);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox AccnoTB;
        private System.Windows.Forms.Label EnterAcclbl;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label AccBalancelbl;
        private System.Windows.Forms.Label Balancelbl;
        private System.Windows.Forms.MaskedTextBox DepositAmountTB;
        private System.Windows.Forms.Button DepositAmountBtn;
    }
}