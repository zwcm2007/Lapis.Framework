using Microsoft.EntityFrameworkCore.Migrations;

namespace Laison.Lapis.Prepayment.Migrations
{
    public partial class third3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RechargeTradeDetail",
                table: "RechargeTradeDetail");

            migrationBuilder.RenameTable(
                name: "RechargeTradeDetail",
                newName: "RegisterTradeDetail");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegisterTradeDetail",
                table: "RegisterTradeDetail",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RegisterTradeDetail",
                table: "RegisterTradeDetail");

            migrationBuilder.RenameTable(
                name: "RegisterTradeDetail",
                newName: "RechargeTradeDetail");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RechargeTradeDetail",
                table: "RechargeTradeDetail",
                column: "Id");
        }
    }
}
