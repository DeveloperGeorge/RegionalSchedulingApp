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

namespace Software2SchedulingApp
{
    public partial class ReportPage : Form
    {
        MySqlConnection con = DB.getConnection();
        
        
        DateTime currentDate;
        DataTable cRecord = new DataTable();
        DataTable consultants = new DataTable();
        DataTable schedules = new DataTable();
        DataTable appPresType = new DataTable();
        DataTable appScrumType = new DataTable();
        int curAppCount;
        int tempCusId;
        int tempScheduleId;
        public ReportPage()
        {
            InitializeComponent();
            tempScheduleId = -1;
            curAppCount = 0;
            tempCusId = 0;
            currentDate = DateTime.Now;
            handleMonth();

            con.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT customerId, customerName FROM customer", con);
            adp.Fill(cRecord);

            MySqlDataAdapter adp2 = new MySqlDataAdapter("SELECT userId, userName  FROM user", con);
            adp2.Fill(consultants);
            con.Close();



            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            dataGridView2.DefaultCellStyle.SelectionBackColor = dataGridView2.DefaultCellStyle.BackColor;
            dataGridView2.DefaultCellStyle.SelectionForeColor = dataGridView2.DefaultCellStyle.ForeColor;
            dataGridView3.DefaultCellStyle.SelectionBackColor = dataGridView2.DefaultCellStyle.BackColor;
            dataGridView3.DefaultCellStyle.SelectionForeColor = dataGridView2.DefaultCellStyle.ForeColor;


            dataGridView2.DataSource = cRecord;
            dataGridView2.Columns["customerId"].HeaderText = "ID";
            dataGridView2.Columns["customerName"].HeaderText = "Customer Name";

            dataGridView3.DataSource = consultants;
            dataGridView3.Columns["userId"].HeaderText = "ID";
            dataGridView3.Columns["userName"].HeaderText = "Consultant";

            

        }

        private void getLocalTime()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["start"].Value = TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(dataGridView1.Rows[i].Cells["start"].Value.ToString()), DB.currentTimeZone);
                dataGridView1.Rows[i].Cells["end"].Value = TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(dataGridView1.Rows[i].Cells["end"].Value.ToString()), DB.currentTimeZone);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void ReportPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                string selCusId = dataGridView2.CurrentRow.Cells["customerId"].Value.ToString();
                tempCusId = int.Parse(selCusId);
                dataGridView2.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Cyan;
                getCustomerAppNum();
                numAppsBox.Text = curAppCount.ToString();
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selConId = dataGridView3.CurrentRow.Cells["userId"].Value.ToString();
                tempScheduleId = int.Parse(selConId);
                dataGridView3.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Cyan;
                getSchedule();

            }
        }

        private void getSchedule()
        {
            schedules.Clear();
            
            using (con)
            {
                con.Open();
                MySqlDataAdapter adp3 = new MySqlDataAdapter("SELECT appointmentId, userId, type, start, end  FROM appointment WHERE userId = '"+tempScheduleId+"' ORDER BY appointmentId", con);
                adp3.Fill(schedules);
                con.Close();
            }
            dataGridView1.DataSource = schedules;
            dataGridView1.Columns["appointmentId"].HeaderText = "Appointment ID";
            dataGridView1.Columns["userId"].HeaderText = "Consultant ID";
            dataGridView1.Columns["type"].HeaderText = "Type";
            dataGridView1.Columns["start"].HeaderText = "Start";
            dataGridView1.Columns["end"].HeaderText = "End";
            getLocalTime();
        }

        

        private void getCustomerAppNum()
        {
            
            con.Open();
            
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(appointmentId) FROM appointment WHERE customerId = '"+tempCusId+"'", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int val = int.Parse(dr[0].ToString());
                curAppCount = val;
            }
            con.Close();
            
        }

        private void handleMonth()
        {
            try
            {
                appPresType.Clear();
                appScrumType.Clear();
                monthCalendar1.RemoveAllBoldedDates();
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
                    monthCalendar1.AddBoldedDate(tempDate.AddDays(i));
                }
                monthCalendar1.UpdateBoldedDates();
                string endDate = month.ToString() + "/" + day.ToString() + "/" + year.ToString();
                DateTime tempEndDate = Convert.ToDateTime(endDate);
                using (con)
                {
                    MySqlCommand cmd1 = new MySqlCommand("SELECT  type, start, end  FROM appointment WHERE type = 'Presentation' AND DATE(start) Between  '" + tempDate.Date.ToString("yyyy/MM/dd") + "' AND '" + tempEndDate.Date.ToString("yyyy/MM/dd") + "' ", con);
                    MySqlCommand cmd2 = new MySqlCommand("SELECT  type, start, end  FROM appointment WHERE type = 'Scrum' AND DATE(start) Between  '" + tempDate.Date.ToString("yyyy/MM/dd") + "' AND '" + tempEndDate.Date.ToString("yyyy/MM/dd") + "' ", con);

                    con.Open();
                    MySqlDataAdapter adp1 = new MySqlDataAdapter(cmd1);
                    adp1.Fill(appPresType);

                    MySqlDataAdapter adp2 = new MySqlDataAdapter(cmd2);
                    adp2.Fill(appScrumType);
                    con.Close();

                    presBox.Text = appPresType.Rows.Count.ToString();
                    scrumBox.Text = appScrumType.Rows.Count.ToString();
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            currentDate = monthCalendar1.SelectionStart.ToUniversalTime();
            handleMonth();
            
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

       
    }
}
