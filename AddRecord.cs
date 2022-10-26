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
using System.Text.RegularExpressions;

namespace Software2SchedulingApp
{
    public partial class AddRecord : Form
    {

        
        public AddRecord()
        {

            InitializeComponent();
            addCName.BackColor = System.Drawing.Color.Salmon;
            addPhoneNum.BackColor = System.Drawing.Color.Salmon;
            addAddress1.BackColor = System.Drawing.Color.Salmon;
            addPostalCode.BackColor = System.Drawing.Color.Salmon;
            plsSelectCountryLbl.BackColor = System.Drawing.Color.Salmon;
            plsSelectCityLbl.BackColor = System.Drawing.Color.Salmon;

         
        

        }

       private bool enableSave()
        {
            return (!string.IsNullOrWhiteSpace(addCName.Text) &&
                !string.IsNullOrWhiteSpace(addPhoneNum.Text) &&
                !string.IsNullOrWhiteSpace(addAddress1.Text) &&
                !string.IsNullOrWhiteSpace(addPostalCode.Text) &&
                !string.IsNullOrWhiteSpace(cBCountry.Text) &&
                !string.IsNullOrWhiteSpace(cBCity.Text) &&
                checkPhone(addPhoneNum.Text) && checkPostal(addPostalCode.Text));
        }


        private void AddRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cBCity_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cBCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkPostal(cBCountry.Text);
            cBCity.Items.Clear();
            cBCity.Text = "";
            int id = DB.Countries[cBCountry.SelectedIndex].countryId;
            foreach (string city in DB.getCityByID(id))
            {
                this.cBCity.Items.Add(city);
            }

            if (cBCountry.Text != "")
            {
                cBCity.Enabled = true;
            }
        }

        private void cBCountry_TextChanged(object sender, EventArgs e)
        {
            checkPostal(cBCountry.Text);
            cBCity.Items.Clear();
            cBCity.Text = "";
            
            plsSelectCityLbl.Visible = true;
            if (string.IsNullOrWhiteSpace(cBCountry.Text))
            {
                plsSelectCountryLbl.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                plsSelectCountryLbl.Visible = false;
            }
            saveAddCR.Enabled = enableSave();
        }

