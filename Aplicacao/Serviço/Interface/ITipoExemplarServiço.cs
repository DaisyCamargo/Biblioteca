namespace Aplicacao.Serviço.Interface
{
    public interface ITipoExemplarServiço
    {
        Task<IEnumerable<TipoExemplarModel>> BuscarTipo();
        Task<TipoExemplarModel> CriarTipo(TipoExemplarEnvioModel tipo);
        Task<TipoExemplarModel> AtualizarTipo(int idTipo, TipoExemplarEnvioModel tipo);
        Task<bool> RemoverTipoExemplar(int idTipo);
    }
}
