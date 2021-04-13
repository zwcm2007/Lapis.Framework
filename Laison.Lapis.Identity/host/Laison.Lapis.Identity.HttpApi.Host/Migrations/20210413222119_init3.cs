using Microsoft.EntityFrameworkCore.Migrations;

namespace Laison.Lapis.Identity.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationRole_Organization_OrganizationId",
                table: "OrganizationRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserOrganization_User_OrganizationId",
                table: "UserOrganization");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Organization",
                table: "Organization");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserOrganization",
                table: "UserOrganization");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrganizationRole",
                table: "OrganizationRole");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "user");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "role");

            migrationBuilder.RenameTable(
                name: "Organization",
                newName: "organization");

            migrationBuilder.RenameTable(
                name: "UserRole",
                newName: "user_role");

            migrationBuilder.RenameTable(
                name: "UserOrganization",
                newName: "user_organization");

            migrationBuilder.RenameTable(
                name: "OrganizationRole",
                newName: "organization_role");

            migrationBuilder.RenameIndex(
                name: "IX_UserOrganization_OrganizationId",
                table: "user_organization",
                newName: "IX_user_organization_OrganizationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_role",
                table: "role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_organization",
                table: "organization",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_role",
                table: "user_role",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_organization",
                table: "user_organization",
                columns: new[] { "UserId", "OrganizationId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_organization_role",
                table: "organization_role",
                columns: new[] { "OrganizationId", "RoleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_organization_role_organization_OrganizationId",
                table: "organization_role",
                column: "OrganizationId",
                principalTable: "organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_organization_user_OrganizationId",
                table: "user_organization",
                column: "OrganizationId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_role_user_UserId",
                table: "user_role",
                column: "UserId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_organization_role_organization_OrganizationId",
                table: "organization_role");

            migrationBuilder.DropForeignKey(
                name: "FK_user_organization_user_OrganizationId",
                table: "user_organization");

            migrationBuilder.DropForeignKey(
                name: "FK_user_role_user_UserId",
                table: "user_role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_role",
                table: "role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_organization",
                table: "organization");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_role",
                table: "user_role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_organization",
                table: "user_organization");

            migrationBuilder.DropPrimaryKey(
                name: "PK_organization_role",
                table: "organization_role");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "role",
                newName: "Role");

            migrationBuilder.RenameTable(
                name: "organization",
                newName: "Organization");

            migrationBuilder.RenameTable(
                name: "user_role",
                newName: "UserRole");

            migrationBuilder.RenameTable(
                name: "user_organization",
                newName: "UserOrganization");

            migrationBuilder.RenameTable(
                name: "organization_role",
                newName: "OrganizationRole");

            migrationBuilder.RenameIndex(
                name: "IX_user_organization_OrganizationId",
                table: "UserOrganization",
                newName: "IX_UserOrganization_OrganizationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Organization",
                table: "Organization",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserOrganization",
                table: "UserOrganization",
                columns: new[] { "UserId", "OrganizationId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrganizationRole",
                table: "OrganizationRole",
                columns: new[] { "OrganizationId", "RoleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationRole_Organization_OrganizationId",
                table: "OrganizationRole",
                column: "OrganizationId",
                principalTable: "Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrganization_User_OrganizationId",
                table: "UserOrganization",
                column: "OrganizationId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
