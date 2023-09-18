namespace RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates
{
    public class TrainingProgramTemplate_Objective
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;

        public TrainingProgram_Template TrainingProgram_Template { get; set; }
        public List<TrainingProgramTemplate_Exercise> Objective_Exercises { get; set; }
    }
}
