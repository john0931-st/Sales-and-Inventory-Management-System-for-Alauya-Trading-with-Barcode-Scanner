
namespace SalesInventoryMSAlauyaTradingBarcodeScanner
{
    partial class frmCancelDetails
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTransNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVoid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCancel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cboAction = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtCancelQty = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(543, 43);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "VOID MODULE";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(110, 87);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(97, 20);
            this.txtID.TabIndex = 15;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTransNo
            // 
            this.txtTransNo.Enabled = false;
            this.txtTransNo.Location = new System.Drawing.Point(391, 87);
            this.txtTransNo.Name = "txtTransNo";
            this.txtTransNo.Size = new System.Drawing.Size(130, 20);
            this.txtTransNo.TabIndex = 15;
            this.txtTransNo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(298, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Transaction No.";
            // 
            // txtPCode
            // 
            this.txtPCode.Enabled = false;
            this.txtPCode.Location = new System.Drawing.Point(110, 113);
            this.txtPCode.Name = "txtPCode";
            this.txtPCode.Size = new System.Drawing.Size(169, 20);
            this.txtPCode.TabIndex = 15;
            this.txtPCode.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Product ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID";
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(110, 139);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(169, 45);
            this.txtDescription.TabIndex = 15;
            this.txtDescription.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Description";
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Location = new System.Drawing.Point(391, 139);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(39, 20);
            this.txtQty.TabIndex = 15;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(308, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Qty | Discount";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(391, 165);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(108, 20);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(350, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total";
            // 
            // txtVoid
            // 
            this.txtVoid.Enabled = false;
            this.txtVoid.Location = new System.Drawing.Point(110, 233);
            this.txtVoid.Name = "txtVoid";
            this.txtVoid.Size = new System.Drawing.Size(169, 20);
            this.txtVoid.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(58, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Void By";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(225, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "SOLD ITEM";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(391, 113);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(108, 20);
            this.txtPrice.TabIndex = 15;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(350, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Price";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(215, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 21);
            this.label12.TabIndex = 17;
            this.label12.Text = "CANCEL ITEM";
            // 
            // txtCancel
            // 
            this.txtCancel.Enabled = false;
            this.txtCancel.Location = new System.Drawing.Point(110, 259);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.Size = new System.Drawing.Size(169, 20);
            this.txtCancel.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(32, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Cancelled By";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(391, 259);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(130, 46);
            this.txtReason.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(326, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Reason(s)\r\n";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(11, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Add to inventory?";
            // 
            // cboAction
            // 
            this.cboAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAction.FormattingEnabled = true;
            this.cboAction.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboAction.Location = new System.Drawing.Point(110, 285);
            this.cboAction.Name = "cboAction";
            this.cboAction.Size = new System.Drawing.Size(54, 21);
            this.cboAction.TabIndex = 18;
            this.cboAction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboAction_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(410, 311);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(111, 32);
            this.btnLogin.TabIndex = 25;
            this.btnLogin.Text = "Cancel Order";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtCancelQty
            // 
            this.txtCancelQty.Location = new System.Drawing.Point(391, 233);
            this.txtCancelQty.Name = "txtCancelQty";
            this.txtCancelQty.Size = new System.Drawing.Size(39, 20);
            this.txtCancelQty.TabIndex = 15;
            this.txtCancelQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCancelQty.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.txtCancelQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCancelQty_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(326, 236);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Cancel Qty";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Location = new System.Drawing.Point(436, 139);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(63, 20);
            this.txtDiscount.TabIndex = 15;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(439, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "₱";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(394, 117);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "₱";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(394, 168);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "₱";
            // 
            // frmCancelDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(543, 354);
            this.ControlBox = false;
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cboAction);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPCode);
            this.Controls.Add(this.txtTransNo);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtCancel);
            this.Controls.Add(this.txtVoid);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCancelQty);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCancelDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alauya Trading";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCancelDetails_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtVoid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtCancel;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.ComboBox cboAction;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtTransNo;
        public System.Windows.Forms.TextBox txtPCode;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.TextBox txtCancelQty;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}