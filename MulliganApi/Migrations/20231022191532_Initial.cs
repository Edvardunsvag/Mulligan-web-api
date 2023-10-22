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
                values: new object[,]
                {
                    { new Guid("2ce3e054-61a5-4bed-b5c2-83d7c05101e0"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 0 },
                    { new Guid("b01378e6-48a6-45f1-b828-9e278237f902"), "Grønmo golfklubb description", "Grønmo golfklubb", false, 2870, 0 }
                });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Date", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("9531b2da-d555-482a-9840-f99329833474"), new Guid("2ce3e054-61a5-4bed-b5c2-83d7c05101e0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 33, new Guid("1a9a92f7-d5fe-4573-95a3-90bd3463f537") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("1bc5d68a-92a8-4697-a764-00f360ae2c80"), new Guid("b01378e6-48a6-45f1-b828-9e278237f902"), 1, 494, 5 },
                    { new Guid("2870fd0c-18b2-49a1-8224-9b95f2512697"), new Guid("b01378e6-48a6-45f1-b828-9e278237f902"), 7, 412, 5 },
                    { new Guid("35039ae0-7e41-4645-b627-f989c17150b3"), new Guid("b01378e6-48a6-45f1-b828-9e278237f902"), 2, 266, 5 },
                    { new Guid("37c65371-57c8-4bdc-a599-e9808c7f9a24"), new Guid("2ce3e054-61a5-4bed-b5c2-83d7c05101e0"), 5, 506, 5 },
                    { new Guid("59240783-a258-4343-bda8-252644b5a646"), new Guid("b01378e6-48a6-45f1-b828-9e278237f902"), 9, 365, 4 },
                    { new Guid("807da2a8-2719-4898-b326-bd3c021f9f74"), new Guid("2ce3e054-61a5-4bed-b5c2-83d7c05101e0"), 7, 270, 4 },
                    { new Guid("88259d74-a6c6-4a3e-beb2-e35f6a8fc9d7"), new Guid("2ce3e054-61a5-4bed-b5c2-83d7c05101e0"), 2, 295, 4 },
                    { new Guid("94e816b1-5254-43ad-ab5b-e6883dc48335"), new Guid("b01378e6-48a6-45f1-b828-9e278237f902"), 6, 337, 4 },
                    { new Guid("ae6abc5c-7890-4784-a80e-40871a587806"), new Guid("2ce3e054-61a5-4bed-b5c2-83d7c05101e0"), 4, 128, 3 },
                    { new Guid("b98d1ae4-53f3-4186-8248-d1fbdb330402"), new Guid("b01378e6-48a6-45f1-b828-9e278237f902"), 5, 127, 3 },
                    { new Guid("b9bcc910-1400-4496-8e44-dd31ffc7caee"), new Guid("2ce3e054-61a5-4bed-b5c2-83d7c05101e0"), 8, 298, 4 },
                    { new Guid("c4896973-8265-47b1-955a-6ddedd52b7d7"), new Guid("b01378e6-48a6-45f1-b828-9e278237f902"), 4, 367, 4 },
                    { new Guid("cdf21c4b-2b63-470d-aee0-1d63fde3b74b"), new Guid("2ce3e054-61a5-4bed-b5c2-83d7c05101e0"), 3, 439, 5 },
                    { new Guid("cf1aeb96-4a11-41c2-86bc-1380458e9ec8"), new Guid("2ce3e054-61a5-4bed-b5c2-83d7c05101e0"), 1, 113, 3 },
                    { new Guid("edac2ada-5bcf-4138-891b-08555b59908d"), new Guid("b01378e6-48a6-45f1-b828-9e278237f902"), 3, 361, 4 },
                    { new Guid("f4c653ee-9396-438e-84c2-2fe7ec183fc9"), new Guid("2ce3e054-61a5-4bed-b5c2-83d7c05101e0"), 9, 330, 4 },
                    { new Guid("f6999fdc-57e0-4bdc-85f5-53d152faed0c"), new Guid("b01378e6-48a6-45f1-b828-9e278237f902"), 8, 141, 3 },
                    { new Guid("fc2404f8-c82f-4607-9c7b-0e61143870cb"), new Guid("2ce3e054-61a5-4bed-b5c2-83d7c05101e0"), 6, 227, 4 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("012d388b-ecd9-4b72-9fe2-c876d0f81703"), 5, 1, new Guid("9531b2da-d555-482a-9840-f99329833474"), 4 },
                    { new Guid("1b703a39-e02d-4fb4-967e-7b63a0470ef9"), 3, 2, new Guid("9531b2da-d555-482a-9840-f99329833474"), 3 },
                    { new Guid("23fe9e27-bbee-45ce-b245-58eb9d0d7637"), 6, 2, new Guid("9531b2da-d555-482a-9840-f99329833474"), 4 },
                    { new Guid("4a2782c1-11a9-45ac-9e11-b1ffbd692f90"), 1, 2, new Guid("9531b2da-d555-482a-9840-f99329833474"), 2 },
                    { new Guid("523ae6ec-17ce-48cc-94b9-0d8d0ffea7b4"), 8, 2, new Guid("9531b2da-d555-482a-9840-f99329833474"), 2 },
                    { new Guid("56912364-aabb-4617-8cd9-4d65e9028483"), 9, 3, new Guid("9531b2da-d555-482a-9840-f99329833474"), 4 },
                    { new Guid("642293c5-02fd-48e4-bed8-3e97528a1468"), 7, 2, new Guid("9531b2da-d555-482a-9840-f99329833474"), 5 },
                    { new Guid("65c3519e-9683-4020-90ad-be7547f2eb16"), 4, 2, new Guid("9531b2da-d555-482a-9840-f99329833474"), 3 },
                    { new Guid("b1dfe152-63f9-442f-b4aa-90d6c6c06b98"), 2, 2, new Guid("9531b2da-d555-482a-9840-f99329833474"), 6 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[,]
                {
                    { new Guid("8ea1dc5f-bfba-4cef-b3fb-ba0fb86e52da"), new Guid("b01378e6-48a6-45f1-b828-9e278237f902"), 57 },
                    { new Guid("c31c7890-ccb4-4caa-a2d0-67f60cc900d5"), new Guid("2ce3e054-61a5-4bed-b5c2-83d7c05101e0"), 52 }
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
