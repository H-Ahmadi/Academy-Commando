﻿// <auto-generated />
using System;
using Academy.Persistence.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Academy.Persistence.EF.Migrations
{
    [DbContext(typeof(AcademyContext))]
    partial class AcademyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Academy.Domain.CourseCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ParentId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("CourseCategories");
                });

            modelBuilder.Entity("Academy.Domain.CourseCategory", b =>
                {
                    b.HasOne("Academy.Domain.CourseCategory", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });
#pragma warning restore 612, 618
        }
    }
}