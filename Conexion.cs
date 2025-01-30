using System.Data;
using System.Data.SqlClient;

public static class Conexion
{
    public string a = "Hola mundo";
    public static string CadenaConexion { get; set; } = @"Data Source=ARELY;Initial Catalog=VACACIONES;Integrated Security=True";

    public static SqlConnection OpenConnection()
    {
        SqlConnection connection = new SqlConnection(CadenaConexion);
        connection.Open();
        return connection;
    }

    public static void CloseConnection(SqlConnection connection)
    {
        if (connection != null && connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }
}