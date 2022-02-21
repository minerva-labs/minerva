using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Minerva.Data;
using NodaTime;

#nullable disable

namespace Minerva.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:test_result_format", "playwright_test,cucumber_js,jest");

            migrationBuilder.CreateTable(
                name: "test_results",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false),
                    duration = table.Column<decimal>(type: "numeric", nullable: false),
                    run_at = table.Column<Instant>(type: "timestamp with time zone", nullable: false),
                    result_type = table.Column<TestResultFormat>(type: "test_result_format", nullable: false),
                    tags = table.Column<List<string>>(type: "text[]", nullable: false),
                    trigger = table.Column<string>(type: "text", nullable: false),
                    product = table.Column<string>(type: "text", nullable: false),
                    error_message = table.Column<string>(type: "jsonb", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_test_results", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "test_results");
        }
    }
}
