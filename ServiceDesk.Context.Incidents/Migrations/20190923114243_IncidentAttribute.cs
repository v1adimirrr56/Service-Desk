using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceDesk.Context.Incidents.Migrations
{
    public partial class IncidentAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Incidents",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactEmail",
                table: "Incidents",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "PassVendorDate", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 23, 11, 42, 43, 369, DateTimeKind.Utc).AddTicks(6592), new DateTime(2019, 10, 25, 11, 42, 43, 369, DateTimeKind.Utc).AddTicks(8273), new DateTime(2019, 10, 3, 11, 42, 43, 370, DateTimeKind.Utc).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "PassVendorDate", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 23, 11, 42, 43, 370, DateTimeKind.Utc).AddTicks(2921), new DateTime(2019, 10, 16, 11, 42, 43, 370, DateTimeKind.Utc).AddTicks(2931), new DateTime(2019, 10, 9, 11, 42, 43, 370, DateTimeKind.Utc).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "PassVendorDate", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 23, 11, 42, 43, 370, DateTimeKind.Utc).AddTicks(2965), new DateTime(2019, 11, 22, 11, 42, 43, 370, DateTimeKind.Utc).AddTicks(2966), new DateTime(2019, 9, 25, 11, 42, 43, 370, DateTimeKind.Utc).AddTicks(2967) });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "Id", "CityId", "ContactEmail", "ContactPhone", "CreateDate", "CreatorName", "ImpactId", "IsComposite", "ManagerId", "PassVendorDate", "PhaseId", "PlanDateResolve", "PriorityId", "Rate", "ShareType", "StateId", "StatusId", "Title", "UseNotification" },
                values: new object[] { 4L, 1L, "hiram-mackenzie9@example.com", "+1(137)-691-2995", new DateTime(2019, 9, 23, 11, 42, 43, 370, DateTimeKind.Utc).AddTicks(2968), "Hiram Mackenzie", 1L, true, 1L, new DateTime(2019, 9, 25, 11, 42, 43, 370, DateTimeKind.Utc).AddTicks(2971), 1L, new DateTime(2019, 10, 1, 11, 42, 43, 370, DateTimeKind.Utc).AddTicks(2972), 1L, 5.0, 0, 1L, 1L, "The Evitable Conflict: The Northern Region", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Incidents",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ContactEmail",
                table: "Incidents",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "PassVendorDate", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 20, 21, 35, 32, 305, DateTimeKind.Local).AddTicks(9771), new DateTime(2019, 10, 22, 21, 35, 32, 307, DateTimeKind.Local).AddTicks(714), new DateTime(2019, 9, 30, 21, 35, 32, 307, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "PassVendorDate", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 20, 21, 35, 32, 307, DateTimeKind.Local).AddTicks(5736), new DateTime(2019, 10, 13, 21, 35, 32, 307, DateTimeKind.Local).AddTicks(5747), new DateTime(2019, 10, 6, 21, 35, 32, 307, DateTimeKind.Local).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "PassVendorDate", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 20, 21, 35, 32, 307, DateTimeKind.Local).AddTicks(5782), new DateTime(2019, 11, 19, 21, 35, 32, 307, DateTimeKind.Local).AddTicks(5783), new DateTime(2019, 9, 22, 21, 35, 32, 307, DateTimeKind.Local).AddTicks(5784) });
        }
    }
}
