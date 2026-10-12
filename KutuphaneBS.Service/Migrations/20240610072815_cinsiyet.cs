using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KutuphaneBS.Service.Migrations
{
    /// <inheritdoc />
    public partial class cinsiyet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cinsiyet",
                table: "Uyeler",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cinsiyet",
                table: "Uyeler");
        }
    }
}
