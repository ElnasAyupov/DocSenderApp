using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DocsSenderApp.Migrations
{
    public partial class OnCreatingEmployeeContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employeers",
                columns: table => new
                {
                    EmployeeId = table.Column<string>(nullable: false),
                    AccountId = table.Column<string>(nullable: true),
                    Avatar = table.Column<byte[]>(nullable: true),
                    FIO = table.Column<string>(nullable: true),
                    RankId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employeers", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    RankId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranks", x => x.RankId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employeers");

            migrationBuilder.DropTable(
                name: "Ranks");
        }
    }
}
