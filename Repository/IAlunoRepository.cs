using GestaoDeProvas.Dto;
using GestaoDeProvas.Models;

namespace GestaoDeProvas.Repository
{
    public interface IAlunoRepository
    {
        AlunoDto Add(AlunoCreateDto aluno);
        IEnumerable<AlunoDto> GetAll();
        AlunoDto? GetById(int id);
        AlunoDto? Update(int id, AlunoCreateDto alunoUpdate);
        bool Delete(int id);
    }
}