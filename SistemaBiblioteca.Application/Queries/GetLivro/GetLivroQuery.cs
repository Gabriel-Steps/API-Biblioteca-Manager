using MediatR;
using SistemaBiblioteca.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.Queries.GetLivro
{
    public class GetLivroQuery : IRequest<LivroDetailsViewModel>
    {
        public GetLivroQuery(int id) 
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
