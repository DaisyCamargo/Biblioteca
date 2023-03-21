using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidade
{
    public class AutorDominio
    {
        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        #endregion

      
        //public AutorDominio() { } 

         public AutorDominio(int id, string nome) 
        {
            this.Id = id;
            this.Nome = nome;
        }
      
        public AutorDominio GetById(int id) //método
        {
            return this;
        }
    }
}
