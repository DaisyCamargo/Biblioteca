using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidade
{
    public class ExemplarDominio
    {
        #region Propriedades
        public int Id { get; set; }
        public int IdTipoExemplar { get; set; }
        public int IdAutor { get; set; }
        public int IdEditora { get; set; }
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        #endregion


        public ExemplarDominio(int id, int id_tipo_exemplar, int id_autor, int id_editora, string titulo, string subtitulo)
        {
            this.Id = id;
            this.IdTipoExemplar = id_tipo_exemplar;
            this.IdAutor = id_autor;
            this.IdEditora = id_editora;
            this.Titulo = titulo;
            this.SubTitulo = subtitulo;
        }

        public ExemplarDominio GetById(int id) //método
        {
            return this;
        }
    }
}
