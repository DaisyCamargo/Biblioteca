using Dominio.Entidade;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infraestrutura.Repositório.Interface
{
    public interface IExemplarRepositorio
    {
        Task<ExemplarDominio> CriarExemplar(int id);
        Task<ExemplarDominio> GravarExemplar(TipoExemplarDominio exemplar);
        Task<bool> AtualizarExemplarDominio(int id, IExemplarDominio exemplarAtualizacao);
        Task<bool> DeletarExemplar(int id);
    }
}
