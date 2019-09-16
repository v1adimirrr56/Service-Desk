using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceDesk.Context.Incidents.Migrations
{
    public partial class IncidentJob90 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Branch_BranchId",
                table: "Incidents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Branch",
                table: "Branch");

            migrationBuilder.DropColumn(
                name: "Archive",
                table: "Incidents");

            migrationBuilder.RenameTable(
                name: "Branch",
                newName: "Brabches");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Incidents",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "ContactEmail",
                table: "Incidents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPhone",
                table: "Incidents",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brabches",
                table: "Brabches",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Priorities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PriorityType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priorities", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Brabches_BranchId",
                table: "Incidents",
                column: "BranchId",
                principalTable: "Brabches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Brabches_BranchId",
                table: "Incidents");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "Priorities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brabches",
                table: "Brabches");

            migrationBuilder.DropColumn(
                name: "ContactEmail",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "ContactPhone",
                table: "Incidents");

            migrationBuilder.RenameTable(
                name: "Brabches",
                newName: "Branch");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Incidents",
                newName: "Name");

            migrationBuilder.AddColumn<bool>(
                name: "Archive",
                table: "Incidents",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Branch",
                table: "Branch",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Branch_BranchId",
                table: "Incidents",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
