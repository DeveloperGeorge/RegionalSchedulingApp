namespace Software2SchedulingApp
{
    partial class ModifyRecord
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
            this.cBCountry = new System.Windows.Forms.ComboBox();
            this.cBCity = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cancelModCR = new System.Windows.Forms.Button();
            this.saveModCR = new System.Windows.Forms.Button();
            this.modPostalCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.modAddress1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.modAddress2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modPhoneNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modCName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.modCId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.plsSelectCityLbl = new System.Windows.Forms.Label();
            this.plsSelectCountryLbl = new System.Windows.Forms.Label();
            this.wrongPostalFormatLbl = new System.Windows.Forms.Label();
            this.wrongPhoneFormatLbl = new System.Windows.Forms.Label();
            this.phoneNumFormat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cBCountry
            // 
            this.cBCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cBCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCountry.FormattingEnabled = true;
            this.cBCountry.Location = new System.Drawing.Point(72, 347);
            this.cBCountry.Name = "cBCountry";
            this.cBCountry.Size = new System.Drawing.Size(121, 21);
            this.cBCountry.TabIndex = 34;
            this.cBCountry.SelectedIndexChanged += new System.EventHandler(this.cBCountry_SelectedIndexChanged);
            this.cBCountry.TextChanged += new System.EventHandler(this.cBCountry_TextChanged);
            this.cBCountry.Enter += new System.EventHandler(this.cBCountry_Enter);
            this.cBCountry.StyleChanged += new System.EventHandler(this.cBCountry_StyleChanged);
            // 
            // cBCity
            // 
            this.cBCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cBCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBCity.BackColor = System.Drawing.SystemColors.Window;
            this.cBCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCity.FormattingEnabled = true;
            this.cBCity.Location = new System.Drawing.Point(273, 347);
            this.cBCity.Name = "cBCity";
            this.cBCity.Size = new System.Drawing.Size(121, 21);
            this.cBCity.TabIndex = 33;
            this.cBCity.SelectedIndexChanged += new System.EventHandler(this.cBCity_SelectedIndexChanged);
            this.cBCity.TextChanged += new System.EventHandler(this.cBCity_TextChanged);
            this.cBCity.Enter += new System.EventHandler(this.cBCity_Enter);
            this.cBCity.StyleChanged += new System.EventHandler(this.cBCity_StyleChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Update Customer Record";
            // 
            // cancelModCR
            // 
            this.cancelModCR.Location = new System.Drawing.Point(247, 393);
            this.cancelModCR.Name = "cancelModCR";
            this.cancelModCR.Size = new System.Drawing.Size(121, 48);
            this.cancelModCR.TabIndex = 31;
            this.cancelModCR.Text = "Cancel";
            this.cancelModCR.UseVisualStyleBackColor = true;
            this.cancelModCR.Click += new System.EventHandler(this.cancelModCR_Click);
            // 
            // saveModCR
            // 
            this.saveModCR.Enabled = false;
            this.saveModCR.Location = new System.Drawing.Point(85, 393);
            this.saveModCR.Name = "saveModCR";
            this.saveModCR.Size = new System.Drawing.Size(121, 48);
            this.saveModCR.TabIndex = 30;
            this.saveModCR.Text = "Save";
            this.saveModCR.UseVisualStyleBackColor = true;
            this.saveModCR.Click += new System.EventHandler(this.saveModCR_Click);
            // 
            // modPostalCode
            // 
            this.modPostalCode.Location = new System.Drawing.Point(172, 284);
            this.modPostalCode.MaxLength = 10;
            this.modPostalCode.Name = "modPostalCode";
            this.modPostalCode.Size = new System.Drawing.Size(100, 20);
            this.modPostalCode.TabIndex = 29;
            this.modPostalCode.TextChanged += new System.EventHandler(this.modPostalCode_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Postal Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "City";
            // 
            // modAddress1
            // 
            this.modAddress1.Location = new System.Drawing.Point(172, 197);
            this.modAddress1.MaxLength = 50;
            this.modAddress1.Name = "modAddress1";
            this.modAddress1.Size = new System.Drawing.Size(100, 20);
            this.modAddress1.TabIndex = 26;
            this.modAddress1.TextChanged += new System.EventHandler(this.modAddress1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Address";
            // 
            // modAddress2
            // 
            this.modAddress2.Location = new System.Drawing.Point(172, 241);
            this.modAddress2.MaxLength = 50;
            this.modAddress2.Name = "modAddress2";
            this.modAddress2.Size = new System.Drawing.Size(100, 20);
            this.modAddress2.TabIndex = 24;
            this.modAddress2.TextChanged += new System.EventHandler(this.modAddress2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Address 2 (Optional)";
            // 
            // modPhoneNum
            // 
            this.modPhoneNum.Location = new System.Drawing.Point(172, 152);
            this.modPhoneNum.MaxLength = 20;
            this.modPhoneNum.Name = "modPhoneNum";
            this.modPhoneNum.Size = new System.Drawing.Size(100, 20);
            this.modPhoneNum.TabIndex = 22;
            this.modPhoneNum.TextChanged += new System.EventHandler(this.modPhoneNum_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Phone Number";
            // 
            // modCName
            // 
            this.modCName.Location = new System.Drawing.Point(172, 108);
            this.modCName.MaxLength = 45;
            this.modCName.Name = "modCName";
            this.modCName.Size = new System.Drawing.Size(100, 20);
            this.modCName.TabIndex = 20;
            this.modCName.TextChanged += new System.EventHandler(this.modCName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Customer Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Country";
            // 
            // modCId
            // 
            this.modCId.Enabled = false;
            this.modCId.Location = new System.Drawing.Point(172, 68);
            this.modCId.Name = "modCId";
            this.modCId.Size = new System.Drawing.Size(100, 20);
            this.modCId.TabIndex = 37;
            this.modCId.TextChanged += new System.EventHandler(this.modCId_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Customer Id";
            // 
            // plsSelectCityLbl
            // 
            this.plsSelectCityLbl.AutoSize = true;
            this.plsSelectCityLbl.Location = new System.Drawing.Point(286, 331);
            this.plsSelectCityLbl.Name = "plsSelectCityLbl";
            this.plsSelectCityLbl.Size = new System.Drawing.Size(98, 13);
            this.plsSelectCityLbl.TabIndex = 39;
            this.plsSelectCityLbl.Text = "Please select a city";
            this.plsSelectCityLbl.Visible = false;
            // 
            // plsSelectCountryLbl
            // 
            this.plsSelectCountryLbl.AutoSize = true;
            this.plsSelectCountryLbl.Location = new System.Drawing.Point(78, 331);
            this.plsSelectCountryLbl.Name = "plsSelectCountryLbl";
            this.plsSelectCountryLbl.Size = new System.Drawing.Size(117, 13);
            this.plsSelectCountryLbl.TabIndex = 38;
            this.plsSelectCountryLbl.Text = "Please select a country";
            this.plsSelectCountryLbl.Visible = false;
            // 
            // wrongPostalFormatLbl
            // 
            this.wrongPostalFormatLbl.AutoSize = true;
            this.wrongPostalFormatLbl.Location = new System.Drawing.Point(278, 287);
            this.wrongPostalFormatLbl.Name = "wrongPostalFormatLbl";
            this.wrongPostalFormatLbl.Size = new System.Drawing.Size(153, 13);
            this.wrongPostalFormatLbl.TabIndex = 41;
            this.wrongPostalFormatLbl.Text = "Format does not match country";
            this.wrongPostalFormatLbl.Visible = false;
            // 
            // wrongPhoneFormatLbl
            // 
            this.wrongPhoneFormatLbl.AutoSize = true;
            this.wrongPhoneFormatLbl.Location = new System.Drawing.Point(278, 155);
            this.wrongPhoneFormatLbl.Name = "wrongPhoneFormatLbl";
            this.wrongPhoneFormatLbl.Size = new System.Drawing.Size(71, 13);
            this.wrongPhoneFormatLbl.TabIndex = 40;
            this.wrongPhoneFormatLbl.Text = "Wrong format";
            this.wrongPhoneFormatLbl.Visible = false;
            // 
            // phoneNumFormat
            // 
            this.phoneNumFormat.AutoSize = true;
            this.phoneNumFormat.Location = new System.Drawing.Point(169, 136);
            this.phoneNumFormat.Name = "phoneNumFormat";
            this.phoneNumFormat.Size = new System.Drawing.Size(52, 13);
            this.phoneNumFormat.TabIndex = 42;
            this.phoneNumFormat.Text = "111-1111";
            // 
            // ModifyRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 453);
            this.Controls.Add(this.phoneNumFormat);
            this.Controls.Add(this.wrongPostalFormatLbl);
            this.Controls.Add(this.wrongPhoneFormatLbl);
            this.Controls.Add(this.plsSelectCityLbl);
            this.Controls.Add(this.plsSelectCountryLbl);
            this.Controls.Add(this.modCId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cBCountry);
            this.Controls.Add(this.cBCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cancelModCR);
            this.Controls.Add(this.saveModCR);
            this.Controls.Add(this.modPostalCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.modAddress1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modAddress2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modPhoneNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modCName);
            this.Controls.Add(this.label1);
            this.Name = "ModifyRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModifyRecord_FormClosing);
            this.Load += new System.EventHandler(this.ModifyRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBCountry;
        private System.Windows.Forms.ComboBox cBCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancelModCR;
        private System.Windows.Forms.Button saveModCR;
        private System.Windows.Forms.TextBox modPostalCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox modAddress1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox modAddress2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox modPhoneNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modCName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox modCId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label plsSelectCityLbl;
        private System.Windows.Forms.Label plsSelectCountryLbl;
        private System.Windows.Forms.Label wrongPostalFormatLbl;
        private System.Windows.Forms.Label wrongPhoneFormatLbl;
        private System.Windows.Forms.Label phoneNumFormat;
    }
}