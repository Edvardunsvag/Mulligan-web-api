using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class UserRoless : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRatings_User_UserId1",
                table: "UserRatings");

            migrationBuilder.DropIndex(
                name: "IX_UserRatings_UserId1",
                table: "UserRatings");

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

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UserRatings");

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName", "Has18Holes", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("743e8fed-5bdd-492f-9863-f70f7bf9131d"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 36 },
                    { new Guid("cca19292-df4f-4543-a590-b0692be5e0b2"), "Grønmo golfklubb description", "Grønmo golfklubb", false, 2870, 37 }
                });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("16b80425-8299-4fd6-a703-5ec0f1ce615b"), new Guid("743e8fed-5bdd-492f-9863-f70f7bf9131d"), 2, 295, 4 },
                    { new Guid("22b187d1-0734-4d62-bf1c-8e2bf5864756"), new Guid("cca19292-df4f-4543-a590-b0692be5e0b2"), 5, 127, 3 },
                    { new Guid("4048ae5c-4348-4ad9-ba19-3da18df51cb2"), new Guid("cca19292-df4f-4543-a590-b0692be5e0b2"), 3, 361, 4 },
                    { new Guid("499bfc05-4f88-4c15-9b1e-887886c77647"), new Guid("cca19292-df4f-4543-a590-b0692be5e0b2"), 9, 365, 4 },
                    { new Guid("5aae3d65-d6fa-4151-95b5-d3d279147fc5"), new Guid("743e8fed-5bdd-492f-9863-f70f7bf9131d"), 7, 270, 4 },
                    { new Guid("5ec85814-fc1b-4836-9300-9347c4ae429a"), new Guid("cca19292-df4f-4543-a590-b0692be5e0b2"), 1, 494, 5 },
                    { new Guid("6128e237-57e3-4f89-8538-d0edccd91087"), new Guid("cca19292-df4f-4543-a590-b0692be5e0b2"), 4, 367, 4 },
                    { new Guid("675fc080-f1fa-42ae-a10b-6598d4b0fb0a"), new Guid("743e8fed-5bdd-492f-9863-f70f7bf9131d"), 3, 439, 5 },
                    { new Guid("6c8ae464-21ae-4318-bd7a-b874ed8b63de"), new Guid("743e8fed-5bdd-492f-9863-f70f7bf9131d"), 8, 298, 4 },
                    { new Guid("6f791cab-0cc1-4cee-a263-ee0b6841c111"), new Guid("cca19292-df4f-4543-a590-b0692be5e0b2"), 7, 412, 5 },
                    { new Guid("74bcf803-2be5-4081-9342-63d0bd1fd9f2"), new Guid("743e8fed-5bdd-492f-9863-f70f7bf9131d"), 4, 128, 3 },
                    { new Guid("8e71bebb-a663-414f-b18b-8e50054781cd"), new Guid("cca19292-df4f-4543-a590-b0692be5e0b2"), 2, 266, 5 },
                    { new Guid("9e015b2a-6fe7-4041-a60d-ac1c91dea3ac"), new Guid("743e8fed-5bdd-492f-9863-f70f7bf9131d"), 9, 330, 4 },
                    { new Guid("a1ae9243-b0ca-4252-94d4-f2c66f611251"), new Guid("743e8fed-5bdd-492f-9863-f70f7bf9131d"), 1, 113, 3 },
                    { new Guid("b9d36622-8688-4dac-872b-4f6ef34c6a02"), new Guid("cca19292-df4f-4543-a590-b0692be5e0b2"), 8, 141, 3 },
                    { new Guid("c6a46a3c-9c50-4ba6-806f-638ecac4f2a0"), new Guid("743e8fed-5bdd-492f-9863-f70f7bf9131d"), 5, 506, 5 },
                    { new Guid("c7bf4285-74cf-4e9a-b345-0c988ead15f4"), new Guid("743e8fed-5bdd-492f-9863-f70f7bf9131d"), 6, 227, 4 },
                    { new Guid("fb77d8d7-5917-49f8-b86b-1d10f55caa01"), new Guid("cca19292-df4f-4543-a590-b0692be5e0b2"), 6, 337, 4 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[,]
                {
                    { new Guid("63615083-5b39-481c-b532-7f5a9ff9b6e4"), new Guid("cca19292-df4f-4543-a590-b0692be5e0b2"), 57 },
                    { new Guid("fc4822c2-0400-481c-99b6-585d5314c704"), new Guid("743e8fed-5bdd-492f-9863-f70f7bf9131d"), 52 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("16b80425-8299-4fd6-a703-5ec0f1ce615b"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("22b187d1-0734-4d62-bf1c-8e2bf5864756"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("4048ae5c-4348-4ad9-ba19-3da18df51cb2"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("499bfc05-4f88-4c15-9b1e-887886c77647"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("5aae3d65-d6fa-4151-95b5-d3d279147fc5"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("5ec85814-fc1b-4836-9300-9347c4ae429a"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("6128e237-57e3-4f89-8538-d0edccd91087"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("675fc080-f1fa-42ae-a10b-6598d4b0fb0a"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("6c8ae464-21ae-4318-bd7a-b874ed8b63de"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("6f791cab-0cc1-4cee-a263-ee0b6841c111"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("74bcf803-2be5-4081-9342-63d0bd1fd9f2"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("8e71bebb-a663-414f-b18b-8e50054781cd"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("9e015b2a-6fe7-4041-a60d-ac1c91dea3ac"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("a1ae9243-b0ca-4252-94d4-f2c66f611251"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("b9d36622-8688-4dac-872b-4f6ef34c6a02"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("c6a46a3c-9c50-4ba6-806f-638ecac4f2a0"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("c7bf4285-74cf-4e9a-b345-0c988ead15f4"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("fb77d8d7-5917-49f8-b86b-1d10f55caa01"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("63615083-5b39-481c-b532-7f5a9ff9b6e4"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("fc4822c2-0400-481c-99b6-585d5314c704"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("743e8fed-5bdd-492f-9863-f70f7bf9131d"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("cca19292-df4f-4543-a590-b0692be5e0b2"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId1",
                table: "UserRatings",
                type: "uniqueidentifier",
                nullable: true);

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
                name: "IX_UserRatings_UserId1",
                table: "UserRatings",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRatings_User_UserId1",
                table: "UserRatings",
                column: "UserId1",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
