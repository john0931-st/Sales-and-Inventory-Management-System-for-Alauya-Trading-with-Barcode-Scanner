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
    public partial class frmVoid : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string stitle = "Sales and Inventory System for Alauya Trading";
        frmCancelDetails f;
        public frmVoid(frmCancelDetails frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            f = frm;
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            try
            {
                if (voidUser.Text != String.Empty && voidPass.Text != String.Empty)
                {
                    string user;
                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM tbluser WHERE username = @username AND password = @password AND role = 'Administrator'", cn);
                    cm.Parameters.AddWithValue("@username", voidUser.Text);
                    cm.Parameters.AddWithValue("@password", voidPass.Text);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if(dr.HasRows)
                    {
                        user = dr["name"].ToString(); //VOID BY
                        dr.Close();
                        cn.Close();

                        SaveCancelOrder(user);
                        if (f.cboAction.Text == "YES")
                        {
                            UpdateData("UPDATE tblProduct SET qty = qty + " + int.Parse(f.txtCancelQty.Text) + "WHERE pcode = '" + f.txtPCode.Text + "'");
                        }

                        UpdateData("UPDATE tblCart SET qty = qty - " + int.Parse(f.txtCancelQty.Text) + "WHERE id LIKE '" + f.txtID.Text + "'");

                        MessageBox.Show("Order transaction successfully cancelled.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        f.RefreshList();
                        f.Close();
                    }
                    else
                    {
                        MessageBox.Show("Admin account is required to continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }
                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SaveCancelOrder(string user)
        {
            cn.Open();
            cm = new SqlCommand("INSERT INTO tblCancel (transno, pcode, price, qty, sdate, voidby, cancelledby, reason, action) VALUES (@transno, @pcode, @price, @qty, @sdate, @voidby, @cancelledby, @reason, @action)", cn);
            cm.Parameters.AddWithValue("@transno", f.txtTransNo.Text);
            cm.Parameters.AddWithValue("@pcode", f.txtPCode.Text);
            cm.Parameters.AddWithValue("@price", double.Parse(f.txtPrice.Text));
            cm.Parameters.AddWithValue("@qty", int.Parse(f.txtCancelQty.Text));
            cm.Parameters.AddWithValue("@sdate", DateTime.Now);
            cm.Parameters.AddWithValue("@voidby", user);
            cm.Parameters.AddWithValue("@cancelledby", f.txtCancel.Text);
            cm.Parameters.AddWithValue("@reason", f.txtReason.Text);
            cm.Parameters.AddWithValue("@action", f.cboAction.Text);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        public void UpdateData(string sql)
        {
            cn.Open();
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        private void frmVoid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}