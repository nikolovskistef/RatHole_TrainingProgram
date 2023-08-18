using Microsoft.EntityFrameworkCore;
using RatHole_TrainingProgram.Models.ExerciseDefinitions;
using RatHole_TrainingProgram.Models.TrainingPrograms;
using RatHole_TrainingProgram.Models.Utils;

namespace RatHole_TrainingProgram.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        
        //Seeding the database with the tags

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // CATEGORY_TAGS table seeding
            modelBuilder.Entity<Category_Tag>().HasData(
                new Category_Tag { Id = 1, Category = Exercise_Category.Strength },
                new Category_Tag { Id = 2, Category = Exercise_Category.Hyperthrophy },
                new Category_Tag { Id = 3, Category = Exercise_Category.Flexibility },
                new Category_Tag { Id = 4, Category = Exercise_Category.Mobility },
                new Category_Tag { Id = 5, Category = Exercise_Category.Speed },
                new Category_Tag { Id = 6, Category = Exercise_Category.Quickness },
                new Category_Tag { Id = 7, Category = Exercise_Category.Explosiveness },
                new Category_Tag { Id = 8, Category = Exercise_Category.Conditioning },
                new Category_Tag { Id = 9, Category = Exercise_Category.Physio }
            );

            // SPLIT_TAGS table seeding
            modelBuilder.Entity<Split_Tag>().HasData(
                new Split_Tag { Id = 1, Split = Exercise_Split.Upper_Body },
                new Split_Tag { Id = 2, Split = Exercise_Split.Lower_Body },
                new Split_Tag { Id = 3, Split = Exercise_Split.Push },
                new Split_Tag { Id = 4, Split = Exercise_Split.Pull },
                new Split_Tag { Id = 5, Split = Exercise_Split.Chest },
                new Split_Tag { Id = 6, Split = Exercise_Split.Back },
                new Split_Tag { Id = 7, Split = Exercise_Split.Arms },
                new Split_Tag { Id = 8, Split = Exercise_Split.Shoulder },
                new Split_Tag { Id = 9, Split = Exercise_Split.Legs }
            );
        }

        //Training Program Template
        public DbSet<TrainingProgram_Template> TrainingProgram_Templates { get; set; }
        public DbSet<TrainingProgramTemplate_Objective> TrainingProgramTemplate_Objectives { get; set; }
        public DbSet<TrainingProgramTemplate_Exercise> trainingProgramTemplate_Exercises { get; set; }
        //Exercise Definition
        public DbSet<Exercise_Definition> Exercise_Definitions { get; set; }
        public DbSet<Category_Tag> Category_Tags { get; set; }
        public DbSet<Split_Tag> Split_Tags { get; set; }
        public DbSet<Muscle_Tag> Muscle_Tags { get; set; }
        public DbSet<Joint_Tag> Joint_Tags { get; set; }
        public DbSet<Tendon_Tag> Tendon_Tags { get; set; }




    }
}
