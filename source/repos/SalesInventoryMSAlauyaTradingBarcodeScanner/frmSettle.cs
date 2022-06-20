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
    public partial class frmSettle : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string stitle = "Sales and Inventory System for Alauya Trading";
        frmPOS fpos;
        public frmSettle(frmPOS fp)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            fpos = fp;
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 44 || e.KeyChar == 46)
            {
                //Accepts , . character
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

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double sale = Double.Parse(txtSale.Text);
                double cash = Double.Parse(txtCash.Text);
                double change = cash - sale;
                txtChange.Text = change.ToString("#,##0.00");
                //txtCash.Text = cash.ToString("#,##0.00"); formats cash
            }
            catch
            {
                txtChange.Text = "0.00";
            }
        }

        private void btnpos7_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnpos7.Text;
        }

        private void btnpos8_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnpos8.Text;
        }

        private void btnpos9_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnpos9.Text;
        }

        private void btnposC_Click(object sender, EventArgs e)
        {
            txtCash.Clear();
            txtCash.Focus();
        }

        private void btnpos4_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnpos4.Text;
        }

        private void btnpos5_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnpos5.Text;
        }

        private void btnpos6_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnpos6.Text;
        }

        private void btnpos0_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnpos0.Text;
        }

        private void btnpos1_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnpos1.Text;
        }

        private void btnpos2_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnpos2.Text;
        }

        private void btnpos3_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnpos3.Text;
        }

        private void btnpos00_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnpos00.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmSettle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void txtCash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (double.Parse(txtChange.Text) < 0 || String.IsNullOrEmpty(txtCash.Text))
                    {
                        MessageBox.Show("Insufficient amount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        for (int i = 0; i < fpos.dataGridViewPOS.Rows.Count; i++)
                        {
                            cn.Open();
                            cm = new SqlCommand("UPDATE tblProduct SET qty = qty - " + int.Parse(fpos.dataGridViewPOS.Rows[i].Cells[5].Value.ToString()) + " WHERE pcode = '" + fpos.dataGridViewPOS.Rows[i].Cells[2].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            cn.Open();
                            cm = new SqlCommand("UPDATE tblCart SET STATUS = 'Sold' WHERE id = '" + fpos.dataGridViewPOS.Rows[i].Cells[1].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                        }
                        frmReceipt frm = new frmReceipt(fpos);
                        frm.LoadReport(txtCash.Text, txtChange.Text);
                        frm.ShowDialog();

                        MessageBox.Show("Transaction successful. Press enter for another transaction.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fpos.GetTransNo();
                        fpos.LoadCart();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
