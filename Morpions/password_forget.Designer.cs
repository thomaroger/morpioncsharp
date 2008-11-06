namespace Morpions
{
    partial class password_forget
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
            this.bt_close = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.bt_submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_close.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_close.Font = new System.Drawing.Font("Georgia", 12F);
            this.bt_close.ForeColor = System.Drawing.Color.Red;
            this.bt_close.Location = new System.Drawing.Point(123, 307);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(174, 40);
            this.bt_close.TabIndex = 15;
            this.bt_close.Text = "Fermer";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // tb_name
            // 
            this.tb_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_name.BackColor = System.Drawing.Color.LightGray;
            this.tb_name.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(150, 89);
            this.tb_name.Name = "tb_name";
            this.tb_name.PasswordChar = '*';
            this.tb_name.Size = new System.Drawing.Size(119, 21);
            this.tb_name.TabIndex = 14;
            // 
            // tb_login
            // 
            this.tb_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_login.BackColor = System.Drawing.Color.LightGray;
            this.tb_login.Font = new System.Drawing.Font("Georgia", 9F);
            this.tb_login.Location = new System.Drawing.Point(150, 33);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(119, 21);
            this.tb_login.TabIndex = 13;
            // 
            // lb_name
            // 
            this.lb_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Georgia", 9F);
            this.lb_name.Location = new System.Drawing.Point(182, 71);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(62, 15);
            this.lb_name.TabIndex = 10;
            this.lb_name.Text = "Prénom  :";
            // 
            // lb_login
            // 
            this.lb_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Georgia", 9F);
            this.lb_login.Location = new System.Drawing.Point(187, 15);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(46, 15);
            this.lb_login.TabIndex = 9;
            this.lb_login.Text = "Login :";
            // 
            // bt_submit
            // 
            this.bt_submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_submit.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_submit.Font = new System.Drawing.Font("Georgia", 12F);
            this.bt_submit.ForeColor = System.Drawing.Color.Red;
            this.bt_submit.Location = new System.Drawing.Point(123, 219);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(174, 51);
            this.bt_submit.TabIndex = 8;
            this.bt_submit.Text = "Valider";
            this.bt_submit.UseVisualStyleBackColor = false;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10F);
            this.label3.Location = new System.Drawing.Point(182, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Email :";
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.LightGray;
            this.tb_email.Location = new System.Drawing.Point(115, 145);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(191, 20);
            this.tb_email.TabIndex = 17;
            // 
            // password_forget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 363);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.bt_submit);
            this.Name = "password_forget";
            this.Text = "Morpion : Mot de Passe oublié";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_email;
    }
}