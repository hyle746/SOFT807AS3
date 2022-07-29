using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BBA.Data.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookID);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1cfeb72d-5d8a-46f8-9ce6-fbc0bcd99f5d", 0, "bcb818e1-99ef-4260-b1f9-2410f09de950", "ApplicationUser", "admin@bba.co.nz", true, false, null, "ADMIN@BBA.CO.NZ", "ADMIN@BBA.CO.NZ", "AQAAAAEAACcQAAAAENi2PlElJGUfeH+tY6xFmtSO0sX5kMBL+EDUE+7Hhb9djL7ZDcm/TkRM1XZAqbFedQ==", "123456789", true, "22b39969-57db-4cc9-810c-b78c8d90bafe", false, "admin@bba.co.nz" },
                    { "ccf54229-2819-42eb-bd10-81254f86034f", 0, "06c202bb-12c4-4bf6-8d4d-f0fa220af411", "ApplicationUser", "customer@bba.co.nz", true, false, null, "CUSTOMER@BBA.CO.NZ", "CUSTOMER@BBA.CO.NZ", "AQAAAAEAACcQAAAAECZBRqi30AzlG3dOngNC74G7qp4lzOzHem7rq6nCwjK2YCn1TtUhk2nCGKxAz8Bx4g==", null, true, "e1f55c3f-e2ae-4f99-8527-7f8974674a70", false, "customer@bba.co.nz" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookID", "Author", "BookImage", "Description", "Genre", "Publisher", "Title" },
                values: new object[,]
                {
                    { 1, "Heather Christle", "e43bf711-67bd-48cb-992c-9e95488492c9-9781948226448_grande.webp", "Award-winning poet Heather Christle has just lost a dear friend to suicide and must reckon with her own struggles with depression and the birth of her first child. How she faces her joy, grief, anxiety, impending motherhood, and conflicted truce with the world results in a moving meditation on the nature, rapture, and perils of crying―from the history of tear-catching gadgets (including the woman who designed a gun that shoots tears) to the science behind animal tears (including moths who drink them) to the fraught role of white women's tears in racist violence.", "Other", "Catapult", "The Crying Book" },
                    { 2, "Tester", null, "Some description here.", "Crime", "Paper company", "Sample Book" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1cfeb72d-5d8a-46f8-9ce6-fbc0bcd99f5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ccf54229-2819-42eb-bd10-81254f86034f");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
