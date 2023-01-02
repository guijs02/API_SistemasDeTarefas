using Microsoft.EntityFrameworkCore;
using SistemasDeTarefas.Data;
using SistemasDeTarefas.Model;
using SistemasDeTarefas.Repository.Interface;

namespace SistemasDeTarefas.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SistemaDeTarefaDBContext _dbContext;
        public UsuarioRepository(SistemaDeTarefaDBContext sistemaDeTarefaDBContext)
        {
            _dbContext = sistemaDeTarefaDBContext;
        }
        public async Task<List<Usuario>> GetAllUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        public async Task<Usuario> GetUsuarioById(int id)
        {
            return await _dbContext.Usuarios.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Usuario> Adicionar(Usuario usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            _dbContext.SaveChanges();
            return usuario;
        }

        public async Task<Usuario> Atualizar(Usuario usuario, int id)
        {
            var obj = await GetUsuarioById(id);

            obj.Nome = usuario.Nome;
            obj.Email = usuario.Email;

            _dbContext.Usuarios.Update(obj);
            _dbContext.SaveChanges();

            return obj;
        }


        public async Task<bool> RemoveUser(int id)
        {
            Usuario usuario = await GetUsuarioById(id);

            if (usuario is null)
            {
                throw new Exception($"Usuário com o id {id} não foi encontrado ");
            }

            _dbContext.Remove(usuario);
            _dbContext.SaveChanges();

            return true;

        }
    }
}
