using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class UserRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("0bc45d6b-2510-4694-ae39-6f3ee4b250ff"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("18f1eefd-a516-466d-85d7-bcbc59fe3a50"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("21199c16-a87f-4345-8993-56c4e6b9c048"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("22d9d31d-fb2c-4841-9f11-146b1a45a799"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("4cf25b13-5e7d-4a38-8609-e47641261100"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("578586dd-3575-4167-aba3-391ba71ef231"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("670c67bb-48c4-4d67-93a5-79a1f497a950"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("6bcb531c-a00c-4d46-8c57-f19b0bb4c590"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("709ae3b1-6a8e-4002-95ec-5da37368d67f"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("76659040-b971-4f18-ba63-d93206e29f51"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("91520dfd-b666-44cd-b24f-b9493ecdf68d"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("96a02f1e-7e49-4f23-8f59-c95cd07e0ed1"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("9edab717-4f8a-4b2f-ba58-54c2f28adc32"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("a71f9827-79aa-4b7d-893b-783b5f815841"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("cedc4646-8ec3-4d63-8592-da5a906bf1f0"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("d5bd17dd-44c1-4351-81e2-c27fe0a8c54a"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("e7728d79-0d6f-432b-a939-84598c366517"));

            migrationBuilder.DeleteData(
                table: "CourseHole",
                keyColumn: "Id",
                keyValue: new Guid("f8d72b1f-f53e-4420-9d9f-cc8fa374b7cc"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("297491b5-bd75-43ef-95e8-88b79cafbffa"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("3d3ec277-9d83-4ac9-bdf9-e38f0b5b5755"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("3ef753b3-60db-47d5-9de3-8a14866eb411"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("3f027657-0bde-4cbf-833c-b9d061a300ba"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("8c40f081-6373-44c6-9a03-c36e4ef672b2"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("a52e6283-7fc9-425d-9c9d-f63c12f5925d"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("e965b85b-14aa-4ba6-a106-9ae40d88576f"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("f6bc538e-5cb6-4f97-ae38-0ec68cdd91c4"));

            migrationBuilder.DeleteData(
                table: "RoundHole",
                keyColumn: "Id",
                keyValue: new Guid("fff23e10-798b-4416-b746-a5f3d822d5c2"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("2031bd3b-2884-4e12-b7ac-53a0c441e2ed"));

            migrationBuilder.DeleteData(
                table: "TeeBoxes",
                keyColumn: "Id",
                keyValue: new Guid("295f5d13-6cb1-4df4-b62f-fec40bead64c"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("023f78c6-9f13-4d59-b7d0-bd1749a6e74f"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("fd146759-1798-412c-8623-4a43cc602e89"));

            migrationBuilder.DeleteData(
                table: "Round",
                keyColumn: "RoundId",
                keyValue: new Guid("a939cc14-c863-4db8-be78-cc7cf841fc1e"));

            migrationBuilder.CreateTable(
                name: "UserRatings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ratingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRatings_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRatings");

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

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName", "Has18Holes", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("023f78c6-9f13-4d59-b7d0-bd1749a6e74f"), "Grønmo golfklubb description", "Grønmo golfklubb", false, 2870, 37 },
                    { new Guid("fd146759-1798-412c-8623-4a43cc602e89"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 36 }
                });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Date", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("a939cc14-c863-4db8-be78-cc7cf841fc1e"), new Guid("fd146759-1798-412c-8623-4a43cc602e89"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 33, new Guid("9e834078-741d-4269-995b-2db99ec755c4") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("0bc45d6b-2510-4694-ae39-6f3ee4b250ff"), new Guid("fd146759-1798-412c-8623-4a43cc602e89"), 4, 128, 3 },
                    { new Guid("18f1eefd-a516-466d-85d7-bcbc59fe3a50"), new Guid("023f78c6-9f13-4d59-b7d0-bd1749a6e74f"), 5, 127, 3 },
                    { new Guid("21199c16-a87f-4345-8993-56c4e6b9c048"), new Guid("fd146759-1798-412c-8623-4a43cc602e89"), 7, 270, 4 },
                    { new Guid("22d9d31d-fb2c-4841-9f11-146b1a45a799"), new Guid("fd146759-1798-412c-8623-4a43cc602e89"), 9, 330, 4 },
                    { new Guid("4cf25b13-5e7d-4a38-8609-e47641261100"), new Guid("023f78c6-9f13-4d59-b7d0-bd1749a6e74f"), 8, 141, 3 },
                    { new Guid("578586dd-3575-4167-aba3-391ba71ef231"), new Guid("023f78c6-9f13-4d59-b7d0-bd1749a6e74f"), 1, 494, 5 },
                    { new Guid("670c67bb-48c4-4d67-93a5-79a1f497a950"), new Guid("023f78c6-9f13-4d59-b7d0-bd1749a6e74f"), 4, 367, 4 },
                    { new Guid("6bcb531c-a00c-4d46-8c57-f19b0bb4c590"), new Guid("fd146759-1798-412c-8623-4a43cc602e89"), 5, 506, 5 },
                    { new Guid("709ae3b1-6a8e-4002-95ec-5da37368d67f"), new Guid("023f78c6-9f13-4d59-b7d0-bd1749a6e74f"), 7, 412, 5 },
                    { new Guid("76659040-b971-4f18-ba63-d93206e29f51"), new Guid("023f78c6-9f13-4d59-b7d0-bd1749a6e74f"), 2, 266, 5 },
                    { new Guid("91520dfd-b666-44cd-b24f-b9493ecdf68d"), new Guid("023f78c6-9f13-4d59-b7d0-bd1749a6e74f"), 3, 361, 4 },
                    { new Guid("96a02f1e-7e49-4f23-8f59-c95cd07e0ed1"), new Guid("fd146759-1798-412c-8623-4a43cc602e89"), 6, 227, 4 },
                    { new Guid("9edab717-4f8a-4b2f-ba58-54c2f28adc32"), new Guid("fd146759-1798-412c-8623-4a43cc602e89"), 2, 295, 4 },
                    { new Guid("a71f9827-79aa-4b7d-893b-783b5f815841"), new Guid("fd146759-1798-412c-8623-4a43cc602e89"), 3, 439, 5 },
                    { new Guid("cedc4646-8ec3-4d63-8592-da5a906bf1f0"), new Guid("023f78c6-9f13-4d59-b7d0-bd1749a6e74f"), 9, 365, 4 },
                    { new Guid("d5bd17dd-44c1-4351-81e2-c27fe0a8c54a"), new Guid("023f78c6-9f13-4d59-b7d0-bd1749a6e74f"), 6, 337, 4 },
                    { new Guid("e7728d79-0d6f-432b-a939-84598c366517"), new Guid("fd146759-1798-412c-8623-4a43cc602e89"), 8, 298, 4 },
                    { new Guid("f8d72b1f-f53e-4420-9d9f-cc8fa374b7cc"), new Guid("fd146759-1798-412c-8623-4a43cc602e89"), 1, 113, 3 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Par", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("297491b5-bd75-43ef-95e8-88b79cafbffa"), 3, 0, 2, new Guid("a939cc14-c863-4db8-be78-cc7cf841fc1e"), 3 },
                    { new Guid("3d3ec277-9d83-4ac9-bdf9-e38f0b5b5755"), 4, 0, 2, new Guid("a939cc14-c863-4db8-be78-cc7cf841fc1e"), 3 },
                    { new Guid("3ef753b3-60db-47d5-9de3-8a14866eb411"), 8, 0, 2, new Guid("a939cc14-c863-4db8-be78-cc7cf841fc1e"), 2 },
                    { new Guid("3f027657-0bde-4cbf-833c-b9d061a300ba"), 9, 0, 3, new Guid("a939cc14-c863-4db8-be78-cc7cf841fc1e"), 4 },
                    { new Guid("8c40f081-6373-44c6-9a03-c36e4ef672b2"), 1, 0, 2, new Guid("a939cc14-c863-4db8-be78-cc7cf841fc1e"), 2 },
                    { new Guid("a52e6283-7fc9-425d-9c9d-f63c12f5925d"), 7, 0, 2, new Guid("a939cc14-c863-4db8-be78-cc7cf841fc1e"), 5 },
                    { new Guid("e965b85b-14aa-4ba6-a106-9ae40d88576f"), 6, 0, 2, new Guid("a939cc14-c863-4db8-be78-cc7cf841fc1e"), 4 },
                    { new Guid("f6bc538e-5cb6-4f97-ae38-0ec68cdd91c4"), 5, 0, 1, new Guid("a939cc14-c863-4db8-be78-cc7cf841fc1e"), 4 },
                    { new Guid("fff23e10-798b-4416-b746-a5f3d822d5c2"), 2, 0, 2, new Guid("a939cc14-c863-4db8-be78-cc7cf841fc1e"), 6 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[,]
                {
                    { new Guid("2031bd3b-2884-4e12-b7ac-53a0c441e2ed"), new Guid("fd146759-1798-412c-8623-4a43cc602e89"), 52 },
                    { new Guid("295f5d13-6cb1-4df4-b62f-fec40bead64c"), new Guid("023f78c6-9f13-4d59-b7d0-bd1749a6e74f"), 57 }
                });
        }
    }
}
