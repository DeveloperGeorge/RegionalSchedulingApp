namespace Software2SchedulingApp
{
    partial class AddAppointment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cusId = new System.Windows.Forms.TextBox();
            this.cusName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cBAppType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addAppSaveBtn = new System.Windows.Forms.Button();
            this.addAppCancelBtn = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.appLbl = new System.Windows.Forms.Label();
            this.bHrLbl = new System.Windows.Forms.Label();
            this.overlapEndPicker = new System.Windows.Forms.DateTimePicker();
            this.overlapStartPicker = new System.Windows.Forms.DateTimePicker();
            this.overlapLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New Appointment";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(330, 74);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(229, 266);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Appointment Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Appointment Start";
            // 
            // cusId
            // 
            this.cusId.Enabled = false;
            this.cusId.Location = new System.Drawing.Point(124, 133);
            this.cusId.Name = "cusId";
            this.cusId.Size = new System.Drawing.Size(100, 20);
            this.cusId.TabIndex = 7;
            this.cusId.TextChanged += new System.EventHandler(this.cusId_TextChanged);
            // 
            // cusName
            // 
            this.cusName.Enabled = false;
            this.cusName.Location = new System.Drawing.Point(124, 192);
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(100, 20);
            this.cusName.TabIndex = 8;
            this.cusName.TextChanged += new System.EventHandler(this.cusName_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 412);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cBAppType
            // 
            this.cBAppType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBAppType.FormattingEnabled = true;
            this.cBAppType.Items.AddRange(new object[] {
            "Presentation",
            "Scrum"});
            this.cBAppType.Location = new System.Drawing.Point(125, 279);
            this.cBAppType.Name = "cBAppType";
            this.cBAppType.Size = new System.Drawing.Size(121, 21);
            this.cBAppType.TabIndex = 11;
            this.cBAppType.SelectedValueChanged += new System.EventHandler(this.cBAppType_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Select Customer For Appointment";
            // 
            // addAppSaveBtn
            // 
            this.addAppSaveBtn.Enabled = false;
            this.addAppSaveBtn.Location = new System.Drawing.Point(365, 541);
            this.addAppSaveBtn.Name = "addAppSaveBtn";
            this.addAppSaveBtn.Size = new System.Drawing.Size(107, 42);
            this.addAppSaveBtn.TabIndex = 16;
            this.addAppSaveBtn.Text = "Save";
            this.addAppSaveBtn.UseVisualStyleBackColor = true;
            this.addAppSaveBtn.Click += new System.EventHandler(this.addAppSaveBtn_Click);
            // 
            // addAppCancelBtn
            // 
            this.addAppCancelBtn.Location = new System.Drawing.Point(487, 541);
            this.addAppCancelBtn.Name = "addAppCancelBtn";
            this.addAppCancelBtn.Size = new System.Drawing.Size(107, 42);
            this.addAppCancelBtn.TabIndex = 17;
            this.addAppCancelBtn.Text = "Cancel";
            this.addAppCancelBtn.UseVisualStyleBackColor = true;
            this.addAppCancelBtn.Click += new System.EventHandler(this.addAppCancelBtn_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(125, 468);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker2.TabIndex = 19;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Appointment End";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "YYYY-MM-DD   HH:MM:SS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "YYYY-MM-DD   HH:MM:SS";
            // 
            // appLbl
            // 
            this.appLbl.AutoSize = true;
            this.appLbl.Location = new System.Drawing.Point(122, 263);
            this.appLbl.Name = "appLbl";
            this.appLbl.Size = new System.Drawing.Size(154, 13);
            this.appLbl.TabIndex = 22;
            this.appLbl.Text = "Please select appointment type";
            // 
            // bHrLbl
            // 
            this.bHrLbl.Location = new System.Drawing.Point(40, 358);
            this.bHrLbl.Name = "bHrLbl";
            this.bHrLbl.Size = new System.Drawing.Size(220, 29);
            this.bHrLbl.TabIndex = 23;
            this.bHrLbl.Text = "Appointment must stay within business hours: Monday-Friday  8:00 AM - 5:00 PM";
            // 
            // overlapEndPicker
            // 
            this.overlapEndPicker.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.overlapEndPicker.Enabled = false;
            this.overlapEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.overlapEndPicker.Location = new System.Drawing.Point(356, 468);
            this.overlapEndPicker.Name = "overlapEndPicker";
            this.overlapEndPicker.Size = new System.Drawing.Size(161, 20);
            this.overlapEndPicker.TabIndex = 25;
            // 
            // overlapStartPicker
            // 
            this.overlapStartPicker.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.overlapStartPicker.Enabled = false;
            this.overlapStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.overlapStartPicker.Location = new System.Drawing.Point(356, 412);
            this.overlapStartPicker.Name = "overlapStartPicker";
            this.overlapStartPicker.Size = new System.Drawing.Size(161, 20);
            this.overlapStartPicker.TabIndex = 24;
            // 
            // overlapLbl
            // 
            this.overlapLbl.AutoSize = true;
            this.overlapLbl.Location = new System.Drawing.Point(327, 386);
            this.overlapLbl.Name = "overlapLbl";
            this.overlapLbl.Size = new System.Drawing.Size(222, 13);
            this.overlapLbl.TabIndex = 26;
            this.overlapLbl.Text = "There is an overlap with this appointment time";
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 595);
            this.Controls.Add(this.overlapLbl);
            this.Controls.Add(this.overlapEndPicker);
            this.Controls.Add(this.overlapStartPicker);
            this.Controls.Add(this.bHrLbl);
            this.Controls.Add(this.appLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addAppCancelBtn);
            this.Controls.Add(this.addAppSaveBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cBAppType);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cusName);
            this.Controls.Add(this.cusId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "AddAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Appointment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddAppointment_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cusId;
        private System.Windows.Forms.TextBox cusName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cBAppType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addAppSaveBtn;
        private System.Windows.Forms.Button addAppCancelBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label appLbl;
        private System.Windows.Forms.Label bHrLbl;
        private System.Windows.Forms.DateTimePicker overlapEndPicker;
        private System.Windows.Forms.DateTimePicker overlapStartPicker;
        private System.Windows.Forms.Label overlapLbl;
    }
}