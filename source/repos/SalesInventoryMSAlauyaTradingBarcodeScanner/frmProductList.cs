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
    public partial class frmProductList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string stitle = "Sales and Inventory System for Alauya Trading";
        public frmProductList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct(this);
            frm.productSave.Enabled = true;
            frm.productUpdate.Enabled = false;
            frm.LoadBrand();
            frm.LoadCategory();
            frm.ShowDialog();
        }
        public void LoadRecords()
        {
            int i = 0;
            dataGridView3.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.reorder FROM tblProduct AS p INNER JOIN tblBrand AS b ON b.id = p.bid INNER JOIN tblCategory AS c ON c.id = p.cid WHERE p.pdesc LIKE '%" + productSearch.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView3.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void productSearch_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView3.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                frmProduct frm = new frmProduct(this);
                frm.productSave.Enabled = false;
                frm.productUpdate.Enabled = true;
                frm.productPCode.Enabled = false;
                frm.productBrand.Enabled = false;
                frm.productCategory.Enabled = false;
                frm.linkLabel1.Enabled = false;
                frm.productPCode.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.productBCode.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.productDesc.Text = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm.productBrand.Text = dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm.productCategory.Text = dataGridView3.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm.productPrice.Text = dataGridView3.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm.txtReorder.Text = dataGridView3.Rows[e.RowIndex].Cells[7].Value.ToString();
                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblStockIn WHERE pcode LIKE '" + dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblCart WHERE pcode LIKE '" + dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblProduct WHERE pcode LIKE '" + dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfully deleted.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }
            }
            else if (colName == "Barcode")
            {
                frmBarcode f = new frmBarcode();
                f.txtBarcode.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
                f.ShowDialog();
            }
        }

        private void productSearch_TextChanged_1(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void posExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
