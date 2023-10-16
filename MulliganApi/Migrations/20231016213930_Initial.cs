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
                values: new object[] { new Guid("9f73001c-5cce-4682-ba74-6252a7394089"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 0 });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Date", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("e8f50966-e2fe-4ff1-88ed-8bb6964de06e"), new Guid("9f73001c-5cce-4682-ba74-6252a7394089"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 33, new Guid("4d6ff1f3-9c7e-4b5b-b42c-632b0b3d8acb") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("028cd1c8-c7f8-4baf-bb42-8aad0b600775"), new Guid("9f73001c-5cce-4682-ba74-6252a7394089"), 5, 506, 5 },
                    { new Guid("1711bf0b-6a33-421b-a81b-f0372394da7f"), new Guid("9f73001c-5cce-4682-ba74-6252a7394089"), 4, 128, 3 },
                    { new Guid("3b25981d-d5a5-4908-87f9-dd958d3a7a2b"), new Guid("9f73001c-5cce-4682-ba74-6252a7394089"), 8, 298, 4 },
                    { new Guid("3bc55b1d-05c3-4b68-b09a-7bd6fe1af667"), new Guid("9f73001c-5cce-4682-ba74-6252a7394089"), 1, 113, 3 },
                    { new Guid("6bcd4947-4bb6-432b-ae67-36656fe76e32"), new Guid("9f73001c-5cce-4682-ba74-6252a7394089"), 2, 295, 4 },
                    { new Guid("bcd56576-1e57-455d-b482-7940e229ff7d"), new Guid("9f73001c-5cce-4682-ba74-6252a7394089"), 6, 227, 4 },
                    { new Guid("cdef83d0-6d57-4e29-8191-8af94c76e5bb"), new Guid("9f73001c-5cce-4682-ba74-6252a7394089"), 3, 439, 5 },
                    { new Guid("de28f3fe-9229-40c5-a5db-50e7e3c4931f"), new Guid("9f73001c-5cce-4682-ba74-6252a7394089"), 9, 330, 4 },
                    { new Guid("e6d89905-d617-469f-ae3a-983d77bc459a"), new Guid("9f73001c-5cce-4682-ba74-6252a7394089"), 7, 270, 4 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("005b2304-5cfa-4e9f-bd07-38df848af026"), 9, 3, new Guid("e8f50966-e2fe-4ff1-88ed-8bb6964de06e"), 4 },
                    { new Guid("19cf368f-5b98-4e95-9c43-b942f7392fa0"), 1, 2, new Guid("e8f50966-e2fe-4ff1-88ed-8bb6964de06e"), 2 },
                    { new Guid("33d24984-81b9-4155-a3df-7d8cb3315ff3"), 7, 2, new Guid("e8f50966-e2fe-4ff1-88ed-8bb6964de06e"), 5 },
                    { new Guid("5d22101a-00e9-47c5-b2b6-9955d45a37f0"), 6, 2, new Guid("e8f50966-e2fe-4ff1-88ed-8bb6964de06e"), 4 },
                    { new Guid("6f1a479f-afe7-4d96-ae4e-ae65e4906112"), 8, 2, new Guid("e8f50966-e2fe-4ff1-88ed-8bb6964de06e"), 2 },
                    { new Guid("7568a465-ca43-4ef8-92a5-890811aa3926"), 5, 1, new Guid("e8f50966-e2fe-4ff1-88ed-8bb6964de06e"), 4 },
                    { new Guid("c398e7b9-2ec4-4147-96ef-19fb7999a5c5"), 2, 2, new Guid("e8f50966-e2fe-4ff1-88ed-8bb6964de06e"), 6 },
                    { new Guid("dbec5194-1a67-4c42-85d8-8648f69dd289"), 4, 2, new Guid("e8f50966-e2fe-4ff1-88ed-8bb6964de06e"), 3 },
                    { new Guid("f2f44f0b-bc7f-4ae3-b308-057cd0333a64"), 3, 2, new Guid("e8f50966-e2fe-4ff1-88ed-8bb6964de06e"), 3 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[] { new Guid("6614dfa8-1cd3-4195-a08b-52e891455b36"), new Guid("9f73001c-5cce-4682-ba74-6252a7394089"), 52 });

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
