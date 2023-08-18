using Microsoft.EntityFrameworkCore;
using RatHole_TrainingProgram.Data;
using RatHole_TrainingProgram.Services.ExerciseDefinitions.CategoryTagService;
using RatHole_TrainingProgram.Services.ExerciseDefinitions.ExerciseDefinitionService;
using RatHole_TrainingProgram.Services.ExerciseDefinitions.JointTagService;
using RatHole_TrainingProgram.Services.ExerciseDefinitions.MuscleTagService;
using RatHole_TrainingProgram.Services.ExerciseDefinitions.SplitTagService;
using RatHole_TrainingProgram.Services.ExerciseDefinitions.TendonTagService;
using RatHole_TrainingProgram.Services.TrainingPrograms.TrainingProgramTemplateExerciseService;
using RatHole_TrainingProgram.Services.TrainingPrograms.TrainingProgramTemplateObjectiveService;
using RatHole_TrainingProgram.Services.TrainingPrograms.TrainingProgramTemplateService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DataContext>(options => options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 26))));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);


//Training Program
builder.Services.AddScoped<ITrainingProgramTemplateService, TrainingProgramTemplateService>();
builder.Services.AddScoped<ITrainingProgramTemplateObjectiveService, TrainingProgramTemplateObjectiveService>();
builder.Services.AddScoped<ITrainingProgramTemplateExerciseService, TrainingProgramTemplateExerciseService>();
//Exercise Definition
builder.Services.AddScoped<IExerciseDefinitionService, ExerciseDefinitionService>();
builder.Services.AddScoped<ICategoryTagService, CategoryTagService>();
builder.Services.AddScoped<ISplitTagService, SplitTagService>();
builder.Services.AddScoped<IMuscleTagService, MuscleTagService>();
builder.Services.AddScoped<IJointTagService, JointTagService>();
builder.Services.AddScoped<ITendonTagService, TendonTagService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); 
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
