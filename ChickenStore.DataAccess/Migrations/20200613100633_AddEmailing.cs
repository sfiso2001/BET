using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChickenStore.DataAccess.Migrations
{
    public partial class AddEmailing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoverTypes");

            migrationBuilder.CreateTable(
                name: "EmailMessages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(maxLength: 100, nullable: false),
                    MessageText = table.Column<string>(maxLength: 300, nullable: false),
                    FromName = table.Column<string>(maxLength: 50, nullable: false),
                    FromEMail = table.Column<string>(maxLength: 50, nullable: false),
                    Sent = table.Column<bool>(nullable: false),
                    SentDate = table.Column<DateTime>(nullable: false),
                    Resolved = table.Column<bool>(nullable: false),
                    ResolvedDate = table.Column<DateTime>(nullable: false),
                    ResolvedBy = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailSetups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mailserver = table.Column<string>(maxLength: 20, nullable: false),
                    username = table.Column<string>(maxLength: 50, nullable: false),
                    pwd = table.Column<string>(maxLength: 50, nullable: true),
                    displayname = table.Column<string>(maxLength: 50, nullable: true),
                    emailtype = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailSetups", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailMessages");

            migrationBuilder.DropTable(
                name: "EmailSetups");

            migrationBuilder.CreateTable(
                name: "CoverTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoverTypes", x => x.Id);
                });
        }
    }
}
