
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
            this.Accountnolbl = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.retriveBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FormcloseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Accountnolbl
            // 
            this.Accountnolbl.AutoSize = true;
            this.Accountnolbl.Location = new System.Drawing.Point(122, 101);
            this.Accountnolbl.Name = "Accountnolbl";
            this.Accountnolbl.Size = new System.Drawing.Size(118, 13);
            this.Accountnolbl.TabIndex = 0;
            this.Accountnolbl.Text = "Enter Your Account no:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(246, 98);
            this.maskedTextBox1.Mask = "0000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox1.Size = new System.Drawing.Size(180, 20);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // retriveBtn
            // 
            this.retriveBtn.BackColor = System.Drawing.Color.Lime;
            this.retriveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retriveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.retriveBtn.Location = new System.Drawing.Point(268, 147);
            this.retriveBtn.Name = "retriveBtn";
            this.retriveBtn.Size = new System.Drawing.Size(132, 35);
            this.retriveBtn.TabIndex = 2;
            this.retriveBtn.Text = "See Details";
            this.retriveBtn.UseVisualStyleBackColor = false;
            this.retriveBtn.Click += new System.EventHandler(this.retriveBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(687, 168);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            // 
            // FormcloseBtn
            // 
            this.FormcloseBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.FormcloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormcloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FormcloseBtn.Location = new System.Drawing.Point(301, 224);
            this.FormcloseBtn.Name = "FormcloseBtn";
            this.FormcloseBtn.Size = new System.Drawing.Size(75, 23);
            this.FormcloseBtn.TabIndex = 4;
            this.FormcloseBtn.Text = "Go back";
            this.FormcloseBtn.UseVisualStyleBackColor = false;
            this.FormcloseBtn.Click += new System.EventHandler(this.FormcloseBtn_Click);
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FormcloseBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.retriveBtn);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.Accountnolbl);
            this.Name = "DetailsForm";
            this.Text = "Show Details";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Accountnolbl;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button retriveBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FormcloseBtn;
    }
}