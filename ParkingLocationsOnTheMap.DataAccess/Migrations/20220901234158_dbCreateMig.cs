using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingLocationsOnTheMap.DataAccess.Migrations
{
    public partial class dbCreateMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IsparkData",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PARK_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LOCATION_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PARK_TYPE_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAPACITY_OF_PARK = table.Column<int>(type: "int", nullable: false),
                    WORKING_TIME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COUNTY_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LONGITUDE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LATITUDE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsparkData", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "NewIsparkData",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PARK_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LOCATION_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PARK_TYPE_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAPACITY_OF_PARK = table.Column<int>(type: "int", nullable: false),
                    WORKING_TIME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COUNTY_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LONGITUDE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LATITUDE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewIsparkData", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SURNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    USER_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PASSWORD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserAccess",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DATE_TIME = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TIME_OVER = table.Column<DateTime>(type: "datetime2", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccess", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserAccess_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAccess_UserID",
                table: "UserAccess",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IsparkData");

            migrationBuilder.DropTable(
                name: "NewIsparkData");

            migrationBuilder.DropTable(
                name: "UserAccess");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
