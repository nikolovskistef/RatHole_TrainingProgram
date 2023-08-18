using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.CategoryTagDTOs;
using RatHole_TrainingProgram.Models;

namespace RatHole_TrainingProgram.Services.ExerciseDefinitions.CategoryTagService
{
    public interface ICategoryTagService
    {
        Task<ServiceResponse<Get_CategoryTag_DTO>> GetById(int id);
        Task<ServiceResponse<List<Get_CategoryTag_DTO>>> GetAll();
        Task<ServiceResponse<List<Get_CategoryTag_DTO>>> Add(Add_CategoryTag_DTO newTag);
        Task<ServiceResponse<Get_CategoryTag_DTO>> Update(Update_CategoryTag_DTO updatedTag);
        Task<ServiceResponse<List<Get_CategoryTag_DTO>>> Delete(int id);
    }
}
