
namespace SalesInventoryMSAlauyaTradingBarcodeScanner
{
    partial class frmVoid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoid));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVoid = new System.Windows.Forms.Button();
            this.voidUser = new MetroFramework.Controls.MetroTextBox();
            this.voidPass = new MetroFramework.Controls.MetroTextBox();
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
            this.panel1.Size = new System.Drawing.Size(257, 52);
            this.panel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Void Order";
            // 
            // btnVoid
            // 
            this.btnVoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnVoid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoid.FlatAppearance.BorderSize = 0;
            this.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoid.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoid.ForeColor = System.Drawing.Color.White;
            this.btnVoid.Location = new System.Drawing.Point(98, 125);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(61, 27);
            this.btnVoid.TabIndex = 27;
            this.btnVoid.Text = "VOID";
            this.btnVoid.UseVisualStyleBackColor = false;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            // 
            // voidUser
            // 
            // 
            // 
            // 
            this.voidUser.CustomButton.Image = null;
            this.voidUser.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.voidUser.CustomButton.Name = "";
            this.voidUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.voidUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.voidUser.CustomButton.TabIndex = 1;
            this.voidUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.voidUser.CustomButton.UseSelectable = true;
            this.voidUser.CustomButton.Visible = false;
            this.voidUser.DisplayIcon = true;
            this.voidUser.Icon = ((System.Drawing.Image)(resources.GetObject("voidUser.Icon")));
            this.voidUser.Lines = new string[0];
            this.voidUser.Location = new System.Drawing.Point(41, 67);
            this.voidUser.MaxLength = 32767;
            this.voidUser.Name = "voidUser";
            this.voidUser.PasswordChar = '\0';
            this.voidUser.PromptText = "Username";
            this.voidUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.voidUser.SelectedText = "";
            this.voidUser.SelectionLength = 0;
            this.voidUser.SelectionStart = 0;
            this.voidUser.ShortcutsEnabled = true;
            this.voidUser.Size = new System.Drawing.Size(175, 23);
            this.voidUser.TabIndex = 28;
            this.voidUser.UseSelectable = true;
            this.voidUser.WaterMark = "Username";
            this.voidUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.voidUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // voidPass
            // 
            // 
            // 
            // 
            this.voidPass.CustomButton.Image = null;
            this.voidPass.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.voidPass.CustomButton.Name = "";
            this.voidPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.voidPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.voidPass.CustomButton.TabIndex = 1;
            this.voidPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.voidPass.CustomButton.UseSelectable = true;
            this.voidPass.CustomButton.Visible = false;
            this.voidPass.DisplayIcon = true;
            this.voidPass.Icon = ((System.Drawing.Image)(resources.GetObject("voidPass.Icon")));
            this.voidPass.Lines = new string[0];
            this.voidPass.Location = new System.Drawing.Point(41, 96);
            this.voidPass.MaxLength = 32767;
            this.voidPass.Name = "voidPass";
            this.voidPass.PasswordChar = '●';
            this.voidPass.PromptText = "Password";
            this.voidPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.voidPass.SelectedText = "";
            this.voidPass.SelectionLength = 0;
            this.voidPass.SelectionStart = 0;
            this.voidPass.ShortcutsEnabled = true;
            this.voidPass.Size = new System.Drawing.Size(175, 23);
            this.voidPass.TabIndex = 29;
            this.voidPass.UseSelectable = true;
            this.voidPass.UseSystemPasswordChar = true;
            this.voidPass.WaterMark = "Password";
            this.voidPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.voidPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmVoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(257, 157);
            this.ControlBox = false;
            this.Controls.Add(this.voidPass);
            this.Controls.Add(this.voidUser);
            this.Controls.Add(this.btnVoid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVoid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alauya Trading";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVoid_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnVoid;
        public MetroFramework.Controls.MetroTextBox voidUser;
        private MetroFramework.Controls.MetroTextBox voidPass;
    }
}