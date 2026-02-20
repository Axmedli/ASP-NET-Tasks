using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_NET_20._TaskFlow_FIle_attachment.Migrations
{
    /// <inheritdoc />
    public partial class AddProjectIsApproved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Projects",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Projects");
        }
    }
}
