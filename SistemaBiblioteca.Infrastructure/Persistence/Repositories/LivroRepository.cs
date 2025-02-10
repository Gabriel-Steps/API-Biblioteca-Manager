using Azure.Core;
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
    public class LivroRepository : ILivroRepository
    {
        private readonly BibliotecaSistemaContext _context;
        public LivroRepository(BibliotecaSistemaContext context) 
        {
            _context = context;
        }

        public async Task AddAsync(Livro livro)
        {
            await _context.Livros.AddAsync(livro);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var livro = _context.Livros.SingleOrDefault(l => l.Id == id);
            if (livro == null)
            {
                throw new Exception("Livro não encontrado");
            }
            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Livro>> GetAll()
        {
            return await _context.Livros.ToListAsync();
        }

        public Livro GetById(int id)
        {
            return _context.Livros.Find(id);
            
        }
    }
}
