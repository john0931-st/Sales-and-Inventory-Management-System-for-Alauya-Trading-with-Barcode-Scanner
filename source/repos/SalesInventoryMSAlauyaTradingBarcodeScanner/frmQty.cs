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

namespace SalesInventoryMSAlauyaTradingBarcodeScanner
{
    public partial class frmQty : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        private String pcode;
        private double price;
        private int qty;
        private string transno;
        frmPOS fpos;
        public frmQty(frmPOS frmpos)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            fpos = frmpos;
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }
        public void ProductDetails(String pcode, double price, String transno, int qty)
        {
            this.pcode = pcode;
            this.price = price;
            this.qty = qty;
            this.transno = transno;
        }
        public void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                //Accepts backspace
            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57)) //ASCII Code 48-57 between 0 - 9
            {
                e.Handled = true;
                if ((e.KeyChar == 13) && (txtQty.Text != String.Empty))
                {
                    String id = "";
                    bool found;
                    int cart_qty = 0;
                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM tblCart WHERE transno = @transno AND pcode = @pcode", cn);
                    cm.Parameters.AddWithValue("@transno", fpos.lblTransno.Text);
                    cm.Parameters.AddWithValue("@pcode", pcode);
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
                            MessageBox.Show("Unable to proceed. Remaining stock is " + qty + ".", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        cn.Open();
                        cm = new SqlCommand("UPDATE tblcart SET qty = (qty + " + int.Parse(txtQty.Text) + ") WHERE id = '" + id + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        fpos.posSearch.Clear();
                        fpos.posSearch.Focus();
                        fpos.LoadCart();
                        this.Dispose();
                    }
                    else
                    {
                        if (qty < int.Parse(txtQty.Text))
                        {
                            MessageBox.Show("Unable to proceed. Remaining stock is " + qty + ".", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        dr.Close();
                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tblCart (transno, pcode, price, qty, sdate, cashier) VALUES (@transno, @pcode, @price,@qty, @sdate, @cashier)", cn);
                        cm.Parameters.AddWithValue("@transno", transno);
                        cm.Parameters.AddWithValue("@pcode", pcode);
                        cm.Parameters.AddWithValue("@price", price);
                        cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                        cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                        cm.Parameters.AddWithValue("@cashier", fpos.lblName.Text);

                        cm.ExecuteNonQuery();
                        cn.Close();

                        fpos.posSearch.Clear();
                        fpos.posSearch.Focus();
                        fpos.LoadCart();
                        this.Dispose();
                    }
                }
            }
        }

        private void frmQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
