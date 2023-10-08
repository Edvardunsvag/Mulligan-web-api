using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class Initials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("0f225cdb-ea6c-4c8b-a9e8-7f0142d77852"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("3f116610-5582-4134-a2a5-8a8415bb2ba3"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("698f4e72-58e6-49a8-8f61-1d99fa9e87ff"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("9aa21e91-9c93-4814-9e14-33844a56b8d2"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("a2198e2b-e8ca-4fd7-ab17-ef53372929c1"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("ccbe7866-f87d-416d-9005-2c83f692c168"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("d6a0d440-91bf-4c9d-8fe9-1a6b7253d364"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("f86fdc20-765c-4322-944d-d82c922a5117"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("fb032fb2-00bc-4530-96a6-16fa60735e3e"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("029374f8-9a73-4f0e-abb5-2011f9aa65da"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("1aa749b4-92ce-4525-b560-ce8dc5f0fde6"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("34acdb17-6597-4dff-9a9e-2ef621558f01"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("6a5605b7-0743-4bf8-8b1a-f81ee20db643"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("72ed27ca-f7ac-4185-af42-dba88c9b7c32"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("880eb72d-d831-46d8-9f0f-a16f5d2d6894"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("a05107f0-559e-468c-aa07-84b1d9c97191"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("b96f693e-7be9-4931-9dba-864bd50e1e1e"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("fde41c1c-14bf-4acc-aa5e-1948e90ce733"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("98b515ab-6b79-450d-88aa-3581a16119f0"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"));

            migrationBuilder.DeleteData(
                table: "Round",
                keyColumn: "RoundId",
                keyValue: new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"));

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName", "Has18Holes", "Length", "Par" },
                values: new object[] { new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"), "Krokhol golfklubb description", "Krokhol", false, 5000, 0 });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"), new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"), 18, 45, new Guid("71e44be8-91ef-4b35-8abe-4741fdd80296") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("088f5a4a-6ba3-46c5-9e3b-aa2a013633a4"), new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"), 7, 270, 4 },
                    { new Guid("19c12b33-85ad-40f6-843f-9201d0d1d291"), new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"), 5, 506, 5 },
                    { new Guid("2ff1c903-2a1b-49c2-92a4-382ea5e37c5f"), new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"), 3, 439, 5 },
                    { new Guid("33aaca0c-98d6-4a3a-9f25-318e9006b2ac"), new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"), 6, 227, 4 },
                    { new Guid("565d2e9e-d260-42dd-9415-ffa9646ce2c7"), new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"), 1, 113, 3 },
                    { new Guid("631afe8b-bf54-4b62-9bb5-fef79239db27"), new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"), 8, 298, 4 },
                    { new Guid("64ff62ba-d0c4-4288-8113-e898a8bf4804"), new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"), 4, 128, 3 },
                    { new Guid("801c6b17-90e9-424d-b1f1-20423acca297"), new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"), 9, 330, 4 },
                    { new Guid("dca81ed6-4fa2-485b-9595-cc7995ce009e"), new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"), 2, 295, 4 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("42c3a0eb-19ec-4377-a474-76e6f1cfd463"), 1, 2, new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"), 2 },
                    { new Guid("63ba9c5e-89a7-4f8c-b410-9b807c5d76e3"), 8, 2, new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"), 2 },
                    { new Guid("6f5ecd23-166e-4aee-8918-c913bec5c482"), 4, 2, new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"), 3 },
                    { new Guid("751befb8-ba6c-4899-928f-a7ff9bc1dedd"), 3, 2, new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"), 3 },
                    { new Guid("7b8bdd74-0052-4755-89b8-6fca6b94aeee"), 9, 3, new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"), 4 },
                    { new Guid("83c92190-e108-4f2f-82ae-ccf3e4e46be2"), 6, 2, new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"), 4 },
                    { new Guid("926ac575-7e23-4623-8fd3-8383d80cb12c"), 5, 1, new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"), 4 },
                    { new Guid("c2cdb27e-ba45-4879-bb0a-64d79bae4f0c"), 7, 2, new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"), 5 },
                    { new Guid("d96a177d-af8e-4958-85f8-ddfc75e20ecd"), 2, 2, new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"), 6 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[] { new Guid("cadf5b6e-68f2-4ec3-ac83-a4c17edb38ef"), new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"), 52 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("088f5a4a-6ba3-46c5-9e3b-aa2a013633a4"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("19c12b33-85ad-40f6-843f-9201d0d1d291"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("2ff1c903-2a1b-49c2-92a4-382ea5e37c5f"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("33aaca0c-98d6-4a3a-9f25-318e9006b2ac"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("565d2e9e-d260-42dd-9415-ffa9646ce2c7"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("631afe8b-bf54-4b62-9bb5-fef79239db27"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("64ff62ba-d0c4-4288-8113-e898a8bf4804"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("801c6b17-90e9-424d-b1f1-20423acca297"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("dca81ed6-4fa2-485b-9595-cc7995ce009e"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("42c3a0eb-19ec-4377-a474-76e6f1cfd463"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("63ba9c5e-89a7-4f8c-b410-9b807c5d76e3"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("6f5ecd23-166e-4aee-8918-c913bec5c482"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("751befb8-ba6c-4899-928f-a7ff9bc1dedd"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("7b8bdd74-0052-4755-89b8-6fca6b94aeee"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("83c92190-e108-4f2f-82ae-ccf3e4e46be2"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("926ac575-7e23-4623-8fd3-8383d80cb12c"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("c2cdb27e-ba45-4879-bb0a-64d79bae4f0c"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("d96a177d-af8e-4958-85f8-ddfc75e20ecd"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("cadf5b6e-68f2-4ec3-ac83-a4c17edb38ef"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"));

            migrationBuilder.DeleteData(
                table: "Round",
                keyColumn: "RoundId",
                keyValue: new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"));

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName", "Has18Holes", "Length", "Par" },
                values: new object[] { new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), "Krokhol golfklubb description", "Krokhol", false, 5000, 0 });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 18, 45, new Guid("c8ea1db6-ff62-4d10-9b31-85a0b4907725") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("0f225cdb-ea6c-4c8b-a9e8-7f0142d77852"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 5, 506, 5 },
                    { new Guid("3f116610-5582-4134-a2a5-8a8415bb2ba3"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 9, 330, 4 },
                    { new Guid("698f4e72-58e6-49a8-8f61-1d99fa9e87ff"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 2, 295, 4 },
                    { new Guid("9aa21e91-9c93-4814-9e14-33844a56b8d2"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 8, 298, 4 },
                    { new Guid("a2198e2b-e8ca-4fd7-ab17-ef53372929c1"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 3, 439, 5 },
                    { new Guid("ccbe7866-f87d-416d-9005-2c83f692c168"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 1, 113, 3 },
                    { new Guid("d6a0d440-91bf-4c9d-8fe9-1a6b7253d364"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 4, 128, 3 },
                    { new Guid("f86fdc20-765c-4322-944d-d82c922a5117"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 7, 270, 4 },
                    { new Guid("fb032fb2-00bc-4530-96a6-16fa60735e3e"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 6, 227, 4 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("029374f8-9a73-4f0e-abb5-2011f9aa65da"), 8, 2, new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"), 2 },
                    { new Guid("1aa749b4-92ce-4525-b560-ce8dc5f0fde6"), 9, 3, new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"), 4 },
                    { new Guid("34acdb17-6597-4dff-9a9e-2ef621558f01"), 3, 2, new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"), 3 },
                    { new Guid("6a5605b7-0743-4bf8-8b1a-f81ee20db643"), 7, 2, new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"), 5 },
                    { new Guid("72ed27ca-f7ac-4185-af42-dba88c9b7c32"), 4, 2, new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"), 3 },
                    { new Guid("880eb72d-d831-46d8-9f0f-a16f5d2d6894"), 5, 1, new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"), 4 },
                    { new Guid("a05107f0-559e-468c-aa07-84b1d9c97191"), 1, 2, new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"), 2 },
                    { new Guid("b96f693e-7be9-4931-9dba-864bd50e1e1e"), 6, 2, new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"), 4 },
                    { new Guid("fde41c1c-14bf-4acc-aa5e-1948e90ce733"), 2, 2, new Guid("6428fe4e-a06b-44ee-a453-af63ba43f7ba"), 6 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[] { new Guid("98b515ab-6b79-450d-88aa-3581a16119f0"), new Guid("e26618f1-b424-4ddb-b9b7-56146d4d1963"), 52 });
        }
    }
}
