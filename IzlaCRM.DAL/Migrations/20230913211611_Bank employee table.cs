using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IzlaCRM.DAL.Migrations
{
    public partial class Bankemployeetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bankEmployeeReceipts_bankEmployees_BankEmployeeId",
                table: "bankEmployeeReceipts");

            migrationBuilder.DropIndex(
                name: "IX_bankEmployeeReceipts_BankEmployeeId",
                table: "bankEmployeeReceipts");

            migrationBuilder.DropColumn(
                name: "PromisedDate",
                table: "bankEmployeeReceipts");

            migrationBuilder.RenameColumn(
                name: "BankEmployeeId",
                table: "bankEmployeeReceipts",
                newName: "MemberId");

            migrationBuilder.AddColumn<int>(
                name: "BankEmployeeReceiptId",
                table: "Payment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BankeEmployeeId",
                table: "bankEmployeeReceipts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "RemainingAmount",
                table: "bankEmployeeReceipts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Payment_BankEmployeeReceiptId",
                table: "Payment",
                column: "BankEmployeeReceiptId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_bankEmployeeReceipts_BankEmployeeReceiptId",
                table: "Payment",
                column: "BankEmployeeReceiptId",
                principalTable: "bankEmployeeReceipts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bankEmployeeReceipts_bankEmployees_BankeEmployeeId",
                table: "bankEmployeeReceipts");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_bankEmployeeReceipts_BankEmployeeReceiptId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_BankEmployeeReceiptId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_bankEmployeeReceipts_BankeEmployeeId",
                table: "bankEmployeeReceipts");

            migrationBuilder.DropColumn(
                name: "BankEmployeeReceiptId",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "BankeEmployeeId",
                table: "bankEmployeeReceipts");

            migrationBuilder.DropColumn(
                name: "RemainingAmount",
                table: "bankEmployeeReceipts");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "bankEmployeeReceipts",
                newName: "BankEmployeeId");

            migrationBuilder.AddColumn<DateTime>(
                name: "PromisedDate",
                table: "bankEmployeeReceipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_bankEmployeeReceipts_BankEmployeeId",
                table: "bankEmployeeReceipts",
                column: "BankEmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_bankEmployeeReceipts_bankEmployees_BankEmployeeId",
                table: "bankEmployeeReceipts",
                column: "BankEmployeeId",
                principalTable: "bankEmployees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
