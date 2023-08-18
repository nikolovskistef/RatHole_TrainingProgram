using RatHole_TrainingProgram.Models.Utils;

namespace RatHole_TrainingProgram.Models.ExerciseDefinitions
{
    public class Joint_Tag
    {
        public int Id { get; set; }
        public Joint Joint { get; set; }
        public Joint_Movement Joint_Movement { get; set; }


        public List<Exercise_Definition> Exercise_Definitions { get; set; }
    }
}
