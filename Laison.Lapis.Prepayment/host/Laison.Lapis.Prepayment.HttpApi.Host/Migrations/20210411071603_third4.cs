using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Laison.Lapis.Prepayment.Migrations
{
    public partial class third4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RegisterTradeDetail",
                table: "RegisterTradeDetail");

            migrationBuilder.RenameTable(
                name: "RegisterTradeDetail",
                newName: "Recharge_Trade_Detail");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recharge_Trade_Detail",
                table: "Recharge_Trade_Detail",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Register_Trade_Detail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    OpenAccountCharge = table.Column<double>(type: "double", nullable: false),
                    ExtraProperties = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40) CHARACTER SET utf8mb4", maxLength: 40, nullable: true),
                    CustomerId = table.Column<Guid>(type: "char(36)", nullable: false),
                    OperatorId = table.Column<Guid>(type: "char(36)", nullable: false),
                    InvoiceNo = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Register_Trade_Detail", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Register_Trade_Detail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recharge_Trade_Detail",
                table: "Recharge_Trade_Detail");

            migrationBuilder.RenameTable(
                name: "Recharge_Trade_Detail",
                newName: "RegisterTradeDetail");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegisterTradeDetail",
                table: "RegisterTradeDetail",
                column: "Id");
        }
    }
}
