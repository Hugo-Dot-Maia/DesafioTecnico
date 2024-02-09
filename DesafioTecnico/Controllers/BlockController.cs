using DesafioTecnico.Model.Dto;
using DesafioTecnico.Service.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTecnico.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlockController
    {
        private readonly IBlockService _service;

        public BlockController(IBlockService blockService)
        {
            _service = blockService;
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
        public async Task<IActionResult> Post(BlockDto block)
        {
            if (block == null)
                return new BadRequestObjectResult("Dados Inválidos");

            var result = await _service.Add(block);

            return result is not null
                ? new OkObjectResult(result)
                : new NotFoundResult();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, BlockDto block)
        {
            if (id <= 0)
                return new BadRequestResult();

            var result = await _service.Update(id, block);

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
