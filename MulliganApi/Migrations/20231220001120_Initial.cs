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
                    { new Guid("39a40625-cd21-412a-af80-ce1f27ada556"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 36 },
                    { new Guid("845211e2-8208-47b1-a1e9-5a8649f39efb"), "Grønmo golfklubb description", "Grønmo golfklubb", false, 2870, 37 }
                });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Date", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("76d02e5a-863f-4fea-8863-c0e2549e560d"), new Guid("39a40625-cd21-412a-af80-ce1f27ada556"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 33, new Guid("70e0af13-50d3-435c-9d84-5b4b4395cbd5") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("068c6c66-60f4-49ed-841f-5fdce7a1cbf3"), new Guid("39a40625-cd21-412a-af80-ce1f27ada556"), 3, 439, 5 },
                    { new Guid("14404935-880c-4190-a1bc-750ea15d5ec1"), new Guid("39a40625-cd21-412a-af80-ce1f27ada556"), 1, 113, 3 },
                    { new Guid("32cdac80-7169-428d-a022-13c7324fc127"), new Guid("845211e2-8208-47b1-a1e9-5a8649f39efb"), 3, 361, 4 },
                    { new Guid("37151234-97ed-433a-a383-55ac19eb38f6"), new Guid("39a40625-cd21-412a-af80-ce1f27ada556"), 9, 330, 4 },
                    { new Guid("3ade4e0f-0e39-46f9-ab87-8f8265da4cd5"), new Guid("39a40625-cd21-412a-af80-ce1f27ada556"), 7, 270, 4 },
                    { new Guid("537f2035-07f1-4c88-bebf-90d79043825d"), new Guid("845211e2-8208-47b1-a1e9-5a8649f39efb"), 9, 365, 4 },
                    { new Guid("693b9a00-33e7-4f74-93ec-3a3af09acfc0"), new Guid("845211e2-8208-47b1-a1e9-5a8649f39efb"), 4, 367, 4 },
                    { new Guid("876501c9-6559-47c2-9241-a58df31b761a"), new Guid("39a40625-cd21-412a-af80-ce1f27ada556"), 5, 506, 5 },
                    { new Guid("8fe6e234-1028-4005-ba9f-45559247124c"), new Guid("39a40625-cd21-412a-af80-ce1f27ada556"), 2, 295, 4 },
                    { new Guid("98ec7727-a3ba-42bf-addd-2e512c7c9d9e"), new Guid("39a40625-cd21-412a-af80-ce1f27ada556"), 4, 128, 3 },
                    { new Guid("9ee3c8b7-c83a-4a4b-a753-794ff78be99d"), new Guid("845211e2-8208-47b1-a1e9-5a8649f39efb"), 8, 141, 3 },
                    { new Guid("9f144300-6f27-4430-90fb-674d578555eb"), new Guid("845211e2-8208-47b1-a1e9-5a8649f39efb"), 7, 412, 5 },
                    { new Guid("b4358b2f-1d22-4a3d-854d-dd520b480358"), new Guid("845211e2-8208-47b1-a1e9-5a8649f39efb"), 1, 494, 5 },
                    { new Guid("dc817ec2-a15d-4430-a3bb-f360955061bf"), new Guid("39a40625-cd21-412a-af80-ce1f27ada556"), 6, 227, 4 },
                    { new Guid("dc9d48b5-3090-413d-aea6-f15bb74c0eb1"), new Guid("845211e2-8208-47b1-a1e9-5a8649f39efb"), 2, 266, 5 },
                    { new Guid("ef368b9d-ad39-488e-ba98-43080602ee88"), new Guid("845211e2-8208-47b1-a1e9-5a8649f39efb"), 6, 337, 4 },
                    { new Guid("effa42c9-6e1e-4c3a-abaf-60a1298bc09d"), new Guid("845211e2-8208-47b1-a1e9-5a8649f39efb"), 5, 127, 3 },
                    { new Guid("f0ec2809-d679-47c9-a6df-3fe23443969f"), new Guid("39a40625-cd21-412a-af80-ce1f27ada556"), 8, 298, 4 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Par", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("32a22b35-13ff-4e03-8e74-4592fe2bdd8c"), 9, 0, 3, new Guid("76d02e5a-863f-4fea-8863-c0e2549e560d"), 4 },
                    { new Guid("5d79b05d-c073-4eb5-acba-db02544dcb9a"), 8, 0, 2, new Guid("76d02e5a-863f-4fea-8863-c0e2549e560d"), 2 },
                    { new Guid("617ea215-f758-4eeb-8f3a-cd4169fa2ad2"), 2, 0, 2, new Guid("76d02e5a-863f-4fea-8863-c0e2549e560d"), 6 },
                    { new Guid("9a7225e0-d919-4a54-822f-680ab2cf0ea7"), 7, 0, 2, new Guid("76d02e5a-863f-4fea-8863-c0e2549e560d"), 5 },
                    { new Guid("cf908535-0959-4a41-af38-fa82fd3b6ccf"), 4, 0, 2, new Guid("76d02e5a-863f-4fea-8863-c0e2549e560d"), 3 },
                    { new Guid("d652dbc5-1ed3-4645-a2b5-1b9856dfbe9d"), 6, 0, 2, new Guid("76d02e5a-863f-4fea-8863-c0e2549e560d"), 4 },
                    { new Guid("ee2c0fe4-6b94-4f2c-ae76-c2978a6ae934"), 5, 0, 1, new Guid("76d02e5a-863f-4fea-8863-c0e2549e560d"), 4 },
                    { new Guid("ee67c2a3-92f3-495d-965e-3b105abdf78e"), 1, 0, 2, new Guid("76d02e5a-863f-4fea-8863-c0e2549e560d"), 2 },
                    { new Guid("f95e5877-de0e-40e5-89d4-ff421a4d759f"), 3, 0, 2, new Guid("76d02e5a-863f-4fea-8863-c0e2549e560d"), 3 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[,]
                {
                    { new Guid("1d7aac19-a210-4160-b3cc-fc46908a7465"), new Guid("39a40625-cd21-412a-af80-ce1f27ada556"), 52 },
                    { new Guid("f53218e5-24ad-4e8b-85f3-7ae58f758766"), new Guid("845211e2-8208-47b1-a1e9-5a8649f39efb"), 57 }
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
