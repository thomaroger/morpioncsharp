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
        int id;
        public un_joueur_menu()
        {
            InitializeComponent();
        }
        public un_joueur_menu(int id_joueur)
        {
            InitializeComponent();
            id = id_joueur;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            un_joueur_menu.ActiveForm.Close();
            un_joueur op = new un_joueur(1,id);
            op.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            un_joueur_menu.ActiveForm.Close();
            un_joueur op = new un_joueur(2,id);
            op.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            un_joueur_menu.ActiveForm.Close();
            un_joueur op = new un_joueur(3,id);
            op.Show();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            un_joueur_menu.ActiveForm.Close();
        }

        private void un_joueur_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
