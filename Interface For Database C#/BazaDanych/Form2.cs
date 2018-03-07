using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Text;


namespace BazaDanych
{

    

    public partial class Form2 : Form 
    {
        string connectionString;

        string path = @"C:\path.txt";


        SqlConnection connection;

        public Form2()
        {
            InitializeComponent();

            connectionString = File.ReadAllText(path);

            //connectionString = ConfigurationManager.ConnectionStrings["BazaDanych.Properties.Settings.serialeConnectionString"].ConnectionString;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Serial "+
                "VALUES ( @SerialTytul, @SerialLiczba_sezonow, @SerialCzas_trwania)";
           

            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ethril\Desktop\BazaDanych\BazaDanych\seriale.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection)) {


                
                command.Parameters.AddWithValue("@SerialTytul", tytulBox.Text);
                command.Parameters.AddWithValue("@SerialLiczba_sezonow",liczbasezonowBox.Text);
                command.Parameters.AddWithValue("@SerialCzas_trwania", czastrwaniaBox.Text);

                command.ExecuteNonQuery();
                }
                connection.Close();
              
            }

        }

       

        private void tytulBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
