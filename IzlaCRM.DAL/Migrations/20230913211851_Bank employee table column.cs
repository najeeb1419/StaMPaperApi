using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IzlaCRM.DAL.Migrations
{
    public partial class Bankemployeetablecolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bankEmployeeReceipts_bankEmployees_BankeEmployeeId",
                table: "bankEmployeeReceipts");

            migrationBuilder.DropIndex(
                name: "IX_bankEmployeeReceipts_BankeEmployeeId",
                table: "bankEmployeeReceipts");

            migrationBuilder.DropColumn(
                name: "BankeEmployeeId",
                table: "bankEmployeeReceipts");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "bankEmployeeReceipts",
                newName: "BankemployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_bankEmployeeReceipts_BankemployeeId",
                table: "bankEmployeeReceipts",
                column: "BankemployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_bankEmployeeReceipts_bankEmployees_BankemployeeId",
                table: "bankEmployeeReceipts",
                column: "BankemployeeId",
                principalTable: "bankEmployees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bankEmployeeReceipts_bankEmployees_BankemployeeId",
                table: "bankEmployeeReceipts");

            migrationBuilder.DropIndex(
                name: "IX_bankEmployeeReceipts_BankemployeeId",
                table: "bankEmployeeReceipts");

            migrationBuilder.RenameColumn(
                name: "BankemployeeId",
                table: "bankEmployeeReceipts",
                newName: "MemberId");

            migrationBuilder.AddColumn<int>(
                name: "BankeEmployeeId",
                table: "bankEmployeeReceipts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_bankEmployeeReceipts_BankeEmployeeId",
                table: "bankEmployeeReceipts",
                column: "BankeEmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_bankEmployeeReceipts_bankEmployees_BankeEmployeeId",
                table: "bankEmployeeReceipts",
                column: "BankeEmployeeId",
                principalTable: "bankEmployees",
                principalColumn: "Id");
        }
    }
}
