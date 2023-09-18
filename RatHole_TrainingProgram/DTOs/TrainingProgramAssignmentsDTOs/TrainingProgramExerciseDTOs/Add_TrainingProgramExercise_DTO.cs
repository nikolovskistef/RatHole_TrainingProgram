using RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments;
using RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates;

namespace RatHole_TrainingProgram.DTOs.TrainingProgramAssignmentsDTOs.TrainingProgramExerciseDTOs
{
    public class Add_TrainingProgramExercise_DTO
    {
        public TrainingProgramTemplate_Exercise Template_Exercise { get; set; }
        public List<TrainingProgramExercise_Properties> Properties_Entries { get; set; } = new List<TrainingProgramExercise_Properties>(); //One exercise entity can have multiple Properties

    }
}
