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
    public partial class password_forget : Form
    {
        public password_forget()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            password_forget.ActiveForm.Close();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            bool flag_champ = false;
            bool flag_email = false;

            string login = tb_login.Text;
            string email = tb_email.Text;
            string name = tb_name.Text;

            string msgbox ="";

            if (login == "" || email == "" || name == "" )
            {
                msgbox = "Champs obligatoires non renseignés. \n";
                flag_champ = true;
            }

            if (email.IndexOf("@") <= 0 || email.IndexOf(".") <= 0)
            {
                msgbox += "Veuillez entrer une adresse mail valide. \n";
                flag_email = true;
            }

            if (flag_champ == true || flag_email == true)
            {
                MessageBox.Show(msgbox, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                msgbox = "Génération de votre mot de passe réussie. \n";
                msgbox += "Un email vous a été envoyé. \n";
                MessageBox.Show(msgbox, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                password_forget.ActiveForm.Close();
            }
        }

    }
}
