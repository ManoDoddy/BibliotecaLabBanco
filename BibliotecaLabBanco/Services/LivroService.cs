using BibliotecaLabBanco.Models;
using BibliotecaLabBanco.Repository.Interfaces;
using BibliotecaLabBanco.Services.Interfaces;

namespace BibliotecaLabBanco.Services;

public class LivroService : ILivroService
{
    private readonly ILivroRepository _livroRepository;

    public LivroService(ILivroRepository livroRepository)
    {
        _livroRepository = livroRepository;
    }

    public async Task<IEnumerable<Livro>> GetAllLivrosAsync()
    {
        return await _livroRepository.GetAllAsync();
    }
}
