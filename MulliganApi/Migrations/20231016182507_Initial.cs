using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    Par = table.Column<int>(type: "int", nullable: false),
                    Has18Holes = table.Column<bool>(type: "bit", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false)
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
                    Strokes = table.Column<int>(type: "int", nullable: false),
                    Puts = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    Score = table.Column<int>(type: "int", nullable: false),
                    Puts = table.Column<int>(type: "int", nullable: false)
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
                columns: new[] { "Id", "CourseDescription", "CourseName", "Has18Holes", "Length", "Par" },
                values: new object[] { new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 0 });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Date", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 33, new Guid("08108351-b943-45df-9c19-52d95e6707c3") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("2900942b-962a-42dc-9727-c8ef6cdc215d"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), 3, 439, 5 },
                    { new Guid("3bf83bff-af68-493a-b1ac-6c28470fae16"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), 9, 330, 4 },
                    { new Guid("50420abb-c17f-4008-8403-72fdcc5a2398"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), 5, 506, 5 },
                    { new Guid("61d9af83-16d8-489c-866e-78c78e201c3f"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), 7, 270, 4 },
                    { new Guid("6291085e-2fdb-433c-bb79-5f7456936f49"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), 1, 113, 3 },
                    { new Guid("a2924e5f-4555-4420-acb0-7c9fa91cd20f"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), 8, 298, 4 },
                    { new Guid("b11f7da5-474d-4f20-92b9-1c7f137f4009"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), 4, 128, 3 },
                    { new Guid("f0b42efe-4c19-4cca-a79c-60509117ecad"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), 2, 295, 4 },
                    { new Guid("fc39dd36-4164-448c-b12d-62873c9f548c"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), 6, 227, 4 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("50d52b9f-5cbb-4ae0-b1ec-4d0988b3707f"), 9, 3, new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"), 4 },
                    { new Guid("563db00b-f159-4e66-801f-217f3dabd7bf"), 6, 2, new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"), 4 },
                    { new Guid("71643069-398f-4211-bb90-333e104f16c7"), 8, 2, new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"), 2 },
                    { new Guid("76d6830f-9d51-4077-9530-4de8ee34f72b"), 5, 1, new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"), 4 },
                    { new Guid("820873a1-a7d8-474d-857e-b188403cadb9"), 1, 2, new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"), 2 },
                    { new Guid("83ebea39-ab40-4dc6-a3f7-6880f02b553b"), 3, 2, new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"), 3 },
                    { new Guid("9d4a2364-ee8e-4b4f-8fc5-765ef48ad47e"), 2, 2, new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"), 6 },
                    { new Guid("af3c61fb-9bf1-4244-9c2b-db687584989e"), 4, 2, new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"), 3 },
                    { new Guid("c953e9a2-6c9a-4461-8278-bd04be904276"), 7, 2, new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"), 5 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[] { new Guid("d7fb7e19-1996-4e24-a4ac-e32f75a42910"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), 52 });

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
