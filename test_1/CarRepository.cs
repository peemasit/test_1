using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace test_1 {
    public class CarRepository {
        string conStr = WebConfigurationManager.ConnectionStrings["conDB"].ConnectionString;

        public class carModel {
            public string carId { get; set; }
            public string carName { get; set; }
        }

        public DataSet showCarList() {
            SqlConnection conn = new SqlConnection(conStr);
            DataSet ds = new DataSet();
            string query = "select * from CarTypeLV1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(ds);
            return ds;
        }

        public void AddCarType(carModel data) {
            SqlConnection conn = new SqlConnection(conStr);
            string query = "insert into CarTypeLV1 values (@Id, @Name)";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@Id", data.carId);
            cmd.Parameters.AddWithValue("@Name", data.carName);
            cmd.ExecuteScalar();
            conn.Close();
            conn.Dispose();
        }
    }
}