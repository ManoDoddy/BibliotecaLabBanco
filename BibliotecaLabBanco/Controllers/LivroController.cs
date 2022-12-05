using BibliotecaLabBanco.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaLabBanco.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class LivroController : ControllerBase
{
    private readonly ILivroService _livroService;

    public LivroController(ILivroService livroService)
    {
        _livroService = livroService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var response = await _livroService.GetAllLivrosAsync();

        return Ok(response.ToArray());
    }
}
