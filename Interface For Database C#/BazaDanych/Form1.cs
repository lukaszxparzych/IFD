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
    public partial class Form1 : Form
    {


        //string connectionString = @"C:\Users\Ethril\Desktop\BazaDanych\BazaDanych\seriale.mdf";
        string connectionString;

        string path = @"C:\path.txt";

     

        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();

            connectionString = File.ReadAllText(path);



            //connectionString = ConfigurationManager.ConnectionStrings["BazaDanych.Properties.Settings.serialeConnectionString"].ConnectionString;
        }

        private void gatunekBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            PopulateTytul();
            PopulateLiczbaSezonow();
            PopulateCzastrwania();
           
            PopulateGatunekCombo();
            PopulateStudioCombo();
            PopulateKrajCombo();

            PopulateGatunek();
            PopulateStudio();
            PopulateKraj();


        }


        private void PopulateTytul()
        {
            //using (connection = new SqlConnection(connectionString))
            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ connectionString + ";Integrated Security=True;Connect Timeout=30"))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Serial", connection))
            {


                DataTable tytulTabela = new DataTable();
                adapter.Fill(tytulTabela);

                tytulBox.DisplayMember = "Tytul";
                tytulBox.ValueMember = "Id";
                tytulBox.DataSource = tytulTabela;


            }


        }

        private void PopulateLiczbaSezonow()
        {
            //using (connection = new SqlConnection(connectionString))
            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + connectionString + ";Integrated Security=True;Connect Timeout=30"))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Serial", connection))
            {


                DataTable liczbasezonowTabela = new DataTable();
                adapter.Fill(liczbasezonowTabela);

                liczbasezonowBox.DisplayMember = "Liczba_sezonow";
                liczbasezonowBox.ValueMember = "Id";
                liczbasezonowBox.DataSource = liczbasezonowTabela;


            }


        }

        private void PopulateCzastrwania()
        {
            //using (connection = new SqlConnection(connectionString))
            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + connectionString + ";Integrated Security=True;Connect Timeout=30"))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Serial", connection))
            {


                DataTable czastrwaniaTabela = new DataTable();
                adapter.Fill(czastrwaniaTabela);

                czastrwaniaBox.DisplayMember = "Czas_trwania";
                czastrwaniaBox.ValueMember = "Id";
                czastrwaniaBox.DataSource = czastrwaniaTabela;


            }


        }


        private void PopulateGatunek()
        {

            string query = "SELECT Serial_Gatunek.Id, Gatunek.Nazwa, Serial.Tytul " +
                            "FROM((Serial_Gatunek " +
                            "INNER JOIN Gatunek ON Serial_Gatunek.GatunekId = Gatunek.Id) " +
                            "INNER JOIN Serial ON Serial_Gatunek.SerialId = Serial.Id) "+
                            "WHERE Serial_Gatunek.SerialId = @SerialId";



            //SELECT Orders.OrderID, Customers.CustomerName, Shippers.ShipperName
            //FROM((Orders
            //INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID)
            //INNER JOIN Shippers ON Orders.ShipperID = Shippers.ShipperID);


            //"WHERE b.GatunekId = @GatunekId";


            //using (connection = new SqlConnection(connectionString))
            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + connectionString + ";Integrated Security=True;Connect Timeout=30"))
            using (SqlCommand command = new SqlCommand(query,connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable gatunekTabela = new DataTable();

                command.Parameters.AddWithValue("@SerialId", tytulBox.SelectedValue);

              
                adapter.Fill(gatunekTabela);



                gatunekBox.DisplayMember = "Nazwa";
                gatunekBox.ValueMember = "Id";
                gatunekBox.DataSource = gatunekTabela;




            }

           
        }

        private void PopulateStudio()
        {
            /*
            string querry = "SELECT a.Nazwa FROM Studio a " +
                "INNER JOIN Serial_Studio b ON " +
                "a.Id = b.StudioId " +
                "WHERE b.StudioId = @StudioId";*/


            string query = "SELECT Serial_Studio.Id, Studio.Nazwa, Serial.Tytul " +
                            "FROM((Serial_Studio " +
                            "INNER JOIN Studio  ON Serial_Studio.StudioId = Studio.Id) " +
                            "INNER JOIN Serial ON Serial_Studio.SerialId = Serial.Id) " +
                            "WHERE Serial_Studio.SerialId = @SerialId";


            //using (connection = new SqlConnection(connectionString))
            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + connectionString + ";Integrated Security=True;Connect Timeout=30"))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {


                command.Parameters.AddWithValue("@SerialId", tytulBox.SelectedValue);

                DataTable studioTabela = new DataTable();
                adapter.Fill(studioTabela);

                studioBox.DisplayMember = "Nazwa";
                studioBox.ValueMember = "Id";
                studioBox.DataSource = studioTabela;


            }


        }

        private void PopulateGatunekCombo()
        {
            //using (connection = new SqlConnection(connectionString))
            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + connectionString + ";Integrated Security=True;Connect Timeout=30"))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Nazwa from Gatunek", connection))
            {
                connection.Open();


                DataSet gatunekTabela = new DataSet();
                adapter.Fill(gatunekTabela, "Gatunek");



                gatunekCombo.DisplayMember = "Nazwa";
                gatunekCombo.ValueMember = "Id";
                gatunekCombo.DataSource = gatunekTabela.Tables["Gatunek"];



            }


        }

        private void PopulateStudioCombo()
        {
            //using (connection = new SqlConnection(connectionString))
            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + connectionString + ";Integrated Security=True;Connect Timeout=30"))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Nazwa from Studio", connection))
            {
                connection.Open();


                DataSet studioTabela = new DataSet();
                adapter.Fill(studioTabela, "Studio");



                studioCombo.DisplayMember = "Nazwa";
                studioCombo.ValueMember = "Id";
                studioCombo.DataSource = studioTabela.Tables["Studio"];



            }


        }

        private void PopulateKrajCombo()
        {
            //using (connection = new SqlConnection(connectionString))
            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + connectionString + ";Integrated Security=True;Connect Timeout=30"))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Nazwa from Kraj", connection))
            {
                connection.Open();


                DataSet studioTabela = new DataSet();
                adapter.Fill(studioTabela, "Kraj");



                KrajCombo.DisplayMember = "Nazwa";
                KrajCombo.ValueMember = "Id";
                KrajCombo.DataSource = studioTabela.Tables["Kraj"];



            }


        }






        private void PopulateKraj()
        {
            string query = "SELECT Serial_Kraj.Id, Kraj.Nazwa, Serial.Tytul " +
                           "FROM((Serial_Kraj " +
                           "INNER JOIN Kraj  ON Serial_Kraj.KrajId = Kraj.Id) " +
                           "INNER JOIN Serial ON Serial_Kraj.SerialId = Serial.Id) " +
                           "WHERE Serial_Kraj.SerialId = @SerialId";


            //using (connection = new SqlConnection(connectionString))
            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + connectionString + ";Integrated Security=True;Connect Timeout=30"))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {


                command.Parameters.AddWithValue("@SerialId", tytulBox.SelectedValue);

                DataTable studioTabela = new DataTable();
                adapter.Fill(studioTabela);

                krajBox.DisplayMember = "Nazwa";
                krajBox.ValueMember = "Id";
                krajBox.DataSource = studioTabela;


            }


        }

        private void gatunekBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tytulBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateGatunek();
            PopulateStudio();
        }

        private void addSerialButton_Click(object sender, EventArgs e)
        {
           Form2 objForm2 = new Form2();
            objForm2.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            PopulateGatunek();
            PopulateTytul();
            PopulateLiczbaSezonow();
            PopulateCzastrwania();

            PopulateGatunekCombo();
            PopulateStudioCombo();
            PopulateKrajCombo();

            PopulateStudio();
            PopulateKraj();
            PopulateGatunek();




        }

        private void editSerialButton_Click(object sender, EventArgs e)
        {

            if (editTytulCheck.Checked && !editCzastrwaniaCheck.Checked && !editLiczbasezonowCheck.Checked)
            {

                string query = @"UPDATE Serial SET Tytul =  @SerialTytul WHERE Id = @SerialId";


                using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + connectionString + ";Integrated Security=True;Connect Timeout=30"))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {



                        command.Parameters.AddWithValue("@SerialTytul", editSerialBox.Text);
                        command.Parameters.AddWithValue("@SerialId", tytulBox.SelectedValue);


                        command.ExecuteNonQuery();
                    }
                    connection.Close();

                }
            }

            else if (!editTytulCheck.Checked && !editCzastrwaniaCheck.Checked && editLiczbasezonowCheck.Checked)
            {
                string query = @"UPDATE Serial SET Liczba_sezonow =  @SerialLiczba_sezonow WHERE Id = @SerialId";


                using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + connectionString + ";Integrated Security=True;Connect Timeout=30"))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {



                        command.Parameters.AddWithValue("@SerialLiczba_sezonow", editSerialBox.Text);
                        command.Parameters.AddWithValue("@SerialId", liczbasezonowBox.SelectedValue);


                        command.ExecuteNonQuery();
                    }
                    connection.Close();

                }

            }
            else if (!editTytulCheck.Checked && editCzastrwaniaCheck.Checked && !editLiczbasezonowCheck.Checked)
            {
                string query = @"UPDATE Serial SET Czas_trwania =  @SerialCzas_trwania WHERE Id = @SerialId";


                using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + connectionString + ";Integrated Security=True;Connect Timeout=30"))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@SerialCzas_trwania", editSerialBox.Text);
                        command.Parameters.AddWithValue("@SerialId", czastrwaniaBox.SelectedValue);


                        command.ExecuteNonQuery();
                    }
                    connection.Close();

                }

            }
            else
                MessageBox.Show("Wybierz jedno zadanie!");
        }

        private void deleteSerialButton_Click(object sender, EventArgs e)
        {
            string query = @"DELETE FROM Serial WHERE Id = @SerialId";


            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + connectionString + ";Integrated Security=True;Connect Timeout=30"))
            {
               
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SerialId", tytulBox.SelectedValue);
                    command.ExecuteNonQuery();
                }
                connection.Close();

            }

        }

        private void gatunekAddButton_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Serial_Gatunek " +
                "VALUES (@GatunekId, @SerialId)";


            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + connectionString + ";Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                   


                    command.Parameters.AddWithValue("@GatunekId", gatunekCombo.SelectedValue);
                    command.Parameters.AddWithValue("@SerialId", tytulBox.SelectedValue);

                    command.ExecuteNonQuery();
                }
                connection.Close();

            }
        }

        private void gatunekDeleteButton_Click(object sender, EventArgs e)
        {
            string query = @"DELETE FROM Serial_Gatunek WHERE SerialId = @SerialId AND GatunekId = @GatunekId";


            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + connectionString + ";Integrated Security=True;Connect Timeout=30"))
            {

                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GatunekId", gatunekBox.SelectedValue);
                    command.Parameters.AddWithValue("@SerialId", tytulBox.SelectedValue);
                    command.ExecuteNonQuery();
                }
                connection.Close();

            }
        }

        private void addStudioButton_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Serial_Studio " +
                "VALUES (@SerialId,@StudioId)";


            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + connectionString + ";Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SerialId", tytulBox.SelectedValue);
                    command.Parameters.AddWithValue("@StudioId", studioCombo.SelectedValue);
                    


                    command.ExecuteNonQuery();
                }
                connection.Close();

            }
        }

        private void gatunekCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectStudioLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 objForm3 = new Form3();
            objForm3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 objForm4 = new Form4();
            objForm4.Show();
        }

        private void gatunekBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addButtonCountry_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Serial_Kraj " +
                "VALUES (@KrajId, @SerialId)";


            using (connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + connectionString + ";Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@KrajId", KrajCombo.SelectedValue);
                    command.Parameters.AddWithValue("@SerialId", tytulBox.SelectedValue);


                    command.ExecuteNonQuery();
                }
                connection.Close();

            }
        }

        private void addCountryButton_Click(object sender, EventArgs e)
        {
            Form5 objForm5 = new Form5();
            objForm5.Show();
        }

        private void krajBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
