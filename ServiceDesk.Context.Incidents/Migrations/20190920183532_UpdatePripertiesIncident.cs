using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceDesk.Context.Incidents.Migrations
{
    public partial class UpdatePripertiesIncident : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotificationType",
                table: "Incidents");

            migrationBuilder.AddColumn<bool>(
                name: "IsComposite",
                table: "Incidents",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "PassVendorDate",
                table: "Incidents",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "UseNotification",
                table: "Incidents",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "IsComposite", "PassVendorDate", "PlanDateResolve", "UseNotification" },
                values: new object[] { new DateTime(2019, 9, 20, 21, 35, 32, 305, DateTimeKind.Local).AddTicks(9771), true, new DateTime(2019, 10, 22, 21, 35, 32, 307, DateTimeKind.Local).AddTicks(714), new DateTime(2019, 9, 30, 21, 35, 32, 307, DateTimeKind.Local).AddTicks(3298), true });

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
                columns: new[] { "CreateDate", "PassVendorDate", "PlanDateResolve", "UseNotification" },
                values: new object[] { new DateTime(2019, 9, 20, 21, 35, 32, 307, DateTimeKind.Local).AddTicks(5782), new DateTime(2019, 11, 19, 21, 35, 32, 307, DateTimeKind.Local).AddTicks(5783), new DateTime(2019, 9, 22, 21, 35, 32, 307, DateTimeKind.Local).AddTicks(5784), true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsComposite",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "PassVendorDate",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "UseNotification",
                table: "Incidents");

            migrationBuilder.AddColumn<int>(
                name: "NotificationType",
                table: "Incidents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "NotificationType", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 19, 15, 11, 29, 139, DateTimeKind.Local).AddTicks(422), 1, new DateTime(2019, 9, 29, 15, 11, 29, 139, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "NotificationType", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 19, 15, 11, 29, 140, DateTimeKind.Local).AddTicks(1043), 3, new DateTime(2019, 10, 5, 15, 11, 29, 140, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "NotificationType", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 19, 15, 11, 29, 140, DateTimeKind.Local).AddTicks(1213), 1, new DateTime(2019, 9, 21, 15, 11, 29, 140, DateTimeKind.Local).AddTicks(1215) });
        }
    }
}
