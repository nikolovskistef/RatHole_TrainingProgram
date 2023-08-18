﻿using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateObjective;
using RatHole_TrainingProgram.Models.TrainingPrograms;

namespace RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplate
{
    public class Get_TrainingProgramTemplate_DTO
    {
        public string Name { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public int Duration_In_Days { get; set; }

        public DateTime Date_Created { get; set; }

        public List<Get_TrainingProgramTemplateObjective_DTO> Objectives { get; set; }
    }
}
