using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class UserRolesss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRatings_User_UserId",
                table: "UserRatings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRatings",
                table: "UserRatings");

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

            migrationBuilder.RenameTable(
                name: "UserRatings",
                newName: "UserRating");

            migrationBuilder.RenameIndex(
                name: "IX_UserRatings_UserId",
                table: "UserRating",
                newName: "IX_UserRating_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRating",
                table: "UserRating",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName", "Has18Holes", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("2f0bd318-b1d5-4c02-86c7-85b1349f7b2e"), "Grønmo golfklubb description", "Grønmo golfklubb", false, 2870, 37 },
                    { new Guid("a2087c7d-4a39-4e47-ad51-4840f7adb6fd"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 36 }
                });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("08263304-4905-466d-a5df-8be84b74df0b"), new Guid("2f0bd318-b1d5-4c02-86c7-85b1349f7b2e"), 9, 365, 4 },
                    { new Guid("19c44c3e-ae52-49f0-89f6-641f72bfeb9d"), new Guid("a2087c7d-4a39-4e47-ad51-4840f7adb6fd"), 6, 227, 4 },
                    { new Guid("220deb54-6d59-4a53-848e-d4c50a9e76b4"), new Guid("a2087c7d-4a39-4e47-ad51-4840f7adb6fd"), 3, 439, 5 },
                    { new Guid("22be234a-6fae-43f6-8ac6-2c0852208a20"), new Guid("2f0bd318-b1d5-4c02-86c7-85b1349f7b2e"), 2, 266, 5 },
                    { new Guid("3417711e-4647-413b-ab59-9d0079991480"), new Guid("2f0bd318-b1d5-4c02-86c7-85b1349f7b2e"), 5, 127, 3 },
                    { new Guid("4bb2b022-89d0-4267-a337-c8764eeceb8b"), new Guid("2f0bd318-b1d5-4c02-86c7-85b1349f7b2e"), 1, 494, 5 },
                    { new Guid("73149398-b7a4-43a4-b900-a0765dca33ef"), new Guid("a2087c7d-4a39-4e47-ad51-4840f7adb6fd"), 9, 330, 4 },
                    { new Guid("828752d4-4e07-4c97-983b-7e946b5697b7"), new Guid("a2087c7d-4a39-4e47-ad51-4840f7adb6fd"), 4, 128, 3 },
                    { new Guid("8b906d0e-7519-41cf-9a0a-1cfc595bbf5b"), new Guid("2f0bd318-b1d5-4c02-86c7-85b1349f7b2e"), 8, 141, 3 },
                    { new Guid("a3cc1e3d-3129-435a-8ad2-67ff612b8c41"), new Guid("a2087c7d-4a39-4e47-ad51-4840f7adb6fd"), 5, 506, 5 },
                    { new Guid("b4bcd5d4-f44f-4cda-8600-646c92d635f4"), new Guid("a2087c7d-4a39-4e47-ad51-4840f7adb6fd"), 8, 298, 4 },
                    { new Guid("b64c7830-b2ea-4a33-a94f-969f2c4fb8d8"), new Guid("2f0bd318-b1d5-4c02-86c7-85b1349f7b2e"), 7, 412, 5 },
                    { new Guid("baeecacd-730c-4988-9c47-d87d45548539"), new Guid("2f0bd318-b1d5-4c02-86c7-85b1349f7b2e"), 4, 367, 4 },
                    { new Guid("cff50949-4898-42c5-8b9a-8087cc4a0591"), new Guid("2f0bd318-b1d5-4c02-86c7-85b1349f7b2e"), 6, 337, 4 },
                    { new Guid("e585ee5b-1406-4cac-9d9b-b41ac315bff7"), new Guid("a2087c7d-4a39-4e47-ad51-4840f7adb6fd"), 2, 295, 4 },
                    { new Guid("f48700cb-e71c-42fe-874e-046825900aa0"), new Guid("a2087c7d-4a39-4e47-ad51-4840f7adb6fd"), 7, 270, 4 },
                    { new Guid("f49b26e5-313b-4a87-b83d-4dd5806aa90f"), new Guid("a2087c7d-4a39-4e47-ad51-4840f7adb6fd"), 1, 113, 3 },
                    { new Guid("fe9c7818-4aac-440a-8e76-8ace46f89412"), new Guid("2f0bd318-b1d5-4c02-86c7-85b1349f7b2e"), 3, 361, 4 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[,]
                {
                    { new Guid("d3dffedc-6599-49b6-a72c-23f3c9a06a87"), new Guid("a2087c7d-4a39-4e47-ad51-4840f7adb6fd"), 52 },
                    { new Guid("df2b2a99-d523-4a7a-a020-33190935b4c1"), new Guid("2f0bd318-b1d5-4c02-86c7-85b1349f7b2e"), 57 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserRating_User_UserId",
                table: "UserRating",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRating_User_UserId",
                table: "UserRating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRating",
                table: "UserRating");

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("08263304-4905-466d-a5df-8be84b74df0b"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("19c44c3e-ae52-49f0-89f6-641f72bfeb9d"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("220deb54-6d59-4a53-848e-d4c50a9e76b4"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("22be234a-6fae-43f6-8ac6-2c0852208a20"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("3417711e-4647-413b-ab59-9d0079991480"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("4bb2b022-89d0-4267-a337-c8764eeceb8b"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("73149398-b7a4-43a4-b900-a0765dca33ef"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("828752d4-4e07-4c97-983b-7e946b5697b7"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("8b906d0e-7519-41cf-9a0a-1cfc595bbf5b"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("a3cc1e3d-3129-435a-8ad2-67ff612b8c41"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("b4bcd5d4-f44f-4cda-8600-646c92d635f4"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("b64c7830-b2ea-4a33-a94f-969f2c4fb8d8"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("baeecacd-730c-4988-9c47-d87d45548539"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("cff50949-4898-42c5-8b9a-8087cc4a0591"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("e585ee5b-1406-4cac-9d9b-b41ac315bff7"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("f48700cb-e71c-42fe-874e-046825900aa0"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("f49b26e5-313b-4a87-b83d-4dd5806aa90f"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("fe9c7818-4aac-440a-8e76-8ace46f89412"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("d3dffedc-6599-49b6-a72c-23f3c9a06a87"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("df2b2a99-d523-4a7a-a020-33190935b4c1"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("2f0bd318-b1d5-4c02-86c7-85b1349f7b2e"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("a2087c7d-4a39-4e47-ad51-4840f7adb6fd"));

            migrationBuilder.RenameTable(
                name: "UserRating",
                newName: "UserRatings");

            migrationBuilder.RenameIndex(
                name: "IX_UserRating_UserId",
                table: "UserRatings",
                newName: "IX_UserRatings_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRatings",
                table: "UserRatings",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_UserRatings_User_UserId",
                table: "UserRatings",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
