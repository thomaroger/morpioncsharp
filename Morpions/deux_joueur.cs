﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Morpions
{
    public partial class deux_joueur : Form
    {
        int[,] tab = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        int joueur = 0;
        int joueur2 = 1;
        int nbX = 0;
        int nbO = 0;


        public bool routine_victoire(int[,] tab)
        {
            bool victory = false;
            int win = 0;

            for (int i = 0; i < 3; i++)
            {
                if (tab[i, 0] == tab[i, 1] && tab[i, 0] == tab[i, 2] && tab[i, 0] != 0)
                {
                    victory = true;
                    win = tab[i, 0];
                }
                if (tab[0, i] == tab[1, i] && tab[0, i] == tab[2, i] && tab[0, i] != 0)
                {
                    victory = true;
                    win = tab[0, i];
                }
            }

            if (tab[0, 0] == tab[1, 1] && tab[0, 0] == tab[2, 2] && tab[0, 0] != 0)
            {
                victory = true;
                win = tab[0, 0];
            }

            if (tab[0, 2] == tab[1, 1] && tab[0, 2] == tab[2, 0] && tab[0, 2] != 0)
            {
                victory = true;
                win = tab[0, 2];
            }


            if (victory)
            {
                morpion_1_1.Enabled = false;
                morpion_1_2.Enabled = false;
                morpion_1_3.Enabled = false;
                morpion_2_1.Enabled = false;
                morpion_2_2.Enabled = false;
                morpion_2_3.Enabled = false;
                morpion_3_1.Enabled = false;
                morpion_3_2.Enabled = false;
                morpion_3_3.Enabled = false;

                if (win == 1)
                {
                    label_morpions.Text = "Victoire joueur 1";
                    return true;
                }
                else
                {
                    label_morpions.Text = "Victoire joueur 2";
                    return true;
                }

            }
            return false;
        }


        public deux_joueur()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            deux_joueur.ActiveForm.Close();
            menu op = new menu();
            op.Show();
        }

        private void morpion_1_1_Click(object sender, EventArgs e)
        {
            if (tab[0, 0] == 0)
            {
                if (nbX <= nbO)
                {
                    morpion_1_1.Text = "X";
                    nbX += 1;
                    tab[0, 0] = 1;
                }
                else if (nbX > nbO)
                {
                    morpion_1_1.Text = "O";
                    nbO += 1;
                    tab[0, 0] = 2;
                }
                morpion_1_1.Update();
                routine_victoire(tab);
            }
        }

        private void morpion_1_2_Click(object sender, EventArgs e)
        {
            if (tab[0, 1] == 0)
            {
                if (nbX <= nbO)
                {
                    morpion_1_2.Text = "X";
                    nbX += 1;
                    tab[0, 1] = 1;
                }
                else if (nbX > nbO)
                {
                    morpion_1_2.Text = "O";
                    nbO += 1;
                    tab[0, 1] = 2;
                }
                morpion_1_2.Update();
                
                routine_victoire(tab);
            }
        }

        private void morpion_1_3_Click(object sender, EventArgs e)
        {
            if (tab[0, 2] == 0)
            {
                if (nbX <= nbO)
                {
                    morpion_1_3.Text = "X";
                    nbX += 1;
                    tab[0, 2] = 1;
                }
                else if (nbX > nbO)
                {
                    morpion_1_3.Text = "O";
                    nbO += 1;
                    tab[0, 2] = 2;
                }
                morpion_1_3.Update();
                
                routine_victoire(tab);
            }
        }

        private void morpion_2_1_Click(object sender, EventArgs e)
        {
            if (tab[1, 0] == 0)
            {
                if (nbX <= nbO)
                {
                    morpion_2_1.Text = "X";
                    nbX += 1;
                    tab[1, 0] = 1;
                }
                else if (nbX > nbO)
                {
                    morpion_2_1.Text = "O";
                    nbO += 1;
                    tab[1, 0] = 2;
                }
                morpion_2_1.Update();
                
                routine_victoire(tab);
            }
        }

        private void morpion_2_2_Click(object sender, EventArgs e)
        {
            if (tab[1, 1] == 0)
            {
                if (nbX <= nbO)
                {
                    morpion_2_2.Text = "X";
                    nbX += 1;
                    tab[1, 1] = 1;
                }
                else if (nbX > nbO)
                {
                    morpion_2_2.Text = "O";
                    nbO += 1;
                    tab[1, 1] = 2;
                }
                morpion_2_2.Update();
                
                routine_victoire(tab);
            }
        }

        private void morpion_2_3_Click(object sender, EventArgs e)
        {
            if (tab[1, 2] == 0)
            {
                if (nbX <= nbO)
                {
                    morpion_2_3.Text = "X";
                    nbX += 1;
                    tab[1, 2] = 1;
                }
                else if (nbX > nbO)
                {
                    morpion_2_3.Text = "O";
                    nbO += 1;
                    tab[1, 2] = 2;
                }
                morpion_2_3.Update();
                
                routine_victoire(tab);
            }
        }

        private void morpion_3_1_Click(object sender, EventArgs e)
        {
            if (tab[2, 0] == 0)
            {
                if (nbX <= nbO)
                {
                    morpion_3_1.Text = "X";
                    nbX += 1;
                    tab[2, 0] = 1;
                }
                else if (nbX > nbO)
                {
                    morpion_3_1.Text = "O";
                    nbO += 1;
                    tab[2, 0] = 2;
                }
                morpion_3_1.Update();
                
                routine_victoire(tab);
            }
        }

        private void morpion_3_2_Click(object sender, EventArgs e)
        {
            if (tab[2, 1] == 0)
            {
                if (nbX <= nbO)
                {
                    morpion_3_2.Text = "X";
                    nbX += 1;
                    tab[2, 1] = 1;
                }
                else if (nbX > nbO)
                {
                    morpion_3_2.Text = "O";
                    nbO += 1;
                    tab[2, 1] = 2;
                }
                morpion_3_2.Update();
                
                routine_victoire(tab);
            }
        }

        private void morpion_3_3_Click(object sender, EventArgs e)
        {
            if (tab[2, 2] == 0)
            {
                if (nbX <= nbO)
                {
                    morpion_3_3.Text = "X";
                    nbX += 1;
                    tab[2, 2] = 1;
                }
                else if (nbX > nbO)
                {
                    morpion_3_3.Text = "O";
                    nbO += 1;
                    tab[2, 2] = 2;
                }
                morpion_3_3.Update();
                
                routine_victoire(tab);
            }
        }

    }
}