﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mahakBackend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class removeList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "imageId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageId",
                table: "Users");
        }
    }
}
