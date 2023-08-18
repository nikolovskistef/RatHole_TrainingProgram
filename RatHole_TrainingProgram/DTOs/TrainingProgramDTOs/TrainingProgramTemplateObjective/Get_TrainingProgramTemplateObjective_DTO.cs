using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateExercise;

namespace RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateObjective
{
    public class Get_TrainingProgramTemplateObjective_DTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;

        public List<Get_TrainingProgramTemplateExercise_DTO> Objective_Exercises { get; set; }
    }
}
