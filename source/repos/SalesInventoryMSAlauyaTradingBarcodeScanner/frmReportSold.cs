using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
namespace SalesInventoryMSAlauyaTradingBarcodeScanner
{
    public partial class frmReportSold : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        frmSoldItems f;
        public frmReportSold(frmSoldItems frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f = frm;
        }

        private void frmReportSold_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        public void LoadSoldReport()
        {
            try
            {
                ReportDataSource rptDS;

                this.reportViewer2.LocalReport.ReportPath = Application.StartupPath + "\\rptDailySales.rdlc";
                this.reportViewer2.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                if (f.cboCashier.Text == "All")
                {
                    da.SelectCommand = new SqlCommand("SELECT c.id, c.transno, c.pcode, p.pdesc,  c.price, c.qty, c.disc AS discount, c.total FROM tblCart AS c INNER JOIN tblProduct AS p ON c.pcode = p.pcode WHERE status LIKE 'Sold' AND sdate BETWEEN '" + f.dt1.Value + "' AND '" + f.dt2.Value + "'", cn);
                }
                else
                {
                    da.SelectCommand = new SqlCommand("SELECT c.id, c.transno, c.pcode, p.pdesc,  c.price, c.qty, c.disc AS discount, c.total FROM tblCart AS c INNER JOIN tblProduct AS p ON c.pcode = p.pcode WHERE status LIKE 'Sold' AND sdate BETWEEN '" + f.dt1.Value + "' AND '" + f.dt2.Value + "' AND cashier LIKE '" + f.cboCashier.Text + "'", cn);
                }
                da.Fill(ds.Tables["dtSoldReport"]);
                cn.Close();

                ReportParameter cashier = new ReportParameter("cashier", f.cboCashier.Text);
                reportViewer2.LocalReport.SetParameters(cashier);
                ReportParameter pDate = new ReportParameter("pDate", "From: " + f.dt1.Value.ToShortDateString() + " To: " + f.dt2.Value.ToShortDateString());
                reportViewer2.LocalReport.SetParameters(pDate);
                ReportParameter pHeader = new ReportParameter("pHeader", "SALES REPORT");
                reportViewer2.LocalReport.SetParameters(pHeader);

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtSoldReport"]);
                reportViewer2.LocalReport.DataSources.Add(rptDS);
                reportViewer2.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer2.ZoomMode = ZoomMode.Percent;
                reportViewer2.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
