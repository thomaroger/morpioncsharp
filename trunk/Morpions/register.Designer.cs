namespace Morpions
{
    partial class register
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
            this.lb_register = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_password2 = new System.Windows.Forms.Label();
            this.lb_surname = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_password2 = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.bt_submit = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_register
            // 
            this.lb_register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_register.AutoSize = true;
            this.lb_register.BackColor = System.Drawing.SystemColors.Control;
            this.lb_register.Font = new System.Drawing.Font("Georgia", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lb_register.Location = new System.Drawing.Point(228, 47);
            this.lb_register.Name = "lb_register";
            this.lb_register.Size = new System.Drawing.Size(139, 27);
            this.lb_register.TabIndex = 0;
            this.lb_register.Text = "Inscription";
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Georgia", 10F);
            this.lb_login.Location = new System.Drawing.Point(40, 158);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(172, 17);
            this.lb_login.TabIndex = 1;
            this.lb_login.Text = "Nom d\'utilisateur (Login) :";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Georgia", 10F);
            this.lb_password.Location = new System.Drawing.Point(42, 224);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(170, 17);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "Mot de Passe (Password) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10F);
            this.label3.Location = new System.Drawing.Point(154, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email :";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Georgia", 10F);
            this.lb_name.Location = new System.Drawing.Point(364, 280);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(65, 17);
            this.lb_name.TabIndex = 4;
            this.lb_name.Text = "Prénom :";
            // 
            // lb_password2
            // 
            this.lb_password2.AutoSize = true;
            this.lb_password2.Font = new System.Drawing.Font("Georgia", 10F);
            this.lb_password2.Location = new System.Drawing.Point(35, 280);
            this.lb_password2.Name = "lb_password2";
            this.lb_password2.Size = new System.Drawing.Size(177, 17);
            this.lb_password2.TabIndex = 5;
            this.lb_password2.Text = "Confirmer le mot de passe :";
            // 
            // lb_surname
            // 
            this.lb_surname.AutoSize = true;
            this.lb_surname.Font = new System.Drawing.Font("Georgia", 10F);
            this.lb_surname.Location = new System.Drawing.Point(383, 339);
            this.lb_surname.Name = "lb_surname";
            this.lb_surname.Size = new System.Drawing.Size(46, 17);
            this.lb_surname.TabIndex = 6;
            this.lb_surname.Text = "Nom :";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(225, 158);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(118, 20);
            this.tb_login.TabIndex = 7;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(225, 224);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(118, 20);
            this.tb_password.TabIndex = 8;
            // 
            // tb_password2
            // 
            this.tb_password2.Location = new System.Drawing.Point(225, 277);
            this.tb_password2.Name = "tb_password2";
            this.tb_password2.PasswordChar = '*';
            this.tb_password2.Size = new System.Drawing.Size(118, 20);
            this.tb_password2.TabIndex = 9;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(225, 336);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(118, 20);
            this.tb_email.TabIndex = 10;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(435, 277);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(118, 20);
            this.tb_name.TabIndex = 11;
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(435, 336);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(118, 20);
            this.tb_surname.TabIndex = 12;
            // 
            // bt_submit
            // 
            this.bt_submit.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_submit.Font = new System.Drawing.Font("Georgia", 12F);
            this.bt_submit.ForeColor = System.Drawing.Color.Red;
            this.bt_submit.Location = new System.Drawing.Point(104, 428);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(108, 35);
            this.bt_submit.TabIndex = 13;
            this.bt_submit.Text = "Valider";
            this.bt_submit.UseVisualStyleBackColor = false;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_close.Font = new System.Drawing.Font("Georgia", 12F);
            this.bt_close.ForeColor = System.Drawing.Color.Red;
            this.bt_close.Location = new System.Drawing.Point(321, 428);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(108, 35);
            this.bt_close.TabIndex = 14;
            this.bt_close.Text = "Fermer";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(594, 492);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_password2);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.lb_surname);
            this.Controls.Add(this.lb_password2);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.lb_register);
            this.Name = "register";
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_register;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_password2;
        private System.Windows.Forms.Label lb_surname;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_password2;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Button bt_close;
    }
}