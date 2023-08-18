using Microsoft.AspNetCore.Mvc;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.SplitTagDTOs;
using RatHole_TrainingProgram.Models;
using RatHole_TrainingProgram.Services.ExerciseDefinitions.SplitTagService;

namespace RatHole_TrainingProgram.Controllers.ExerciseDefinitions
{
    [ApiController]
    [Route("/api/admin/[controller]")]
    public class SplitTagController : ControllerBase
    {
        private readonly ISplitTagService _service;

        public SplitTagController(ISplitTagService service)
        {
            _service = service;
        }

        //  GET Controller

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Get_SplitTag_DTO>>> GetById(int id)
        {
            return Ok(await _service.GetById(id));
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Get_SplitTag_DTO>>>> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        //  POST Controller
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Get_SplitTag_DTO>>>> Add(Add_SplitTag_DTO newTag)
        {
            return Ok(await _service.Add(newTag));
        }

        //  PUT Controller
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Get_SplitTag_DTO>>> Update(Update_SplitTag_DTO updatedTag)
        {
            var response = await _service.Update(updatedTag);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        //  DELETE Controller
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<Get_SplitTag_DTO>>>> Delete(int id)
        {
            var response = await _service.Delete(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
