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
    public partial class frmLookUp : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        string stitle = "Sales and Inventory System for Alauya Trading";
        frmPOS f;
        public frmLookUp(frmPOS frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            lookupSearch.SelectionStart = 0;
            lookupSearch.SelectionLength = lookupSearch.Text.Length;
            f = frm;
        }

        public void LoadRecords()
        {
            int i = 0;
            dataGridViewLU.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty FROM tblProduct AS p INNER JOIN tblBrand AS b ON b.id = p.bid INNER JOIN tblCategory AS c ON c.id = p.cid WHERE p.pdesc LIKE '%" + lookupSearch.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewLU.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dataGridViewLU_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewLU.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                frmQty frm = new frmQty(f);
                frm.ProductDetails(dataGridViewLU.Rows[e.RowIndex].Cells[1].Value.ToString(), Double.Parse(dataGridViewLU.Rows[e.RowIndex].Cells[6].Value.ToString()), f.lblTransno.Text, int.Parse(dataGridViewLU.Rows[e.RowIndex].Cells[7].Value.ToString()));
                frm.ShowDialog();
            }
        }

        private void lookupSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void frmLookUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
