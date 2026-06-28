using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreelancerHub.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Payments");

            migrationBuilder.RenameColumn(
                name: "bidAmount",
                table: "Proposals",
                newName: "BidAmount");

            migrationBuilder.RenameColumn(
                name: "FriendId",
                table: "Proposals",
                newName: "FreelancerId");

            migrationBuilder.RenameColumn(
                name: "PaymentDate",
                table: "Projects",
                newName: "Deadline");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Projects",
                newName: "Budget");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentId",
                table: "Payments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "PaymentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "BidAmount",
                table: "Proposals",
                newName: "bidAmount");

            migrationBuilder.RenameColumn(
                name: "FreelancerId",
                table: "Proposals",
                newName: "FriendId");

            migrationBuilder.RenameColumn(
                name: "Deadline",
                table: "Projects",
                newName: "PaymentDate");

            migrationBuilder.RenameColumn(
                name: "Budget",
                table: "Projects",
                newName: "Amount");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentId",
                table: "Payments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "Id");
        }
    }
}
