using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SistemaBiblioteca.Application.Commands.CreateEmprestimo;
using SistemaBiblioteca.Application.Commands.DeleteEmprestimo;
using SistemaBiblioteca.Application.Queries.GetAllEmprestimos;
using SistemaBiblioteca.Application.Queries.GetAllUsuarios;
using SistemaBiblioteca.Core.Entities;

namespace SistemaBiblioteca.API.Controllers
{
    [Route("api/emprestimos")]
    [ApiController]
    public class EmprestimoController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IValidator<CreateEmprestimoCommand> _validator;
        public EmprestimoController(IMediator mediator, IValidator<CreateEmprestimoCommand> validator)
        {
            _mediator = mediator;
            _validator = validator;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody]CreateEmprestimoCommand command)
        {
            var validationResult = _validator.Validate(command);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }
            int id = await _mediator.Send(command);
            return Ok(id);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id) {
            var delete = new DeleteEmprestimoCommand(id);
            await _mediator.Send(delete);
            return Ok();
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllEmprestimoQuery();
            var emprestimos = await _mediator.Send(query);
            return Ok(emprestimos);
        }
    }
}
