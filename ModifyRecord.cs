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
    public partial class ModifyRecord : Form
    {
        string curAddressdId;
        MySqlConnection con = DB.getConnection();
        public ModifyRecord()
        {
            InitializeComponent();
            con.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT customerId, customerName, phone, address.addressId, address, address2, city, postalCode, country FROM customer, address, city, country WHERE customer.addressId = address.addressId AND address.cityId = city.cityId AND city.countryId = country.countryId AND customer.customerId = '"+DB.curCustomerId+"'", con);
            DataTable cRecord = new DataTable();
            adp.Fill(cRecord);
            con.Close();
            cBCountry.DropDownStyle = ComboBoxStyle.DropDown;
            cBCity.DropDownStyle = ComboBoxStyle.DropDown;
            modCId.Text = cRecord.Rows[0][0].ToString();
            modCName.Text = cRecord.Rows[0][1].ToString();
            modPhoneNum.Text = cRecord.Rows[0][2].ToString();
            modAddress1.Text = cRecord.Rows[0][4].ToString();
            modAddress2.Text = cRecord.Rows[0][5].ToString();
            cBCountry.Text = cRecord.Rows[0][8].ToString();
            cBCity.Text = cRecord.Rows[0][6].ToString();
            modPostalCode.Text = cRecord.Rows[0][7].ToString();
            
            curAddressdId = cRecord.Rows[0][3].ToString();


        }

        




        private void ModifyRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cancelModCR_Click(object sender, EventArgs e)
        {
            DB.Cities.Clear();
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private bool enableSave()
        {
            return (!string.IsNullOrWhiteSpace(modCName.Text) &&
                !string.IsNullOrWhiteSpace(modPhoneNum.Text) &&
                !string.IsNullOrWhiteSpace(modAddress1.Text) &&
                !string.IsNullOrWhiteSpace(modPostalCode.Text) &&
                !string.IsNullOrWhiteSpace(cBCountry.Text) &&
                !string.IsNullOrWhiteSpace(cBCity.Text) &&
                checkPhone(modPhoneNum.Text) &&
                checkPostal(modPostalCode.Text));
        }

        private void modCId_TextChanged(object sender, EventArgs e)
        {

        }

        private void modCName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modCName.Text))
            {
                modCName.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modCName.BackColor = System.Drawing.Color.White;
            }
            saveModCR.Enabled = enableSave();
        }

        private void modPhoneNum_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modPhoneNum.Text))
            {
                modPhoneNum.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                if (checkPhone(modPhoneNum.Text))
                {
                    modPhoneNum.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    wrongPhoneFormatLbl.Visible = true;
                    modPhoneNum.BackColor = System.Drawing.Color.Salmon;

                }
                
            }
            saveModCR.Enabled = enableSave();
        }

        private void modAddress1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modAddress1.Text))
            {
                modAddress1.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modAddress1.BackColor = System.Drawing.Color.White;
            }
            saveModCR.Enabled = enableSave();
        }

        private void modAddress2_TextChanged(object sender, EventArgs e)
        {

        }

        private void modPostalCode_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modPostalCode.Text))
            {
                modPostalCode.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                if (checkPostal(modPostalCode.Text))
                {
                    wrongPostalFormatLbl.Visible = false;
                    modPostalCode.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    wrongPostalFormatLbl.Visible = true;
                    modPostalCode.BackColor = System.Drawing.Color.Salmon;
                }
            }
            saveModCR.Enabled = enableSave();
        }

        private void cBCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkPostal(modPostalCode.Text);
            cBCity.Items.Clear();
            cBCity.Text = "";
            int id = DB.Countries[cBCountry.SelectedIndex].countryId;
            foreach (string city in DB.getCityByID(id))
            {
                this.cBCity.Items.Add(city);
            }

            
        }

        private void cBCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModifyRecord_Load(object sender, EventArgs e)
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

        private void cBCountry_TextChanged(object sender, EventArgs e)
        {
            checkPostal(modPostalCode.Text);
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
            saveModCR.Enabled = enableSave();

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
            saveModCR.Enabled = enableSave();
        }

        private void cBCountry_Enter(object sender, EventArgs e)
        {
            checkCountry();
            checkCity();
            checkPostal(modPostalCode.Text);

        }

        private void cBCity_Enter(object sender, EventArgs e)
        {
            checkCountry();
            checkCity();
            checkPostal(modPostalCode.Text);
        }

        private void saveModCR_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = DB.getConnection();
                con.Open();

                DB.getCityID(cBCity.Text);

                MySqlCommand cmd2 = new MySqlCommand("Update address Set address = @address, address2 = @address2, cityId = @cityId, postalCode = @postalCode, phone = @phone, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy Where address.addressId = '" + curAddressdId + "'", con);
                cmd2.Parameters.AddWithValue("@address", modAddress1.Text);
                cmd2.Parameters.AddWithValue("@address2", modAddress2.Text);
                cmd2.Parameters.AddWithValue("@cityId", DB.curCityId);
                cmd2.Parameters.AddWithValue("@postalCode", modPostalCode.Text);
                cmd2.Parameters.AddWithValue("@phone", modPhoneNum.Text);
                cmd2.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                cmd2.Parameters.AddWithValue("@lastUpdateBy", DB.curUser);
                cmd2.ExecuteNonQuery();
                cmd2.Parameters.Clear();
                MySqlCommand cmd = new MySqlCommand("Update customer Set customerName = @customerName, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy Where customer.customerId= '" + modCId.Text + "'", con);
                cmd.Parameters.AddWithValue("@customerName", modCName.Text);
                cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                cmd.Parameters.AddWithValue("@lastUpdateBy", DB.curUser);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                DB.Cities.Clear();
                Main main = new Main();
                main.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkCountry()
        {
            cBCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cBCity.DropDownStyle = ComboBoxStyle.DropDownList;
            if (string.IsNullOrWhiteSpace(cBCountry.Text))
            {
                plsSelectCountryLbl.Visible = true;
                plsSelectCountryLbl.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                plsSelectCountryLbl.Visible = false;
            }
            saveModCR.Enabled = enableSave();
        }
        private void checkCity()
        {
            cBCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cBCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            if (string.IsNullOrWhiteSpace(cBCity.Text))
            {
                plsSelectCityLbl.Visible = true;
                plsSelectCityLbl.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                plsSelectCityLbl.Visible = false;
            }
            saveModCR.Enabled = enableSave();
        }

        private void cBCountry_StyleChanged(object sender, EventArgs e)
        {
            
        }

        private void cBCity_StyleChanged(object sender, EventArgs e)
        {
           
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
                modPostalCode.BackColor = System.Drawing.Color.White;
                return true;

            }
            else
            {
                modPostalCode.BackColor = System.Drawing.Color.Salmon;
                wrongPostalFormatLbl.Visible = true;
                return false;
            }


        }

    }
}
