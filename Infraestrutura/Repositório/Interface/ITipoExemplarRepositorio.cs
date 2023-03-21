using Dominio.Entidade;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infraestrutura.Repositório.Interface
{
    public interface ITipoExemplarRepositorio
    {
        Task<TipoExemplarDominio> CriarTipo(int id);
        Task<TipoExemplarDominio> GravarTipo(TipoExemplarDominio tipo);
        Task<bool> AtualizarTipoExemplarDominio(int id, ITipoExemplarDominio tipoAtualizacao);
        Task<bool> DeletarTipo(int id);
    }
}
