using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class ChangesToUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("06831ff9-05bd-4f11-ac88-530991538a0e"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("0f7e2f66-d984-4c81-8b1b-54b3c53500b3"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("19911048-cd85-4f09-ab22-4dc7987563ba"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("2951fb31-b357-4c64-8123-31c0870cdf46"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("325b7631-19da-4d32-b582-6d288e86c7a2"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("374ccee7-89c4-470c-b7e4-423bf71619b6"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("45432af8-4b49-4fce-98e0-1b9464e17d1a"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("4eb0baf1-a92b-4d23-9f15-b20b6510ee99"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("56a7ef2a-b8b8-458c-a123-530be416bfd8"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("914c32d8-2a80-42ab-b8fe-a26b24b4a454"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("9543ff73-5200-4359-aaba-bb4857c79af6"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("c542eab8-72c1-4eca-9933-f5ca33e2cad4"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("cc8fe247-171f-4bdf-8922-cb8140839099"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("d3670fa8-9c00-4eb7-99e9-c383f328e0f7"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("e0a3a8dc-7d32-4a15-9af1-bd18a9a7390c"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("e8d9dc64-0421-48bd-afbe-6f536d1f7060"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("fb8a62d4-9c9c-4691-a693-414568dc650d"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("fdf11998-86b7-47f5-b893-dba5f2f59790"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("11f84b9b-ad97-4494-a516-4de21f530883"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("18ed7f64-53d7-43da-b255-413c827355e5"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("1bd292a0-b64e-4293-aaab-55bab5e7c721"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("1cf5793e-aec0-44be-8611-ebd0140c68b1"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("33fa2a57-95fa-496d-9d96-1a2744d77e74"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("34b8fe52-2dd2-4fc2-b0b3-5c76a67f03c3"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("839367e0-8f8e-4bd4-97a4-09cabcd0ad87"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("8718ad8d-d104-4699-8f2b-aef35cf9c1f2"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("e081f5a7-c826-4ce1-a3dd-636016aacbd1"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("09460a96-315c-4083-a11e-3693f08e5780"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("b0f90312-e6dc-44e7-8947-a18b72bc8145"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"));

            migrationBuilder.DeleteData(
                table: "Round",
                keyColumn: "RoundId",
                keyValue: new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

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
        }
    }
}
