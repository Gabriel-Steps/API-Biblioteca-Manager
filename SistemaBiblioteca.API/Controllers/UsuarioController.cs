﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using SistemaBiblioteca.Application.Commands.CreateUsuario;
using SistemaBiblioteca.Application.Queries.GetAllLivros;
using SistemaBiblioteca.Application.Queries.GetAllUsuarios;
using SistemaBiblioteca.Application.Queries.GetUsuario;

namespace SistemaBiblioteca.API.Controllers
{
    [Route("api/usuarios")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsuarioController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) {
            var query = new GetUsuarioQuery(id);
            var usuario = await _mediator.Send(query);
            return Ok(usuario);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllUsuarioQuery();
            var usuarios = await _mediator.Send(query);
            return Ok(usuarios);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(CreateUsuarioCommand command)
        {
            int id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new {id}, command);
        }
    }
}
