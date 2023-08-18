using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateExercise;
using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateObjective;
using RatHole_TrainingProgram.Models;

namespace RatHole_TrainingProgram.Services.TrainingPrograms.TrainingProgramTemplateExerciseService
{
    public interface ITrainingProgramTemplateExerciseService
    {
        Task<ServiceResponse<Get_TrainingProgramTemplateExercise_DTO>> GetById(int id);
        Task<ServiceResponse<List<Get_TrainingProgramTemplateExercise_DTO>>> GetAll();
        Task<ServiceResponse<Get_TrainingProgramTemplateObjective_DTO>> Add(int exerciseDefinitionId, int ObjectiveId, Add_TrainingProgramTemplateExercise_DTO newExercise);
        Task<ServiceResponse<Get_TrainingProgramTemplateExercise_DTO>> Update(Update_TrainingProgramTemplateExercise_DTO updatedExercise);
        Task<ServiceResponse<List<Get_TrainingProgramTemplateExercise_DTO>>> Delete(int id);
    }
}
