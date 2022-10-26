namespace Software2SchedulingApp
{
    partial class ModifyAppointment
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.addAppCancelBtn = new System.Windows.Forms.Button();
            this.addAppSaveBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cBAppType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cusName = new System.Windows.Forms.TextBox();
            this.cusId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.appId = new System.Windows.Forms.TextBox();
            this.bHrLbl = new System.Windows.Forms.Label();
            this.overlapLbl = new System.Windows.Forms.Label();
            this.overlapEndPicker = new System.Windows.Forms.DateTimePicker();
            this.overlapStartPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 470);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "YYYY-MM-DD   HH:MM:SS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "YYYY-MM-DD   HH:MM:SS";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(119, 486);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker2.TabIndex = 36;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Appointment End";
            // 
            // addAppCancelBtn
            // 
            this.addAppCancelBtn.Location = new System.Drawing.Point(478, 553);
            this.addAppCancelBtn.Name = "addAppCancelBtn";
            this.addAppCancelBtn.Size = new System.Drawing.Size(107, 42);
            this.addAppCancelBtn.TabIndex = 34;
            this.addAppCancelBtn.Text = "Cancel";
            this.addAppCancelBtn.UseVisualStyleBackColor = true;
            this.addAppCancelBtn.Click += new System.EventHandler(this.addAppCancelBtn_Click);
            // 
            // addAppSaveBtn
            // 
            this.addAppSaveBtn.Location = new System.Drawing.Point(356, 553);
            this.addAppSaveBtn.Name = "addAppSaveBtn";
            this.addAppSaveBtn.Size = new System.Drawing.Size(107, 42);
            this.addAppSaveBtn.TabIndex = 33;
            this.addAppSaveBtn.Text = "Save";
            this.addAppSaveBtn.UseVisualStyleBackColor = true;
            this.addAppSaveBtn.Click += new System.EventHandler(this.addAppSaveBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Select Customer For Appointment";
            // 
            // cBAppType
            // 
            this.cBAppType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBAppType.FormattingEnabled = true;
            this.cBAppType.Items.AddRange(new object[] {
            "Presentation",
            "Scrum"});
            this.cBAppType.Location = new System.Drawing.Point(125, 291);
            this.cBAppType.Name = "cBAppType";
            this.cBAppType.Size = new System.Drawing.Size(121, 21);
            this.cBAppType.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 430);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cusName
            // 
            this.cusName.Enabled = false;
            this.cusName.Location = new System.Drawing.Point(128, 225);
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(100, 20);
            this.cusName.TabIndex = 29;
            // 
            // cusId
            // 
            this.cusId.Enabled = false;
            this.cusId.Location = new System.Drawing.Point(128, 168);
            this.cusId.Name = "cusId";
            this.cusId.Size = new System.Drawing.Size(100, 20);
            this.cusId.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Appointment Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Appointment Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Customer ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 78);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(229, 266);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Update Appointment";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Appointment ID";
            // 
            // appId
            // 
            this.appId.Enabled = false;
            this.appId.Location = new System.Drawing.Point(128, 114);
            this.appId.Name = "appId";
            this.appId.Size = new System.Drawing.Size(100, 20);
            this.appId.TabIndex = 40;
            // 
            // bHrLbl
            // 
            this.bHrLbl.Location = new System.Drawing.Point(48, 372);
            this.bHrLbl.Name = "bHrLbl";
            this.bHrLbl.Size = new System.Drawing.Size(220, 29);
            this.bHrLbl.TabIndex = 41;
            this.bHrLbl.Text = "Appointment must stay within business hours: Monday-Friday  8:00 AM - 5:00 PM";
            // 
            // overlapLbl
            // 
            this.overlapLbl.AutoSize = true;
            this.overlapLbl.Location = new System.Drawing.Point(325, 402);
            this.overlapLbl.Name = "overlapLbl";
            this.overlapLbl.Size = new System.Drawing.Size(222, 13);
            this.overlapLbl.TabIndex = 44;
            this.overlapLbl.Text = "There is an overlap with this appointment time";
            // 
            // overlapEndPicker
            // 
            this.overlapEndPicker.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.overlapEndPicker.Enabled = false;
            this.overlapEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.overlapEndPicker.Location = new System.Drawing.Point(356, 485);
            this.overlapEndPicker.Name = "overlapEndPicker";
            this.overlapEndPicker.Size = new System.Drawing.Size(161, 20);
            this.overlapEndPicker.TabIndex = 43;
            // 
            // overlapStartPicker
            // 
            this.overlapStartPicker.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.overlapStartPicker.Enabled = false;
            this.overlapStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.overlapStartPicker.Location = new System.Drawing.Point(356, 429);
            this.overlapStartPicker.Name = "overlapStartPicker";
            this.overlapStartPicker.Size = new System.Drawing.Size(161, 20);
            this.overlapStartPicker.TabIndex = 42;
            // 
            // ModifyAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 607);
            this.Controls.Add(this.overlapLbl);
            this.Controls.Add(this.overlapEndPicker);
            this.Controls.Add(this.overlapStartPicker);
            this.Controls.Add(this.bHrLbl);
            this.Controls.Add(this.appId);
            this.Controls.Add(this.label10);
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
            this.Name = "ModifyAppointment";
            this.Text = "Modify Appointment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModifyAppointment_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addAppCancelBtn;
        private System.Windows.Forms.Button addAppSaveBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBAppType;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox cusName;
        private System.Windows.Forms.TextBox cusId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox appId;
        private System.Windows.Forms.Label bHrLbl;
        private System.Windows.Forms.Label overlapLbl;
        private System.Windows.Forms.DateTimePicker overlapEndPicker;
        private System.Windows.Forms.DateTimePicker overlapStartPicker;
    }
}