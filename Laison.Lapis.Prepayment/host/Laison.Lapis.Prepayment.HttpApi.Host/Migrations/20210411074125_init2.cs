using Microsoft.EntityFrameworkCore.Migrations;

namespace Laison.Lapis.Prepayment.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Register_Trade_Detail",
                table: "Register_Trade_Detail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recharge_Trade_Detail",
                table: "Recharge_Trade_Detail");

            migrationBuilder.RenameTable(
                name: "Register_Trade_Detail",
                newName: "register_trade_detail");

            migrationBuilder.RenameTable(
                name: "Recharge_Trade_Detail",
                newName: "recharge_trade_detail");

            migrationBuilder.RenameColumn(
                name: "OpenAccountCharge",
                table: "register_trade_detail",
                newName: "RegisterCharge");

            migrationBuilder.AddPrimaryKey(
                name: "PK_register_trade_detail",
                table: "register_trade_detail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_recharge_trade_detail",
                table: "recharge_trade_detail",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_register_trade_detail",
                table: "register_trade_detail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_recharge_trade_detail",
                table: "recharge_trade_detail");

            migrationBuilder.RenameTable(
                name: "register_trade_detail",
                newName: "Register_Trade_Detail");

            migrationBuilder.RenameTable(
                name: "recharge_trade_detail",
                newName: "Recharge_Trade_Detail");

            migrationBuilder.RenameColumn(
                name: "RegisterCharge",
                table: "Register_Trade_Detail",
                newName: "OpenAccountCharge");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Register_Trade_Detail",
                table: "Register_Trade_Detail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recharge_Trade_Detail",
                table: "Recharge_Trade_Detail",
                column: "Id");
        }
    }
}
