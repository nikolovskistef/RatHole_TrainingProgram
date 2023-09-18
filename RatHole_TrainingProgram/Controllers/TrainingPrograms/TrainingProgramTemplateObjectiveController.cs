using Microsoft.AspNetCore.Mvc;
using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateDTOs.TrainingProgramTemplate;
using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateObjective;
using RatHole_TrainingProgram.Models;
using RatHole_TrainingProgram.Services.TrainingPrograms.TrainingProgramTemplateObjectiveService;

namespace RatHole_TrainingProgram.Controllers.TrainingPrograms
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrainingProgramTemplateObjectiveController : ControllerBase
    {
        private readonly ITrainingProgramTemplateObjectiveService _service;

        public TrainingProgramTemplateObjectiveController(ITrainingProgramTemplateObjectiveService service)
        {
            _service = service;
        }

        // GET Controller

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Get_TrainingProgramTemplateObjective_DTO>>> GetById(int id)
        {
            return Ok(await _service.GetById(id));
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Get_TrainingProgramTemplateObjective_DTO>>>> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        //  POST Controller
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Get_TrainingProgramTemplate_DTO>>>> Add(int trainingProgramTemplateId, Add_TrainingProgramTemplateObjective_DTO newObjective)
        {
            return Ok(await _service.Add(trainingProgramTemplateId, newObjective));
        }

        //  PUT Controller
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Get_TrainingProgramTemplateObjective_DTO>>> Update(Update_TrainingProgramTemplateObjective_DTO updatedObjective)
        {
            var response = await _service.Update(updatedObjective);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        //  DELETE Controller
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<Get_TrainingProgramTemplateObjective_DTO>>>> Delete(int id)
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
