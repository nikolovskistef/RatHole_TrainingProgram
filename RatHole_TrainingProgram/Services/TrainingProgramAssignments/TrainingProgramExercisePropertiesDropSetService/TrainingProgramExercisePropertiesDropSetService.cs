using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RatHole_TrainingProgram.Data;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.JointTagDTOs;
using RatHole_TrainingProgram.DTOs.TrainingProgramAssignmentsDTOs.TrainingProgramExercisePropertiesDropSetDTOs;
using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateExercise;
using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateObjective;
using RatHole_TrainingProgram.Models;
using RatHole_TrainingProgram.Models.ExerciseDefinitions;
using RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments;
using RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates;

namespace RatHole_TrainingProgram.Services.TrainingProgramAssignments.TrainingProgramExercisePropertiesDropSetService
{
    public class TrainingProgramExercisePropertiesDropSetService : ITrainingProgramExercisePropertiesDropSetService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public TrainingProgramExercisePropertiesDropSetService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        //  GET Methods
        public async Task<ServiceResponse<Get_TrainingProgramExercisePropertiesDropSet_DTO>> GetById(int id)
        {
            var serviceResponse = new ServiceResponse<Get_TrainingProgramExercisePropertiesDropSet_DTO>();
            var dropSetProperties = await _context.TrainingProgramExerciseProperties_DropSets
                .FirstOrDefaultAsync(d => d.Id == id);

            serviceResponse.Data = _mapper.Map<Get_TrainingProgramExercisePropertiesDropSet_DTO>(dropSetProperties);
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Get_TrainingProgramExercisePropertiesDropSet_DTO>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<Get_TrainingProgramExercisePropertiesDropSet_DTO>>();
            var dropSetProperties = await _context.TrainingProgramExerciseProperties_DropSets
                .ToListAsync();

            serviceResponse.Data = dropSetProperties.Select(d => _mapper.Map<Get_TrainingProgramExercisePropertiesDropSet_DTO>(d)).ToList();
            return serviceResponse;

        }

        //  POST Methods
        public async Task<ServiceResponse<List<Get_TrainingProgramExercisePropertiesDropSet_DTO>>> Add(Add_TrainingProgramExercisePropertiesDropSet_DTO newDropSetProperties)
        {
            var serviceResponse = new ServiceResponse<List<Get_TrainingProgramExercisePropertiesDropSet_DTO>>();
            TrainingProgramExerciseProperties_DropSet dropSetProperties = _mapper.Map<TrainingProgramExerciseProperties_DropSet>(newDropSetProperties);

            _context.TrainingProgramExerciseProperties_DropSets.Add(dropSetProperties);
            await _context.SaveChangesAsync();

            serviceResponse.Data = await _context.TrainingProgramExerciseProperties_DropSets.Select(d => _mapper.Map<Get_TrainingProgramExercisePropertiesDropSet_DTO>(d)).ToListAsync();
            serviceResponse.Message = "Properties Added.";
            return serviceResponse;
        }

        //  PUT Methods
        public async Task<ServiceResponse<Get_TrainingProgramExercisePropertiesDropSet_DTO>> Update(Update_TrainingProgramExercisePropertiesDropSet_DTO updatedDropSetProperties)
        {
            var serviceResponse = new ServiceResponse<Get_TrainingProgramExercisePropertiesDropSet_DTO>();

            try
            {
                var dropSetProperties = await _context.TrainingProgramExerciseProperties_DropSets.FirstOrDefaultAsync(d => d.Id == updatedDropSetProperties.Id);

                dropSetProperties.DropSet_Offset = updatedDropSetProperties.DropSet_Offset;
                dropSetProperties.DropSet_Count = updatedDropSetProperties.DropSet_Count;

                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<Get_TrainingProgramExercisePropertiesDropSet_DTO>(dropSetProperties);
                serviceResponse.Message = "Propeerties Updated.";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        //  DELETE Methods
        public async Task<ServiceResponse<List<Get_TrainingProgramExercisePropertiesDropSet_DTO>>> Delete(int id)
        {
            var serviceResponse = new ServiceResponse<List<Get_TrainingProgramExercisePropertiesDropSet_DTO>>();

            try
            {
                var dropSetProperties = await _context.TrainingProgramExerciseProperties_DropSets.FirstAsync(d => d.Id == id);

                _context.TrainingProgramExerciseProperties_DropSets.Remove(dropSetProperties);
                await _context.SaveChangesAsync();

                serviceResponse.Data = await _context.TrainingProgramExerciseProperties_DropSets.Select(d => _mapper
                                                                                                                    .Map<Get_TrainingProgramExercisePropertiesDropSet_DTO>(d))
                                                                                                                    .ToListAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }
}
