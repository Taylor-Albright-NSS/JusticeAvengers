﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace JusticeAvengers.Migrations
{
    [DbContext(typeof(JusticeAvengersDbContext))]
    partial class JusticeAvengersDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("JusticeAvengers.Models.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("HeroId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TypeId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Weight")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("HeroId");

                    b.ToTable("Equipment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A blade imbued with the essence of courage",
                            HeroId = 1,
                            Name = "Sword of Valor",
                            TypeId = 1,
                            Weight = 12.5m
                        },
                        new
                        {
                            Id = 2,
                            Description = "A bow crafted by the finest elven craftsmen",
                            HeroId = 2,
                            Name = "Elven Bow",
                            TypeId = 2,
                            Weight = 4.3m
                        },
                        new
                        {
                            Id = 3,
                            Description = "A staff that channels arcane power",
                            HeroId = 3,
                            Name = "Wizard's Staff",
                            TypeId = 3,
                            Weight = 8.1m
                        },
                        new
                        {
                            Id = 4,
                            Description = "A shield that radiates divine protection",
                            HeroId = 5,
                            Name = "Shield of Light",
                            TypeId = 4,
                            Weight = 15.7m
                        },
                        new
                        {
                            Id = 5,
                            Description = "A heavy axe forged in the mountain halls",
                            HeroId = 7,
                            Name = "Dwarven Axe",
                            TypeId = 5,
                            Weight = 20.2m
                        },
                        new
                        {
                            Id = 6,
                            Description = "A magical ring that grants invisibility",
                            HeroId = 4,
                            Name = "Ring of Stealth",
                            TypeId = 6,
                            Weight = 0.2m
                        },
                        new
                        {
                            Id = 7,
                            Description = "The personal weapon of the woodland king",
                            HeroId = 8,
                            Name = "Bow of Thranduil",
                            TypeId = 2,
                            Weight = 3.9m
                        },
                        new
                        {
                            Id = 8,
                            Description = "Restores health when consumed",
                            HeroId = 9,
                            Name = "Potion of Healing",
                            TypeId = 7,
                            Weight = 0.5m
                        },
                        new
                        {
                            Id = 9,
                            Description = "A ceremonial weapon with a razor-sharp edge",
                            HeroId = 10,
                            Name = "Golden Dagger",
                            TypeId = 1,
                            Weight = 2.3m
                        },
                        new
                        {
                            Id = 10,
                            Description = "Grants increased physical power",
                            HeroId = 1,
                            Name = "Amulet of Strength",
                            TypeId = 6,
                            Weight = 1.1m
                        });
                });

            modelBuilder.Entity("JusticeAvengers.Models.EquipmentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EquipmentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sword"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bow"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Staff"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Shield"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Axe"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Accessory"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Potion"
                        });
                });

            modelBuilder.Entity("JusticeAvengers.Models.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("HeroClassId")
                        .HasColumnType("integer");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("QuestId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("HeroClassId");

                    b.HasIndex("QuestId");

                    b.ToTable("Heroes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A skilled ranger and warrior",
                            HeroClassId = 1,
                            Level = 20,
                            Name = "Aragorn",
                            QuestId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "An elven archer with unmatched precision",
                            HeroClassId = 2,
                            Level = 18,
                            Name = "Legolas",
                            QuestId = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "A wise and powerful wizard",
                            HeroClassId = 3,
                            Level = 25,
                            Name = "Gandalf",
                            QuestId = 3
                        },
                        new
                        {
                            Id = 4,
                            Description = "A brave halfling on a dangerous journey",
                            HeroClassId = 4,
                            Level = 10,
                            Name = "Frodo",
                            QuestId = 1
                        },
                        new
                        {
                            Id = 5,
                            Description = "A fierce shieldmaiden of Rohan",
                            HeroClassId = 5,
                            Level = 15,
                            Name = "Eowyn",
                            QuestId = 2
                        },
                        new
                        {
                            Id = 6,
                            Description = "A noble warrior with a strong sense of duty",
                            HeroClassId = 1,
                            Level = 17,
                            Name = "Boromir",
                            QuestId = 4
                        },
                        new
                        {
                            Id = 7,
                            Description = "A stout and fearless dwarf warrior",
                            HeroClassId = 6,
                            Level = 16,
                            Name = "Gimli",
                            QuestId = 3
                        },
                        new
                        {
                            Id = 8,
                            Description = "A king of the woodland elves",
                            HeroClassId = 2,
                            Level = 22,
                            Name = "Thranduil",
                            QuestId = 5
                        },
                        new
                        {
                            Id = 9,
                            Description = "A graceful elf skilled in healing and magic",
                            HeroClassId = 3,
                            Level = 14,
                            Name = "Arwen",
                            QuestId = 3
                        },
                        new
                        {
                            Id = 10,
                            Description = "A loyal companion with unwavering courage",
                            HeroClassId = 4,
                            Level = 12,
                            Name = "Samwise",
                            QuestId = 1
                        });
                });

            modelBuilder.Entity("JusticeAvengers.Models.HeroClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("HeroClasses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Warrior"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Archer"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Wizard"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Halfling"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Shieldmaiden"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Dwarf"
                        });
                });

            modelBuilder.Entity("JusticeAvengers.Models.Quest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Quests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Eliminate the orc horde threatening the kingdom",
                            IsCompleted = false,
                            Name = "Defeat the Orcs"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Save the captured elf from the goblin cave",
                            IsCompleted = false,
                            Name = "Rescue the Elf"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Find the ancient amulet lost in the haunted forest",
                            IsCompleted = false,
                            Name = "Retrieve the Amulet"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Protect the castle from the siege of the dark army",
                            IsCompleted = true,
                            Name = "Defend the Castle"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Uncover the secrets of the ancient ruins",
                            IsCompleted = false,
                            Name = "Explore the Ruins"
                        });
                });

            modelBuilder.Entity("JusticeAvengers.Models.Equipment", b =>
                {
                    b.HasOne("JusticeAvengers.Models.Hero", null)
                        .WithMany("Equipment")
                        .HasForeignKey("HeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JusticeAvengers.Models.Hero", b =>
                {
                    b.HasOne("JusticeAvengers.Models.HeroClass", "HeroClass")
                        .WithMany()
                        .HasForeignKey("HeroClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JusticeAvengers.Models.Quest", "Quest")
                        .WithMany("Heroes")
                        .HasForeignKey("QuestId");

                    b.Navigation("HeroClass");

                    b.Navigation("Quest");
                });

            modelBuilder.Entity("JusticeAvengers.Models.Hero", b =>
                {
                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("JusticeAvengers.Models.Quest", b =>
                {
                    b.Navigation("Heroes");
                });
#pragma warning restore 612, 618
        }
    }
}
