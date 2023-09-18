using RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates;

namespace RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments
{
    public class TrainingProgram_Exercise
    {
        public int Id { get; set; }

        public TrainingProgramTemplate_Exercise Template_Exercise { get; set; }
        public List<TrainingProgramExercise_Properties> Properties_Entries { get; set; } = new List<TrainingProgramExercise_Properties>(); //One exercise entity can have multiple Properties
                                                                                                                                   //(the original one and the edit entries)   
        public TrainingProgram_Workout Workout { get; set; }

        //Should I take it from TrainingProgramTemplate_Exercise -> TrainingProgramTemplate_Objectives -> TrainingProgram_Template -> TrainingProgram_Assignment
        //public TrainingProgram_Assignment Assignment { get; set; }
    }
}
