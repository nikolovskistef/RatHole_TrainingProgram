using RatHole_TrainingProgram.Models.Utils;

namespace RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.MuscleTagDTOs
{
    public class Update_MuscleTag_DTO
    {
        public int Id { get; set; }
        public Muscle Muscle { get; set; }
        public Muscle_Role Muscle_Role { get; set; }
        public Muscle_Involvment Muscle_Involvment { get; set; }
    }
}
