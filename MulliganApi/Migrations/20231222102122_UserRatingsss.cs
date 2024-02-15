using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class UserRatingsss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRatings_User_Id",
                table: "UserRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRatings_User_UserId",
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

            migrationBuilder.RenameColumn(
                name: "ratingDate",
                table: "UserRatings",
                newName: "RatingDate");

            migrationBuilder.RenameColumn(
                name: "rating",
                table: "UserRatings",
                newName: "Rating");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "UserRatings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_UserRatings_UserId1",
                table: "UserRatings",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRatings_User_UserId",
                table: "UserRatings",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRatings_User_UserId1",
                table: "UserRatings",
                column: "UserId1",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRatings_User_UserId",
                table: "UserRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRatings_User_UserId1",
                table: "UserRatings");

            migrationBuilder.DropIndex(
                name: "IX_UserRatings_UserId1",
                table: "UserRatings");

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
                name: "UserId1",
                table: "UserRatings");

            migrationBuilder.RenameColumn(
                name: "RatingDate",
                table: "UserRatings",
                newName: "ratingDate");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "UserRatings",
                newName: "rating");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "UserRatings",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.AddForeignKey(
                name: "FK_UserRatings_User_Id",
                table: "UserRatings",
                column: "Id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRatings_User_UserId",
                table: "UserRatings",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
