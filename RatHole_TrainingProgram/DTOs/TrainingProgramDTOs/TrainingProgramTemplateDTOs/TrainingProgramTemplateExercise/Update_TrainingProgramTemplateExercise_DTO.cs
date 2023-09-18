using RatHole_TrainingProgram.Models.ExerciseDefinitions;
using RatHole_TrainingProgram.Models.TrainingPrograms;
using RatHole_TrainingProgram.Models.Utils;

namespace RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateExercise
{
    public class Update_TrainingProgramTemplateExercise_DTO
    {
        public int Id { get; set; }
        public Exercise_Method Method { get; set; }
        public int Circuit_Number { get; set; }
        public int Position { get; set; }


        public Exercise_Definition Exercise_Definition { get; set; }
    }
}
