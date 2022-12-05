using BibliotecaLabBanco.Database.Interfaces;
using MySql.Data.MySqlClient;

namespace BibliotecaLabBanco.Database;

public class PlatformMySql : IPlatformMySql
{
    private readonly string _connectionString;

    public PlatformMySql(string connectionString)
    {
        _connectionString = connectionString;
    }

    public MySqlConnection GetMySqlConnection()
    {
        return new MySqlConnection(_connectionString);
    }
}
