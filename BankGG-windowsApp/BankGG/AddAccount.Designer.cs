
namespace BankGG
{
    partial class AddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount));
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.Adresslbl = new System.Windows.Forms.Label();
            this.AccTypelbl = new System.Windows.Forms.Label();
            this.Amountlbl = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Birthdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.FirstNtext = new Guna.UI2.WinForms.Guna2TextBox();
            this.SecondNtext = new Guna.UI2.WinForms.Guna2TextBox();
            this.ThirdNtext = new Guna.UI2.WinForms.Guna2TextBox();
            this.Emailtext = new Guna.UI2.WinForms.Guna2TextBox();
            this.Adresstext = new Guna.UI2.WinForms.Guna2TextBox();
            this.accTypeCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.FormCloseBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SubmitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.FormCancel = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(37, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(37, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 2;
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.BackColor = System.Drawing.Color.Transparent;
            this.Emaillbl.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillbl.ForeColor = System.Drawing.Color.White;
            this.Emaillbl.Location = new System.Drawing.Point(28, 75);
            this.Emaillbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(63, 20);
            this.Emaillbl.TabIndex = 8;
            this.Emaillbl.Text = "Email:";
            this.Emaillbl.Click += new System.EventHandler(this.Emaillbl_Click);
            // 
            // Adresslbl
            // 
            this.Adresslbl.AutoSize = true;
            this.Adresslbl.BackColor = System.Drawing.Color.Transparent;
            this.Adresslbl.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adresslbl.ForeColor = System.Drawing.Color.White;
            this.Adresslbl.Location = new System.Drawing.Point(13, 132);
            this.Adresslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Adresslbl.Name = "Adresslbl";
            this.Adresslbl.Size = new System.Drawing.Size(81, 20);
            this.Adresslbl.TabIndex = 10;
            this.Adresslbl.Text = "Address:";
            // 
            // AccTypelbl
            // 
            this.AccTypelbl.AutoSize = true;
            this.AccTypelbl.BackColor = System.Drawing.Color.Transparent;
            this.AccTypelbl.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccTypelbl.ForeColor = System.Drawing.Color.White;
            this.AccTypelbl.Location = new System.Drawing.Point(8, 267);
            this.AccTypelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AccTypelbl.Name = "AccTypelbl";
            this.AccTypelbl.Size = new System.Drawing.Size(126, 20);
            this.AccTypelbl.TabIndex = 12;
            this.AccTypelbl.Text = "Account Type:";
            // 
            // Amountlbl
            // 
            this.Amountlbl.AutoSize = true;
            this.Amountlbl.BackColor = System.Drawing.Color.Transparent;
            this.Amountlbl.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountlbl.ForeColor = System.Drawing.Color.White;
            this.Amountlbl.Location = new System.Drawing.Point(36, 332);
            this.Amountlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Amountlbl.Name = "Amountlbl";
            this.Amountlbl.Size = new System.Drawing.Size(72, 20);
            this.Amountlbl.TabIndex = 14;
            this.Amountlbl.Text = "Amount:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.Location = new System.Drawing.Point(141, 332);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox1.Mask = "00000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(176, 22);
            this.maskedTextBox1.TabIndex = 15;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 381);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Birth Date:";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 300;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.guna2BorderlessForm1.BorderRadius = 40;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Birthdate
            // 
            this.Birthdate.Checked = true;
            this.Birthdate.FillColor = System.Drawing.Color.Black;
            this.Birthdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Birthdate.ForeColor = System.Drawing.Color.White;
            this.Birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Birthdate.Location = new System.Drawing.Point(141, 381);
            this.Birthdate.MaxDate = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            this.Birthdate.MinDate = new System.DateTime(1924, 1, 1, 0, 0, 0, 0);
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Size = new System.Drawing.Size(200, 36);
            this.Birthdate.TabIndex = 21;
            this.Birthdate.Value = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            // 
            // FirstNtext
            // 
            this.FirstNtext.Animated = true;
            this.FirstNtext.BackColor = System.Drawing.Color.Transparent;
            this.FirstNtext.BorderColor = System.Drawing.Color.Transparent;
            this.FirstNtext.BorderRadius = 14;
            this.FirstNtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstNtext.DefaultText = "";
            this.FirstNtext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FirstNtext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FirstNtext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FirstNtext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FirstNtext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstNtext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FirstNtext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstNtext.Location = new System.Drawing.Point(98, 13);
            this.FirstNtext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirstNtext.Name = "FirstNtext";
            this.FirstNtext.PasswordChar = '\0';
            this.FirstNtext.PlaceholderText = "First name";
            this.FirstNtext.SelectedText = "";
            this.FirstNtext.Size = new System.Drawing.Size(154, 37);
            this.FirstNtext.TabIndex = 22;
            // 
            // SecondNtext
            // 
            this.SecondNtext.Animated = true;
            this.SecondNtext.BackColor = System.Drawing.Color.Transparent;
            this.SecondNtext.BorderColor = System.Drawing.Color.Transparent;
            this.SecondNtext.BorderRadius = 14;
            this.SecondNtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SecondNtext.DefaultText = "";
            this.SecondNtext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SecondNtext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SecondNtext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SecondNtext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SecondNtext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SecondNtext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SecondNtext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SecondNtext.Location = new System.Drawing.Point(255, 13);
            this.SecondNtext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SecondNtext.Name = "SecondNtext";
            this.SecondNtext.PasswordChar = '\0';
            this.SecondNtext.PlaceholderText = "Middle name";
            this.SecondNtext.SelectedText = "";
            this.SecondNtext.Size = new System.Drawing.Size(154, 37);
            this.SecondNtext.TabIndex = 23;
            // 
            // ThirdNtext
            // 
            this.ThirdNtext.Animated = true;
            this.ThirdNtext.BackColor = System.Drawing.Color.Transparent;
            this.ThirdNtext.BorderColor = System.Drawing.Color.Transparent;
            this.ThirdNtext.BorderRadius = 14;
            this.ThirdNtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ThirdNtext.DefaultText = "";
            this.ThirdNtext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ThirdNtext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ThirdNtext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ThirdNtext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ThirdNtext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ThirdNtext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ThirdNtext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ThirdNtext.Location = new System.Drawing.Point(415, 13);
            this.ThirdNtext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ThirdNtext.Name = "ThirdNtext";
            this.ThirdNtext.PasswordChar = '\0';
            this.ThirdNtext.PlaceholderText = "Last name";
            this.ThirdNtext.SelectedText = "";
            this.ThirdNtext.Size = new System.Drawing.Size(154, 37);
            this.ThirdNtext.TabIndex = 24;
            // 
            // Emailtext
            // 
            this.Emailtext.Animated = true;
            this.Emailtext.BackColor = System.Drawing.Color.Transparent;
            this.Emailtext.BorderColor = System.Drawing.Color.Transparent;
            this.Emailtext.BorderRadius = 12;
            this.Emailtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Emailtext.DefaultText = "";
            this.Emailtext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Emailtext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Emailtext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Emailtext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Emailtext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Emailtext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Emailtext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Emailtext.Location = new System.Drawing.Point(141, 75);
            this.Emailtext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Emailtext.Name = "Emailtext";
            this.Emailtext.PasswordChar = '\0';
            this.Emailtext.PlaceholderText = "Email";
            this.Emailtext.SelectedText = "";
            this.Emailtext.Size = new System.Drawing.Size(219, 37);
            this.Emailtext.TabIndex = 25;
            // 
            // Adresstext
            // 
            this.Adresstext.Animated = true;
            this.Adresstext.BackColor = System.Drawing.Color.Transparent;
            this.Adresstext.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Adresstext.BorderRadius = 10;
            this.Adresstext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Adresstext.DefaultText = "";
            this.Adresstext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Adresstext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Adresstext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Adresstext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Adresstext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Adresstext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Adresstext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Adresstext.Location = new System.Drawing.Point(141, 132);
            this.Adresstext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Adresstext.Multiline = true;
            this.Adresstext.Name = "Adresstext";
            this.Adresstext.PasswordChar = '\0';
            this.Adresstext.PlaceholderText = "";
            this.Adresstext.SelectedText = "";
            this.Adresstext.Size = new System.Drawing.Size(259, 116);
            this.Adresstext.TabIndex = 26;
            // 
            // accTypeCB
            // 
            this.accTypeCB.AutoRoundedCorners = true;
            this.accTypeCB.BackColor = System.Drawing.Color.Transparent;
            this.accTypeCB.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.accTypeCB.BorderRadius = 17;
            this.accTypeCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.accTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accTypeCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.accTypeCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.accTypeCB.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.accTypeCB.ForeColor = System.Drawing.Color.Black;
            this.accTypeCB.ItemHeight = 30;
            this.accTypeCB.Items.AddRange(new object[] {
            "Savings",
            "Current"});
            this.accTypeCB.Location = new System.Drawing.Point(142, 267);
            this.accTypeCB.Name = "accTypeCB";
            this.accTypeCB.Size = new System.Drawing.Size(175, 36);
            this.accTypeCB.TabIndex = 27;
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
            this.FormCloseBtn.TabIndex = 28;
            this.FormCloseBtn.Text = "X";
            this.FormCloseBtn.Click += new System.EventHandler(this.FormCloseBtn_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Animated = true;
            this.SubmitBtn.AutoRoundedCorners = true;
            this.SubmitBtn.BackColor = System.Drawing.Color.Transparent;
            this.SubmitBtn.BorderRadius = 40;
            this.SubmitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SubmitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SubmitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SubmitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SubmitBtn.FillColor = System.Drawing.Color.ForestGreen;
            this.SubmitBtn.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.HoverState.FillColor = System.Drawing.Color.Lime;
            this.SubmitBtn.HoverState.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.SubmitBtn.Location = new System.Drawing.Point(264, 428);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(201, 83);
            this.SubmitBtn.TabIndex = 29;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseTransparentBackground = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click_1);
            // 
            // FormCancel
            // 
            this.FormCancel.Animated = true;
            this.FormCancel.AutoRoundedCorners = true;
            this.FormCancel.BackColor = System.Drawing.Color.Transparent;
            this.FormCancel.BorderRadius = 40;
            this.FormCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FormCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FormCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FormCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FormCancel.FillColor = System.Drawing.Color.Tomato;
            this.FormCancel.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            this.FormCancel.ForeColor = System.Drawing.Color.White;
            this.FormCancel.HoverState.FillColor = System.Drawing.Color.Red;
            this.FormCancel.HoverState.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormCancel.HoverState.ForeColor = System.Drawing.Color.Black;
            this.FormCancel.Location = new System.Drawing.Point(471, 428);
            this.FormCancel.Name = "FormCancel";
            this.FormCancel.Size = new System.Drawing.Size(201, 83);
            this.FormCancel.TabIndex = 30;
            this.FormCancel.Text = "Cancel";
            this.FormCancel.UseTransparentBackground = true;
            this.FormCancel.Click += new System.EventHandler(this.FormCancel_Click);
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.FormCancel);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.FormCloseBtn);
            this.Controls.Add(this.accTypeCB);
            this.Controls.Add(this.Adresstext);
            this.Controls.Add(this.Emailtext);
            this.Controls.Add(this.ThirdNtext);
            this.Controls.Add(this.SecondNtext);
            this.Controls.Add(this.FirstNtext);
            this.Controls.Add(this.Birthdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.Amountlbl);
            this.Controls.Add(this.AccTypelbl);
            this.Controls.Add(this.Adresslbl);
            this.Controls.Add(this.Emaillbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Account";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.Label Adresslbl;
        private System.Windows.Forms.Label AccTypelbl;
        private System.Windows.Forms.Label Amountlbl;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DateTimePicker Birthdate;
        private Guna.UI2.WinForms.Guna2TextBox FirstNtext;
        private Guna.UI2.WinForms.Guna2TextBox ThirdNtext;
        private Guna.UI2.WinForms.Guna2TextBox SecondNtext;
        private Guna.UI2.WinForms.Guna2TextBox Emailtext;
        private Guna.UI2.WinForms.Guna2TextBox Adresstext;
        private Guna.UI2.WinForms.Guna2ComboBox accTypeCB;
        private Guna.UI2.WinForms.Guna2Button FormCloseBtn;
        private Guna.UI2.WinForms.Guna2Button SubmitBtn;
        private Guna.UI2.WinForms.Guna2Button FormCancel;
    }
}