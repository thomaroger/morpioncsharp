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
            this.SuspendLayout();
            // 
            // bt_submit
            // 
            this.bt_submit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_submit.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_submit.Font = new System.Drawing.Font("Georgia", 12F);
            this.bt_submit.ForeColor = System.Drawing.Color.Red;
            this.bt_submit.Location = new System.Drawing.Point(77, 214);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(130, 42);
            this.bt_submit.TabIndex = 0;
            this.bt_submit.Text = "Valider";
            this.bt_submit.UseVisualStyleBackColor = false;
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Georgia", 9F);
            this.lb_login.Location = new System.Drawing.Point(63, 35);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(46, 15);
            this.lb_login.TabIndex = 1;
            this.lb_login.Text = "Login :";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Georgia", 9F);
            this.lb_password.Location = new System.Drawing.Point(43, 72);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(67, 15);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "Password :";
            // 
            // lb_register
            // 
            this.lb_register.AutoSize = true;
            this.lb_register.Location = new System.Drawing.Point(113, 158);
            this.lb_register.Name = "lb_register";
            this.lb_register.Size = new System.Drawing.Size(49, 13);
            this.lb_register.TabIndex = 3;
            this.lb_register.Text = "S\'inscrire";
            // 
            // lb_passwordforget
            // 
            this.lb_passwordforget.AutoSize = true;
            this.lb_passwordforget.Location = new System.Drawing.Point(88, 185);
            this.lb_passwordforget.Name = "lb_passwordforget";
            this.lb_passwordforget.Size = new System.Drawing.Size(103, 13);
            this.lb_passwordforget.TabIndex = 4;
            this.lb_passwordforget.Text = "Mot de Passe oublié";
            // 
            // tb_login
            // 
            this.tb_login.BackColor = System.Drawing.Color.LightGray;
            this.tb_login.Font = new System.Drawing.Font("Georgia", 9F);
            this.tb_login.Location = new System.Drawing.Point(115, 30);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(91, 21);
            this.tb_login.TabIndex = 5;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.LightGray;
            this.tb_password.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(115, 70);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(91, 21);
            this.tb_password.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 268);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.lb_passwordforget);
            this.Controls.Add(this.lb_register);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.bt_submit);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

