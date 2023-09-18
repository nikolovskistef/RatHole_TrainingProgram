using RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates;

namespace RatHole_TrainingProgram.Models.ExerciseDefinitions
{
    public class Exercise_Definition
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string URL { get; set; } = string.Empty;

        //TAGS
        public List<Category_Tag> Categories { get; set; }
        public List<Split_Tag> Splits { get; set; }
        public List<Muscle_Tag> Muscle_Tags { get; set; }
        public List<Joint_Tag> Joint_Tags { get; set; }
        public List<Tendon_Tag> Tendon_Tags { get; set; }

        
        public List<TrainingProgramTemplate_Exercise> Exercises { get; set; }

    }
}
