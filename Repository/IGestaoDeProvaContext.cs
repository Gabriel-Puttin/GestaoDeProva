using Microsoft.EntityFrameworkCore;
using GestaoDeProvas.Models;

public interface IGestaoDeProvaContext
{
    DbSet<Aluno> Alunos { get; set; }
    public int SaveChanges();
}