using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagementDAL.Migrations
{
    /// <inheritdoc />
    public partial class auditableEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Insurances",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Insurances",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Insurances",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Insurances",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Insurances",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Insurances",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Insurances",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Genders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Genders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Genders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Genders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Genders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Genders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Genders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Insurances");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Insurances");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Insurances");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Insurances");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Insurances");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Insurances");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Insurances");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Genders");
        }
    }
}
