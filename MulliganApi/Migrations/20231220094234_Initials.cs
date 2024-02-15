using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class Initials : Migration
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
                    { new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"), "Grønmo golfklubb description", "Grønmo golfklubb", false, 2870, 37 },
                    { new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 36 }
                });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Date", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"), new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 33, new Guid("76962868-6a8d-4533-b4bb-53305effd5da") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("06831ff9-05bd-4f11-ac88-530991538a0e"), new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"), 5, 127, 3 },
                    { new Guid("0f7e2f66-d984-4c81-8b1b-54b3c53500b3"), new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"), 5, 506, 5 },
                    { new Guid("19911048-cd85-4f09-ab22-4dc7987563ba"), new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"), 9, 330, 4 },
                    { new Guid("2951fb31-b357-4c64-8123-31c0870cdf46"), new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"), 2, 295, 4 },
                    { new Guid("325b7631-19da-4d32-b582-6d288e86c7a2"), new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"), 7, 270, 4 },
                    { new Guid("374ccee7-89c4-470c-b7e4-423bf71619b6"), new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"), 8, 141, 3 },
                    { new Guid("45432af8-4b49-4fce-98e0-1b9464e17d1a"), new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"), 1, 113, 3 },
                    { new Guid("4eb0baf1-a92b-4d23-9f15-b20b6510ee99"), new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"), 2, 266, 5 },
                    { new Guid("56a7ef2a-b8b8-458c-a123-530be416bfd8"), new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"), 6, 337, 4 },
                    { new Guid("914c32d8-2a80-42ab-b8fe-a26b24b4a454"), new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"), 4, 367, 4 },
                    { new Guid("9543ff73-5200-4359-aaba-bb4857c79af6"), new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"), 8, 298, 4 },
                    { new Guid("c542eab8-72c1-4eca-9933-f5ca33e2cad4"), new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"), 3, 361, 4 },
                    { new Guid("cc8fe247-171f-4bdf-8922-cb8140839099"), new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"), 3, 439, 5 },
                    { new Guid("d3670fa8-9c00-4eb7-99e9-c383f328e0f7"), new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"), 1, 494, 5 },
                    { new Guid("e0a3a8dc-7d32-4a15-9af1-bd18a9a7390c"), new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"), 6, 227, 4 },
                    { new Guid("e8d9dc64-0421-48bd-afbe-6f536d1f7060"), new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"), 7, 412, 5 },
                    { new Guid("fb8a62d4-9c9c-4691-a693-414568dc650d"), new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"), 9, 365, 4 },
                    { new Guid("fdf11998-86b7-47f5-b893-dba5f2f59790"), new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"), 4, 128, 3 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Par", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("11f84b9b-ad97-4494-a516-4de21f530883"), 3, 0, 2, new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"), 3 },
                    { new Guid("18ed7f64-53d7-43da-b255-413c827355e5"), 7, 0, 2, new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"), 5 },
                    { new Guid("1bd292a0-b64e-4293-aaab-55bab5e7c721"), 1, 0, 2, new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"), 2 },
                    { new Guid("1cf5793e-aec0-44be-8611-ebd0140c68b1"), 5, 0, 1, new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"), 4 },
                    { new Guid("33fa2a57-95fa-496d-9d96-1a2744d77e74"), 8, 0, 2, new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"), 2 },
                    { new Guid("34b8fe52-2dd2-4fc2-b0b3-5c76a67f03c3"), 2, 0, 2, new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"), 6 },
                    { new Guid("839367e0-8f8e-4bd4-97a4-09cabcd0ad87"), 9, 0, 3, new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"), 4 },
                    { new Guid("8718ad8d-d104-4699-8f2b-aef35cf9c1f2"), 6, 0, 2, new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"), 4 },
                    { new Guid("e081f5a7-c826-4ce1-a3dd-636016aacbd1"), 4, 0, 2, new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"), 3 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[,]
                {
                    { new Guid("09460a96-315c-4083-a11e-3693f08e5780"), new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"), 52 },
                    { new Guid("b0f90312-e6dc-44e7-8947-a18b72bc8145"), new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"), 57 }
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
