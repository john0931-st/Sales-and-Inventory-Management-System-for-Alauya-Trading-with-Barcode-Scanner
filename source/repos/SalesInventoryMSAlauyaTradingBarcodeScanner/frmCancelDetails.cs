using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SalesInventoryMSAlauyaTradingBarcodeScanner
{
    public partial class frmCancelDetails : Form
    {
        frmSoldItems f;
        public frmCancelDetails(frmSoldItems frm)
        {
            InitializeComponent();
            this.KeyPreview = true;
            f = frm;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboAction_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cboAction.Text != String.Empty) && (txtQty.Text != String.Empty) && (txtReason.Text != String.Empty))
                {
                    
                    if (int.Parse(txtCancelQty.Text) == 0 || txtCancelQty.Text == String.Empty)
                    {
                        return;
                    }
                    else if (int.Parse(txtQty.Text) >= int.Parse(txtCancelQty.Text))
                    {
                        frmVoid f = new frmVoid(this);
                        f.voidUser.Focus();
                        f.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RefreshList()
        {
            f.LoadRecord();
        }

        private void txtCancelQty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmCancelDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
