using Microsoft.AspNetCore.Mvc;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.JointTagDTOs;
using RatHole_TrainingProgram.Models;
using RatHole_TrainingProgram.Services.ExerciseDefinitions.JointTagService;

namespace RatHole_TrainingProgram.Controllers.ExerciseDefinitions
{
    [ApiController]
    [Route("/api/admin/[controller]")]
    public class JointTagController : ControllerBase
    {
        private readonly IJointTagService _service;

        public JointTagController(IJointTagService service)
        {
            _service = service;
        }

        //  GET Controller

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Get_JointTag_DTO>>> GetById(int id)
        {
            return Ok(await _service.GetById(id));
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Get_JointTag_DTO>>>> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        //  POST Controller
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Get_JointTag_DTO>>>> Add(Add_JointTag_DTO newTag)
        {
            return Ok(await _service.Add(newTag));
        }

        //  PUT Controller
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Get_JointTag_DTO>>> Update(Update_JointTag_DTO updatedTag)
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
        public async Task<ActionResult<ServiceResponse<List<Get_JointTag_DTO>>>> Delete(int id)
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
