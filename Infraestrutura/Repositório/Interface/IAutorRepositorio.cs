using Dominio.Entidade;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infraestrutura.Repositório.Interface
{
    public interface IAutorRepositorio
    {
        Task<AutorDominio> CriarAutor(int id);
        Task<AutorDominio> GravarAutor(AutorDominio autor);
        Task<bool> AtualizarAutorDominio(int id, AutorDominio autorAtualizacao);
        Task<bool> DeletarAutor(int id);
    }
}
