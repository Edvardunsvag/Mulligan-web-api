using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Database.migrations
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
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    VerificationToken = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Par = table.Column<int>(type: "int", nullable: false),
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
                name: "UserRating",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RatingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRating_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
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
                values: new object[,]
                {
                    { new Guid("1a993ed4-841f-4cdd-baac-81f170e66f0d"), "Grønmo golfklubb description", "Grønmo golfklubb", false, 2870, 37 },
                    { new Guid("ff1d75b1-b9ec-4f99-b007-f204c42abb1d"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 36 }
                });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("35ee1143-e546-4e68-8fbf-e535a58ebbf7"), new Guid("ff1d75b1-b9ec-4f99-b007-f204c42abb1d"), 1, 113, 3 },
                    { new Guid("48ced368-512e-4429-9b49-a240acac040c"), new Guid("1a993ed4-841f-4cdd-baac-81f170e66f0d"), 5, 127, 3 },
                    { new Guid("5980a636-f583-4beb-9860-0a1524a4b7b6"), new Guid("1a993ed4-841f-4cdd-baac-81f170e66f0d"), 6, 337, 4 },
                    { new Guid("5c4eab66-2d77-41cf-ad83-014bb886013f"), new Guid("1a993ed4-841f-4cdd-baac-81f170e66f0d"), 2, 266, 5 },
                    { new Guid("68f13970-ffd8-4f9f-b203-a09cd4388319"), new Guid("1a993ed4-841f-4cdd-baac-81f170e66f0d"), 8, 141, 3 },
                    { new Guid("77c2ff0b-288e-4f7a-bce4-2aa6fa57f46e"), new Guid("ff1d75b1-b9ec-4f99-b007-f204c42abb1d"), 8, 298, 4 },
                    { new Guid("85e17aad-60df-462b-a3ca-601c36176c0a"), new Guid("1a993ed4-841f-4cdd-baac-81f170e66f0d"), 7, 412, 5 },
                    { new Guid("88ba968e-965f-4190-85f6-32eb1a30f4b1"), new Guid("1a993ed4-841f-4cdd-baac-81f170e66f0d"), 4, 367, 4 },
                    { new Guid("912b0dc1-9121-4f5e-a3fb-8acff229a45b"), new Guid("ff1d75b1-b9ec-4f99-b007-f204c42abb1d"), 3, 439, 5 },
                    { new Guid("9ee77ff2-edcb-4ee7-a03b-0a786fcd4bd7"), new Guid("ff1d75b1-b9ec-4f99-b007-f204c42abb1d"), 7, 270, 4 },
                    { new Guid("ab2bde69-1210-4444-b6f5-aee691e6dc78"), new Guid("1a993ed4-841f-4cdd-baac-81f170e66f0d"), 9, 365, 4 },
                    { new Guid("b95bf5ff-59bd-4fe9-9387-b6dd14e25de0"), new Guid("ff1d75b1-b9ec-4f99-b007-f204c42abb1d"), 4, 128, 3 },
                    { new Guid("c7623d09-4766-477b-815f-ef4a478a48b9"), new Guid("ff1d75b1-b9ec-4f99-b007-f204c42abb1d"), 2, 295, 4 },
                    { new Guid("d1267429-61c8-4ed9-945b-5fb8125b6b5f"), new Guid("ff1d75b1-b9ec-4f99-b007-f204c42abb1d"), 9, 330, 4 },
                    { new Guid("d24bf1c5-57b8-4f9a-945a-3ee29e908039"), new Guid("ff1d75b1-b9ec-4f99-b007-f204c42abb1d"), 6, 227, 4 },
                    { new Guid("d9a8bdaf-2f29-43b1-9d6b-d49a44021c37"), new Guid("1a993ed4-841f-4cdd-baac-81f170e66f0d"), 1, 494, 5 },
                    { new Guid("da5b21ba-d785-42c5-ba3d-3027267c56a6"), new Guid("ff1d75b1-b9ec-4f99-b007-f204c42abb1d"), 5, 506, 5 },
                    { new Guid("f4510dbd-044f-43aa-b8dc-6121b0975769"), new Guid("1a993ed4-841f-4cdd-baac-81f170e66f0d"), 3, 361, 4 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[,]
                {
                    { new Guid("17f97eb4-d938-47e9-b680-a0d64960212c"), new Guid("1a993ed4-841f-4cdd-baac-81f170e66f0d"), 57 },
                    { new Guid("1abbd009-9cb4-4578-af1b-9e8422459da1"), new Guid("ff1d75b1-b9ec-4f99-b007-f204c42abb1d"), 52 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserRating_UserId",
                table: "UserRating",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");
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
                name: "UserRating");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "CourseHole");

            migrationBuilder.DropTable(
                name: "Round");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Course");
        }
    }
}
