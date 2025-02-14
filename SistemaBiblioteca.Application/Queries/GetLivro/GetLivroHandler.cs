using MediatR;
using Microsoft.EntityFrameworkCore;
using SistemaBiblioteca.Application.ViewModels;
using SistemaBiblioteca.Core.Entities;
using SistemaBiblioteca.Core.Repositories;
using SistemaBiblioteca.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.Queries.GetLivro
{
    public class GetLivroHandler : IRequestHandler<GetLivroQuery, LivroDetailsViewModel>
    {
        private readonly ILivroRepository _context;
        public GetLivroHandler(ILivroRepository context) 
        {
            _context = context;
        }
        public async Task<LivroDetailsViewModel> Handle(GetLivroQuery request, CancellationToken cancellationToken)
        {
            var livro = _context.GetById(request.Id);
            if (livro == null)
            {
                throw new Exception("Livro não encontrado");
            }
            var livroInfo = new LivroDetailsViewModel(
                livro.Id,
                livro.Titulo,
                livro.Autor,
                livro.ISBN,
                livro.AnoDeLancamento,
		livro.Disponivel);
            return livroInfo;
        }
    }
}
