using MediatR;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using SistemaBiblioteca.Core.Entities;
using SistemaBiblioteca.Core.Repositories;
using SistemaBiblioteca.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.Commands.CreateLivro
{
    public class CreateLivroHandler : IRequestHandler<CreateLivroCommand, int>
    {
        private readonly ILivroRepository _context;
        public CreateLivroHandler(ILivroRepository context) 
        {
            _context = context;
        }

        public async Task<int> Handle(CreateLivroCommand request, CancellationToken cancellationToken)
        {
            var livro = new Livro(
                  request.Titulo,
                  request.Autor,
                  request.ISBN,
                  request.AnoDeLancamento);
            await _context.AddAsync(livro);
            return livro.Id;
        }
    }
}
