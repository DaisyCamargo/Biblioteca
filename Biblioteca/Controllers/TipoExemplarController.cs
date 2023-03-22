using Domain.Entidade;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/tipos_exemplar")]

    public class TipoExemplarController : ControllerBase
    {
        [HttpGet("{id}")]
        public TipoExemplarDominio GetById([FromRoute] int id)
        {
            TipoExemplarDominio tipoExemplar = new TipoExemplarDominio(id, "Aventura");
            return tipoExemplar.GetById(id);
        }
    }
}
