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
    public partial class frmInventoryReport : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public frmInventoryReport()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void frmInventoryReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void LoadReport()
        {
            ReportDataSource rptDS;
            try
            {
                reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\\rptInventory.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand("SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty, p.reorder FROM tblProduct AS p INNER JOIN tblBrand AS b ON p.bid = b.id INNER JOIN tblCategory AS c ON p.cid = c.id ORDER BY p.pcode", cn);
                da.Fill(ds.Tables["dtInventory"]);
                cn.Close();

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtInventory"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadTopSelling(string sql, string param)
        {
            try
            {
                ReportDataSource rptDS;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\\rptTop.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand(sql, cn);
                da.Fill(ds.Tables["dtTopSelling"]);
                cn.Close();

                ReportParameter pDate = new ReportParameter("pDate", param);
                reportViewer1.LocalReport.SetParameters(pDate);

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtTopSelling"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadSoldItems(string sql, string param)
        {
            try
            {
                ReportDataSource rptDS;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\\rptSold.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand(sql, cn);
                da.Fill(ds.Tables["dtSoldItems"]);
                cn.Close();

                ReportParameter pDate = new ReportParameter("pDate", param);
                reportViewer1.LocalReport.SetParameters(pDate);

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtSoldItems"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadCritical(string sql)
        {
            try
            {
                ReportDataSource rptDS;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\\rptCritical.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand(sql, cn);
                da.Fill(ds.Tables["dtCritical"]);
                cn.Close();

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtCritical"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void LoadCancelled(string sql, string param)
        {
            try
            {
                ReportDataSource rptDS;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\\rptCancelled.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand(sql, cn);
                da.Fill(ds.Tables["dtCancelled"]);
                cn.Close();

                ReportParameter pDate = new ReportParameter("pDate", param);
                reportViewer1.LocalReport.SetParameters(pDate);

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtCancelled"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadStockHis(string sql, string param)
        {
            try
            {
                ReportDataSource rptDS;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\\rptStockHis.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand(sql, cn);
                da.Fill(ds.Tables["dtStockHis"]);
                cn.Close();

                ReportParameter pDate = new ReportParameter("pDate", param);
                reportViewer1.LocalReport.SetParameters(pDate);

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtStockHis"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadAdjustment(string sql, string param)
        {
            try
            {
                ReportDataSource rptDS;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\\rptAdjustment.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand(sql, cn);
                da.Fill(ds.Tables["dtAdjustment"]);
                cn.Close();

                ReportParameter pDate = new ReportParameter("pDate", param);
                reportViewer1.LocalReport.SetParameters(pDate);

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtAdjustment"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
