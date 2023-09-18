namespace RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramAssignmentDTOs.TrainingProgramAssignment
{
    public class Add_TrainingProgramAssignment_DTO
    {
        public int Assigned_From { get; set; }
        public int Assigned_To { get; set; }

        public DateTime Assign_StartDate { get; set; }  //Start of Assignment 
        public DateTime Assign_EndDate { get; set; }    //End of Assignment (Start Date + TrainingProgramTemplate.Duration or premature end)
    }
}
