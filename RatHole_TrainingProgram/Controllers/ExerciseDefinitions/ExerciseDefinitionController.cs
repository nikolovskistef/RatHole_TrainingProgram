using Microsoft.AspNetCore.Mvc;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.ExerciseDefinitionDTOs;
using RatHole_TrainingProgram.Models;
using RatHole_TrainingProgram.Services.ExerciseDefinitions.ExerciseDefinitionService;

namespace RatHole_TrainingProgram.Controllers.ExerciseDefinitions
{
    [ApiController]
    [Route("/api/admin/[controller]")]
    public class ExerciseDefinitionController : ControllerBase
    {
        private readonly IExerciseDefinitionService _service;

        public ExerciseDefinitionController(IExerciseDefinitionService service)
        {
            _service = service;
        }

        //  GET Controller

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Get_ExerciseDefinition_DTO>>> GetById(int id)
        {
            return Ok(await _service.GetById(id));
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Get_ExerciseDefinition_DTO>>>> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        //  POST Controller
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Get_ExerciseDefinition_DTO>>>> Add(Add_ExerciseDefinition_DTO newDefinition)
        {
            return Ok(await _service.Add(newDefinition));
        }

        //  PUT Controller
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Get_ExerciseDefinition_DTO>>> Update(Update_ExerciseDefinition_DTO updatedDefinition)
        {
            var response = await _service.Update(updatedDefinition);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        //  DELETE Controller
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<Get_ExerciseDefinition_DTO>>>> Delete(int id)
        {
            var response = await _service.Delete(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        // ADD Exercise Definition Tags
        [HttpPost("CategoryAdd")]
        public async Task<ActionResult<ServiceResponse<Get_ExerciseDefinition_DTO>>> AddExerciseDefinitionCategory(Add_ExerciseDefinitionCategory_DTO newCategory)
        {
            return Ok(await _service.AddExerciseDefinitionCategory(newCategory));
        }
        [HttpPost("SplitAdd")]
        public async Task<ActionResult<ServiceResponse<Get_ExerciseDefinition_DTO>>> AddExerciseDefinitionSplit(Add_ExerciseDefinitionSplit_DTO newSplit)
        {
            return Ok(await _service.AddExerciseDefinitionSplit(newSplit));
        }
        [HttpPost("MuscleTagAdd")]
        public async Task<ActionResult<ServiceResponse<Get_ExerciseDefinition_DTO>>> AddExerciseDefinitionMuscleTag(Add_ExerciseDefinitionMuscleTag_DTO newTag)
        {
            return Ok(await _service.AddExerciseDefinitionMuscleTag(newTag));
        }
        [HttpPost("JointTagAdd")]
        public async Task<ActionResult<ServiceResponse<Get_ExerciseDefinition_DTO>>> AddExerciseDefinitionJointTag(Add_ExerciseDefinitionJointTag_DTO newTag)
        {
            return Ok(await _service.AddExerciseDefinitionJointTag(newTag));
        }
        [HttpPost("TendonTagAdd")]
        public async Task<ActionResult<ServiceResponse<Get_ExerciseDefinition_DTO>>> AddExerciseDefinitionTendonTag(Add_ExerciseDefinitionTendonTag_DTO newTag)
        {
            return Ok(await _service.AddExerciseDefinitionTendonTag(newTag));
        }

        // DELETE Exercise Definition Tags
        [HttpDelete("CategoryDelete/{exerciseDefinitionId}/{categoryId}")]
        public async Task<ActionResult<ServiceResponse<Get_ExerciseDefinition_DTO>>> DeleteExerciseDefinitionCategory(int exerciseDefinitionId, int categoryId)
        {
            return Ok(await _service.DeleteExerciseDefinitionCategory(exerciseDefinitionId, categoryId));
        }
        [HttpDelete("SplitDelete/{exerciseDefinitionId}/{splitId}")]
        public async Task<ActionResult<ServiceResponse<Get_ExerciseDefinition_DTO>>> DeleteExerciseDefinitionSplit(int exerciseDefinitionId, int splitId)
        {
            return Ok(await _service.DeleteExerciseDefinitionSplit(exerciseDefinitionId, splitId));
        }
        [HttpDelete("MuscleTagDelete/{exerciseDefinitionId}/{muscleTagId}")]
        public async Task<ActionResult<ServiceResponse<Get_ExerciseDefinition_DTO>>> DeleteExerciseDefinitionMuscleTag(int exerciseDefinitionId, int muscleTagId)
        {
            return Ok(await _service.DeleteExerciseDefinitionMuscleTag(exerciseDefinitionId, muscleTagId));
        }
        [HttpDelete("JointTagDelete/{exerciseDefinitionId}/{jointTagId}")]
        public async Task<ActionResult<ServiceResponse<Get_ExerciseDefinition_DTO>>> DeleteExerciseDefinitionJointTag(int exerciseDefinitionId, int jointTagId)
        {
            return Ok(await _service.DeleteExerciseDefinitionJointTag(exerciseDefinitionId, jointTagId));
        }
        [HttpDelete("TendonTagDelete/{exerciseDefinitionId}/{tendonTagId}")]
        public async Task<ActionResult<ServiceResponse<Get_ExerciseDefinition_DTO>>> DeleteExerciseDefinitionTendonTag(int exerciseDefinitionId, int tendonTagId)
        {
            return Ok(await _service.DeleteExerciseDefinitionTendonTag(exerciseDefinitionId, tendonTagId));
        }
    }
}
