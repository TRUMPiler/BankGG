﻿
namespace BankGG
{
    partial class MainForm
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
            this.addAccbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.delAccbtn = new System.Windows.Forms.Button();
            this.fetchdetailsbtn = new System.Windows.Forms.Button();
            this.withbtn = new System.Windows.Forms.Button();
            this.depbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addAccbtn
            // 
            this.addAccbtn.AutoSize = true;
            this.addAccbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addAccbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAccbtn.Location = new System.Drawing.Point(365, 109);
            this.addAccbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addAccbtn.Name = "addAccbtn";
            this.addAccbtn.Size = new System.Drawing.Size(337, 44);
            this.addAccbtn.TabIndex = 0;
            this.addAccbtn.Text = "Add Account";
            this.addAccbtn.UseVisualStyleBackColor = true;
            this.addAccbtn.Click += new System.EventHandler(this.addAccbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "choose an option";
            // 
            // delAccbtn
            // 
            this.delAccbtn.AutoSize = true;
            this.delAccbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delAccbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delAccbtn.Location = new System.Drawing.Point(365, 181);
            this.delAccbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delAccbtn.Name = "delAccbtn";
            this.delAccbtn.Size = new System.Drawing.Size(337, 44);
            this.delAccbtn.TabIndex = 2;
            this.delAccbtn.Text = "Delete Account";
            this.delAccbtn.UseVisualStyleBackColor = true;
            this.delAccbtn.Click += new System.EventHandler(this.delAccbtn_Click);
            // 
            // fetchdetailsbtn
            // 
            this.fetchdetailsbtn.AutoSize = true;
            this.fetchdetailsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fetchdetailsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchdetailsbtn.Location = new System.Drawing.Point(365, 247);
            this.fetchdetailsbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fetchdetailsbtn.Name = "fetchdetailsbtn";
            this.fetchdetailsbtn.Size = new System.Drawing.Size(337, 44);
            this.fetchdetailsbtn.TabIndex = 3;
            this.fetchdetailsbtn.Text = "See your bank details";
            this.fetchdetailsbtn.UseVisualStyleBackColor = true;
            this.fetchdetailsbtn.Click += new System.EventHandler(this.fetchdetailsbtn_Click);
            // 
            // withbtn
            // 
            this.withbtn.AutoSize = true;
            this.withbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withbtn.Location = new System.Drawing.Point(365, 313);
            this.withbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.withbtn.Name = "withbtn";
            this.withbtn.Size = new System.Drawing.Size(337, 44);
            this.withbtn.TabIndex = 4;
            this.withbtn.Text = "Withdraw Money";
            this.withbtn.UseVisualStyleBackColor = true;
            this.withbtn.Click += new System.EventHandler(this.withbtn_Click);
            // 
            // depbtn
            // 
            this.depbtn.AutoSize = true;
            this.depbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.depbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depbtn.Location = new System.Drawing.Point(365, 374);
            this.depbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.depbtn.Name = "depbtn";
            this.depbtn.Size = new System.Drawing.Size(337, 44);
            this.depbtn.TabIndex = 5;
            this.depbtn.Text = "Deposit money";
            this.depbtn.UseVisualStyleBackColor = true;
            this.depbtn.Click += new System.EventHandler(this.depbtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.depbtn);
            this.Controls.Add(this.withbtn);
            this.Controls.Add(this.fetchdetailsbtn);
            this.Controls.Add(this.delAccbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addAccbtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addAccbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delAccbtn;
        private System.Windows.Forms.Button fetchdetailsbtn;
        private System.Windows.Forms.Button withbtn;
        private System.Windows.Forms.Button depbtn;
    }
}
