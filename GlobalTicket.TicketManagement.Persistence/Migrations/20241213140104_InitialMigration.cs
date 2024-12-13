using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                column: "EventDate",
                value: new DateTime(2025, 10, 13, 15, 1, 3, 727, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                column: "EventDate",
                value: new DateTime(2025, 9, 13, 15, 1, 3, 727, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                column: "EventDate",
                value: new DateTime(2025, 4, 13, 15, 1, 3, 727, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                column: "EventDate",
                value: new DateTime(2025, 8, 13, 15, 1, 3, 727, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                column: "EventDate",
                value: new DateTime(2025, 4, 13, 15, 1, 3, 727, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                column: "EventDate",
                value: new DateTime(2025, 6, 13, 15, 1, 3, 726, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                column: "OrderPlaced",
                value: new DateTime(2024, 12, 13, 15, 1, 3, 727, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                column: "OrderPlaced",
                value: new DateTime(2024, 12, 13, 15, 1, 3, 727, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                column: "OrderPlaced",
                value: new DateTime(2024, 12, 13, 15, 1, 3, 727, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                column: "OrderPlaced",
                value: new DateTime(2024, 12, 13, 15, 1, 3, 727, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                column: "OrderPlaced",
                value: new DateTime(2024, 12, 13, 15, 1, 3, 727, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                column: "OrderPlaced",
                value: new DateTime(2024, 12, 13, 15, 1, 3, 727, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                column: "OrderPlaced",
                value: new DateTime(2024, 12, 13, 15, 1, 3, 727, DateTimeKind.Local).AddTicks(8707));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                column: "EventDate",
                value: new DateTime(2025, 10, 13, 15, 0, 32, 9, DateTimeKind.Local).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                column: "EventDate",
                value: new DateTime(2025, 9, 13, 15, 0, 32, 9, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                column: "EventDate",
                value: new DateTime(2025, 4, 13, 15, 0, 32, 9, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                column: "EventDate",
                value: new DateTime(2025, 8, 13, 15, 0, 32, 9, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                column: "EventDate",
                value: new DateTime(2025, 4, 13, 15, 0, 32, 9, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                column: "EventDate",
                value: new DateTime(2025, 6, 13, 15, 0, 32, 8, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                column: "OrderPlaced",
                value: new DateTime(2024, 12, 13, 15, 0, 32, 9, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                column: "OrderPlaced",
                value: new DateTime(2024, 12, 13, 15, 0, 32, 9, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                column: "OrderPlaced",
                value: new DateTime(2024, 12, 13, 15, 0, 32, 9, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                column: "OrderPlaced",
                value: new DateTime(2024, 12, 13, 15, 0, 32, 9, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                column: "OrderPlaced",
                value: new DateTime(2024, 12, 13, 15, 0, 32, 9, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                column: "OrderPlaced",
                value: new DateTime(2024, 12, 13, 15, 0, 32, 9, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                column: "OrderPlaced",
                value: new DateTime(2024, 12, 13, 15, 0, 32, 9, DateTimeKind.Local).AddTicks(8583));
        }
    }
}
