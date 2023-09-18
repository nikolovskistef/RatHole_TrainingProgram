namespace RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments
{
    public class TrainingProgramExerciseProperties_DropSet
    {
        public int Id { get; set; }

        public int DropSet_Count { get; set; }
        public int DropSet_Offset { get; set; }

        public int PropertiesId { get; set; }
        public TrainingProgramExercise_Properties Properties { get; set; } = null!;
    }
}
