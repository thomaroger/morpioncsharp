namespace Morpions
{
    partial class score
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.MesScores1 = new Morpions.MesScores();
            this.bt_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.MesScores1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(927, 471);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_close.Font = new System.Drawing.Font("Georgia", 12F);
            this.bt_close.ForeColor = System.Drawing.Color.Red;
            this.bt_close.Location = new System.Drawing.Point(807, 477);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(108, 35);
            this.bt_close.TabIndex = 16;
            this.bt_close.Text = "Fermer";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 524);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "score";
            this.Text = "score";
            this.Load += new System.EventHandler(this.score_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button bt_close;
        private MesScores MesScores1;
    }
}