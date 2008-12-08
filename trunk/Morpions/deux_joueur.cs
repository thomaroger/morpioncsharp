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
    public partial class deux_joueur : Form
    {
        int[,] tab = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        int nbX = 0;
        int nbO = 0;
        int id;


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

        public deux_joueur(int id_joueur)
        {
            InitializeComponent();
             id = id_joueur;
        }
        private void bt_close_Click(object sender, EventArgs e)
        {
            deux_joueur.ActiveForm.Close();
            menu op = new menu();
            op.Show();
        }

        private void case_Click(object sender, EventArgs e)
        {
            Button bouton = (System.Windows.Forms.Button)sender;
            int num1 = int.Parse(bouton.Name.Substring(8,1));
            int num2 = int.Parse(bouton.Name.Substring(10,1));

            if (tab[num1-1, num2-1] == 0)
            {
                if (nbX <= nbO)
                {
                    bouton.Text = "X";
                    nbX += 1;
                    tab[num1 - 1, num2 - 1] = 1;
                }
                else if (nbX > nbO)
                {
                    bouton.Text = "O";
                    nbO += 1;
                    tab[num1 - 1, num2 - 1] = 2;
                }
                bouton.Update();
                routine_victoire(tab);
            }
        }

        private void deux_joueur_Load(object sender, EventArgs e)
        {

        }
    }
}
