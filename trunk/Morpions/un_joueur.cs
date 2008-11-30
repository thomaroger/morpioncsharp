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
        int[,] tab = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        int niveau = 0;
        int joueur = 0;
        int joueur2 = 1;

        public un_joueur()
        {
        }

        public un_joueur(int lvl) {
            InitializeComponent();
            niveau = lvl;
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            un_joueur.ActiveForm.Close();
        }

        private void morpion_1_1_Click(object sender, EventArgs e)
        {
            morpion_1_1.Text = "X";  
            morpion_1_1.Update();
            tab[0,0] = 1;
     
        }

        private void morpion_1_2_Click(object sender, EventArgs e)
        {
            morpion_1_2.Text = "X";
            morpion_1_2.Update();
            tab[0, 1] = 1;


        }

        private void morpion_1_3_Click(object sender, EventArgs e)
        {
            morpion_1_3.Text = "X";
            morpion_1_3.Update();
            tab[0, 2] = 1;

        }

        private void morpion_2_1_Click(object sender, EventArgs e)
        {
            morpion_2_1.Text = "X";
            morpion_2_1.Update();
            tab[1, 0] = 1;
        }

        private void morpion_2_2_Click(object sender, EventArgs e)
        {
            morpion_2_2.Text = "X";
            morpion_2_2.Update();
            tab[1,1] = 1;

        }

        private void morpion_2_3_Click(object sender, EventArgs e)
        {
            morpion_2_3.Text = "X";
            morpion_2_3.Update();
            tab[1, 2] = 1;

        }

        private void morpion_3_1_Click(object sender, EventArgs e)
        {
            morpion_3_1.Text = "X";
            morpion_3_1.Update();
            tab[2, 0] = 1;

        }

        private void morpion_3_2_Click(object sender, EventArgs e)
        {
            morpion_3_2.Text = "X";
            morpion_3_2.Update();
            tab[2, 1] = 1;
        }

        private void morpion_3_3_Click(object sender, EventArgs e)
        {
            morpion_3_3.Text = "X";
            morpion_3_3.Update();
            tab[2, 2] = 1;
        }

    }
}
