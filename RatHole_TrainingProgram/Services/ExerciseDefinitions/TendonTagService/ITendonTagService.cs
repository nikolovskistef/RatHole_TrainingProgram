using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.CategoryTagDTOs;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.TendonTagDTOs;
using RatHole_TrainingProgram.Models;

namespace RatHole_TrainingProgram.Services.ExerciseDefinitions.TendonTagService
{
    public interface ITendonTagService
    {
        Task<ServiceResponse<Get_TendonTag_DTO>> GetById(int id);
        Task<ServiceResponse<List<Get_TendonTag_DTO>>> GetAll();
        Task<ServiceResponse<List<Get_TendonTag_DTO>>> Add(Add_TendonTag_DTO newTag);
        Task<ServiceResponse<Get_TendonTag_DTO>> Update(Update_TendonTag_DTO updatedTag);
        Task<ServiceResponse<List<Get_TendonTag_DTO>>> Delete(int id);
    }
}
