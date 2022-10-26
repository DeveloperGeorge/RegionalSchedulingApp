namespace Software2SchedulingApp
{
    partial class AddRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.addCName = new System.Windows.Forms.TextBox();
            this.addPhoneNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addAddress1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addAddress2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addPostalCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveAddCR = new System.Windows.Forms.Button();
            this.cancelAddCR = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cBCity = new System.Windows.Forms.ComboBox();
            this.cBCountry = new System.Windows.Forms.ComboBox();
            this.plsSelectCountryLbl = new System.Windows.Forms.Label();
            this.plsSelectCityLbl = new System.Windows.Forms.Label();
            this.phoneNumFormat = new System.Windows.Forms.Label();
            this.wrongPhoneFormatLbl = new System.Windows.Forms.Label();
            this.wrongPostalFormatLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // addCName
            // 
            this.addCName.Location = new System.Drawing.Point(161, 67);
            this.addCName.MaxLength = 45;
            this.addCName.Name = "addCName";
            this.addCName.Size = new System.Drawing.Size(100, 20);
            this.addCName.TabIndex = 1;
            this.addCName.TextChanged += new System.EventHandler(this.addCName_TextChanged);
            // 
            // addPhoneNum
            // 
            this.addPhoneNum.Location = new System.Drawing.Point(161, 111);
            this.addPhoneNum.MaxLength = 20;
            this.addPhoneNum.Name = "addPhoneNum";
            this.addPhoneNum.Size = new System.Drawing.Size(100, 20);
            this.addPhoneNum.TabIndex = 3;
            this.addPhoneNum.TextChanged += new System.EventHandler(this.addPhoneNum_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone Number";
            // 
            // addAddress1
            // 
            this.addAddress1.Location = new System.Drawing.Point(161, 156);
            this.addAddress1.MaxLength = 50;
            this.addAddress1.Name = "addAddress1";
            this.addAddress1.Size = new System.Drawing.Size(100, 20);
            this.addAddress1.TabIndex = 7;
            this.addAddress1.TextChanged += new System.EventHandler(this.addAddress1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // addAddress2
            // 
            this.addAddress2.Location = new System.Drawing.Point(161, 200);
            this.addAddress2.MaxLength = 50;
            this.addAddress2.Name = "addAddress2";
            this.addAddress2.Size = new System.Drawing.Size(100, 20);
            this.addAddress2.TabIndex = 5;
            this.addAddress2.TextChanged += new System.EventHandler(this.addAddress2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address 2 (Optional)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "City";
            // 
            // addPostalCode
            // 
            this.addPostalCode.Location = new System.Drawing.Point(161, 243);
            this.addPostalCode.MaxLength = 10;
            this.addPostalCode.Name = "addPostalCode";
            this.addPostalCode.Size = new System.Drawing.Size(100, 20);
            this.addPostalCode.TabIndex = 11;
            this.addPostalCode.TextChanged += new System.EventHandler(this.addPostalCode_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Postal Code";
            // 
            // saveAddCR
            // 
            this.saveAddCR.Enabled = false;
            this.saveAddCR.Location = new System.Drawing.Point(73, 368);
            this.saveAddCR.Name = "saveAddCR";
            this.saveAddCR.Size = new System.Drawing.Size(121, 48);
            this.saveAddCR.TabIndex = 12;
            this.saveAddCR.Text = "Save";
            this.saveAddCR.UseVisualStyleBackColor = true;
            this.saveAddCR.Click += new System.EventHandler(this.saveAddCR_Click);
            // 
            // cancelAddCR
            // 
            this.cancelAddCR.Location = new System.Drawing.Point(235, 368);
            this.cancelAddCR.Name = "cancelAddCR";
            this.cancelAddCR.Size = new System.Drawing.Size(121, 48);
            this.cancelAddCR.TabIndex = 13;
            this.cancelAddCR.Text = "Cancel";
            this.cancelAddCR.UseVisualStyleBackColor = true;
            this.cancelAddCR.Click += new System.EventHandler(this.cancelAddCR_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Create New Customer Record";
            // 
            // cBCity
            // 
            this.cBCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cBCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBCity.BackColor = System.Drawing.SystemColors.Window;
            this.cBCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCity.Enabled = false;
            this.cBCity.FormattingEnabled = true;
            this.cBCity.Location = new System.Drawing.Point(267, 315);
            this.cBCity.Name = "cBCity";
            this.cBCity.Size = new System.Drawing.Size(121, 21);
            this.cBCity.TabIndex = 17;
            this.cBCity.SelectedIndexChanged += new System.EventHandler(this.cBCity_SelectedIndexChanged);
            this.cBCity.TextChanged += new System.EventHandler(this.cBCity_TextChanged);
            // 
            // cBCountry
            // 
            this.cBCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cBCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCountry.FormattingEnabled = true;
            this.cBCountry.Location = new System.Drawing.Point(66, 315);
            this.cBCountry.Name = "cBCountry";
            this.cBCountry.Size = new System.Drawing.Size(121, 21);
            this.cBCountry.TabIndex = 18;
            this.cBCountry.SelectedIndexChanged += new System.EventHandler(this.cBCountry_SelectedIndexChanged);
            this.cBCountry.TextChanged += new System.EventHandler(this.cBCountry_TextChanged);
            // 
            // plsSelectCountryLbl
            // 
            this.plsSelectCountryLbl.AutoSize = true;
            this.plsSelectCountryLbl.Location = new System.Drawing.Point(70, 299);
            this.plsSelectCountryLbl.Name = "plsSelectCountryLbl";
            this.plsSelectCountryLbl.Size = new System.Drawing.Size(117, 13);
            this.plsSelectCountryLbl.TabIndex = 19;
            this.plsSelectCountryLbl.Text = "Please select a country";
            // 
            // plsSelectCityLbl
            // 
            this.plsSelectCityLbl.AutoSize = true;
            this.plsSelectCityLbl.Location = new System.Drawing.Point(278, 299);
            this.plsSelectCityLbl.Name = "plsSelectCityLbl";
            this.plsSelectCityLbl.Size = new System.Drawing.Size(98, 13);
            this.plsSelectCityLbl.TabIndex = 20;
            this.plsSelectCityLbl.Text = "Please select a city";
            // 
            // phoneNumFormat
            // 
            this.phoneNumFormat.AutoSize = true;
            this.phoneNumFormat.Location = new System.Drawing.Point(158, 95);
            this.phoneNumFormat.Name = "phoneNumFormat";
            this.phoneNumFormat.Size = new System.Drawing.Size(52, 13);
            this.phoneNumFormat.TabIndex = 21;
            this.phoneNumFormat.Text = "111-1111";
            // 
            // wrongPhoneFormatLbl
            // 
            this.wrongPhoneFormatLbl.AutoSize = true;
            this.wrongPhoneFormatLbl.Location = new System.Drawing.Point(267, 114);
            this.wrongPhoneFormatLbl.Name = "wrongPhoneFormatLbl";
            this.wrongPhoneFormatLbl.Size = new System.Drawing.Size(71, 13);
            this.wrongPhoneFormatLbl.TabIndex = 22;
            this.wrongPhoneFormatLbl.Text = "Wrong format";
            this.wrongPhoneFormatLbl.Visible = false;
            // 
            // wrongPostalFormatLbl
            // 
            this.wrongPostalFormatLbl.AutoSize = true;
            this.wrongPostalFormatLbl.Location = new System.Drawing.Point(267, 246);
            this.wrongPostalFormatLbl.Name = "wrongPostalFormatLbl";
            this.wrongPostalFormatLbl.Size = new System.Drawing.Size(153, 13);
            this.wrongPostalFormatLbl.TabIndex = 23;
            this.wrongPostalFormatLbl.Text = "Format does not match country";
            this.wrongPostalFormatLbl.Visible = false;
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 453);
            this.Controls.Add(this.wrongPostalFormatLbl);
            this.Controls.Add(this.wrongPhoneFormatLbl);
            this.Controls.Add(this.phoneNumFormat);
            this.Controls.Add(this.plsSelectCityLbl);
            this.Controls.Add(this.plsSelectCountryLbl);
            this.Controls.Add(this.cBCountry);
            this.Controls.Add(this.cBCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cancelAddCR);
            this.Controls.Add(this.saveAddCR);
            this.Controls.Add(this.addPostalCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addAddress1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addAddress2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addPhoneNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addCName);
            this.Controls.Add(this.label1);
            this.Name = "AddRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddRecord_FormClosing);
            this.Load += new System.EventHandler(this.AddRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addCName;
        private System.Windows.Forms.TextBox addPhoneNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addAddress1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addAddress2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addPostalCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveAddCR;
        private System.Windows.Forms.Button cancelAddCR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cBCity;
        private System.Windows.Forms.ComboBox cBCountry;
        private System.Windows.Forms.Label plsSelectCountryLbl;
        private System.Windows.Forms.Label plsSelectCityLbl;
        private System.Windows.Forms.Label phoneNumFormat;
        private System.Windows.Forms.Label wrongPhoneFormatLbl;
        private System.Windows.Forms.Label wrongPostalFormatLbl;
    }
}