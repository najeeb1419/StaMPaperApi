using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IzlaCRM.DAL.Migrations
{
    public partial class addbankEmployeepayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bankEmployeeReceipts_bankEmployees_BankemployeeId",
                table: "bankEmployeeReceipts");

            migrationBuilder.DropForeignKey(
                name: "FK_bankEmployeeReceipts_LookUps_LookUpId",
                table: "bankEmployeeReceipts");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_bankEmployeeReceipts_BankEmployeeReceiptId",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bankEmployeeReceipts",
                table: "bankEmployeeReceipts");

            migrationBuilder.RenameTable(
                name: "bankEmployeeReceipts",
                newName: "BankEmployeeReceipt");

            migrationBuilder.RenameIndex(
                name: "IX_bankEmployeeReceipts_LookUpId",
                table: "BankEmployeeReceipt",
                newName: "IX_BankEmployeeReceipt_LookUpId");

            migrationBuilder.RenameIndex(
                name: "IX_bankEmployeeReceipts_BankemployeeId",
                table: "BankEmployeeReceipt",
                newName: "IX_BankEmployeeReceipt_BankemployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BankEmployeeReceipt",
                table: "BankEmployeeReceipt",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BankEmployeeReceipt_bankEmployees_BankemployeeId",
                table: "BankEmployeeReceipt",
                column: "BankemployeeId",
                principalTable: "bankEmployees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BankEmployeeReceipt_LookUps_LookUpId",
                table: "BankEmployeeReceipt",
                column: "LookUpId",
                principalTable: "LookUps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_BankEmployeeReceipt_BankEmployeeReceiptId",
                table: "Payment",
                column: "BankEmployeeReceiptId",
                principalTable: "BankEmployeeReceipt",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankEmployeeReceipt_bankEmployees_BankemployeeId",
                table: "BankEmployeeReceipt");

            migrationBuilder.DropForeignKey(
                name: "FK_BankEmployeeReceipt_LookUps_LookUpId",
                table: "BankEmployeeReceipt");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_BankEmployeeReceipt_BankEmployeeReceiptId",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BankEmployeeReceipt",
                table: "BankEmployeeReceipt");

            migrationBuilder.RenameTable(
                name: "BankEmployeeReceipt",
                newName: "bankEmployeeReceipts");

            migrationBuilder.RenameIndex(
                name: "IX_BankEmployeeReceipt_LookUpId",
                table: "bankEmployeeReceipts",
                newName: "IX_bankEmployeeReceipts_LookUpId");

            migrationBuilder.RenameIndex(
                name: "IX_BankEmployeeReceipt_BankemployeeId",
                table: "bankEmployeeReceipts",
                newName: "IX_bankEmployeeReceipts_BankemployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bankEmployeeReceipts",
                table: "bankEmployeeReceipts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_bankEmployeeReceipts_bankEmployees_BankemployeeId",
                table: "bankEmployeeReceipts",
                column: "BankemployeeId",
                principalTable: "bankEmployees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bankEmployeeReceipts_LookUps_LookUpId",
                table: "bankEmployeeReceipts",
                column: "LookUpId",
                principalTable: "LookUps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_bankEmployeeReceipts_BankEmployeeReceiptId",
                table: "Payment",
                column: "BankEmployeeReceiptId",
                principalTable: "bankEmployeeReceipts",
                principalColumn: "Id");
        }
    }
}
