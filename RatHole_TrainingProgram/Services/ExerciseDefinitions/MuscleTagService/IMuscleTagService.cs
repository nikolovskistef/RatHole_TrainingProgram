using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.MuscleTagDTOs;
using RatHole_TrainingProgram.Models;

namespace RatHole_TrainingProgram.Services.ExerciseDefinitions.MuscleTagService
{
    public interface IMuscleTagService
    {
        Task<ServiceResponse<Get_MuscleTag_DTO>> GetById(int id);
        Task<ServiceResponse<List<Get_MuscleTag_DTO>>> GetAll();
        Task<ServiceResponse<List<Get_MuscleTag_DTO>>> Add(Add_MuscleTag_DTO newTag);
        Task<ServiceResponse<Get_MuscleTag_DTO>> Update(Update_MuscleTag_DTO updatedTag);
        Task<ServiceResponse<List<Get_MuscleTag_DTO>>> Delete(int id);
    }
}
