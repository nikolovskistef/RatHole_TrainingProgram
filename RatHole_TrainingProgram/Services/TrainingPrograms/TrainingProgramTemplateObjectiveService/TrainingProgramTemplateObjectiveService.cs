using AutoMapper;
using RatHole_TrainingProgram.Data;
using RatHole_TrainingProgram.Models;
using Microsoft.EntityFrameworkCore;
using RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates;
using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateDTOs.TrainingProgramTemplate;
using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplateObjective;

namespace RatHole_TrainingProgram.Services.TrainingPrograms.TrainingProgramTemplateObjectiveService
{
    public class TrainingProgramTemplateObjectiveService : ITrainingProgramTemplateObjectiveService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public TrainingProgramTemplateObjectiveService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        //  GET Methods
        public async Task<ServiceResponse<Get_TrainingProgramTemplateObjective_DTO>> GetById(int id)
        {
            var serviceResponse = new ServiceResponse<Get_TrainingProgramTemplateObjective_DTO>();
            var objective = await _context.TrainingProgramTemplate_Objectives
                .Include(o => o.Objective_Exercises)
                .FirstOrDefaultAsync(o => o.Id == id);

            serviceResponse.Data = _mapper.Map<Get_TrainingProgramTemplateObjective_DTO>(objective);
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Get_TrainingProgramTemplateObjective_DTO>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<Get_TrainingProgramTemplateObjective_DTO>>();
            var objectives = await _context.TrainingProgramTemplate_Objectives
                .Include(o => o.Objective_Exercises)
                .ToListAsync();

            serviceResponse.Data = objectives.Select(o => _mapper.Map<Get_TrainingProgramTemplateObjective_DTO>(o)).ToList();
            return serviceResponse;

        }

        //  POST Methoids
        public async Task<ServiceResponse<Get_TrainingProgramTemplate_DTO>> Add(int trainingProgramTemplateId , Add_TrainingProgramTemplateObjective_DTO newObjective)
        {
            var serviceResponse = new ServiceResponse<Get_TrainingProgramTemplate_DTO>();

            var trainingProgram = await _context.TrainingProgram_Templates
            .Include(t => t.Objectives)
            .FirstOrDefaultAsync(t => t.Id == trainingProgramTemplateId);

            if (trainingProgram == null)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Training Program not found.";
                return serviceResponse;
            }

            TrainingProgramTemplate_Objective objective = _mapper.Map<TrainingProgramTemplate_Objective>(newObjective);
            objective.TrainingProgram_Template = trainingProgram;

            _context.Add(objective);
            await _context.SaveChangesAsync();

            var newTrainingProgram = await _context.TrainingProgram_Templates
            .Include(t => t.Objectives)
            .FirstOrDefaultAsync(t => t.Id == trainingProgramTemplateId);

            serviceResponse.Data = _mapper.Map<Get_TrainingProgramTemplate_DTO>(newTrainingProgram);
            serviceResponse.Message = "Objective Added.";
            return serviceResponse;

        }

        //  PUT Methods
        public async Task<ServiceResponse<Get_TrainingProgramTemplateObjective_DTO>> Update(Update_TrainingProgramTemplateObjective_DTO updatedObjective)
        {
            var serviceResponse = new ServiceResponse<Get_TrainingProgramTemplateObjective_DTO>();

            try
            {
                var objective = await _context.TrainingProgramTemplate_Objectives.FirstOrDefaultAsync(o => o.Id == updatedObjective.Id);

                objective.Name = updatedObjective.Name;
                objective.Details = updatedObjective.Details;
                //objective.Objective_Exercises = updatedObjective.Objective_Exercises;

                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<Get_TrainingProgramTemplateObjective_DTO>(objective);
                serviceResponse.Message = "Objective Updated.";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        //  DELETE Methods
        public async Task<ServiceResponse<List<Get_TrainingProgramTemplateObjective_DTO>>> Delete(int id)
        {
            var serviceResponse = new ServiceResponse<List<Get_TrainingProgramTemplateObjective_DTO>>();

            try
            {
                var objective = await _context.TrainingProgramTemplate_Objectives.FirstAsync(o => o.Id == id);

                _context.TrainingProgramTemplate_Objectives.Remove(objective);
                await _context.SaveChangesAsync();

                serviceResponse.Data = await _context.TrainingProgramTemplate_Objectives.Select(o => _mapper.Map<Get_TrainingProgramTemplateObjective_DTO>(o)).ToListAsync();
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
