using MediatR;
using Microsoft.SqlServer.Server;
using SistemaBiblioteca.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.Queries.GetUsuario
{
    public class GetUsuarioQuery : IRequest<UsuarioDetailsViewModel>
    {
        public GetUsuarioQuery(int id) 
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
