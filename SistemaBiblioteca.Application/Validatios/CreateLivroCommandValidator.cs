using FluentValidation;
using SistemaBiblioteca.Application.Commands.CreateLivro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.Validatios
{
    public class CreateLivroCommandValidator : AbstractValidator<CreateLivroCommand>
    {
        public CreateLivroCommandValidator()
        {
            RuleFor(l => l.ISBN).MaximumLength(13).WithMessage("O campo ISBN pode no máximo ter 13 caracteres");
        }
    }
}
