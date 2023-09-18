namespace RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments
{
    public class TrainingProgramExerciseProperties_Interval
    {
        public int Id { get; set; }

        public int Active_Time { get; set; }
        public int Rest_Time { get; set; }

        public int PropertiesId { get; set; }
        public TrainingProgramExercise_Properties Properties { get; set; } = null!;
    }
}
