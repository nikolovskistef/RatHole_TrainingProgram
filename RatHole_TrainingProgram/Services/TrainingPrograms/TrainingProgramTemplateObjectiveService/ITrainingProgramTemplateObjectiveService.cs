using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplate;
using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateObjective;
using RatHole_TrainingProgram.Models;

namespace RatHole_TrainingProgram.Services.TrainingPrograms.TrainingProgramTemplateObjectiveService
{
    public interface ITrainingProgramTemplateObjectiveService
    {
        Task<ServiceResponse<Get_TrainingProgramTemplateObjective_DTO>> GetById(int id);
        Task<ServiceResponse<List<Get_TrainingProgramTemplateObjective_DTO>>> GetAll();
        Task<ServiceResponse<Get_TrainingProgramTemplate_DTO>> Add(int trainingProgramTemplateId ,Add_TrainingProgramTemplateObjective_DTO newObjective);
        Task<ServiceResponse<Get_TrainingProgramTemplateObjective_DTO>> Update(Update_TrainingProgramTemplateObjective_DTO updatedObjective);
        Task<ServiceResponse<List<Get_TrainingProgramTemplateObjective_DTO>>> Delete(int id);
    }
}
