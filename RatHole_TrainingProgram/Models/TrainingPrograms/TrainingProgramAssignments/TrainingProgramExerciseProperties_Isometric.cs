namespace RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments
{
    public class TrainingProgramExerciseProperties_Isometric
    {
        public int Id { get; set; }

        public double Time_Under_Tension { get; set; }
        
        public int PropertiesId { get; set; }
        public TrainingProgramExercise_Properties Properties { get; set; } = null!;
    }
}
