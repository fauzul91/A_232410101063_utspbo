using Npgsql;
using OOP_UTS.App.Core;
using OOP_UTS.App.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_UTS.App.Context
{
    internal class InventarisContext : DatabaseWrapper
    {
        private static string table = "inventaris";

        public static DataTable All()
        {
            string query = @"
            SELECT
                inv.id_inventaris,
                inv.nama_inventaris,
	            inv.id_category,
                cat.nama_category,
                inv.jumlah,
                inv.harga
            FROM inventaris inv
            JOIN category cat ON inv.id_category = cat.id_category ";

            DataTable dataInventaris = queryExecutor(query);
            return dataInventaris;
        }

        public static DataTable getInventarisById(int id)
        {
            string query = @"
            SELECT
                inv.id_inventaris,
                inv.nama_inventaris,
	            inv.id_category,
                cat.nama_category,
                inv.jumlah,
                inv.harga
            FROM inventaris inv
            JOIN category cat ON inv.id_category = cat.id_category 
            WHERE inv.id_inventaris = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable dataInventaris = queryExecutor(query, parameters);
            return dataInventaris;
        }


        public static void AddInventaris(M_Inventaris inventarisBaru)
        {
            string query = $"INSERT INTO {table} (nama_inventaris, id_category, jumlah, harga) VALUES(@nama_inventaris, @id_category, @jumlah, @harga)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_inventaris", inventarisBaru.nama_inventaris),
                new NpgsqlParameter("@id_category", inventarisBaru.id_category),
                new NpgsqlParameter("@jumlah", inventarisBaru.jumlah),
                new NpgsqlParameter("@harga", inventarisBaru.harga),
            };

            commandExecutor(query, parameters);
        }

        public static void UpdateMahasiswa(M_Inventaris inventaris)
        {
            string query = $"UPDATE {table} SET nama_inventaris = @nama_inventaris, id_category = @id_category, jumlah = @jumlah, harga = @harga";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_inventaris", inventaris.nama_inventaris),
                new NpgsqlParameter("@id_category", inventaris.id_category),
                new NpgsqlParameter("@jumlah", inventaris.jumlah),
                new NpgsqlParameter("@harga", inventaris.harga),
            };

            commandExecutor(query, parameters);
        }

        public static void DeleteInventaris(int id_inventaris)
        {
            string query = $"DELETE FROM {table} WHERE id_inventaris = @id_inventaris";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_inventaris", id_inventaris)
            };

            commandExecutor(query, parameters);
        }
    }
}
