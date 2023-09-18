using System.ComponentModel.DataAnnotations;

namespace RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates
{
    public class TrainingProgram_Template
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public int Duration_In_Days { get; set; }

        public DateTime Date_Created { get; set; }

        public List<TrainingProgramTemplate_Objective>? Objectives { get; set; }
    }
}
