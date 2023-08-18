using RatHole_TrainingProgram.Models.Utils;

namespace RatHole_TrainingProgram.Models.ExerciseDefinitions
{
    public class Category_Tag
    {
        public int Id { get; set; }
        public Exercise_Category Category { get; set; }

        public List<Exercise_Definition> Exercise_Definitions { get; set; }
    }
}
