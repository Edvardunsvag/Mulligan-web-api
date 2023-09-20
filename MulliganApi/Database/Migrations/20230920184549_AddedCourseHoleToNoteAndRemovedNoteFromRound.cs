using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedCourseHoleToNoteAndRemovedNoteFromRound : Migration
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
                    CourseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    courseHoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Note_CourseHole_courseHoleId",
                        column: x => x.courseHoleId,
                        principalTable: "CourseHole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName" },
                values: new object[] { new Guid("d5a4c618-d009-43bb-82fe-3c5dc1d72a0a"), "Krokhol golfklubb description", "Krokhol" });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Strokes", "UserId" },
                values: new object[] { new Guid("8c9a491a-2615-4fba-a862-190a5cc95aaf"), new Guid("d5a4c618-d009-43bb-82fe-3c5dc1d72a0a"), 45, new Guid("3dd1d758-2124-4a0a-b5b8-0984c5e01def") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("079991cb-a173-4300-8cfe-d7630f4ab95f"), new Guid("d5a4c618-d009-43bb-82fe-3c5dc1d72a0a"), 5, 506, 5 },
                    { new Guid("5affd5d2-eed2-4a0f-8838-ffe4d23a36c1"), new Guid("d5a4c618-d009-43bb-82fe-3c5dc1d72a0a"), 2, 295, 4 },
                    { new Guid("908d0b7b-d68d-4ec6-a7e1-ac463686e9cf"), new Guid("d5a4c618-d009-43bb-82fe-3c5dc1d72a0a"), 7, 270, 4 },
                    { new Guid("a4041df2-34f2-4e94-9690-476ee95406a9"), new Guid("d5a4c618-d009-43bb-82fe-3c5dc1d72a0a"), 4, 128, 3 },
                    { new Guid("e07a33f8-7a45-4fd1-add7-356951d69087"), new Guid("d5a4c618-d009-43bb-82fe-3c5dc1d72a0a"), 1, 113, 3 },
                    { new Guid("eefca9a2-1693-4d36-852b-05ffc78d7a0f"), new Guid("d5a4c618-d009-43bb-82fe-3c5dc1d72a0a"), 9, 330, 4 },
                    { new Guid("f0a41fb3-db45-4784-9c4b-702aa536b599"), new Guid("d5a4c618-d009-43bb-82fe-3c5dc1d72a0a"), 3, 439, 5 },
                    { new Guid("f632db8c-6cdb-4965-bbd8-532e445a9769"), new Guid("d5a4c618-d009-43bb-82fe-3c5dc1d72a0a"), 6, 227, 4 },
                    { new Guid("f7147e26-0c6d-4b36-8742-451d08932046"), new Guid("d5a4c618-d009-43bb-82fe-3c5dc1d72a0a"), 8, 298, 4 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("1f14f71b-c841-4ab4-80ae-61c7f9365895"), 1, new Guid("8c9a491a-2615-4fba-a862-190a5cc95aaf"), 2 },
                    { new Guid("278a7002-29a1-4e26-ab69-1626e3fa927d"), 7, new Guid("8c9a491a-2615-4fba-a862-190a5cc95aaf"), 5 },
                    { new Guid("2a7a6ed2-c50b-4452-9875-b22e60dac3a2"), 4, new Guid("8c9a491a-2615-4fba-a862-190a5cc95aaf"), 3 },
                    { new Guid("4605defc-3128-4f51-a802-b0fb060a4bce"), 8, new Guid("8c9a491a-2615-4fba-a862-190a5cc95aaf"), 2 },
                    { new Guid("7907369a-8836-423f-8af3-857a232dd2e6"), 9, new Guid("8c9a491a-2615-4fba-a862-190a5cc95aaf"), 4 },
                    { new Guid("932ea025-5d64-439e-ae25-5382d21b0faf"), 3, new Guid("8c9a491a-2615-4fba-a862-190a5cc95aaf"), 3 },
                    { new Guid("b0e4e7c1-7b4a-4e7d-80c0-17469ac9136a"), 5, new Guid("8c9a491a-2615-4fba-a862-190a5cc95aaf"), 4 },
                    { new Guid("f118b5ec-d876-4ee9-b5a3-94398005b082"), 2, new Guid("8c9a491a-2615-4fba-a862-190a5cc95aaf"), 6 },
                    { new Guid("f3c594e2-778a-4087-8c6a-a79f07cfef55"), 6, new Guid("8c9a491a-2615-4fba-a862-190a5cc95aaf"), 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseHole_CourseId",
                table: "CourseHole",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_courseHoleId",
                table: "Note",
                column: "courseHoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoundHole_RoundId",
                table: "RoundHole",
                column: "RoundId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Note");

            migrationBuilder.DropTable(
                name: "RoundHole");

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
