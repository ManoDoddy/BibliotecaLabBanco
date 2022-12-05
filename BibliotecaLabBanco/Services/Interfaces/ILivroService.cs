using BibliotecaLabBanco.Models;

namespace BibliotecaLabBanco.Services.Interfaces;

public interface ILivroService
{
    Task<IEnumerable<Livro>> GetAllLivrosAsync();
}
