using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class Initialss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("fd1cef2b-cc06-4c64-950f-3aa5e84a16f6"), "Krokhol golfklubb description", "Krokhol", false, 9, 0 });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("5d55e271-7f64-4e34-a86c-7799d9bcddc2"), new Guid("fd1cef2b-cc06-4c64-950f-3aa5e84a16f6"), 18, 45, new Guid("36ff434e-32df-4f07-b930-0f9810565e08") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("0b20565e-3877-4fa3-a68b-f841fe84c55b"), new Guid("fd1cef2b-cc06-4c64-950f-3aa5e84a16f6"), 3, 439, 5 },
                    { new Guid("4b6a3094-7934-498c-9c37-1fe84b860f69"), new Guid("fd1cef2b-cc06-4c64-950f-3aa5e84a16f6"), 5, 506, 5 },
                    { new Guid("85edf5a7-12f8-42b4-9350-030cd7bf2ed4"), new Guid("fd1cef2b-cc06-4c64-950f-3aa5e84a16f6"), 1, 113, 3 },
                    { new Guid("9c76b30d-39cb-4604-9790-77a3a4ca3de3"), new Guid("fd1cef2b-cc06-4c64-950f-3aa5e84a16f6"), 7, 270, 4 },
                    { new Guid("acbf954d-d076-48c0-a189-dd9a441c6af7"), new Guid("fd1cef2b-cc06-4c64-950f-3aa5e84a16f6"), 9, 330, 4 },
                    { new Guid("acef557f-f992-4830-a03c-0257f1f25c2a"), new Guid("fd1cef2b-cc06-4c64-950f-3aa5e84a16f6"), 8, 298, 4 },
                    { new Guid("bfc45fc0-3a38-4783-8055-352ace88d720"), new Guid("fd1cef2b-cc06-4c64-950f-3aa5e84a16f6"), 2, 295, 4 },
                    { new Guid("d7824f57-03fb-4757-b2ab-83952a3b2f86"), new Guid("fd1cef2b-cc06-4c64-950f-3aa5e84a16f6"), 6, 227, 4 },
                    { new Guid("fd8a9273-cdac-4bce-9949-edde3a321e6d"), new Guid("fd1cef2b-cc06-4c64-950f-3aa5e84a16f6"), 4, 128, 3 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("0e77af22-5212-430d-b2d9-4ab9023e131d"), 2, 2, new Guid("5d55e271-7f64-4e34-a86c-7799d9bcddc2"), 6 },
                    { new Guid("32e45698-524c-42bc-be53-0c6105a28071"), 6, 2, new Guid("5d55e271-7f64-4e34-a86c-7799d9bcddc2"), 4 },
                    { new Guid("4d64082a-30c9-437d-86d8-4b3649d05e1c"), 3, 2, new Guid("5d55e271-7f64-4e34-a86c-7799d9bcddc2"), 3 },
                    { new Guid("69d6b8f5-3982-42e5-b198-6b52a288c19b"), 4, 2, new Guid("5d55e271-7f64-4e34-a86c-7799d9bcddc2"), 3 },
                    { new Guid("8c774b2f-349a-40ed-932e-a3a7b6ebe9b8"), 5, 1, new Guid("5d55e271-7f64-4e34-a86c-7799d9bcddc2"), 4 },
                    { new Guid("92e78faf-3bd6-4dee-885f-1d5a7361f479"), 1, 2, new Guid("5d55e271-7f64-4e34-a86c-7799d9bcddc2"), 2 },
                    { new Guid("abcd7889-4aa3-4372-b817-2e6e36f8a4d4"), 7, 2, new Guid("5d55e271-7f64-4e34-a86c-7799d9bcddc2"), 5 },
                    { new Guid("ba2100ca-e068-4a35-a8d3-0970755c96af"), 9, 3, new Guid("5d55e271-7f64-4e34-a86c-7799d9bcddc2"), 4 },
                    { new Guid("dc18a705-221a-4d5c-9eef-39824d6c73c4"), 8, 2, new Guid("5d55e271-7f64-4e34-a86c-7799d9bcddc2"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[] { new Guid("5d226fb7-fa19-4952-b6b0-d26bbc68b9bc"), new Guid("fd1cef2b-cc06-4c64-950f-3aa5e84a16f6"), 52 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("0b20565e-3877-4fa3-a68b-f841fe84c55b"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("4b6a3094-7934-498c-9c37-1fe84b860f69"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("85edf5a7-12f8-42b4-9350-030cd7bf2ed4"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("9c76b30d-39cb-4604-9790-77a3a4ca3de3"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("acbf954d-d076-48c0-a189-dd9a441c6af7"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("acef557f-f992-4830-a03c-0257f1f25c2a"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("bfc45fc0-3a38-4783-8055-352ace88d720"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("d7824f57-03fb-4757-b2ab-83952a3b2f86"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("fd8a9273-cdac-4bce-9949-edde3a321e6d"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("0e77af22-5212-430d-b2d9-4ab9023e131d"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("32e45698-524c-42bc-be53-0c6105a28071"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("4d64082a-30c9-437d-86d8-4b3649d05e1c"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("69d6b8f5-3982-42e5-b198-6b52a288c19b"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("8c774b2f-349a-40ed-932e-a3a7b6ebe9b8"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("92e78faf-3bd6-4dee-885f-1d5a7361f479"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("abcd7889-4aa3-4372-b817-2e6e36f8a4d4"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("ba2100ca-e068-4a35-a8d3-0970755c96af"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("dc18a705-221a-4d5c-9eef-39824d6c73c4"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("5d226fb7-fa19-4952-b6b0-d26bbc68b9bc"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("fd1cef2b-cc06-4c64-950f-3aa5e84a16f6"));

            migrationBuilder.DeleteData(
                table: "Round",
                keyColumn: "RoundId",
                keyValue: new Guid("5d55e271-7f64-4e34-a86c-7799d9bcddc2"));

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
    }
}
