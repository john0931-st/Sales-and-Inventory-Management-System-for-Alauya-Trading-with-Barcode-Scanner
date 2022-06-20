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
    public partial class frmDiscount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        string stitle = "Sales and Inventory System for Alauya Trading";
        frmPOS f;
        public frmDiscount(frmPOS frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            f = frm;
        }

        private void txtPercent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double percent = double.Parse(txtPercent.Text);
                double dec = percent / 100;
                double total = double.Parse(txtPrice.Text);
                double discount = double.Parse(txtPrice.Text) * dec;
                txtAmount.Text = discount.ToString("#,##0.00");
                txtPrice.Text = total.ToString("#,##0.00");
            }
            catch
            {
                txtAmount.Text = "0.00";
            }
        }

        private void disConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtPercent.Text) >= 100 || txtPercent.Text == "")
                {
                    return;
                }
                else if ( MessageBox.Show("Add discount? Click yes to confirm.", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblCart SET disc = @disc WHERE id = @id", cn);
                    cm.Parameters.AddWithValue("@disc", double.Parse(txtAmount.Text));
                    cm.Parameters.AddWithValue("@id", int.Parse(lblID.Text));
                    cm.ExecuteNonQuery();
                    cn.Close();
                    f.LoadCart();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPercent_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void txtPercent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (int.Parse(txtPercent.Text) >= 100 || txtPercent.Text == "")
                    {
                        return;
                    }
                    else //if (MessageBox.Show("Add discount? Click yes to confirm.", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblCart SET disc = @disc WHERE id = @id", cn);
                        cm.Parameters.AddWithValue("@disc", double.Parse(txtAmount.Text));
                        cm.Parameters.AddWithValue("@id", int.Parse(lblID.Text));
                        cm.ExecuteNonQuery();
                        cn.Close();
                        f.LoadCart();
                        this.Close();
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
}
