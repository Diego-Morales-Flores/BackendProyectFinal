﻿// <auto-generated />
using System;
using DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BakeryFreshBreadAPI.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221216212337_DatabaseSeeding")]
    partial class DatabaseSeeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.BreadType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BreadName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CookingTemperature")
                        .HasColumnType("int");

                    b.Property<string>("CookingTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("FermentTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Process")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestingTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Breads");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4ec5819b-7839-47f0-b265-ae91dd40eaed"),
                            BreadName = "BAGUETTE",
                            CookingTemperature = 270,
                            CookingTime = "15 min",
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6655),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6656),
                            FermentTime = "1 day",
                            Price = "2.0",
                            Process = "MIX, REST, FOLD, REST, FOLD, FERMENT, CUT, SHAPE, REST COOK",
                            RestingTime = "0.5 hr"
                        },
                        new
                        {
                            Id = new Guid("433b4492-be99-40c5-bd20-b32b909cdf2c"),
                            BreadName = "WHITE BREAD",
                            CookingTemperature = 180,
                            CookingTime = "30 min",
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6669),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6670),
                            FermentTime = "4 day",
                            Price = "2.5",
                            Process = "MIX, CUT, FERMENT, SHAPE, REST, COOK",
                            RestingTime = "1 hr"
                        },
                        new
                        {
                            Id = new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"),
                            BreadName = "MILK BREAD",
                            CookingTemperature = 180,
                            CookingTime = "15 min",
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6674),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6675),
                            FermentTime = "4 hrs",
                            Price = "1.5",
                            Process = "MIX, CUT, REST, SHAPE, FERMENT, COOK",
                            RestingTime = "10 min"
                        },
                        new
                        {
                            Id = new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"),
                            BreadName = "HAMBURGUER BUN",
                            CookingTemperature = 180,
                            CookingTime = "15 min",
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6679),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6680),
                            FermentTime = "4 hrs",
                            Price = "1.0",
                            Process = "MIX, CUT, REST, SHAPE, FERMENT, PLACE, COOK",
                            RestingTime = "0.5 hr"
                        });
                });

            modelBuilder.Entity("Models.BreadTypeIngredient", b =>
                {
                    b.Property<Guid>("BreadTypeID")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(0);

                    b.Property<Guid>("IngredientID")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("BreadTypeID", "IngredientID");

                    b.ToTable("BreadTypeIngredients");

                    b.HasData(
                        new
                        {
                            BreadTypeID = new Guid("4ec5819b-7839-47f0-b265-ae91dd40eaed"),
                            IngredientID = new Guid("d8710641-8725-4c57-b537-d8cf69094d9a"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6704),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6705),
                            Quantity = 280
                        },
                        new
                        {
                            BreadTypeID = new Guid("4ec5819b-7839-47f0-b265-ae91dd40eaed"),
                            IngredientID = new Guid("328137cf-a8f4-498d-b724-37a2e56babe9"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6708),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6709),
                            Quantity = 210
                        },
                        new
                        {
                            BreadTypeID = new Guid("4ec5819b-7839-47f0-b265-ae91dd40eaed"),
                            IngredientID = new Guid("07953a69-856e-4111-9785-c74ead722be3"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6711),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6712),
                            Quantity = 10
                        },
                        new
                        {
                            BreadTypeID = new Guid("4ec5819b-7839-47f0-b265-ae91dd40eaed"),
                            IngredientID = new Guid("d0a9cf3f-5dad-4dfb-bfc3-0c3bc96b823d"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6713),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6714),
                            Quantity = 5
                        },
                        new
                        {
                            BreadTypeID = new Guid("433b4492-be99-40c5-bd20-b32b909cdf2c"),
                            IngredientID = new Guid("d8710641-8725-4c57-b537-d8cf69094d9a"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6717),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6718),
                            Quantity = 1000
                        },
                        new
                        {
                            BreadTypeID = new Guid("433b4492-be99-40c5-bd20-b32b909cdf2c"),
                            IngredientID = new Guid("328137cf-a8f4-498d-b724-37a2e56babe9"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6720),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6720),
                            Quantity = 280
                        },
                        new
                        {
                            BreadTypeID = new Guid("433b4492-be99-40c5-bd20-b32b909cdf2c"),
                            IngredientID = new Guid("07953a69-856e-4111-9785-c74ead722be3"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6722),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6723),
                            Quantity = 20
                        },
                        new
                        {
                            BreadTypeID = new Guid("433b4492-be99-40c5-bd20-b32b909cdf2c"),
                            IngredientID = new Guid("d0a9cf3f-5dad-4dfb-bfc3-0c3bc96b823d"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6725),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6726),
                            Quantity = 20
                        },
                        new
                        {
                            BreadTypeID = new Guid("433b4492-be99-40c5-bd20-b32b909cdf2c"),
                            IngredientID = new Guid("4716f6d0-2208-43ea-9645-fa9be0ad29c9"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6728),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6728),
                            Quantity = 80
                        },
                        new
                        {
                            BreadTypeID = new Guid("433b4492-be99-40c5-bd20-b32b909cdf2c"),
                            IngredientID = new Guid("dad68d5e-11c9-4ccb-8be8-9e136a30575c"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6730),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6731),
                            Quantity = 60
                        },
                        new
                        {
                            BreadTypeID = new Guid("433b4492-be99-40c5-bd20-b32b909cdf2c"),
                            IngredientID = new Guid("f20f6a62-ac9c-4139-bd3a-c938ad46a070"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6733),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6734),
                            Quantity = 100
                        },
                        new
                        {
                            BreadTypeID = new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"),
                            IngredientID = new Guid("d8710641-8725-4c57-b537-d8cf69094d9a"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6794),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6795),
                            Quantity = 55
                        },
                        new
                        {
                            BreadTypeID = new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"),
                            IngredientID = new Guid("328137cf-a8f4-498d-b724-37a2e56babe9"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6798),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6799),
                            Quantity = 25
                        },
                        new
                        {
                            BreadTypeID = new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"),
                            IngredientID = new Guid("07953a69-856e-4111-9785-c74ead722be3"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6801),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6802),
                            Quantity = 1
                        },
                        new
                        {
                            BreadTypeID = new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"),
                            IngredientID = new Guid("d0a9cf3f-5dad-4dfb-bfc3-0c3bc96b823d"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6804),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6805),
                            Quantity = 3
                        },
                        new
                        {
                            BreadTypeID = new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"),
                            IngredientID = new Guid("4716f6d0-2208-43ea-9645-fa9be0ad29c9"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6807),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6807),
                            Quantity = 6
                        },
                        new
                        {
                            BreadTypeID = new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"),
                            IngredientID = new Guid("8866ba3c-4028-440b-a8cd-4d9087de1f05"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6809),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6810),
                            Quantity = 10
                        },
                        new
                        {
                            BreadTypeID = new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"),
                            IngredientID = new Guid("dad68d5e-11c9-4ccb-8be8-9e136a30575c"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6812),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6813),
                            Quantity = 20
                        },
                        new
                        {
                            BreadTypeID = new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"),
                            IngredientID = new Guid("f20f6a62-ac9c-4139-bd3a-c938ad46a070"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6815),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6816),
                            Quantity = 10
                        },
                        new
                        {
                            BreadTypeID = new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"),
                            IngredientID = new Guid("a28fe0bd-dc14-4dc1-b9a4-de282052bc40"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6818),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6819),
                            Quantity = 2
                        },
                        new
                        {
                            BreadTypeID = new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"),
                            IngredientID = new Guid("956ee4b9-69c4-4ad4-939e-d4dd2579a9fa"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6820),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6821),
                            Quantity = 1
                        },
                        new
                        {
                            BreadTypeID = new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"),
                            IngredientID = new Guid("1c2e75e1-98f3-454a-947a-81f48f8807a1"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6823),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6824),
                            Quantity = 1
                        },
                        new
                        {
                            BreadTypeID = new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"),
                            IngredientID = new Guid("d8710641-8725-4c57-b537-d8cf69094d9a"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6826),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6827),
                            Quantity = 100
                        },
                        new
                        {
                            BreadTypeID = new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"),
                            IngredientID = new Guid("328137cf-a8f4-498d-b724-37a2e56babe9"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6828),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6829),
                            Quantity = 25
                        },
                        new
                        {
                            BreadTypeID = new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"),
                            IngredientID = new Guid("07953a69-856e-4111-9785-c74ead722be3"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6831),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6832),
                            Quantity = 2
                        },
                        new
                        {
                            BreadTypeID = new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"),
                            IngredientID = new Guid("d0a9cf3f-5dad-4dfb-bfc3-0c3bc96b823d"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6834),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6835),
                            Quantity = 4
                        },
                        new
                        {
                            BreadTypeID = new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"),
                            IngredientID = new Guid("4716f6d0-2208-43ea-9645-fa9be0ad29c9"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6837),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6837),
                            Quantity = 6
                        },
                        new
                        {
                            BreadTypeID = new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"),
                            IngredientID = new Guid("8866ba3c-4028-440b-a8cd-4d9087de1f05"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6839),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6840),
                            Quantity = 10
                        },
                        new
                        {
                            BreadTypeID = new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"),
                            IngredientID = new Guid("dad68d5e-11c9-4ccb-8be8-9e136a30575c"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6842),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6843),
                            Quantity = 5
                        },
                        new
                        {
                            BreadTypeID = new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"),
                            IngredientID = new Guid("f20f6a62-ac9c-4139-bd3a-c938ad46a070"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6845),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6846),
                            Quantity = 6
                        },
                        new
                        {
                            BreadTypeID = new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"),
                            IngredientID = new Guid("6492ebeb-0903-4acf-8f9d-74ed9be50c24"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6847),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6848),
                            Quantity = 25
                        },
                        new
                        {
                            BreadTypeID = new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"),
                            IngredientID = new Guid("c5d9f3fd-8ae1-4471-bc21-8e8878796430"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6850),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6851),
                            Quantity = 10
                        },
                        new
                        {
                            BreadTypeID = new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"),
                            IngredientID = new Guid("9b2ce295-f8dd-433d-8b92-a8e38fa7ca3f"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6853),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6854),
                            Quantity = 5
                        });
                });

            modelBuilder.Entity("Models.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d8710641-8725-4c57-b537-d8cf69094d9a"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6155),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6167),
                            Name = "Flour"
                        },
                        new
                        {
                            Id = new Guid("328137cf-a8f4-498d-b724-37a2e56babe9"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6176),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6177),
                            Name = "Water"
                        },
                        new
                        {
                            Id = new Guid("07953a69-856e-4111-9785-c74ead722be3"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6180),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6181),
                            Name = "Salt"
                        },
                        new
                        {
                            Id = new Guid("d0a9cf3f-5dad-4dfb-bfc3-0c3bc96b823d"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6183),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6184),
                            Name = "Yeast"
                        },
                        new
                        {
                            Id = new Guid("4716f6d0-2208-43ea-9645-fa9be0ad29c9"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6186),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6187),
                            Name = "Sugar"
                        },
                        new
                        {
                            Id = new Guid("dad68d5e-11c9-4ccb-8be8-9e136a30575c"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6189),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6190),
                            Name = "Milk"
                        },
                        new
                        {
                            Id = new Guid("f20f6a62-ac9c-4139-bd3a-c938ad46a070"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6192),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6193),
                            Name = "Butter"
                        },
                        new
                        {
                            Id = new Guid("8866ba3c-4028-440b-a8cd-4d9087de1f05"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6195),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6196),
                            Name = "Egg"
                        },
                        new
                        {
                            Id = new Guid("a28fe0bd-dc14-4dc1-b9a4-de282052bc40"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6198),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6199),
                            Name = "Honey"
                        },
                        new
                        {
                            Id = new Guid("956ee4b9-69c4-4ad4-939e-d4dd2579a9fa"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6201),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6202),
                            Name = "Lemon zest"
                        },
                        new
                        {
                            Id = new Guid("1c2e75e1-98f3-454a-947a-81f48f8807a1"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6204),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6205),
                            Name = "Vanilla essence"
                        },
                        new
                        {
                            Id = new Guid("6492ebeb-0903-4acf-8f9d-74ed9be50c24"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6207),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6208),
                            Name = "Sweet potato"
                        },
                        new
                        {
                            Id = new Guid("c5d9f3fd-8ae1-4471-bc21-8e8878796430"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6210),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6211),
                            Name = "Sesame seed"
                        },
                        new
                        {
                            Id = new Guid("9b2ce295-f8dd-433d-8b92-a8e38fa7ca3f"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6213),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6214),
                            Name = "Gilding"
                        });
                });

            modelBuilder.Entity("Models.Menu", b =>
                {
                    b.Property<Guid>("OfficeID")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(0);

                    b.Property<Guid>("BreadTypeID")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.HasKey("OfficeID", "BreadTypeID");

                    b.ToTable("Menu");

                    b.HasData(
                        new
                        {
                            OfficeID = new Guid("a5ee0236-be1f-4ee6-ba0f-9835a2a3edf3"),
                            BreadTypeID = new Guid("4ec5819b-7839-47f0-b265-ae91dd40eaed"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6953),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6954)
                        },
                        new
                        {
                            OfficeID = new Guid("a5ee0236-be1f-4ee6-ba0f-9835a2a3edf3"),
                            BreadTypeID = new Guid("433b4492-be99-40c5-bd20-b32b909cdf2c"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6957),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6958)
                        },
                        new
                        {
                            OfficeID = new Guid("a5ee0236-be1f-4ee6-ba0f-9835a2a3edf3"),
                            BreadTypeID = new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6960),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6961)
                        },
                        new
                        {
                            OfficeID = new Guid("a36757a5-708c-419e-8b5e-f6e04088eb14"),
                            BreadTypeID = new Guid("4ec5819b-7839-47f0-b265-ae91dd40eaed"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6962),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6963)
                        },
                        new
                        {
                            OfficeID = new Guid("a36757a5-708c-419e-8b5e-f6e04088eb14"),
                            BreadTypeID = new Guid("433b4492-be99-40c5-bd20-b32b909cdf2c"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6965),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6966)
                        },
                        new
                        {
                            OfficeID = new Guid("a36757a5-708c-419e-8b5e-f6e04088eb14"),
                            BreadTypeID = new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"),
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6968),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6969)
                        });
                });

            modelBuilder.Entity("Models.Office", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Direcction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Offices");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a5ee0236-be1f-4ee6-ba0f-9835a2a3edf3"),
                            Capacity = 150,
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6916),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6917),
                            Direcction = "742 Evergreen Terrace",
                            Name = "MAIN OFFICE",
                            Phone = "664 123 456"
                        },
                        new
                        {
                            Id = new Guid("a36757a5-708c-419e-8b5e-f6e04088eb14"),
                            Capacity = 100,
                            DateCreated = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6924),
                            DateModified = new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6925),
                            Direcction = "P Sherman, 42 Wallaby Sydney",
                            Name = "SECOND OFFICE",
                            Phone = "664 123 456"
                        });
                });

            modelBuilder.Entity("Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descripton")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OfficeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TotalPrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Models.OrderBreadType", b =>
                {
                    b.Property<Guid>("OrderID")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(0);

                    b.Property<Guid>("BreadTypeID")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderID", "BreadTypeID");

                    b.ToTable("OrderBreadTypes");
                });
#pragma warning restore 612, 618
        }
    }
}