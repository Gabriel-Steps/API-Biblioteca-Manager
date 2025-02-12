using SistemaBiblioteca.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Core.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario GetById(int id);
        Task CreateAsync(Usuario usuario);

        Task<List<Usuario>> GetAllAsync();
    }
}
