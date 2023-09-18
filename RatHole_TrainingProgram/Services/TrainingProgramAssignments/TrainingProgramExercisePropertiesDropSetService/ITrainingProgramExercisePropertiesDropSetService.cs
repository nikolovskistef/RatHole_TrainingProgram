using RatHole_TrainingProgram.DTOs.TrainingProgramAssignmentsDTOs.TrainingProgramExercisePropertiesDropSetDTOs;
using RatHole_TrainingProgram.Models;

namespace RatHole_TrainingProgram.Services.TrainingProgramAssignments.TrainingProgramExercisePropertiesDropSetService
{
    public interface ITrainingProgramExercisePropertiesDropSetService
    {
        Task<ServiceResponse<Get_TrainingProgramExercisePropertiesDropSet_DTO>> GetById(int id);
        Task<ServiceResponse<List<Get_TrainingProgramExercisePropertiesDropSet_DTO>>> GetAll();
        Task<ServiceResponse<List<Get_TrainingProgramExercisePropertiesDropSet_DTO>>> Add(Add_TrainingProgramExercisePropertiesDropSet_DTO newDropSetProperties);
        Task<ServiceResponse<Get_TrainingProgramExercisePropertiesDropSet_DTO>> Update(Update_TrainingProgramExercisePropertiesDropSet_DTO updatedDropSetProperties);
        Task<ServiceResponse<List<Get_TrainingProgramExercisePropertiesDropSet_DTO>>> Delete(int id);
    }
}
