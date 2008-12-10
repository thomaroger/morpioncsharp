namespace Morpions
{
    partial class Form1
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
            this.bt_submit = new System.Windows.Forms.Button();
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_register = new System.Windows.Forms.Label();
            this.lb_passwordforget = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_submit
            // 
            this.bt_submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_submit.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_submit.Font = new System.Drawing.Font("Georgia", 12F);
            this.bt_submit.ForeColor = System.Drawing.Color.Red;
            this.bt_submit.Location = new System.Drawing.Point(156, 251);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(174, 51);
            this.bt_submit.TabIndex = 0;
            this.bt_submit.Text = "Valider";
            this.bt_submit.UseVisualStyleBackColor = false;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // lb_login
            // 
            this.lb_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Georgia", 9F);
            this.lb_login.Location = new System.Drawing.Point(220, 47);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(46, 15);
            this.lb_login.TabIndex = 1;
            this.lb_login.Text = "Login :";
            // 
            // lb_password
            // 
            this.lb_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Georgia", 9F);
            this.lb_password.Location = new System.Drawing.Point(210, 103);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(67, 15);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "Password :";
            // 
            // lb_register
            // 
            this.lb_register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_register.Font = new System.Drawing.Font("Georgia", 9F);
            this.lb_register.Location = new System.Drawing.Point(210, 196);
            this.lb_register.Name = "lb_register";
            this.lb_register.Size = new System.Drawing.Size(65, 16);
            this.lb_register.TabIndex = 3;
            this.lb_register.Text = "S\'inscrire";
            this.lb_register.Click += new System.EventHandler(this.lb_register_Click);
            // 
            // lb_passwordforget
            // 
            this.lb_passwordforget.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_passwordforget.AutoSize = true;
            this.lb_passwordforget.Font = new System.Drawing.Font("Georgia", 9F);
            this.lb_passwordforget.Location = new System.Drawing.Point(185, 223);
            this.lb_passwordforget.Name = "lb_passwordforget";
            this.lb_passwordforget.Size = new System.Drawing.Size(116, 15);
            this.lb_passwordforget.TabIndex = 4;
            this.lb_passwordforget.Text = "Mot de Passe oublié";
            this.lb_passwordforget.Click += new System.EventHandler(this.lb_passwordforget_Click);
            // 
            // tb_login
            // 
            this.tb_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_login.BackColor = System.Drawing.Color.LightGray;
            this.tb_login.Font = new System.Drawing.Font("Georgia", 9F);
            this.tb_login.Location = new System.Drawing.Point(182, 65);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(119, 21);
            this.tb_login.TabIndex = 5;
            // 
            // tb_password
            // 
            this.tb_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_password.BackColor = System.Drawing.Color.LightGray;
            this.tb_password.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(183, 121);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(119, 21);
            this.tb_password.TabIndex = 6;
            // 
            // bt_close
            // 
            this.bt_close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_close.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_close.Font = new System.Drawing.Font("Georgia", 12F);
            this.bt_close.ForeColor = System.Drawing.Color.Red;
            this.bt_close.Location = new System.Drawing.Point(156, 339);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(174, 40);
            this.bt_close.TabIndex = 7;
            this.bt_close.Text = "Fermer";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.bt_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_close;
            this.ClientSize = new System.Drawing.Size(486, 391);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.lb_passwordforget);
            this.Controls.Add(this.lb_register);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.bt_submit);
            this.Font = new System.Drawing.Font("Georgia", 10F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Morpion : Connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_register;
        private System.Windows.Forms.Label lb_passwordforget;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button bt_close;
    }
}

