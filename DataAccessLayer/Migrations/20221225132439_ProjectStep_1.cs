using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class ProjectStep_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MDY_Services",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vatrate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MDY_Services", x => x.ServiceId);
                });

            migrationBuilder.CreateTable(
                name: "MDY_UserTypes",
                columns: table => new
                {
                    UserTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MDY_UserTypes", x => x.UserTypeId);
                });

            migrationBuilder.CreateTable(
                name: "MDY_Invoices",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    FichenNo = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Vatrate = table.Column<int>(type: "int", nullable: false),
                    VatrateAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VatrateGeneralTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DocNumber = table.Column<int>(type: "int", nullable: false),
                    AdminTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MDY_Invoices", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_MDY_Invoices_MDY_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "MDY_Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MDY_Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErpCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MDY_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_MDY_Users_MDY_UserTypes_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "MDY_UserTypes",
                        principalColumn: "UserTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MDY_Invoices_ServiceId",
                table: "MDY_Invoices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_MDY_Users_UserTypeId",
                table: "MDY_Users",
                column: "UserTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MDY_Invoices");

            migrationBuilder.DropTable(
                name: "MDY_Users");

            migrationBuilder.DropTable(
                name: "MDY_Services");

            migrationBuilder.DropTable(
                name: "MDY_UserTypes");
        }
    }
}
