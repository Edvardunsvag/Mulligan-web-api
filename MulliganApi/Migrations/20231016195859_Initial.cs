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
                values: new object[] { new Guid("2c8ee096-a49b-4ae2-bfd5-8f8e5440b72c"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 0 });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Date", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("d80c53a2-3dcd-4c89-9f91-bd69d6be8c73"), new Guid("2c8ee096-a49b-4ae2-bfd5-8f8e5440b72c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 33, new Guid("d2395527-e513-47bf-a4b8-ed71dd533c9b") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("2ff332b6-4063-467d-9093-0f3f71db2600"), new Guid("2c8ee096-a49b-4ae2-bfd5-8f8e5440b72c"), 5, 506, 5 },
                    { new Guid("35e1a3b3-d14d-46a4-8833-b1035b9a53c2"), new Guid("2c8ee096-a49b-4ae2-bfd5-8f8e5440b72c"), 3, 439, 5 },
                    { new Guid("3ce07f9a-2127-4eba-a63d-faeded8f4513"), new Guid("2c8ee096-a49b-4ae2-bfd5-8f8e5440b72c"), 6, 227, 4 },
                    { new Guid("4f011f0a-610b-45b8-8f65-946b289bff19"), new Guid("2c8ee096-a49b-4ae2-bfd5-8f8e5440b72c"), 9, 330, 4 },
                    { new Guid("67632ff3-90f0-497e-8308-3d2e53c6c901"), new Guid("2c8ee096-a49b-4ae2-bfd5-8f8e5440b72c"), 7, 270, 4 },
                    { new Guid("8907b974-062f-4d86-9c91-4979cf1cb88b"), new Guid("2c8ee096-a49b-4ae2-bfd5-8f8e5440b72c"), 1, 113, 3 },
                    { new Guid("a710143e-0331-4e86-860b-c73c60be63a6"), new Guid("2c8ee096-a49b-4ae2-bfd5-8f8e5440b72c"), 4, 128, 3 },
                    { new Guid("d825bda6-52c6-425a-a0e0-0acecc8d4cd0"), new Guid("2c8ee096-a49b-4ae2-bfd5-8f8e5440b72c"), 2, 295, 4 },
                    { new Guid("dd94fad2-f5ba-4a00-8f7c-5bff10b4f378"), new Guid("2c8ee096-a49b-4ae2-bfd5-8f8e5440b72c"), 8, 298, 4 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("04c9d4a0-1977-48ca-8f30-73ff98bca0b0"), 8, 2, new Guid("d80c53a2-3dcd-4c89-9f91-bd69d6be8c73"), 2 },
                    { new Guid("0bd7d4c1-aa84-463c-9087-ede284dd0931"), 2, 2, new Guid("d80c53a2-3dcd-4c89-9f91-bd69d6be8c73"), 6 },
                    { new Guid("451314cc-3b0b-4a42-9c7c-643ff5bcf53f"), 4, 2, new Guid("d80c53a2-3dcd-4c89-9f91-bd69d6be8c73"), 3 },
                    { new Guid("5a143ab5-e846-47db-aea5-1fd7454c0f7c"), 6, 2, new Guid("d80c53a2-3dcd-4c89-9f91-bd69d6be8c73"), 4 },
                    { new Guid("5f305f32-aa9a-4f51-b919-f40faf5555ce"), 5, 1, new Guid("d80c53a2-3dcd-4c89-9f91-bd69d6be8c73"), 4 },
                    { new Guid("75f99277-522c-4d27-a52a-46711ddca27c"), 7, 2, new Guid("d80c53a2-3dcd-4c89-9f91-bd69d6be8c73"), 5 },
                    { new Guid("8f1662d0-4732-4c46-bee6-2c4e7be8a8cb"), 3, 2, new Guid("d80c53a2-3dcd-4c89-9f91-bd69d6be8c73"), 3 },
                    { new Guid("9f6e3b42-ffa7-4cec-9b14-e2f0ad4ce9dd"), 9, 3, new Guid("d80c53a2-3dcd-4c89-9f91-bd69d6be8c73"), 4 },
                    { new Guid("a5d0d99f-8a83-4439-890e-511eebed7328"), 1, 2, new Guid("d80c53a2-3dcd-4c89-9f91-bd69d6be8c73"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[] { new Guid("a170e173-1fb5-4f6d-ad8f-4ad1030ed1d7"), new Guid("2c8ee096-a49b-4ae2-bfd5-8f8e5440b72c"), 52 });

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
