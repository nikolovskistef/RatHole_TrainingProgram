using RatHole_TrainingProgram.Models.ExerciseDefinitions;
using RatHole_TrainingProgram.Models.Utils;

namespace RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateExercise
{
    public class Add_TrainingProgramTemplateExercise_DTO
    {
        public Exercise_Method Method { get; set; }
        public int Circuit_Number { get; set; }
        public int Position { get; set; }

    }
}
