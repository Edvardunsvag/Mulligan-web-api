using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class initiala : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Par = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Round",
                columns: table => new
                {
                    RoundId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Strokes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Round", x => x.RoundId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    VerificationToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PasswordResetToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResetTokenExpires = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseHole",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Par = table.Column<int>(type: "int", nullable: false),
                    HoleNumber = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseHole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseHole_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeeBoxes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeeBox = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeeBoxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeeBoxes_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoundHole",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoundId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoleNumber = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoundHole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoundHole_Round_RoundId",
                        column: x => x.RoundId,
                        principalTable: "Round",
                        principalColumn: "RoundId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Note",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoteText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Note_CourseHole_HoleId",
                        column: x => x.HoleId,
                        principalTable: "CourseHole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName", "Par" },
                values: new object[] { new Guid("1939f6f0-d52e-4198-8a22-ee86f1629056"), "Krokhol golfklubb description", "Krokhol", 0 });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Strokes", "UserId" },
                values: new object[] { new Guid("b1add512-3c5a-4f0f-b686-3605098da85e"), new Guid("1939f6f0-d52e-4198-8a22-ee86f1629056"), 45, new Guid("da926bbc-bf4c-45b8-9a96-9b02b6ddde7a") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("1a4f5b68-b2e8-4410-9e4c-57a45deafa8f"), new Guid("1939f6f0-d52e-4198-8a22-ee86f1629056"), 8, 298, 4 },
                    { new Guid("1e818065-bbbf-4a9b-82b2-f6dafb34bf79"), new Guid("1939f6f0-d52e-4198-8a22-ee86f1629056"), 5, 506, 5 },
                    { new Guid("259708bd-e50f-4a78-ae7c-c2a106637a2b"), new Guid("1939f6f0-d52e-4198-8a22-ee86f1629056"), 3, 439, 5 },
                    { new Guid("5b4ea064-2073-48c8-a149-62a7d708ec13"), new Guid("1939f6f0-d52e-4198-8a22-ee86f1629056"), 9, 330, 4 },
                    { new Guid("607078bc-75f7-4b19-b5fb-8c64f1349847"), new Guid("1939f6f0-d52e-4198-8a22-ee86f1629056"), 2, 295, 4 },
                    { new Guid("d4a4b792-b60c-45aa-81d3-c5e7e3e9efbe"), new Guid("1939f6f0-d52e-4198-8a22-ee86f1629056"), 6, 227, 4 },
                    { new Guid("d504b548-ecd1-4848-9ce8-a64aeb893254"), new Guid("1939f6f0-d52e-4198-8a22-ee86f1629056"), 4, 128, 3 },
                    { new Guid("e1f7337f-cce1-4f2c-9a8c-ea994f67e2c2"), new Guid("1939f6f0-d52e-4198-8a22-ee86f1629056"), 1, 113, 3 },
                    { new Guid("f6725d64-f56c-4fc9-86de-c1cf98753473"), new Guid("1939f6f0-d52e-4198-8a22-ee86f1629056"), 7, 270, 4 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("2262d45b-b0be-44b4-938f-1002077caa7b"), 5, new Guid("b1add512-3c5a-4f0f-b686-3605098da85e"), 4 },
                    { new Guid("307f24ea-04e7-42c8-a6d4-f228e50444b1"), 7, new Guid("b1add512-3c5a-4f0f-b686-3605098da85e"), 5 },
                    { new Guid("3a35c896-f929-4f6a-9754-429ff9f9ad25"), 1, new Guid("b1add512-3c5a-4f0f-b686-3605098da85e"), 2 },
                    { new Guid("3f48652f-500a-4f86-b5b8-d281311c8dd8"), 2, new Guid("b1add512-3c5a-4f0f-b686-3605098da85e"), 6 },
                    { new Guid("44ecc7cb-82ce-487d-9dbf-4719866e138c"), 6, new Guid("b1add512-3c5a-4f0f-b686-3605098da85e"), 4 },
                    { new Guid("5da681fa-5069-4bdc-b37a-baefbd6cf5e6"), 3, new Guid("b1add512-3c5a-4f0f-b686-3605098da85e"), 3 },
                    { new Guid("848f3234-ff41-4c2c-9c71-31d90a666829"), 4, new Guid("b1add512-3c5a-4f0f-b686-3605098da85e"), 3 },
                    { new Guid("ae327e63-ff49-4d83-98f8-b496da758c72"), 9, new Guid("b1add512-3c5a-4f0f-b686-3605098da85e"), 4 },
                    { new Guid("b9b43e25-53e7-4d78-b9fb-f25a02f50b3c"), 8, new Guid("b1add512-3c5a-4f0f-b686-3605098da85e"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[] { new Guid("54831e4f-4e5e-4a0d-ac63-a89bb61cd613"), new Guid("1939f6f0-d52e-4198-8a22-ee86f1629056"), 52 });

            migrationBuilder.CreateIndex(
                name: "IX_CourseHole_CourseId",
                table: "CourseHole",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_HoleId",
                table: "Note",
                column: "HoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoundHole_RoundId",
                table: "RoundHole",
                column: "RoundId");

            migrationBuilder.CreateIndex(
                name: "IX_TeeBoxes_CourseId",
                table: "TeeBoxes",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Note");

            migrationBuilder.DropTable(
                name: "RoundHole");

            migrationBuilder.DropTable(
                name: "TeeBoxes");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "CourseHole");

            migrationBuilder.DropTable(
                name: "Round");

            migrationBuilder.DropTable(
                name: "Course");
        }
    }
}
