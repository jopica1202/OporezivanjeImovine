namespace OporezivanjeImovine
{
    partial class Form_Login
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
            this.lbl_login = new System.Windows.Forms.Label();
            this.Txt_name = new System.Windows.Forms.TextBox();
            this.Txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_Uloguj = new System.Windows.Forms.Button();
            this.btn_registruj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(396, 101);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(79, 31);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Login";
            this.lbl_login.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_name
            // 
            this.Txt_name.Location = new System.Drawing.Point(465, 194);
            this.Txt_name.Name = "Txt_name";
            this.Txt_name.Size = new System.Drawing.Size(243, 22);
            this.Txt_name.TabIndex = 1;
            // 
            // Txt_pass
            // 
            this.Txt_pass.Location = new System.Drawing.Point(465, 258);
            this.Txt_pass.Name = "Txt_pass";
            this.Txt_pass.Size = new System.Drawing.Size(243, 22);
            this.Txt_pass.TabIndex = 1;
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mail.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mail.Location = new System.Drawing.Point(337, 194);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(87, 31);
            this.lbl_mail.TabIndex = 0;
            this.lbl_mail.Text = "E-mail";
            this.lbl_mail.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(337, 258);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(103, 31);
            this.lbl_password.TabIndex = 0;
            this.lbl_password.Text = "Lozinka";
            this.lbl_password.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Uloguj
            // 
            this.btn_Uloguj.BackColor = System.Drawing.Color.Transparent;
            this.btn_Uloguj.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Uloguj.Location = new System.Drawing.Point(377, 344);
            this.btn_Uloguj.Name = "btn_Uloguj";
            this.btn_Uloguj.Size = new System.Drawing.Size(146, 51);
            this.btn_Uloguj.TabIndex = 2;
            this.btn_Uloguj.Text = "Uloguj se";
            this.btn_Uloguj.UseVisualStyleBackColor = false;
            this.btn_Uloguj.Click += new System.EventHandler(this.btn_Uloguj_Click);
            // 
            // btn_registruj
            // 
            this.btn_registruj.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registruj.Location = new System.Drawing.Point(365, 412);
            this.btn_registruj.Name = "btn_registruj";
            this.btn_registruj.Size = new System.Drawing.Size(172, 40);
            this.btn_registruj.TabIndex = 3;
            this.btn_registruj.Text = "Registruj se";
            this.btn_registruj.UseVisualStyleBackColor = true;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OporezivanjeImovine.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(948, 596);
            this.Controls.Add(this.btn_registruj);
            this.Controls.Add(this.btn_Uloguj);
            this.Controls.Add(this.Txt_pass);
            this.Controls.Add(this.Txt_name);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.lbl_login);
            this.Name = "Form_Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.TextBox Txt_name;
        private System.Windows.Forms.TextBox Txt_pass;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_Uloguj;
        private System.Windows.Forms.Button btn_registruj;
    }
}

