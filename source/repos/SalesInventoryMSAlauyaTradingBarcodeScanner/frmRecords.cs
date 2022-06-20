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
using System.Windows.Forms.DataVisualization.Charting;
namespace SalesInventoryMSAlauyaTradingBarcodeScanner
{
    public partial class frmRecords : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public frmRecords()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        public void LoadRecordTop()
        {
            dataGridViewRecords.Rows.Clear();
            int i = 0;
            cn.Open();
            cm = new SqlCommand("SELECT TOP 10 pcode, pdesc, ISNULL(SUM(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwSoldItems WHERE sdate BETWEEN '" + date1.Value.ToString() + "' AND '" + date2.Value.ToString() + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty desc", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewRecords.Rows.Add(i, dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["qty"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                dataGridViewRecords.Rows[0].Selected = true;
            }
            dr.Close();
            cn.Close();
        }

        public void CancelledOrders()
        {
            int i = 0;
            dataGridViewCancelled.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM vwCancelledOrder WHERE sdate BETWEEN '" + dtCancel1.Value.ToString() + "' AND '" + dtCancel2.Value.ToString() + "'ORDER BY transno", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewCancelled.Rows.Add(i, dr["transno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00"), dr["sdate"].ToString(), dr["voidby"].ToString(), dr["cancelledby"].ToString(), dr["reason"].ToString(), dr["action"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {
            LoadRecordTop();
        }

        private void date2_ValueChanged(object sender, EventArgs e)
        {
            LoadRecordTop();
        }

