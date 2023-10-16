using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IzlaCRM.DAL.Migrations
{
    public partial class addBankEmployeePaymenttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankEmployeePayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    BankEmployeeReceiptId = table.Column<int>(type: "int", nullable: false),
                    SendingAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankEmployeePayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankEmployeePayments_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BankEmployeePayments_BankEmployeeReceipt_BankEmployeeReceiptId",
                        column: x => x.BankEmployeeReceiptId,
                        principalTable: "BankEmployeeReceipt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankEmployeePayments_AccountId",
                table: "BankEmployeePayments",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_BankEmployeePayments_BankEmployeeReceiptId",
                table: "BankEmployeePayments",
                column: "BankEmployeeReceiptId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankEmployeePayments");
        }
    }
}
