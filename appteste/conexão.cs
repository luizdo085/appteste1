using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace appteste
{
    public class conexão
    {
        private string connectionString;
        private MySqlConnection connection;

        public conexão()
        {
            // Inicializa a string de conexão e a conexão no construtor
            connectionString = "Server=sql10.freemysqlhosting.net;Database=sql10664524;User ID=sql10664524;Password=XtLMMxAUU6;Port=3306;SSL Mode=Preferred;";
            connection = new MySqlConnection(connectionString);
        }
        public void AbrirConexao()
        {
            try
            {
                    connection.Open();
                    Console.WriteLine("Conexão aberta com sucesso!");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Erro ao abrir a conexão: {ex.Message}");
            }
        }
        public void FecharConexao()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Conexão fechada com sucesso!");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Erro ao abrir a conexão: {ex.Message}");
            }
        }
    }
}