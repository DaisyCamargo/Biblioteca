using Domain.Entidade;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/exemplares")]
    public class ExemplarController : ControllerBase
    {
        [HttpGet("{id}")]
        public ExemplarDominio GetById([FromRoute] int id)
        {
            ExemplarDominio exemplar = new ExemplarDominio(id,1,2,3,"Once Upon Time", "Despertar");
            return exemplar.GetById(id);
        }
    }
}