        private void cBCity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cBCity.Text))
            {
                plsSelectCityLbl.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                plsSelectCityLbl.Visible = false;
            }
            saveAddCR.Enabled = enableSave();
        }

        private void AddRecord_Load(object sender, EventArgs e)
        {
            MySqlConnection con = DB.getConnection();
            con.Open();
            MySqlCommand cmdCountry = new MySqlCommand("SELECT countryId, country FROM country", con);
            MySqlDataReader dr = cmdCountry.ExecuteReader();
            while (dr.Read())
            {
                cBCountry.Items.Add(dr["country"]);
                DB.Countries.Add(new Country() { countryId = ((int)dr["countryId"]), countryName = dr["country"] as string });
            }
            con.Close();
            con.Open();
            MySqlCommand cmdCity = new MySqlCommand("SELECT cityId, city, countryId FROM city", con);
            MySqlDataReader dr2 = cmdCity.ExecuteReader();
            while (dr2.Read())
            {

                DB.Cities.Add(new City() { cityId = ((int)dr2["cityId"]), cityName = dr2["city"] as string, countryId = ((int)dr2["countryId"]) });

            }
            con.Close();

        }

        private void cancelAddCR_Click(object sender, EventArgs e)
        {
            DB.Cities.Clear();
            Main main = new Main();
            main.Show();
            this.Hide();

        }

        private void saveAddCR_Click(object sender, EventArgs e)
        {
            
            try
            {
                MySqlConnection con = DB.getConnection();
                con.Open();

                DB.createAddressId();
                DB.createCustomerId();
                DB.getCityID(cBCity.Text);

                MySqlCommand cmd2 = new MySqlCommand("Insert into address(addressId, address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) values(@addressId, @address, @address2, @cityId, @postalCode, @phone, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)", con);
                cmd2.Parameters.AddWithValue("@addressId", DB.createdAddressId + 1);
                cmd2.Parameters.AddWithValue("@address", addAddress1.Text);
                cmd2.Parameters.AddWithValue("@address2", addAddress2.Text);
                cmd2.Parameters.AddWithValue("@cityId", DB.curCityId);
                cmd2.Parameters.AddWithValue("@postalCode", addPostalCode.Text);
                cmd2.Parameters.AddWithValue("@phone", addPhoneNum.Text);
                cmd2.Parameters.AddWithValue("@createDate", DateTime.Now);
                cmd2.Parameters.AddWithValue("@createdBy", DB.curUser);
                cmd2.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                cmd2.Parameters.AddWithValue("@lastUpdateBy", DB.curUser);
                cmd2.ExecuteNonQuery();
                cmd2.Parameters.Clear();
                MySqlCommand cmd = new MySqlCommand("Insert into customer(customerId, customerName , addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) values(@customerId, @customerName, @addressId, @active, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)", con);
                cmd.Parameters.AddWithValue("@customerId", DB.createdCustomerId + 1);
                cmd.Parameters.AddWithValue("@customerName", addCName.Text);
                cmd.Parameters.AddWithValue("@addressId", DB.createdAddressId + 1);
                cmd.Parameters.AddWithValue("@active", 1);
                cmd.Parameters.AddWithValue("@createDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@createdBy", DB.curUser);
                cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                cmd.Parameters.AddWithValue("@lastUpdateBy", DB.curUser);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();
                DB.Cities.Clear();
                Main main = new Main();
                main.Show();
                this.Hide();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void addCName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addCName.Text))
            {
                addCName.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addCName.BackColor = System.Drawing.Color.White;
            }
            saveAddCR.Enabled = enableSave();
        }

        private void addPhoneNum_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(addPhoneNum.Text))
            {
                addPhoneNum.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                if (checkPhone(addPhoneNum.Text))
                {
                    addPhoneNum.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    wrongPhoneFormatLbl.Visible = true;
                    addPhoneNum.BackColor = System.Drawing.Color.Salmon;
                }
                
            }
            saveAddCR.Enabled = enableSave();
        }

        private void addAddress1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addAddress1.Text))
            {
                addAddress1.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addAddress1.BackColor = System.Drawing.Color.White;
            }
            saveAddCR.Enabled = enableSave();
        }

        private void addAddress2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void addPostalCode_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addPostalCode.Text))
            {
                addPostalCode.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                if (checkPostal(addPostalCode.Text))
                {
                    wrongPostalFormatLbl.Visible = false;
                    addPostalCode.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    wrongPostalFormatLbl.Visible = true;
                    addPostalCode.BackColor = System.Drawing.Color.Salmon;
                }
                
            }
            saveAddCR.Enabled = enableSave();
        }

        private bool checkPhone(string s)
        {
            Regex phoneRegEx = new Regex(@"^\d{3}-\d{4}$");
            if (phoneRegEx.IsMatch(s))
            {
                wrongPhoneFormatLbl.Visible = false;
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool checkPostal(string s)
        {
            string tempCountry;
            tempCountry = "";
                switch (cBCountry.Text)
                {
                    case "US":
                        tempCountry = @"^\d{5}(?:-\d{4})?$";
                        break;                    
                    case "Canada":
                        tempCountry = @"^[A-Z]\d[A-Z] \d[A-Z]\d$";
                        break;
                    case "Norway":
                        tempCountry = @"^\d{4}$";
                        break;
                    case "Japan":
                        tempCountry = @"^\d{3}-\d{4}$";
                        break;
                    case "England":
                        tempCountry = @"^([A-Z]{1,2}\d{1,2}|[A-Z]{1,2}\d[A-Z]) \d[A-Z]{2}$";
                        break;
                 
                }
                Regex postalRegEx = new Regex(tempCountry);
                if (postalRegEx.IsMatch(s))
                {
                    wrongPostalFormatLbl.Visible = false;
                    return true;

                }
                else
                {
                    addPostalCode.BackColor = System.Drawing.Color.Salmon;
                    wrongPostalFormatLbl.Visible = true;
                    return false;
                }
            
            
        }

        
    }
}
