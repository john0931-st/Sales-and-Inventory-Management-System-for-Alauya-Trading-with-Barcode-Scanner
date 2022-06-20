using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SalesInventoryMSAlauyaTradingBarcodeScanner
{
    public partial class frmSoldItems : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        public string suser;
        public string sadmin;
        public frmSoldItems()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            dt1.Value = DateTime.Now;
            dt2.Value = DateTime.Now;
            LoadRecord();
            LoadCashier();
        }

        private void posExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadRecord()
        {
            int i = 0;
            double _total = 0;
            double total = 0;
            dataGridViewSold.Rows.Clear();
            cn.Open();
            if (cboCashier.Text == "All")
            {
                cm = new SqlCommand("SELECT c.id, c.transno, c.pcode, p.pdesc,  c.price, c.qty, c.disc, c.total FROM tblCart AS c INNER JOIN tblProduct AS p ON c.pcode = p.pcode WHERE status LIKE 'Sold' AND sdate BETWEEN '" + dt1.Value + "' AND '" + dt2.Value + "' ORDER BY transno", cn);
            }
            else
            {
                cm = new SqlCommand("SELECT c.id, c.transno, c.pcode, p.pdesc,  c.price, c.qty, c.disc, c.total FROM tblCart AS c INNER JOIN tblProduct AS p ON c.pcode = p.pcode WHERE status LIKE 'Sold' AND sdate BETWEEN '" + dt1.Value + "' AND '" + dt2.Value + "' AND cashier LIKE '" + cboCashier.Text + "%' ORDER BY transno", cn);
            }
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                _total += double.Parse(dr["total"].ToString());
                dataGridViewSold.Rows.Add(i, dr["id"].ToString(), dr["transno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), double.Parse(dr["price"].ToString()).ToString("#,##0.00"), dr["qty"].ToString(), double.Parse(dr["disc"].ToString()).ToString("#,##0.00"), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
            }
            dr.Close();
            cn.Close();
            lblTotal.Text = _total.ToString("₱#,##0.00");
        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void dt2_ValueChanged(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cboCashier.Text == "" || dataGridViewSold.Rows.Count <= 0)
            {
                return;
            }
            else
            {
                frmReportSold frm = new frmReportSold(this);
                frm.LoadSoldReport();
                frm.ShowDialog();
            }
        }

        private void cboCashier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public void LoadCashier()
        {
            cboCashier.Items.Clear();
            cboCashier.Items.Add("All");
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblUser WHERE name LIKE '%" + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cboCashier.Items.Add(dr["name"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void cboCashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void dataGridViewSold_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewSold.Columns[e.ColumnIndex].Name;
            if(colName == "colCancel")
            {
                frmCancelDetails f = new frmCancelDetails(this);
                f.txtID.Text = dataGridViewSold.Rows[e.RowIndex].Cells[1].Value.ToString();
                f.txtTransNo.Text = dataGridViewSold.Rows[e.RowIndex].Cells[2].Value.ToString();
                f.txtPCode.Text = dataGridViewSold.Rows[e.RowIndex].Cells[3].Value.ToString();
                f.txtDescription.Text = dataGridViewSold.Rows[e.RowIndex].Cells[4].Value.ToString();
                f.txtPrice.Text = dataGridViewSold.Rows[e.RowIndex].Cells[5].Value.ToString();
                f.txtQty.Text = dataGridViewSold.Rows[e.RowIndex].Cells[6].Value.ToString();
                f.txtDiscount.Text = dataGridViewSold.Rows[e.RowIndex].Cells[7].Value.ToString();
                f.txtTotal.Text = dataGridViewSold.Rows[e.RowIndex].Cells[8].Value.ToString();
                f.txtCancel.Text = suser;
                if (f.txtCancel.Text == string.Empty)
                {
                    f.txtCancel.Text = sadmin;
                }
                f.Show();
            }
        }

        private void frmSoldItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
