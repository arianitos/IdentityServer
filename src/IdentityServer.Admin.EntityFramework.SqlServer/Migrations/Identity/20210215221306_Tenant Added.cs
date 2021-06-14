using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Admin.EntityFramework.SqlServer.Migrations.Identity
{
    public partial class TenantAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tenant",
                table: "UserTokens",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tenant",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tenant",
                table: "UserRoles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tenant",
                table: "UserLogins",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tenant",
                table: "UserClaims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tenant",
                table: "Roles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tenant",
                table: "RoleClaims",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tenant",
                table: "UserTokens");

            migrationBuilder.DropColumn(
                name: "Tenant",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Tenant",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "Tenant",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "Tenant",
                table: "UserClaims");

            migrationBuilder.DropColumn(
                name: "Tenant",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "Tenant",
                table: "RoleClaims");
        }
    }
}
