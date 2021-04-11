using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Laison.Lapis.Prepayment.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    IdentityNo = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Telephone = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Email = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Address_Province = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Address_City = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Address_Town = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Address_Village = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Remark = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ExtraProperties = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40) CHARACTER SET utf8mb4", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recharge_Trade_Detail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    ExtraProperties = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40) CHARACTER SET utf8mb4", maxLength: 40, nullable: true),
                    CustomerId = table.Column<Guid>(type: "char(36)", nullable: false),
                    OperatorId = table.Column<Guid>(type: "char(36)", nullable: false),
                    InvoiceNo = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recharge_Trade_Detail", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    No = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Debt = table.Column<double>(type: "double", nullable: false),
                    MakeCard = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExtraProperties = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40) CHARACTER SET utf8mb4", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_Customer_Id",
                        column: x => x.Id,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Recharge_Trade_Detail");

            migrationBuilder.DropTable(
                name: "Register_Trade_Detail");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
