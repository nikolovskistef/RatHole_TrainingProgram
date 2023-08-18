using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.JointTagDTOs;
using RatHole_TrainingProgram.Models;

namespace RatHole_TrainingProgram.Services.ExerciseDefinitions.JointTagService
{
    public interface IJointTagService
    {
        Task<ServiceResponse<Get_JointTag_DTO>> GetById(int id);
        Task<ServiceResponse<List<Get_JointTag_DTO>>> GetAll();
        Task<ServiceResponse<List<Get_JointTag_DTO>>> Add(Add_JointTag_DTO newTag);
        Task<ServiceResponse<Get_JointTag_DTO>> Update(Update_JointTag_DTO updatedTag);
        Task<ServiceResponse<List<Get_JointTag_DTO>>> Delete(int id);
    }
}
