
namespace SalesInventoryMSAlauyaTradingBarcodeScanner
{
    partial class frmProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.productPCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productBrand = new System.Windows.Forms.ComboBox();
            this.productCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.productUpdate = new System.Windows.Forms.Button();
            this.productCancel = new System.Windows.Forms.Button();
            this.productSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.productBCode = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.reorder = new System.Windows.Forms.Label();
            this.txtReorder = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 52);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "PRODUCT DETAILS";
            // 
            // productPCode
            // 
            this.productPCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productPCode.Location = new System.Drawing.Point(109, 65);
            this.productPCode.Name = "productPCode";
            this.productPCode.Size = new System.Drawing.Size(203, 25);
            this.productPCode.TabIndex = 13;
            this.productPCode.TextChanged += new System.EventHandler(this.productPCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product Code";
            // 
            // productDesc
            // 
            this.productDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productDesc.Location = new System.Drawing.Point(109, 128);
            this.productDesc.Multiline = true;
            this.productDesc.Name = "productDesc";
            this.productDesc.Size = new System.Drawing.Size(203, 55);
            this.productDesc.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Brand";
            // 
            // productBrand
            // 
            this.productBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productBrand.FormattingEnabled = true;
            this.productBrand.Location = new System.Drawing.Point(109, 189);
            this.productBrand.Name = "productBrand";
            this.productBrand.Size = new System.Drawing.Size(203, 25);
            this.productBrand.Sorted = true;
            this.productBrand.TabIndex = 17;
            this.productBrand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productBrand_KeyPress);
            // 
            // productCategory
            // 
            this.productCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productCategory.FormattingEnabled = true;
            this.productCategory.Location = new System.Drawing.Point(108, 220);
            this.productCategory.Name = "productCategory";
            this.productCategory.Size = new System.Drawing.Size(203, 25);
            this.productCategory.Sorted = true;
            this.productCategory.TabIndex = 19;
            this.productCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productCategory_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Category";
            // 
            // productPrice
            // 
            this.productPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productPrice.Location = new System.Drawing.Point(108, 251);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(90, 25);
            this.productPrice.TabIndex = 21;
            this.productPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.productPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productPrice_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(67, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Price";
            // 
            // productUpdate
            // 
            this.productUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.productUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productUpdate.FlatAppearance.BorderSize = 0;
            this.productUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productUpdate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.productUpdate.Location = new System.Drawing.Point(131, 316);
            this.productUpdate.Name = "productUpdate";
            this.productUpdate.Size = new System.Drawing.Size(61, 27);
            this.productUpdate.TabIndex = 26;
            this.productUpdate.Text = "Update";
            this.productUpdate.UseVisualStyleBackColor = false;
            this.productUpdate.Click += new System.EventHandler(this.productUpdate_Click);
            // 
            // productCancel
            // 
            this.productCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productCancel.BackColor = System.Drawing.Color.DarkRed;
            this.productCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productCancel.FlatAppearance.BorderSize = 0;
            this.productCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productCancel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.productCancel.Location = new System.Drawing.Point(198, 316);
            this.productCancel.Name = "productCancel";
            this.productCancel.Size = new System.Drawing.Size(61, 27);
            this.productCancel.TabIndex = 25;
            this.productCancel.Text = "Cancel";
            this.productCancel.UseVisualStyleBackColor = false;
            this.productCancel.Click += new System.EventHandler(this.productCancel_Click);
            // 
            // productSave
            // 
            this.productSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.productSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productSave.FlatAppearance.BorderSize = 0;
            this.productSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productSave.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSave.ForeColor = System.Drawing.SystemColors.Control;
            this.productSave.Location = new System.Drawing.Point(64, 316);
            this.productSave.Name = "productSave";
            this.productSave.Size = new System.Drawing.Size(61, 27);
            this.productSave.TabIndex = 24;
            this.productSave.Text = "Save";
            this.productSave.UseVisualStyleBackColor = false;
            this.productSave.Click += new System.EventHandler(this.productSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(47, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Barcode";
            // 
            // productBCode
            // 
            this.productBCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productBCode.Enabled = false;
            this.productBCode.Location = new System.Drawing.Point(109, 97);
            this.productBCode.Name = "productBCode";
            this.productBCode.Size = new System.Drawing.Size(142, 25);
            this.productBCode.TabIndex = 28;
            this.productBCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productBCode_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(113, 255);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 17);
            this.label17.TabIndex = 29;
            this.label17.Text = "₱";
            // 
            // reorder
            // 
            this.reorder.AutoSize = true;
            this.reorder.ForeColor = System.Drawing.SystemColors.Control;
            this.reorder.Location = new System.Drawing.Point(7, 285);
            this.reorder.Name = "reorder";
            this.reorder.Size = new System.Drawing.Size(96, 17);
            this.reorder.TabIndex = 30;
            this.reorder.Text = "Re-Order Level";
            // 
            // txtReorder
            // 
            this.txtReorder.Location = new System.Drawing.Point(108, 282);
            this.txtReorder.Name = "txtReorder";
            this.txtReorder.Size = new System.Drawing.Size(51, 25);
            this.txtReorder.TabIndex = 31;
            this.txtReorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtReorder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReorder_KeyPress);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(257, 102);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 15);
            this.linkLabel1.TabIndex = 32;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Generate";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(323, 350);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtReorder);
            this.Controls.Add(this.reorder);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.productBCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.productUpdate);
            this.Controls.Add(this.productCancel);
            this.Controls.Add(this.productSave);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.productCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.productBrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productPCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alauya Trading";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox productPCode;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox productDesc;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox productPrice;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button productUpdate;
        public System.Windows.Forms.Button productCancel;
        public System.Windows.Forms.Button productSave;
        public System.Windows.Forms.ComboBox productBrand;
        public System.Windows.Forms.ComboBox productCategory;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox productBCode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label reorder;
        public System.Windows.Forms.TextBox txtReorder;
        public System.Windows.Forms.LinkLabel linkLabel1;
    }
}