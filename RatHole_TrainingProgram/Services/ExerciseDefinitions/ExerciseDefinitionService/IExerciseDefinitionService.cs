using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.CategoryTagDTOs;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.ExerciseDefinitionDTOs;
using RatHole_TrainingProgram.Models;

namespace RatHole_TrainingProgram.Services.ExerciseDefinitions.ExerciseDefinitionService
{
    public interface IExerciseDefinitionService
    {
        Task<ServiceResponse<Get_ExerciseDefinition_DTO>> GetById(int id);
        Task<ServiceResponse<List<Get_ExerciseDefinition_DTO>>> GetAll();
        Task<ServiceResponse<List<Get_ExerciseDefinition_DTO>>> Add(Add_ExerciseDefinition_DTO newDefinition);
        Task<ServiceResponse<Get_ExerciseDefinition_DTO>> Update(Update_ExerciseDefinition_DTO updatedDefinition);
        Task<ServiceResponse<List<Get_ExerciseDefinition_DTO>>> Delete(int id);
        
        // ADD Exercise Definition Tags
        Task<ServiceResponse<Get_ExerciseDefinition_DTO>> AddExerciseDefinitionCategory(Add_ExerciseDefinitionCategory_DTO newCategory);
        Task<ServiceResponse<Get_ExerciseDefinition_DTO>> AddExerciseDefinitionSplit(Add_ExerciseDefinitionSplit_DTO newSplit);
        Task<ServiceResponse<Get_ExerciseDefinition_DTO>> AddExerciseDefinitionMuscleTag(Add_ExerciseDefinitionMuscleTag_DTO newTag);
        Task<ServiceResponse<Get_ExerciseDefinition_DTO>> AddExerciseDefinitionJointTag(Add_ExerciseDefinitionJointTag_DTO newTag);
        Task<ServiceResponse<Get_ExerciseDefinition_DTO>> AddExerciseDefinitionTendonTag(Add_ExerciseDefinitionTendonTag_DTO newTag);

        // DELETE Exercise Definition Tags
        Task<ServiceResponse<Get_ExerciseDefinition_DTO>> DeleteExerciseDefinitionCategory(int exerciseDefinitionId, int categoryId);
        Task<ServiceResponse<Get_ExerciseDefinition_DTO>> DeleteExerciseDefinitionSplit(int exerciseDefinitionId, int splitId);
        Task<ServiceResponse<Get_ExerciseDefinition_DTO>> DeleteExerciseDefinitionMuscleTag(int exerciseDefinitionId, int tagId);
        Task<ServiceResponse<Get_ExerciseDefinition_DTO>> DeleteExerciseDefinitionJointTag(int exerciseDefinitionId, int tagId);
        Task<ServiceResponse<Get_ExerciseDefinition_DTO>> DeleteExerciseDefinitionTendonTag(int exerciseDefinitionId, int tagId);
    }
}
