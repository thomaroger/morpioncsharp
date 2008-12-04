using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//using pour l'email
using System.Net.Mail;
using System.Net;
using System.Data.Sql;
using System.Data.SqlClient;

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
                //Envoi de l'email
                // Creation du mail
                MailMessage msg = null;
                //Expediteur
                string from = "projet.morpions@gmail.com";
                //Recepteur
                string to = tb_email.Text;
                // Sujet
                string sujet = "Recuperation de votre mot de passe";            

                // Chaîne de connexion
                string connectString = "database=Morpions;server=localhost;Integrated Security=true";
                // Objet connection
                SqlConnection connection = new SqlConnection(connectString);
                // Ouverture
                connection.Open();
                // Objet Command
                SqlCommand command = new SqlCommand("SELECT USER_PASSWORD FROM [USER] WHERE USER_SURNAME = '" + tb_name.Text  + "' AND USER_LOGIN = '" + tb_login.Text + "'", connection);
                // Objet DataReader
                SqlDataReader reader = command.ExecuteReader();
                Object[] row = null;
                string pass = null;
                while (reader.Read())
                {
                    row = new Object[reader.FieldCount];
                    reader.GetValues(row);
                    pass = row.GetValue(0).ToString();
                }
                
                // Fermeture
                connection.Close();

                //Corps du mail
                string Body = "Votre mot de passe est :" + pass;

                msg = new MailMessage(from, to, sujet, Body);

                SmtpClient objSC = new SmtpClient("smtp.gmail.com", 587);

                objSC.Credentials = new NetworkCredential("projet.morpions@gmail.com", "lose007*");
                //objSC.Send(msg);
                objSC.SendAsync(msg, "Envoie en cours");

                msgbox = "Génération de votre mot de passe réussie. \n";
                msgbox += "Un email vous a été envoyé. \n";
                MessageBox.Show(msgbox, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //fermeture de la forme
                password_forget.ActiveForm.Close();
            }
        }

    }
}
