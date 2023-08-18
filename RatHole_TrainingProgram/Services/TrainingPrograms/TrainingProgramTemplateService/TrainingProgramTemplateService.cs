using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RatHole_TrainingProgram.Data;
using RatHole_TrainingProgram.DTOs.TrainingProgramDTOs.TrainingProgramTemplate;
using RatHole_TrainingProgram.Models;
using RatHole_TrainingProgram.Models.TrainingPrograms;

namespace RatHole_TrainingProgram.Services.TrainingPrograms.TrainingProgramTemplateService
{
    public class TrainingProgramTemplateService : ITrainingProgramTemplateService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public TrainingProgramTemplateService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        //GET Methods
        public async Task<ServiceResponse<Get_TrainingProgramTemplate_DTO>> GetById(int id)
        {
            var serviceResponse = new ServiceResponse<Get_TrainingProgramTemplate_DTO>();
            var trainingProgram = await _context.TrainingProgram_Templates
                .Include(p => p.Objectives)
                .FirstOrDefaultAsync(p => p.Id == id);

            serviceResponse.Data = _mapper.Map<Get_TrainingProgramTemplate_DTO>(trainingProgram);
            return serviceResponse;

        }

        public async Task<ServiceResponse<List<Get_TrainingProgramTemplate_DTO>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<Get_TrainingProgramTemplate_DTO>>();
            var trainingPrograms = await _context.TrainingProgram_Templates
                .Include(p => p.Objectives)
                .ToListAsync();

            serviceResponse.Data = trainingPrograms.Select(p => _mapper.Map<Get_TrainingProgramTemplate_DTO>(p)).ToList();
            return serviceResponse;
        }

        //POST Methods
        public async Task<ServiceResponse<List<Get_TrainingProgramTemplate_DTO>>> Add(Add_TrainingProgramTemplate_DTO newTrainigProgram)
        {
            var serviceResponse = new ServiceResponse<List<Get_TrainingProgramTemplate_DTO>>();
            TrainingProgram_Template trainingProgram = _mapper.Map<TrainingProgram_Template>(newTrainigProgram);

            _context.TrainingProgram_Templates.Add(trainingProgram);
            await _context.SaveChangesAsync();

            serviceResponse.Data = await _context.TrainingProgram_Templates.Select(p => _mapper.Map<Get_TrainingProgramTemplate_DTO>(p)).ToListAsync();
            serviceResponse.Message = "Training Program Added.";
            return serviceResponse;
        }


        //PUT Methods
        public async Task<ServiceResponse<Get_TrainingProgramTemplate_DTO>> Update(Update_TrainingProgramTemplate_DTO updatedTrainingProgram)
        {
            var serviceResponse = new ServiceResponse<Get_TrainingProgramTemplate_DTO>();
            try
            {
                var trainingProgram = await _context.TrainingProgram_Templates.FirstOrDefaultAsync(p => p.Id == updatedTrainingProgram.Id);

                trainingProgram.Name = updatedTrainingProgram.Name;
                trainingProgram.Details = updatedTrainingProgram.Details;
                trainingProgram.Duration_In_Days = updatedTrainingProgram.Duration_In_Days;
                trainingProgram.Date_Created = updatedTrainingProgram.Date_Created;

                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<Get_TrainingProgramTemplate_DTO>(trainingProgram);
                serviceResponse.Message = "Training Program Updated.";

            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        //DELETE Methods
        public async Task<ServiceResponse<List<Get_TrainingProgramTemplate_DTO>>> Delete(int id)
        {
            var serviceResponse = new ServiceResponse<List<Get_TrainingProgramTemplate_DTO>>();
            try
            {
                var trainingProgram = await _context.TrainingProgram_Templates.FirstAsync(p => p.Id == id);

                _context.TrainingProgram_Templates.Remove(trainingProgram);
                await _context.SaveChangesAsync();


                serviceResponse.Data = await _context.TrainingProgram_Templates.Select(p => _mapper.Map<Get_TrainingProgramTemplate_DTO>(p)).ToListAsync();
                serviceResponse.Message = "Training Program Deleted.";

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
