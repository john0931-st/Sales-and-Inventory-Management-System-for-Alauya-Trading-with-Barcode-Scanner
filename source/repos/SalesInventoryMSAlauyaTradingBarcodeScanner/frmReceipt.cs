using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
namespace SalesInventoryMSAlauyaTradingBarcodeScanner
{
    public partial class frmReceipt : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        string stitle = "Sales and Inventory System for Alauya Trading";
        string store = "Alauya Trading";
        string address = "M. Belen St., Brgy. Poblacion 4, Silang, Cavite";

        frmPOS f;
        public frmReceipt(frmPOS frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f = frm;
        }

        private void fr_Receipt_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        public void LoadReport(string pcash, string pchange) //Generate Receipt
        {
            ReportDataSource rptDataSource;
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + "\\Report1.rdlc"; //@"\Reports\Report1.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand("SELECT c.id, c.transno, c.pcode, c.price, c.qty, c.disc, c.total, c.sdate, c.status, p.pdesc FROM tblCart AS c INNER JOIN tblProduct As p ON p.pcode = c.pcode WHERE transno = '" + f.lblTransno.Text + "'", cn);
                da.Fill(ds.Tables["dtSold"]);
                cn.Close();

                ReportParameter pDiscount = new ReportParameter("pDiscount", "₱ " + f.lblDiscount.Text);
                ReportParameter pTotal = new ReportParameter("pTotal", "₱ " + f.lblTotal.Text);
                ReportParameter pCash = new ReportParameter("pCash", "₱ " + double.Parse(pcash.ToString()).ToString("#,##0.00"));
                ReportParameter pChange = new ReportParameter("pChange", "₱ " + pchange);
                ReportParameter pStore = new ReportParameter("pStore", store);
                ReportParameter pAddress = new ReportParameter("pAddress", address);
                ReportParameter pTransNo = new ReportParameter("pTransNo", "Invoice # : " + f.lblTransno.Text);
                ReportParameter pCashier = new ReportParameter("pCashier", f.lblName.Text);

                reportViewer1.LocalReport.SetParameters(pDiscount);
                reportViewer1.LocalReport.SetParameters(pTotal);
                reportViewer1.LocalReport.SetParameters(pCash);
                reportViewer1.LocalReport.SetParameters(pChange);
                reportViewer1.LocalReport.SetParameters(pStore);
                reportViewer1.LocalReport.SetParameters(pAddress);
                reportViewer1.LocalReport.SetParameters(pTransNo);
                reportViewer1.LocalReport.SetParameters(pCashier);

                rptDataSource = new ReportDataSource("DataSet1", ds.Tables["dtSold"]);
                reportViewer1.LocalReport.DataSources.Add(rptDataSource);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                System.Drawing.Printing.PageSettings pagesettings = new System.Drawing.Printing.PageSettings();
                pagesettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 275, 3000);
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
