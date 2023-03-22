using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidade
{
    public class EditoraDominio
    {
            #region Propriedades
            public int Id { get; set; }
            public string Nome { get; set; }
            #endregion

           public EditoraDominio(int id, string nome)
            {
                this.Id = id;
                this.Nome = nome;
            }

            public EditoraDominio GetById(int id) //método
            {
                return this;
            }
        }
    }
