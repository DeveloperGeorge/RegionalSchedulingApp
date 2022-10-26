namespace Software2SchedulingApp
{
    partial class Main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.customerRec = new System.Windows.Forms.Label();
            this.appointments = new System.Windows.Forms.Label();
            this.addCR = new System.Windows.Forms.Button();
            this.modifyCR = new System.Windows.Forms.Button();
            this.deleteCR = new System.Windows.Forms.Button();
            this.deleteApp = new System.Windows.Forms.Button();
            this.modifyApp = new System.Windows.Forms.Button();
            this.addApp = new System.Windows.Forms.Button();
            this.appointmentCalender = new System.Windows.Forms.MonthCalendar();
            this.rBDay = new System.Windows.Forms.RadioButton();
            this.rBWeek = new System.Windows.Forms.RadioButton();
            this.rBMonth = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.alertTimer = new System.Windows.Forms.Timer(this.components);
            this.reportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(473, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(583, 73);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(472, 236);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // customerRec
            // 
            this.customerRec.AutoSize = true;
            this.customerRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerRec.Location = new System.Drawing.Point(9, 54);
            this.customerRec.Name = "customerRec";
            this.customerRec.Size = new System.Drawing.Size(136, 16);
            this.customerRec.TabIndex = 2;
            this.customerRec.Text = "Customer Records";
            // 
            // appointments
            // 
            this.appointments.AutoSize = true;
            this.appointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointments.Location = new System.Drawing.Point(580, 54);
            this.appointments.Name = "appointments";
            this.appointments.Size = new System.Drawing.Size(102, 16);
            this.appointments.TabIndex = 3;
            this.appointments.Text = "Appointments";
            // 
            // addCR
            // 
            this.addCR.Location = new System.Drawing.Point(221, 332);
            this.addCR.Name = "addCR";
            this.addCR.Size = new System.Drawing.Size(84, 29);
            this.addCR.TabIndex = 4;
            this.addCR.Text = "Add";
            this.addCR.UseVisualStyleBackColor = true;
            this.addCR.Click += new System.EventHandler(this.addCR_Click);
            // 
            // modifyCR
            // 
            this.modifyCR.Location = new System.Drawing.Point(311, 332);
            this.modifyCR.Name = "modifyCR";
            this.modifyCR.Size = new System.Drawing.Size(84, 29);
            this.modifyCR.TabIndex = 5;
            this.modifyCR.Text = "Modify";
            this.modifyCR.UseVisualStyleBackColor = true;
            this.modifyCR.Click += new System.EventHandler(this.modifyCR_Click);
            // 
            // deleteCR
            // 
            this.deleteCR.Location = new System.Drawing.Point(401, 332);
            this.deleteCR.Name = "deleteCR";
            this.deleteCR.Size = new System.Drawing.Size(84, 29);
            this.deleteCR.TabIndex = 6;
            this.deleteCR.Text = "Delete";
            this.deleteCR.UseVisualStyleBackColor = true;
            this.deleteCR.Click += new System.EventHandler(this.deleteCR_Click);
            // 
            // deleteApp
            // 
            this.deleteApp.Location = new System.Drawing.Point(969, 332);
            this.deleteApp.Name = "deleteApp";
            this.deleteApp.Size = new System.Drawing.Size(84, 29);
            this.deleteApp.TabIndex = 9;
            this.deleteApp.Text = "Delete";
            this.deleteApp.UseVisualStyleBackColor = true;
            this.deleteApp.Click += new System.EventHandler(this.deleteApp_Click);
            // 
            // modifyApp
            // 
            this.modifyApp.Location = new System.Drawing.Point(879, 332);
            this.modifyApp.Name = "modifyApp";
            this.modifyApp.Size = new System.Drawing.Size(84, 29);
            this.modifyApp.TabIndex = 8;
            this.modifyApp.Text = "Modify";
            this.modifyApp.UseVisualStyleBackColor = true;
            this.modifyApp.Click += new System.EventHandler(this.modifyApp_Click);
            // 
            // addApp
            // 
            this.addApp.Location = new System.Drawing.Point(789, 332);
            this.addApp.Name = "addApp";
            this.addApp.Size = new System.Drawing.Size(84, 29);
            this.addApp.TabIndex = 7;
            this.addApp.Text = "Add";
            this.addApp.UseVisualStyleBackColor = true;
            this.addApp.Click += new System.EventHandler(this.addApp_Click);
            // 
            // appointmentCalender
            // 
            this.appointmentCalender.Location = new System.Drawing.Point(583, 373);
            this.appointmentCalender.Name = "appointmentCalender";
            this.appointmentCalender.TabIndex = 10;
            this.appointmentCalender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.appointmentCalender_DateChanged);
            this.appointmentCalender.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.appointmentCalender_DateSelected);
            // 
            // rBDay
            // 
            this.rBDay.AutoSize = true;
            this.rBDay.Location = new System.Drawing.Point(6, 19);
            this.rBDay.Name = "rBDay";
            this.rBDay.Size = new System.Drawing.Size(44, 17);
            this.rBDay.TabIndex = 11;
            this.rBDay.TabStop = true;
            this.rBDay.Text = "Day";
            this.rBDay.UseVisualStyleBackColor = true;
            this.rBDay.CheckedChanged += new System.EventHandler(this.rBDay_CheckedChanged);
            // 
            // rBWeek
            // 
            this.rBWeek.AutoSize = true;
            this.rBWeek.Location = new System.Drawing.Point(6, 42);
            this.rBWeek.Name = "rBWeek";
            this.rBWeek.Size = new System.Drawing.Size(54, 17);
            this.rBWeek.TabIndex = 12;
            this.rBWeek.TabStop = true;
            this.rBWeek.Text = "Week";
            this.rBWeek.UseVisualStyleBackColor = true;
            this.rBWeek.CheckedChanged += new System.EventHandler(this.rBWeek_CheckedChanged);
            // 
            // rBMonth
            // 
            this.rBMonth.AutoSize = true;
            this.rBMonth.Location = new System.Drawing.Point(5, 65);
            this.rBMonth.Name = "rBMonth";
            this.rBMonth.Size = new System.Drawing.Size(55, 17);
            this.rBMonth.TabIndex = 13;
            this.rBMonth.TabStop = true;
            this.rBMonth.Text = "Month";
            this.rBMonth.UseVisualStyleBackColor = true;
            this.rBMonth.CheckedChanged += new System.EventHandler(this.rBMonth_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rBMonth);
            this.groupBox1.Controls.Add(this.rBWeek);
            this.groupBox1.Controls.Add(this.rBDay);
            this.groupBox1.Location = new System.Drawing.Point(822, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 120);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calender View Options";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alertTimer
            // 
            this.alertTimer.Interval = 1000;
            this.alertTimer.Tick += new System.EventHandler(this.alertTimer_Tick);
            // 
            // reportBtn
            // 
            this.reportBtn.Location = new System.Drawing.Point(143, 438);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(148, 69);
            this.reportBtn.TabIndex = 15;
            this.reportBtn.Text = "Reports Page";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 560);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.appointmentCalender);
            this.Controls.Add(this.deleteApp);
            this.Controls.Add(this.modifyApp);
            this.Controls.Add(this.addApp);
            this.Controls.Add(this.deleteCR);
            this.Controls.Add(this.modifyCR);
            this.Controls.Add(this.addCR);
            this.Controls.Add(this.appointments);
            this.Controls.Add(this.customerRec);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label customerRec;
        private System.Windows.Forms.Label appointments;
        private System.Windows.Forms.Button addCR;
        private System.Windows.Forms.Button modifyCR;
        private System.Windows.Forms.Button deleteCR;
        private System.Windows.Forms.Button deleteApp;
        private System.Windows.Forms.Button modifyApp;
        private System.Windows.Forms.Button addApp;
        private System.Windows.Forms.MonthCalendar appointmentCalender;
        private System.Windows.Forms.RadioButton rBDay;
        private System.Windows.Forms.RadioButton rBWeek;
        private System.Windows.Forms.RadioButton rBMonth;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer alertTimer;
        private System.Windows.Forms.Button reportBtn;
    }
}