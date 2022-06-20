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
using System.IO;
namespace SalesInventoryMSAlauyaTradingBarcodeScanner
{
    public partial class frmProduct : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmProductList flist;
        string stitle = "Sales and Inventory System for Alauya Trading";
        public frmProduct(frmProductList frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            flist = frm;
        }

        private void productCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadCategory()
        {
            productCategory.Items.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT category FROM tblCategory", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                productCategory.Items.Add(dr[0].ToString());
            }
            cn.Close();
        }

        public void LoadBrand()
        {
            productBrand.Items.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT brand FROM tblBrand", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                productBrand.Items.Add(dr[0].ToString());
            }
            cn.Close();
        }

        private void productSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(productPCode.Text))
                {
                    string error = "Product Code is empty.";
                    MessageBox.Show(error, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                } 
                else if (String.IsNullOrEmpty(productDesc.Text))
                {
                    string error = "Product Description is empty.";
                    MessageBox.Show(error, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (String.IsNullOrEmpty(productBrand.Text))
                {
                    string error = "Brand is empty.";
                    MessageBox.Show(error, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (String.IsNullOrEmpty(productCategory.Text))
                {
                    string error = "Category is empty.";
                    MessageBox.Show(error, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (String.IsNullOrEmpty(productPrice.Text))
                {
                    string error = "Price is empty.";
                    MessageBox.Show(error, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //else if (productDesc.Text != string.Empty) //check if description is existing
                //{
                //    cn.Open();
                //    cm = new SqlCommand("SELECT * FROM tblProduct WHERE pdesc LIKE'" + productDesc.Text + "'", cn);
                //    dr = cm.ExecuteReader();
                //    dr.Read();
                //    if (dr.HasRows)
                //    {
                //        MessageBox.Show("Product is already existing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        Clear();
                //        return;
                //    }
                //    dr.Close();
                //    cn.Close();
                //}
                else if (MessageBox.Show("Are you sure you want to save this product?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                     string bid = ""; string cid = "";
                     cn.Open();
                     cm = new SqlCommand("SELECT id FROM tblBrand WHERE brand LIKE '" + productBrand.Text + "'", cn);
                     dr = cm.ExecuteReader();
                     dr.Read();
                     if (dr.HasRows){ bid = dr[0].ToString(); }
                     dr.Close();
                     cn.Close();

                     cn.Open();
                     cm = new SqlCommand("SELECT id FROM tblCategory WHERE category LIKE '" + productCategory.Text + "'", cn);
                     dr = cm.ExecuteReader();
                     dr.Read();
                     if (dr.HasRows) { cid = dr[0].ToString(); }
                     dr.Close();
                     cn.Close();

                     cn.Open();
                     cm = new SqlCommand("INSERT INTO tblProduct (pcode, barcode, pdesc, bid, cid, price, reorder) VALUES (@pcode, @barcode, @pdesc, @bid, @cid, @price, @reorder)", cn);
                     cm.Parameters.AddWithValue("@pcode", productPCode.Text);
                     cm.Parameters.AddWithValue("@barcode", productBCode.Text);
                     cm.Parameters.AddWithValue("@pdesc", productDesc.Text);
                     cm.Parameters.AddWithValue("@bid", bid);
                     cm.Parameters.AddWithValue("@cid", cid);
                     cm.Parameters.AddWithValue("@price", double.Parse(productPrice.Text)); 
                     cm.Parameters.AddWithValue("@reorder", int.Parse(txtReorder.Text));
                     cm.ExecuteNonQuery();
                     cn.Close();
                     MessageBox.Show("Product has been succesfully saved.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                     Clear();
                     flist.LoadRecords();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Clear()
        {
            productPCode.Clear();
            productBCode.Clear();
            productDesc.Clear();
            productPrice.Clear();
            productCategory.Text = "";
            productBrand.Text = "";
            productPCode.Focus();
            productSave.Enabled = true;
            productUpdate.Enabled = false;
            txtReorder.Clear();
        }

        private void productUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(productPCode.Text))
                {
                    string error = "Product Code is empty.";
                    MessageBox.Show(error, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (String.IsNullOrEmpty(productBCode.Text))
                {
                    string error = "Barcode is empty.";
                    MessageBox.Show(error, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (String.IsNullOrEmpty(productDesc.Text))
                {
                    string error = "Product Description is empty.";
                    MessageBox.Show(error, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (String.IsNullOrEmpty(productBrand.Text))
                {
                    string error = "Brand is empty.";
                    MessageBox.Show(error, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (String.IsNullOrEmpty(productCategory.Text))
                {
                    string error = "Category is empty.";
                    MessageBox.Show(error, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (String.IsNullOrEmpty(productPrice.Text))
                {
                    string error = "Price is empty.";
                    MessageBox.Show(error, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (MessageBox.Show("Are you sure you want to update this product?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string bid = ""; string cid = "";
                        cn.Open();
                        cm = new SqlCommand("SELECT id FROM tblBrand WHERE brand LIKE '" + productBrand.Text + "'", cn);
                        dr = cm.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows) { bid = dr[0].ToString(); }
                        dr.Close();
                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("SELECT id FROM tblCategory WHERE category LIKE '" + productCategory.Text + "'", cn);
                        dr = cm.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows) { cid = dr[0].ToString(); }
                        dr.Close();
                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("UPDATE tblProduct SET barcode=@barcode, pdesc=@pdesc, bid=@bid, cid=@cid, price=@price, reorder = @reorder WHERE pcode LIKE @pcode", cn);
                        cm.Parameters.AddWithValue("@pcode", productPCode.Text);
                        cm.Parameters.AddWithValue("@barcode", productBCode.Text);
                        cm.Parameters.AddWithValue("@pdesc", productDesc.Text);
                        cm.Parameters.AddWithValue("@bid", bid);
                        cm.Parameters.AddWithValue("@cid", cid);
                        cm.Parameters.AddWithValue("@price", double.Parse(productPrice.Text));
                        cm.Parameters.AddWithValue("@reorder", int.Parse(txtReorder.Text));
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Product has been succesfully updated.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        flist.LoadRecords();
                        this.Dispose();
                    }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void productPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 46)
            {
                //Accepts . character
            }else if(e.KeyChar == 8){
                //Accepts backspace
            }
            else if((e.KeyChar < 48) || (e.KeyChar > 57)) //ASCII Code 48-57 between 0 - 9
            {
                e.Handled = true;
            }
        }

        private void productPCode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void productBCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void productBrand_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void productCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtReorder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                //Accepts backspace
            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57)) //ASCII Code 48-57 between 0 - 9
            {
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            productBCode.Clear();
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                string transno;
                int count;
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 barcode FROM tblProduct WHERE barcode LIKE '" + sdate + "%' ORDER BY pcode desc", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    productBCode.Text = sdate + (count + 1);
                }
                else
                {
                    transno = sdate + "4001";
                    productBCode.Text = transno;
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
    }
}