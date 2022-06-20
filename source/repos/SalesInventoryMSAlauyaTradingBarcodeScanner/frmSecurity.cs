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
    public partial class frmSecurity : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        string stitle = "Sales and Inventory System for Alauya Trading";
        public bool _isactive = false;
        public frmSecurity()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }
        private void Clear()
        {
            txtUser.Clear();
            txtPass.Clear();
            txtUser.Focus();
        }

        private void btnCanelLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Clear();
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _username = "", _role = "", _name = "";
            {

            }
            try
            {
                bool found = false;
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tblUser WHERE username = @username AND password = @password", cn);
                cm.Parameters.AddWithValue("@username", txtUser.Text);
                cm.Parameters.AddWithValue("@password", txtPass.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                    _username = dr["username"].ToString();
                    _role = dr["role"].ToString();
                    _name = dr["name"].ToString();
                    _isactive = bool.Parse(dr["isactive"].ToString());
                }
                else
                {
                    found = false;
                }
                dr.Close();
                cn.Close();
                if (found == true)
                {
                    if (_isactive == false)
                    {
                        MessageBox.Show("Access denied. Account is inactive.", "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Clear();
                        return;
                    }
                    if (_role == "Cashier")
                    {
                        MessageBox.Show("Access granted. Welcome " + _name + ". " + _role + " Account.", stitle + " | POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        this.Hide();
                        frmPOS frm = new frmPOS();
                        frm.lblName.Text = _name;
                        frm.ShowDialog();
                    }
                    else
                    {
                        if (MessageBox.Show("Do you want to go to Admin Panel?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MessageBox.Show("Access granted. Welcome " + _name + ". " + _role + " Account.", stitle + " | Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            this.Hide();
                            Form1 frm = new Form1();
                            frm.lblName.Text = _name;
                            frm.userLabel.Text = _role;
                            frm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Access granted. Welcome " + _name + ". " + _role + " Account.", stitle + " | POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            this.Hide();
                            frmPOS frm = new frmPOS();
                            frm.lblName.Text = _name;
                            frm.ShowDialog();
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Access denied. Account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear();
                    return;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
