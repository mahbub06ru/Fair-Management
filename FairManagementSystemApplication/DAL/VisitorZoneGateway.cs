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
    class VisitorZoneGateway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["FairManagementConString"].ConnectionString;
        VisitorZone visitorZone = new VisitorZone();
        public void Save(VisitorZone visitorZone)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO tbl_visitor_zone VALUES ('" + visitorZone.VisitorId + "','" + visitorZone.ZoneId + "')";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
