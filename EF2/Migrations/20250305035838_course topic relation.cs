﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF2.Migrations
{
    /// <inheritdoc />
    public partial class coursetopicrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Courses_Top_ID",
                table: "Courses",
                column: "Top_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_Top_ID",
                table: "Courses",
                column: "Top_ID",
                principalTable: "Topics",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_Top_ID",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Top_ID",
                table: "Courses");
        }
    }
}
