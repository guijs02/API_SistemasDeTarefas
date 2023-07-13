using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemasDeTarefas.Model;
using SistemasDeTarefas.Repository.Interface;

namespace SistemasDeTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> GetAllUsuarios()
        {
            List<Usuario> usuarios = await _usuarioRepository.GetAllUsuarios();
            return Ok(usuarios);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetByIdUsuarios(int id)
        {
            Usuario usuario = await _usuarioRepository.GetUsuarioById(id);
            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> Adicionar([FromBody] Usuario usuario)
        {
            Usuario user = await _usuarioRepository.Adicionar(usuario);
            return Ok(user);
        }
        [HttpPut]
        public async Task<ActionResult<Usuario>> Atualizar([FromBody]Usuario usuario, int id)
        {
            Usuario user = await _usuarioRepository.Atualizar(usuario,id);
            return Ok(user);
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Usuario>> DeleteUser(int id)
        {
            bool apagado = await _usuarioRepository.RemoveUser(id);
            return Ok(apagado);
        }
    }
}
