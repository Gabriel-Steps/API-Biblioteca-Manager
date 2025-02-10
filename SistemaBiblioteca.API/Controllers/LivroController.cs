using MediatR;
using Microsoft.AspNetCore.Mvc;
using SistemaBiblioteca.Application.Commands.CreateLivro;
using SistemaBiblioteca.Application.Commands.DeleteLivro;
using SistemaBiblioteca.Application.Queries.GetAllLivros;
using SistemaBiblioteca.Application.Queries.GetLivro;

namespace SistemaBiblioteca.API.Controllers
{
    [Route("api/livros")]
    public class LivroController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LivroController(IMediator mediator) { 
            _mediator = mediator;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetLivroQuery(id);
            var livro = await _mediator.Send(query);
            return Ok(livro);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateLivroCommand newLivro)
        {
            if (!ModelState.IsValid)
            {
                var messages = ModelState
                    .SelectMany(ms => ms.Value.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();

                return BadRequest(messages);
            }
            var idLivro = await _mediator.Send(newLivro);
            return CreatedAtAction(nameof(GetById), new { id = idLivro }, newLivro);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllLivroQuery();
            var livros = await _mediator.Send(query);
            return Ok(livros);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteLivroCommand(id);
            await _mediator.Send(command);
            return Ok();
        }
    }
}
