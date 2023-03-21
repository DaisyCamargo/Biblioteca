using Domain.Entidade;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutorController : ControllerBase
    {
        [HttpGet("{id}")]
        public AutorDominio GetById([FromRoute] int id) 
        {
            AutorDominio autor = new AutorDominio(id,"Rodrigo");
            return autor.GetById(id);
        }
        
    }
}
