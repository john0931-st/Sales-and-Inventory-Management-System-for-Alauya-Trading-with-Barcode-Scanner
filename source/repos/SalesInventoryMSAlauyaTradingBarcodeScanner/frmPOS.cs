using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tulpep.NotificationWindow;
namespace SalesInventoryMSAlauyaTradingBarcodeScanner
{
    public partial class frmPOS : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string stitle = "Sales and Inventory System for Alauya Trading";
        String id;
        String price;
        int qty;
        public frmPOS()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            lblDate.Text = DateTime.Now.ToShortDateString();
            this.KeyPreview = true;
            if (lblTransno.Text == "000000000000")
            {
                posSearch.Enabled = false;
            }
        }

        private void opennewfrm(object obj)
        {
            Application.Run(new Form1());
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        public void posLog_Click(object sender, EventArgs e)
        {
            if (dataGridViewPOS.Rows.Count > 0)
            {
                MessageBox.Show("Unable to logout. Cancel the transaction first.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (MessageBox.Show("Are you sure you want to logout?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmSecurity frm = new frmSecurity();
                frm.ShowDialog();
            }
        }

        public void GetTransNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                string transno;
                int count;
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 transno FROM tblCart WHERE transno LIKE '" + sdate + "%' ORDER BY id desc", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows) 
                { 
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lblTransno.Text = sdate + (count + 1);
                }
                else 
                { 
                    transno = sdate + "1001";
                    lblTransno.Text = transno;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (dataGridViewPOS.Rows.Count > 0)
            {
                return;
            }
            else
            {
                GetTransNo();
                posSearch.Enabled = true;
                btnNew.Enabled = false;
                btnNew.BackColor = Color.DarkGreen;
                posSearch.Focus();
            }
        }

        private void posSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void posSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (posSearch.Text == String.Empty)
                {
                    return;
                }
                else
                {
                    string _pcode;
                    double _price;
                    int _qty;
                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM tblProduct WHERE barcode LIKE '" + posSearch.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        qty = int.Parse(dr["qty"].ToString());
                        //frmQty frm = new frmQty(this);
                        //frm.ProductDetails(dr["pcode"].ToString(), double.Parse(dr["price"].ToString()), lblTransno.Text, qty);

                        _pcode = dr["pcode"].ToString();
                        _price = double.Parse(dr["price"].ToString());
                        _qty = int.Parse(txtQty.Text);

                        dr.Close();
                        cn.Close();
                        //frm.ShowDialog();

                        AddToCart(_pcode, _price, _qty);
                    }
                    else
                    {
                        cn.Close();
                        dr.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddToCart(string _pcode, double _price, int _qty)
        {
            string id = "";
            bool found;
            int cart_qty = 0;
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblCart WHERE transno = @transno AND pcode = @pcode", cn);
            cm.Parameters.AddWithValue("@transno", lblTransno.Text);
            cm.Parameters.AddWithValue("@pcode", _pcode);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                found = true;
                id = dr["id"].ToString();
                cart_qty = int.Parse(dr["qty"].ToString());
            }
            else
            {
                found = false;
            }
            dr.Close();
            cn.Close();

            if (found == true)
            {
                if (qty < (int.Parse(txtQty.Text) + cart_qty))
                {
                    MessageBox.Show("Unable to proceed. Remaining stock is " + qty + ".", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cn.Open();
                cm = new SqlCommand("UPDATE tblcart SET qty = (qty + " + _qty + ") WHERE id = '" + id + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();

                posSearch.SelectionStart = 0;
                posSearch.SelectionLength = posSearch.Text.Length;
                LoadCart();
                //this.Dispose();
            }
            else
            {
                if (qty < int.Parse(txtQty.Text))
                {
                    MessageBox.Show("Unable to proceed. Remaining stock is " + qty + ".", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dr.Close();
                cn.Close();

                cn.Open();
                cm = new SqlCommand("INSERT INTO tblcart (transno, pcode, price, qty, sdate, cashier) VALUES (@transno, @pcode, @price,@qty, @sdate, @cashier)", cn);
                cm.Parameters.AddWithValue("@transno", lblTransno.Text);
                cm.Parameters.AddWithValue("@pcode", _pcode);
                cm.Parameters.AddWithValue("@price", _price);
                cm.Parameters.AddWithValue("@qty", _qty);
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                cm.Parameters.AddWithValue("@cashier", lblName.Text);

                cm.ExecuteNonQuery();
                cn.Close();

                posSearch.SelectionStart = 0;
                posSearch.SelectionLength = posSearch.Text.Length;
                LoadCart();
                //this.Dispose();
            }
        }

        public void LoadCart()
        {
            try
            {
                dataGridViewPOS.Rows.Clear();
                int i = 0;
                double total = 0;
                double discount = 0;
                cn.Open();
                cm = new SqlCommand("SELECT c.id, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total FROM tblCart AS c INNER JOIN tblProduct AS p ON c.pcode = p.pcode WHERE transno LIKE '" + lblTransno.Text + "' AND STATUS LIKE 'Pending' ", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    total += double.Parse(dr["total"].ToString());
                    discount += double.Parse(dr["disc"].ToString());
                    dataGridViewPOS.Rows.Add(i, dr["id"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                }
                dr.Close();
                cn.Close();
                lblTotal.Text = total.ToString("#,##0.00");
                lblDiscount.Text = discount.ToString("#,##0.00");
                GetCartTotal();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void GetCartTotal()
        {
            double discount = Double.Parse(lblDiscount.Text);
            double sales = Double.Parse(lblTotal.Text);
            lblDisplayTotal.Text = sales.ToString("#,##0.00");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (lblTransno.Text == "000000000000")
            {
                return;
            }
            frmLookUp frm = new frmLookUp(this);
            //frm.lookupSearch.Focus();
            frm.LoadRecords();
            frm.ShowDialog();
        }

        private void dataGridViewPOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewPOS.Columns[e.ColumnIndex].Name;
            if(colName == "Delete")
            {
                if(MessageBox.Show("Remove this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblcart WHERE id LIKE '" + dataGridViewPOS.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Item has succesfully removed.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCart();
                }
            }
            else if (colName == "colAdd")
            {
                int i = 0;
                cn.Open();
                cm = new SqlCommand("SELECT SUM(qty) AS qty FROM tblProduct WHERE pcode LIKE '" + dataGridViewPOS.Rows[e.RowIndex].Cells[2].Value.ToString() + "' GROUP BY pcode ", cn);
                i = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();

                if (int.Parse(dataGridViewPOS.Rows[e.RowIndex].Cells[5].Value.ToString()) < i)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblCart set qty = qty + " + int.Parse(txtQty.Text) + " WHERE transno LIKE '" + lblTransno.Text + "' AND pcode LIKE '" + dataGridViewPOS.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Remaining stock on hand is " + i + ".", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (colName == "colRemove")
            {
                int i = 0;
                cn.Open();
                cm = new SqlCommand("SELECT SUM(qty) AS qty FROM tblCart WHERE pcode LIKE '" + dataGridViewPOS.Rows[e.RowIndex].Cells[2].Value.ToString() + "' AND transno LIKE '" + lblTransno.Text + "' GROUP BY transno, pcode ", cn);
                i = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();

                if (i > 1)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblCart set qty = qty - " + int.Parse(txtQty.Text) + " WHERE transno LIKE '" + lblTransno.Text + "' AND pcode LIKE '" + dataGridViewPOS.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Remaining stock on cart is " + i + ".", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            //int i = 0;  
            if (lblTransno.Text == "000000000000" || dataGridViewPOS.Rows.Count == 0 || (double.Parse(dataGridViewPOS.CurrentRow.Cells[6].Value.ToString()) > 0))
            {
                return;
            }
            frmDiscount frms = new frmDiscount(this);
            frms.lblID.Text = id;
            frms.txtPrice.Text = price;
            frms.ShowDialog();
        }

        private void dataGridViewPOS_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridViewPOS.CurrentRow.Index;
            id = dataGridViewPOS[1, i].Value.ToString();
            price = dataGridViewPOS[7, i].Value.ToString();
            //double _grid = double.Parse(dataGridViewPOS[7, i].Value.ToString());
            //dataGridViewPOS[7, i].Value = _grid.ToString("#,##0.00");
            //price = dataGridViewPOS[4, i].Value.ToString(); Uncomment if you want discount per piece
        }

        private void btnSettle_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            if (lblTransno.Text == "000000000000" || dataGridViewPOS.Rows.Count == 0)
            {
                return;
            }
            frmSettle frms = new frmSettle(this);
            frms.txtSale.Text = lblDisplayTotal.Text;
            frms.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate1.Text = DateTime.Now.ToLongDateString();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            frmSoldItems frm = new frmSoldItems();
            frm.dt1.Enabled = false;
            frm.dt2.Enabled = false;
            frm.suser = lblName.Text;
            frm.cboCashier.Enabled = false;
            frm.cboCashier.Text = lblName.Text;
            frm.ShowDialog();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            if (lblTransno.Text == "000000000000" || dataGridViewPOS.Rows.Count == 0)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Remove item/s from cart?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblCart WHERE transno LIKE '" + lblTransno.Text + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("All item/s has been successfully removed from cart.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCart();
                }
            }
        }

        private void frmPOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnNew_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnSearch_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnDiscount_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F4)
            {
                btnSettle_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnCancel_Click_1(sender, e);
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnSale_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F10)
            {
                posLog_Click(sender, e);
            }
            //else if (e.KeyCode == Keys.F8)
            //{
            //    posSearch.SelectionStart = 0;
            //    posSearch.SelectionLength = posSearch.Text.Length;
            //}
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            dataGridViewPOS.Columns[7].DefaultCellStyle.Format = "#,##0.00";
        }
    }
}
