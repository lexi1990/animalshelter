using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AnimalShelter.Migrations
{
    public partial class Status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Size",
                table: "Animals",
                nullable: true,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<byte>(
                name: "Status",
                table: "Animals",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Animals");

            migrationBuilder.AlterColumn<byte>(
                name: "Size",
                table: "Animals",
                nullable: false,
                oldClrType: typeof(byte),
                oldNullable: true);
        }
    }
}
