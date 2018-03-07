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
    public partial class Form5 : Form
    {
        string connectionString;

        string path = @"C:\path.txt";

        SqlConnection connection;

        public Form5()
        {
            InitializeComponent();

            connectionString = File.ReadAllText(path);
        }

        private void addGatunek_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Kraj " +
                "VALUES ( @KrajNazwa)";


            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ethril\Desktop\BazaDanych\BazaDanych\seriale.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudiokNazwa", addKraj.Text);


                    command.ExecuteNonQuery();
                }
                PopulateTytul();
                connection.Close();

            }
        }

        private void deleteKraj_Click(object sender, EventArgs e)
        {
            string query = @"DELETE FROM Gatunek WHERE Id =  @KrajId";


            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ethril\Desktop\BazaDanych\BazaDanych\seriale.mdf;Integrated Security=True;Connect Timeout=30"))
            {

                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@KrajId", nazwaKrajBox.SelectedValue);
                    command.ExecuteNonQuery();
                }
                PopulateTytul();
                connection.Close();

            }
        }


        private void PopulateTytul()
        {
            //using (connection = new SqlConnection(connectionString))
            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ethril\Desktop\BazaDanych\BazaDanych\seriale.mdf;Integrated Security=True;Connect Timeout=30"))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Kraj", connection))
            {


                DataTable tytulTabela = new DataTable();
                adapter.Fill(tytulTabela);

                nazwaKrajBox.DisplayMember = "Nazwa";
                nazwaKrajBox.ValueMember = "Id";
                nazwaKrajBox.DataSource = tytulTabela;


            }


        }

        private void editKraj_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE Kraj SET Nazwa =  @KrajNazwa WHERE Id = @KrajId";


            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ethril\Desktop\BazaDanych\BazaDanych\seriale.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {



                    command.Parameters.AddWithValue("@StudioNazwa", editKraj.Text);
                    command.Parameters.AddWithValue("@StudioId", nazwaKrajBox.SelectedValue);


                    command.ExecuteNonQuery();
                }
                connection.Close();

            }
        }
    }
}
