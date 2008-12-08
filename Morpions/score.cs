using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Morpions
{
    public partial class score : Form
    {
        int id;
        public score()
        {
            InitializeComponent();
        }

        public score(int id_joueur)
        {
            InitializeComponent();
             id = id_joueur;
        }


        private void bt_close_Click(object sender, EventArgs e)
        {
            score.ActiveForm.Close();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void score_Load(object sender, EventArgs e)
        {

        }
    }
}
