using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.CategoryTagDTOs;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.JointTagDTOs;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.MuscleTagDTOs;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.SplitTagDTOs;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.TendonTagDTOs;
using RatHole_TrainingProgram.Models.ExerciseDefinitions;
using RatHole_TrainingProgram.Models.TrainingPrograms;

namespace RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.ExerciseDefinitionDTOs
{
    public class Get_ExerciseDefinition_DTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string URL { get; set; } = string.Empty;

        //TAGS
        public List<Get_CategoryTag_DTO> Categories { get; set; }
        public List<Get_SplitTag_DTO> Splits { get; set; }
        public List<Get_MuscleTag_DTO> Muscle_Tags { get; set; }
        public List<Get_JointTag_DTO> Joint_Tags { get; set; }
        public List<Get_TendonTag_DTO> Tendon_Tags { get; set; }

    }
}
