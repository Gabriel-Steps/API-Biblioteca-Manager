using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SistemaBiblioteca.Application.Commands.CreateEmprestimo;
using SistemaBiblioteca.Application.Commands.CreateLivro;
using SistemaBiblioteca.Application.Validatios;
using SistemaBiblioteca.Application.Validatios.Service;
using SistemaBiblioteca.Core.Entities;
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
builder.Services.AddScoped<ILivroService, LivroService>();
builder.Services.AddScoped<IValidator<CreateEmprestimoCommand>, CreateEmprestimoCommandValidation>();
builder.Services.AddControllers();
builder.Services.AddMediatR(typeof(CreateLivroCommand));
builder.Services.AddCors(options => {
    options.AddPolicy("AllowFrontend", policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseCors("AllowFrontend");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
