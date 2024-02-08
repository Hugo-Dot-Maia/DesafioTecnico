using DesafioTecnico.Model.Dto;
using DesafioTecnico.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTecnico.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResidentController
    {
        private readonly IResidentService _residentService;

        public ResidentController(IResidentService residentService)
        {
            _residentService = residentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _residentService.GetAll();
            return result.Any()
                ? new OkObjectResult(result)
                : new NotFoundObjectResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _residentService.GetById(id);
            return new OkObjectResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ResidentDto resident)
        {
            if (resident == null) 
                return new BadRequestObjectResult("Dados Inválidos");

            var result = await _residentService.Add(resident);

            return result is not null
                ? new OkObjectResult(result)
                : new NotFoundResult();

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ResidentDto resident)
        {
            if (id <= 0)
                return new BadRequestResult();

            var result = await _residentService.Update(id, resident);

            return result
                ? new OkResult()
                : new NotFoundResult();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0) return new BadRequestResult();

            var result = await _residentService.Delete(id);

            return result
                ? new OkResult()
                : new NotFoundResult();
        }




    }
}
