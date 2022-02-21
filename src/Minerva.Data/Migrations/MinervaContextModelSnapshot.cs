﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Minerva.Data;
using NodaTime;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Minerva.Data.Migrations
{
    [DbContext(typeof(MinervaContext))]
    partial class MinervaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresEnum(modelBuilder, "test_result_format", new[] { "playwright_test", "cucumber_js", "jest" });
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Minerva.Data.TestResult", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<decimal>("Duration")
                        .HasColumnType("numeric")
                        .HasColumnName("duration");

                    b.Property<string>("ErrorMessage")
                        .HasColumnType("jsonb")
                        .HasColumnName("error_message");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Product")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("product");

                    b.Property<TestResultFormat>("ResultType")
                        .HasColumnType("test_result_format")
                        .HasColumnName("result_type");

                    b.Property<Instant>("RunAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("run_at");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("status");

                    b.Property<List<string>>("Tags")
                        .IsRequired()
                        .HasColumnType("text[]")
                        .HasColumnName("tags");

                    b.Property<string>("Trigger")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("trigger");

                    b.HasKey("Id")
                        .HasName("pk_test_results");

                    b.ToTable("test_results", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}