using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class UserRatingsUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName", "Has18Holes", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"), "Grønmo golfklubb description", "Grønmo golfklubb", false, 2870, 37 },
                    { new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 36 }
                });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("2b898959-5ea5-4212-9a33-e0da537918f7"), new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"), 2, 295, 4 },
                    { new Guid("4f57e7e2-50b6-488a-906d-9a732f804afe"), new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"), 7, 270, 4 },
                    { new Guid("6877ff95-deb9-4f1d-8c57-6ff4e564b7bf"), new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"), 8, 141, 3 },
                    { new Guid("768ee4a3-04d2-4e38-937b-164ef1294be4"), new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"), 1, 494, 5 },
                    { new Guid("79ca5e2f-aa36-43ff-8980-d79f0f837139"), new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"), 6, 337, 4 },
                    { new Guid("8a1f1008-c30c-4753-8f2c-25d91a0822c2"), new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"), 1, 113, 3 },
                    { new Guid("8cb7a6af-7028-4a32-8902-261356307082"), new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"), 9, 365, 4 },
                    { new Guid("8d5d4033-a475-41f3-8854-c12024cd047b"), new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"), 3, 439, 5 },
                    { new Guid("9fd267c0-bacf-4ae0-9e47-d1d4f6984635"), new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"), 4, 128, 3 },
                    { new Guid("ae4274df-444d-45b4-a7e9-5386b2e09e7c"), new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"), 8, 298, 4 },
                    { new Guid("c74895c6-468f-4354-bf43-6258374fe0a5"), new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"), 7, 412, 5 },
                    { new Guid("d27a6694-d4a0-4fdc-9f08-769733f1526c"), new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"), 9, 330, 4 },
                    { new Guid("d47fd485-7c83-4f27-a3d1-fbfc567dcdac"), new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"), 4, 367, 4 },
                    { new Guid("d663c8e5-050b-4a3b-8243-334076898aeb"), new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"), 6, 227, 4 },
                    { new Guid("db6ab4ff-43d6-4885-9c43-caab8dd8c52a"), new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"), 5, 506, 5 },
                    { new Guid("f797d609-5b09-4717-a71f-ae579d57d71d"), new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"), 2, 266, 5 },
                    { new Guid("f9ac0034-8838-414b-93ba-cfddc65529e9"), new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"), 3, 361, 4 },
                    { new Guid("f9c6eb7d-c335-4d43-ab1e-4b36678d435c"), new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"), 5, 127, 3 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[,]
                {
                    { new Guid("66643f26-f198-4098-83c3-857fd41a8f2a"), new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"), 52 },
                    { new Guid("c2dd0724-0025-4dff-b3e4-025ee6e1ebb6"), new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"), 57 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("2b898959-5ea5-4212-9a33-e0da537918f7"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("4f57e7e2-50b6-488a-906d-9a732f804afe"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("6877ff95-deb9-4f1d-8c57-6ff4e564b7bf"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("768ee4a3-04d2-4e38-937b-164ef1294be4"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("79ca5e2f-aa36-43ff-8980-d79f0f837139"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("8a1f1008-c30c-4753-8f2c-25d91a0822c2"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("8cb7a6af-7028-4a32-8902-261356307082"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("8d5d4033-a475-41f3-8854-c12024cd047b"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("9fd267c0-bacf-4ae0-9e47-d1d4f6984635"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("ae4274df-444d-45b4-a7e9-5386b2e09e7c"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("c74895c6-468f-4354-bf43-6258374fe0a5"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("d27a6694-d4a0-4fdc-9f08-769733f1526c"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("d47fd485-7c83-4f27-a3d1-fbfc567dcdac"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("d663c8e5-050b-4a3b-8243-334076898aeb"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("db6ab4ff-43d6-4885-9c43-caab8dd8c52a"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("f797d609-5b09-4717-a71f-ae579d57d71d"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("f9ac0034-8838-414b-93ba-cfddc65529e9"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("f9c6eb7d-c335-4d43-ab1e-4b36678d435c"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("66643f26-f198-4098-83c3-857fd41a8f2a"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("c2dd0724-0025-4dff-b3e4-025ee6e1ebb6"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"));

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
        }
    }
}
