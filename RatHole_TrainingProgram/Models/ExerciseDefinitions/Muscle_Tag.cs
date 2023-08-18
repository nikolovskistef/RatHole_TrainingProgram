using RatHole_TrainingProgram.Models.Utils;

namespace RatHole_TrainingProgram.Models.ExerciseDefinitions
{
    public class Muscle_Tag
    {
        public int Id { get; set; }
        public Muscle Muscle { get; set; }
        public Muscle_Role Muscle_Role { get; set; }
        public Muscle_Involvment Muscle_Involvment { get; set; }
       
        public List<Exercise_Definition> Exercise_Definitions { get; set; }
    }
}
