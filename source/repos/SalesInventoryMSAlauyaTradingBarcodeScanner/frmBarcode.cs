using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
namespace SalesInventoryMSAlauyaTradingBarcodeScanner
{
    public partial class frmBarcode : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da;
        DBConnection dbcon = new DBConnection();
        ReportDocument crystal = new ReportDocument();
        public frmBarcode()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MRGOODAMNKISSER\SQLEXPRESS;Initial Catalog=POS_ALAUYA;Integrated Security=True");
            string sql = "SELECT * FROM tblProduct WHERE barcode ='" + txtBarcode.Text + "'";
            for (int i = 1; i < int.Parse(textBox2.Text); i++)
            {
                sql = sql + "UNION ALL SELECT * FROM tblProduct WHERE barcode ='" + txtBarcode.Text + "'";
            }
            SqlDataAdapter sda = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "tblProduct");
            crystal.SetDataSource(ds);
            crystalReportViewer1.ReportSource = crystal;
            cn.Close();
        }

        private void frmBarcode_Load(object sender, EventArgs e)
        {
            var pathWithEnv = @"%userprofile%\source\repos\SalesInventoryMSAlauyaTradingBarcodeScanner\rptBarcode.rpt";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
            crystal.Load(filePath);
            //crystal.Load(@"C:\Users\John Archie Padrigo\source\repos\SalesInventoryMSAlauyaTradingBarcodeScanner\rptBarcode.rpt");
        }
    }
}