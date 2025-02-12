using SistemaBiblioteca.Core.Repositories;
using SistemaBiblioteca.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.Validatios.Service
{
    public class LivroService : ILivroService
    {
        private readonly BibliotecaSistemaContext _context;

        public LivroService(BibliotecaSistemaContext context)
        {
            _context = context;
        }

        public bool LivroDisponivel(int idLivro)
        {
            var livro = _context.Livros.Find(idLivro);
            if(livro.Disponivel != true)
            {
                return false;
            }
            return true;
        }

        public bool LivroExiste(int idLivro)
        {
            return _context.Livros.Any(l => l.Id == idLivro);
        }
    }
}
