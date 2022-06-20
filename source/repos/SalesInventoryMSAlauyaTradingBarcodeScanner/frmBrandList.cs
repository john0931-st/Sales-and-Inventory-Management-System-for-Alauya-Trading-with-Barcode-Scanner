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
    public partial class frmBrandList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        string stitle = "Sales and Inventory System for Alauya Trading";
        public frmBrandList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            Loadrecords();
        }

        public void Loadrecords()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblBrand WHERE brand LIKE '%" + brandSearch.Text + "%' ORDER BY brand", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["brand"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmBrand frm = new frmBrand(this);
            frm.btn_save.Enabled = true;
            frm.btn_update.Enabled = false;
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                frmBrand frm = new frmBrand(this);
                frm.btn_save.Enabled = false;
                frm.lblID.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                frm.txt_brand.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                frm.ShowDialog();

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblBrand WHERE id LIKE '" + dataGridView1[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Brand has been successfully deleted.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Loadrecords();
                }
            }
        }

        private void brandSearch_TextChanged_1(object sender, EventArgs e)
        {
            Loadrecords();
        }
    }
}
