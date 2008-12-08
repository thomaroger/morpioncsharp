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
   

    public partial class menu : Form
    {
        int id;
        public menu()
        {
            InitializeComponent();
        }
        public menu(int id_joueur)
        {
            InitializeComponent();
            id = id_joueur;
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            menu.ActiveForm.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            menu.ActiveForm.Close();
            un_joueur_menu op = new un_joueur_menu(id);
            op.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            menu.ActiveForm.Close();
            deux_joueur op = new deux_joueur(id);
            op.Show();
        }

        private void lblScores_Click(object sender, EventArgs e)
        {
            score op = new score(id);
            op.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            topTen op = new topTen(id);
            op.ShowDialog();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
