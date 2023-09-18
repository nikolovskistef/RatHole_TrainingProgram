using Microsoft.AspNetCore.Mvc;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.SplitTagDTOs;
using RatHole_TrainingProgram.DTOs.TrainingProgramAssignmentsDTOs.TrainingProgramExercisePropertiesDropSetDTOs;
using RatHole_TrainingProgram.Models;
using RatHole_TrainingProgram.Services.TrainingProgramAssignments.TrainingProgramExercisePropertiesDropSetService;

namespace RatHole_TrainingProgram.Controllers.TrainingProgramAssignments
{
    [ApiController]
    [Route("/api/[controller]")]
    public class TrainingProgramExercisePropertiesDropSetController : ControllerBase
    {
        private readonly ITrainingProgramExercisePropertiesDropSetService _service;

        public TrainingProgramExercisePropertiesDropSetController(ITrainingProgramExercisePropertiesDropSetService service)
        {
            _service = service;
        }

        //  GET Controller

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Get_TrainingProgramExercisePropertiesDropSet_DTO>>> GetById(int id)
        {
            return Ok(await _service.GetById(id));
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Get_TrainingProgramExercisePropertiesDropSet_DTO>>>> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        //  POST Controller
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Get_TrainingProgramExercisePropertiesDropSet_DTO>>>> Add(Add_TrainingProgramExercisePropertiesDropSet_DTO newDropSetProperties)
        {
            return Ok(await _service.Add(newDropSetProperties));
        }

        //  PUT Controller
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Get_TrainingProgramExercisePropertiesDropSet_DTO>>> Update(Update_TrainingProgramExercisePropertiesDropSet_DTO updatedDropSetProperties)
        {
            var response = await _service.Update(updatedDropSetProperties);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        //  DELETE Controller
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<Get_TrainingProgramExercisePropertiesDropSet_DTO>>>> Delete(int id)
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
