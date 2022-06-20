
namespace SalesInventoryMSAlauyaTradingBarcodeScanner
{
    partial class frmVendor
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Goldenrod;
            this.panel6.Controls.Add(this.label13);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(399, 40);
            this.panel6.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 21);
            this.label13.TabIndex = 3;
            this.label13.Text = "SUPPLIER DETAILS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Supplier";
            // 
            // txtVendor
            // 
            this.txtVendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendor.Location = new System.Drawing.Point(108, 46);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Size = new System.Drawing.Size(285, 25);
            this.txtVendor.TabIndex = 9;
            this.txtVendor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVendor_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(108, 77);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(285, 69);
            this.txtAddress.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Address";
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Location = new System.Drawing.Point(108, 183);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(285, 25);
            this.txtTel.TabIndex = 15;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Telephone";
            // 
            // txtPerson
            // 
            this.txtPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPerson.Location = new System.Drawing.Point(108, 152);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Size = new System.Drawing.Size(285, 25);
            this.txtPerson.TabIndex = 13;
            this.txtPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPerson_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Contact Person";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(108, 214);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(285, 25);
            this.txtEmail.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(63, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email";
            // 
            // txtFax
            // 
            this.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFax.Location = new System.Drawing.Point(108, 245);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(285, 25);
            this.txtFax.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(75, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Fax";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_update.Location = new System.Drawing.Point(265, 276);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(61, 27);
            this.btn_update.TabIndex = 22;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkRed;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel.Location = new System.Drawing.Point(332, 276);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(61, 27);
            this.btn_cancel.TabIndex = 21;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_save.Location = new System.Drawing.Point(198, 276);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(61, 27);
            this.btn_save.TabIndex = 20;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(9, 46);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 17);
            this.lblID.TabIndex = 23;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // frmVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(399, 309);
            this.ControlBox = false;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPerson);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVendor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel6);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmVendor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Alauya Trading";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVendor_KeyDown);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.TextBox txtVendor;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtTel;
        public System.Windows.Forms.TextBox txtPerson;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtFax;
        public System.Windows.Forms.Label lblID;
    }
}