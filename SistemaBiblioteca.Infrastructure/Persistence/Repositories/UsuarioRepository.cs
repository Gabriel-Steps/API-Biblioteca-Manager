using Microsoft.EntityFrameworkCore;
using SistemaBiblioteca.Core.Entities;
using SistemaBiblioteca.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Infrastructure.Persistence.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly BibliotecaSistemaContext _context;
        public UsuarioRepository(BibliotecaSistemaContext context) 
        {
            _context = context;
        }

        public async Task CreateAsync(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Usuario>> GetAllAsync()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public Usuario GetById(int id)
        {
            return _context.Usuarios.Find(id);
        }
    }
}
