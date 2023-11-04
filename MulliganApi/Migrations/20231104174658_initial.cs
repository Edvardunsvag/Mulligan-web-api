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
                    { new Guid("d3768131-c080-473d-8de0-acedea072d60"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 0 },
                    { new Guid("f460f95f-e682-408b-b585-181234cace6c"), "Grønmo golfklubb description", "Grønmo golfklubb", false, 2870, 0 }
                });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Date", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("d6ed0562-1142-4aa2-9e3f-a7fb821c0c1e"), new Guid("d3768131-c080-473d-8de0-acedea072d60"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 33, new Guid("12debba3-9ba6-41a9-a0a5-50f5704fe1c4") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("02d46e5d-5988-477d-bb53-743002b79daf"), new Guid("d3768131-c080-473d-8de0-acedea072d60"), 1, 113, 3 },
                    { new Guid("06abdc75-f9c9-429e-8c3c-d71e8710fe58"), new Guid("d3768131-c080-473d-8de0-acedea072d60"), 7, 270, 4 },
                    { new Guid("1f62c851-57d5-46e0-a547-065fbfa1a392"), new Guid("f460f95f-e682-408b-b585-181234cace6c"), 5, 127, 3 },
                    { new Guid("2586ec13-a3d2-46d1-8d6a-1fb2051d1ce6"), new Guid("f460f95f-e682-408b-b585-181234cace6c"), 9, 365, 4 },
                    { new Guid("2f20eebe-ded0-45f0-8263-ef183c1993e5"), new Guid("f460f95f-e682-408b-b585-181234cace6c"), 1, 494, 5 },
                    { new Guid("35c495ee-615c-4a36-84da-bb1e7c76a050"), new Guid("f460f95f-e682-408b-b585-181234cace6c"), 2, 266, 5 },
                    { new Guid("371d923a-fb3b-4dd7-b24e-f7e287794fb3"), new Guid("d3768131-c080-473d-8de0-acedea072d60"), 4, 128, 3 },
                    { new Guid("47d1d281-afe1-4058-b819-38e00fc0471c"), new Guid("f460f95f-e682-408b-b585-181234cace6c"), 8, 141, 3 },
                    { new Guid("5e619a47-cb70-43c3-9f42-09d07c0522e8"), new Guid("d3768131-c080-473d-8de0-acedea072d60"), 6, 227, 4 },
                    { new Guid("63892120-3f40-4b1d-ba41-288025ac65f8"), new Guid("f460f95f-e682-408b-b585-181234cace6c"), 3, 361, 4 },
                    { new Guid("7014a11b-f5a5-430f-b5fc-08fd837d0373"), new Guid("d3768131-c080-473d-8de0-acedea072d60"), 5, 506, 5 },
                    { new Guid("704875df-174f-46b9-ac47-032fc7cd5c4e"), new Guid("f460f95f-e682-408b-b585-181234cace6c"), 6, 337, 4 },
                    { new Guid("71eb5d35-48b0-4396-88de-320a2facc56b"), new Guid("d3768131-c080-473d-8de0-acedea072d60"), 9, 330, 4 },
                    { new Guid("91af6c59-2b9f-4875-ab68-afd5b666bafb"), new Guid("f460f95f-e682-408b-b585-181234cace6c"), 7, 412, 5 },
                    { new Guid("9c6bc41c-1b2d-43be-ad5a-5273c8d6f284"), new Guid("d3768131-c080-473d-8de0-acedea072d60"), 8, 298, 4 },
                    { new Guid("c4d2d0e7-5ebb-4269-8898-9baabf9b7792"), new Guid("f460f95f-e682-408b-b585-181234cace6c"), 4, 367, 4 },
                    { new Guid("cd4cf2d3-d95e-4537-b9d4-7a39e335eef4"), new Guid("d3768131-c080-473d-8de0-acedea072d60"), 3, 439, 5 },
                    { new Guid("d727106c-7a8b-40ff-b932-cf4de8250282"), new Guid("d3768131-c080-473d-8de0-acedea072d60"), 2, 295, 4 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Par", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("108193c4-0862-4778-b9a9-028afbc9ade3"), 2, 0, 2, new Guid("d6ed0562-1142-4aa2-9e3f-a7fb821c0c1e"), 6 },
                    { new Guid("1113a40c-e712-4774-a1de-82296b00a2d6"), 5, 0, 1, new Guid("d6ed0562-1142-4aa2-9e3f-a7fb821c0c1e"), 4 },
                    { new Guid("1bf59a75-7811-4cc3-be90-50760e23644c"), 9, 0, 3, new Guid("d6ed0562-1142-4aa2-9e3f-a7fb821c0c1e"), 4 },
                    { new Guid("3bd63512-8d7f-4cbc-bcf9-a2857087d093"), 3, 0, 2, new Guid("d6ed0562-1142-4aa2-9e3f-a7fb821c0c1e"), 3 },
                    { new Guid("51e32054-f18b-4211-9603-8612d7ab80f1"), 1, 0, 2, new Guid("d6ed0562-1142-4aa2-9e3f-a7fb821c0c1e"), 2 },
                    { new Guid("591fa5ea-5247-45a0-a8d4-ff4c95564ccb"), 7, 0, 2, new Guid("d6ed0562-1142-4aa2-9e3f-a7fb821c0c1e"), 5 },
                    { new Guid("8958ef32-356e-42b8-8266-f79db9496025"), 8, 0, 2, new Guid("d6ed0562-1142-4aa2-9e3f-a7fb821c0c1e"), 2 },
                    { new Guid("a970a466-c9ae-4ead-9020-fef4c1fe9e83"), 6, 0, 2, new Guid("d6ed0562-1142-4aa2-9e3f-a7fb821c0c1e"), 4 },
                    { new Guid("e1c153a2-a96d-4919-9c99-e85ee5315fae"), 4, 0, 2, new Guid("d6ed0562-1142-4aa2-9e3f-a7fb821c0c1e"), 3 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[,]
                {
                    { new Guid("68f3da4e-a1ba-4fb7-a5ee-e99e68ca70da"), new Guid("f460f95f-e682-408b-b585-181234cace6c"), 57 },
                    { new Guid("fae6f91b-1b31-4fd9-b147-88e1b55e5d6e"), new Guid("d3768131-c080-473d-8de0-acedea072d60"), 52 }
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
