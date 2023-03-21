using System;
using System.ComponentModel;

namespace Dominio.Entidades
{
    public  abstract class EntidadeBase
    {
        [ Description("Data_Atualizacao")]
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;

        protected void SetDataAtualizacao()
            => DataAtualizacao = DateTime.Now;
    }
}
