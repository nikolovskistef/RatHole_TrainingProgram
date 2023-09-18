using RatHole_TrainingProgram.Models.Utils;

namespace RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments
{
    public class TrainingProgram_Workout
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public Workout_Status Status { get; set; }
        
        //public Workout_Action Action { get; set; }

        public DateTime Date { get; set; }  //The date planned from the assignment
                                            //(shown in the calendar)
        public DateTime Date_Recorded { get; set; } //The Date this workout is recoreded for tracking
                                                    //(originally it should be the Date date, but if it was postponed/moved can be different date.)

        public List<TrainingProgram_Exercise> Exercises { get; set; } = new List<TrainingProgram_Exercise>();
        public TrainingProgram_Assignment Training_Program { get; set; } = null!; //Each individual Workout belongs to a single assgned TrainingProgram
    }
}
