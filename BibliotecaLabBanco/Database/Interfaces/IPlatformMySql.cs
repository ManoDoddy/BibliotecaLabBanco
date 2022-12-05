using MySql.Data.MySqlClient;

namespace BibliotecaLabBanco.Database.Interfaces;

public interface IPlatformMySql
{
    MySqlConnection GetMySqlConnection();
}
