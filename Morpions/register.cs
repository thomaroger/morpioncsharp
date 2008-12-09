using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Morpions
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            register.ActiveForm.Close();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            /* Flag de verification pour le formulaire */
            bool flag_champ = false;
            bool flag_password = false;
            bool flag_length_password = false;
            bool flag_email = false;

            /* Recuperation des données */
            string login = tb_login.Text;
            string password = tb_password.Text;
            string password2 = tb_password2.Text;
            string email = tb_email.Text;
            string name = tb_name.Text;
            string surname = tb_surname.Text;

			Regex EmailRegex = new Regex("^[a-z-A-Z0-9_.-]+@{1}[a-z-A-Z0-9_.-]{2,}\\.[a-z-A-Z0-9_.-]{2,}$");
			//^[a-z-A-Z0-9_.-]      => au debut(le ^), les lettres et chiffres ainsi que _.- sont acceptés
			//+@{1}                 => juste 1 @
			//[a-z-A-Z0-9_.-]{2,}   => 2 caractères au moins (le {2,} )
			//\\.                   => un point
			//[a-z-A-Z0-9_.-]{2,}$  => 2 caractères au moins à la fin (le $)


            string msgbox = "";

            if (login=="" || password=="" || password2=="" || email=="" || name=="" || surname=="") {
                msgbox = "Champs obligatoires non renseignés. \n";
                flag_champ = true;
            }

            if (password != password2) {
                msgbox += "Les mots de passe ne concordent pas. \n";
                flag_password = true;
            }else{
                if (password.Length < 6) {
                    msgbox += "Les mots de passe doivent comporter 6 caractères au mimimun. \n";
                    flag_length_password = true;
                }
            }

			if(!EmailRegex.IsMatch(email))
			{
				msgbox += "Veuillez entrer une adresse mail valide. \n";
				flag_email = true;
			}

            if (flag_password == true || flag_champ == true || flag_length_password == true || flag_email == true)
            {
                MessageBox.Show(msgbox, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                User user = new User(login, password, email, name, surname, "192.168.0.1", 0, 0, 0, 0, 0, 0, 0);
                user.AddUser();
                MessageBox.Show("Enregistrement effectué", "Félicitation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                register.ActiveForm.Close();

            }

            

        }

    }
}
