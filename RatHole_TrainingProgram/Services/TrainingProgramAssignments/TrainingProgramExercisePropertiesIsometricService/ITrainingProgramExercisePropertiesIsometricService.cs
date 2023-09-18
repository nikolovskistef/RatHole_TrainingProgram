using RatHole_TrainingProgram.DTOs.TrainingProgramAssignmentsDTOs.TrainingProgramExercisePropertiesDropSetDTOs;
using RatHole_TrainingProgram.DTOs.TrainingProgramAssignmentsDTOs.TrainingProgramExercisePropertiesIsometricDTOs;
using RatHole_TrainingProgram.Models;

namespace RatHole_TrainingProgram.Services.TrainingProgramAssignments.TrainingProgramExercisePropertiesIsometricService
{
    public interface ITrainingProgramExercisePropertiesIsometricService
    {
        Task<ServiceResponse<Get_TrainingProgramExercisePropertiesIsometric_DTO>> GetById(int id);
        Task<ServiceResponse<List<Get_TrainingProgramExercisePropertiesIsometric_DTO>>> GetAll();
        Task<ServiceResponse<Get_TrainingProgramExercisePropertiesIsometric_DTO>> Add(Add_TrainingProgramExercisePropertiesIsometric_DTO newIsometricProperties);
        Task<ServiceResponse<Get_TrainingProgramExercisePropertiesIsometric_DTO>> Update(Update_TrainingProgramExercisePropertiesIsometric_DTO updatedIsometricProperties);
        Task<ServiceResponse<List<Get_TrainingProgramExercisePropertiesIsometric_DTO>>> Delete(int id);
    }
}
