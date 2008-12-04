using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Morpions
{
    public partial class topTen : Form
    {
        public topTen()
        {
            InitializeComponent();
        }

        private void topTen_Load(object sender, EventArgs e)
        {
            // Chaîne de connexion
            string connectString = "Data Source=Localhost;Initial Catalog=Morpions;Integrated Security=true";
            // Objet connection
            SqlConnection connection = new SqlConnection(connectString);
            // Ouverture
            connection.Open();
            // Objet Command
            SqlCommand command = new SqlCommand("SELECT [USER].USER_ID,[USER].USER_NAME,[SCORE_HISTORIQUE].HISTO_WIN_PLAYER,[SCORE_HISTORIQUE].HISTO_LOSE_PLAYER FROM [USER],[SCORE_HISTORIQUE] WHERE [SCORE_HISTORIQUE].USER_ID= [USER].USER_ID ORDER BY [SCORE_HISTORIQUE].HISTO_WIN_PLAYER DESC,[SCORE_HISTORIQUE].HISTO_LOSE_PLAYER ASC", connection);
            // Objet DataReader
            SqlDataReader reader = command.ExecuteReader();
            Object[] row = null;
            int i = 1;
            while (reader.Read())
            {
                row = new Object[reader.FieldCount];
                reader.GetValues(row);

                switch (i)
                {
                    case 1:
                       lbNom1.Text = row.GetValue(1).ToString();
                       lblWin1.Text = row.GetValue(2).ToString();
                       lblLose1.Text = row.GetValue(3).ToString();
                     break;
                    case 2:
                       lbNom2.Text = row.GetValue(1).ToString();
                       lblWin2.Text = row.GetValue(2).ToString();
                       lblLose2.Text = row.GetValue(3).ToString();
                     break;
                    case 3:
                      lbNom3.Text = row.GetValue(1).ToString();
                      lblWin3.Text = row.GetValue(2).ToString();
                      lblLose3.Text = row.GetValue(3).ToString();
                     break;
                    case 4:
                      lbNom4.Text = row.GetValue(1).ToString();
                      lblWin4.Text = row.GetValue(2).ToString();
                      lblLose4.Text = row.GetValue(3).ToString();
                     break;
                    case 5:
                      lbNom5.Text = row.GetValue(1).ToString();
                      lblWin5.Text = row.GetValue(2).ToString();
                      lblLose5.Text = row.GetValue(3).ToString();
                     break;
                }

                i++;
               


            }
            // Fermeture
            connection.Close();
                
        }
    }
}
