using AutoMapper;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.CategoryTagDTOs;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.ExerciseDefinitionDTOs;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.JointTagDTOs;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.MuscleTagDTOs;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.SplitTagDTOs;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.TendonTagDTOs;
using RatHole_TrainingProgram.DTOs.TrainingProgramAssignmentsDTOs.TrainingProgramExercisePropertiesDropSetDTOs;
using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateDTOs.TrainingProgramTemplate;
using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateExercise;
using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateObjective;
using RatHole_TrainingProgram.Models.ExerciseDefinitions;
using RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments;
using RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates;

namespace RatHole_TrainingProgram
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {

            //Exercise Definition
            CreateMap<Exercise_Definition, Get_ExerciseDefinition_DTO>();
            CreateMap<Add_ExerciseDefinition_DTO, Exercise_Definition>();

            //Category Tag
            CreateMap<Category_Tag, Get_CategoryTag_DTO>();
            CreateMap<Add_CategoryTag_DTO, Category_Tag>();

            //Split Tag
            CreateMap<Split_Tag, Get_SplitTag_DTO>();
            CreateMap<Add_SplitTag_DTO, Split_Tag>();

            //Muscle Tag
            CreateMap<Muscle_Tag, Get_MuscleTag_DTO>();
            CreateMap<Add_MuscleTag_DTO, Muscle_Tag>();

            //Joint Tag
            CreateMap<Joint_Tag, Get_JointTag_DTO>();
            CreateMap<Add_JointTag_DTO, Joint_Tag>();

            //Tendon Tag
            CreateMap<Tendon_Tag, Get_TendonTag_DTO>();
            CreateMap<Add_TendonTag_DTO, Tendon_Tag>();

            //TRAINING PROGRAM ASSIGNMENT
            //Training Program Exercise Parameters DropSet
            CreateMap<TrainingProgramExerciseProperties_DropSet, Get_TrainingProgramExercisePropertiesDropSet_DTO >();
            CreateMap<Add_TrainingProgramExercisePropertiesDropSet_DTO, TrainingProgramExerciseProperties_DropSet>();
            //TRAINING PROGRAM TEMPLATE
            //Training Program Template
            CreateMap<TrainingProgram_Template, Get_TrainingProgramTemplate_DTO>();
            CreateMap<Add_TrainingProgramTemplate_DTO, TrainingProgram_Template>();
            //Training Program Template Objectives
            CreateMap<TrainingProgramTemplate_Objective, Get_TrainingProgramTemplateObjective_DTO>();
            CreateMap<Add_TrainingProgramTemplateObjective_DTO, TrainingProgramTemplate_Objective>();
            // Trainig Program Template Exercise
            CreateMap<TrainingProgramTemplate_Exercise, Get_TrainingProgramTemplateExercise_DTO>();
            CreateMap<Add_TrainingProgramTemplateExercise_DTO, TrainingProgramTemplate_Exercise>();
        }
    }
}
