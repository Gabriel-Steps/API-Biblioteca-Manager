using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SistemaBiblioteca.Application.Commands.CreateLivro;
using SistemaBiblioteca.Application.Validatios;
using SistemaBiblioteca.Core.Repositories;
using SistemaBiblioteca.Infrastructure.Persistence;
using SistemaBiblioteca.Infrastructure.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ILivroRepository, LivroRepository>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IEmprestimoRepository, EmprestimoRepository>();


builder.Services.AddDbContext<BibliotecaSistemaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));
builder.Services.AddValidatorsFromAssemblyContaining<CreateLivroCommandValidator>();
builder.Services.AddControllers();
builder.Services.AddMediatR(typeof(CreateLivroCommand));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
