using GestaoDeProvas.Dto;
using GestaoDeProvas.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeProvas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoRepository _repository;

        public AlunoController(IAlunoRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Add([FromBody] AlunoCreateDto alunoDto)
        {
            var aluno = _repository.Add(alunoDto);
            return CreatedAtAction(nameof(GetById), new { id = aluno.AlunoId }, aluno);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = _repository.GetById(id);
            if (aluno == null) return NotFound();
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] AlunoCreateDto alunoDto)
        {
            var aluno = _repository.Update(id, alunoDto);
            if (aluno == null) return NotFound();
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _repository.Delete(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}
