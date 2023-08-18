using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RatHole_TrainingProgram.Data;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.JointTagDTOs;
using RatHole_TrainingProgram.Models;
using RatHole_TrainingProgram.Models.ExerciseDefinitions;

namespace RatHole_TrainingProgram.Services.ExerciseDefinitions.JointTagService
{
    public class JointTagService : IJointTagService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public JointTagService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        //  GET Methods
        public async Task<ServiceResponse<Get_JointTag_DTO>> GetById(int id)
        {
            var serviceResponse = new ServiceResponse<Get_JointTag_DTO>();
            var tag = await _context.Joint_Tags.FirstOrDefaultAsync(t => t.Id == id);

            serviceResponse.Data = _mapper.Map<Get_JointTag_DTO>(tag);
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Get_JointTag_DTO>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<Get_JointTag_DTO>>();
            var tags = await _context.Joint_Tags.ToListAsync();

            serviceResponse.Data = tags.Select(t => _mapper.Map<Get_JointTag_DTO>(t)).ToList();
            return serviceResponse;
        }

        //  POST Methods
        public async Task<ServiceResponse<List<Get_JointTag_DTO>>> Add(Add_JointTag_DTO newTag)
        {
            var serviceResponse = new ServiceResponse<List<Get_JointTag_DTO>>();
            Joint_Tag tag = _mapper.Map<Joint_Tag>(newTag);

            _context.Joint_Tags.Add(tag);
            await _context.SaveChangesAsync();

            serviceResponse.Data = await _context.Joint_Tags.Select(t => _mapper.Map<Get_JointTag_DTO>(t)).ToListAsync();
            serviceResponse.Message = "Joint Tag Added.";
            return serviceResponse;
        }

        //PUT Methods
        public async Task<ServiceResponse<Get_JointTag_DTO>> Update(Update_JointTag_DTO updatedTag)
        {
            var serviceResponse = new ServiceResponse<Get_JointTag_DTO>();

            try
            {
                var tag = await _context.Joint_Tags.FirstOrDefaultAsync(t => t.Id == updatedTag.Id);

                tag.Joint_Movement = updatedTag.Joint_Movement;
                tag.Joint = updatedTag.Joint;


                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<Get_JointTag_DTO>(tag);
                serviceResponse.Message = "Joint Tag Updated.";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        //DELETE Methods
        public async Task<ServiceResponse<List<Get_JointTag_DTO>>> Delete(int id)
        {
            var serviceResponse = new ServiceResponse<List<Get_JointTag_DTO>>();

            try
            {
                var tag = await _context.Joint_Tags.FirstAsync(t => t.Id == id);

                _context.Joint_Tags.Remove(tag);
                await _context.SaveChangesAsync();

                serviceResponse.Data = await _context.Joint_Tags.Select(t => _mapper.Map<Get_JointTag_DTO>(t)).ToListAsync();
                serviceResponse.Message = "Joint Tag Deleted.";
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
