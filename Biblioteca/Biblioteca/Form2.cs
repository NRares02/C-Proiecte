using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            PopuleazaGridFacturi();
            PopuleazaGridComenzi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  // Create an instance of Form1
            form1.Show();               // Show Form1
            this.Hide();                // Hide Form2
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();  // Create an instance of Form3
            form3.Show();               // Show Form3
            this.Hide();                // Hide Form2
        }

        private void PopuleazaGridFacturi()
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Biblioteca;";

            // Creează o conexiune la baza de date MySQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Execută o interogare SQL
                SqlCommand command = new SqlCommand("SELECT IDFactura,IDClient,Data,NrFactura FROM Facturi ORDER BY IDFactura", connection);


                // Setează parametrii pentru interogare


                SqlDataReader dataReader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridView1.DataSource = dataTable;
                dataReader.Close();

                // Închide conexiunea
                connection.Close();

            }

        }

        private void PopuleazaGridComenzi()
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Biblioteca;";

            // Creează o conexiune la baza de date MySQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Execută o interogare SQL
                SqlCommand command = new SqlCommand("SELECT IDComanda,IDFactura,IDCarte FROM Comenzi ORDER BY IDComanda", connection);


                // Setează parametrii pentru interogare


                SqlDataReader dataReader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridView1.DataSource = dataTable;
                dataReader.Close();

                // Închide conexiunea
                connection.Close();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Biblioteca;";

            // Creează o conexiune la baza de date MySQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Execută o interogare SQL
                SqlCommand command = new SqlCommand("SELECT IDFactura,IDClient,Data,NrFactura FROM Facturi ORDER BY Data", connection);


                // Setează parametrii pentru interogare


                SqlDataReader dataReader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridView1.DataSource = dataTable;
                dataReader.Close();

                // Închide conexiunea
                connection.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Biblioteca;";

            // Creează o conexiune la baza de date MySQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Execută o interogare SQL
                SqlCommand command = new SqlCommand("SELECT IDComanda,IDFactura,IDCarte FROM Comenzi ORDER BY IDComanda", connection);


                // Setează parametrii pentru interogare


                SqlDataReader dataReader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridView2.DataSource = dataTable;
                dataReader.Close();

                // Închide conexiunea
                connection.Close();

            }
        }
    }
}
