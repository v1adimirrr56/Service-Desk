using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceDesk.Context.Incidents.Migrations
{
    public partial class DefaultIncidentUTC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Incidents",
                nullable: false,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Incidents",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "PassVendorDate", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 23, 13, 42, 22, 244, DateTimeKind.Utc).AddTicks(9196), new DateTime(2019, 10, 25, 13, 42, 22, 245, DateTimeKind.Utc).AddTicks(1374), new DateTime(2019, 10, 3, 13, 42, 22, 245, DateTimeKind.Utc).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "PassVendorDate", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 23, 13, 42, 22, 245, DateTimeKind.Utc).AddTicks(7674), new DateTime(2019, 10, 16, 13, 42, 22, 245, DateTimeKind.Utc).AddTicks(7690), new DateTime(2019, 10, 9, 13, 42, 22, 245, DateTimeKind.Utc).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "PassVendorDate", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 23, 13, 42, 22, 245, DateTimeKind.Utc).AddTicks(7749), new DateTime(2019, 11, 22, 13, 42, 22, 245, DateTimeKind.Utc).AddTicks(7750), new DateTime(2019, 9, 25, 13, 42, 22, 245, DateTimeKind.Utc).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "PassVendorDate", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 23, 13, 42, 22, 245, DateTimeKind.Utc).AddTicks(7753), new DateTime(2019, 9, 25, 13, 42, 22, 245, DateTimeKind.Utc).AddTicks(7759), new DateTime(2019, 10, 1, 13, 42, 22, 245, DateTimeKind.Utc).AddTicks(7760) });
        }
    }
}
