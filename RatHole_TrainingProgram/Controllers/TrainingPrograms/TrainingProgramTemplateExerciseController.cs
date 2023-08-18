using Microsoft.AspNetCore.Mvc;
using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateExercise;
using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateObjective;
using RatHole_TrainingProgram.Models;
using RatHole_TrainingProgram.Services.TrainingPrograms.TrainingProgramTemplateExerciseService;

namespace RatHole_TrainingProgram.Controllers.TrainingPrograms
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrainingProgramTemplateExerciseController : ControllerBase
    {
        private readonly ITrainingProgramTemplateExerciseService _service;

        public TrainingProgramTemplateExerciseController(ITrainingProgramTemplateExerciseService service)
        {
            _service = service;
        }

        // GET Controller

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Get_TrainingProgramTemplateExercise_DTO>>> GetById(int id)
        {
            return Ok(await _service.GetById(id));
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Get_TrainingProgramTemplateExercise_DTO>>>> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        //  POST Controller
        [HttpPost("{exerciseDefinitionId}/{objectiveId}")]
        public async Task<ActionResult<ServiceResponse<Get_TrainingProgramTemplateObjective_DTO>>> Add(int exerciseDefinitionId, int objectiveId, Add_TrainingProgramTemplateExercise_DTO newExercise)
        {
            return Ok(await _service.Add(exerciseDefinitionId, objectiveId, newExercise));
        }

        //  PUT Controller
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Get_TrainingProgramTemplateExercise_DTO>>> Update(Update_TrainingProgramTemplateExercise_DTO updatedExercise)
        {
            var response = await _service.Update(updatedExercise);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        //  DELETE Controller
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<Get_TrainingProgramTemplateExercise_DTO>>>> Delete(int id)
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
