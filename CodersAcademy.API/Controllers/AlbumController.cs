using Microsoft.AspNetCore.Mvc;

namespace CodersAcademy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAlbuns()
        {
            return Ok( new { Message = "Primeira API Criada" });
        }
    }
}
