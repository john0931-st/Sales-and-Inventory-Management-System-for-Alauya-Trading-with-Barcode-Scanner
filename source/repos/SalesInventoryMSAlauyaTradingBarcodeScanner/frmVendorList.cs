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
    public partial class frmVendorList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        string stitle = "Sales and Inventory System for Alauya Trading";
        public frmVendorList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            cn.ConnectionString = dbcon.MyConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmVendor f = new frmVendor(this);
            f.btn_update.Enabled = false;
            f.ShowDialog();
        }

        public void LoadRecordsVendors()
        {
            dataGridViewVendor.Rows.Clear();
            int i = 0;
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblVendor WHERE vendor LIKE '%" + vendorSearch.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewVendor.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dataGridViewVendor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewVendor.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                frmVendor f = new frmVendor(this);
                f.lblID.Text = dataGridViewVendor.Rows[e.RowIndex].Cells[1].Value.ToString();
                f.txtVendor.Text = dataGridViewVendor.Rows[e.RowIndex].Cells[2].Value.ToString();
                f.txtAddress.Text = dataGridViewVendor.Rows[e.RowIndex].Cells[3].Value.ToString();
                f.txtPerson.Text = dataGridViewVendor.Rows[e.RowIndex].Cells[4].Value.ToString();
                f.txtTel.Text = dataGridViewVendor.Rows[e.RowIndex].Cells[5].Value.ToString();
                f.txtEmail.Text = dataGridViewVendor.Rows[e.RowIndex].Cells[6].Value.ToString();
                f.txtFax.Text = dataGridViewVendor.Rows[e.RowIndex].Cells[7].Value.ToString();
                f.btn_save.Enabled = false;
                f.btn_update.Enabled = true;
                f.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Delete this record? Click yes to confirm.", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblVendor WHERE id LIKE '" + dataGridViewVendor.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Vendor details has been successfully deleted.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecordsVendors();
                }
            }
        }

        private void vendorSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRecordsVendors();
        }
    }
}
