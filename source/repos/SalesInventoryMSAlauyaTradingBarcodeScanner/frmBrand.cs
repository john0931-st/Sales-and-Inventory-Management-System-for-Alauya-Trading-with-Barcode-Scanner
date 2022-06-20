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
    public partial class frmBrand : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmBrandList frmlist;
        string stitle = "Sales and Inventory System for Alauya Trading";
        public frmBrand(frmBrandList flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmlist = flist;
        }

        private void frmBrand_Load(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            btn_save.Enabled = true;
            btn_update.Enabled = false;
            txt_brand.Clear();
            txt_brand.Focus();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txt_brand.Text))
                {
                    string warning = "Field is empty.";
                    MessageBox.Show(warning, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MessageBox.Show("Are you sure you want to save this brand?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblBrand(Brand)VALUES(@brand)", cn);
                    cm.Parameters.AddWithValue("@brand", txt_brand.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been succesfully saved", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    frmlist.Loadrecords();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clear();
            this.Dispose();
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txt_brand.Text))
                {
                    string warning = "Field is empty.";
                    MessageBox.Show(warning, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
                else if (MessageBox.Show("Are you sure to update this brand?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblBrand SET brand = @brand WHERE id LIKE '" + lblID.Text + "'", cn);
                        cm.Parameters.AddWithValue("@brand", txt_brand.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Brand has been successfully updated.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        frmlist.Loadrecords();
                        this.Close();
                    }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_brand_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
