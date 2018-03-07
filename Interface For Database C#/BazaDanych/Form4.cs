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
    public partial class Form4 : Form
    {
        string connectionString;

        string path = @"C:\path.txt";

        SqlConnection connection;


        public Form4()
        {
            InitializeComponent();

            connectionString = File.ReadAllText(path);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            PopulateTytul();
        }

        private void addStudio_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Studio " +
                "VALUES (@StudioNazwa)";


            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ethril\Desktop\BazaDanych\BazaDanych\seriale.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudioNazwa", textBox2.Text);


                    command.ExecuteNonQuery();
                }
                PopulateTytul();
                connection.Close();

            }
        }

        private void deleteStudio_Click(object sender, EventArgs e)
        {
            string query = @"DELETE FROM Serial WHERE Id =  @StudioId";


            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ethril\Desktop\BazaDanych\BazaDanych\seriale.mdf;Integrated Security=True;Connect Timeout=30"))
            {

                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudioId", nazwaStudioBox.SelectedValue);
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
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Studio", connection))
            {


                DataTable tytulTabela = new DataTable();
                adapter.Fill(tytulTabela);

                nazwaStudioBox.DisplayMember = "Nazwa";
                nazwaStudioBox.ValueMember = "Id";
                nazwaStudioBox.DataSource = tytulTabela;


            }


        }

        private void editGatunek_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE Studio SET Nazwa =  @StudiokNazwa WHERE Id = @StudioId";


            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ethril\Desktop\BazaDanych\BazaDanych\seriale.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {



                    command.Parameters.AddWithValue("@StudioNazwa", editStudio.Text);
                    command.Parameters.AddWithValue("@StudioId", nazwaStudioBox.SelectedValue);


                    command.ExecuteNonQuery();
                }
                connection.Close();

            }
        }

        private void nazwaStudioBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
