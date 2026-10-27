using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QuanLyHocSinh
{
    // Lớp truy cập dữ liệu dùng chung: mọi truy vấn đều đi qua SqlParameter.
    internal static class Db
    {
        private static string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["DBHocSinh"].ConnectionString; }
        }

        // SELECT -> DataTable
        public static DataTable Query(string sql, params SqlParameter[] parameters)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(sql, conn))
            using (var adapter = new SqlDataAdapter(cmd))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        // INSERT / UPDATE / DELETE -> số dòng bị ảnh hưởng
        public static int Execute(string sql, params SqlParameter[] parameters)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        // Truy vấn trả về một giá trị (COUNT, ...)
        public static object Scalar(string sql, params SqlParameter[] parameters)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }
    }
}
