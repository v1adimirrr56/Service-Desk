using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceDesk.Context.Incidents.Migrations
{
    public partial class StateCityRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StateCityRelations",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StateId = table.Column<long>(nullable: false),
                    CityId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateCityRelations", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "StateCityRelations",
                columns: new[] { "Id", "CityId", "StateId" },
                values: new object[,]
                {
                    { 1L, 1L, 1L },
                    { 2L, 2L, 2L },
                    { 3L, 3L, 3L },
                    { 4L, 4L, 4L },
                    { 5L, 5L, 5L },
                    { 6L, 6L, 6L },
                    { 7L, 7L, 7L },
                    { 8L, 8L, 8L },
                    { 9L, 9L, 9L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StateCityRelations");

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

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "PassVendorDate", "PlanDateResolve" },
                values: new object[] { new DateTime(2019, 9, 23, 11, 42, 43, 370, DateTimeKind.Utc).AddTicks(2968), new DateTime(2019, 9, 25, 11, 42, 43, 370, DateTimeKind.Utc).AddTicks(2971), new DateTime(2019, 10, 1, 11, 42, 43, 370, DateTimeKind.Utc).AddTicks(2972) });
        }
    }
}
