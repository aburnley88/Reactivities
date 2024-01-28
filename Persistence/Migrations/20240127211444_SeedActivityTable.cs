using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedActivityTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("34d37a6b-8fae-4d76-bfd2-55aa45680241"), "Festive", "Atlanta", new DateTime(2023, 11, 27, 21, 14, 43, 316, DateTimeKind.Utc).AddTicks(6959), "Activity 2, 2 months ago", "Past Activity 2", "YSL HQ" },
                    { new Guid("5d16d4a0-21b6-44ac-afe0-bc7e65e22bc3"), "Dating", "Tampa", new DateTime(2024, 3, 27, 21, 14, 43, 316, DateTimeKind.Utc).AddTicks(6950), "Activity 1, 2 months in the future", "Future Activity 1", "Armiturworks" },
                    { new Guid("630e212d-7c6d-4599-b1f7-f390afd1e60d"), "Social", "Shirlington", new DateTime(2024, 3, 27, 21, 14, 43, 316, DateTimeKind.Utc).AddTicks(6984), "Activity 2, 2 months in future", "Future Activity 2", "Pallette22" },
                    { new Guid("7154fdcf-6670-48d7-a588-cc29a986eb51"), "Drinks", "Washington D.C.", new DateTime(2023, 10, 27, 21, 14, 43, 316, DateTimeKind.Utc).AddTicks(6927), "Activity 3 months ago", "Past Activity 1", "U st" },
                    { new Guid("9dc301c9-a87c-4081-a68a-d2a91a3d7d74"), "Social", "Arlington", new DateTime(2024, 1, 29, 21, 14, 43, 316, DateTimeKind.Utc).AddTicks(7002), "Activity 4, 2 days in future", "Future Activity 4", "UpaDidi" },
                    { new Guid("b2506493-1861-4c9a-9985-dc8296f84d83"), "Sports", "San Diego", new DateTime(2024, 5, 27, 21, 14, 43, 316, DateTimeKind.Utc).AddTicks(6991), "Activity 3, 4 months in future", "Future Activity 3", "Aztecs Stadium" },
                    { new Guid("f872ea99-c733-4f57-9caf-df229624be40"), "Dating", "Los Angeles", new DateTime(2023, 8, 27, 21, 14, 43, 316, DateTimeKind.Utc).AddTicks(6997), "Activity 2, 5 months ago", "Past Activity 3", "Staples Center" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("34d37a6b-8fae-4d76-bfd2-55aa45680241"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("5d16d4a0-21b6-44ac-afe0-bc7e65e22bc3"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("630e212d-7c6d-4599-b1f7-f390afd1e60d"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("7154fdcf-6670-48d7-a588-cc29a986eb51"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("9dc301c9-a87c-4081-a68a-d2a91a3d7d74"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b2506493-1861-4c9a-9985-dc8296f84d83"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("f872ea99-c733-4f57-9caf-df229624be40"));
        }
    }
}
