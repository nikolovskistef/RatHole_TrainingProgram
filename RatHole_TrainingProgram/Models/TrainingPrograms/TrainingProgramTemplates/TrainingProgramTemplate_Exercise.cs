using RatHole_TrainingProgram.Models.ExerciseDefinitions;
using RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments;
using RatHole_TrainingProgram.Models.Utils;

namespace RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates
{
    public class TrainingProgramTemplate_Exercise
    {
        public int Id { get; set; }
        public Exercise_Method Method { get; set; }
        public int Circuit_Number { get; set; }
        public int Position { get; set; }


        public Exercise_Definition Exercise_Definition { get; set; }
        public TrainingProgramTemplate_Objective TrainingProgramTemplate_Objective { get; set; }
        public List<TrainingProgram_Exercise> Assigned_Exercises { get; set; } = new List<TrainingProgram_Exercise>();
    }
}
