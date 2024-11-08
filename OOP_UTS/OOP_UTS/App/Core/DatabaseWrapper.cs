using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace OOP_UTS.App.Core
{
    internal class DatabaseWrapper
    {
        private static readonly string DB_HOST = "localhost";
        private static readonly string DB_DATABASE = "InventoryManagement";
        private static readonly string DB_USERNAME = "postgres";
        private static readonly string DB_PASSWORD = "123";
        private static readonly string DB_PORT = "5432";

        private static NpgsqlConnection connection;
        private static NpgsqlCommand command;

        // Method open dan close Koneksi
        public static void openConnection()
        {
            connection = new NpgsqlConnection($"Host={DB_HOST};Username={DB_USERNAME};Password={DB_PASSWORD};Database={DB_DATABASE};Port={DB_PORT}");
            connection.Open();
            command = new NpgsqlCommand();
            command.Connection = connection;
        }

        public static void closeConnection()
        {
            connection.Close();
            command.Parameters.Clear();
        }

        public static DataTable queryExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                openConnection();
                DataTable dataTable = new DataTable();
                command.CommandText = query;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                    command.Prepare();
                }
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                closeConnection();
                return dataTable;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void commandExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                openConnection();
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                command.Prepare();
                command.Parameters.Clear();
                command.ExecuteNonQuery();
                closeConnection();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

//CREATE TABLE admin (
//	id_admin serial PRIMARY KEY NOT NULL UNIQUE,
//    email varchar(32) NOT NULL,
//    password varchar(32) NOT NULL
//)

//CREATE TABLE pengguna (
//	id_pengguna serial PRIMARY KEY NOT NULL UNIQUE,
//    email varchar(32) NOT NULL,
//    password varchar(32) NOT NULL
//)

//CREATE TABLE category (
//	id_category serial PRIMARY KEY NOT NULL,
//    nama_category varchar(32) NOT NULL
//)

//CREATE TABLE inventaris (
//	id_inventaris serial PRIMARY KEY NOT NULL UNIQUE,
//    nama_inventaris varchar(32) NOT NULL,
//    id_category int NOT NULL,
//    jumlah int NOT NULL,
//    harga int NOT NULL,
//    CONSTRAINT id_category FOREIGN KEY (id_category) REFERENCES category(id_category)
//)