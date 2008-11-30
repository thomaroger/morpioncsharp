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
    public partial class un_joueur_menu : Form
    {
        public un_joueur_menu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            un_joueur_menu.ActiveForm.Close();
            un_joueur op = new un_joueur(1);
            op.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            un_joueur_menu.ActiveForm.Close();
            un_joueur op = new un_joueur(1);
            op.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            un_joueur_menu.ActiveForm.Close();
            un_joueur op = new un_joueur(1);
            op.Show();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            un_joueur_menu.ActiveForm.Close();
        }
    }
}
