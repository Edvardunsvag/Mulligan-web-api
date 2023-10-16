using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class Initialk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("2900942b-962a-42dc-9727-c8ef6cdc215d"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("3bf83bff-af68-493a-b1ac-6c28470fae16"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("50420abb-c17f-4008-8403-72fdcc5a2398"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("61d9af83-16d8-489c-866e-78c78e201c3f"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("6291085e-2fdb-433c-bb79-5f7456936f49"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("a2924e5f-4555-4420-acb0-7c9fa91cd20f"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("b11f7da5-474d-4f20-92b9-1c7f137f4009"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("f0b42efe-4c19-4cca-a79c-60509117ecad"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("fc39dd36-4164-448c-b12d-62873c9f548c"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("50d52b9f-5cbb-4ae0-b1ec-4d0988b3707f"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("563db00b-f159-4e66-801f-217f3dabd7bf"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("71643069-398f-4211-bb90-333e104f16c7"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("76d6830f-9d51-4077-9530-4de8ee34f72b"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("820873a1-a7d8-474d-857e-b188403cadb9"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("83ebea39-ab40-4dc6-a3f7-6880f02b553b"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("9d4a2364-ee8e-4b4f-8fc5-765ef48ad47e"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("af3c61fb-9bf1-4244-9c2b-db687584989e"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("c953e9a2-6c9a-4461-8278-bd04be904276"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("d7fb7e19-1996-4e24-a4ac-e32f75a42910"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"));

            migrationBuilder.DeleteData(
                table: "Round",
                keyColumn: "RoundId",
                keyValue: new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"));

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "User",
                newName: "Username");

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName", "Has18Holes", "Length", "Par" },
                values: new object[] { new Guid("0831e002-40fb-4303-bdd9-ccf8a7b0a12e"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 0 });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Date", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("9729d711-2906-4f68-9c85-6625d0810249"), new Guid("0831e002-40fb-4303-bdd9-ccf8a7b0a12e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 33, new Guid("694122ad-7eee-4932-bab2-82fa2bfc2e25") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("25a86e87-5011-421b-97f6-790f2027bf2d"), new Guid("0831e002-40fb-4303-bdd9-ccf8a7b0a12e"), 4, 128, 3 },
                    { new Guid("344974ef-d410-4db5-be4b-1045aebb6070"), new Guid("0831e002-40fb-4303-bdd9-ccf8a7b0a12e"), 9, 330, 4 },
                    { new Guid("8b0e0761-d1f9-44f8-b63d-f0f4711e6f13"), new Guid("0831e002-40fb-4303-bdd9-ccf8a7b0a12e"), 8, 298, 4 },
                    { new Guid("8ea32f57-4055-4401-8d30-faf17826b0ef"), new Guid("0831e002-40fb-4303-bdd9-ccf8a7b0a12e"), 2, 295, 4 },
                    { new Guid("948e2c21-1d4c-4834-891a-2b2cace754e9"), new Guid("0831e002-40fb-4303-bdd9-ccf8a7b0a12e"), 1, 113, 3 },
                    { new Guid("9ec6e68e-d7bf-419c-af2e-1765d36529bf"), new Guid("0831e002-40fb-4303-bdd9-ccf8a7b0a12e"), 5, 506, 5 },
                    { new Guid("ac6178e6-ee89-4bde-9ac4-662e6ecbe2bf"), new Guid("0831e002-40fb-4303-bdd9-ccf8a7b0a12e"), 6, 227, 4 },
                    { new Guid("aee94310-dc83-4c60-a6cd-a305758a19e1"), new Guid("0831e002-40fb-4303-bdd9-ccf8a7b0a12e"), 3, 439, 5 },
                    { new Guid("de132c59-4cde-4d2c-b159-c762d4ee2d2d"), new Guid("0831e002-40fb-4303-bdd9-ccf8a7b0a12e"), 7, 270, 4 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("0ed6ea83-f255-4266-9e4e-a90ece2464b0"), 2, 2, new Guid("9729d711-2906-4f68-9c85-6625d0810249"), 6 },
                    { new Guid("40e811c1-9400-4c8e-b265-63b0a2fd0859"), 5, 1, new Guid("9729d711-2906-4f68-9c85-6625d0810249"), 4 },
                    { new Guid("4e99882c-d770-4ca0-b518-7f35ce8ea79b"), 8, 2, new Guid("9729d711-2906-4f68-9c85-6625d0810249"), 2 },
                    { new Guid("4f2eaa83-5f5b-412e-9aec-213a259d5ede"), 4, 2, new Guid("9729d711-2906-4f68-9c85-6625d0810249"), 3 },
                    { new Guid("549f43bb-46b0-4535-8fcb-264a4aab4aac"), 6, 2, new Guid("9729d711-2906-4f68-9c85-6625d0810249"), 4 },
                    { new Guid("803c15e5-6b93-49c0-a534-2bf9acabca4c"), 9, 3, new Guid("9729d711-2906-4f68-9c85-6625d0810249"), 4 },
                    { new Guid("843b2552-19b8-47dd-8ad3-60bee399b524"), 1, 2, new Guid("9729d711-2906-4f68-9c85-6625d0810249"), 2 },
                    { new Guid("a6c607e4-ba4b-4351-96de-9da9deae347e"), 7, 2, new Guid("9729d711-2906-4f68-9c85-6625d0810249"), 5 },
                    { new Guid("bc64ecf7-99c0-46cb-b38e-5279a2615488"), 3, 2, new Guid("9729d711-2906-4f68-9c85-6625d0810249"), 3 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[] { new Guid("1328b209-546f-4cca-84b5-d6bdce7e9310"), new Guid("0831e002-40fb-4303-bdd9-ccf8a7b0a12e"), 52 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("25a86e87-5011-421b-97f6-790f2027bf2d"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("344974ef-d410-4db5-be4b-1045aebb6070"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("8b0e0761-d1f9-44f8-b63d-f0f4711e6f13"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("8ea32f57-4055-4401-8d30-faf17826b0ef"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("948e2c21-1d4c-4834-891a-2b2cace754e9"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("9ec6e68e-d7bf-419c-af2e-1765d36529bf"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("ac6178e6-ee89-4bde-9ac4-662e6ecbe2bf"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("aee94310-dc83-4c60-a6cd-a305758a19e1"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("de132c59-4cde-4d2c-b159-c762d4ee2d2d"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("0ed6ea83-f255-4266-9e4e-a90ece2464b0"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("40e811c1-9400-4c8e-b265-63b0a2fd0859"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("4e99882c-d770-4ca0-b518-7f35ce8ea79b"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("4f2eaa83-5f5b-412e-9aec-213a259d5ede"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("549f43bb-46b0-4535-8fcb-264a4aab4aac"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("803c15e5-6b93-49c0-a534-2bf9acabca4c"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("843b2552-19b8-47dd-8ad3-60bee399b524"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("a6c607e4-ba4b-4351-96de-9da9deae347e"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("bc64ecf7-99c0-46cb-b38e-5279a2615488"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("1328b209-546f-4cca-84b5-d6bdce7e9310"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("0831e002-40fb-4303-bdd9-ccf8a7b0a12e"));

            migrationBuilder.DeleteData(
                table: "Round",
                keyColumn: "RoundId",
                keyValue: new Guid("9729d711-2906-4f68-9c85-6625d0810249"));

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "User",
                newName: "Email");

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName", "Has18Holes", "Length", "Par" },
                values: new object[] { new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 0 });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Date", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 33, new Guid("08108351-b943-45df-9c19-52d95e6707c3") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("2900942b-962a-42dc-9727-c8ef6cdc215d"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), 3, 439, 5 },
                    { new Guid("3bf83bff-af68-493a-b1ac-6c28470fae16"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), 9, 330, 4 },
                    { new Guid("50420abb-c17f-4008-8403-72fdcc5a2398"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), 5, 506, 5 },
                    { new Guid("61d9af83-16d8-489c-866e-78c78e201c3f"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), 7, 270, 4 },
                    { new Guid("6291085e-2fdb-433c-bb79-5f7456936f49"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), 1, 113, 3 },
                    { new Guid("a2924e5f-4555-4420-acb0-7c9fa91cd20f"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), 8, 298, 4 },
                    { new Guid("b11f7da5-474d-4f20-92b9-1c7f137f4009"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), 4, 128, 3 },
                    { new Guid("f0b42efe-4c19-4cca-a79c-60509117ecad"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), 2, 295, 4 },
                    { new Guid("fc39dd36-4164-448c-b12d-62873c9f548c"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), 6, 227, 4 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("50d52b9f-5cbb-4ae0-b1ec-4d0988b3707f"), 9, 3, new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"), 4 },
                    { new Guid("563db00b-f159-4e66-801f-217f3dabd7bf"), 6, 2, new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"), 4 },
                    { new Guid("71643069-398f-4211-bb90-333e104f16c7"), 8, 2, new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"), 2 },
                    { new Guid("76d6830f-9d51-4077-9530-4de8ee34f72b"), 5, 1, new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"), 4 },
                    { new Guid("820873a1-a7d8-474d-857e-b188403cadb9"), 1, 2, new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"), 2 },
                    { new Guid("83ebea39-ab40-4dc6-a3f7-6880f02b553b"), 3, 2, new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"), 3 },
                    { new Guid("9d4a2364-ee8e-4b4f-8fc5-765ef48ad47e"), 2, 2, new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"), 6 },
                    { new Guid("af3c61fb-9bf1-4244-9c2b-db687584989e"), 4, 2, new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"), 3 },
                    { new Guid("c953e9a2-6c9a-4461-8278-bd04be904276"), 7, 2, new Guid("10c15123-76a9-42a7-87dc-0f95e1145f68"), 5 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[] { new Guid("d7fb7e19-1996-4e24-a4ac-e32f75a42910"), new Guid("630c18b7-2d14-40a2-9bf5-00cffc77ab6c"), 52 });
        }
    }
}
