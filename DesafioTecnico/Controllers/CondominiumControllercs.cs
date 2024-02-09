using DesafioTecnico.Model.Dto;
using DesafioTecnico.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTecnico.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CondominiumController
    {
        private readonly ICondominiumService _service;

        public CondominiumController(ICondominiumService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAll();

            return result.Any()
                ? new OkObjectResult(result)
                : new NotFoundResult();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetById(id);
            return new OkObjectResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CondominiumDto condominium)
        {
            if (condominium == null)
                return new BadRequestObjectResult("Dados Inválidos");

            var result = await _service.Add(condominium);

            return result is not null
                ? new OkObjectResult(result)
                : new NotFoundResult();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CondominiumDto condominium)
        {
            if (id <= 0)
                return new BadRequestResult();

            var result = await _service.Update(id, condominium);

            return result
                ? new OkResult()
                : new NotFoundResult();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0) return new BadRequestResult();

            var result = await _service.Delete(id);

            return result
                ? new OkResult()
                : new NotFoundResult();
        }

    }
}
