using RatHole_TrainingProgram.Models.Utils;

namespace RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.JointTagDTOs
{
    public class Update_JointTag_DTO
    {
        public int Id { get; set; }
        public Joint Joint { get; set; }
        public Joint_Movement Joint_Movement { get; set; }
    }
}
