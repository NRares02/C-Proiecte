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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            PopuleazaGridAutori();
            PopuleazaGridEdituri();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  // Create an instance of Form2
            form2.Show();               // Show Form2
            this.Hide();                // Hide Form3
        }

        private void PopuleazaGridAutori()
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Biblioteca;";

            // Creează o conexiune la baza de date MySQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Execută o interogare SQL
                SqlCommand command = new SqlCommand("SELECT IDAutor,Autor FROM Autori ORDER BY IDAutor", connection);


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

        private void PopuleazaGridEdituri()
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Biblioteca;";

            // Creează o conexiune la baza de date MySQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Execută o interogare SQL
                SqlCommand command = new SqlCommand("SELECT IDEditura,Editura FROM Editura ORDER BY IDEditura", connection);


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

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Biblioteca;";

            // Creează o conexiune la baza de date MySQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Execută o interogare SQL
                SqlCommand command = new SqlCommand("SELECT IDAutor,Autor FROM Autori ORDER BY Autor", connection);


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
                SqlCommand command = new SqlCommand("SELECT IDEditura,Editura FROM Editura ORDER BY Editura", connection);


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
