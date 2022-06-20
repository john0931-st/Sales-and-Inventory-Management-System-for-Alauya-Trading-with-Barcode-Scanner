using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using Tulpep.NotificationWindow;
namespace SalesInventoryMSAlauyaTradingBarcodeScanner

{
    public partial class Form1 : Form
    {
        Thread th;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public string _module = "SALES HISTORY MODULE";

        public Form1()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            NotifyCriticalItems();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_brand_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            frmBrandList frm = new frmBrandList
            {
                TopLevel = false
            };
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            frmCategoryList frm = new frmCategoryList
            {
                TopLevel = false
            };
            panel4.Controls.Add(frm);
            frm.LoadCategory();
            frm.BringToFront();
            frm.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            frmProductList frm = new frmProductList
            {
                TopLevel = false
            };
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.LoadRecords();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            frmStockIn frm = new frmStockIn
            {
                TopLevel = false
            };
            panel4.Controls.Add(frm);
            frm.LoadStockIn();
            frm.LoadRecordsAdjustment();
            frm.txtUser.Text = lblName.Text;
            frm.txtstockinby.Text = lblName.Text;
            frm.txtstockinby.Enabled = false;
            frm.txtRefNo.Enabled = false;
            frm.BringToFront();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            frmUserAccount frm = new frmUserAccount
            {
                TopLevel = false
            };
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            frmSoldItems frm = new frmSoldItems()
            {
                TopLevel = false
            };
            panel4.Controls.Add(frm);
            frm.BringToFront(); 
            frm.cboCashier.Text = lblName.Text;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.panelSoldItems.BackColor = ColorTranslator.FromHtml("#252526");
            frm.lblSoldItems.ForeColor = Color.White;
            frm.WindowState = FormWindowState.Maximized;
            frm.sadmin = lblName.Text;
            frm.lblSoldItems.Text = _module;
            frm.KeyPreview = false;
            frm.Text = "";
            frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmSecurity frm = new frmSecurity();
                frm.ShowDialog();
            }
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            frmRecords frm = new frmRecords
            {
                TopLevel = false
            };
            frm.LoadCriticalItems();
            frm.LoadInventory();
            frm.LoadRecordTop();
            frm.LoadRecordSoldItems();
            frm.CancelledOrders();
            frm.LoadStockAdjustmentHistory();
            frm.LoadStockInHistory();
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        public void NotifyCriticalItems()
        {
            string critical = "";
            cn.Open();
            cm = new SqlCommand("SELECT COUNT(*) FROM vwCriticalItems", cn);
            string count = cm.ExecuteScalar().ToString();
            cn.Close();

            int i = 0;
            cn.Open();
            cm = new SqlCommand("SELECT * FROM vwCriticalItems", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                critical += i + ".) " + dr["pdesc"].ToString() + Environment.NewLine;
            }
            dr.Close();
            cn.Close();

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.error;
            popup.TitleText = count + " CRITICAL ITEM(S).";
            popup.ContentText = critical;
            popup.Popup();
            popup.TitleColor = Color.White;
            popup.BodyColor = Color.Black;
            popup.HeaderColor = Color.Gray;
            popup.ContentColor = Color.White;
        }

        private void userDashboard_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            frmDashboard frm = new frmDashboard
            {
                TopLevel = false
            };
            panel4.Controls.Add(frm);
            frm.lblDailySales.Text = dbcon.DailySales().ToString("#,##0.00");
            frm.lblProductLine.Text = dbcon.ProductLine().ToString("#,##0");
            frm.lblStockOnHand.Text = dbcon.StockOnHand().ToString("#,##0");
            frm.lblCriticalItems.Text = dbcon.CriticalItems().ToString("#,##0");
            frm.BringToFront();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            frmVendorList frm = new frmVendorList()
            {
                TopLevel = false
            };
            panel4.Controls.Add(frm);
            frm.LoadRecordsVendors();
            frm.BringToFront();
            frm.Show();
        }
    }
}
