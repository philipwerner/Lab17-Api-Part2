﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Todo_Api.Data;

namespace Todo_Api.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20180411221550_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Todo_Api.Models.TodoItem", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsComplete");

                    b.Property<string>("Name");

                    b.Property<int?>("WeekDayID");

                    b.HasKey("ID");

                    b.HasIndex("WeekDayID");

                    b.ToTable("TodoItems");
                });

            modelBuilder.Entity("Todo_Api.Models.WeekDay", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Day");

                    b.HasKey("ID");

                    b.ToTable("WeekDay");
                });

            modelBuilder.Entity("Todo_Api.Models.TodoItem", b =>
                {
                    b.HasOne("Todo_Api.Models.WeekDay", "WeekDay")
                        .WithMany("Items")
                        .HasForeignKey("WeekDayID");
                });
#pragma warning restore 612, 618
        }
    }
}
