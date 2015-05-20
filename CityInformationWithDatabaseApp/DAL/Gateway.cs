using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityInformationWithDatabaseApp.Model;

namespace CityInformationWithDatabaseApp.DAL
{
    class Gateway
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["connectionDb"].ConnectionString;

        public int Save(City aCity)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO CityInformationTB VALUES ('" + aCity.CityName + "', '" + aCity.About + "', '" + aCity.Country + "')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected;
        }

        public bool IsCityNameExists(string cityName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM CityInformationTB WHERE CityName = '" + cityName + "'";
            SqlCommand command = new SqlCommand(query, connection);
            bool isCityNameExist = false;
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                isCityNameExist = true;
                break;
            }
            reader.Close();
            connection.Close();
            return isCityNameExist;
        }
    }
}
