﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Todo.Api.Data;

#nullable disable

namespace Todo.Api.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    [Migration("20240621181118_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Todo.Api.Models.TodoList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 6, 21, 21, 11, 16, 820, DateTimeKind.Local).AddTicks(3225),
                            IsActive = true,
                            Title = "Todo List 1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 6, 21, 21, 11, 16, 820, DateTimeKind.Local).AddTicks(3235),
                            IsActive = true,
                            Title = "Todo List 2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 6, 21, 21, 11, 16, 820, DateTimeKind.Local).AddTicks(3237),
                            IsActive = true,
                            Title = "Todo List 3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
