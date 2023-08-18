using AutoMapper;
using RatHole_TrainingProgram.Data;
using RatHole_TrainingProgram.DTOs.ExerciseDefinitionDTOs.ExerciseDefinitionDTOs;
using RatHole_TrainingProgram.Models.ExerciseDefinitions;
using RatHole_TrainingProgram.Models;
using Microsoft.EntityFrameworkCore;

namespace RatHole_TrainingProgram.Services.ExerciseDefinitions.ExerciseDefinitionService
{

    public class ExerciseDefinitionService : IExerciseDefinitionService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public ExerciseDefinitionService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        
        //GET Methods
        public async Task<ServiceResponse<Get_ExerciseDefinition_DTO>> GetById(int id)
        {
            var serviceResponse = new ServiceResponse<Get_ExerciseDefinition_DTO>();
            var definition = await _context.Exercise_Definitions
                .Include(e => e.Categories)
                .Include(e => e.Splits)
                .Include(e => e.Muscle_Tags)
                .Include(e => e.Joint_Tags)
                .Include(e => e.Tendon_Tags)
                .FirstOrDefaultAsync(d => d.Id == id);

            serviceResponse.Data = _mapper.Map<Get_ExerciseDefinition_DTO>(definition);
            return serviceResponse;
        }
        public async Task<ServiceResponse<List<Get_ExerciseDefinition_DTO>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<Get_ExerciseDefinition_DTO>>();
            var definitions = await _context.Exercise_Definitions
                .Include(e => e.Categories)
                .Include(e => e.Splits)
                .Include(e => e.Muscle_Tags)
                .Include(e => e.Joint_Tags)
                .Include(e => e.Tendon_Tags)
                .ToListAsync();

