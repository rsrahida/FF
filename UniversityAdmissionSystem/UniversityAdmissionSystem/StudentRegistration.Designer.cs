namespace UniversityAdmissionSystem
{
    partial class StudentRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRegistration));
            this.logopctrbx = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.registlbl = new System.Windows.Forms.Label();
            this.gmaillbl = new System.Windows.Forms.Label();
            this.txtgmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logopctrbx)).BeginInit();
            this.SuspendLayout();
            // 
            // logopctrbx
            // 
            this.logopctrbx.Image = ((System.Drawing.Image)(resources.GetObject("logopctrbx.Image")));
            this.logopctrbx.Location = new System.Drawing.Point(12, 12);
            this.logopctrbx.Name = "logopctrbx";
            this.logopctrbx.Size = new System.Drawing.Size(201, 50);
            this.logopctrbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logopctrbx.TabIndex = 0;
            this.logopctrbx.TabStop = false;
            this.logopctrbx.Click += new System.EventHandler(this.logopctrbx_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(256, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(396, 320);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 30);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Registrate";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(396, 239);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(120, 30);
            this.txtpassword.TabIndex = 5;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.Location = new System.Drawing.Point(279, 239);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(111, 30);
            this.passwordlbl.TabIndex = 7;
            this.passwordlbl.Text = "Password:";
            this.passwordlbl.Click += new System.EventHandler(this.passwordlbl_Click);
            // 
            // registlbl
            // 
            this.registlbl.AutoSize = true;
            this.registlbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registlbl.Location = new System.Drawing.Point(187, 111);
            this.registlbl.Name = "registlbl";
            this.registlbl.Size = new System.Drawing.Size(398, 32);
            this.registlbl.TabIndex = 8;
            this.registlbl.Text = "STUDENT REGISTRATION SYSTEM";
            this.registlbl.Click += new System.EventHandler(this.registlbl_Click);
            // 
            // gmaillbl
            // 
            this.gmaillbl.AutoSize = true;
            this.gmaillbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmaillbl.Location = new System.Drawing.Point(230, 182);
            this.gmaillbl.Name = "gmaillbl";
            this.gmaillbl.Size = new System.Drawing.Size(160, 30);
            this.gmaillbl.TabIndex = 9;
            this.gmaillbl.Text = "Gmail Address:";
            this.gmaillbl.Click += new System.EventHandler(this.gmaillbl_Click);
            // 
            // txtgmail
            // 
            this.txtgmail.Location = new System.Drawing.Point(396, 182);
            this.txtgmail.Multiline = true;
            this.txtgmail.Name = "txtgmail";
            this.txtgmail.Size = new System.Drawing.Size(120, 30);
            this.txtgmail.TabIndex = 10;
            this.txtgmail.TextChanged += new System.EventHandler(this.txtgmail_TextChanged);
            // 
            // StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtgmail);
            this.Controls.Add(this.gmaillbl);
            this.Controls.Add(this.registlbl);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.logopctrbx);
            this.Name = "StudentRegistration";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logopctrbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logopctrbx;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Label registlbl;
        private System.Windows.Forms.Label gmaillbl;
        private System.Windows.Forms.TextBox txtgmail;
    }
}

