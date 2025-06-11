using GestaoDeProvas.Repository;
using Microsoft.EntityFrameworkCore;
using GestaoDeProvas.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<GestaoDeProvaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configuração do Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Gestão de Provas API", Version = "v1" });
});

builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
builder.Services.AddControllers();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Gestão de Provas v1");
    c.RoutePrefix = "swagger";
});

app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();

if (app.Environment.IsDevelopment())
{
    using var scope = app.Services.CreateScope();
    var db = scope.ServiceProvider.GetRequiredService<GestaoDeProvaContext>();
    db.Database.EnsureCreated();
}

app.Run();