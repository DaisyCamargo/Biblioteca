using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidade
{
    public class TipoExemplarDominio
    {
        public int Id { get; set; }
        public string Descricao { get; set; }


        public TipoExemplarDominio(int id, string descricao)
        {
            this.Id = id;
            this.Descricao = descricao;
        }

        public TipoExemplarDominio GetById(int id) //método
        {
            return this;
        }
    }
}
