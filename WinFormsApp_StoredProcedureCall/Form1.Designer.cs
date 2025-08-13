namespace WinFormsApp_StoredProcedureCall
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnnewSupplier = new Button();
            txtCompanyName = new TextBox();
            txtContactName = new TextBox();
            txtcontactTitle = new TextBox();
            txtaddress = new TextBox();
            txtCity = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // btnnewSupplier
            // 
            btnnewSupplier.Location = new Point(86, 286);
            btnnewSupplier.Name = "btnnewSupplier";
            btnnewSupplier.Size = new Size(94, 29);
            btnnewSupplier.TabIndex = 0;
            btnnewSupplier.Text = "Register";
            btnnewSupplier.UseVisualStyleBackColor = true;
            btnnewSupplier.Click += btnnewSupplier_Click;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(127, 42);
            txtCompanyName.MaxLength = 40;
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.PlaceholderText = "Enter CompanyName";
            txtCompanyName.Size = new Size(347, 27);
            txtCompanyName.TabIndex = 1;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(127, 75);
            txtContactName.MaxLength = 30;
            txtContactName.Name = "txtContactName";
            txtContactName.PlaceholderText = "Enter Contact NAme";
            txtContactName.Size = new Size(347, 27);
            txtContactName.TabIndex = 2;
            txtContactName.TextChanged += textBox2_TextChanged;
            // 
            // txtcontactTitle
            // 
            txtcontactTitle.Location = new Point(127, 110);
            txtcontactTitle.MaxLength = 30;
            txtcontactTitle.Name = "txtcontactTitle";
            txtcontactTitle.PlaceholderText = "Enter Contact Title";
            txtcontactTitle.Size = new Size(361, 27);
            txtcontactTitle.TabIndex = 3;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(127, 155);
            txtaddress.MaxLength = 60;
            txtaddress.Name = "txtaddress";
            txtaddress.PlaceholderText = "Enter Address";
            txtaddress.Size = new Size(256, 27);
            txtaddress.TabIndex = 4;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(127, 201);
            txtCity.MaxLength = 15;
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "Enter City";
            txtCity.Size = new Size(214, 27);
            txtCity.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(616, 75);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(281, 284);
            listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(977, 75);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(281, 284);
            listBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 450);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(txtCity);
            Controls.Add(txtaddress);
            Controls.Add(txtcontactTitle);
            Controls.Add(txtContactName);
            Controls.Add(txtCompanyName);
            Controls.Add(btnnewSupplier);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnnewSupplier;
        private TextBox txtCompanyName;
        private TextBox txtContactName;
        private TextBox txtcontactTitle;
        private TextBox txtaddress;
        private TextBox txtCity;
        private ListBox listBox1;
        private ListBox listBox2;
    }
}
