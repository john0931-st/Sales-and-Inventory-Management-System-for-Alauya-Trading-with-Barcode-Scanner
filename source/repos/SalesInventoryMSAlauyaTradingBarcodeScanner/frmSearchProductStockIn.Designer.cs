
namespace SalesInventoryMSAlauyaTradingBarcodeScanner
{
    partial class frmSearchProductStockIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchProductStockIn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productSearch = new MetroFramework.Controls.MetroTextBox();
            this.label1SearchProd = new System.Windows.Forms.Label();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.productSearch);
            this.panel1.Controls.Add(this.label1SearchProd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 52);
            this.panel1.TabIndex = 2;
            // 
            // productSearch
            // 
            this.productSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.productSearch.CustomButton.Image = null;
            this.productSearch.CustomButton.Location = new System.Drawing.Point(363, 1);
            this.productSearch.CustomButton.Name = "";
            this.productSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.productSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.productSearch.CustomButton.TabIndex = 1;
            this.productSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.productSearch.CustomButton.UseSelectable = true;
            this.productSearch.CustomButton.Visible = false;
            this.productSearch.DisplayIcon = true;
            this.productSearch.Icon = ((System.Drawing.Image)(resources.GetObject("productSearch.Icon")));
            this.productSearch.Lines = new string[0];
            this.productSearch.Location = new System.Drawing.Point(238, 13);
            this.productSearch.MaxLength = 32767;
            this.productSearch.Name = "productSearch";
            this.productSearch.PasswordChar = '\0';
            this.productSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.productSearch.SelectedText = "";
            this.productSearch.SelectionLength = 0;
            this.productSearch.SelectionStart = 0;
            this.productSearch.ShortcutsEnabled = true;
            this.productSearch.Size = new System.Drawing.Size(389, 27);
            this.productSearch.TabIndex = 9;
            this.productSearch.UseSelectable = true;
            this.productSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.productSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.productSearch.TextChanged += new System.EventHandler(this.productSearch_TextChanged);
            // 
            // label1SearchProd
            // 
            this.label1SearchProd.AutoSize = true;
            this.label1SearchProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1SearchProd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1SearchProd.Location = new System.Drawing.Point(12, 16);
            this.label1SearchProd.Name = "label1SearchProd";
            this.label1SearchProd.Size = new System.Drawing.Size(120, 21);
            this.label1SearchProd.TabIndex = 2;
            this.label1SearchProd.Text = "PRODUCT LIST";
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.AllowUserToResizeColumns = false;
            this.dataGridView6.AllowUserToResizeRows = false;
            this.dataGridView6.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView6.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView6.ColumnHeadersHeight = 30;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column7,
            this.Select});
            this.dataGridView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView6.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView6.EnableHeadersVisualStyles = false;
            this.dataGridView6.Location = new System.Drawing.Point(0, 52);
            this.dataGridView6.MultiSelect = false;
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersVisible = false;
            this.dataGridView6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView6.Size = new System.Drawing.Size(865, 345);
            this.dataGridView6.TabIndex = 6;
            this.dataGridView6.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView6_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.Width = 37;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "PCODE";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 53;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.HeaderText = "DESCRIPTION";
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column7.HeaderText = "STOCK";
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 51;
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Select.HeaderText = "";
            this.Select.Image = ((System.Drawing.Image)(resources.GetObject("Select.Image")));
            this.Select.Name = "Select";
            this.Select.Width = 5;
            // 
            // frmSearchProductStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 397);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSearchProductStockIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alauya Trading";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSearchProductStockIn_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1SearchProd;
        public System.Windows.Forms.DataGridView dataGridView6;
        private MetroFramework.Controls.MetroTextBox productSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Select;
    }
}