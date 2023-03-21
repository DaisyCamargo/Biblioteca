using Dominio.Entidade;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infraestrutura.Repositório.Interface
{
    public interface IEditoraRepositorio
    {
        Task<EditoraDominio> CriarEditora(int id);
        Task<EditoraDominio> GravarEditora(EditoraDominio Editora);
        Task<bool> AtualizarEditoraDominio(int id, IEditoraDominio EditoraAtualizacao);
        Task<bool> DeletarEditora(int id);
    }
}
