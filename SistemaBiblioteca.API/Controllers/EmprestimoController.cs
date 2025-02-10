using MediatR;
using Microsoft.AspNetCore.Mvc;
using SistemaBiblioteca.Application.Commands.CreateEmprestimo;
using SistemaBiblioteca.Application.Commands.DeleteEmprestimo;

namespace SistemaBiblioteca.API.Controllers
{
    [Route("api/emprestimos")]
    [ApiController]
    public class EmprestimoController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmprestimoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(CreateEmprestimoCommand command)
        {
            int id = await _mediator.Send(command);
            return Ok(id);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id) {
            var delete = new DeleteEmprestimoCommand(id);
            await _mediator.Send(delete);
            return Ok();
        }
    }
}
