using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceDesk.Context.Incidents.Migrations
{
    public partial class DefaultIncidentPassVendorNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "UseNotification",
                table: "Incidents",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassVendorDate",
                table: "Incidents",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "IsComposite",
                table: "Incidents",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "PassVendorDate", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 24, 7, 33, 26, 748, DateTimeKind.Utc).AddTicks(4326), new DateTime(2019, 10, 26, 7, 33, 26, 748, DateTimeKind.Utc).AddTicks(5930), new DateTime(2019, 10, 4, 7, 33, 26, 748, DateTimeKind.Utc).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "PassVendorDate", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 24, 7, 33, 26, 749, DateTimeKind.Utc).AddTicks(763), new DateTime(2019, 10, 17, 7, 33, 26, 749, DateTimeKind.Utc).AddTicks(772), new DateTime(2019, 10, 10, 7, 33, 26, 749, DateTimeKind.Utc).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "PassVendorDate", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 24, 7, 33, 26, 749, DateTimeKind.Utc).AddTicks(806), new DateTime(2019, 11, 23, 7, 33, 26, 749, DateTimeKind.Utc).AddTicks(807), new DateTime(2019, 9, 26, 7, 33, 26, 749, DateTimeKind.Utc).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "PassVendorDate", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 24, 7, 33, 26, 749, DateTimeKind.Utc).AddTicks(809), new DateTime(2019, 9, 26, 7, 33, 26, 749, DateTimeKind.Utc).AddTicks(812), new DateTime(2019, 10, 2, 7, 33, 26, 749, DateTimeKind.Utc).AddTicks(813) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "UseNotification",
                table: "Incidents",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassVendorDate",
                table: "Incidents",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsComposite",
                table: "Incidents",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "PassVendorDate", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 24, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(426), new DateTime(2019, 10, 26, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(2171), new DateTime(2019, 10, 4, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "PassVendorDate", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 24, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(7343), new DateTime(2019, 10, 17, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(7353), new DateTime(2019, 10, 10, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "PassVendorDate", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 24, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(7390), new DateTime(2019, 11, 23, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(7390), new DateTime(2019, 9, 26, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "PassVendorDate", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 24, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(7393), new DateTime(2019, 9, 26, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(7396), new DateTime(2019, 10, 2, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(7398) });
        }
    }
}
