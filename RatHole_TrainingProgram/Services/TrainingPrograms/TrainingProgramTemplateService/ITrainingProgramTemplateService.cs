using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateDTOs.TrainingProgramTemplate;
using RatHole_TrainingProgram.Models;

namespace RatHole_TrainingProgram.Services.TrainingPrograms.TrainingProgramTemplateService
{
    public interface ITrainingProgramTemplateService
    {
        Task<ServiceResponse<Get_TrainingProgramTemplate_DTO>> GetById(int id);
        Task<ServiceResponse<List<Get_TrainingProgramTemplate_DTO>>> GetAll();
        Task<ServiceResponse<List<Get_TrainingProgramTemplate_DTO>>> Add(Add_TrainingProgramTemplate_DTO newTrainigProgram);
        Task<ServiceResponse<Get_TrainingProgramTemplate_DTO>> Update(Update_TrainingProgramTemplate_DTO updatedTrainingProgram);
        Task<ServiceResponse<List<Get_TrainingProgramTemplate_DTO>>> Delete(int id);
    }
}
