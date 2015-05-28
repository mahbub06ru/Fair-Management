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
    class VisitorZoneInformationViewGateway
    {
        public List<VisitorZoneInformationView> GetVisitorZoneByZoneId(int zoneId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FairManagementConString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM visitorZoneView WHERE ZoneId='" + zoneId + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<VisitorZoneInformationView> visitorZoneInformationViewList = new List<VisitorZoneInformationView>();
            while (sqlDataReader.Read())
            {
                VisitorZoneInformationView visitorZoneInformationView = new VisitorZoneInformationView();
                visitorZoneInformationView.VisitorId = int.Parse(sqlDataReader["VisitorId"].ToString());
                visitorZoneInformationView.VisitorName = sqlDataReader["VisitorName"].ToString();
                visitorZoneInformationView.VisitorEmail = sqlDataReader["VisitorEmail"].ToString();
                visitorZoneInformationView.VisitorContactNumber = sqlDataReader["VisitorContactNumber"].ToString();
                visitorZoneInformationView.ZoneId = int.Parse(sqlDataReader["ZoneId"].ToString());
                visitorZoneInformationView.ZoneName = sqlDataReader["ZoneName"].ToString();
                visitorZoneInformationViewList.Add(visitorZoneInformationView);
            }
            return visitorZoneInformationViewList;
        }
    }
}
