using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace pcms.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    sk = table.Column<long>(type: "bigint", nullable: false),
                    emr = table.Column<string>(nullable: true),
                    yr_mon = table.Column<string>(nullable: true),
                    emr_cnt = table.Column<int>(nullable: false),
                    add_user = table.Column<string>(nullable: true),
                    add_time = table.Column<DateTime>(nullable: true),
                    chg_user = table.Column<string>(nullable: true),
                    chg_time = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.sk);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
