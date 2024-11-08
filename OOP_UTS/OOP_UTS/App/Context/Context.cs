//using Npgsql;
//using OOP_UTS.App.Core;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP_UTS.App.Context
//{
//    internal class Context : DatabaseWrapper
//    {
//        private static string table = "mahasiswa";

//        public static DataTable All()
//        {
//            string query = @"
//        SELECT 
//            m.id,
//            m.nama,
//            m.nim,
//            m.email,
//            m.semester,
//            m.id_prodi,
//            p.nama_prodi  
//        FROM 
//            mahasiswa m
//        JOIN 
//            prodi p ON m.id_prodi = p.id";

//            DataTable dataMahasiswa = queryExecutor(query);
//            return dataMahasiswa;
//        }

//        public static DataTable getMahasiswaById(int id)
//        {
//            string query = @"
//                SELECT 
//                    m.id,
//                    m.nama,
//                    m.nim,
//                    m.email,
//                    m.semester,
//                    m.id_prodi,
//                    p.nama_prodi  
//                FROM 
//                    mahasiswa m
//                JOIN 
//                    prodi p ON m.id_prodi = p.id
//                WHERE 
//                    m.id = @id";

//            NpgsqlParameter[] parameters =
//            {
//                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
//            };

//            DataTable dataMahasiswa = queryExecutor(query, parameters);
//            return dataMahasiswa;
//        }


//        public static void AddMahasiswa(M_Mahasiswa mahasiswaBaru)
//        {
//            string query = $"INSERT INTO {table} (nama, nim, email, semester, id_prodi) VALUES(@nama, @nim, @email, @semester, @id_prodi)";

//            NpgsqlParameter[] parameters =
//            {
//                new NpgsqlParameter("@nama", mahasiswaBaru.nama),
//                new NpgsqlParameter("@nim", mahasiswaBaru.nim),
//                new NpgsqlParameter("@email", mahasiswaBaru.email),
//                new NpgsqlParameter("@semester", mahasiswaBaru.semester),
//                new NpgsqlParameter("@id_prodi", mahasiswaBaru.id_prodi)
//            };

//            commandExecutor(query, parameters);
//        }   

//        public static void UpdateMahasiswa(M_Mahasiswa mahasiswa)
//        {
//            string query = $"UPDATE {table} SET nama = @nama, nim = @nim, email = @email, semester = @semester, id_prodi = @id_prodi WHERE id = @id";

//            NpgsqlParameter[] parameters =
//            {
//                new NpgsqlParameter("@nama", mahasiswa.nama),
//                new NpgsqlParameter("@nim", mahasiswa.nim),
//                new NpgsqlParameter("@email", mahasiswa.email),
//                new NpgsqlParameter("@semester", mahasiswa.semester),
//                new NpgsqlParameter("@id_prodi", mahasiswa.id_prodi),
//                new NpgsqlParameter("@id", mahasiswa.id)
//            };

//            commandExecutor(query, parameters);
//        }

//        public static void DeleteMahasiswa(int id)
//        {
//            string query = $"DELETE FROM {table} WHERE id = @id";

//            NpgsqlParameter[] parameters =
//            {
//                new NpgsqlParameter("@id", id)
//            };

//            commandExecutor(query, parameters);
//        }
//    }
//}

