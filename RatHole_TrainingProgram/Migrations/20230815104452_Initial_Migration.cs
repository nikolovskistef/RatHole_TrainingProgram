using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RatHole_TrainingProgram.Migrations
{
    /// <inheritdoc />
    public partial class Initial_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Category_Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category_Tags", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Exercise_Definitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    URL = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise_Definitions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Joint_Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Joint = table.Column<int>(type: "int", nullable: false),
                    Joint_Movement = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joint_Tags", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Muscle_Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Muscle = table.Column<int>(type: "int", nullable: false),
                    Muscle_Role = table.Column<int>(type: "int", nullable: false),
                    Muscle_Involvment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muscle_Tags", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Split_Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Split = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Split_Tags", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tendon_Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tendon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tendon_Tags", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TrainingProgram_Templates",
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
                    table.PrimaryKey("PK_TrainingProgram_Templates", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Category_TagExercise_Definition",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    Exercise_DefinitionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category_TagExercise_Definition", x => new { x.CategoriesId, x.Exercise_DefinitionsId });
                    table.ForeignKey(
                        name: "FK_Category_TagExercise_Definition_Category_Tags_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Category_Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Category_TagExercise_Definition_Exercise_Definitions_Exercis~",
                        column: x => x.Exercise_DefinitionsId,
                        principalTable: "Exercise_Definitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Exercise_DefinitionJoint_Tag",
                columns: table => new
                {
                    Exercise_DefinitionsId = table.Column<int>(type: "int", nullable: false),
                    Joint_TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise_DefinitionJoint_Tag", x => new { x.Exercise_DefinitionsId, x.Joint_TagsId });
                    table.ForeignKey(
                        name: "FK_Exercise_DefinitionJoint_Tag_Exercise_Definitions_Exercise_D~",
                        column: x => x.Exercise_DefinitionsId,
                        principalTable: "Exercise_Definitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exercise_DefinitionJoint_Tag_Joint_Tags_Joint_TagsId",
                        column: x => x.Joint_TagsId,
                        principalTable: "Joint_Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Exercise_DefinitionMuscle_Tag",
                columns: table => new
                {
                    Exercise_DefinitionsId = table.Column<int>(type: "int", nullable: false),
                    Muscle_TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise_DefinitionMuscle_Tag", x => new { x.Exercise_DefinitionsId, x.Muscle_TagsId });
                    table.ForeignKey(
                        name: "FK_Exercise_DefinitionMuscle_Tag_Exercise_Definitions_Exercise_~",
                        column: x => x.Exercise_DefinitionsId,
                        principalTable: "Exercise_Definitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exercise_DefinitionMuscle_Tag_Muscle_Tags_Muscle_TagsId",
                        column: x => x.Muscle_TagsId,
                        principalTable: "Muscle_Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Exercise_DefinitionSplit_Tag",
                columns: table => new
                {
                    Exercise_DefinitionsId = table.Column<int>(type: "int", nullable: false),
                    SplitsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise_DefinitionSplit_Tag", x => new { x.Exercise_DefinitionsId, x.SplitsId });
                    table.ForeignKey(
                        name: "FK_Exercise_DefinitionSplit_Tag_Exercise_Definitions_Exercise_D~",
                        column: x => x.Exercise_DefinitionsId,
                        principalTable: "Exercise_Definitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exercise_DefinitionSplit_Tag_Split_Tags_SplitsId",
                        column: x => x.SplitsId,
                        principalTable: "Split_Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Exercise_DefinitionTendon_Tag",
                columns: table => new
                {
                    Exercise_DefinitionsId = table.Column<int>(type: "int", nullable: false),
                    Tendon_TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise_DefinitionTendon_Tag", x => new { x.Exercise_DefinitionsId, x.Tendon_TagsId });
                    table.ForeignKey(
                        name: "FK_Exercise_DefinitionTendon_Tag_Exercise_Definitions_Exercise_~",
                        column: x => x.Exercise_DefinitionsId,
                        principalTable: "Exercise_Definitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exercise_DefinitionTendon_Tag_Tendon_Tags_Tendon_TagsId",
                        column: x => x.Tendon_TagsId,
                        principalTable: "Tendon_Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TrainingProgramTemplate_Objectives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Details = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TrainingProgram_TemplateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramTemplate_Objectives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramTemplate_Objectives_TrainingProgram_Templates~",
                        column: x => x.TrainingProgram_TemplateId,
                        principalTable: "TrainingProgram_Templates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "trainingProgramTemplate_Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Method = table.Column<int>(type: "int", nullable: false),
                    Circuit_Number = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Exercise_DefinitionId = table.Column<int>(type: "int", nullable: false),
                    TrainingProgramTemplate_ObjectiveId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trainingProgramTemplate_Exercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_trainingProgramTemplate_Exercises_Exercise_Definitions_Exerc~",
                        column: x => x.Exercise_DefinitionId,
                        principalTable: "Exercise_Definitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trainingProgramTemplate_Exercises_TrainingProgramTemplate_Ob~",
                        column: x => x.TrainingProgramTemplate_ObjectiveId,
                        principalTable: "TrainingProgramTemplate_Objectives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Category_Tags",
                columns: new[] { "Id", "Category" },
                values: new object[,]
                {
                    { 1, 0 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 3 },
                    { 5, 4 },
                    { 6, 5 },
                    { 7, 6 },
                    { 8, 7 },
                    { 9, 8 }
                });

            migrationBuilder.InsertData(
                table: "Split_Tags",
                columns: new[] { "Id", "Split" },
                values: new object[,]
                {
                    { 1, 0 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 3 },
                    { 5, 4 },
                    { 6, 5 },
                    { 7, 6 },
                    { 8, 7 },
                    { 9, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_TagExercise_Definition_Exercise_DefinitionsId",
                table: "Category_TagExercise_Definition",
                column: "Exercise_DefinitionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_DefinitionJoint_Tag_Joint_TagsId",
                table: "Exercise_DefinitionJoint_Tag",
                column: "Joint_TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_DefinitionMuscle_Tag_Muscle_TagsId",
                table: "Exercise_DefinitionMuscle_Tag",
                column: "Muscle_TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_DefinitionSplit_Tag_SplitsId",
                table: "Exercise_DefinitionSplit_Tag",
                column: "SplitsId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_DefinitionTendon_Tag_Tendon_TagsId",
                table: "Exercise_DefinitionTendon_Tag",
                column: "Tendon_TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_trainingProgramTemplate_Exercises_Exercise_DefinitionId",
                table: "trainingProgramTemplate_Exercises",
                column: "Exercise_DefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_trainingProgramTemplate_Exercises_TrainingProgramTemplate_Ob~",
                table: "trainingProgramTemplate_Exercises",
                column: "TrainingProgramTemplate_ObjectiveId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramTemplate_Objectives_TrainingProgram_TemplateId",
                table: "TrainingProgramTemplate_Objectives",
                column: "TrainingProgram_TemplateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category_TagExercise_Definition");

            migrationBuilder.DropTable(
                name: "Exercise_DefinitionJoint_Tag");

            migrationBuilder.DropTable(
                name: "Exercise_DefinitionMuscle_Tag");

            migrationBuilder.DropTable(
                name: "Exercise_DefinitionSplit_Tag");

            migrationBuilder.DropTable(
                name: "Exercise_DefinitionTendon_Tag");

            migrationBuilder.DropTable(
                name: "trainingProgramTemplate_Exercises");

            migrationBuilder.DropTable(
                name: "Category_Tags");

            migrationBuilder.DropTable(
                name: "Joint_Tags");

            migrationBuilder.DropTable(
                name: "Muscle_Tags");

            migrationBuilder.DropTable(
                name: "Split_Tags");

            migrationBuilder.DropTable(
                name: "Tendon_Tags");

            migrationBuilder.DropTable(
                name: "Exercise_Definitions");

            migrationBuilder.DropTable(
                name: "TrainingProgramTemplate_Objectives");

            migrationBuilder.DropTable(
                name: "TrainingProgram_Templates");
        }
    }
}
