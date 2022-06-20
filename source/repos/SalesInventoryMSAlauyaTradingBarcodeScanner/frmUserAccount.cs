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
    public partial class frmUserAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        string stitle = "Sales and Inventory System for Alauya Trading";
        public frmUserAccount()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Clear()
        {
            txtName.Clear();
            txtUser.Clear();
            txtPass.Clear();
            txtRetype.Clear();
            cboRole.SelectedIndex = -1;
            txtName.Focus();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == string.Empty || txtUser.Text == string.Empty || txtPass.Text == string.Empty || txtRetype.Text == string.Empty || cboRole.Text == string.Empty)
                {
                    MessageBox.Show("The required fields are empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txtPass.Text != txtRetype.Text)
                {
                    MessageBox.Show("Password did not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cn.Open();
                cm = new SqlCommand("INSERT INTO tblUser (username, password, role, name) VALUES (@username, @password, @role, @name)", cn);
                cm.Parameters.AddWithValue("@name", txtName.Text);
                cm.Parameters.AddWithValue("@username", txtUser.Text);
                cm.Parameters.AddWithValue("@password", txtPass.Text);
                cm.Parameters.AddWithValue("@role", cboRole.Text);
                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("New account has been saved.", "New Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void showPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void showPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtRetype.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtRetype.UseSystemPasswordChar = true;
        }

        private void btnCanelUser_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            changeOld.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            changeOld.UseSystemPasswordChar = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            changeNew.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            changeNew.UseSystemPasswordChar = true;
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            changeRetype.UseSystemPasswordChar = false;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            changeRetype.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string _oldpass = dbcon.GetPassword(changeUser.Text);
                if (changeUser.Text == string.Empty || changeOld.Text == string.Empty || changeNew.Text == string.Empty || changeRetype.Text == string.Empty)
                {
                    MessageBox.Show("The required fields are empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (_oldpass != changeOld.Text)
                {
                    MessageBox.Show("Old password did not match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (changeNew.Text != changeRetype.Text)
                {
                    MessageBox.Show("New password and Re-type password did not match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (changeNew.Text == changeOld.Text || changeRetype.Text == changeOld.Text)
                {
                    MessageBox.Show("New password is the same with the old password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (MessageBox.Show("Change Password?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblUser SET password = @password WHERE username = @username", cn);
                        cm.Parameters.AddWithValue("@password", changeNew.Text);
                        cm.Parameters.AddWithValue("@username", changeUser.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Password has been successfully changed.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changeUser.Clear();
                        changeOld.Clear();
                        changeNew.Clear();
                        changeRetype.Clear();
                    }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUser2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tbluser WHERE username = @username", cn);
                cm.Parameters.AddWithValue("@username", txtUser2.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    checkActive.Checked = bool.Parse(dr["isActive"].ToString());
                }
                else
                {
                    checkActive.Checked = false; 
                     
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bool found;
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tbluser WHERE username = @username AND role = 'Cashier'", cn);
                cm.Parameters.AddWithValue("@username", txtUser2.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                }
                else
                {
                    found = false;
                }

                dr.Close();
                cn.Close();
                
                 if(found == true)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblUser SET isactive = @isactive WHERE username = @username", cn);
                    cm.Parameters.AddWithValue("@isactive", checkActive.Checked.ToString());
                    cm.Parameters.AddWithValue("@username", txtUser2.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Account status has been successfully updated.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUser2.Clear();
                    checkActive.Checked = false;
                }
                 else if (Environment.UserName == txtUser2.Text)
                {
                    MessageBox.Show("Changes to the current account status are not possible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
              
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
