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
                    Puts = table.Column<int>(type: "int", nullable: false)
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
                values: new object[] { new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), "Krokhol golfklubb description", "Krokhol", false, 5000, 0 });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 18, 45, new Guid("c8ea1db6-ff62-4d10-9b31-85a0b4907725") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("0f225cdb-ea6c-4c8b-a9e8-7f0142d77852"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 5, 506, 5 },
                    { new Guid("3f116610-5582-4134-a2a5-8a8415bb2ba3"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 9, 330, 4 },
                    { new Guid("698f4e72-58e6-49a8-8f61-1d99fa9e87ff"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 2, 295, 4 },
                    { new Guid("9aa21e91-9c93-4814-9e14-33844a56b8d2"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 8, 298, 4 },
                    { new Guid("a2198e2b-e8ca-4fd7-ab17-ef53372929c1"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 3, 439, 5 },
                    { new Guid("ccbe7866-f87d-416d-9005-2c83f692c168"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 1, 113, 3 },
                    { new Guid("d6a0d440-91bf-4c9d-8fe9-1a6b7253d364"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 4, 128, 3 },
                    { new Guid("f86fdc20-765c-4322-944d-d82c922a5117"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 7, 270, 4 },
                    { new Guid("fb032fb2-00bc-4530-96a6-16fa60735e3e"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 6, 227, 4 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("029374f8-9a73-4f0e-abb5-2011f9aa65da"), 8, 2, new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"), 2 },
                    { new Guid("1aa749b4-92ce-4525-b560-ce8dc5f0fde6"), 9, 3, new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"), 4 },
                    { new Guid("34acdb17-6597-4dff-9a9e-2ef621558f01"), 3, 2, new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"), 3 },
                    { new Guid("6a5605b7-0743-4bf8-8b1a-f81ee20db643"), 7, 2, new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"), 5 },
                    { new Guid("72ed27ca-f7ac-4185-af42-dba88c9b7c32"), 4, 2, new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"), 3 },
                    { new Guid("880eb72d-d831-46d8-9f0f-a16f5d2d6894"), 5, 1, new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"), 4 },
                    { new Guid("a05107f0-559e-468c-aa07-84b1d9c97191"), 1, 2, new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"), 2 },
                    { new Guid("b96f693e-7be9-4931-9dba-864bd50e1e1e"), 6, 2, new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"), 4 },
                    { new Guid("fde41c1c-14bf-4acc-aa5e-1948e90ce733"), 2, 2, new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"), 6 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[] { new Guid("98b515ab-6b79-450d-88aa-3581a16119f0"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 52 });

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
