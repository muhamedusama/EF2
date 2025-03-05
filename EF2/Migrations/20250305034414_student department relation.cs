using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF2.Migrations
{
    /// <inheritdoc />
    public partial class studentdepartmentrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Students_Dep_ID",
                table: "Students",
                column: "Dep_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_Dep_ID",
                table: "Students",
                column: "Dep_ID",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_Dep_ID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Dep_ID",
                table: "Students");
        }
    }
}
