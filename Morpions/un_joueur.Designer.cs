namespace Morpions
{
    partial class un_joueur
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
            this.Morpion = new System.Windows.Forms.TableLayoutPanel();
            this.bt_close = new System.Windows.Forms.Button();
            this.morpion_1_1 = new System.Windows.Forms.Button();
            this.morpion_1_2 = new System.Windows.Forms.Button();
            this.morpion_1_3 = new System.Windows.Forms.Button();
            this.morpion_2_1 = new System.Windows.Forms.Button();
            this.morpion_2_2 = new System.Windows.Forms.Button();
            this.morpion_2_3 = new System.Windows.Forms.Button();
            this.morpion_3_1 = new System.Windows.Forms.Button();
            this.morpion_3_2 = new System.Windows.Forms.Button();
            this.morpion_3_3 = new System.Windows.Forms.Button();
            this.Morpion.SuspendLayout();
            this.SuspendLayout();
            // 
            // Morpion
            // 
            this.Morpion.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Morpion.ColumnCount = 3;
            this.Morpion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.6F));
            this.Morpion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.4F));
            this.Morpion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.Morpion.Controls.Add(this.morpion_3_2, 1, 2);
            this.Morpion.Controls.Add(this.morpion_3_1, 0, 2);
            this.Morpion.Controls.Add(this.morpion_2_3, 2, 1);
            this.Morpion.Controls.Add(this.morpion_2_2, 1, 1);
            this.Morpion.Controls.Add(this.morpion_2_1, 0, 1);
            this.Morpion.Controls.Add(this.morpion_1_3, 2, 0);
            this.Morpion.Controls.Add(this.morpion_1_2, 1, 0);
            this.Morpion.Controls.Add(this.morpion_1_1, 0, 0);
            this.Morpion.Controls.Add(this.morpion_3_3, 2, 2);
            this.Morpion.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.Morpion.Location = new System.Drawing.Point(31, 25);
            this.Morpion.Name = "Morpion";
            this.Morpion.RowCount = 3;
            this.Morpion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.06867F));
            this.Morpion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.93133F));
            this.Morpion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.Morpion.Size = new System.Drawing.Size(378, 354);
            this.Morpion.TabIndex = 0;
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_close.Font = new System.Drawing.Font("Georgia", 12F);
            this.bt_close.ForeColor = System.Drawing.Color.Red;
            this.bt_close.Location = new System.Drawing.Point(177, 406);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(108, 35);
            this.bt_close.TabIndex = 16;
            this.bt_close.Text = "Fermer";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // morpion_1_1
            // 
            this.morpion_1_1.BackColor = System.Drawing.SystemColors.Control;
            this.morpion_1_1.ForeColor = System.Drawing.Color.White;
            this.morpion_1_1.Location = new System.Drawing.Point(4, 4);
            this.morpion_1_1.Name = "morpion_1_1";
            this.morpion_1_1.Size = new System.Drawing.Size(116, 105);
            this.morpion_1_1.TabIndex = 0;
            this.morpion_1_1.UseVisualStyleBackColor = false;
            this.morpion_1_1.Click += new System.EventHandler(this.morpion_1_1_Click);
            // 
            // morpion_1_2
            // 
            this.morpion_1_2.BackColor = System.Drawing.SystemColors.Control;
            this.morpion_1_2.ForeColor = System.Drawing.Color.White;
            this.morpion_1_2.Location = new System.Drawing.Point(127, 4);
            this.morpion_1_2.Name = "morpion_1_2";
            this.morpion_1_2.Size = new System.Drawing.Size(116, 105);
            this.morpion_1_2.TabIndex = 1;
            this.morpion_1_2.UseVisualStyleBackColor = false;
            // 
            // morpion_1_3
            // 
            this.morpion_1_3.BackColor = System.Drawing.SystemColors.Control;
            this.morpion_1_3.ForeColor = System.Drawing.Color.White;
            this.morpion_1_3.Location = new System.Drawing.Point(252, 4);
            this.morpion_1_3.Name = "morpion_1_3";
            this.morpion_1_3.Size = new System.Drawing.Size(116, 105);
            this.morpion_1_3.TabIndex = 2;
            this.morpion_1_3.UseVisualStyleBackColor = false;
            // 
            // morpion_2_1
            // 
            this.morpion_2_1.BackColor = System.Drawing.SystemColors.Control;
            this.morpion_2_1.ForeColor = System.Drawing.Color.White;
            this.morpion_2_1.Location = new System.Drawing.Point(4, 116);
            this.morpion_2_1.Name = "morpion_2_1";
            this.morpion_2_1.Size = new System.Drawing.Size(116, 114);
            this.morpion_2_1.TabIndex = 3;
            this.morpion_2_1.UseVisualStyleBackColor = false;
            // 
            // morpion_2_2
            // 
            this.morpion_2_2.BackColor = System.Drawing.SystemColors.Control;
            this.morpion_2_2.ForeColor = System.Drawing.Color.White;
            this.morpion_2_2.Location = new System.Drawing.Point(127, 116);
            this.morpion_2_2.Name = "morpion_2_2";
            this.morpion_2_2.Size = new System.Drawing.Size(116, 114);
            this.morpion_2_2.TabIndex = 4;
            this.morpion_2_2.UseVisualStyleBackColor = false;
            // 
            // morpion_2_3
            // 
            this.morpion_2_3.BackColor = System.Drawing.SystemColors.Control;
            this.morpion_2_3.ForeColor = System.Drawing.Color.White;
            this.morpion_2_3.Location = new System.Drawing.Point(252, 116);
            this.morpion_2_3.Name = "morpion_2_3";
            this.morpion_2_3.Size = new System.Drawing.Size(116, 114);
            this.morpion_2_3.TabIndex = 5;
            this.morpion_2_3.UseVisualStyleBackColor = false;
            // 
            // morpion_3_1
            // 
            this.morpion_3_1.BackColor = System.Drawing.SystemColors.Control;
            this.morpion_3_1.ForeColor = System.Drawing.Color.White;
            this.morpion_3_1.Location = new System.Drawing.Point(4, 237);
            this.morpion_3_1.Name = "morpion_3_1";
            this.morpion_3_1.Size = new System.Drawing.Size(116, 113);
            this.morpion_3_1.TabIndex = 6;
            this.morpion_3_1.UseVisualStyleBackColor = false;
            // 
            // morpion_3_2
            // 
            this.morpion_3_2.BackColor = System.Drawing.SystemColors.Control;
            this.morpion_3_2.ForeColor = System.Drawing.Color.White;
            this.morpion_3_2.Location = new System.Drawing.Point(127, 237);
            this.morpion_3_2.Name = "morpion_3_2";
            this.morpion_3_2.Size = new System.Drawing.Size(116, 113);
            this.morpion_3_2.TabIndex = 7;
            this.morpion_3_2.UseVisualStyleBackColor = false;
            // 
            // morpion_3_3
            // 
            this.morpion_3_3.BackColor = System.Drawing.SystemColors.Control;
            this.morpion_3_3.ForeColor = System.Drawing.Color.White;
            this.morpion_3_3.Location = new System.Drawing.Point(252, 237);
            this.morpion_3_3.Name = "morpion_3_3";
            this.morpion_3_3.Size = new System.Drawing.Size(116, 113);
            this.morpion_3_3.TabIndex = 8;
            this.morpion_3_3.UseVisualStyleBackColor = false;
            // 
            // un_joueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 453);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.Morpion);
            this.Name = "un_joueur";
            this.Text = "un_joueur";
            this.Morpion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Morpion;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button morpion_1_1;
        private System.Windows.Forms.Button morpion_3_2;
        private System.Windows.Forms.Button morpion_3_1;
        private System.Windows.Forms.Button morpion_2_3;
        private System.Windows.Forms.Button morpion_2_2;
        private System.Windows.Forms.Button morpion_2_1;
        private System.Windows.Forms.Button morpion_1_3;
        private System.Windows.Forms.Button morpion_1_2;
        private System.Windows.Forms.Button morpion_3_3;

    }
}