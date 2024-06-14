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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopuleazaGridCarti();
            PopuleazaGridClienti();
        }

        private void PopuleazaGridCarti()
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Biblioteca;";

            // Creează o conexiune la baza de date MySQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Execută o interogare SQL
                SqlCommand command = new SqlCommand("SELECT Titlu,Carti.[An publicatie],Pret,ISBN,Editura.Editura FROM Carti INNER JOIN Editura ON Carti.IDEditura = Editura.IDEditura ORDER BY Titlu", connection);
                

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

        private void PopuleazaGridClienti()
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Biblioteca;";

            // Creează o conexiune la baza de date MySQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Execută o interogare SQL
                SqlCommand command = new SqlCommand("SELECT Nume,Clienti.[Nr.telefon],Email,Clienti.[Data.nasterii],Pin FROM Clienti ORDER BY Nume", connection);
                

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
                SqlCommand command = new SqlCommand("SELECT Titlu,Carti.[An publicatie],Pret,ISBN,Editura.Editura FROM Carti INNER JOIN Editura ON Carti.IDEditura = Editura.IDEditura ORDER BY Editura", connection);


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

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Biblioteca;";
            // Creează o conexiune la baza de date MySQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Execută o interogare SQL
                SqlCommand command = new SqlCommand("SELECT Titlu,Carti.[An publicatie],Pret,ISBN,Editura.Editura FROM Carti INNER JOIN Editura ON Carti.IDEditura = Editura.IDEditura ORDER BY Titlu", connection);


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
            Form2 form2 = new Form2();  // Create an instance of Form2
            form2.Show();               // Show Form2
            this.Hide();                // Hide Form1
        }
    }

    //Structurare baza de date pentru FitFusionGYM
    //Aici de adaugat mai multe griduri de vizualizat(Far informatii inutile pentru utilizatrori)+forms
}
