namespace RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplate
{
    public class Update_TrainingProgramTemplate_DTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public int Duration_In_Days { get; set; }

        public DateTime Date_Created { get; set; }
    }
}
