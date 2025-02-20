using MediatR;
using SistemaBiblioteca.Application.ViewModels;
using SistemaBiblioteca.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.Queries.GetAllUsuarios
{
    public class GetAllUsuarioHandler : IRequestHandler<GetAllUsuarioQuery, List<UsuarioDetailsViewModel>>
    {
        private readonly IUsuarioRepository _context;
        public GetAllUsuarioHandler(IUsuarioRepository context)
        {
            _context = context;
        }
        public async Task<List<UsuarioDetailsViewModel>> Handle(GetAllUsuarioQuery request, CancellationToken cancellationToken)
        {
            var usuarios = await _context.GetAllAsync();
            var usuariosViewModel = usuarios
                .Select(u => new UsuarioDetailsViewModel(u.Id, u.Nome, u.Email)).ToList();
            return usuariosViewModel;
        }
    }
}
