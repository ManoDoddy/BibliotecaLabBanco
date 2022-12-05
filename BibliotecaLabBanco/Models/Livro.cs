namespace BibliotecaLabBanco.Models;

public class Livro
{
    public string Isbn { get; set; }
    public string Titulo { get; set; }
    public int GeneroId { get; set; }
    public int EditoraId { get; set; }
    public int AutorId { get; set; }
}
