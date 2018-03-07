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
    public partial class Form3 : Form
    {
        string connectionString;

        string path = @"C:\path.txt";

        SqlConnection connection;

        public Form3()
        {
            InitializeComponent();

            connectionString = File.ReadAllText(path);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            PopulateTytul();
        }

        private void addGatunek_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Gatunek " +
                "VALUES ( @GatunekNazwa)";


            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ethril\Desktop\BazaDanych\BazaDanych\seriale.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GatunekNazwa", textBox2.Text);
                    

                    command.ExecuteNonQuery();
                }
                PopulateTytul();
                connection.Close();

            }
        }

        private void deleteGatunek_Click(object sender, EventArgs e)
        {
            string query = @"DELETE FROM Gatunek WHERE Id =  @GatunekId";


            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ethril\Desktop\BazaDanych\BazaDanych\seriale.mdf;Integrated Security=True;Connect Timeout=30"))
            {

                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GatunekId", nazwaGatunekBox.SelectedValue);
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
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Gatunek", connection))
            {


                DataTable tytulTabela = new DataTable();
                adapter.Fill(tytulTabela);

                nazwaGatunekBox.DisplayMember = "Nazwa";
                nazwaGatunekBox.ValueMember = "Id";
                nazwaGatunekBox.DataSource = tytulTabela;


            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editGatunek_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE Gatunek SET Nazwa =  @GatunekNazwa WHERE Id = @GatunekId";


            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ethril\Desktop\BazaDanych\BazaDanych\seriale.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {



                    command.Parameters.AddWithValue("@GatunekNazwa", editGatunek.Text);
                    command.Parameters.AddWithValue("@GatunekId", nazwaGatunekBox.SelectedValue);


                    command.ExecuteNonQuery();
                }
                connection.Close();

            }
        }
    }
}
