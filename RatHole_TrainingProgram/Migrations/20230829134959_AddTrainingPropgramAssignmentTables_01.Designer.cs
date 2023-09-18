﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RatHole_TrainingProgram.Data;

#nullable disable

namespace RatHole_TrainingProgram.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230829134959_AddTrainingPropgramAssignmentTables_01")]
    partial class AddTrainingPropgramAssignmentTables_01
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Category_TagExercise_Definition", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("Exercise_DefinitionsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "Exercise_DefinitionsId");

                    b.HasIndex("Exercise_DefinitionsId");

                    b.ToTable("Category_TagExercise_Definition");
                });

            modelBuilder.Entity("Exercise_DefinitionJoint_Tag", b =>
                {
                    b.Property<int>("Exercise_DefinitionsId")
                        .HasColumnType("int");

                    b.Property<int>("Joint_TagsId")
                        .HasColumnType("int");

                    b.HasKey("Exercise_DefinitionsId", "Joint_TagsId");

                    b.HasIndex("Joint_TagsId");

                    b.ToTable("Exercise_DefinitionJoint_Tag");
                });

            modelBuilder.Entity("Exercise_DefinitionMuscle_Tag", b =>
                {
                    b.Property<int>("Exercise_DefinitionsId")
                        .HasColumnType("int");

                    b.Property<int>("Muscle_TagsId")
                        .HasColumnType("int");

                    b.HasKey("Exercise_DefinitionsId", "Muscle_TagsId");

                    b.HasIndex("Muscle_TagsId");

                    b.ToTable("Exercise_DefinitionMuscle_Tag");
                });

            modelBuilder.Entity("Exercise_DefinitionSplit_Tag", b =>
                {
                    b.Property<int>("Exercise_DefinitionsId")
                        .HasColumnType("int");

                    b.Property<int>("SplitsId")
                        .HasColumnType("int");

                    b.HasKey("Exercise_DefinitionsId", "SplitsId");

                    b.HasIndex("SplitsId");

                    b.ToTable("Exercise_DefinitionSplit_Tag");
                });

            modelBuilder.Entity("Exercise_DefinitionTendon_Tag", b =>
                {
                    b.Property<int>("Exercise_DefinitionsId")
                        .HasColumnType("int");

                    b.Property<int>("Tendon_TagsId")
                        .HasColumnType("int");

                    b.HasKey("Exercise_DefinitionsId", "Tendon_TagsId");

                    b.HasIndex("Tendon_TagsId");

                    b.ToTable("Exercise_DefinitionTendon_Tag");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.ExerciseDefinitions.Category_Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Category_Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 0
                        },
                        new
                        {
                            Id = 2,
                            Category = 1
                        },
                        new
                        {
                            Id = 3,
                            Category = 2
                        },
                        new
                        {
                            Id = 4,
                            Category = 3
                        },
                        new
                        {
                            Id = 5,
                            Category = 4
                        },
                        new
                        {
                            Id = 6,
                            Category = 5
                        },
                        new
                        {
                            Id = 7,
                            Category = 6
                        },
                        new
                        {
                            Id = 8,
                            Category = 7
                        },
                        new
                        {
                            Id = 9,
                            Category = 8
                        });
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.ExerciseDefinitions.Exercise_Definition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Exercise_Definitions");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.ExerciseDefinitions.Joint_Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Joint")
                        .HasColumnType("int");

                    b.Property<int>("Joint_Movement")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Joint_Tags");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.ExerciseDefinitions.Muscle_Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Muscle")
                        .HasColumnType("int");

                    b.Property<int>("Muscle_Involvment")
                        .HasColumnType("int");

                    b.Property<int>("Muscle_Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Muscle_Tags");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.ExerciseDefinitions.Split_Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Split")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Split_Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Split = 0
                        },
                        new
                        {
                            Id = 2,
                            Split = 1
                        },
                        new
                        {
                            Id = 3,
                            Split = 2
                        },
                        new
                        {
                            Id = 4,
                            Split = 3
                        },
                        new
                        {
                            Id = 5,
                            Split = 4
                        },
                        new
                        {
                            Id = 6,
                            Split = 5
                        },
                        new
                        {
                            Id = 7,
                            Split = 6
                        },
                        new
                        {
                            Id = 8,
                            Split = 7
                        },
                        new
                        {
                            Id = 9,
                            Split = 8
                        });
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.ExerciseDefinitions.Tendon_Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Tendon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tendon_Tags");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgramExerciseProperties_DropSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DropSet_Count")
                        .HasColumnType("int");

                    b.Property<int>("DropSet_Offset")
                        .HasColumnType("int");

                    b.Property<int>("PropertiesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropertiesId")
                        .IsUnique();

                    b.ToTable("TrainingProgramExerciseProperties_DropSets");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgramExerciseProperties_Interval", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Active_Time")
                        .HasColumnType("int");

                    b.Property<int>("PropertiesId")
                        .HasColumnType("int");

                    b.Property<int>("Rest_Time")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropertiesId")
                        .IsUnique();

                    b.ToTable("trainingProgramExerciseProperties_Intervals");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgramExerciseProperties_Isometric", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PropertiesId")
                        .HasColumnType("int");

                    b.Property<double>("Time_Under_Tension")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("PropertiesId")
                        .IsUnique();

                    b.ToTable("trainingProgramExerciseProperties_Isometrics");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgramExercise_Properties", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date_Modified")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("Reps")
                        .HasColumnType("int");

                    b.Property<int>("Sets")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.ToTable("TrainingProgramExercise_Properties");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgram_Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Template_ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Template_ExerciseId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("TrainingProgram_Exercises");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgram_Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Date_Recorded")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Training_ProgramId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Training_ProgramId");

                    b.ToTable("TrainingProgram_Workouts");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates.TrainingProgramTemplate_Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Circuit_Number")
                        .HasColumnType("int");

                    b.Property<int>("Exercise_DefinitionId")
                        .HasColumnType("int");

                    b.Property<int>("Method")
                        .HasColumnType("int");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<int>("TrainingProgramTemplate_ObjectiveId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Exercise_DefinitionId");

                    b.HasIndex("TrainingProgramTemplate_ObjectiveId");

                    b.ToTable("trainingProgramTemplate_Exercises");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates.TrainingProgramTemplate_Objective", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TrainingProgram_TemplateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrainingProgram_TemplateId");

                    b.ToTable("TrainingProgramTemplate_Objectives");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates.TrainingProgram_Template", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date_Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Duration_In_Days")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TrainingProgram_Template");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgram_Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Assign_EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Assign_StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Assigned_From")
                        .HasColumnType("int");

                    b.Property<int>("Assigned_To")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TrainingProgram_Assignment");
                });

            modelBuilder.Entity("Category_TagExercise_Definition", b =>
                {
                    b.HasOne("RatHole_TrainingProgram.Models.ExerciseDefinitions.Category_Tag", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RatHole_TrainingProgram.Models.ExerciseDefinitions.Exercise_Definition", null)
                        .WithMany()
                        .HasForeignKey("Exercise_DefinitionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Exercise_DefinitionJoint_Tag", b =>
                {
                    b.HasOne("RatHole_TrainingProgram.Models.ExerciseDefinitions.Exercise_Definition", null)
                        .WithMany()
                        .HasForeignKey("Exercise_DefinitionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RatHole_TrainingProgram.Models.ExerciseDefinitions.Joint_Tag", null)
                        .WithMany()
                        .HasForeignKey("Joint_TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Exercise_DefinitionMuscle_Tag", b =>
                {
                    b.HasOne("RatHole_TrainingProgram.Models.ExerciseDefinitions.Exercise_Definition", null)
                        .WithMany()
                        .HasForeignKey("Exercise_DefinitionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RatHole_TrainingProgram.Models.ExerciseDefinitions.Muscle_Tag", null)
                        .WithMany()
                        .HasForeignKey("Muscle_TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Exercise_DefinitionSplit_Tag", b =>
                {
                    b.HasOne("RatHole_TrainingProgram.Models.ExerciseDefinitions.Exercise_Definition", null)
                        .WithMany()
                        .HasForeignKey("Exercise_DefinitionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RatHole_TrainingProgram.Models.ExerciseDefinitions.Split_Tag", null)
                        .WithMany()
                        .HasForeignKey("SplitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Exercise_DefinitionTendon_Tag", b =>
                {
                    b.HasOne("RatHole_TrainingProgram.Models.ExerciseDefinitions.Exercise_Definition", null)
                        .WithMany()
                        .HasForeignKey("Exercise_DefinitionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RatHole_TrainingProgram.Models.ExerciseDefinitions.Tendon_Tag", null)
                        .WithMany()
                        .HasForeignKey("Tendon_TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgramExerciseProperties_DropSet", b =>
                {
                    b.HasOne("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgramExercise_Properties", "Properties")
                        .WithOne("DropSet_Properties")
                        .HasForeignKey("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgramExerciseProperties_DropSet", "PropertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Properties");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgramExerciseProperties_Interval", b =>
                {
                    b.HasOne("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgramExercise_Properties", "Properties")
                        .WithOne("Interval_Properties")
                        .HasForeignKey("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgramExerciseProperties_Interval", "PropertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Properties");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgramExerciseProperties_Isometric", b =>
                {
                    b.HasOne("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgramExercise_Properties", "Properties")
                        .WithOne("Isometric_Properties")
                        .HasForeignKey("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgramExerciseProperties_Isometric", "PropertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Properties");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgramExercise_Properties", b =>
                {
                    b.HasOne("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgram_Exercise", "Exercise")
                        .WithMany("Properties_Entries")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgram_Exercise", b =>
                {
                    b.HasOne("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates.TrainingProgramTemplate_Exercise", "Template_Exercise")
                        .WithMany("Assigned_Exercises")
                        .HasForeignKey("Template_ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgram_Workout", "Workout")
                        .WithMany("Exercises")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Template_Exercise");

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgram_Workout", b =>
                {
                    b.HasOne("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgram_Assignment", "Training_Program")
                        .WithMany("Workouts")
                        .HasForeignKey("Training_ProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Training_Program");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates.TrainingProgramTemplate_Exercise", b =>
                {
                    b.HasOne("RatHole_TrainingProgram.Models.ExerciseDefinitions.Exercise_Definition", "Exercise_Definition")
                        .WithMany("Exercises")
                        .HasForeignKey("Exercise_DefinitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates.TrainingProgramTemplate_Objective", "TrainingProgramTemplate_Objective")
                        .WithMany("Objective_Exercises")
                        .HasForeignKey("TrainingProgramTemplate_ObjectiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise_Definition");

                    b.Navigation("TrainingProgramTemplate_Objective");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates.TrainingProgramTemplate_Objective", b =>
                {
                    b.HasOne("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates.TrainingProgram_Template", "TrainingProgram_Template")
                        .WithMany("Objectives")
                        .HasForeignKey("TrainingProgram_TemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrainingProgram_Template");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.ExerciseDefinitions.Exercise_Definition", b =>
                {
                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgramExercise_Properties", b =>
                {
                    b.Navigation("DropSet_Properties");

                    b.Navigation("Interval_Properties");

                    b.Navigation("Isometric_Properties");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgram_Exercise", b =>
                {
                    b.Navigation("Properties_Entries");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramAssignments.TrainingProgram_Workout", b =>
                {
                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates.TrainingProgramTemplate_Exercise", b =>
                {
                    b.Navigation("Assigned_Exercises");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates.TrainingProgramTemplate_Objective", b =>
                {
                    b.Navigation("Objective_Exercises");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgramTemplates.TrainingProgram_Template", b =>
                {
                    b.Navigation("Objectives");
                });

            modelBuilder.Entity("RatHole_TrainingProgram.Models.TrainingPrograms.TrainingProgram_Assignment", b =>
                {
                    b.Navigation("Workouts");
                });
#pragma warning restore 612, 618
        }
    }
}