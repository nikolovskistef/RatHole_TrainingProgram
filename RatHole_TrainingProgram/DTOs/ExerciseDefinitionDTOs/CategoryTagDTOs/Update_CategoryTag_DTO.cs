using RatHole_TrainingProgram.Models.ExerciseDefinitions;
using RatHole_TrainingProgram.Models.Utils;

namespace RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.CategoryTagDTOs
{
    public class Update_CategoryTag_DTO
    {
        public int Id { get; set; }
        public Exercise_Category Category { get; set; }
    }
}
