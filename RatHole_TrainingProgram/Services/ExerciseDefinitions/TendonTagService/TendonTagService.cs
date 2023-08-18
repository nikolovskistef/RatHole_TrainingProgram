using AutoMapper;
using RatHole_TrainingProgram.Data;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.CategoryTagDTOs;
using RatHole_TrainingProgram.Models.ExerciseDefinitions;
using RatHole_TrainingProgram.Models;
using Microsoft.EntityFrameworkCore;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.TendonTagDTOs;

namespace RatHole_TrainingProgram.Services.ExerciseDefinitions.TendonTagService
{
    public class TendonTagService : ITendonTagService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public TendonTagService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        //  GET Methods
        public async Task<ServiceResponse<Get_TendonTag_DTO>> GetById(int id)
        {
            var serviceResponse = new ServiceResponse<Get_TendonTag_DTO>();
            var tag = await _context.Tendon_Tags.FirstOrDefaultAsync(t => t.Id == id);

            serviceResponse.Data = _mapper.Map<Get_TendonTag_DTO>(tag);
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Get_TendonTag_DTO>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<Get_TendonTag_DTO>>();
            var tags = await _context.Tendon_Tags.ToListAsync();

            serviceResponse.Data = tags.Select(t => _mapper.Map<Get_TendonTag_DTO>(t)).ToList();
            return serviceResponse;
        }

        //  POST Methods
        public async Task<ServiceResponse<List<Get_TendonTag_DTO>>> Add(Add_TendonTag_DTO newTag)
        {
            var serviceResponse = new ServiceResponse<List<Get_TendonTag_DTO>>();
            Tendon_Tag tag = _mapper.Map<Tendon_Tag>(newTag);

            _context.Tendon_Tags.Add(tag);
            await _context.SaveChangesAsync();

            serviceResponse.Data = await _context.Tendon_Tags.Select(t => _mapper.Map<Get_TendonTag_DTO>(t)).ToListAsync();
            serviceResponse.Message = "Tendon Tag Added.";
            return serviceResponse;
        }

        //PUT Methods
        public async Task<ServiceResponse<Get_TendonTag_DTO>> Update(Update_TendonTag_DTO updatedTag)
        {
            var serviceResponse = new ServiceResponse<Get_TendonTag_DTO>();

            try
            {
                var tag = await _context.Tendon_Tags.FirstOrDefaultAsync(t => t.Id == updatedTag.Id);

                tag.Tendon = updatedTag.Tendon;


                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<Get_TendonTag_DTO>(tag);
                serviceResponse.Message = "Tendon Tag Updated.";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        //DELETE Methods
        public async Task<ServiceResponse<List<Get_TendonTag_DTO>>> Delete(int id)
        {
            var serviceResponse = new ServiceResponse<List<Get_TendonTag_DTO>>();

            try
            {
                var tag = await _context.Tendon_Tags.FirstAsync(t => t.Id == id);

                _context.Tendon_Tags.Remove(tag);
                await _context.SaveChangesAsync();

                serviceResponse.Data = await _context.Tendon_Tags.Select(t => _mapper.Map<Get_TendonTag_DTO>(t)).ToListAsync();
                serviceResponse.Message = "Tendon Tag Deleted.";
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
