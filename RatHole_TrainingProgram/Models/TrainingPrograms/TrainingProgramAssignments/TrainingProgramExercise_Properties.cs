namespace RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments
{
    public class TrainingProgramExercise_Properties
    {
        public int Id { get; set; }

        public int Sets { get; set; }
        public int Reps { get; set; }
        public double Weight { get; set; }

        public DateTime Date_Modified { get; set; } //If the properties are updated the Date_Modified is populated, otherwise is empty

        public TrainingProgram_Exercise Exercise { get; set; } //Every Properties entity is linked to only one Exercise entity
        //Specific Properties
        public TrainingProgramExerciseProperties_DropSet? DropSet_Properties { get; set; }
        public TrainingProgramExerciseProperties_Isometric? Isometric_Properties { get; set; }
        public TrainingProgramExerciseProperties_Interval? Interval_Properties { get; set; }
    }
}
