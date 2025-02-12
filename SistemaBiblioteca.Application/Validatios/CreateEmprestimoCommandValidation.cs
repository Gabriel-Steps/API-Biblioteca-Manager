using FluentValidation;
using SistemaBiblioteca.Application.Commands.CreateEmprestimo;
using SistemaBiblioteca.Core.Entities;
using SistemaBiblioteca.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.Validatios
{
    public class CreateEmprestimoCommandValidation : AbstractValidator<CreateEmprestimoCommand>
    {
        public CreateEmprestimoCommandValidation(ILivroService livroService)
        {
            RuleFor(e => e.IdLivro).Must(livroService.LivroExiste).Must(livroService.LivroDisponivel).WithMessage("O Livro informado não está disponivel");
        }
    }
}
