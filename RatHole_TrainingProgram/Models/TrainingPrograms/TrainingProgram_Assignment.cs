using RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments;

namespace RatHole_TrainingProgram.Models.TrainingPrograms
{
    public class TrainingProgram_Assignment
    {
        public int Id { get; set; }

        //Later they should be User or Account type not int 
        public int Assigned_From { get; set; }
        public int Assigned_To { get; set; }

        public DateTime Assign_StartDate { get; set; }  //Start of Assignment 
        public DateTime Assign_EndDate { get; set; }    //End of Assignment (Start Date + TrainingProgramTemplate.Duration or premature end)

        public List<TrainingProgram_Workout> Workouts { get; set; } = new List<TrainingProgram_Workout>(); // Each assigned Training Program consists of Workouts 
    }
}