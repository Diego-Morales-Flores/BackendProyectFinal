using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BakeryFreshBreadAPI.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Breads",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BreadName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CookingTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestingTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FermentTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CookingTemperature = table.Column<int>(type: "int", nullable: false),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BreadTypeIngredients",
                columns: table => new
                {
                    BreadTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IngredientID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreadTypeIngredients", x => new { x.BreadTypeID, x.IngredientID });
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    OfficeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BreadTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => new { x.OfficeID, x.BreadTypeID });
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direcction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderBreadTypes",
                columns: table => new
                {
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BreadTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderBreadTypes", x => new { x.OrderID, x.BreadTypeID });
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OfficeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripton = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BreadTypeIngredients",
                columns: new[] { "BreadTypeID", "IngredientID", "DateCreated", "DateModified", "Quantity" },
                values: new object[,]
                {
                    { new Guid("433b4492-be99-40c5-bd20-b32b909cdf2c"), new Guid("07953a69-856e-4111-9785-c74ead722be3"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6722), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6723), 20 },
                    { new Guid("433b4492-be99-40c5-bd20-b32b909cdf2c"), new Guid("328137cf-a8f4-498d-b724-37a2e56babe9"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6720), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6720), 280 },
                    { new Guid("433b4492-be99-40c5-bd20-b32b909cdf2c"), new Guid("4716f6d0-2208-43ea-9645-fa9be0ad29c9"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6728), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6728), 80 },
                    { new Guid("433b4492-be99-40c5-bd20-b32b909cdf2c"), new Guid("d0a9cf3f-5dad-4dfb-bfc3-0c3bc96b823d"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6725), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6726), 20 },
                    { new Guid("433b4492-be99-40c5-bd20-b32b909cdf2c"), new Guid("d8710641-8725-4c57-b537-d8cf69094d9a"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6717), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6718), 1000 },
                    { new Guid("433b4492-be99-40c5-bd20-b32b909cdf2c"), new Guid("dad68d5e-11c9-4ccb-8be8-9e136a30575c"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6730), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6731), 60 },
                    { new Guid("433b4492-be99-40c5-bd20-b32b909cdf2c"), new Guid("f20f6a62-ac9c-4139-bd3a-c938ad46a070"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6733), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6734), 100 },
                    { new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"), new Guid("07953a69-856e-4111-9785-c74ead722be3"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6801), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6802), 1 },
                    { new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"), new Guid("1c2e75e1-98f3-454a-947a-81f48f8807a1"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6823), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6824), 1 },
                    { new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"), new Guid("328137cf-a8f4-498d-b724-37a2e56babe9"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6798), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6799), 25 },
                    { new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"), new Guid("4716f6d0-2208-43ea-9645-fa9be0ad29c9"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6807), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6807), 6 },
                    { new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"), new Guid("8866ba3c-4028-440b-a8cd-4d9087de1f05"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6809), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6810), 10 },
                    { new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"), new Guid("956ee4b9-69c4-4ad4-939e-d4dd2579a9fa"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6820), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6821), 1 },
                    { new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"), new Guid("a28fe0bd-dc14-4dc1-b9a4-de282052bc40"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6818), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6819), 2 },
                    { new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"), new Guid("d0a9cf3f-5dad-4dfb-bfc3-0c3bc96b823d"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6804), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6805), 3 },
                    { new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"), new Guid("d8710641-8725-4c57-b537-d8cf69094d9a"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6794), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6795), 55 },
                    { new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"), new Guid("dad68d5e-11c9-4ccb-8be8-9e136a30575c"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6812), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6813), 20 },
                    { new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"), new Guid("f20f6a62-ac9c-4139-bd3a-c938ad46a070"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6815), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6816), 10 },
                    { new Guid("4ec5819b-7839-47f0-b265-ae91dd40eaed"), new Guid("07953a69-856e-4111-9785-c74ead722be3"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6711), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6712), 10 },
                    { new Guid("4ec5819b-7839-47f0-b265-ae91dd40eaed"), new Guid("328137cf-a8f4-498d-b724-37a2e56babe9"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6708), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6709), 210 },
                    { new Guid("4ec5819b-7839-47f0-b265-ae91dd40eaed"), new Guid("d0a9cf3f-5dad-4dfb-bfc3-0c3bc96b823d"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6713), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6714), 5 },
                    { new Guid("4ec5819b-7839-47f0-b265-ae91dd40eaed"), new Guid("d8710641-8725-4c57-b537-d8cf69094d9a"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6704), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6705), 280 },
                    { new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"), new Guid("07953a69-856e-4111-9785-c74ead722be3"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6831), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6832), 2 },
                    { new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"), new Guid("328137cf-a8f4-498d-b724-37a2e56babe9"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6828), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6829), 25 },
                    { new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"), new Guid("4716f6d0-2208-43ea-9645-fa9be0ad29c9"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6837), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6837), 6 },
                    { new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"), new Guid("6492ebeb-0903-4acf-8f9d-74ed9be50c24"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6847), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6848), 25 },
                    { new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"), new Guid("8866ba3c-4028-440b-a8cd-4d9087de1f05"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6839), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6840), 10 },
                    { new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"), new Guid("9b2ce295-f8dd-433d-8b92-a8e38fa7ca3f"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6853), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6854), 5 },
                    { new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"), new Guid("c5d9f3fd-8ae1-4471-bc21-8e8878796430"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6850), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6851), 10 },
                    { new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"), new Guid("d0a9cf3f-5dad-4dfb-bfc3-0c3bc96b823d"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6834), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6835), 4 },
                    { new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"), new Guid("d8710641-8725-4c57-b537-d8cf69094d9a"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6826), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6827), 100 },
                    { new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"), new Guid("dad68d5e-11c9-4ccb-8be8-9e136a30575c"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6842), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6843), 5 },
                    { new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"), new Guid("f20f6a62-ac9c-4139-bd3a-c938ad46a070"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6845), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6846), 6 }
                });

            migrationBuilder.InsertData(
                table: "Breads",
                columns: new[] { "Id", "BreadName", "CookingTemperature", "CookingTime", "DateCreated", "DateModified", "FermentTime", "Price", "Process", "RestingTime" },
                values: new object[,]
                {
                    { new Guid("433b4492-be99-40c5-bd20-b32b909cdf2c"), "WHITE BREAD", 180, "30 min", new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6669), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6670), "4 day", "2.5", "MIX, CUT, FERMENT, SHAPE, REST, COOK", "1 hr" },
                    { new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"), "MILK BREAD", 180, "15 min", new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6674), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6675), "4 hrs", "1.5", "MIX, CUT, REST, SHAPE, FERMENT, COOK", "10 min" },
                    { new Guid("4ec5819b-7839-47f0-b265-ae91dd40eaed"), "BAGUETTE", 270, "15 min", new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6655), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6656), "1 day", "2.0", "MIX, REST, FOLD, REST, FOLD, FERMENT, CUT, SHAPE, REST COOK", "0.5 hr" },
                    { new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"), "HAMBURGUER BUN", 180, "15 min", new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6679), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6680), "4 hrs", "1.0", "MIX, CUT, REST, SHAPE, FERMENT, PLACE, COOK", "0.5 hr" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name" },
                values: new object[,]
                {
                    { new Guid("07953a69-856e-4111-9785-c74ead722be3"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6180), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6181), "Salt" },
                    { new Guid("1c2e75e1-98f3-454a-947a-81f48f8807a1"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6204), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6205), "Vanilla essence" },
                    { new Guid("328137cf-a8f4-498d-b724-37a2e56babe9"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6176), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6177), "Water" },
                    { new Guid("4716f6d0-2208-43ea-9645-fa9be0ad29c9"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6186), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6187), "Sugar" },
                    { new Guid("6492ebeb-0903-4acf-8f9d-74ed9be50c24"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6207), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6208), "Sweet potato" },
                    { new Guid("8866ba3c-4028-440b-a8cd-4d9087de1f05"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6195), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6196), "Egg" },
                    { new Guid("956ee4b9-69c4-4ad4-939e-d4dd2579a9fa"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6201), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6202), "Lemon zest" },
                    { new Guid("9b2ce295-f8dd-433d-8b92-a8e38fa7ca3f"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6213), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6214), "Gilding" },
                    { new Guid("a28fe0bd-dc14-4dc1-b9a4-de282052bc40"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6198), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6199), "Honey" },
                    { new Guid("c5d9f3fd-8ae1-4471-bc21-8e8878796430"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6210), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6211), "Sesame seed" },
                    { new Guid("d0a9cf3f-5dad-4dfb-bfc3-0c3bc96b823d"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6183), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6184), "Yeast" },
                    { new Guid("d8710641-8725-4c57-b537-d8cf69094d9a"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6155), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6167), "Flour" },
                    { new Guid("dad68d5e-11c9-4ccb-8be8-9e136a30575c"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6189), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6190), "Milk" },
                    { new Guid("f20f6a62-ac9c-4139-bd3a-c938ad46a070"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6192), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6193), "Butter" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "BreadTypeID", "OfficeID", "DateCreated", "DateModified" },
                values: new object[,]
                {
                    { new Guid("433b4492-be99-40c5-bd20-b32b909cdf2c"), new Guid("a36757a5-708c-419e-8b5e-f6e04088eb14"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6965), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6966) },
                    { new Guid("4ec5819b-7839-47f0-b265-ae91dd40eaed"), new Guid("a36757a5-708c-419e-8b5e-f6e04088eb14"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6962), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6963) },
                    { new Guid("dbeae87f-18bc-4d51-bcc4-a838f9f4bc87"), new Guid("a36757a5-708c-419e-8b5e-f6e04088eb14"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6968), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6969) },
                    { new Guid("433b4492-be99-40c5-bd20-b32b909cdf2c"), new Guid("a5ee0236-be1f-4ee6-ba0f-9835a2a3edf3"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6957), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6958) },
                    { new Guid("4bb9d625-1352-4233-b929-b16f5e4b1403"), new Guid("a5ee0236-be1f-4ee6-ba0f-9835a2a3edf3"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6960), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6961) },
                    { new Guid("4ec5819b-7839-47f0-b265-ae91dd40eaed"), new Guid("a5ee0236-be1f-4ee6-ba0f-9835a2a3edf3"), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6953), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6954) }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Capacity", "DateCreated", "DateModified", "Direcction", "Name", "Phone" },
                values: new object[,]
                {
                    { new Guid("a36757a5-708c-419e-8b5e-f6e04088eb14"), 100, new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6924), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6925), "P Sherman, 42 Wallaby Sydney", "SECOND OFFICE", "664 123 456" },
                    { new Guid("a5ee0236-be1f-4ee6-ba0f-9835a2a3edf3"), 150, new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6916), new DateTime(2022, 12, 16, 17, 23, 37, 551, DateTimeKind.Local).AddTicks(6917), "742 Evergreen Terrace", "MAIN OFFICE", "664 123 456" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Breads");

            migrationBuilder.DropTable(
                name: "BreadTypeIngredients");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "OrderBreadTypes");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
