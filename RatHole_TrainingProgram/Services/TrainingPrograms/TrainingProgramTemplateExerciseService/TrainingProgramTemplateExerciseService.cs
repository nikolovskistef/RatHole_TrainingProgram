using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RatHole_TrainingProgram.Data;
using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateExercise;
using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateObjective;
using RatHole_TrainingProgram.Models;
using RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates;

namespace RatHole_TrainingProgram.Services.TrainingPrograms.TrainingProgramTemplateExerciseService
{
    public class TrainingProgramTemplateExerciseService : ITrainingProgramTemplateExerciseService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public TrainingProgramTemplateExerciseService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        //  GET Methods
        public async Task<ServiceResponse<Get_TrainingProgramTemplateExercise_DTO>> GetById(int id)
        {
            var serviceResponse = new ServiceResponse<Get_TrainingProgramTemplateExercise_DTO>();
            var exercise = await _context.trainingProgramTemplate_Exercises
                .Include(e => e.TrainingProgramTemplate_Objective)
                .Include(e => e.Exercise_Definition)
                .FirstOrDefaultAsync(e => e.Id == id);

            serviceResponse.Data = _mapper.Map<Get_TrainingProgramTemplateExercise_DTO>(exercise);
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Get_TrainingProgramTemplateExercise_DTO>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<Get_TrainingProgramTemplateExercise_DTO>>();
            var exercises = await _context.trainingProgramTemplate_Exercises
                .Include(e => e.TrainingProgramTemplate_Objective)
                .Include(e => e.Exercise_Definition)
                .ToListAsync();

            serviceResponse.Data = exercises.Select(e => _mapper.Map<Get_TrainingProgramTemplateExercise_DTO>(e)).ToList();
            return serviceResponse;

        }

        //  POST Methoids
        public async Task<ServiceResponse<Get_TrainingProgramTemplateObjective_DTO>> Add(int exerciseDefinitionId, int objectiveId, Add_TrainingProgramTemplateExercise_DTO newExercise)
        {
            var serviceResponse = new ServiceResponse<Get_TrainingProgramTemplateObjective_DTO>();

            try
            {
                //Retrieve the Objective of the Exercise
                var objective = await _context.TrainingProgramTemplate_Objectives
                    .Include(o => o.Objective_Exercises)
                    .FirstOrDefaultAsync(o => o.Id == objectiveId);
                if(objective == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Objective not found.";
                    return serviceResponse;
                }

                //Retrieve the Exercise_Definition of the Exercise
                var exerciseDefinition = await _context.Exercise_Definitions
                    .FirstOrDefaultAsync(e => e.Id == exerciseDefinitionId);
                if (exerciseDefinition == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Exercise Definition not found.";
                    return serviceResponse;
                }

                //Add the selected Exercise_Definition and Objective to the Exercise
                var exercise = _mapper.Map<TrainingProgramTemplate_Exercise>(newExercise);
                exercise.Exercise_Definition = exerciseDefinition;
                exercise.TrainingProgramTemplate_Objective = objective;

                //Add Exercise in database
                _context.Add(exercise);
                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<Get_TrainingProgramTemplateObjective_DTO>(objective);
                serviceResponse.Message = "Exercise Added.";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        //  PUT Methods
        public async Task<ServiceResponse<Get_TrainingProgramTemplateExercise_DTO>> Update(Update_TrainingProgramTemplateExercise_DTO updatedExercise)
        {
            var serviceResponse = new ServiceResponse<Get_TrainingProgramTemplateExercise_DTO>();

            try
            {
                var exercise = await _context.trainingProgramTemplate_Exercises.FirstOrDefaultAsync(e => e.Id == updatedExercise.Id);

                exercise.Method = updatedExercise.Method;
                exercise.Circuit_Number = updatedExercise.Circuit_Number;
                exercise.Position = updatedExercise.Position;

                //Not sure if this is needed
                exercise.Exercise_Definition = updatedExercise.Exercise_Definition;


                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<Get_TrainingProgramTemplateExercise_DTO>(exercise);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        //  DELETE Methods
        public async Task<ServiceResponse<List<Get_TrainingProgramTemplateExercise_DTO>>> Delete(int id)
        {
            var serviceResponse = new ServiceResponse<List<Get_TrainingProgramTemplateExercise_DTO>>();

            try
            {
                var exercise = await _context.trainingProgramTemplate_Exercises.FirstAsync(e => e.Id == id);

                _context.trainingProgramTemplate_Exercises.Remove(exercise);
                await _context.SaveChangesAsync();

                serviceResponse.Data = await _context.trainingProgramTemplate_Exercises.Select(e => _mapper.Map<Get_TrainingProgramTemplateExercise_DTO>(e)).ToListAsync();
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
