using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SalesInventoryMSAlauyaTradingBarcodeScanner
{
    public class DBConnection
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        private string con;
        private double dailysaels;
        private int productline;
        private int stockonhand;
        private int criticalitems;
        public string MyConnection()
        {
            con = @"Data Source=MRGOODAMNKISSER\SQLEXPRESS;Initial Catalog=POS_ALAUYA;Integrated Security=True";
            return con;
        }

        public string GetPassword(string user)
        {
            string password = "";
            cn.ConnectionString = MyConnection();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblUser WHERE username = @username ", cn);
            cm.Parameters.AddWithValue("@username", user);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                password = dr["password"].ToString();
            }
            dr.Close();
            cn.Close();
            return password;
        }

        public double DailySales()
        {
            string sdate = DateTime.Now.ToShortDateString();
            cn = new SqlConnection();
            cn.ConnectionString = con;
            cn.Open();
            cm = new SqlCommand("SELECT ISNULL (SUM(total),0) AS total FROM tblCart WHERE sdate BETWEEN '" + sdate + "' AND '" + sdate + "' AND STATUS LIKE 'Sold'", cn);
            dailysaels = double.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return dailysaels;
        }

        public double ProductLine()
        {
            cn = new SqlConnection();
            cn.ConnectionString = con;
            cn.Open();
            cm = new SqlCommand("SELECT COUNT(*) FROM tblProduct", cn);
            productline = int.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return productline;
        }

        public double StockOnHand()
        {
            cn = new SqlConnection();
            cn.ConnectionString = con;
            cn.Open();
            cm = new SqlCommand("SELECT ISNULL(SUM(qty),0) AS qty FROM tblProduct", cn);
            stockonhand = int.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return stockonhand;
        }

        public double CriticalItems()
        {
            cn = new SqlConnection();
            cn.ConnectionString = con;
            cn.Open();
            cm = new SqlCommand("SELECT COUNT(*) FROM vwCriticalItems", cn);
            criticalitems = int.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return criticalitems;
        }
    }
}
