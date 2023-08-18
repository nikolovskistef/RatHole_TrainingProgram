using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RatHole_TrainingProgram.Data;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.MuscleTagDTOs;
using RatHole_TrainingProgram.Models;
using RatHole_TrainingProgram.Models.ExerciseDefinitions;

namespace RatHole_TrainingProgram.Services.ExerciseDefinitions.MuscleTagService
{
    public class MuscleTagService : IMuscleTagService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public MuscleTagService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        //  GET Methods
        public async Task<ServiceResponse<Get_MuscleTag_DTO>> GetById(int id)
        {
            var serviceResponse = new ServiceResponse<Get_MuscleTag_DTO>();
            var tag = await _context.Muscle_Tags.FirstOrDefaultAsync(t => t.Id == id);

            serviceResponse.Data = _mapper.Map<Get_MuscleTag_DTO>(tag);
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Get_MuscleTag_DTO>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<Get_MuscleTag_DTO>>();
            var tags = await _context.Muscle_Tags.ToListAsync();

            serviceResponse.Data = tags.Select(t => _mapper.Map<Get_MuscleTag_DTO>(t)).ToList();
            return serviceResponse;
        }

        //  POST Methods
        public async Task<ServiceResponse<List<Get_MuscleTag_DTO>>> Add(Add_MuscleTag_DTO newTag)
        {
            var serviceResponse = new ServiceResponse<List<Get_MuscleTag_DTO>>();
            Muscle_Tag tag = _mapper.Map<Muscle_Tag>(newTag);

            _context.Muscle_Tags.Add(tag);
            await _context.SaveChangesAsync();

            serviceResponse.Data = await _context.Muscle_Tags.Select(t => _mapper.Map<Get_MuscleTag_DTO>(t)).ToListAsync();
            serviceResponse.Message = "Muscle Tag Added.";
            return serviceResponse;
        }

        //PUT Methods
        public async Task<ServiceResponse<Get_MuscleTag_DTO>> Update(Update_MuscleTag_DTO updatedTag)
        {
            var serviceResponse = new ServiceResponse<Get_MuscleTag_DTO>();

            try
            {
                var tag = await _context.Muscle_Tags.FirstOrDefaultAsync(t => t.Id == updatedTag.Id);

                tag.Muscle = updatedTag.Muscle;
                tag.Muscle_Role = updatedTag.Muscle_Role;
                tag.Muscle_Involvment = updatedTag.Muscle_Involvment;
                

                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<Get_MuscleTag_DTO>(tag);
                serviceResponse.Message = "Muscle Tag Updated.";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        //DELETE Methods
        public async Task<ServiceResponse<List<Get_MuscleTag_DTO>>> Delete(int id)
        {
            var serviceResponse = new ServiceResponse<List<Get_MuscleTag_DTO>>();

            try
            {
                var tag = await _context.Muscle_Tags.FirstAsync(t => t.Id == id);

                _context.Muscle_Tags.Remove(tag);
                await _context.SaveChangesAsync();

                serviceResponse.Data = await _context.Muscle_Tags.Select(t => _mapper.Map<Get_MuscleTag_DTO>(t)).ToListAsync();
                serviceResponse.Message = "Muscle Tag Deleted.";
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
