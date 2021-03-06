﻿// <auto-generated />
using DocsSenderApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DocsSenderApp.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    partial class EmployeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DocsSenderApp.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountId");

                    b.Property<byte[]>("Avatar");

                    b.Property<string>("FIO");

                    b.Property<string>("RankId");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employeers");
                });

            modelBuilder.Entity("DocsSenderApp.Models.Rank", b =>
                {
                    b.Property<string>("RankId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("RankId");

                    b.ToTable("Ranks");
                });
#pragma warning restore 612, 618
        }
    }
}
