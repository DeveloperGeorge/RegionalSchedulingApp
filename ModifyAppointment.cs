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
    public partial class ModifyAppointment : Form
    {
        MySqlConnection con = DB.getConnection();
        int tempIdx;
        string appCusId;
        string appCusName;
        bool withinHrs;
        bool noOverlap;
        DataTable overlapDT = new DataTable();
        
        public ModifyAppointment()
        {
            InitializeComponent();
            
            tempIdx = -1;
            con.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT customerId, customerName FROM customer", con);
            DataTable cRecord = new DataTable();
            adp.Fill(cRecord);
            con.Close();

            con.Open();
            MySqlDataAdapter adp3 = new MySqlDataAdapter("SELECT start, end, appointmentId FROM appointment", con);
            adp3.Fill(overlapDT);
            con.Close();

            dataGridView1.ClearSelection();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            dataGridView1.DataSource = cRecord;
            dataGridView1.Columns["customerId"].HeaderText = "ID";
            dataGridView1.Columns["customerName"].HeaderText = "Customer Name";
            con.Open();
            MySqlDataAdapter adp2 = new MySqlDataAdapter("SELECT appointmentId, customerName, customer.customerId, type, start, end  FROM appointment, customer WHERE appointment.customerId = customer.customerId AND appointmentId = '"+DB.curAppId+"'", con);
            DataTable appointments = new DataTable();
            adp2.Fill(appointments);
            con.Close();
            appId.Text = appointments.Rows[0][0].ToString();
            cusId.Text = appointments.Rows[0][2].ToString();
            cusName.Text = appointments.Rows[0][1].ToString();
            cBAppType.SelectedItem = appointments.Rows[0][3].ToString();
            //dateTimePicker1.Text = appointments.Rows[0][4].ToString();
            //dateTimePicker2.Text = appointments.Rows[0][5].ToString();
            dateTimePicker1.Text = TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(appointments.Rows[0][4].ToString()), DB.currentTimeZone).ToString();
            dateTimePicker2.Text = TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(appointments.Rows[0][5].ToString()), DB.currentTimeZone).ToString();
            

        }

       

        private void ModifyAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                appCusId = dataGridView1.CurrentRow.Cells["customerId"].Value.ToString();
                appCusName = dataGridView1.CurrentRow.Cells["CustomerName"].Value.ToString();
                cusId.Text = appCusId;
                cusName.Text = appCusName;
                tempIdx = e.RowIndex;
                dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Cyan;
            }
        }

        private void addAppCancelBtn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void addAppSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = DB.getConnection();
                con.Open();

                
                MySqlCommand cmd = new MySqlCommand("Update appointment Set customerId = @customerId, type = @type, start = @start, end = @end, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy Where appointment.appointmentId = '"+appId.Text+"'", con);
                cmd.Parameters.AddWithValue("@customerId", cusId.Text);
                cmd.Parameters.AddWithValue("@type", cBAppType.Text);
                cmd.Parameters.AddWithValue("@start", dateTimePicker1.Value.ToUniversalTime()); 
                cmd.Parameters.AddWithValue("@end", dateTimePicker2.Value.ToUniversalTime()); 
                cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                cmd.Parameters.AddWithValue("@lastUpdateBy", DB.curUser);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();
                Main main = new Main();
                main.Show();
                this.Hide();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool enableSave()
        {
            return (!string.IsNullOrWhiteSpace(cusName.Text) &&
               !string.IsNullOrWhiteSpace(cusId.Text) &&
               !string.IsNullOrWhiteSpace(cBAppType.Text) &&
               withinHrs && noOverlap);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            checkBusinessHrs();
            checkOverlap();
            dateTimePicker2.Value = dateTimePicker1.Value.AddHours(1).AddMinutes(-1);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            checkBusinessHrs();
            checkOverlap();
        }

        private void checkBusinessHrs()
        {

            DateTime tempStart = DateTime.Parse("08:00:00");

            DateTime tempEnd = DateTime.Parse("17:00:00");

            if ((dateTimePicker1.Value.DayOfWeek.ToString() == "Saturday" || dateTimePicker1.Value.DayOfWeek.ToString() == "Sunday") || (dateTimePicker1.Value.TimeOfDay < tempStart.TimeOfDay || dateTimePicker1.Value.TimeOfDay > tempEnd.TimeOfDay) || (dateTimePicker2.Value.TimeOfDay > tempEnd.TimeOfDay))
            {

                withinHrs = false;
                bHrLbl.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                withinHrs = true;
                bHrLbl.BackColor = System.Drawing.Color.Empty;
            }
            addAppSaveBtn.Enabled = enableSave();

        }


        private bool isOverlap(DateTime appStart, DateTime appEnd, DateTime overlapStart, DateTime overlapEnd)
        {
            if (appStart < overlapStart)
            {
                if (appEnd < overlapStart)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (appStart > overlapStart && appStart < overlapEnd)
            {
                return true;

            }
            else
            {
                if (appStart > overlapEnd)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }

        private void checkOverlap()
        {
            for (int i = 0; i < overlapDT.Rows.Count; i++)
            {
                overlapStartPicker.Value = TimeZoneInfo.ConvertTimeFromUtc((DateTime)overlapDT.Rows[i]["start"], TimeZoneInfo.Local);
                overlapEndPicker.Value = TimeZoneInfo.ConvertTimeFromUtc((DateTime)overlapDT.Rows[i]["end"], TimeZoneInfo.Local);
                int tempAppId = (int)overlapDT.Rows[i]["appointmentId"];
                if (isOverlap(dateTimePicker1.Value, dateTimePicker2.Value, overlapStartPicker.Value, overlapEndPicker.Value) && tempAppId != int.Parse(appId.Text))
                {
                    
                    overlapStartPicker.Visible = true;
                    overlapEndPicker.Visible = true;
                    overlapLbl.Visible = true;
                    overlapLbl.BackColor = System.Drawing.Color.Salmon;
                    noOverlap = false;
                    break;
                }
                else
                {
                    overlapStartPicker.Visible = false;
                    overlapEndPicker.Visible = false;
                    overlapLbl.Visible = false;
                    noOverlap = true;
                }
            }
            
        }

        
    }
}
