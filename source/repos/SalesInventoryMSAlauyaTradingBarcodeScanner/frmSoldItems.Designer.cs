
namespace SalesInventoryMSAlauyaTradingBarcodeScanner
{
    partial class frmSoldItems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSoldItems));
            this.panelSoldItems = new System.Windows.Forms.Panel();
            this.lblSoldItems = new System.Windows.Forms.Label();
            this.dataGridViewSold = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cboCashier = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCancel = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelSoldItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSold)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSoldItems
            // 
            this.panelSoldItems.BackColor = System.Drawing.Color.Goldenrod;
            this.panelSoldItems.Controls.Add(this.lblSoldItems);
            this.panelSoldItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSoldItems.Location = new System.Drawing.Point(0, 0);
            this.panelSoldItems.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelSoldItems.Name = "panelSoldItems";
            this.panelSoldItems.Size = new System.Drawing.Size(922, 44);
            this.panelSoldItems.TabIndex = 4;
            // 
            // lblSoldItems
            // 
            this.lblSoldItems.AutoSize = true;
            this.lblSoldItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldItems.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSoldItems.Location = new System.Drawing.Point(10, 12);
            this.lblSoldItems.Name = "lblSoldItems";
            this.lblSoldItems.Size = new System.Drawing.Size(178, 21);
            this.lblSoldItems.TabIndex = 2;
            this.lblSoldItems.Text = "DAILY SALES MODULE";
            // 
            // dataGridViewSold
            // 
            this.dataGridViewSold.AllowUserToAddRows = false;
            this.dataGridViewSold.AllowUserToDeleteRows = false;
            this.dataGridViewSold.AllowUserToResizeColumns = false;
            this.dataGridViewSold.AllowUserToResizeRows = false;
            this.dataGridViewSold.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSold.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSold.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSold.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSold.ColumnHeadersHeight = 30;
            this.dataGridViewSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSold.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.colCancel});
            this.dataGridViewSold.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewSold.EnableHeadersVisualStyles = false;
            this.dataGridViewSold.Location = new System.Drawing.Point(0, 84);
            this.dataGridViewSold.MultiSelect = false;
            this.dataGridViewSold.Name = "dataGridViewSold";
            this.dataGridViewSold.RowHeadersVisible = false;
            this.dataGridViewSold.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSold.Size = new System.Drawing.Size(922, 454);
            this.dataGridViewSold.TabIndex = 5;
            this.dataGridViewSold.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSold_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filter By Date (From - To)";
            // 
            // dt1
            // 
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt1.Location = new System.Drawing.Point(171, 53);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(103, 25);
            this.dt1.TabIndex = 7;
            this.dt1.ValueChanged += new System.EventHandler(this.dt1_ValueChanged);
            // 
            // dt2
            // 
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt2.Location = new System.Drawing.Point(280, 53);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(103, 25);
            this.dt2.TabIndex = 8;
            this.dt2.ValueChanged += new System.EventHandler(this.dt2_ValueChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTotal.Location = new System.Drawing.Point(752, 48);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(158, 32);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(548, 53);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(114, 25);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print Preview";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cboCashier
            // 
            this.cboCashier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCashier.FormattingEnabled = true;
            this.cboCashier.Location = new System.Drawing.Point(389, 53);
            this.cboCashier.Name = "cboCashier";
            this.cboCashier.Size = new System.Drawing.Size(153, 25);
            this.cboCashier.TabIndex = 12;
            this.cboCashier.SelectedIndexChanged += new System.EventHandler(this.cboCashier_SelectedIndexChanged);
            this.cboCashier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCashier_KeyPress);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.Width = 39;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "INVOICE #";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 73;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.HeaderText = "PCODE";
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 53;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column6.HeaderText = "DESCRIPTION";
            this.Column6.Name = "Column6";
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column7.HeaderText = "PRICE";
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 45;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column8.HeaderText = "QTY";
            this.Column8.Name = "Column8";
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 36;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column9.HeaderText = "DISCOUNT";
            this.Column9.Name = "Column9";
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 75;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column10.HeaderText = "TOTAL";
            this.Column10.Name = "Column10";
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column10.Width = 50;
            // 
            // colCancel
            // 
            this.colCancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCancel.HeaderText = "";
            this.colCancel.Image = ((System.Drawing.Image)(resources.GetObject("colCancel.Image")));
            this.colCancel.Name = "colCancel";
            this.colCancel.Width = 5;
            // 
            // frmSoldItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 538);
            this.ControlBox = false;
            this.Controls.Add(this.cboCashier);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dt2);
            this.Controls.Add(this.dt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewSold);
            this.Controls.Add(this.panelSoldItems);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSoldItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alauya Trading";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSoldItems_KeyDown);
            this.panelSoldItems.ResumeLayout(false);
            this.panelSoldItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panelSoldItems;
        public System.Windows.Forms.Label lblSoldItems;
        public System.Windows.Forms.DataGridView dataGridViewSold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Button btnPrint;
        public System.Windows.Forms.DateTimePicker dt1;
        public System.Windows.Forms.DateTimePicker dt2;
        public System.Windows.Forms.ComboBox cboCashier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewImageColumn colCancel;
    }
}