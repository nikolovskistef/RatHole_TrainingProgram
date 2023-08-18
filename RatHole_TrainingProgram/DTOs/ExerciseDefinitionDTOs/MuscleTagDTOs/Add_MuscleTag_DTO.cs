using RatHole_TrainingProgram.Models.Utils;

namespace RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.MuscleTagDTOs
{
    public class Add_MuscleTag_DTO
    {
        public Muscle Muscle { get; set; }
        public Muscle_Role Muscle_Role { get; set; }
        public Muscle_Involvment Muscle_Involvment { get; set; }
    }
}
