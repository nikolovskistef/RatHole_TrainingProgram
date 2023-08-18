using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RatHole_TrainingProgram.Data;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.CategoryTagDTOs;
using RatHole_TrainingProgram.Models;
using RatHole_TrainingProgram.Models.ExerciseDefinitions;

namespace RatHole_TrainingProgram.Services.ExerciseDefinitions.CategoryTagService
{
    public class CategoryTagService : ICategoryTagService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public CategoryTagService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        //  GET Methods
        public async Task<ServiceResponse<Get_CategoryTag_DTO>> GetById(int id)
        {
            var serviceResponse = new ServiceResponse<Get_CategoryTag_DTO>();
            var tag = await _context.Category_Tags.FirstOrDefaultAsync(t => t.Id == id);

            serviceResponse.Data = _mapper.Map<Get_CategoryTag_DTO>(tag);
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Get_CategoryTag_DTO>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<Get_CategoryTag_DTO>>();
            var tags = await _context.Category_Tags.ToListAsync();

            serviceResponse.Data = tags.Select(t => _mapper.Map<Get_CategoryTag_DTO>(t)).ToList();
            return serviceResponse;
        }

        //  POST Methods
        public async Task<ServiceResponse<List<Get_CategoryTag_DTO>>> Add(Add_CategoryTag_DTO newTag)
        {
            var serviceResponse = new ServiceResponse<List<Get_CategoryTag_DTO>>();
            Category_Tag tag = _mapper.Map<Category_Tag>(newTag);

            _context.Category_Tags.Add(tag);
            await _context.SaveChangesAsync();

            serviceResponse.Data = await _context.Category_Tags.Select(t => _mapper.Map<Get_CategoryTag_DTO>(t)).ToListAsync();
            serviceResponse.Message = "Category Added.";
            return serviceResponse;
        }

        //PUT Methods
        public async Task<ServiceResponse<Get_CategoryTag_DTO>> Update(Update_CategoryTag_DTO updatedTag)
        {
            var serviceResponse = new ServiceResponse<Get_CategoryTag_DTO>();

            try
            {
                var tag = await _context.Category_Tags.FirstOrDefaultAsync(t => t.Id == updatedTag.Id);

                tag.Category = updatedTag.Category;


                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<Get_CategoryTag_DTO>(tag);
                serviceResponse.Message = "Category Updated.";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        //DELETE Methods
        public async Task<ServiceResponse<List<Get_CategoryTag_DTO>>> Delete(int id)
        {
            var serviceResponse = new ServiceResponse<List<Get_CategoryTag_DTO>>();

            try
            {
                var tag = await _context.Category_Tags.FirstAsync(t => t.Id == id);

                _context.Category_Tags.Remove(tag);
                await _context.SaveChangesAsync();

                serviceResponse.Data = await _context.Category_Tags.Select(t => _mapper.Map<Get_CategoryTag_DTO>(t)).ToListAsync();
                serviceResponse.Message = "Category Deleted.";
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
