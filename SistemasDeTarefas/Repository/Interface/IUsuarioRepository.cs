using SistemasDeTarefas.Model;

namespace SistemasDeTarefas.Repository.Interface
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> GetAllUsuarios();
        Task<Usuario> GetUsuarioById(int id);
        Task<Usuario> Adicionar(Usuario usuario);

        Task<Usuario> Atualizar(Usuario usuario, int id);
        Task<bool> RemoveUser(int id);

    }
}
