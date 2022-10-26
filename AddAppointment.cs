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
    public partial class AddAppointment : Form
    {
        MySqlConnection con = DB.getConnection();
        int tempIdx;
        string appCusId;
        string appCusName;
        bool withinHrs;
        bool noOverlap;
        DataTable overlapDT = new DataTable();
        public AddAppointment()
        {
            InitializeComponent();
            tempIdx = -1;
            withinHrs = false;
            con.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT customerId, customerName FROM customer", con);
            DataTable cRecord = new DataTable();
            adp.Fill(cRecord);
            con.Close();


            con.Open();
            MySqlDataAdapter adp2 = new MySqlDataAdapter("SELECT start, end FROM appointment", con);
            adp2.Fill(overlapDT);
            con.Close();

            dataGridView1.ClearSelection();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            dataGridView1.DataSource = cRecord;
            dataGridView1.Columns["customerId"].HeaderText = "ID";
            dataGridView1.Columns["customerName"].HeaderText = "Customer Name";

            dateTimePicker1.Value = DateTime.Today;

            cusName.BackColor = System.Drawing.Color.Salmon;
            cusId.BackColor = System.Drawing.Color.Salmon;
            appLbl.BackColor = System.Drawing.Color.Salmon;
            bHrLbl.BackColor = System.Drawing.Color.Salmon;
            checkOverlap();
            
            

        }

        private bool enableSave()
        {
            return (!string.IsNullOrWhiteSpace(cusName.Text) &&
               !string.IsNullOrWhiteSpace(cusId.Text) &&
               !string.IsNullOrWhiteSpace(cBAppType.Text) &&
               withinHrs && noOverlap);
        }

        private void AddAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cusId_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cusId.Text))
            {
                cusId.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                cusId.BackColor = System.Drawing.Color.White;
            }
            addAppSaveBtn.Enabled = enableSave();
        }

        private void cusName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cusName.Text))
            {
                cusName.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                cusName.BackColor = System.Drawing.Color.White;
            }
            addAppSaveBtn.Enabled = enableSave();
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

        private void addAppSaveBtn_Click(object sender, EventArgs e)
        {
            
                try
                {

                    MySqlConnection con = DB.getConnection();
                    con.Open();


                    DB.createAppointmentId();
                    MySqlCommand cmd = new MySqlCommand("Insert into appointment(appointmentId, customerId, userId, type, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) values(@appointmentId, @customerId, @userId, @type, @start, @end, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)", con);
                    cmd.Parameters.AddWithValue("@appointmentId", DB.createdAppointmentId + 1);
                    cmd.Parameters.AddWithValue("@customerId", cusId.Text);
                    cmd.Parameters.AddWithValue("@userId", DB.curUserId);
                    cmd.Parameters.AddWithValue("@type", cBAppType.Text);
                    cmd.Parameters.AddWithValue("@start", dateTimePicker1.Value.ToUniversalTime());
                    cmd.Parameters.AddWithValue("@end", dateTimePicker2.Value.ToUniversalTime());
                    cmd.Parameters.AddWithValue("@createDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@createdBy", DB.curUser);
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

        private void addAppCancelBtn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            checkBusinessHrs();
            checkOverlap();
            dateTimePicker2.Value = dateTimePicker1.Value.AddHours(1).AddMinutes(-1);
            
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            checkOverlap();
            checkBusinessHrs();
        }


        private void cBAppType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cBAppType.Text))
            {
                appLbl.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                appLbl.Visible = false;
            }
            addAppSaveBtn.Enabled = enableSave();
        }

        private void checkBusinessHrs()
        {

            DateTime tempStart = DateTime.Parse("08:00:00");
            
            DateTime tempEnd = DateTime.Parse("17:00:00");

            if ((dateTimePicker1.Value.DayOfWeek.ToString() == "Saturday" || dateTimePicker1.Value.DayOfWeek.ToString() == "Sunday") ||(dateTimePicker1.Value.TimeOfDay < tempStart.TimeOfDay || dateTimePicker1.Value.TimeOfDay > tempEnd.TimeOfDay) || (dateTimePicker2.Value.TimeOfDay > tempEnd.TimeOfDay) )
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
            if(appStart < overlapStart)
            {
                if(appEnd < overlapStart)
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
                if(appStart > overlapEnd)
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

                if (isOverlap(dateTimePicker1.Value, dateTimePicker2.Value, overlapStartPicker.Value, overlapEndPicker.Value))
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
