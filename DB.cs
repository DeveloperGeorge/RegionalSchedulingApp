using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Software2SchedulingApp
{
    public static class DB
    {

        private static List<Country> countries = new List<Country>();
        private static List<City> cities = new List<City>();


        public static List<Country> Countries { get { return countries; } set { countries = value; } }
        public static List<City> Cities { get { return cities; } set { cities = value; } }

        public static string curUser { get; set; }
        public static int curUserId { get; set; }
        public static int createdAddressId { get; set; }
        public static int createdCustomerId { get; set; }
        public static int createdAppointmentId { get; set; }
        public static int curAddressId { get; set; }
        public static int curCustomerId { get; set; }
        public static int curCityId { get; set; }
        public static int curCRCount { get; set; }
        public static int curAppCount { get; set; }
        public static int curAppId { get; set; }
        public static CustomerRecord curCustomerRecord { get; set; }
        public static TimeZoneInfo currentTimeZone = TimeZoneInfo.Local;
        public static DateTime loginTime { get; set; }
        
        

        //This is the string that has the database connection credentials.
        public static string connectionString = "server= ;user id= ;database= ;password= ";
        

        public static MySqlConnection getConnection()
        {      
            return new MySqlConnection(connectionString);
        }

        public static string[] getCityByID (int id)
        {

            //Justify these Lambda Expressions: 
            return Cities.Where(c => c.countryId == id)//finds the cities in the Cities list that match the countryId parameter.
                .Select(c => c.cityName)//gets city names that match the countryId.
                .ToArray();  

            //var ci = from City in Cities where City.countryId == id select City.cityName;
            //string[] citArray = ci.ToArray();
            //return citArray;        
        }

        public static bool deleteCR(int p)
        {
            MySqlConnection con = getConnection();
           
            con.Open();
            
            MySqlCommand cmd = new MySqlCommand("Select COUNT(customerId) From customer", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int val = int.Parse(dr[0].ToString());
                 curCRCount = val;
            }
            con.Close();

            if (p >= -1 && p < DB.curCRCount)
            {
                return true;
            }
            return false;
        }

        public static bool deleteApp(int p)
        {
            MySqlConnection con = getConnection();

            con.Open();

            MySqlCommand cmd = new MySqlCommand("Select COUNT(appointmentId) From appointment", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int val = int.Parse(dr[0].ToString());
                curAppCount = val;
            }
            con.Close();

            if (p >= -1 && p < DB.curAppCount)
            {
                return true;
            }
            return false;
        }

        public static void createAddressId()
        {
            MySqlConnection con = DB.getConnection();
            
            con.Open();
            
            MySqlCommand cmd = new MySqlCommand("Select MAX(addressId) From address", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int val = int.Parse(dr[0].ToString());
                DB.createdAddressId = val;
            }

            con.Close();
        }

        public static void createCustomerId()
        {
            MySqlConnection con = DB.getConnection();
            
            con.Open();
          
            MySqlCommand cmd = new MySqlCommand("Select MAX(customerId) From customer", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int val = int.Parse(dr[0].ToString());
                DB.createdCustomerId = val;
            }

            con.Close();
        }

        public static void createAppointmentId()
        {
            MySqlConnection con = DB.getConnection();

            con.Open();

            MySqlCommand cmd = new MySqlCommand("Select MAX(appointmentId) From appointment", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int val = int.Parse(dr[0].ToString());
                DB.createdAppointmentId = val;
            }

            con.Close();
        }

        public static void getCityID(string tempC)
        {
            MySqlConnection con = DB.getConnection();
 
            con.Open();
          
            MySqlCommand cmd = new MySqlCommand("Select cityId From city WHERE city='" + tempC + "'", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int val = int.Parse(dr[0].ToString());
                DB.curCityId = val;
            }

            con.Close();
        }


    }

    
}