        public void LoadRecordSoldItems()
        {
            try
            {
                dataGridViewSOLDITEMS.Rows.Clear();
                int i = 0;
                cn.Open();
                cm = new SqlCommand("SELECT c.pcode, p.pdesc, c.price, sum(c.qty) AS tot_qty, sum(c.disc) AS tot_disc, sum(c.total) AS total from tblcart AS c INNER JOIN tblProduct AS p on c.pcode = p.pcode WHERE status LIKE 'Sold' AND sdate BETWEEN '" + dateTimePicker0.Value.ToString() + "' AND '" + dateTimePicker1.Value.ToString() + "' GROUP BY c.pcode, p.pdesc, c.price ORDER BY pcode", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridViewSOLDITEMS.Rows.Add(i, dr["pcode"].ToString(), dr["pdesc"].ToString(), double.Parse(dr["price"].ToString()).ToString("#,##0.00"), dr["tot_qty"].ToString(), double.Parse(dr["tot_disc"].ToString()).ToString("#,##0.00"), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                }
                dr.Close();
                cn.Close();

                cn.Open();
                cm = new SqlCommand("SELECT ISNULL(sum(total),0) FROM tblcart  WHERE status LIKE 'Sold' AND sdate BETWEEN '" + dateTimePicker0.Value.ToString() + "' AND '" + dateTimePicker1.Value.ToString() + "'", cn);
                labelTotal.Text = double.Parse(cm.ExecuteScalar().ToString()).ToString("₱#,##0.00");
                dr = cm.ExecuteReader();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateTimePicker0_ValueChanged(object sender, EventArgs e)
        {
            LoadRecordSoldItems();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadRecordSoldItems();
        }
        
        public void LoadCriticalItems()
        {
            try
            {
                dataGridViewCritical.Rows.Clear();
                int i = 0;
                cn.Open();
                cm = new SqlCommand("SELECT * FROM vwCriticalItems", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridViewCritical.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), double.Parse(dr[5].ToString()).ToString("#,##0.00"), dr[6].ToString(), dr[7].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex) 
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadInventory()
        {
            int i = 0;
            dataGridViewINVENTLIST.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty, p.reorder FROM tblProduct AS p INNER JOIN tblBrand AS b ON p.bid = b.id INNER JOIN tblCategory AS c ON p.cid = c.id", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewINVENTLIST.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridViewINVENTLIST.Rows.Count <= 0)
            {
                return;
            }
            else
            {
                frmInventoryReport f = new frmInventoryReport();
                f.LoadReport();
                f.ShowDialog();
            }
        }

        private void dtCancel1_ValueChanged(object sender, EventArgs e)
        {
            CancelledOrders();
        }

        private void dtCancel2_ValueChanged(object sender, EventArgs e)
        {
            CancelledOrders();
        }

        public void LoadStockInHistory()
        {
            int i = 0;
            dataGridViewHistory.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM vwStockIn WHERE CAST (sdate as date) BETWEEN '" + dtHis1.Value.ToShortDateString() + "' AND '" + dtHis2.Value.ToShortDateString() + "'AND status LIKE 'Done'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewHistory.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[8].ToString());

            }
            dr.Close();
            cn.Close();
        }

        private void dtHis1_ValueChanged(object sender, EventArgs e)
        {
            LoadStockInHistory();
        }

        private void dtHis2_ValueChanged(object sender, EventArgs e)
        {
            LoadStockInHistory();
        }

        private void printTop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridViewRecords.Rows.Count <= 0)
            {
                return;
            }
            else
            {
                frmInventoryReport frm = new frmInventoryReport();
                //frm.LoadTopSelling("SELECT TOP 10 pcode, pdesc, sum(qty) AS qty FROM vwSoldItems WHERE sdate BETWEEN '" + date1.Value.ToString() + "' AND '" + date2.Value.ToString() + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty desc", "FROM : " + date1.Value.ToString() + " TO : " + date2.Value.ToString());
                frm.LoadTopSelling("SELECT TOP 10 pcode, pdesc, ISNULL(SUM(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwSoldItems WHERE sdate BETWEEN '" + date1.Value.ToString() + "' AND '" + date2.Value.ToString() + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty desc", "FROM : " + date1.Value.ToString() + " TO : " + date2.Value.ToString());
                frm.Show();
            }
        }

        private void printSold_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridViewSOLDITEMS.Rows.Count <= 0)
            {
                return;
            }
            else
            {
                frmInventoryReport frm = new frmInventoryReport();
                frm.LoadSoldItems("SELECT c.pcode, p.pdesc, c.price, sum(c.qty) AS tot_qty, sum(c.disc) AS tot_disc, sum(c.total) AS total from tblcart AS c INNER JOIN tblProduct AS p on c.pcode = p.pcode WHERE status LIKE 'Sold' AND sdate BETWEEN '" + dateTimePicker0.Value.ToString() + "' AND '" + dateTimePicker1.Value.ToString() + "' GROUP BY c.pcode, p.pdesc, c.price ORDER BY pcode", "FROM : " + dateTimePicker0.Value.ToString() + " TO : " + dateTimePicker1.Value.ToString());
                frm.Show();
            }
        }

        private void printCritical_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridViewCritical.Rows.Count <= 0)
            {
                return;
            }
            else
            {
                frmInventoryReport frm = new frmInventoryReport();
                frm.LoadCritical("SELECT * FROM vwCriticalItems ORDER BY pcode");
                frm.Show();
            }
        }

        private void printCancelled_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridViewCancelled.Rows.Count <= 0)
            {
                return;
            }
            else
            {
                frmInventoryReport frm = new frmInventoryReport();
                frm.LoadCancelled("SELECT * FROM vwCancelledOrder WHERE sdate BETWEEN '" + dtCancel1.Value.ToShortDateString() + "' AND '" + dtCancel2.Value.ToShortDateString() + "' ORDER BY transno", "FROM : " + dtCancel1.Value.ToString() + " TO : " + dtCancel2.Value.ToString());
                frm.Show();
            }
        }

        private void printHis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridViewHistory.Rows.Count <= 0)
            {
                return;
            }
            else
            {
                frmInventoryReport frm = new frmInventoryReport();
                frm.LoadStockHis("SELECT * FROM vwStockIn WHERE CAST (sdate as date) BETWEEN '" + dtHis1.Value.ToShortDateString() + "' AND '" + dtHis2.Value.ToShortDateString() + "'AND status LIKE 'Done' ORDER BY pcode", "FROM : " + dtHis1.Value.ToString() + " TO : " + dtHis2.Value.ToString());
                frm.Show();
            }
        }
        public void LoadStockAdjustmentHistory()
        {
            int i = 0;
            dataGridViewAdjust.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT a.referenceno, a.pcode, p.pdesc, a.qty, a.action, a.remarks, a.sdate, a.[user] FROM tblAdjustment AS a INNER JOIN tblProduct AS p ON p.pcode = a.pcode WHERE sdate BETWEEN '" + dtAdjust1.Value.ToString() + "'AND '" + dtAdjust2.Value.ToString() + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewAdjust.Rows.Add(i, dr[0].ToString(), dr["referenceno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["qty"].ToString(), dr["action"].ToString(), dr["remarks"].ToString(), dr["sdate"].ToString(), dr["user"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dtAdjust1_ValueChanged(object sender, EventArgs e)
        {
            LoadStockAdjustmentHistory();
        }

        private void dtAdjust2_ValueChanged(object sender, EventArgs e)
        {
            LoadStockAdjustmentHistory();
        }

        private void printAdjust_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridViewHistory.Rows.Count <= 0)
            {
                return;
            }
            else
            {
                frmInventoryReport frm = new frmInventoryReport();
                frm.LoadAdjustment("SELECT a.referenceno, a.pcode, p.pdesc, a.qty, a.action, a.remarks, a.sdate, a.[user] FROM tblAdjustment AS a INNER JOIN tblProduct AS p ON p.pcode = a.pcode WHERE sdate BETWEEN '" + dtAdjust1.Value.ToString() + "'AND '" + dtAdjust2.Value.ToString() + "'", "FROM : " + dtAdjust1.Value.ToString() + " TO : " + dtAdjust2.Value.ToString());
                frm.Show();
            }
        }
    }
}