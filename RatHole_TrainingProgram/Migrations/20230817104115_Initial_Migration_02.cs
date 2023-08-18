using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RatHole_TrainingProgram.Migrations
{
    /// <inheritdoc />
    public partial class Initial_Migration_02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Exercise_DefinitionId",
                table: "trainingProgramTemplate_Exercises",
                newName: "ExerciseId");

            migrationBuilder.RenameIndex(
                name: "IX_trainingProgramTemplate_Exercises_Exercise_DefinitionId",
                table: "trainingProgramTemplate_Exercises",
                newName: "IX_trainingProgramTemplate_Exercises_ExerciseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExerciseId",
                table: "trainingProgramTemplate_Exercises",
                newName: "Exercise_DefinitionId");

            migrationBuilder.RenameIndex(
                name: "IX_trainingProgramTemplate_Exercises_ExerciseId",
                table: "trainingProgramTemplate_Exercises",
                newName: "IX_trainingProgramTemplate_Exercises_Exercise_DefinitionId");
        }
    }
}
