using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplate;
using RatHole_TrainingProgram.Models.TrainingPrograms;

namespace RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateObjective
{
    public class Update_TrainingProgramTemplateObjective_DTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;

        public List<TrainingProgramTemplate_Exercise> Objective_Exercises { get; set; }
    }
}
