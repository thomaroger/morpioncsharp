namespace Morpions
{
    partial class menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_close.Font = new System.Drawing.Font("Georgia", 12F);
            this.bt_close.ForeColor = System.Drawing.Color.Red;
            this.bt_close.Location = new System.Drawing.Point(91, 221);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(108, 35);
            this.bt_close.TabIndex = 15;
            this.bt_close.Text = "Fermer";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10F);
            this.label1.Location = new System.Drawing.Point(111, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "1 Joueur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10F);
            this.label2.Location = new System.Drawing.Point(108, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "2 Joueurs";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10F);
            this.label4.Location = new System.Drawing.Point(93, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Top 5 Joueurs";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Font = new System.Drawing.Font("Georgia", 10F);
            this.lblScores.Location = new System.Drawing.Point(107, 173);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(72, 17);
            this.lblScores.TabIndex = 20;
            this.lblScores.Text = "Les scores";
            this.lblScores.Click += new System.EventHandler(this.lblScores_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_close;
            this.ClientSize = new System.Drawing.Size(292, 267);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_close);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblScores;
    }
}