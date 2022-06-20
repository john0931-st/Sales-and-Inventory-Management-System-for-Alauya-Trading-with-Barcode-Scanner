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
    public partial class frmCategory : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmCategoryList flist;
        string stitle = "Sales and Inventory System for Alauya Trading";
        public frmCategory(frmCategoryList frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            flist = frm;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void Clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtCategory.Clear();
            txtCategory.Focus();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtCategory.Text))
                {
                    string warning = "Field is empty.";
                    MessageBox.Show(warning, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MessageBox.Show("Are you sure you want to save this category?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tblCategory(category)VALUES(@category)", cn);
                        cm.Parameters.AddWithValue("@category", txtCategory.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Record has been succesfully saved", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        flist.LoadCategory();
                      
                    }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtCategory.Text))
                {
                    string warning = "Field is empty.";
                    MessageBox.Show(warning, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MessageBox.Show("Are you sure you want to update this category?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblCategory SET category = @category WHERE id LIKE '"+lblID2.Text+"'", cn);
                        cm.Parameters.AddWithValue("@category", txtCategory.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Record has been succesfully saved", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        flist.LoadCategory();
                        this.Dispose();

                    }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
