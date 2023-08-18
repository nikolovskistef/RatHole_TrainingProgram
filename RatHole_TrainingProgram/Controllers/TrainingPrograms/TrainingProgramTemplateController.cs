using Microsoft.AspNetCore.Mvc;
using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplate;
using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateObjective;
using RatHole_TrainingProgram.Models;
using RatHole_TrainingProgram.Services.TrainingPrograms.TrainingProgramTemplateService;

namespace RatHole_TrainingProgram.Controllers.TrainingPrograms
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrainingProgramTemplateController : ControllerBase
    {
        private readonly ITrainingProgramTemplateService _service;

        public TrainingProgramTemplateController(ITrainingProgramTemplateService service)
        {
            _service = service;
        }

        // GET Controller

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Get_TrainingProgramTemplate_DTO>>> GetById(int id)
        {
            return Ok(await _service.GetById(id));
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Get_TrainingProgramTemplate_DTO>>>> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        //  POST Controller
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Get_TrainingProgramTemplate_DTO>>>> Add(Add_TrainingProgramTemplate_DTO newTrainingProgram)
        {
            return Ok(await _service.Add(newTrainingProgram));
        }

        //  PUT Controller
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Get_TrainingProgramTemplate_DTO>>> Update(Update_TrainingProgramTemplate_DTO updatedTrainingProgram)
        {
            var response = await _service.Update(updatedTrainingProgram);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        //  DELETE Controller
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<Get_TrainingProgramTemplate_DTO>>>> Delete(int id)
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
