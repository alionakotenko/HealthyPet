﻿// <auto-generated />
using System;
using HealthyPet.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HealthyPet.Api.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20181111124614_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("HealthyPet.Api.Entities.Pet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PetName");

                    b.Property<int>("PetType");

                    b.HasKey("Id");

                    b.ToTable("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}