            serviceResponse.Data = definitions.Select(d => _mapper.Map<Get_ExerciseDefinition_DTO>(d)).ToList();
            return serviceResponse;
        }

        //POST Methods
        public async Task<ServiceResponse<List<Get_ExerciseDefinition_DTO>>> Add(Add_ExerciseDefinition_DTO newDefinition)
        {
            var ServiceResponse = new ServiceResponse<List<Get_ExerciseDefinition_DTO>>();
            Exercise_Definition definition = _mapper.Map<Exercise_Definition>(newDefinition);

            _context.Exercise_Definitions.Add(definition);
            await _context.SaveChangesAsync();

            ServiceResponse.Data = await _context.Exercise_Definitions.Select(d => _mapper.Map<Get_ExerciseDefinition_DTO>(d)).ToListAsync();
            return ServiceResponse;
        }

        //PUT Methods
        public async Task<ServiceResponse<Get_ExerciseDefinition_DTO>> Update(Update_ExerciseDefinition_DTO updatedDefinition)
        {
            var serviceResponse = new ServiceResponse<Get_ExerciseDefinition_DTO>();

            try
            {
                var definition = await _context.Exercise_Definitions.FirstOrDefaultAsync(o => o.Id == updatedDefinition.Id);

                definition.Name = updatedDefinition.Name;
                definition.Description = updatedDefinition.Description;
                definition.URL = updatedDefinition.URL;

                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<Get_ExerciseDefinition_DTO>(definition);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        //DELETE Methods
        public async Task<ServiceResponse<List<Get_ExerciseDefinition_DTO>>> Delete(int id)
        {
            var serviceResponse = new ServiceResponse<List<Get_ExerciseDefinition_DTO>>();

            try
            {
                var definition = await _context.Exercise_Definitions.FirstAsync(d => d.Id == id);

                _context.Exercise_Definitions.Remove(definition);
                await _context.SaveChangesAsync();

                serviceResponse.Data = await _context.Exercise_Definitions.Select(d => _mapper.Map<Get_ExerciseDefinition_DTO>(d)).ToListAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        //ADD Exercise Definition Tags
        public async Task<ServiceResponse<Get_ExerciseDefinition_DTO>> AddExerciseDefinitionCategory(Add_ExerciseDefinitionCategory_DTO newCategory)
        {
            var serviceResponse = new ServiceResponse<Get_ExerciseDefinition_DTO>();

            try
            {
                var exerciseDefinition = await _context.Exercise_Definitions
                .Include(e => e.Categories)
                .Include(e => e.Splits)
                .Include(e => e.Muscle_Tags)
                .Include(e => e.Joint_Tags)
                .Include(e => e.Tendon_Tags)
                .FirstOrDefaultAsync(e => e.Id == newCategory.ExerciseDefinition_Id);

                if (exerciseDefinition == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Exercise Definition not found.";
                    return serviceResponse;
                }

                var category = await _context.Category_Tags.FirstOrDefaultAsync(c => c.Id == newCategory.Category_Id);

                if (category == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Category not found.";
                    return serviceResponse;
                }

                exerciseDefinition.Categories.Add(category);
                await _context.SaveChangesAsync();
                serviceResponse.Data = _mapper.Map<Get_ExerciseDefinition_DTO>(exerciseDefinition);
                serviceResponse.Message = "Category Added.";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<Get_ExerciseDefinition_DTO>> AddExerciseDefinitionSplit(Add_ExerciseDefinitionSplit_DTO newSplit)
        {
            var serviceResponse = new ServiceResponse<Get_ExerciseDefinition_DTO>();

            try
            {
                var exerciseDefinition = await _context.Exercise_Definitions
                .Include(e => e.Categories)
                .Include(e => e.Splits)
                .Include(e => e.Muscle_Tags)
                .Include(e => e.Joint_Tags)
                .Include(e => e.Tendon_Tags)
                .FirstOrDefaultAsync(e => e.Id == newSplit.ExerciseDefinition_Id);

                if (exerciseDefinition == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Exercise Definition not found.";
                    return serviceResponse;
                }

                var split = await _context.Split_Tags.FirstOrDefaultAsync(c => c.Id == newSplit.Split_Id);

                if (split == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Split not found.";
                    return serviceResponse;
                }

                exerciseDefinition.Splits.Add(split);
                await _context.SaveChangesAsync();
                serviceResponse.Data = _mapper.Map<Get_ExerciseDefinition_DTO>(exerciseDefinition);
                serviceResponse.Message = "Split Added.";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<Get_ExerciseDefinition_DTO>> AddExerciseDefinitionMuscleTag(Add_ExerciseDefinitionMuscleTag_DTO newTag)
        {
            var serviceResponse = new ServiceResponse<Get_ExerciseDefinition_DTO>();

            try
            {
                var exerciseDefinition = await _context.Exercise_Definitions
                .Include(e => e.Categories)
                .Include(e => e.Splits)
                .Include(e => e.Muscle_Tags)
                .Include(e => e.Joint_Tags)
                .Include(e => e.Tendon_Tags)
                .FirstOrDefaultAsync(e => e.Id == newTag.ExerciseDefinition_Id);

                if (exerciseDefinition == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Exercise Definition not found.";
                    return serviceResponse;
                }

                var tag = await _context.Muscle_Tags.FirstOrDefaultAsync(t => t.Id == newTag.MuslceTag_Id);

                if (tag == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Muscle Tag not found.";
                    return serviceResponse;
                }

                exerciseDefinition.Muscle_Tags.Add(tag);
                await _context.SaveChangesAsync();
                serviceResponse.Data = _mapper.Map<Get_ExerciseDefinition_DTO>(exerciseDefinition);
                serviceResponse.Message = "Muscle Tag Added.";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<Get_ExerciseDefinition_DTO>> AddExerciseDefinitionJointTag(Add_ExerciseDefinitionJointTag_DTO newTag)
        {
            var serviceResponse = new ServiceResponse<Get_ExerciseDefinition_DTO>();

            try
            {
                var exerciseDefinition = await _context.Exercise_Definitions
                .Include(e => e.Categories)
                .Include(e => e.Splits)
                .Include(e => e.Muscle_Tags)
                .Include(e => e.Joint_Tags)
                .Include(e => e.Tendon_Tags)
                .FirstOrDefaultAsync(e => e.Id == newTag.ExerciseDefinition_Id);

                if (exerciseDefinition == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Exercise Definition not found.";
                    return serviceResponse;
                }

                var tag = await _context.Joint_Tags.FirstOrDefaultAsync(t => t.Id == newTag.JointTag_Id);

                if (tag == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Joint Tag not found.";
                    return serviceResponse;
                }

                exerciseDefinition.Joint_Tags.Add(tag);
                await _context.SaveChangesAsync();
                serviceResponse.Data = _mapper.Map<Get_ExerciseDefinition_DTO>(exerciseDefinition);
                serviceResponse.Message = "Joint Tag Added.";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<Get_ExerciseDefinition_DTO>> AddExerciseDefinitionTendonTag(Add_ExerciseDefinitionTendonTag_DTO newTag)
        {
            var serviceResponse = new ServiceResponse<Get_ExerciseDefinition_DTO>();

            try
            {
                var exerciseDefinition = await _context.Exercise_Definitions
                .Include(e => e.Categories)
                .Include(e => e.Splits)
                .Include(e => e.Muscle_Tags)
                .Include(e => e.Joint_Tags)
                .Include(e => e.Tendon_Tags)
                .FirstOrDefaultAsync(e => e.Id == newTag.ExerciseDefinition_Id);

                if (exerciseDefinition == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Exercise Definition not found.";
                    return serviceResponse;
                }

                var tag = await _context.Tendon_Tags.FirstOrDefaultAsync(t => t.Id == newTag.TendonTag_Id);

                if (tag == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Tendon Tag not found.";
                    return serviceResponse;
                }

                exerciseDefinition.Tendon_Tags.Add(tag);
                await _context.SaveChangesAsync();
                serviceResponse.Data = _mapper.Map<Get_ExerciseDefinition_DTO>(exerciseDefinition);
                serviceResponse.Message = "Tendon Tag Added.";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }


        // DELETE Exercise Definition Tags
        public async Task<ServiceResponse<Get_ExerciseDefinition_DTO>> DeleteExerciseDefinitionCategory(int exerciseDefinitionId, int categoryId)
        {
            var serviceResponse = new ServiceResponse<Get_ExerciseDefinition_DTO>();

            try
            {
                var exerciseDefinition = await _context.Exercise_Definitions
                .Include(e => e.Categories)
                .Include(e => e.Splits)
                .Include(e => e.Muscle_Tags)
                .Include(e => e.Joint_Tags)
                .Include(e => e.Tendon_Tags)
                .FirstOrDefaultAsync(e => e.Id == exerciseDefinitionId);

                if (exerciseDefinition == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Exercise Definition not found.";
                    return serviceResponse;
                }

                var category = exerciseDefinition.Categories.FirstOrDefault(c => c.Id == categoryId);

                if (category == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Category not found.";
                    return serviceResponse;
                }

                exerciseDefinition.Categories.Remove(category);
                await _context.SaveChangesAsync();
                serviceResponse.Data = _mapper.Map<Get_ExerciseDefinition_DTO>(exerciseDefinition);
                serviceResponse.Message = "Category Removed.";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<Get_ExerciseDefinition_DTO>> DeleteExerciseDefinitionSplit(int exerciseDefinitionId, int splitId)
        {
        var serviceResponse = new ServiceResponse<Get_ExerciseDefinition_DTO>();

        try
        {
            var exerciseDefinition = await _context.Exercise_Definitions
            .Include(e => e.Categories)
            .Include(e => e.Splits)
            .Include(e => e.Muscle_Tags)
            .Include(e => e.Joint_Tags)
            .Include(e => e.Tendon_Tags)
            .FirstOrDefaultAsync(e => e.Id == exerciseDefinitionId);

            if (exerciseDefinition == null)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Exercise Definition not found.";
                return serviceResponse;
            }

            var split  = exerciseDefinition.Splits.FirstOrDefault(s => s.Id == splitId);

            if (split == null)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Split not found.";
                return serviceResponse;
            }

            exerciseDefinition.Splits.Remove(split);
            await _context.SaveChangesAsync();
            serviceResponse.Data = _mapper.Map<Get_ExerciseDefinition_DTO>(exerciseDefinition);
            serviceResponse.Message = "Split Removed.";
        }
        catch (Exception ex)
        {
            serviceResponse.Success = false;
            serviceResponse.Message = ex.Message;
        }
        return serviceResponse;
    }

        public async Task<ServiceResponse<Get_ExerciseDefinition_DTO>> DeleteExerciseDefinitionMuscleTag(int exerciseDefinitionId, int tagId)
        {
            var serviceResponse = new ServiceResponse<Get_ExerciseDefinition_DTO>();

            try
            {
                var exerciseDefinition = await _context.Exercise_Definitions
                .Include(e => e.Categories)
                .Include(e => e.Splits)
                .Include(e => e.Muscle_Tags)
                .Include(e => e.Joint_Tags)
                .Include(e => e.Tendon_Tags)
                .FirstOrDefaultAsync(e => e.Id == exerciseDefinitionId);

                if (exerciseDefinition == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Exercise Definition not found.";
                    return serviceResponse;
                }

                var tag =  exerciseDefinition.Muscle_Tags.FirstOrDefault(t => t.Id == tagId);

                if (tag == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Muscle Tag not found.";
                    return serviceResponse;
                }

                exerciseDefinition.Muscle_Tags.Remove(tag);
                await _context.SaveChangesAsync();
                serviceResponse.Data = _mapper.Map<Get_ExerciseDefinition_DTO>(exerciseDefinition);
                serviceResponse.Message = "Muscle Tag Removed.";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<Get_ExerciseDefinition_DTO>> DeleteExerciseDefinitionJointTag(int exerciseDefinitionId, int tagId)
        {
            var serviceResponse = new ServiceResponse<Get_ExerciseDefinition_DTO>();

            try
            {
                var exerciseDefinition = await _context.Exercise_Definitions
                .Include(e => e.Categories)
                .Include(e => e.Splits)
                .Include(e => e.Muscle_Tags)
                .Include(e => e.Joint_Tags)
                .Include(e => e.Tendon_Tags)
                .FirstOrDefaultAsync(e => e.Id == exerciseDefinitionId);

                if (exerciseDefinition == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Exercise Definition not found.";
                    return serviceResponse;
                }

                var tag = exerciseDefinition.Joint_Tags.FirstOrDefault(t => t.Id == tagId);

                if (tag == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Joint Tag not found.";
                    return serviceResponse;
                }

                exerciseDefinition.Joint_Tags.Remove(tag);
                await _context.SaveChangesAsync();
                serviceResponse.Data = _mapper.Map<Get_ExerciseDefinition_DTO>(exerciseDefinition);
                serviceResponse.Message = "Joint Tag Removed.";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<Get_ExerciseDefinition_DTO>> DeleteExerciseDefinitionTendonTag(int exerciseDefinitionId, int tagId)
        {
            var serviceResponse = new ServiceResponse<Get_ExerciseDefinition_DTO>();

            try
            {
                var exerciseDefinition = await _context.Exercise_Definitions
                .Include(e => e.Categories)
                .Include(e => e.Splits)
                .Include(e => e.Muscle_Tags)
                .Include(e => e.Joint_Tags)
                .Include(e => e.Tendon_Tags)
                .FirstOrDefaultAsync(e => e.Id == exerciseDefinitionId);

                if (exerciseDefinition == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Exercise Definition not found.";
                    return serviceResponse;
                }

                var tag = exerciseDefinition.Tendon_Tags.FirstOrDefault(t => t.Id == tagId);

                if (tag == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Tendon Tag not found.";
                    return serviceResponse;
                }

                exerciseDefinition.Tendon_Tags.Remove(tag);
                await _context.SaveChangesAsync();
                serviceResponse.Data = _mapper.Map<Get_ExerciseDefinition_DTO>(exerciseDefinition);
                serviceResponse.Message = "Tendon Tag Removed.";
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
