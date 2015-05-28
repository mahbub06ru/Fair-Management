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
    class VisitorInfoGateway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["FairManagementConString"].ConnectionString;
         VisitorInfo visitorInfo = new VisitorInfo();

        public int Save(VisitorInfo visitorInfo)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO tbl_visitor_info OUTPUT INSERTED.Id VALUES('" + visitorInfo.Name + "','" + visitorInfo.Email + "','" + visitorInfo.ContactNumber + "')";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            connection.Open();
            int row = (int)sqlCommand.ExecuteScalar();
            connection.Close();
            if (row > 0)
            {
                return row;
            }
            else
            {
                return 0;
            }
        }
    }
}
