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
    public partial class frmCategoryList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string stitle = "Sales and Inventory System for Alauya Trading";
        public frmCategoryList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory(this);
            frm.btnSave.Enabled = true;
            frm.btnUpdate.Enabled = false;
            frm.ShowDialog();
        }
        public void LoadCategory()
        {
            int i = 0;
            dataGridView2.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblCategory WHERE category LIKE '%" + categorySearch.Text + "%' ORDER BY category", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView2.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            cn.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView2.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                frmCategory frm = new frmCategory(this);
                frm.txtCategory.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.lblID2.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.btnSave.Enabled = false;
                frm.btnUpdate.Enabled = true;
                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblCategory WHERE id LIKE '" + dataGridView2[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category has been successfully deleted.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategory();
                }
            }
        }

        private void categorySearch_TextChanged(object sender, EventArgs e)
        {
            LoadCategory();
        }
    }
}
