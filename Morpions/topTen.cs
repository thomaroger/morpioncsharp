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
            SqlCommand command = new SqlCommand("SELECT [USER].USER_ID,[USER].USER_NAME,MAX([SCORE_HISTORIQUE].HISTO_WIN_PLAYER) FROM [USER],[SCORE_HISTORIQUE] WHERE [SCORE_HISTORIQUE].USER_ID= [USER].USER_ID ", connection);
            // Objet DataReader
            SqlDataReader reader = command.ExecuteReader();
            Object[] row = null;

            while (reader.Read())
            {
                row = new Object[reader.FieldCount];
                reader.GetValues(row);
                textBox1.Text = row.GetValue(2).ToString(); 
               


            }
            // Fermeture
            connection.Close();
                
        }
    }
}
