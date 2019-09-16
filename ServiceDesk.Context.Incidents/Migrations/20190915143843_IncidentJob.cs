using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceDesk.Context.Incidents.Migrations
{
    public partial class IncidentJob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Branch",
                table: "Incidents");

            migrationBuilder.AddColumn<long>(
                name: "BranchId",
                table: "Incidents",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Incidents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameBranch = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JobTitle = table.Column<string>(nullable: true),
                    IncidentId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Job_Incidents_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incidents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_BranchId",
                table: "Incidents",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Job_IncidentId",
                table: "Job",
                column: "IncidentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Branch_BranchId",
                table: "Incidents",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Branch_BranchId",
                table: "Incidents");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Incidents_BranchId",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Incidents");

            migrationBuilder.AddColumn<string>(
                name: "Branch",
                table: "Incidents",
                nullable: false,
                defaultValue: "");
        }
    }
}
