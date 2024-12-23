using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FinishDate",
                table: "TaskItems",
                newName: "FinishTDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "TaskItems",
                newName: "CreateTDate");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTDate",
                value: new DateTime(2024, 12, 23, 20, 5, 7, 413, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTDate",
                value: new DateTime(2024, 12, 23, 20, 5, 7, 413, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTDate",
                value: new DateTime(2024, 12, 23, 20, 5, 7, 413, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTDate",
                value: new DateTime(2024, 12, 23, 20, 5, 7, 413, DateTimeKind.Local).AddTicks(8180));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FinishTDate",
                table: "TaskItems",
                newName: "FinishDate");

            migrationBuilder.RenameColumn(
                name: "CreateTDate",
                table: "TaskItems",
                newName: "CreatedDate");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 1, 39, 1, 519, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 1, 39, 1, 519, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 1, 39, 1, 519, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 1, 39, 1, 519, DateTimeKind.Local).AddTicks(3746));
        }
    }
}
