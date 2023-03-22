using Domain.Entidade;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
        [ApiController]
        [Route("api/editores")]
        public class EditoraController : ControllerBase
        {
            [HttpGet("{id}")]
            public EditoraDominio GetById([FromRoute] int id)
            {
                EditoraDominio editora = new EditoraDominio(id, "Planeta");
                return editora.GetById(id);
            }

        }
}
