using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class UserRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("1457932f-2496-43fd-9656-5794c99f7ab8"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("1967d23f-e239-4179-a7da-d8c8353938d2"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("434b7b37-134b-4b32-b700-168b8d1149c6"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("478f078a-8662-4496-872f-bc1260d6dbd8"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("4d0cc8b6-d980-4afa-b4b6-251d1fbb1b3d"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("65b5676c-956b-442c-90d8-a9b8f46b5f18"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("69f0cfd0-b20c-458e-9c53-26df5f192f02"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("778fb925-6e24-4298-a344-c7ed49ab1a83"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("88b15dd5-99ed-4bc9-9243-ce0815a0698f"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("a513c5b4-b392-4ec2-83b3-1cac1da83241"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("b7c4d1c0-857d-4a94-ab89-71032f170d59"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("cb6cbb83-9e62-4a2c-b58f-019784f4aed3"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("d0bbc357-626a-40fa-a6be-18fd2db85e84"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("d6d3aea1-f17f-4016-af15-5e5e9a688546"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("dcb53085-1fb2-42f8-8784-c2f572141ada"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("dd3f1776-3fc7-468f-90a7-27af347dc326"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("e188e5ed-3696-4330-9c4e-ad9457bb5437"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("f7f28a7f-3638-4558-ae68-c0f1ed4022ee"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("1ebb0280-9369-4d91-8796-cd0623409c38"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("4f7de840-5fa6-4d2d-8ad0-d39b7bf5ca59"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("11744fbf-e5ae-4050-be89-90202c3c2fb8"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("2d9dc29f-daf7-43da-b4b4-aa6e41be66cf"));

            migrationBuilder.DropColumn(
                name: "PasswordResetToken",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ResetTokenExpires",
                table: "User");

            migrationBuilder.DropColumn(
                name: "VerifiedAt",
                table: "User");

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

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName", "Has18Holes", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("3dcea0d9-b783-4a67-a19b-dff70198d533"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 36 },
                    { new Guid("6df2d975-d70b-4104-9ecd-9cf13b42d021"), "Grønmo golfklubb description", "Grønmo golfklubb", false, 2870, 37 }
                });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("105e3a5e-7998-4478-ac37-bdbd00449416"), new Guid("3dcea0d9-b783-4a67-a19b-dff70198d533"), 3, 439, 5 },
                    { new Guid("136d7ba8-22d2-41cf-a3c9-c8339b1cc129"), new Guid("3dcea0d9-b783-4a67-a19b-dff70198d533"), 5, 506, 5 },
                    { new Guid("16e0208d-677b-448b-8a37-189046a03017"), new Guid("3dcea0d9-b783-4a67-a19b-dff70198d533"), 9, 330, 4 },
                    { new Guid("1a141a13-212b-464e-a200-5bc422a3d7f2"), new Guid("6df2d975-d70b-4104-9ecd-9cf13b42d021"), 7, 412, 5 },
                    { new Guid("1f733566-b76c-4248-9ef5-edf48a51bbf0"), new Guid("6df2d975-d70b-4104-9ecd-9cf13b42d021"), 5, 127, 3 },
                    { new Guid("3f63962e-5084-4c90-a7cc-20e583c384af"), new Guid("3dcea0d9-b783-4a67-a19b-dff70198d533"), 7, 270, 4 },
                    { new Guid("40d7a4a8-85a7-4509-921c-e648d6f64e06"), new Guid("3dcea0d9-b783-4a67-a19b-dff70198d533"), 2, 295, 4 },
                    { new Guid("5fe041bc-57a1-41be-aea4-1b9565b10c29"), new Guid("6df2d975-d70b-4104-9ecd-9cf13b42d021"), 2, 266, 5 },
                    { new Guid("63e3413b-2790-4411-83b1-f7b6d58e3a08"), new Guid("3dcea0d9-b783-4a67-a19b-dff70198d533"), 8, 298, 4 },
                    { new Guid("78a71880-8e0d-42f4-8106-3ddd517174b6"), new Guid("6df2d975-d70b-4104-9ecd-9cf13b42d021"), 9, 365, 4 },
                    { new Guid("7e3479f0-9bd1-4f00-b38f-3ce106ead7b7"), new Guid("6df2d975-d70b-4104-9ecd-9cf13b42d021"), 6, 337, 4 },
                    { new Guid("81a4bd08-2515-41bc-a831-9da25367ee00"), new Guid("6df2d975-d70b-4104-9ecd-9cf13b42d021"), 8, 141, 3 },
                    { new Guid("8cec9d17-512a-4116-b799-3ec85897eef6"), new Guid("3dcea0d9-b783-4a67-a19b-dff70198d533"), 1, 113, 3 },
                    { new Guid("90524636-1d1c-4d5d-8ad9-c1825ffaf7af"), new Guid("3dcea0d9-b783-4a67-a19b-dff70198d533"), 4, 128, 3 },
                    { new Guid("94c80242-3c42-4263-9dcd-297ee0a36b6d"), new Guid("6df2d975-d70b-4104-9ecd-9cf13b42d021"), 3, 361, 4 },
                    { new Guid("da759b0a-8569-4b37-9b8f-4ac25b486c94"), new Guid("6df2d975-d70b-4104-9ecd-9cf13b42d021"), 4, 367, 4 },
                    { new Guid("e9fe2114-5f23-4cb2-b399-a9c0020f1fdb"), new Guid("6df2d975-d70b-4104-9ecd-9cf13b42d021"), 1, 494, 5 },
                    { new Guid("ec2fc903-0249-4371-a244-6b41d1f362d9"), new Guid("3dcea0d9-b783-4a67-a19b-dff70198d533"), 6, 227, 4 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[,]
                {
                    { new Guid("0a6e4ab0-4183-4609-b93f-19825915f76a"), new Guid("6df2d975-d70b-4104-9ecd-9cf13b42d021"), 57 },
                    { new Guid("76aa894e-ace4-4ec0-9792-6d8477d4ad26"), new Guid("3dcea0d9-b783-4a67-a19b-dff70198d533"), 52 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("105e3a5e-7998-4478-ac37-bdbd00449416"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("136d7ba8-22d2-41cf-a3c9-c8339b1cc129"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("16e0208d-677b-448b-8a37-189046a03017"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("1a141a13-212b-464e-a200-5bc422a3d7f2"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("1f733566-b76c-4248-9ef5-edf48a51bbf0"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("3f63962e-5084-4c90-a7cc-20e583c384af"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("40d7a4a8-85a7-4509-921c-e648d6f64e06"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("5fe041bc-57a1-41be-aea4-1b9565b10c29"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("63e3413b-2790-4411-83b1-f7b6d58e3a08"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("78a71880-8e0d-42f4-8106-3ddd517174b6"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("7e3479f0-9bd1-4f00-b38f-3ce106ead7b7"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("81a4bd08-2515-41bc-a831-9da25367ee00"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("8cec9d17-512a-4116-b799-3ec85897eef6"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("90524636-1d1c-4d5d-8ad9-c1825ffaf7af"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("94c80242-3c42-4263-9dcd-297ee0a36b6d"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("da759b0a-8569-4b37-9b8f-4ac25b486c94"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("e9fe2114-5f23-4cb2-b399-a9c0020f1fdb"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("ec2fc903-0249-4371-a244-6b41d1f362d9"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("0a6e4ab0-4183-4609-b93f-19825915f76a"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("76aa894e-ace4-4ec0-9792-6d8477d4ad26"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("3dcea0d9-b783-4a67-a19b-dff70198d533"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("6df2d975-d70b-4104-9ecd-9cf13b42d021"));

            migrationBuilder.AddColumn<string>(
                name: "PasswordResetToken",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ResetTokenExpires",
                table: "User",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "VerifiedAt",
                table: "User",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName", "Has18Holes", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("11744fbf-e5ae-4050-be89-90202c3c2fb8"), "Grønmo golfklubb description", "Grønmo golfklubb", false, 2870, 37 },
                    { new Guid("2d9dc29f-daf7-43da-b4b4-aa6e41be66cf"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 36 }
                });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("1457932f-2496-43fd-9656-5794c99f7ab8"), new Guid("2d9dc29f-daf7-43da-b4b4-aa6e41be66cf"), 5, 506, 5 },
                    { new Guid("1967d23f-e239-4179-a7da-d8c8353938d2"), new Guid("11744fbf-e5ae-4050-be89-90202c3c2fb8"), 5, 127, 3 },
                    { new Guid("434b7b37-134b-4b32-b700-168b8d1149c6"), new Guid("2d9dc29f-daf7-43da-b4b4-aa6e41be66cf"), 8, 298, 4 },
                    { new Guid("478f078a-8662-4496-872f-bc1260d6dbd8"), new Guid("11744fbf-e5ae-4050-be89-90202c3c2fb8"), 2, 266, 5 },
                    { new Guid("4d0cc8b6-d980-4afa-b4b6-251d1fbb1b3d"), new Guid("2d9dc29f-daf7-43da-b4b4-aa6e41be66cf"), 4, 128, 3 },
                    { new Guid("65b5676c-956b-442c-90d8-a9b8f46b5f18"), new Guid("2d9dc29f-daf7-43da-b4b4-aa6e41be66cf"), 3, 439, 5 },
                    { new Guid("69f0cfd0-b20c-458e-9c53-26df5f192f02"), new Guid("11744fbf-e5ae-4050-be89-90202c3c2fb8"), 3, 361, 4 },
                    { new Guid("778fb925-6e24-4298-a344-c7ed49ab1a83"), new Guid("11744fbf-e5ae-4050-be89-90202c3c2fb8"), 7, 412, 5 },
                    { new Guid("88b15dd5-99ed-4bc9-9243-ce0815a0698f"), new Guid("2d9dc29f-daf7-43da-b4b4-aa6e41be66cf"), 6, 227, 4 },
                    { new Guid("a513c5b4-b392-4ec2-83b3-1cac1da83241"), new Guid("2d9dc29f-daf7-43da-b4b4-aa6e41be66cf"), 9, 330, 4 },
                    { new Guid("b7c4d1c0-857d-4a94-ab89-71032f170d59"), new Guid("11744fbf-e5ae-4050-be89-90202c3c2fb8"), 9, 365, 4 },
                    { new Guid("cb6cbb83-9e62-4a2c-b58f-019784f4aed3"), new Guid("11744fbf-e5ae-4050-be89-90202c3c2fb8"), 4, 367, 4 },
                    { new Guid("d0bbc357-626a-40fa-a6be-18fd2db85e84"), new Guid("2d9dc29f-daf7-43da-b4b4-aa6e41be66cf"), 7, 270, 4 },
                    { new Guid("d6d3aea1-f17f-4016-af15-5e5e9a688546"), new Guid("11744fbf-e5ae-4050-be89-90202c3c2fb8"), 8, 141, 3 },
                    { new Guid("dcb53085-1fb2-42f8-8784-c2f572141ada"), new Guid("2d9dc29f-daf7-43da-b4b4-aa6e41be66cf"), 2, 295, 4 },
                    { new Guid("dd3f1776-3fc7-468f-90a7-27af347dc326"), new Guid("11744fbf-e5ae-4050-be89-90202c3c2fb8"), 1, 494, 5 },
                    { new Guid("e188e5ed-3696-4330-9c4e-ad9457bb5437"), new Guid("11744fbf-e5ae-4050-be89-90202c3c2fb8"), 6, 337, 4 },
                    { new Guid("f7f28a7f-3638-4558-ae68-c0f1ed4022ee"), new Guid("2d9dc29f-daf7-43da-b4b4-aa6e41be66cf"), 1, 113, 3 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[,]
                {
                    { new Guid("1ebb0280-9369-4d91-8796-cd0623409c38"), new Guid("11744fbf-e5ae-4050-be89-90202c3c2fb8"), 57 },
                    { new Guid("4f7de840-5fa6-4d2d-8ad0-d39b7bf5ca59"), new Guid("2d9dc29f-daf7-43da-b4b4-aa6e41be66cf"), 52 }
                });
        }
    }
}
