using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RatHole_TrainingProgram.Data;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.SplitTagDTOs;
using RatHole_TrainingProgram.Models;
using RatHole_TrainingProgram.Models.ExerciseDefinitions;

namespace RatHole_TrainingProgram.Services.ExerciseDefinitions.SplitTagService
{
    public class SplitTagService : ISplitTagService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public SplitTagService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        //  GET Methods
        public async Task<ServiceResponse<Get_SplitTag_DTO>> GetById(int id)
        {
            var serviceResponse = new ServiceResponse<Get_SplitTag_DTO>();
            var tag = await _context.Split_Tags.FirstOrDefaultAsync(t => t.Id == id);

            serviceResponse.Data = _mapper.Map<Get_SplitTag_DTO>(tag);
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Get_SplitTag_DTO>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<Get_SplitTag_DTO>>();
            var tags = await _context.Split_Tags.ToListAsync();

            serviceResponse.Data = tags.Select(t => _mapper.Map<Get_SplitTag_DTO>(t)).ToList();
            return serviceResponse;
        }

        //  POST Methods
        public async Task<ServiceResponse<List<Get_SplitTag_DTO>>> Add(Add_SplitTag_DTO newTag)
        {
            var serviceResponse = new ServiceResponse<List<Get_SplitTag_DTO>>();
            Split_Tag tag = _mapper.Map<Split_Tag>(newTag);

            _context.Split_Tags.Add(tag);
            await _context.SaveChangesAsync();

            serviceResponse.Data = await _context.Split_Tags.Select(t => _mapper.Map<Get_SplitTag_DTO>(t)).ToListAsync();
            serviceResponse.Message = "Splits Added";
            return serviceResponse;
        }

        //PUT Methods
        public async Task<ServiceResponse<Get_SplitTag_DTO>> Update(Update_SplitTag_DTO updatedTag)
        {
            var serviceResponse = new ServiceResponse<Get_SplitTag_DTO>();

            try
            {
                var tag = await _context.Split_Tags.FirstOrDefaultAsync(t => t.Id == updatedTag.Id);

                tag.Split = updatedTag.Split;


                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<Get_SplitTag_DTO>(tag);
                serviceResponse.Message = "Splits Updated";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        //DELETE Methods
        public async Task<ServiceResponse<List<Get_SplitTag_DTO>>> Delete(int id)
        {
            var serviceResponse = new ServiceResponse<List<Get_SplitTag_DTO>>();

            try
            {
                var tag = await _context.Split_Tags.FirstAsync(t => t.Id == id);

                _context.Split_Tags.Remove(tag);
                await _context.SaveChangesAsync();

                serviceResponse.Data = await _context.Split_Tags.Select(t => _mapper.Map<Get_SplitTag_DTO>(t)).ToListAsync();
                serviceResponse.Message = "Splits Deleted.";
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
