using RatHole_TrainingProgram.Models.Utils;

namespace RatHole_TrainingProgram.Models.ExerciseDefinitions
{
    public class Tendon_Tag
    {
        public int Id { get; set; }
        public Tendon Tendon { get; set; }

        public List<Exercise_Definition> Exercise_Definitions { get; set; }
    }
}
