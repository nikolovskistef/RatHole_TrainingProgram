using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RatHole_TrainingProgram.Migrations
{
    /// <inheritdoc />
    public partial class AddTrainingPropgramAssignmentTables_01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingProgramTemplate_Objectives_TrainingProgram_Templates~",
                table: "TrainingProgramTemplate_Objectives");

            migrationBuilder.DropTable(
                name: "TrainingProgram_Templates");

            migrationBuilder.CreateTable(
                name: "TrainingProgram_Assignment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Assigned_From = table.Column<int>(type: "int", nullable: false),
                    Assigned_To = table.Column<int>(type: "int", nullable: false),
                    Assign_StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Assign_EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgram_Assignment", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TrainingProgram_Template",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Details = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Duration_In_Days = table.Column<int>(type: "int", nullable: false),
                    Date_Created = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgram_Template", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TrainingProgram_Workouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Details = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Date_Recorded = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Training_ProgramId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgram_Workouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgram_Workouts_TrainingProgram_Assignment_Training~",
                        column: x => x.Training_ProgramId,
                        principalTable: "TrainingProgram_Assignment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TrainingProgram_Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Template_ExerciseId = table.Column<int>(type: "int", nullable: false),
                    WorkoutId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgram_Exercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgram_Exercises_TrainingProgram_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "TrainingProgram_Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingProgram_Exercises_trainingProgramTemplate_Exercises_~",
                        column: x => x.Template_ExerciseId,
                        principalTable: "trainingProgramTemplate_Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TrainingProgramExercise_Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "double", nullable: false),
                    Date_Modified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramExercise_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramExercise_Properties_TrainingProgram_Exercises~",
                        column: x => x.ExerciseId,
                        principalTable: "TrainingProgram_Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TrainingProgramExerciseProperties_DropSets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DropSet_Count = table.Column<int>(type: "int", nullable: false),
                    DropSet_Offset = table.Column<int>(type: "int", nullable: false),
                    PropertiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramExerciseProperties_DropSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramExerciseProperties_DropSets_TrainingProgramEx~",
                        column: x => x.PropertiesId,
                        principalTable: "TrainingProgramExercise_Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "trainingProgramExerciseProperties_Intervals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Active_Time = table.Column<int>(type: "int", nullable: false),
                    Rest_Time = table.Column<int>(type: "int", nullable: false),
                    PropertiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trainingProgramExerciseProperties_Intervals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_trainingProgramExerciseProperties_Intervals_TrainingProgramE~",
                        column: x => x.PropertiesId,
                        principalTable: "TrainingProgramExercise_Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "trainingProgramExerciseProperties_Isometrics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Time_Under_Tension = table.Column<double>(type: "double", nullable: false),
                    PropertiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trainingProgramExerciseProperties_Isometrics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_trainingProgramExerciseProperties_Isometrics_TrainingProgram~",
                        column: x => x.PropertiesId,
                        principalTable: "TrainingProgramExercise_Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgram_Exercises_Template_ExerciseId",
                table: "TrainingProgram_Exercises",
                column: "Template_ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgram_Exercises_WorkoutId",
                table: "TrainingProgram_Exercises",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgram_Workouts_Training_ProgramId",
                table: "TrainingProgram_Workouts",
                column: "Training_ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramExercise_Properties_ExerciseId",
                table: "TrainingProgramExercise_Properties",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramExerciseProperties_DropSets_PropertiesId",
                table: "TrainingProgramExerciseProperties_DropSets",
                column: "PropertiesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_trainingProgramExerciseProperties_Intervals_PropertiesId",
                table: "trainingProgramExerciseProperties_Intervals",
                column: "PropertiesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_trainingProgramExerciseProperties_Isometrics_PropertiesId",
                table: "trainingProgramExerciseProperties_Isometrics",
                column: "PropertiesId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingProgramTemplate_Objectives_TrainingProgram_Template_~",
                table: "TrainingProgramTemplate_Objectives",
                column: "TrainingProgram_TemplateId",
                principalTable: "TrainingProgram_Template",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingProgramTemplate_Objectives_TrainingProgram_Template_~",
                table: "TrainingProgramTemplate_Objectives");

            migrationBuilder.DropTable(
                name: "TrainingProgram_Template");

            migrationBuilder.DropTable(
                name: "TrainingProgramExerciseProperties_DropSets");

            migrationBuilder.DropTable(
                name: "trainingProgramExerciseProperties_Intervals");

            migrationBuilder.DropTable(
                name: "trainingProgramExerciseProperties_Isometrics");

            migrationBuilder.DropTable(
                name: "TrainingProgramExercise_Properties");

            migrationBuilder.DropTable(
                name: "TrainingProgram_Exercises");

            migrationBuilder.DropTable(
                name: "TrainingProgram_Workouts");

            migrationBuilder.DropTable(
                name: "TrainingProgram_Assignment");

            migrationBuilder.CreateTable(
                name: "TrainingProgram_Templates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date_Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Details = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Duration_In_Days = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgram_Templates", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingProgramTemplate_Objectives_TrainingProgram_Templates~",
                table: "TrainingProgramTemplate_Objectives",
                column: "TrainingProgram_TemplateId",
                principalTable: "TrainingProgram_Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
