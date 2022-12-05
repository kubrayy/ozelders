﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OzelDers.Data.Concrete;

#nullable disable

namespace OzelDers.Data.Migrations
{
    [DbContext(typeof(MyAppContext))]
    [Migration("20221124090442_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("OzelDers.Entity.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAdres")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<int>("LanguageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("OneHourPrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 77,
                            DateAdded = new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4930),
                            Description = "Hello, I'm English. Let's make practice!",
                            EmailAdres = "roseblack@example.com",
                            Gender = "Woman",
                            ImageUrl = "1_en.jpeg",
                            LanguageId = 1,
                            LastName = "Black",
                            Name = "Rose",
                            OneHourPrice = 50m,
                            Url = "1"
                        },
                        new
                        {
                            Id = 2,
                            Age = 65,
                            DateAdded = new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4960),
                            Description = "Hello, I'm English. Let's make practice!",
                            EmailAdres = "charlesprince@example.com",
                            Gender = "Man",
                            ImageUrl = "2_en.jpeg",
                            LanguageId = 1,
                            LastName = "Prince",
                            Name = "Charles",
                            OneHourPrice = 70m,
                            Url = "2"
                        },
                        new
                        {
                            Id = 3,
                            Age = 35,
                            DateAdded = new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4960),
                            Description = "Hello, I'm English. Let's make practice!",
                            EmailAdres = "elizabethblue@example.com",
                            Gender = "Man",
                            ImageUrl = "3_en.jpeg",
                            LanguageId = 1,
                            LastName = "Blue",
                            Name = "Elizabeth",
                            OneHourPrice = 50m,
                            Url = "3"
                        },
                        new
                        {
                            Id = 4,
                            Age = 34,
                            DateAdded = new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4960),
                            Description = "Hello, I'm German. Let's make practice!",
                            EmailAdres = "blaskoln@example.com",
                            Gender = "Man",
                            ImageUrl = "4_alm.jpeg",
                            LanguageId = 2,
                            LastName = "Köln",
                            Name = "Blas",
                            OneHourPrice = 90m,
                            Url = "4"
                        },
                        new
                        {
                            Id = 5,
                            Age = 46,
                            DateAdded = new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4960),
                            Description = "Hello, I'm German. Let's make practice!",
                            EmailAdres = "odianemodiane@example.com",
                            Gender = "Man",
                            ImageUrl = "5_alm.jpeg",
                            LanguageId = 2,
                            LastName = "Modiane",
                            Name = "Odiane",
                            OneHourPrice = 120m,
                            Url = "5"
                        },
                        new
                        {
                            Id = 6,
                            Age = 34,
                            DateAdded = new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4970),
                            Description = "Hello, I'm German. Let's make practice!",
                            EmailAdres = "trudymrudy@example.com",
                            Gender = "Man",
                            ImageUrl = "6_alm.jpeg",
                            LanguageId = 2,
                            LastName = "Mrudy",
                            Name = "Trudy",
                            OneHourPrice = 150m,
                            Url = "6"
                        },
                        new
                        {
                            Id = 7,
                            Age = 27,
                            DateAdded = new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4970),
                            Description = "Hello, I'm Italian. Let's make practice!",
                            EmailAdres = "alessamalessa@example.com",
                            Gender = "Woman",
                            ImageUrl = "7_ital.jpeg",
                            LanguageId = 3,
                            LastName = "Malessa",
                            Name = "Alessa",
                            OneHourPrice = 170m,
                            Url = "7"
                        },
                        new
                        {
                            Id = 8,
                            Age = 44,
                            DateAdded = new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4970),
                            Description = "Hello, I'm Italian. Let's make practice!",
                            EmailAdres = "aureliaonomoro@example.com",
                            Gender = "Man",
                            ImageUrl = "8_ital.jpeg",
                            LanguageId = 3,
                            LastName = "Moro",
                            Name = "Aureliano",
                            OneHourPrice = 150m,
                            Url = "8"
                        },
                        new
                        {
                            Id = 9,
                            Age = 34,
                            DateAdded = new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4970),
                            Description = "Hello, I'm Italian. Let's make practice!",
                            EmailAdres = "orestemokar@example.com",
                            Gender = "Man",
                            ImageUrl = "9_ital.jpeg",
                            LanguageId = 3,
                            LastName = "Mokar",
                            Name = "Oreste",
                            OneHourPrice = 180m,
                            Url = "9"
                        },
                        new
                        {
                            Id = 10,
                            Age = 25,
                            DateAdded = new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4970),
                            Description = "Hello, I'm Korean. Let's make practice!",
                            EmailAdres = "iseosiwoo@example.com",
                            Gender = "Woman",
                            ImageUrl = "10_kor.jpg",
                            LanguageId = 4,
                            LastName = "Si-woo",
                            Name = "I-seo",
                            OneHourPrice = 190m,
                            Url = "10"
                        },
                        new
                        {
                            Id = 11,
                            Age = 21,
                            DateAdded = new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4980),
                            Description = "Hello, I'm Korean. Let's make practice!",
                            EmailAdres = "yejunpoju@example.com",
                            Gender = "Woman",
                            ImageUrl = "11_kor.jpg",
                            LanguageId = 4,
                            LastName = "Po-ju",
                            Name = "Ye-jun",
                            OneHourPrice = 120m,
                            Url = "11"
                        },
                        new
                        {
                            Id = 12,
                            Age = 19,
                            DateAdded = new DateTime(2022, 11, 24, 12, 4, 42, 47, DateTimeKind.Local).AddTicks(4980),
                            Description = "Hello, I'm Korean. Let's make practice!",
                            EmailAdres = "eunseoseoyun@example.com",
                            Gender = "Woman",
                            ImageUrl = "12_kor.jpg",
                            LanguageId = 4,
                            LastName = "Seoyun",
                            Name = "Eunseo",
                            OneHourPrice = 150m,
                            Url = "12"
                        });
                });

            modelBuilder.Entity("OzelDers.Entity.InstructorAndStudent", b =>
                {
                    b.Property<int>("InstructorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("InstructorId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("InstructorAndStudents");
                });

            modelBuilder.Entity("OzelDers.Entity.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("LanguageId");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            LanguageId = 1,
                            ImageUrl = "english.jpeg",
                            Name = "English",
                            Url = "learnenglish"
                        },
                        new
                        {
                            LanguageId = 2,
                            ImageUrl = "germany.jpeg",
                            Name = "Germany",
                            Url = "learngermany"
                        },
                        new
                        {
                            LanguageId = 3,
                            ImageUrl = "italy.jpeg",
                            Name = "Italian",
                            Url = "learnitalian"
                        },
                        new
                        {
                            LanguageId = 4,
                            ImageUrl = "korean.jpeg",
                            Name = "Korean",
                            Url = "learnkorean"
                        });
                });

            modelBuilder.Entity("OzelDers.Entity.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 17,
                            LastName = "Purple",
                            Name = "Joseph"
                        },
                        new
                        {
                            Id = 2,
                            Age = 16,
                            LastName = "Black",
                            Name = "Yusuf"
                        },
                        new
                        {
                            Id = 3,
                            Age = 26,
                            LastName = "Pink",
                            Name = "Merve"
                        },
                        new
                        {
                            Id = 4,
                            Age = 37,
                            LastName = "Maslı",
                            Name = "Aslı"
                        });
                });

            modelBuilder.Entity("OzelDers.Entity.Instructor", b =>
                {
                    b.HasOne("OzelDers.Entity.Language", "Language")
                        .WithMany("Instructors")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("OzelDers.Entity.InstructorAndStudent", b =>
                {
                    b.HasOne("OzelDers.Entity.Instructor", "Instructor")
                        .WithMany("InstructorAndStudents")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OzelDers.Entity.Student", "Student")
                        .WithMany("InstructorAndStudents")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("OzelDers.Entity.Instructor", b =>
                {
                    b.Navigation("InstructorAndStudents");
                });

            modelBuilder.Entity("OzelDers.Entity.Language", b =>
                {
                    b.Navigation("Instructors");
                });

            modelBuilder.Entity("OzelDers.Entity.Student", b =>
                {
                    b.Navigation("InstructorAndStudents");
                });
#pragma warning restore 612, 618
        }
    }
}