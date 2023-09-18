using RatHole_TrainingProgram.DTOs.TrainingProgramAssignmentsDTOs.TrainingProgramExercisePropertiesIntervalDTOs;
using RatHole_TrainingProgram.Models;

namespace RatHole_TrainingProgram.Services.TrainingProgramAssignments.TrainingProgramExercisePropertiesIntervalService
{
    public interface ITrainingProgramExercisePropertiesIntervalService
    {
        Task<ServiceResponse<Get_TrainingProgramExercisePropertiesInterval_DTO>> GetById(int id);
        Task<ServiceResponse<List<Get_TrainingProgramExercisePropertiesInterval_DTO>>> GetAll();
        Task<ServiceResponse<Get_TrainingProgramExercisePropertiesInterval_DTO>> Add(Add_TrainingProgramExercisePropertiesInterval_DTO newIntervalProperties);
        Task<ServiceResponse<Get_TrainingProgramExercisePropertiesInterval_DTO>> Update(Update_TrainingProgramExercisePropertiesInterval_DTO updatedIntervalProperties);
        Task<ServiceResponse<List<Get_TrainingProgramExercisePropertiesInterval_DTO>>> Delete(int id);
    }
}
