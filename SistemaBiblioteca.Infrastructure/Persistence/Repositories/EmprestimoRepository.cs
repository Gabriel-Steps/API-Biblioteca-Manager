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
    public class EmprestimoRepository : IEmprestimoRepository
    {
        private readonly BibliotecaSistemaContext _context;
        public EmprestimoRepository(BibliotecaSistemaContext context) 
        {
            _context = context;
        }
        public async Task Add(Emprestimo emprestimo)
        {

            _context.Livros.Find(emprestimo.IdLivro).Disponivel = false;
            await _context.Emprestimos.AddAsync(emprestimo);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var emprestimo = _context.Emprestimos.FirstOrDefault(emp => emp.Id == id);
            if (emprestimo == null)
            {
                throw new Exception("Emprestimo não encontrado");
            }
            string mensagem = emprestimo.DataDeDevolucao < DateTime.Today ?
                $"O livro foi devolvido com {DateTime.Today.Subtract(emprestimo.DataDeDevolucao)} dias de atraso" :
                "O livro foi devolvido dentro do prazo";
            Console.WriteLine(mensagem);
            _context.Livros.FirstOrDefault(l => l.Id == emprestimo.IdLivro).Disponivel = true;
            _context.Emprestimos.Remove(emprestimo);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Emprestimo>> GetAllAsync()
        {
            return await _context.Emprestimos.ToListAsync();
        }
    }
}
