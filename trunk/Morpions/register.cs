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
            bool flag_champ = false;
            bool flag_password = false;
            bool flag_length_password = false;
            string login = tb_login.Text;
            string password = tb_password.Text;
            string password2 = tb_password2.Text;
            string email = tb_email.Text;
            string name = tb_name.Text;
            string surname = tb_surname.Text;
            string msgbox = "";
            if (login=="" || password=="" || password2=="" || email=="" || name=="" || surname=="") {
                msgbox = "Champs obligatoires non renseignés \n";
                flag_champ = true;
            }

            if (password != password2) {
                msgbox += "Les mots de passe ne concordent pas";
                flag_password = true;
            }else{
                if (password.Length < 6) {
                    msgbox += "Les mots de passe doivent comporter 6 caractères au mimimun";
                    flag_length_password = true;
                }
            }

            if (flag_password == true || flag_champ == true || flag_length_password == true)
            {
                MessageBox.Show(msgbox, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                MessageBox.Show("Enregistrement effectué", "Félicitation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                register.ActiveForm.Close();
            }

        }

    }
}
