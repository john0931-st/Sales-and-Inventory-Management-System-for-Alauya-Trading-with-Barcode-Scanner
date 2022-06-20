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
    public partial class frmStockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string stitle = "Sales and Inventory System for Alauya Trading";
        int _qty = 0;
        public frmStockIn()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            cn.ConnectionString = dbcon.MyConnection();
            LoadVendor();
            //button1.Enabled = false;
        }

        public void LoadStockIn()
        {
            int i = 0;
            dataGridView5.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM vwStockIn WHERE refno LIKE '" + txtRefNo.Text + "' AND status LIKE 'Pending'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView5.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[8].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView5.Columns[e.ColumnIndex].Name;
            if(colName == "Remove")
            {
                if(MessageBox.Show("Remove this item?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblStockIn WHERE id = '" + dataGridView5.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item has been successfully removed.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStockIn();
                }
            }
        }

        public void Clear()
        {
            txtRefNo.Clear();
            dataGridView5.Rows.Clear();
            datestock.Value = DateTime.Now;
            txtPerson.Clear();
            txtAddress.Clear();
            cboVendor.SelectedIndex = -1;
            txtRefNo.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView5.Rows.Count <= 0 || txtRefNo.Text == string.Empty || txtstockinby.Text == string.Empty || cboVendor.Text == string.Empty || txtPerson.Text == string.Empty || txtAddress.Text == string.Empty)
                {
                    MessageBox.Show("The required fields are empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (MessageBox.Show("Are you sure you want to save this records?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for (int i = 0; i < dataGridView5.Rows.Count; i++)
                        {
                            //Update tblProduct QTY
                            cn.Open();
                            cm = new SqlCommand("UPDATE tblProduct SET qty = qty + " + int.Parse(dataGridView5.Rows[i].Cells[5].Value.ToString()) + " WHERE pcode LIKE '" + dataGridView5.Rows[i].Cells[3].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            //Update tblStockIn QTY
                            cn.Open();
                            cm = new SqlCommand("UPDATE tblStockIn SET qty = qty + " + int.Parse(dataGridView5.Rows[i].Cells[5].Value.ToString()) + ", status = 'Done' WHERE id LIKE '" + dataGridView5.Rows[i].Cells[1].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                    }
                        MessageBox.Show("Stock in details has been successfully saved.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        dataGridView5.Rows.Clear();
                        LoadStockIn();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtRefNo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtstockinby_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmSearchProductStockIn frm = new frmSearchProductStockIn(this);
            frm.LoadProduct();
            frm.ShowDialog();
        }

        private void cboVendor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public void LoadVendor()
        {
            cboVendor.SelectedIndex = -1;
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblVendor", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cboVendor.Items.Add(dr["vendor"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void cboVendor_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblVendor WHERE vendor LIKE '" + cboVendor.Text + "'", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                lblVendorID.Text = dr["id"].ToString();
                txtPerson.Text = dr["contactperson"].ToString();
                txtAddress.Text = dr["address"].ToString();
            }
            dr.Close();
            cn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtRefNo.Clear();
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                string transno;
                int count;
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 refno FROM tblStockIn WHERE refno LIKE '" + sdate + "%' ORDER BY id desc", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    txtRefNo.Text = sdate + (count + 1);
                }
                else
                {
                    transno = sdate + "2001";
                    txtRefNo.Text = transno;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dataGridView5.Rows.Count <= 0 )
            {
                Clear();
                return;
            }
            else if (MessageBox.Show("Cancel stock in?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("DELETE FROM tblStockIn WHERE refno = '" + txtRefNo.Text + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Item has been successfully removed.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStockIn();
                Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtRef.Text == string.Empty || txtPCode.Text == string.Empty || txtDesc.Text == string.Empty || txtQty.Text == string.Empty || cboCommand.Text == string.Empty || txtRemarks.Text == string.Empty || txtUser.Text == string.Empty)
            {
                return;
            }
            else
            {
                try
                {
                    if(int.Parse(txtQty.Text) <= 0)

                    {
                        return;
                    }
                    else
                    {
                        if(cboCommand.Text == "REMOVE FROM INVENTORY")
                        {
                            if (int.Parse(txtQty.Text) > (int.Parse(dataGridView3.CurrentRow.Cells[7].Value.ToString())))
                            {
                                return;
                            }
                            else if (MessageBox.Show("Remove this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                SqlStatement("UPDATE tblProduct SET qty = (qty - " + int.Parse(txtQty.Text) + ") WHERE pcode LIKE '" + txtPCode.Text + "'");
                                SqlStatement("INSERT into tblAdjustment(referenceno, pcode, qty, action, remarks, sdate, [user]) VALUES ('" + txtRef.Text + "', '" + txtPCode.Text + "', '" + int.Parse(txtQty.Text) + "', '" + cboCommand.Text + "', '" + txtRemarks.Text + "', '" + DateTime.Now.ToShortDateString() + "', '" + txtUser.Text + "')");
                                MessageBox.Show("Stock has been successfully adjusted.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearAdjustment();
                                LoadRecordsAdjustment();
                            }
                            else
                            {
                                ClearAdjustment();
                                LoadRecordsAdjustment();
                            }
                        }
                        else 
                        {
                            if (MessageBox.Show("Add this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                SqlStatement("UPDATE tblProduct SET qty = (qty + " + int.Parse(txtQty.Text) + ") WHERE pcode LIKE '" + txtPCode.Text + "'");
                                SqlStatement("INSERT into tblAdjustment(referenceno, pcode, qty, action, remarks, sdate, [user]) VALUES ('" + txtRef.Text + "', '" + txtPCode.Text + "', '" + int.Parse(txtQty.Text) + "', '" + cboCommand.Text + "', '" + txtRemarks.Text + "', '" + DateTime.Now.ToShortDateString() + "', '" + txtUser.Text + "')");
                                MessageBox.Show("Stock has been successfully adjusted.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearAdjustment();
                                LoadRecordsAdjustment();
                            }
                            else
                            {
                                ClearAdjustment();
                                LoadRecordsAdjustment();
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void SqlStatement(string _sql)
        {
            cn.Open();
            cm = new SqlCommand(_sql, cn);
            cm.ExecuteNonQuery();

            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAdjustment();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
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

        public void LoadRecordsAdjustment()
        {
            int i = 0;
            dataGridView3.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty FROM tblProduct AS p INNER JOIN tblBrand AS b ON b.id = p.bid INNER JOIN tblCategory AS c ON c.id = p.cid WHERE p.pdesc LIKE '%" + adjustmentSearch.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView3.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void adjustmentSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRecordsAdjustment();
        }
        public void ReferenceNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                string referenceno;
                int count;
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 referenceno FROM tblAdjustment WHERE referenceno LIKE '" + sdate + "%' ORDER BY id desc", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    referenceno = dr[0].ToString();
                    count = int.Parse(referenceno.Substring(8, 4));
                    txtRef.Text = sdate + (count + 1);
                }
                else
                {
                    referenceno = sdate + "3001";
                    txtRef.Text = referenceno;
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

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView3.Columns[e.ColumnIndex].Name;
            if(colName == "Select")
            {
                if(txtRef.Text == string.Empty)
                {
                    return;
                }
                else
                {
                    txtPCode.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtDesc.Text = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString() + " | " + dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString() + " | " + dataGridView3.Rows[e.RowIndex].Cells[5].Value.ToString();
                    _qty = int.Parse(dataGridView3.Rows[e.RowIndex].Cells[7].Value.ToString());
                }
            }
        }

        public void ClearAdjustment()
        {
            txtRef.Clear();
            txtPCode.Clear();
            txtDesc.Clear();
            txtQty.Clear();
            cboCommand.SelectedIndex = -1;
            txtRemarks.Clear();
            adjustmentSearch.Clear();
            adjustmentSearch.Focus();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReferenceNo();
        }
    }
}
