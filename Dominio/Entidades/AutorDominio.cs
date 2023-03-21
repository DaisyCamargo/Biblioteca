using Dominio.Entidades;

namespace Dominio.Entidades
{
    public class AutorDominio
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }

        public AutorDominio(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public void AtualizarAutor(int id, string nome)
        {
            Id = id;
            Nome = nome;

            SetDataAtualizacao();
        }
    }
}
