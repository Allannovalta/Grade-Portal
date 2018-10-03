﻿// <auto-generated />
using System;
using AllanNovalta.GradePortal.Web.Infrastructure.Data.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AllanNovalta.GradePortal.Web.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    [Migration("20181003005935_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AllanNovalta.GradePortal.Web.Infrastructure.Data.Models.Grade", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AcademicYear");

                    b.Property<string>("Comment");

                    b.Property<string>("FirstName");

                    b.Property<decimal>("GradePercent");

                    b.Property<decimal>("GradePoint");

                    b.Property<bool>("IsFailed");

                    b.Property<string>("LastName");

                    b.Property<string>("Semester");

                    b.Property<Guid?>("StudentId");

                    b.Property<string>("SubjectCode");

                    b.Property<string>("SubjectTitle");

                    b.Property<DateTime>("Timestamp");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("AllanNovalta.GradePortal.Web.Infrastructure.Data.Models.User", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<string>("LastName");

                    b.Property<int>("LoginStatus");

                    b.Property<int>("LoginTrials");

                    b.Property<string>("Password");

                    b.Property<string>("RegistrationCode");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}