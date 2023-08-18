using Microsoft.AspNetCore.Mvc;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.MuscleTagDTOs;
using RatHole_TrainingProgram.Models;
using RatHole_TrainingProgram.Services.ExerciseDefinitions.MuscleTagService;

namespace RatHole_TrainingProgram.Controllers.ExerciseDefinitions
{
    [ApiController]
    [Route("/api/admin/[controller]")]
    public class MuslceTagController : ControllerBase
    {
        private readonly IMuscleTagService _service;

        public MuslceTagController(IMuscleTagService service)
        {
            _service = service;
        }

        //  GET Controller

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Get_MuscleTag_DTO>>> GetById(int id)
        {
            return Ok(await _service.GetById(id));
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Get_MuscleTag_DTO>>>> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        //  POST Controller
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Get_MuscleTag_DTO>>>> Add(Add_MuscleTag_DTO newTag)
        {
            return Ok(await _service.Add(newTag));
        }

        //  PUT Controller
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Get_MuscleTag_DTO>>> Update(Update_MuscleTag_DTO  updatedTag)
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
        public async Task<ActionResult<ServiceResponse<List<Get_MuscleTag_DTO>>>> Delete(int id)
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
