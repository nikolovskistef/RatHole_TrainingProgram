namespace RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateDTOs.TrainingProgramTemplate
{
    public class Add_TrainingProgramTemplate_DTO
    {
        public string Name { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public int Duration_In_Days { get; set; }

        public DateTime Date_Created { get; set; }
    }
}
