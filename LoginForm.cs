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
using System.Configuration;
using System.IO;




namespace Software2SchedulingApp
{
    
    public partial class LoginForm : Form   
    {
        MySqlConnection con = DB.getConnection();
        
        
       
 
        int i;
        string invalidLogin;
        string userActivityFile = "UserActivity.txt"; // User activity: the user name and log in time is recoreded here. The file is located in debug folder.
        
        public LoginForm()
        {


            InitializeComponent();
            
           

            
            
            string cReg = RegionInfo.CurrentRegion.EnglishName.ToString();
            switch (cReg.ToUpper())
            {
                case "UNITED STATES":
                    label3.Text = "This Login form supports English and Japanese.";
                    label1.Text = "User Name";
                    label2.Text = "Password";
                    logInBtn.Text = "Log In";
                    invalidLogin = "The user name and password did not match.";

                    break;
                case "JAPAN":
                    label3.Text = "このログインフォームは英語と日本語をサポートしています";
                    label1.Text = "ユーザー名";
                    label2.Text = "パスワード";
                    logInBtn.Text = "ログインする";
                    invalidLogin = "ユーザー名とパスワードが一致しませんでした";
                    break;
            }


        }
        private void writeUserActivity()
        {
            string userActivity = "'" + DB.curUser + "'   '" + DB.loginTime.ToString() + "'";
            using (StreamWriter sw = new StreamWriter(userActivityFile, true))
            {
                sw.WriteLine(userActivity);
            }
           
            
            
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            i = 0;
           
            try
            {
               
                con.Open();
                string sqlString = "SELECT * FROM user WHERE userName='" + userNameBox.Text + "' AND password='" + passwordBox.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(sqlString, con);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i == 0)
                {
                    MessageBox.Show(invalidLogin);
                    con.Close();
                }
                else
                {
                    string loggedInUser = dt.Rows[0][1].ToString();
                    string loggedInUserId = dt.Rows[0][0].ToString();
                    DB.curUser = loggedInUser;
                    DB.curUserId = int.Parse(loggedInUserId);
                    DB.loginTime = DateTime.Now.ToUniversalTime();
                    //writeUserActivity(); //  Upon successful log in the user name and time of log in will be appended to the UserActivity.txt file
                    this.Hide();
                    Main main = new Main();
                    main.Show();
                    con.Close();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
