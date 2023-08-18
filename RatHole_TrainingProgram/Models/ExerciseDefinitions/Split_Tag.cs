using RatHole_TrainingProgram.Models.Utils;

namespace RatHole_TrainingProgram.Models.ExerciseDefinitions
{
    public class Split_Tag
    {
        public int Id { get; set; }
        public Exercise_Split Split { get; set; }

        public List<Exercise_Definition> Exercise_Definitions { get; set; }
    }
}
