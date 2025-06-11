using GestaoDeProvas.Dto;
using GestaoDeProvas.Models;

namespace GestaoDeProvas.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly GestaoDeProvaContext _context;

        public AlunoRepository(GestaoDeProvaContext context)
        {
            _context = context;
        }

        public AlunoDto Add(AlunoCreateDto alunoDto)
        {
            var aluno = new Aluno
            {
                Nome = alunoDto.Nome,
                Email = alunoDto.Email,
                Senha = alunoDto.Senha
            };

            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            return new AlunoDto
            {
                AlunoId = aluno.AlunoId,
                Nome = aluno.Nome,
                Email = aluno.Email
            };
        }

        public IEnumerable<AlunoDto> GetAll()
        {
            return _context.Alunos
                .Select(a => new AlunoDto
                {
                    AlunoId = a.AlunoId,
                    Nome = a.Nome,
                    Email = a.Email
                })
                .ToList();
        }

        public AlunoDto? GetById(int id)
        {
            var aluno = _context.Alunos.Find(id);
            if (aluno == null) return null;

            return new AlunoDto
            {
                AlunoId = aluno.AlunoId,
                Nome = aluno.Nome,
                Email = aluno.Email
            };
        }

        public AlunoDto? Update(int id, AlunoCreateDto alunoUpdate)
        {
            var aluno = _context.Alunos.Find(id);
            if (aluno == null) return null;

            aluno.Nome = alunoUpdate.Nome;
            aluno.Email = alunoUpdate.Email;
            aluno.Senha = alunoUpdate.Senha;

            _context.SaveChanges();

            return new AlunoDto
            {
                AlunoId = aluno.AlunoId,
                Nome = aluno.Nome,
                Email = aluno.Email
            };
        }

        public bool Delete(int id)
        {
            var aluno = _context.Alunos.Find(id);
            if (aluno == null) return false;

            _context.Alunos.Remove(aluno);
            _context.SaveChanges();
            return true;
        }
    }
}