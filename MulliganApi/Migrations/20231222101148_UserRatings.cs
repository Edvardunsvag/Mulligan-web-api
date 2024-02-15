using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class UserRatings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRatings_User_userId",
                table: "UserRatings");

            migrationBuilder.DropIndex(
                name: "IX_UserRatings_userId",
                table: "UserRatings");

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("16dc43d2-7df1-4845-8865-63f555310e09"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("4b291aff-d862-4f82-89ce-955436750fa0"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("578c9c22-8dab-4ede-bfb9-90e6f5f99789"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("5a27b0ae-62b1-4466-876d-177513ad95d6"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("6a08669b-6f8e-4921-b0a1-9fa6c193aa93"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("783d3efc-001c-4157-907b-af88414e687b"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("9cf05e55-089b-483e-a91a-9f6d1475e962"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("b3d6b996-1e45-4d1c-9490-995aa7d640b3"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("bb74c986-d7a7-4bdb-8ff0-c408072a871f"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("c09fb976-0dcd-493f-8db4-335ff8f21a56"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("c6638eb5-23ca-4957-955e-b35eb94a178f"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("c721ddad-4aee-4a29-acf7-70863f6f9fbd"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("cfb0b4c8-6d92-4e68-b982-32a0aab1b3d1"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("e29172c3-8bf9-4217-a0d4-eb81f0e4f147"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("e594d2d0-80d9-4cae-8d5c-194ef58d0eee"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("ec8d2b9b-9d4b-4b63-8b9a-1be087a9fc15"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("f96aefc0-fc54-4c93-a41d-97d67df82782"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("fc1cd502-5625-4bc7-93b0-d4a14ec0cc3d"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("08007533-2ae1-4970-a776-ab7954899219"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("0d319366-7f15-4ce0-a89b-90391b4174ce"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("1c0b92da-ffd4-4962-ace4-059f90dcf3ee"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("2cedd21e-7328-4f4d-848e-d304cdc48512"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("62b44a10-45ce-443c-8d4c-32a061436d10"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("6753673f-6b2d-4997-88ad-f0aea878174c"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("e12c8d97-9f14-48e9-ad3f-37a22d16a1d9"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("eab3cbbe-d9db-42f1-82ad-6a68b4ef0b78"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("f52f9cb5-fb59-4d38-b366-2206f6ff2b7d"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("1aa05a45-8aa7-41a3-836d-2779df34162b"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("9bd3694f-2379-420d-a515-a97e50ee7d18"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("0d16426e-50cd-469a-909d-8b1518f0ffd9"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("77126168-565a-4ecd-ac1a-a904fc6b8eaa"));

            migrationBuilder.DeleteData(
                table: "Round",
                keyColumn: "RoundId",
                keyValue: new Guid("14e9a747-e942-4d12-bcf6-38acbc7bd81c"));

            migrationBuilder.DropColumn(
                name: "userId",
                table: "UserRatings");

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName", "Has18Holes", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("3d530933-1c90-453c-9c8b-125308ed4521"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 36 },
                    { new Guid("61451737-a26b-4b5b-b4aa-d1088d4383a9"), "Grønmo golfklubb description", "Grønmo golfklubb", false, 2870, 37 }
                });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("03c5e264-30de-45ae-9049-0e3d0782436c"), new Guid("3d530933-1c90-453c-9c8b-125308ed4521"), 5, 506, 5 },
                    { new Guid("14f6fbd6-97de-4dbb-99c8-e61b7d2e28a5"), new Guid("61451737-a26b-4b5b-b4aa-d1088d4383a9"), 1, 494, 5 },
                    { new Guid("1e6cbf00-047c-4899-9478-bf83f99963bf"), new Guid("3d530933-1c90-453c-9c8b-125308ed4521"), 2, 295, 4 },
                    { new Guid("31076032-f579-4d03-8faa-7e708ca150cc"), new Guid("61451737-a26b-4b5b-b4aa-d1088d4383a9"), 3, 361, 4 },
                    { new Guid("32e815f4-4dbe-4c18-bb8e-7a4603a5450d"), new Guid("3d530933-1c90-453c-9c8b-125308ed4521"), 4, 128, 3 },
                    { new Guid("3cf1cb48-4aba-48f2-9b2b-1ec5910979de"), new Guid("61451737-a26b-4b5b-b4aa-d1088d4383a9"), 5, 127, 3 },
                    { new Guid("3d913231-82d1-405e-810a-12ae222b3125"), new Guid("61451737-a26b-4b5b-b4aa-d1088d4383a9"), 9, 365, 4 },
                    { new Guid("609a1545-c708-4bed-966d-08d94d52f371"), new Guid("3d530933-1c90-453c-9c8b-125308ed4521"), 7, 270, 4 },
                    { new Guid("6e705992-9341-41ee-b582-0ffda351e12e"), new Guid("61451737-a26b-4b5b-b4aa-d1088d4383a9"), 8, 141, 3 },
                    { new Guid("89b76a24-2e5c-4042-8cb3-ae2c80a21a4b"), new Guid("61451737-a26b-4b5b-b4aa-d1088d4383a9"), 7, 412, 5 },
                    { new Guid("a78f26c9-9ff5-431c-bd75-685cf37c2e1a"), new Guid("3d530933-1c90-453c-9c8b-125308ed4521"), 1, 113, 3 },
                    { new Guid("aa94accb-0145-44d9-b133-af6fed91bb36"), new Guid("3d530933-1c90-453c-9c8b-125308ed4521"), 8, 298, 4 },
                    { new Guid("aa9b30ea-f21f-426d-847f-4f523dbea20b"), new Guid("61451737-a26b-4b5b-b4aa-d1088d4383a9"), 6, 337, 4 },
                    { new Guid("c31ace15-7932-4303-a8c3-66fe34c1c162"), new Guid("3d530933-1c90-453c-9c8b-125308ed4521"), 9, 330, 4 },
                    { new Guid("d3750811-8ad0-42bf-86e7-a0d5a24e52f6"), new Guid("61451737-a26b-4b5b-b4aa-d1088d4383a9"), 2, 266, 5 },
                    { new Guid("e024d66a-5ab6-4a97-beab-c4aa2db0c5e1"), new Guid("3d530933-1c90-453c-9c8b-125308ed4521"), 3, 439, 5 },
                    { new Guid("f0102bd1-8ea4-4de1-bd34-748b446a157a"), new Guid("3d530933-1c90-453c-9c8b-125308ed4521"), 6, 227, 4 },
                    { new Guid("f7052f33-1cc2-4706-b6ab-5d548adb7b29"), new Guid("61451737-a26b-4b5b-b4aa-d1088d4383a9"), 4, 367, 4 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[,]
                {
                    { new Guid("540b81ee-2b47-4ef7-978b-2a3aa0abb20d"), new Guid("61451737-a26b-4b5b-b4aa-d1088d4383a9"), 57 },
                    { new Guid("6dfb76c4-983a-48bd-b2cb-9c2a6d08ed32"), new Guid("3d530933-1c90-453c-9c8b-125308ed4521"), 52 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserRatings_User_Id",
                table: "UserRatings",
                column: "Id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRatings_User_Id",
                table: "UserRatings");

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("03c5e264-30de-45ae-9049-0e3d0782436c"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("14f6fbd6-97de-4dbb-99c8-e61b7d2e28a5"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("1e6cbf00-047c-4899-9478-bf83f99963bf"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("31076032-f579-4d03-8faa-7e708ca150cc"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("32e815f4-4dbe-4c18-bb8e-7a4603a5450d"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("3cf1cb48-4aba-48f2-9b2b-1ec5910979de"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("3d913231-82d1-405e-810a-12ae222b3125"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("609a1545-c708-4bed-966d-08d94d52f371"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("6e705992-9341-41ee-b582-0ffda351e12e"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("89b76a24-2e5c-4042-8cb3-ae2c80a21a4b"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("a78f26c9-9ff5-431c-bd75-685cf37c2e1a"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("aa94accb-0145-44d9-b133-af6fed91bb36"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("aa9b30ea-f21f-426d-847f-4f523dbea20b"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("c31ace15-7932-4303-a8c3-66fe34c1c162"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("d3750811-8ad0-42bf-86e7-a0d5a24e52f6"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("e024d66a-5ab6-4a97-beab-c4aa2db0c5e1"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("f0102bd1-8ea4-4de1-bd34-748b446a157a"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("f7052f33-1cc2-4706-b6ab-5d548adb7b29"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("540b81ee-2b47-4ef7-978b-2a3aa0abb20d"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("6dfb76c4-983a-48bd-b2cb-9c2a6d08ed32"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("3d530933-1c90-453c-9c8b-125308ed4521"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("61451737-a26b-4b5b-b4aa-d1088d4383a9"));

            migrationBuilder.AddColumn<Guid>(
                name: "userId",
                table: "UserRatings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName", "Has18Holes", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("0d16426e-50cd-469a-909d-8b1518f0ffd9"), "Grønmo golfklubb description", "Grønmo golfklubb", false, 2870, 37 },
                    { new Guid("77126168-565a-4ecd-ac1a-a904fc6b8eaa"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 36 }
                });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Date", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("14e9a747-e942-4d12-bcf6-38acbc7bd81c"), new Guid("77126168-565a-4ecd-ac1a-a904fc6b8eaa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 33, new Guid("75b2efb0-62e9-4df6-8ebe-c6f21fff7a44") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("16dc43d2-7df1-4845-8865-63f555310e09"), new Guid("0d16426e-50cd-469a-909d-8b1518f0ffd9"), 8, 141, 3 },
                    { new Guid("4b291aff-d862-4f82-89ce-955436750fa0"), new Guid("77126168-565a-4ecd-ac1a-a904fc6b8eaa"), 3, 439, 5 },
                    { new Guid("578c9c22-8dab-4ede-bfb9-90e6f5f99789"), new Guid("77126168-565a-4ecd-ac1a-a904fc6b8eaa"), 2, 295, 4 },
                    { new Guid("5a27b0ae-62b1-4466-876d-177513ad95d6"), new Guid("77126168-565a-4ecd-ac1a-a904fc6b8eaa"), 7, 270, 4 },
                    { new Guid("6a08669b-6f8e-4921-b0a1-9fa6c193aa93"), new Guid("77126168-565a-4ecd-ac1a-a904fc6b8eaa"), 4, 128, 3 },
                    { new Guid("783d3efc-001c-4157-907b-af88414e687b"), new Guid("0d16426e-50cd-469a-909d-8b1518f0ffd9"), 1, 494, 5 },
                    { new Guid("9cf05e55-089b-483e-a91a-9f6d1475e962"), new Guid("77126168-565a-4ecd-ac1a-a904fc6b8eaa"), 8, 298, 4 },
                    { new Guid("b3d6b996-1e45-4d1c-9490-995aa7d640b3"), new Guid("0d16426e-50cd-469a-909d-8b1518f0ffd9"), 6, 337, 4 },
                    { new Guid("bb74c986-d7a7-4bdb-8ff0-c408072a871f"), new Guid("0d16426e-50cd-469a-909d-8b1518f0ffd9"), 2, 266, 5 },
                    { new Guid("c09fb976-0dcd-493f-8db4-335ff8f21a56"), new Guid("0d16426e-50cd-469a-909d-8b1518f0ffd9"), 9, 365, 4 },
                    { new Guid("c6638eb5-23ca-4957-955e-b35eb94a178f"), new Guid("0d16426e-50cd-469a-909d-8b1518f0ffd9"), 7, 412, 5 },
                    { new Guid("c721ddad-4aee-4a29-acf7-70863f6f9fbd"), new Guid("0d16426e-50cd-469a-909d-8b1518f0ffd9"), 5, 127, 3 },
                    { new Guid("cfb0b4c8-6d92-4e68-b982-32a0aab1b3d1"), new Guid("77126168-565a-4ecd-ac1a-a904fc6b8eaa"), 1, 113, 3 },
                    { new Guid("e29172c3-8bf9-4217-a0d4-eb81f0e4f147"), new Guid("0d16426e-50cd-469a-909d-8b1518f0ffd9"), 4, 367, 4 },
                    { new Guid("e594d2d0-80d9-4cae-8d5c-194ef58d0eee"), new Guid("77126168-565a-4ecd-ac1a-a904fc6b8eaa"), 9, 330, 4 },
                    { new Guid("ec8d2b9b-9d4b-4b63-8b9a-1be087a9fc15"), new Guid("77126168-565a-4ecd-ac1a-a904fc6b8eaa"), 5, 506, 5 },
                    { new Guid("f96aefc0-fc54-4c93-a41d-97d67df82782"), new Guid("0d16426e-50cd-469a-909d-8b1518f0ffd9"), 3, 361, 4 },
                    { new Guid("fc1cd502-5625-4bc7-93b0-d4a14ec0cc3d"), new Guid("77126168-565a-4ecd-ac1a-a904fc6b8eaa"), 6, 227, 4 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Par", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("08007533-2ae1-4970-a776-ab7954899219"), 3, 0, 2, new Guid("14e9a747-e942-4d12-bcf6-38acbc7bd81c"), 3 },
                    { new Guid("0d319366-7f15-4ce0-a89b-90391b4174ce"), 9, 0, 3, new Guid("14e9a747-e942-4d12-bcf6-38acbc7bd81c"), 4 },
                    { new Guid("1c0b92da-ffd4-4962-ace4-059f90dcf3ee"), 5, 0, 1, new Guid("14e9a747-e942-4d12-bcf6-38acbc7bd81c"), 4 },
                    { new Guid("2cedd21e-7328-4f4d-848e-d304cdc48512"), 8, 0, 2, new Guid("14e9a747-e942-4d12-bcf6-38acbc7bd81c"), 2 },
                    { new Guid("62b44a10-45ce-443c-8d4c-32a061436d10"), 6, 0, 2, new Guid("14e9a747-e942-4d12-bcf6-38acbc7bd81c"), 4 },
                    { new Guid("6753673f-6b2d-4997-88ad-f0aea878174c"), 1, 0, 2, new Guid("14e9a747-e942-4d12-bcf6-38acbc7bd81c"), 2 },
                    { new Guid("e12c8d97-9f14-48e9-ad3f-37a22d16a1d9"), 4, 0, 2, new Guid("14e9a747-e942-4d12-bcf6-38acbc7bd81c"), 3 },
                    { new Guid("eab3cbbe-d9db-42f1-82ad-6a68b4ef0b78"), 2, 0, 2, new Guid("14e9a747-e942-4d12-bcf6-38acbc7bd81c"), 6 },
                    { new Guid("f52f9cb5-fb59-4d38-b366-2206f6ff2b7d"), 7, 0, 2, new Guid("14e9a747-e942-4d12-bcf6-38acbc7bd81c"), 5 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[,]
                {
                    { new Guid("1aa05a45-8aa7-41a3-836d-2779df34162b"), new Guid("0d16426e-50cd-469a-909d-8b1518f0ffd9"), 57 },
                    { new Guid("9bd3694f-2379-420d-a515-a97e50ee7d18"), new Guid("77126168-565a-4ecd-ac1a-a904fc6b8eaa"), 52 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRatings_userId",
                table: "UserRatings",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRatings_User_userId",
                table: "UserRatings",
                column: "userId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
