using MediatR;
using Microsoft.EntityFrameworkCore;
using SistemaBiblioteca.Application.ViewModels;
using SistemaBiblioteca.Core.Repositories;
using SistemaBiblioteca.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.Queries.GetAllLivros
{
    public class GetAllLivrosHandler : IRequestHandler<GetAllLivroQuery, List<LivroViewModel>>
    {
        private readonly ILivroRepository _context;
        public GetAllLivrosHandler(ILivroRepository context) 
        { 
            _context = context;
        }
        public async Task<List<LivroViewModel>> Handle(GetAllLivroQuery request, CancellationToken cancellationToken)
        {
            var livros = await _context.GetAll();
            var livrosViewModel = livros
                .Select(l => new LivroViewModel(
                    l.Titulo,
                    l.Autor,
                    l.ISBN,
                    l.AnoDeLancamento))
                .ToList();
            return livrosViewModel;
        }
    }
}
