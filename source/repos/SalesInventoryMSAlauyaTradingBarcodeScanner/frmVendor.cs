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
    public partial class frmVendor : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        string stitle = "Sales and Inventory System for Alauya Trading";
        frmVendorList ff;
        public frmVendor(frmVendorList ff)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            cn.ConnectionString = dbcon.MyConnection();
            this.ff = ff;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVendor.Text == string.Empty || txtAddress.Text == string.Empty || txtPerson.Text == string.Empty || txtTel.Text == string.Empty || txtEmail.Text == string.Empty || txtFax.Text == string.Empty)
                {
                    MessageBox.Show("The required fields are empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (MessageBox.Show("Save this record? Click yes to confirm.", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblVendor(vendor,address, contactperson, telephone, email, fax) VALUES (@vendor,@address, @contactperson, @telephone, @email, @fax)", cn);
                    cm.Parameters.AddWithValue("@vendor", txtVendor.Text);
                    cm.Parameters.AddWithValue("@address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@contactperson", txtPerson.Text);
                    cm.Parameters.AddWithValue("@telephone", txtTel.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@fax", txtFax.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Vendor details has been successfully saved.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    ff.LoadRecordsVendors();
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
            txtVendor.Clear();
            txtAddress.Clear();
            txtPerson.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            txtFax.Clear();
            txtVendor.Focus();
            btn_save.Enabled = true;
            btn_update.Enabled = false;
            btn_cancel.Enabled = true;
        }

        private void txtVendor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 44 || e.KeyChar == 46 || e.KeyChar == 32)
            {
                //Accepts (space) , . character
            }
            else if (e.KeyChar == 8)
            {
                //Accepts backspace
            }
            else if ((e.KeyChar < 65) || (e.KeyChar > 90) && (e.KeyChar < 97) || (e.KeyChar > 122)) //ASCII Code 65-90 & 97-122 between A-Za-z
            {
                e.Handled = true;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
            {
                //Accepts . character
            }
            else if (e.KeyChar == 8)
            {
                //Accepts backspace
            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57)) //ASCII Code 48-57 between 0 - 9
            {
                e.Handled = true;
            }
        }

        private void txtPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 44 || e.KeyChar == 46 || e.KeyChar == 32)
            {
                //Accepts (space) , . character
            }
            else if (e.KeyChar == 8)
            {
                //Accepts backspace
            }
            else if ((e.KeyChar < 65) || (e.KeyChar > 90) && (e.KeyChar < 97) || (e.KeyChar > 122)) //ASCII Code 65-90 & 97-122 between A-Za-z
            {
                e.Handled = true;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVendor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVendor.Text == string.Empty || txtAddress.Text == string.Empty || txtPerson.Text == string.Empty || txtTel.Text == string.Empty || txtEmail.Text == string.Empty || txtFax.Text == string.Empty)
                {
                    MessageBox.Show("The required fields are empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (MessageBox.Show("Update this record? Click yes to confirm.", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblVendor SET vendor = @vendor, address = @address, contactperson = @contactperson, telephone = @telephone, email = @email, fax = @fax WHERE id = @id", cn);
                    cm.Parameters.AddWithValue("@vendor", txtVendor.Text);
                    cm.Parameters.AddWithValue("@address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@contactperson", txtPerson.Text);
                    cm.Parameters.AddWithValue("@telephone", txtTel.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@fax", txtFax.Text);
                    cm.Parameters.AddWithValue("@id", lblID.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Vendor details has been successfully updated.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    ff.LoadRecordsVendors();
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
