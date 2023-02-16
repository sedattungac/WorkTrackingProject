using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class TableInvoiceUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VatrateGeneralTotal",
                table: "MDY_Invoices",
                newName: "VatAmount");

            migrationBuilder.RenameColumn(
                name: "VatrateAmount",
                table: "MDY_Invoices",
                newName: "GeneralTotal");

            migrationBuilder.RenameColumn(
                name: "FichenNo",
                table: "MDY_Invoices",
                newName: "FicheNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VatAmount",
                table: "MDY_Invoices",
                newName: "VatrateGeneralTotal");

            migrationBuilder.RenameColumn(
                name: "GeneralTotal",
                table: "MDY_Invoices",
                newName: "VatrateAmount");

            migrationBuilder.RenameColumn(
                name: "FicheNo",
                table: "MDY_Invoices",
                newName: "FichenNo");
        }
    }
}
