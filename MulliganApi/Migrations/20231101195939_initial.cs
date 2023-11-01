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
                    { new Guid("6e75c96b-c72f-4506-8e72-e70a96f30b07"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 0 },
                    { new Guid("ff4da611-b939-421f-9cab-ea9834f08e81"), "Grønmo golfklubb description", "Grønmo golfklubb", false, 2870, 0 }
                });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Date", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("4ca40883-4e89-44b6-87cc-396b3c5f1389"), new Guid("6e75c96b-c72f-4506-8e72-e70a96f30b07"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 33, new Guid("79e23339-1c35-4f7f-b622-d187063b3273") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("1463f5b7-bab1-4c81-8caa-46379151dcbc"), new Guid("6e75c96b-c72f-4506-8e72-e70a96f30b07"), 7, 270, 4 },
                    { new Guid("14c4964e-bcf7-4a3d-ad72-46235a33c2a0"), new Guid("ff4da611-b939-421f-9cab-ea9834f08e81"), 1, 494, 5 },
                    { new Guid("1751b4b0-8047-4d79-87ef-3a1ce4ef64c8"), new Guid("ff4da611-b939-421f-9cab-ea9834f08e81"), 3, 361, 4 },
                    { new Guid("3b63b6ff-d0cb-493b-bf43-1cb86bec0c55"), new Guid("ff4da611-b939-421f-9cab-ea9834f08e81"), 7, 412, 5 },
                    { new Guid("4aaf9cab-941d-4f9a-91c8-d19b0bf13343"), new Guid("6e75c96b-c72f-4506-8e72-e70a96f30b07"), 6, 227, 4 },
                    { new Guid("4fdb9114-8aac-470a-b907-53e1db9e13b3"), new Guid("ff4da611-b939-421f-9cab-ea9834f08e81"), 4, 367, 4 },
                    { new Guid("50d65a98-b836-4252-a83f-247bc0f7d640"), new Guid("6e75c96b-c72f-4506-8e72-e70a96f30b07"), 1, 113, 3 },
                    { new Guid("54631dd2-c291-473e-af3a-01088de59c7b"), new Guid("6e75c96b-c72f-4506-8e72-e70a96f30b07"), 9, 330, 4 },
                    { new Guid("62c5f05e-51cf-4441-964e-05dc244b6732"), new Guid("6e75c96b-c72f-4506-8e72-e70a96f30b07"), 2, 295, 4 },
                    { new Guid("6a08007d-d64a-426c-88c0-17d4cd59f371"), new Guid("6e75c96b-c72f-4506-8e72-e70a96f30b07"), 4, 128, 3 },
                    { new Guid("78e23492-ea21-4a7d-81ee-c5d63459e0d2"), new Guid("6e75c96b-c72f-4506-8e72-e70a96f30b07"), 3, 439, 5 },
                    { new Guid("936e7ab3-5c39-4457-b1b3-57ebb7f28a46"), new Guid("6e75c96b-c72f-4506-8e72-e70a96f30b07"), 8, 298, 4 },
                    { new Guid("9ec42265-441a-45fb-a54f-708d93c89afb"), new Guid("ff4da611-b939-421f-9cab-ea9834f08e81"), 5, 127, 3 },
                    { new Guid("b0e9b111-d4f9-47f9-b045-9e7ef2c09853"), new Guid("ff4da611-b939-421f-9cab-ea9834f08e81"), 2, 266, 5 },
                    { new Guid("b979a68b-de3f-471e-a684-5e32d1cb6ece"), new Guid("ff4da611-b939-421f-9cab-ea9834f08e81"), 8, 141, 3 },
                    { new Guid("c2939e30-9743-41a0-b626-c87487a861f8"), new Guid("ff4da611-b939-421f-9cab-ea9834f08e81"), 6, 337, 4 },
                    { new Guid("c7c2a1b5-70b0-4d3d-8eb5-cba6bed933b2"), new Guid("ff4da611-b939-421f-9cab-ea9834f08e81"), 9, 365, 4 },
                    { new Guid("d293243b-6869-4be5-a619-fbae771eab12"), new Guid("6e75c96b-c72f-4506-8e72-e70a96f30b07"), 5, 506, 5 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Par", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("4caa65a5-4b4b-4089-a835-f89f9c3ead70"), 9, 0, 3, new Guid("4ca40883-4e89-44b6-87cc-396b3c5f1389"), 4 },
                    { new Guid("4d8c69de-c1ea-4c63-b7e0-c57091bc295b"), 6, 0, 2, new Guid("4ca40883-4e89-44b6-87cc-396b3c5f1389"), 4 },
                    { new Guid("676f56f6-6fbc-4bc1-b620-89d399d722ea"), 2, 0, 2, new Guid("4ca40883-4e89-44b6-87cc-396b3c5f1389"), 6 },
                    { new Guid("941e071e-d97c-464f-aa1a-575f5fd98772"), 4, 0, 2, new Guid("4ca40883-4e89-44b6-87cc-396b3c5f1389"), 3 },
                    { new Guid("9ede46fc-d3d8-4197-b3dd-bbb56f86e66e"), 3, 0, 2, new Guid("4ca40883-4e89-44b6-87cc-396b3c5f1389"), 3 },
                    { new Guid("abd05452-f194-493d-85e8-e6995d837eaf"), 1, 0, 2, new Guid("4ca40883-4e89-44b6-87cc-396b3c5f1389"), 2 },
                    { new Guid("aed80410-770f-4588-97d1-214a7c7897da"), 5, 0, 1, new Guid("4ca40883-4e89-44b6-87cc-396b3c5f1389"), 4 },
                    { new Guid("b43b5b98-79be-45b3-8158-15fe002eaf34"), 8, 0, 2, new Guid("4ca40883-4e89-44b6-87cc-396b3c5f1389"), 2 },
                    { new Guid("c2a30b33-d650-4dda-9654-6eaf0938b938"), 7, 0, 2, new Guid("4ca40883-4e89-44b6-87cc-396b3c5f1389"), 5 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[,]
                {
                    { new Guid("c76d5f65-0984-4b4a-8ba8-c11bfeb0f078"), new Guid("ff4da611-b939-421f-9cab-ea9834f08e81"), 57 },
                    { new Guid("f9cd1f7e-02a7-4d89-896a-650207f5bb40"), new Guid("6e75c96b-c72f-4506-8e72-e70a96f30b07"), 52 }
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
