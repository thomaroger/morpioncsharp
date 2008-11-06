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
            this.SuspendLayout();
            // 
            // lb_register
            // 
            this.lb_register.AutoSize = true;
            this.lb_register.Location = new System.Drawing.Point(187, 24);
            this.lb_register.Name = "lb_register";
            this.lb_register.Size = new System.Drawing.Size(55, 13);
            this.lb_register.TabIndex = 0;
            this.lb_register.Text = "Inscription";
            this.lb_register.Click += new System.EventHandler(this.lb_register_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 492);
            this.Controls.Add(this.lb_register);
            this.Name = "register";
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_register;
    }
}