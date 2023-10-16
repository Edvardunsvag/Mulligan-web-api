using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedDateToRound : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Round",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName", "Has18Holes", "Length", "Par" },
                values: new object[] { new Guid("603590d4-86f5-44d0-8054-9007c75d01df"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 0 });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Date", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("d0c93632-be15-4a53-84dc-8aa23761fa9b"), new Guid("603590d4-86f5-44d0-8054-9007c75d01df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 33, new Guid("1a003d39-a7fb-47a5-852e-cc4537589ebd") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("0351ed02-76e8-4a8b-9995-aea8dcec374a"), new Guid("603590d4-86f5-44d0-8054-9007c75d01df"), 1, 113, 3 },
                    { new Guid("1501c156-2c79-433f-9734-50542a2c8b43"), new Guid("603590d4-86f5-44d0-8054-9007c75d01df"), 7, 270, 4 },
                    { new Guid("480fb4b7-dcea-4579-89bc-7c98d24c1ca6"), new Guid("603590d4-86f5-44d0-8054-9007c75d01df"), 6, 227, 4 },
                    { new Guid("60cfd858-2d59-48f0-a3b4-6e74d79efe2f"), new Guid("603590d4-86f5-44d0-8054-9007c75d01df"), 8, 298, 4 },
                    { new Guid("735726ed-b5a5-46ef-8991-09c555e603f3"), new Guid("603590d4-86f5-44d0-8054-9007c75d01df"), 5, 506, 5 },
                    { new Guid("a733ca41-342c-44fc-8591-b396b1c8319f"), new Guid("603590d4-86f5-44d0-8054-9007c75d01df"), 4, 128, 3 },
                    { new Guid("c04d3679-65a9-4239-ac59-ff3c119ee195"), new Guid("603590d4-86f5-44d0-8054-9007c75d01df"), 9, 330, 4 },
                    { new Guid("c2047cf0-6041-4a4c-807f-ecfc48de3c9b"), new Guid("603590d4-86f5-44d0-8054-9007c75d01df"), 3, 439, 5 },
                    { new Guid("fde3d2e8-1cba-4a04-8ec2-127234c61750"), new Guid("603590d4-86f5-44d0-8054-9007c75d01df"), 2, 295, 4 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("11488248-4e0f-45d8-a7d2-e7317a27ec59"), 7, 2, new Guid("d0c93632-be15-4a53-84dc-8aa23761fa9b"), 5 },
                    { new Guid("1971114b-7a86-4fbc-8321-b515b3956fce"), 2, 2, new Guid("d0c93632-be15-4a53-84dc-8aa23761fa9b"), 6 },
                    { new Guid("23a63297-6457-470c-98fe-6e6e4001cd70"), 5, 1, new Guid("d0c93632-be15-4a53-84dc-8aa23761fa9b"), 4 },
                    { new Guid("370017fa-8175-4789-bc38-9b83232477e4"), 4, 2, new Guid("d0c93632-be15-4a53-84dc-8aa23761fa9b"), 3 },
                    { new Guid("6645fa67-3787-4170-b9f5-e402c5d13cf4"), 1, 2, new Guid("d0c93632-be15-4a53-84dc-8aa23761fa9b"), 2 },
                    { new Guid("bad6f067-37b9-43a0-aa87-d7c42b033e92"), 9, 3, new Guid("d0c93632-be15-4a53-84dc-8aa23761fa9b"), 4 },
                    { new Guid("bd191f24-5039-4cab-9b1b-a0295efd2d01"), 3, 2, new Guid("d0c93632-be15-4a53-84dc-8aa23761fa9b"), 3 },
                    { new Guid("ca1accd7-1ef3-4d96-ae9a-446bb0319676"), 6, 2, new Guid("d0c93632-be15-4a53-84dc-8aa23761fa9b"), 4 },
                    { new Guid("f9217701-8e51-4755-995a-70544cf23789"), 8, 2, new Guid("d0c93632-be15-4a53-84dc-8aa23761fa9b"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[] { new Guid("181a8314-dea4-40db-961c-c66639673c84"), new Guid("603590d4-86f5-44d0-8054-9007c75d01df"), 52 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("0351ed02-76e8-4a8b-9995-aea8dcec374a"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("1501c156-2c79-433f-9734-50542a2c8b43"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("480fb4b7-dcea-4579-89bc-7c98d24c1ca6"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("60cfd858-2d59-48f0-a3b4-6e74d79efe2f"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("735726ed-b5a5-46ef-8991-09c555e603f3"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("a733ca41-342c-44fc-8591-b396b1c8319f"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("c04d3679-65a9-4239-ac59-ff3c119ee195"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("c2047cf0-6041-4a4c-807f-ecfc48de3c9b"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("fde3d2e8-1cba-4a04-8ec2-127234c61750"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("11488248-4e0f-45d8-a7d2-e7317a27ec59"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("1971114b-7a86-4fbc-8321-b515b3956fce"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("23a63297-6457-470c-98fe-6e6e4001cd70"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("370017fa-8175-4789-bc38-9b83232477e4"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("6645fa67-3787-4170-b9f5-e402c5d13cf4"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("bad6f067-37b9-43a0-aa87-d7c42b033e92"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("bd191f24-5039-4cab-9b1b-a0295efd2d01"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("ca1accd7-1ef3-4d96-ae9a-446bb0319676"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("f9217701-8e51-4755-995a-70544cf23789"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("181a8314-dea4-40db-961c-c66639673c84"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("603590d4-86f5-44d0-8054-9007c75d01df"));

            migrationBuilder.DeleteData(
                table: "Round",
                keyColumn: "RoundId",
                keyValue: new Guid("d0c93632-be15-4a53-84dc-8aa23761fa9b"));

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Round");

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
    }
}
