using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.ExerciseDefinitionDTOs;
using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateObjective;
using RatHole_TrainingProgram.Models.ExerciseDefinitions;
using RatHole_TrainingProgram.Models.TrainingPrograms;
using RatHole_TrainingProgram.Models.Utils;

namespace RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateExercise
{
    public class Get_TrainingProgramTemplateExercise_DTO
    {
        public int Id { get; set; }
        public Exercise_Method Method { get; set; }
        public int Circuit_Number { get; set; }
        public int Position { get; set; }

        public Get_ExerciseDefinition_DTO Exercise_Definition { get; set; }
        public Get__TrainingProgramTemplateObjectiveExercise_DTO Objective { get; set; }
    }
}
