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
                    { new Guid("63000723-111e-4929-91e6-c25bd8072e74"), "Grønmo golfklubb description", "Grønmo golfklubb", false, 2870, 37 },
                    { new Guid("765df59f-c3e8-4952-818e-10b5f25bc26b"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 36 }
                });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Date", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("6d6bd9b9-9c0e-4aaa-ac7b-84728d7daf80"), new Guid("765df59f-c3e8-4952-818e-10b5f25bc26b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 33, new Guid("3b6b597d-3229-439f-acb5-14e8b7ced20f") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("011a8261-d8b2-4db8-8a45-0e95cad819fc"), new Guid("63000723-111e-4929-91e6-c25bd8072e74"), 3, 361, 4 },
                    { new Guid("0de108be-ad50-48ce-8ffa-c97de26de5c0"), new Guid("63000723-111e-4929-91e6-c25bd8072e74"), 9, 365, 4 },
                    { new Guid("19700d58-c005-4ebb-a055-331a56415cc7"), new Guid("63000723-111e-4929-91e6-c25bd8072e74"), 1, 494, 5 },
                    { new Guid("1d6267e2-075d-49c8-aa40-b621cd58039b"), new Guid("63000723-111e-4929-91e6-c25bd8072e74"), 6, 337, 4 },
                    { new Guid("1e16e3bc-3a96-4a7d-b4aa-30a50e64c714"), new Guid("765df59f-c3e8-4952-818e-10b5f25bc26b"), 3, 439, 5 },
                    { new Guid("203eb9d2-b3b4-406d-8ee5-850466fef3b7"), new Guid("63000723-111e-4929-91e6-c25bd8072e74"), 8, 141, 3 },
                    { new Guid("2828cef8-9f2f-46b8-b4fc-170e3b75f1ea"), new Guid("765df59f-c3e8-4952-818e-10b5f25bc26b"), 1, 113, 3 },
                    { new Guid("3937d1b1-a709-41b5-958e-d364c28acc28"), new Guid("765df59f-c3e8-4952-818e-10b5f25bc26b"), 8, 298, 4 },
                    { new Guid("3e9619ba-dd9b-42d3-aa55-cc24bac02777"), new Guid("765df59f-c3e8-4952-818e-10b5f25bc26b"), 9, 330, 4 },
                    { new Guid("4ff9a4c1-7883-4f6d-9051-a3e0421a4861"), new Guid("63000723-111e-4929-91e6-c25bd8072e74"), 2, 266, 5 },
                    { new Guid("52f1d5ff-e33e-41ed-80e6-3acb64884971"), new Guid("765df59f-c3e8-4952-818e-10b5f25bc26b"), 5, 506, 5 },
                    { new Guid("7be94ef3-0b9c-4ebe-b3bb-92f58d86d89b"), new Guid("63000723-111e-4929-91e6-c25bd8072e74"), 4, 367, 4 },
                    { new Guid("85b09f55-b498-4f71-922d-c9ed8f1c3108"), new Guid("765df59f-c3e8-4952-818e-10b5f25bc26b"), 7, 270, 4 },
                    { new Guid("95616e1f-dc91-4c34-8a08-a5ae582b53d7"), new Guid("63000723-111e-4929-91e6-c25bd8072e74"), 7, 412, 5 },
                    { new Guid("96dc33c4-9e19-456a-8983-1035ccd6b8f5"), new Guid("765df59f-c3e8-4952-818e-10b5f25bc26b"), 4, 128, 3 },
                    { new Guid("eb133c6b-08ac-44a6-bbb0-b458b77f034a"), new Guid("765df59f-c3e8-4952-818e-10b5f25bc26b"), 2, 295, 4 },
                    { new Guid("f3167de7-b558-4453-8e36-ac8d964e5fd0"), new Guid("765df59f-c3e8-4952-818e-10b5f25bc26b"), 6, 227, 4 },
                    { new Guid("f9f6a439-29c5-48e9-8bb1-a816c77d7c0d"), new Guid("63000723-111e-4929-91e6-c25bd8072e74"), 5, 127, 3 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Par", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("21aeae75-fef4-4c47-add3-a078cd74c296"), 7, 0, 2, new Guid("6d6bd9b9-9c0e-4aaa-ac7b-84728d7daf80"), 5 },
                    { new Guid("21df039e-0075-47e8-9494-ae2bd95f8329"), 5, 0, 1, new Guid("6d6bd9b9-9c0e-4aaa-ac7b-84728d7daf80"), 4 },
                    { new Guid("44934452-41a1-402d-8cad-e66752b75be5"), 1, 0, 2, new Guid("6d6bd9b9-9c0e-4aaa-ac7b-84728d7daf80"), 2 },
                    { new Guid("59d355a8-df78-4bed-aa55-32dbce47d875"), 6, 0, 2, new Guid("6d6bd9b9-9c0e-4aaa-ac7b-84728d7daf80"), 4 },
                    { new Guid("61f66490-adf9-4f0c-ba76-d427aab16339"), 8, 0, 2, new Guid("6d6bd9b9-9c0e-4aaa-ac7b-84728d7daf80"), 2 },
                    { new Guid("986a20ce-48da-499c-a369-d3b5ec6126b9"), 4, 0, 2, new Guid("6d6bd9b9-9c0e-4aaa-ac7b-84728d7daf80"), 3 },
                    { new Guid("9c5ec71c-23a9-4cf0-add6-dc95fddf772b"), 9, 0, 3, new Guid("6d6bd9b9-9c0e-4aaa-ac7b-84728d7daf80"), 4 },
                    { new Guid("ef73b9ee-b93c-4bc9-9843-4e3227b6e133"), 3, 0, 2, new Guid("6d6bd9b9-9c0e-4aaa-ac7b-84728d7daf80"), 3 },
                    { new Guid("fd7d736c-b302-41b9-95ec-e339294eb591"), 2, 0, 2, new Guid("6d6bd9b9-9c0e-4aaa-ac7b-84728d7daf80"), 6 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[,]
                {
                    { new Guid("70d1414c-7580-440a-8216-392c8f5197be"), new Guid("63000723-111e-4929-91e6-c25bd8072e74"), 57 },
                    { new Guid("bc04c0ac-2c3b-4a11-9439-69d99f4846f1"), new Guid("765df59f-c3e8-4952-818e-10b5f25bc26b"), 52 }
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
