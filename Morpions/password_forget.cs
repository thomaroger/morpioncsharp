using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

//using pour l'email
//using System.Net.Mail;
using System.Net;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.Mail; 

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

			Regex EmailRegex = new Regex("^[a-z-A-Z0-9_.-]+@{1}[a-z-A-Z0-9_.-]{2,}\\.[a-z-A-Z0-9_.-]{2,}$");

            string msgbox ="";

            if (login == "" || email == "" || name == "" )
            {
                msgbox = "Champs obligatoires non renseignés. \n";
                flag_champ = true;
            }

			if (!EmailRegex.IsMatch(email))
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
                string sujet = "Récuperation de votre mot de passe";            

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
                if(pass != null)
                {
                string Body = "Votre mot de passe est :" + pass;

                //msg = new MailMessage(from, to, sujet, Body); 
                msg = new MailMessage();
                msg.Body = Body;
                msg.From = from;
                msg.To = to;
                msg.Subject = sujet;

                //msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "projet.morpions@gmail.com");
                //msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "lose007*");
                SmtpMail.SmtpServer = "smtp.gmail.com";

                //SmtpClient objSC = new SmtpClient("smtp.gmail.com", 587);
                //objSC.Credentials = new NetworkCredential("projet.morpions@gmail.com", "lose007*");

                //Envoi du message
                //objSC.Send(msg);
                SmtpMail.Send(msg);

                msgbox = "Génération de votre mot de passe réussie. \n";
                msgbox += "Un email vous a été envoyé. \n";
                MessageBox.Show(msgbox, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Aucun compte trouve", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //fermeture de la forme
                password_forget.ActiveForm.Close();
            }
        }

        private void password_forget_Load(object sender, EventArgs e)
        {

        }

    }
}
