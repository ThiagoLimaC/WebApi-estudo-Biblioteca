using WebApi_estudo_Biblioteca.Dto.Vinculo;
using WebApi_estudo_Biblioteca.Models;

namespace WebApi_estudo_Biblioteca.Dto.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
