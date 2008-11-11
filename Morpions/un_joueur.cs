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
    public partial class un_joueur : Form
    {
        public un_joueur()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            un_joueur.ActiveForm.Close();
        }

        private void morpion_1_1_Click(object sender, EventArgs e)
        {
            morpion_1_1.Text = "X";  
            morpion_1_1.Update();
        }
    }
}
