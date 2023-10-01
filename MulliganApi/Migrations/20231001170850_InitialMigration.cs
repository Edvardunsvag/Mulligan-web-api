using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
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
                    Par = table.Column<int>(type: "int", nullable: false)
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
                    Strokes = table.Column<int>(type: "int", nullable: false)
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
                    Score = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseHoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Note_CourseHole_CourseHoleId",
                        column: x => x.CourseHoleId,
                        principalTable: "CourseHole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName", "Par" },
                values: new object[] { new Guid("9a7bdccc-a6bc-4530-8d47-1354813ca6ba"), "Krokhol golfklubb description", "Krokhol", 0 });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Strokes", "UserId" },
                values: new object[] { new Guid("2f685fa9-c7f2-4afa-a97e-9e355e17f7b5"), new Guid("9a7bdccc-a6bc-4530-8d47-1354813ca6ba"), 45, new Guid("b813162a-1fea-42c3-b541-c6324bad1d42") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("1ee20b51-b68f-4070-b691-6b3c1c40c964"), new Guid("9a7bdccc-a6bc-4530-8d47-1354813ca6ba"), 9, 330, 4 },
                    { new Guid("5fd15305-e567-4074-8dbd-2c08a30cb75b"), new Guid("9a7bdccc-a6bc-4530-8d47-1354813ca6ba"), 6, 227, 4 },
                    { new Guid("74648ba3-ea57-481c-a06e-85a2367fb698"), new Guid("9a7bdccc-a6bc-4530-8d47-1354813ca6ba"), 4, 128, 3 },
                    { new Guid("803214e5-eb3c-4d41-89f2-3af3bae416be"), new Guid("9a7bdccc-a6bc-4530-8d47-1354813ca6ba"), 2, 295, 4 },
                    { new Guid("9e5f7869-3d84-4df4-927b-c9a2912ce349"), new Guid("9a7bdccc-a6bc-4530-8d47-1354813ca6ba"), 5, 506, 5 },
                    { new Guid("bef94f29-4738-4ea4-b61e-6d0620fd07c0"), new Guid("9a7bdccc-a6bc-4530-8d47-1354813ca6ba"), 8, 298, 4 },
                    { new Guid("ce02674b-36cd-4e7b-bc01-4fe76e600a72"), new Guid("9a7bdccc-a6bc-4530-8d47-1354813ca6ba"), 3, 439, 5 },
                    { new Guid("d88c8e17-19dc-4be0-a5f2-d330ed564a75"), new Guid("9a7bdccc-a6bc-4530-8d47-1354813ca6ba"), 1, 113, 3 },
                    { new Guid("eb9f52a2-939a-4211-abff-805dcc73f3fa"), new Guid("9a7bdccc-a6bc-4530-8d47-1354813ca6ba"), 7, 270, 4 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("05982b0a-7044-453c-9290-592e056f6aac"), 9, new Guid("2f685fa9-c7f2-4afa-a97e-9e355e17f7b5"), 4 },
                    { new Guid("21ed672f-d7da-4a0e-a137-247245af4404"), 5, new Guid("2f685fa9-c7f2-4afa-a97e-9e355e17f7b5"), 4 },
                    { new Guid("26098bfa-212c-4e09-b89b-7a90b0af593e"), 4, new Guid("2f685fa9-c7f2-4afa-a97e-9e355e17f7b5"), 3 },
                    { new Guid("2a2c119f-cca4-4a15-b2d2-a5b9d49ae29d"), 8, new Guid("2f685fa9-c7f2-4afa-a97e-9e355e17f7b5"), 2 },
                    { new Guid("59662a03-255d-4d39-b2a2-59543f941450"), 6, new Guid("2f685fa9-c7f2-4afa-a97e-9e355e17f7b5"), 4 },
                    { new Guid("5a5ec90b-2b8e-4d99-b4af-ee9fb249c0b4"), 3, new Guid("2f685fa9-c7f2-4afa-a97e-9e355e17f7b5"), 3 },
                    { new Guid("919eb89e-09f8-4c7e-b7ce-0754e057d813"), 2, new Guid("2f685fa9-c7f2-4afa-a97e-9e355e17f7b5"), 6 },
                    { new Guid("95e67745-7685-48a6-b4dc-c22676b6b76c"), 1, new Guid("2f685fa9-c7f2-4afa-a97e-9e355e17f7b5"), 2 },
                    { new Guid("b5bb92be-2015-42a3-bb48-0afe22766775"), 7, new Guid("2f685fa9-c7f2-4afa-a97e-9e355e17f7b5"), 5 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[] { new Guid("06f6b7f5-a5b2-42f8-8feb-d87b920f0508"), new Guid("9a7bdccc-a6bc-4530-8d47-1354813ca6ba"), 52 });

            migrationBuilder.CreateIndex(
                name: "IX_CourseHole_CourseId",
                table: "CourseHole",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_CourseHoleId",
                table: "Note",
                column: "CourseHoleId");

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
