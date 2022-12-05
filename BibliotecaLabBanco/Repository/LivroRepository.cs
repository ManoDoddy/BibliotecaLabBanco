using BibliotecaLabBanco.Database;
using BibliotecaLabBanco.Database.Interfaces;
using BibliotecaLabBanco.Database.Sql.Livro;
using BibliotecaLabBanco.Models;
using BibliotecaLabBanco.Repository.Interfaces;
using Dapper;

namespace BibliotecaLabBanco.Repository;

public class LivroRepository : ILivroRepository
{
    private readonly IPlatformMySql _mySql;

    public LivroRepository(IPlatformMySql mySql)
    {
        _mySql = mySql;
    }

    public Task<Livro> CreateAsync(Livro entity)
    {
        throw new NotImplementedException();
    }

    public Task<Livro> DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Livro>> GetAllAsync()
    {
        using var conn = _mySql.GetMySqlConnection();

        var result = await conn.QueryAsync<Livro>(LivroSql.GetAllLivros);

        return result;
    }

    public Task<Livro> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<Livro> UpdateAsync(Livro entity)
    {
        throw new NotImplementedException();
    }
}
