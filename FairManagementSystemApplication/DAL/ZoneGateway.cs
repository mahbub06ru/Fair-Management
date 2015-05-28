using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementSystemApplication.Model;

namespace FairManagementSystemApplication.DAL
{
    class ZoneGateway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["FairManagementConString"].ConnectionString;
        Zone zone = new Zone();
        public int Insert(Zone zone)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO tbl_zone VALUES ('" + zone.Zone_Name + "')";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }


        public Zone GetZoneByZoneTitle(string zoneTitle)
        {

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM tbl_zone WHERE zone_title = '" + zoneTitle + "' ";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Zone aZone = null;

            while (reader.Read())
            {
                if (aZone == null)
                {
                    aZone = new Zone();
                }

                aZone.Id = int.Parse(reader["id"].ToString());
                aZone.Zone_Name = reader["zone_title"].ToString();


            }
            reader.Close();
            connection.Close();
            return aZone;
        }

        public List<Zone> GetAllZoneTypeList()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM tbl_zone";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Zone> zoneList = new List<Zone>();

            while (reader.Read())
            {
                Zone aZone = new Zone();
                aZone.Id = int.Parse(reader["id"].ToString());
                aZone.Zone_Name = reader["zone_title"].ToString();

                zoneList.Add(aZone);
            }
            reader.Close();
            connection.Close();
            return zoneList;
        }
    }
}
