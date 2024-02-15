using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class optionalEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("2de2de63-0ffb-4dc5-a9fc-2869fdb18eab"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("38cf2d35-257c-4b09-a06c-43c6323a8b1c"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("3d865835-3fe6-4b16-bf03-e31ca45b4f04"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("52035625-d1f8-4afa-b5f9-d8d3bf75de9e"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("52d58aca-c60b-405d-a443-a06759180ec0"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("5f14b6d3-f553-48fb-88b9-f6d0673c9b15"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("8d852778-fac6-499d-ac9b-7a2f0a13c976"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("a0d4d5d4-847e-4e6c-9f8b-bf859ae294ad"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("a52b8d77-5e5b-4d0b-845a-a1b86720bfec"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("abbc8bee-899c-445f-9095-00f718cc94ef"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("bdb9ca9f-cdf1-4889-9a55-02945c71df4c"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("c674f9b3-14b0-4de9-b4fc-cd06e31d59a6"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("cbf13496-c944-4431-a70d-e5467c23ec00"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("ddd51cb8-81c8-4cfe-a956-ffdd011c8349"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("ddec1612-c6be-4d7e-bf07-a3cbee52d259"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("eedf4b57-2652-438a-848f-c9d67bead932"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("fbb6d3be-9778-4af7-bbe9-b156a40cdb1d"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("fedb12c2-14ac-4d91-a303-d7a72c9bb152"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("0062a0a6-e07e-4e79-ba58-37856d88f50c"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("12cd8005-ccd4-497a-9896-74f6b24d6aae"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("61a73fff-8cd5-4acf-94d1-a5da5dd9010a"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("6a09090a-c35e-4223-9b3b-47b67f17bdaf"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("b20af224-fe21-4187-abd1-2fa9427f2b2a"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("b8dc3cf5-d068-4110-a095-b1cc627009a7"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("c8e79cf0-93fd-403b-b851-e99e98d270c8"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("d373fdf5-e192-4f98-b208-ab4a55821ee9"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("f7a80cfa-8646-43cf-a684-204f44cd3a82"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("3a8913a0-5241-4b0a-9d7c-e24497d29f93"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("a480bc89-8422-4383-a179-1ff1b663677f"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"));

            migrationBuilder.DeleteData(
                table: "Round",
                keyColumn: "RoundId",
                keyValue: new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName", "Has18Holes", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"), "Grønmo golfklubb description", "Grønmo golfklubb", false, 2870, 37 },
                    { new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 36 }
                });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Date", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("244f8f51-9394-4374-b074-350ab2841f86"), new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 33, new Guid("87f32ca7-d592-44b9-8026-80ce3c5c7ca1") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("1bff6206-eb7b-4ff0-a18c-6c87af0d28d1"), new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"), 8, 298, 4 },
                    { new Guid("2724ae8a-69fe-4e8b-9d4e-513d8a63eb36"), new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"), 4, 367, 4 },
                    { new Guid("2ca53452-aa7e-4428-b0ad-7e5ff9e3a77d"), new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"), 8, 141, 3 },
                    { new Guid("2fb65d4e-262c-4598-a081-75b614c5b5e6"), new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"), 1, 113, 3 },
                    { new Guid("32cb58d1-776d-4e39-a46b-1a7ff47949a1"), new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"), 5, 127, 3 },
                    { new Guid("4480cc3c-df53-4a67-8a30-b6a9e790913f"), new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"), 2, 266, 5 },
                    { new Guid("599128da-2e42-458e-9390-51a3ca73bd38"), new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"), 3, 439, 5 },
                    { new Guid("777a6f11-2ba1-4c28-b3eb-effb62b6aece"), new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"), 3, 361, 4 },
                    { new Guid("7d229392-356d-42de-9231-f13be2d540c7"), new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"), 4, 128, 3 },
                    { new Guid("84c88ad9-b721-445c-a5e2-8643fae0fc87"), new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"), 9, 365, 4 },
                    { new Guid("933a29ca-99d1-46d7-97ab-97eb99945915"), new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"), 5, 506, 5 },
                    { new Guid("a44ec46d-7ff6-46f2-ac13-4ba568be8f78"), new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"), 6, 227, 4 },
                    { new Guid("a85f487f-f9b7-4bee-92a6-39d1fc68a07b"), new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"), 7, 270, 4 },
                    { new Guid("b028ae8c-fc77-4b2e-89f3-2a4e4c8295de"), new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"), 2, 295, 4 },
                    { new Guid("e6e3d6fe-6a52-43f1-8eae-241011965aba"), new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"), 9, 330, 4 },
                    { new Guid("e839273a-f4f8-4d32-9c33-b93bde8321ce"), new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"), 7, 412, 5 },
                    { new Guid("f154f384-c857-42ac-942c-93feef5b6c39"), new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"), 6, 337, 4 },
                    { new Guid("f33c86f9-14dd-4ee9-921e-cac64a645ab1"), new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"), 1, 494, 5 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Par", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("2902bf14-3307-4e6e-8a70-deaeeac1132b"), 6, 0, 2, new Guid("244f8f51-9394-4374-b074-350ab2841f86"), 4 },
                    { new Guid("2bf3092f-1f05-432d-afb3-47773d41c474"), 8, 0, 2, new Guid("244f8f51-9394-4374-b074-350ab2841f86"), 2 },
                    { new Guid("30bb31ea-ad39-499a-9749-0fea53fcd1ee"), 5, 0, 1, new Guid("244f8f51-9394-4374-b074-350ab2841f86"), 4 },
                    { new Guid("6054dc2b-4708-4da2-af6a-9d069fd3d339"), 9, 0, 3, new Guid("244f8f51-9394-4374-b074-350ab2841f86"), 4 },
                    { new Guid("7382f2bf-f190-4ef8-ac08-e532535b13a4"), 1, 0, 2, new Guid("244f8f51-9394-4374-b074-350ab2841f86"), 2 },
                    { new Guid("837d0f7d-39e1-45e6-9dba-1ea8f2e71047"), 2, 0, 2, new Guid("244f8f51-9394-4374-b074-350ab2841f86"), 6 },
                    { new Guid("88e3a56c-7c1e-4048-a267-f787f84f8851"), 4, 0, 2, new Guid("244f8f51-9394-4374-b074-350ab2841f86"), 3 },
                    { new Guid("a17978c6-f0ab-429a-a70b-a5045c2fbadb"), 7, 0, 2, new Guid("244f8f51-9394-4374-b074-350ab2841f86"), 5 },
                    { new Guid("ea49f85f-d245-469e-a40c-698ab952e332"), 3, 0, 2, new Guid("244f8f51-9394-4374-b074-350ab2841f86"), 3 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[,]
                {
                    { new Guid("4e1fe4d8-332a-4987-933e-5a738ddba836"), new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"), 52 },
                    { new Guid("8bb8ee7f-6f22-442f-82ce-372a8f8a90fd"), new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"), 57 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("1bff6206-eb7b-4ff0-a18c-6c87af0d28d1"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("2724ae8a-69fe-4e8b-9d4e-513d8a63eb36"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("2ca53452-aa7e-4428-b0ad-7e5ff9e3a77d"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("2fb65d4e-262c-4598-a081-75b614c5b5e6"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("32cb58d1-776d-4e39-a46b-1a7ff47949a1"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("4480cc3c-df53-4a67-8a30-b6a9e790913f"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("599128da-2e42-458e-9390-51a3ca73bd38"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("777a6f11-2ba1-4c28-b3eb-effb62b6aece"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("7d229392-356d-42de-9231-f13be2d540c7"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("84c88ad9-b721-445c-a5e2-8643fae0fc87"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("933a29ca-99d1-46d7-97ab-97eb99945915"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("a44ec46d-7ff6-46f2-ac13-4ba568be8f78"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("a85f487f-f9b7-4bee-92a6-39d1fc68a07b"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("b028ae8c-fc77-4b2e-89f3-2a4e4c8295de"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("e6e3d6fe-6a52-43f1-8eae-241011965aba"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("e839273a-f4f8-4d32-9c33-b93bde8321ce"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("f154f384-c857-42ac-942c-93feef5b6c39"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("f33c86f9-14dd-4ee9-921e-cac64a645ab1"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("2902bf14-3307-4e6e-8a70-deaeeac1132b"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("2bf3092f-1f05-432d-afb3-47773d41c474"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("30bb31ea-ad39-499a-9749-0fea53fcd1ee"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("6054dc2b-4708-4da2-af6a-9d069fd3d339"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("7382f2bf-f190-4ef8-ac08-e532535b13a4"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("837d0f7d-39e1-45e6-9dba-1ea8f2e71047"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("88e3a56c-7c1e-4048-a267-f787f84f8851"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("a17978c6-f0ab-429a-a70b-a5045c2fbadb"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("ea49f85f-d245-469e-a40c-698ab952e332"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("4e1fe4d8-332a-4987-933e-5a738ddba836"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("8bb8ee7f-6f22-442f-82ce-372a8f8a90fd"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"));

            migrationBuilder.DeleteData(
                table: "Round",
                keyColumn: "RoundId",
                keyValue: new Guid("244f8f51-9394-4374-b074-350ab2841f86"));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName", "Has18Holes", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 36 },
                    { new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"), "Grønmo golfklubb description", "Grønmo golfklubb", false, 2870, 37 }
                });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Date", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"), new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 33, new Guid("38adbc5b-b58a-4b4f-9b71-66ed80b261d7") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("2de2de63-0ffb-4dc5-a9fc-2869fdb18eab"), new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"), 5, 506, 5 },
                    { new Guid("38cf2d35-257c-4b09-a06c-43c6323a8b1c"), new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"), 6, 337, 4 },
                    { new Guid("3d865835-3fe6-4b16-bf03-e31ca45b4f04"), new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"), 1, 113, 3 },
                    { new Guid("52035625-d1f8-4afa-b5f9-d8d3bf75de9e"), new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"), 8, 298, 4 },
                    { new Guid("52d58aca-c60b-405d-a443-a06759180ec0"), new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"), 4, 128, 3 },
                    { new Guid("5f14b6d3-f553-48fb-88b9-f6d0673c9b15"), new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"), 1, 494, 5 },
                    { new Guid("8d852778-fac6-499d-ac9b-7a2f0a13c976"), new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"), 9, 365, 4 },
                    { new Guid("a0d4d5d4-847e-4e6c-9f8b-bf859ae294ad"), new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"), 8, 141, 3 },
                    { new Guid("a52b8d77-5e5b-4d0b-845a-a1b86720bfec"), new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"), 3, 361, 4 },
                    { new Guid("abbc8bee-899c-445f-9095-00f718cc94ef"), new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"), 7, 412, 5 },
                    { new Guid("bdb9ca9f-cdf1-4889-9a55-02945c71df4c"), new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"), 9, 330, 4 },
                    { new Guid("c674f9b3-14b0-4de9-b4fc-cd06e31d59a6"), new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"), 3, 439, 5 },
                    { new Guid("cbf13496-c944-4431-a70d-e5467c23ec00"), new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"), 7, 270, 4 },
                    { new Guid("ddd51cb8-81c8-4cfe-a956-ffdd011c8349"), new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"), 6, 227, 4 },
                    { new Guid("ddec1612-c6be-4d7e-bf07-a3cbee52d259"), new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"), 2, 295, 4 },
                    { new Guid("eedf4b57-2652-438a-848f-c9d67bead932"), new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"), 4, 367, 4 },
                    { new Guid("fbb6d3be-9778-4af7-bbe9-b156a40cdb1d"), new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"), 5, 127, 3 },
                    { new Guid("fedb12c2-14ac-4d91-a303-d7a72c9bb152"), new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"), 2, 266, 5 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Par", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("0062a0a6-e07e-4e79-ba58-37856d88f50c"), 4, 0, 2, new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"), 3 },
                    { new Guid("12cd8005-ccd4-497a-9896-74f6b24d6aae"), 1, 0, 2, new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"), 2 },
                    { new Guid("61a73fff-8cd5-4acf-94d1-a5da5dd9010a"), 7, 0, 2, new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"), 5 },
                    { new Guid("6a09090a-c35e-4223-9b3b-47b67f17bdaf"), 5, 0, 1, new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"), 4 },
                    { new Guid("b20af224-fe21-4187-abd1-2fa9427f2b2a"), 3, 0, 2, new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"), 3 },
                    { new Guid("b8dc3cf5-d068-4110-a095-b1cc627009a7"), 2, 0, 2, new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"), 6 },
                    { new Guid("c8e79cf0-93fd-403b-b851-e99e98d270c8"), 9, 0, 3, new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"), 4 },
                    { new Guid("d373fdf5-e192-4f98-b208-ab4a55821ee9"), 8, 0, 2, new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"), 2 },
                    { new Guid("f7a80cfa-8646-43cf-a684-204f44cd3a82"), 6, 0, 2, new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"), 4 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[,]
                {
                    { new Guid("3a8913a0-5241-4b0a-9d7c-e24497d29f93"), new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"), 52 },
                    { new Guid("a480bc89-8422-4383-a179-1ff1b663677f"), new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"), 57 }
                });
        }
    }
}
