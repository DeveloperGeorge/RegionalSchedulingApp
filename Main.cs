using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace Software2SchedulingApp
{
    public partial class Main : Form
    {

        MySqlConnection con = DB.getConnection();
        DataTable cRecord = new DataTable();
        DataTable appointmentsDT = new DataTable();
        int tempCRIdx;
        int tempAppIdx;
        DateTime currentDate;
        public Main()
        {

            InitializeComponent();
            currentDate = DateTime.Now;
            
            appointmentCalender.AddBoldedDate(currentDate);
            tempCRIdx = -1;
            tempAppIdx = -1;

            con.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT customerId, customerName, phone, address.addressId, address, address2, city, postalCode, country FROM customer, address, city, country WHERE customer.addressId = address.addressId AND address.cityId = city.cityId AND city.countryId = country.countryId", con);        
            adp.Fill(cRecord);

            
            MySqlDataAdapter adp2 = new MySqlDataAdapter("SELECT appointmentId, customer.customerName, customer.customerId, type, start, end  FROM appointment JOIN customer ON appointment.customerId = customer.customerId ORDER BY appointmentId", con);
           
            adp2.Fill(appointmentsDT);
            con.Close();
             


            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            dataGridView2.DefaultCellStyle.SelectionBackColor = dataGridView2.DefaultCellStyle.BackColor;
            dataGridView2.DefaultCellStyle.SelectionForeColor = dataGridView2.DefaultCellStyle.ForeColor;
            dataGridView1.DataSource = cRecord;
            dataGridView1.Columns["customerId"].HeaderText = "ID";
            dataGridView1.Columns["customerName"].HeaderText = "Customer Name";
            dataGridView1.Columns["postalCode"].HeaderText = "Postal Code";
            dataGridView1.Columns["addressId"].HeaderText = "Address ID";
            dataGridView1.Columns["address"].HeaderText = "Primary Address";
            dataGridView1.Columns["address2"].HeaderText = "Secondary Address";
            dataGridView1.Columns["phone"].HeaderText = "Phone";
            dataGridView1.Columns["city"].HeaderText = "City";
            dataGridView1.Columns["country"].HeaderText = "Country";
            dataGridView2.DataSource = appointmentsDT;
            dataGridView2.Columns["appointmentID"].HeaderText = "Appointment ID";
            dataGridView2.Columns["customerId"].HeaderText = "Customer ID";
            dataGridView2.Columns["customerName"].HeaderText = "Customer Name";
            dataGridView2.Columns["type"].HeaderText = "Type";
            dataGridView2.Columns["start"].HeaderText = "Start";
            dataGridView2.Columns["end"].HeaderText = "End";
            getLocalTime();
            alertTimer.Start();
            

            

        }
         private void getLocalTime()
         {
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                dataGridView2.Rows[i].Cells["start"].Value = TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(dataGridView2.Rows[i].Cells["start"].Value.ToString()), DB.currentTimeZone);
                dataGridView2.Rows[i].Cells["end"].Value = TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(dataGridView2.Rows[i].Cells["end"].Value.ToString()), DB.currentTimeZone);
            }
         }


        private void checkForApp()
        {
            DataTable reminderTable = new DataTable();
            using (MySqlConnection con = DB.getConnection())
            {
                MySqlCommand cmd = new MySqlCommand("Select start, appointmentId From appointment", con);
                con.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(reminderTable);
                con.Close();
            }
        
            
            for (int i = 0; i < reminderTable.Rows.Count; i++)
            {
                if (DB.loginTime >= DateTime.Parse(reminderTable.Rows[i][0].ToString()).AddMinutes(-15) && DateTime.Now.ToUniversalTime() <= DateTime.Parse(reminderTable.Rows[i][0].ToString()))
                {
                    DateTime reminderDT = TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reminderTable.Rows[i][0].ToString()), DB.currentTimeZone);
                    MessageBox.Show("Appointment ID: '"+reminderTable.Rows[i][1].ToString()+"' At '"+reminderDT.ToString()+"' starts within 15 minutes");
                    
                }
            }

        }

        private void alertTimer_Tick(object sender, EventArgs e)
        {
            alertTimer.Stop();
            checkForApp();
           // alertTimer.Interval = 60000;
           // alertTimer.Start();
        }

        private void getData(string s)
        {
            using (MySqlConnection con = DB.getConnection())
            {
                MySqlCommand cmd = new MySqlCommand(s, con);
                con.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(appointmentsDT);
                con.Close();
            }
        }

       

        private void handleDay()
        {
            
            appointmentCalender.RemoveAllBoldedDates();
            appointmentCalender.AddBoldedDate(currentDate);
            appointmentCalender.UpdateBoldedDates();
            appointmentsDT.Clear();
            getData("SELECT appointmentId, customer.customerName, customer.customerId, type, start, end  FROM appointment JOIN customer ON appointment.customerId = customer.customerId WHERE  DATE(start) ='" + currentDate.Date.ToString("yyyy/MM/dd") + "' ");
            dataGridView2.DataSource = appointmentsDT;
            getLocalTime();
            
        }

        private void handleWeek()
        {
            appointmentCalender.RemoveAllBoldedDates();
            appointmentsDT.Clear();
            int dow = (int)currentDate.DayOfWeek;
            string startDate = currentDate.AddDays(-dow).ToString();
            DateTime tempDate = Convert.ToDateTime(startDate);
            for(int i = 0; i < 7; i++)
            {
                appointmentCalender.AddBoldedDate(tempDate.AddDays(i));
            }
            appointmentCalender.UpdateBoldedDates();
            string endDate = currentDate.AddDays(7 - dow).ToString();
            DateTime tempEndDate = Convert.ToDateTime(endDate);
            getData("SELECT appointmentId, customerName, customer.customerId, type, start, end  FROM appointment JOIN customer ON appointment.customerId = customer.customerId WHERE DATE(start) Between  '" + tempDate.Date.ToString("yyyy/MM/dd") + "' AND '" + tempEndDate.Date.ToString("yyyy/MM/dd") + "' ");
            dataGridView2.DataSource = appointmentsDT;
            getLocalTime();
        }

        private void handleMonth()
        {
            appointmentCalender.RemoveAllBoldedDates();
            appointmentsDT.Clear();
            int month = currentDate.Month;
            int year = currentDate.Year;
            int day = 0;
            string startDate = month.ToString() + "/01/" + year.ToString();
            DateTime tempDate = Convert.ToDateTime(startDate);
            if (DateTime.IsLeapYear(year))
            {
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                        day = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        day = 30;
                        break;
                    default:
                        day = 29;
                        break;
                }
            }
            else
            {
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                        day = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        day = 30;
                        break;
                    default:
                        day = 28;
                        break;
                }
            }
            for (int i = 0; i < day; i++)
            {
                appointmentCalender.AddBoldedDate(tempDate.AddDays(i));
            }
            appointmentCalender.UpdateBoldedDates();
            string endDate = month.ToString() + "/" + day.ToString() + "/" + year.ToString();
            DateTime tempEndDate = Convert.ToDateTime(endDate);
            getData("SELECT appointmentId, customerName, customer.customerId, type, start, end  FROM appointment JOIN customer ON appointment.customerId = customer.customerId WHERE DATE(start) Between  '" + tempDate.Date.ToString("yyyy/MM/dd") + "' AND '" + tempEndDate.Date.ToString("yyyy/MM/dd") + "' ");
            dataGridView2.DataSource = appointmentsDT;
            getLocalTime();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selCusId = dataGridView1.CurrentRow.Cells["customerId"].Value.ToString();
                DB.curCustomerId = int.Parse(selCusId);
                tempCRIdx = e.RowIndex;
                dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Cyan;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selAppId = dataGridView2.CurrentRow.Cells["appointmentId"].Value.ToString();
                DB.curAppId = int.Parse(selAppId);
                tempAppIdx = e.RowIndex;
                dataGridView2.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Cyan;
            }
        }

        private void addCR_Click(object sender, EventArgs e)
        {
            alertTimer.Stop();
            this.Hide();
            AddRecord addRecord = new AddRecord();
            addRecord.Show();
        }

        private void modifyCR_Click(object sender, EventArgs e)
        {
            if (tempCRIdx >= 0)
            {
                alertTimer.Stop();
                this.Hide();
                ModifyRecord modifyRecord = new ModifyRecord();
                modifyRecord.Show();
            }
            else
            {
                MessageBox.Show("Please select customer record to modify.");
            }
            
        }

        private void deleteCR_Click(object sender, EventArgs e)
        {
            if (tempCRIdx >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this customer record?", "Delete Customer Record Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool crDelete = DB.deleteCR(tempCRIdx);
                    if (crDelete == true)
                    {
                        if(con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        string selCusId = dataGridView1.CurrentRow.Cells["customerId"].Value.ToString();
                        string selCusName = dataGridView1.CurrentRow.Cells["CustomerName"].Value.ToString();
                        string selCusPhone = dataGridView1.CurrentRow.Cells["phone"].Value.ToString();
                        string selCusAddressId = dataGridView1.CurrentRow.Cells["addressId"].Value.ToString();
                        string selCusPrimeAddress = dataGridView1.CurrentRow.Cells["address"].Value.ToString();
                        string selCusSecAddress = dataGridView1.CurrentRow.Cells["address2"].Value.ToString();
                        string selCusPostal = dataGridView1.CurrentRow.Cells["postalCode"].Value.ToString();

                        
                        MySqlCommand cmd1 = new MySqlCommand("Delete From customer Where customerId = @customerId", con);
                        cmd1.Parameters.AddWithValue("@customerId", selCusId);
                        cmd1.ExecuteNonQuery();
                        MySqlCommand cmd = new MySqlCommand("Delete From address Where addressId = @addressId", con);
                        cmd.Parameters.AddWithValue("@addressId", selCusAddressId);
                        cmd.ExecuteNonQuery();

                        dataGridView1.Rows.RemoveAt(tempCRIdx);
                        dataGridView1.ClearSelection();
                        
                    }
                    else
                    {
                        MessageBox.Show("Nothing to Delete");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select customer record to delete.");

            }
        }

        private void addApp_Click(object sender, EventArgs e)
        {
            alertTimer.Stop();
            this.Hide();
            AddAppointment addAppointment = new AddAppointment();
            addAppointment.Show();
        }

        private void modifyApp_Click(object sender, EventArgs e)
        {
            if (tempAppIdx >= 0)
            {
                alertTimer.Stop();
                this.Hide();
                ModifyAppointment modifyAppointment = new ModifyAppointment();
                modifyAppointment.Show();
            }
            else
            {
                MessageBox.Show("Please select appointment to modify.");
            }
            
        }

        private void deleteApp_Click(object sender, EventArgs e)
        {
            if (tempAppIdx >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this appointment?", "Delete Appointment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool appDelete = DB.deleteApp(tempAppIdx);
                    if (appDelete == true)
                    {
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        string selAppId = dataGridView2.CurrentRow.Cells["appointmentId"].Value.ToString();
                        


                        MySqlCommand cmd1 = new MySqlCommand("Delete From appointment Where appointmentId = @appointmentId", con);
                        cmd1.Parameters.AddWithValue("@appointmentId", selAppId);
                        cmd1.ExecuteNonQuery();                
                        dataGridView2.Rows.RemoveAt(tempAppIdx);
                        dataGridView2.ClearSelection();

                    }
                    else
                    {
                        MessageBox.Show("Nothing to Delete");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select customer record to delete.");

            }
        }

        private void rBDay_CheckedChanged(object sender, EventArgs e)
        {
            handleDay();
        }

        private void rBWeek_CheckedChanged(object sender, EventArgs e)
        {
            handleWeek();
        }

        private void rBMonth_CheckedChanged(object sender, EventArgs e)
        {
            handleMonth();
        }

        private void appointmentCalender_DateChanged(object sender, DateRangeEventArgs e)
        {
             
        }

        private void appointmentCalender_DateSelected(object sender, DateRangeEventArgs e)
        {
            currentDate = appointmentCalender.SelectionStart.ToUniversalTime();
            if(rBDay.Checked == true)
            {
                handleDay();
            }
            else if(rBWeek.Checked == true)
            {
                handleWeek();
            }
            else if(rBMonth.Checked == true)
            {
                handleMonth();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rBDay.Checked == true)
            {
                rBDay.Checked = false;
            }
            else if (rBWeek.Checked == true)
            {
                rBWeek.Checked = false;
            }
            else if (rBMonth.Checked == true)
            {
                rBMonth.Checked = false;
            }
            appointmentsDT.Clear();         
            appointmentCalender.RemoveAllBoldedDates();
            currentDate = DateTime.Now;
            appointmentCalender.AddBoldedDate(currentDate);
            appointmentCalender.UpdateBoldedDates();
            con.Open();
            MySqlDataAdapter adp2 = new MySqlDataAdapter("SELECT appointmentId, customer.customerName, customer.customerId, type, start, end  FROM appointment JOIN customer ON appointment.customerId = customer.customerId", con);
            adp2.Fill(appointmentsDT);
            con.Close();
            getLocalTime();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            alertTimer.Stop();
            this.Hide();
            ReportPage reportPage = new ReportPage();
            reportPage.Show();
        }
    }
}
