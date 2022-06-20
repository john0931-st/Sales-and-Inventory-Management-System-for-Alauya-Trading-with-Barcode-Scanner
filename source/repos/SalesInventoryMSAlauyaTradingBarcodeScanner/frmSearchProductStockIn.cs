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
    public partial class frmSearchProductStockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string stitle = "Sales and Inventory System for Alauya Trading";
        frmStockIn slist;
        public frmSearchProductStockIn( frmStockIn flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            slist = flist;
        }

        public void LoadProduct()
        {
            int i = 0;
            dataGridView6.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT pcode, pdesc, qty FROM tblProduct WHERE pdesc LIKE '%" + productSearch.Text + "%' ORDER BY pcode", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView6.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView6.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                if (slist.txtRefNo.Text == string.Empty || slist.txtstockinby.Text == string.Empty || slist.cboVendor.Text == string.Empty || slist.txtPerson.Text == string.Empty || slist.txtAddress.Text == string.Empty)
                {
                    MessageBox.Show("The required fields are empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Add this item?", "Add Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblStockIn (refno, pcode, sdate, stockinby, vendorid) VALUES (@refno, @pcode, @sdate, @stockinby, @vendorid)", cn);
                    cm.Parameters.AddWithValue("@refno", slist.txtRefNo.Text);
                    cm.Parameters.AddWithValue("@pcode", dataGridView6.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cm.Parameters.AddWithValue("@sdate", slist.datestock.Value);
                    cm.Parameters.AddWithValue("@stockinby", slist.txtstockinby.Text);
                    cm.Parameters.AddWithValue("@vendorid", slist.lblVendorID.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    //MessageBox.Show("Succesfully added.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    slist.LoadStockIn();
                }

            }
        }

        private void productSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void frmSearchProductStockIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
