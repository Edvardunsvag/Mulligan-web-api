using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
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
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                values: new object[] { new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 0 });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Date", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("0bb628fd-7525-4d27-81f7-9b3c736a3e58"), new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 33, new Guid("814077ba-4ccc-4329-a84b-dc8264d7e1ff") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("0feb56a8-8da9-4049-a112-6f3c8a270f58"), new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"), 8, 298, 4 },
                    { new Guid("4315bd89-86ab-434e-af38-021068d0c3fa"), new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"), 1, 113, 3 },
                    { new Guid("4b734475-89c5-4942-b82b-ca32587dd092"), new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"), 2, 295, 4 },
                    { new Guid("61bf2f78-d0ba-4e54-8742-64dc730e4ac4"), new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"), 4, 128, 3 },
                    { new Guid("8684c5d0-4e0a-4259-bea4-465feeb5ef24"), new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"), 6, 227, 4 },
                    { new Guid("a7b18268-5dc1-422c-a30f-784cc541df7e"), new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"), 9, 330, 4 },
                    { new Guid("acedd4c6-f340-4030-a5ec-6d80b7bd34c1"), new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"), 7, 270, 4 },
                    { new Guid("b36aa4d7-417b-44a9-8796-92d205f05169"), new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"), 5, 506, 5 },
                    { new Guid("cc68bd7f-3179-433e-a089-0276931e4c9c"), new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"), 3, 439, 5 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("0a78eb49-f22f-4c42-9030-88ff392f8161"), 4, 2, new Guid("0bb628fd-7525-4d27-81f7-9b3c736a3e58"), 3 },
                    { new Guid("24fa0d90-2f63-4857-9fcb-c89ef4f71c8f"), 5, 1, new Guid("0bb628fd-7525-4d27-81f7-9b3c736a3e58"), 4 },
                    { new Guid("2ee30590-624c-4d2b-bb8e-755fae575561"), 6, 2, new Guid("0bb628fd-7525-4d27-81f7-9b3c736a3e58"), 4 },
                    { new Guid("668bf063-51c0-42ad-bf82-60af8ad75b82"), 1, 2, new Guid("0bb628fd-7525-4d27-81f7-9b3c736a3e58"), 2 },
                    { new Guid("af65d9c7-579a-4d26-bec7-3f6ee0060141"), 3, 2, new Guid("0bb628fd-7525-4d27-81f7-9b3c736a3e58"), 3 },
                    { new Guid("bebf8ba0-8082-4a24-935b-c96f667a79a8"), 9, 3, new Guid("0bb628fd-7525-4d27-81f7-9b3c736a3e58"), 4 },
                    { new Guid("bf44472a-d9aa-495f-9e7e-30de1452adc1"), 8, 2, new Guid("0bb628fd-7525-4d27-81f7-9b3c736a3e58"), 2 },
                    { new Guid("c8225fb7-6d51-4cf1-a8cb-3bb04abb8a5c"), 2, 2, new Guid("0bb628fd-7525-4d27-81f7-9b3c736a3e58"), 6 },
                    { new Guid("cc91d836-5029-479f-95d2-a3502ae5b028"), 7, 2, new Guid("0bb628fd-7525-4d27-81f7-9b3c736a3e58"), 5 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[] { new Guid("f1dc6a8c-1b3f-4af8-8c27-5ffca36634af"), new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"), 52 });

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
