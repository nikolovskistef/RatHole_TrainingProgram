using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.SplitTagDTOs;
using RatHole_TrainingProgram.Models;

namespace RatHole_TrainingProgram.Services.ExerciseDefinitions.SplitTagService
{
    public interface ISplitTagService
    {
        Task<ServiceResponse<Get_SplitTag_DTO>> GetById(int id);
        Task<ServiceResponse<List<Get_SplitTag_DTO>>> GetAll();
        Task<ServiceResponse<List<Get_SplitTag_DTO>>> Add(Add_SplitTag_DTO newTag);
        Task<ServiceResponse<Get_SplitTag_DTO>> Update(Update_SplitTag_DTO updatedTag);
        Task<ServiceResponse<List<Get_SplitTag_DTO>>> Delete(int id);
    }
}
