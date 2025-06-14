using WebApi_estudo_Biblioteca.Dto.Vinculo;
using WebApi_estudo_Biblioteca.Models;

namespace WebApi_estudo_Biblioteca.Dto.Livro
{
    public class LivroEdicaoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
