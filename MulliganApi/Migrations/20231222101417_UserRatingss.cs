using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class UserRatingss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "UserId",
                table: "UserRatings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName", "Has18Holes", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("334b4e79-448b-4479-88be-9e8bdca13b24"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 36 },
                    { new Guid("5aa7b6ab-10f3-4036-bfca-06b4a548d69c"), "Grønmo golfklubb description", "Grønmo golfklubb", false, 2870, 37 }
                });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("48b30df1-b8dc-45e9-bbb9-112df3aeb6fe"), new Guid("5aa7b6ab-10f3-4036-bfca-06b4a548d69c"), 4, 367, 4 },
                    { new Guid("4bb0cb5c-b7f6-440f-919d-1e0be9e0b3c8"), new Guid("5aa7b6ab-10f3-4036-bfca-06b4a548d69c"), 3, 361, 4 },
                    { new Guid("5d6db470-cd79-4988-81c5-8eb621ebb725"), new Guid("5aa7b6ab-10f3-4036-bfca-06b4a548d69c"), 7, 412, 5 },
                    { new Guid("62d6ca6c-f435-4def-b355-474187b08bad"), new Guid("5aa7b6ab-10f3-4036-bfca-06b4a548d69c"), 5, 127, 3 },
                    { new Guid("63f7fa03-9571-46fb-9db8-08eaf3017459"), new Guid("334b4e79-448b-4479-88be-9e8bdca13b24"), 8, 298, 4 },
                    { new Guid("690826e8-b7d2-4afd-a80c-131b2b9cc71a"), new Guid("5aa7b6ab-10f3-4036-bfca-06b4a548d69c"), 6, 337, 4 },
                    { new Guid("695f5d67-c624-4577-97ff-f4e227ed6343"), new Guid("334b4e79-448b-4479-88be-9e8bdca13b24"), 9, 330, 4 },
                    { new Guid("8672ef66-7969-46ec-bc2c-1c899ba9767a"), new Guid("5aa7b6ab-10f3-4036-bfca-06b4a548d69c"), 9, 365, 4 },
                    { new Guid("8e8d1980-b6bb-448b-8396-55f8b59a1ced"), new Guid("5aa7b6ab-10f3-4036-bfca-06b4a548d69c"), 2, 266, 5 },
                    { new Guid("90269e20-ca57-4100-a63d-5930807b2de6"), new Guid("334b4e79-448b-4479-88be-9e8bdca13b24"), 6, 227, 4 },
                    { new Guid("99332c50-1713-4bb2-b2ac-1b8d5cec2886"), new Guid("334b4e79-448b-4479-88be-9e8bdca13b24"), 5, 506, 5 },
                    { new Guid("a5fa8957-0df2-4c03-9b0d-b993f872eba2"), new Guid("334b4e79-448b-4479-88be-9e8bdca13b24"), 1, 113, 3 },
                    { new Guid("b0a298bc-617d-42af-ab00-50e5fc236d5a"), new Guid("334b4e79-448b-4479-88be-9e8bdca13b24"), 7, 270, 4 },
                    { new Guid("b7be5db5-8aca-4b5d-9bea-b875c79671a2"), new Guid("5aa7b6ab-10f3-4036-bfca-06b4a548d69c"), 1, 494, 5 },
                    { new Guid("c347bc56-5033-4568-bf97-e82430e27e93"), new Guid("334b4e79-448b-4479-88be-9e8bdca13b24"), 2, 295, 4 },
                    { new Guid("c3b75c8b-2b32-4dbf-9138-9380ebe3f747"), new Guid("5aa7b6ab-10f3-4036-bfca-06b4a548d69c"), 8, 141, 3 },
                    { new Guid("ea5914c9-cee2-4b7c-b559-b762c9d0bc64"), new Guid("334b4e79-448b-4479-88be-9e8bdca13b24"), 3, 439, 5 },
                    { new Guid("fd01f751-dea2-481b-9a55-fe279d8e32ba"), new Guid("334b4e79-448b-4479-88be-9e8bdca13b24"), 4, 128, 3 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[,]
                {
                    { new Guid("b12cff5b-8b5b-4c5a-b209-b7e212c7769a"), new Guid("334b4e79-448b-4479-88be-9e8bdca13b24"), 52 },
                    { new Guid("f94519aa-ad4e-42d9-91a0-2a0f7f8d6088"), new Guid("5aa7b6ab-10f3-4036-bfca-06b4a548d69c"), 57 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRatings_UserId",
                table: "UserRatings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRatings_User_UserId",
                table: "UserRatings",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRatings_User_UserId",
                table: "UserRatings");

            migrationBuilder.DropIndex(
                name: "IX_UserRatings_UserId",
                table: "UserRatings");

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("48b30df1-b8dc-45e9-bbb9-112df3aeb6fe"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("4bb0cb5c-b7f6-440f-919d-1e0be9e0b3c8"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("5d6db470-cd79-4988-81c5-8eb621ebb725"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("62d6ca6c-f435-4def-b355-474187b08bad"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("63f7fa03-9571-46fb-9db8-08eaf3017459"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("690826e8-b7d2-4afd-a80c-131b2b9cc71a"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("695f5d67-c624-4577-97ff-f4e227ed6343"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("8672ef66-7969-46ec-bc2c-1c899ba9767a"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("8e8d1980-b6bb-448b-8396-55f8b59a1ced"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("90269e20-ca57-4100-a63d-5930807b2de6"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("99332c50-1713-4bb2-b2ac-1b8d5cec2886"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("a5fa8957-0df2-4c03-9b0d-b993f872eba2"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("b0a298bc-617d-42af-ab00-50e5fc236d5a"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("b7be5db5-8aca-4b5d-9bea-b875c79671a2"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("c347bc56-5033-4568-bf97-e82430e27e93"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("c3b75c8b-2b32-4dbf-9138-9380ebe3f747"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("ea5914c9-cee2-4b7c-b559-b762c9d0bc64"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("fd01f751-dea2-481b-9a55-fe279d8e32ba"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("b12cff5b-8b5b-4c5a-b209-b7e212c7769a"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("f94519aa-ad4e-42d9-91a0-2a0f7f8d6088"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("334b4e79-448b-4479-88be-9e8bdca13b24"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5aa7b6ab-10f3-4036-bfca-06b4a548d69c"));

            migrationBuilder.DropColumn(
                name: "UserId",
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
        }
    }
}
