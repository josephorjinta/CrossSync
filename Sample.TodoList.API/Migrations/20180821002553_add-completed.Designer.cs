﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sample.TodoList.Entities.Shared;

namespace Sample.TodoList.API.Migrations
{
    [DbContext(typeof(TodoListContext))]
    [Migration("20180821002553_add-completed")]
    partial class Addcompleted
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CrossSync.Entity.Abstractions.Entities.DeletedEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DataType");

                    b.Property<DateTimeOffset>("DeletedDate");

                    b.Property<Guid>("EntityId");

                    b.HasKey("Id");

                    b.HasIndex("EntityId", "DataType")
                        .IsUnique()
                        .HasFilter("[DataType] IS NOT NULL");

                    b.ToTable("DeletedEntities");
                });

            modelBuilder.Entity("Sample.TodoList.Entities.Shared.TodoList", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Completed");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Name");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("TodoLists");
                });

            modelBuilder.Entity("Sample.TodoList.Entities.Shared.TodoListItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Task");

                    b.Property<Guid?>("TodoListId");

                    b.HasKey("Id");

                    b.HasIndex("TodoListId");

                    b.ToTable("TodoListItem");
                });

            modelBuilder.Entity("Sample.TodoList.Entities.Shared.TodoListItem", b =>
                {
                    b.HasOne("Sample.TodoList.Entities.Shared.TodoList")
                        .WithMany("Items")
                        .HasForeignKey("TodoListId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
