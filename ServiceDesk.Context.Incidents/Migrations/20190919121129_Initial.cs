using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceDesk.Context.Incidents.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Impact",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phase",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Priority",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PriorityType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priority", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    StateId = table.Column<long>(nullable: false),
                    PhaseId = table.Column<long>(nullable: false),
                    StatusId = table.Column<long>(nullable: false),
                    ImpactId = table.Column<long>(nullable: false),
                    ManagerId = table.Column<long>(nullable: false),
                    PlanDateResolve = table.Column<DateTime>(nullable: false),
                    ShareType = table.Column<int>(nullable: false),
                    NotificationType = table.Column<int>(nullable: false),
                    ContactEmail = table.Column<string>(nullable: true),
                    PriorityId = table.Column<long>(nullable: false),
                    CityId = table.Column<long>(nullable: false),
                    ContactPhone = table.Column<string>(nullable: true),
                    CreatorName = table.Column<string>(nullable: true),
                    Rate = table.Column<double>(nullable: false, defaultValue: 1.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incidents_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Impact_ImpactId",
                        column: x => x.ImpactId,
                        principalTable: "Impact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Manager_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Manager",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Phase_PhaseId",
                        column: x => x.PhaseId,
                        principalTable: "Phase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Priority_PriorityId",
                        column: x => x.PriorityId,
                        principalTable: "Priority",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "New York" },
                    { 8L, "Columbus" },
                    { 7L, "Jacksonville" },
                    { 6L, "Philadelphia" },
                    { 9L, "Seattle" },
                    { 4L, "Houston" },
                    { 3L, "Chicago" },
                    { 2L, "Los Angeles" },
                    { 5L, "Phoenix" }
                });

            migrationBuilder.InsertData(
                table: "Impact",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Single" },
                    { 2L, "Group" },
                    { 3L, "Mass" }
                });

            migrationBuilder.InsertData(
                table: "Manager",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 4L, "barry.frazier29@example.com", "Barry", "Frazier" },
                    { 1L, "linda.armstrong76@example.com", "Linda", "Armstrong" },
                    { 2L, "dylan.cole27@example.com", "Dylan", "Cole" },
                    { 3L, "travis.murphy20@example.com", "Travis", "Murphy" }
                });

            migrationBuilder.InsertData(
                table: "Phase",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3L, "Resolving" },
                    { 4L, "Closed" },
                    { 1L, "Registration" },
                    { 2L, "In working" }
                });

            migrationBuilder.InsertData(
                table: "Priority",
                columns: new[] { "Id", "PriorityType" },
                values: new object[,]
                {
                    { 1L, "None" },
                    { 2L, "Normal" },
                    { 3L, "Major" },
                    { 4L, "Critical" }
                });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 9L, "Washington" },
                    { 8L, "Ohio" },
                    { 7L, "Florida" },
                    { 6L, "Pennsylvania" },
                    { 5L, "Arizona" },
                    { 3L, "Illinois" },
                    { 2L, "California" },
                    { 1L, "New York" },
                    { 4L, "Texas" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5L, "Resolve" },
                    { 1L, "Open" },
                    { 2L, "In work" },
                    { 3L, "Pass vendor" },
                    { 4L, "Hold" },
                    { 6L, "Closed" }
                });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "Id", "CityId", "ContactEmail", "ContactPhone", "CreateDate", "CreatorName", "ImpactId", "ManagerId", "NotificationType", "PhaseId", "PlanDateResolve", "PriorityId", "Rate", "ShareType", "StateId", "StatusId", "Title" },
                values: new object[] { 1L, 1L, "ching.hso-lin89@example.com", "+1(137)-691-2995", new DateTime(2019, 9, 19, 15, 11, 29, 139, DateTimeKind.Local).AddTicks(422), "Ching Hso-lin", 1L, 1L, 1, 1L, new DateTime(2019, 9, 29, 15, 11, 29, 139, DateTimeKind.Local).AddTicks(8648), 1L, 5.0, 0, 1L, 1L, "The Evitable Conflict: The Eastern Region" });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "Id", "CityId", "ContactEmail", "ContactPhone", "CreateDate", "CreatorName", "ImpactId", "ManagerId", "NotificationType", "PhaseId", "PlanDateResolve", "PriorityId", "Rate", "ShareType", "StateId", "StatusId", "Title" },
                values: new object[] { 2L, 2L, "ngoma42@example.com", "+1(137)-691-2995", new DateTime(2019, 9, 19, 15, 11, 29, 140, DateTimeKind.Local).AddTicks(1043), "Ngoma", 2L, 2L, 3, 2L, new DateTime(2019, 10, 5, 15, 11, 29, 140, DateTimeKind.Local).AddTicks(1066), 2L, 7.0, 1, 2L, 2L, "The Evitable Conflict: The Tropic Region" });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "Id", "CityId", "ContactEmail", "ContactPhone", "CreateDate", "CreatorName", "ImpactId", "ManagerId", "NotificationType", "PhaseId", "PlanDateResolve", "PriorityId", "Rate", "ShareType", "StateId", "StatusId", "Title" },
                values: new object[] { 3L, 3L, "szegeczowska90@example.com", "+1(137)-691-2995", new DateTime(2019, 9, 19, 15, 11, 29, 140, DateTimeKind.Local).AddTicks(1213), "Szegeczowska", 3L, 3L, 1, 3L, new DateTime(2019, 9, 21, 15, 11, 29, 140, DateTimeKind.Local).AddTicks(1215), 3L, 2.0, 0, 3L, 3L, "The Evitable Conflict: The European Region" });

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_CityId",
                table: "Incidents",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ImpactId",
                table: "Incidents",
                column: "ImpactId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ManagerId",
                table: "Incidents",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_PhaseId",
                table: "Incidents",
                column: "PhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_PriorityId",
                table: "Incidents",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_StateId",
                table: "Incidents",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_StatusId",
                table: "Incidents",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Job_IncidentId",
                table: "Job",
                column: "IncidentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Impact");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "Phase");

            migrationBuilder.DropTable(
                name: "Priority");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
