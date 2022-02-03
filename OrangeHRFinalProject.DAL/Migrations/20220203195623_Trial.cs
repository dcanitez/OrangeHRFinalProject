using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrangeHRFinalProject.DAL.Migrations
{
    public partial class Trial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Comments_CommentId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_CommentId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Holidays",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDay",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommentCount",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "PermissionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermissionTypeId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permissions_PermissionTypes_PermissionTypeId",
                        column: x => x.PermissionTypeId,
                        principalTable: "PermissionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "23cbfcf1-b37b-4e58-a139-c6c154268cfd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "fab88dfc-90b1-4be1-aa7a-34c666b356a9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "11a351b5-d10e-453f-8734-208643ff5177");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e23a4939-b247-497f-bb9c-b653404d9a66", true, "AQAAAAEAACcQAAAAEB+97qVnRKFWNsPtGJLWYdcbvKB6D8Em2m+NBaeKheu62KrJBT0EalUv1HduKZ1dEA==", "830970b7-0b2c-4936-98f2-f6817bbf4fa5" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 401, DateTimeKind.Local).AddTicks(5072), new DateTime(2022, 2, 3, 21, 56, 21, 404, DateTimeKind.Local).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(857), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(883), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(889), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(894), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(900), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(905), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(908) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(911), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(916), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(918) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(921), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(928), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(933), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(939), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(941) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(944), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(950), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(955), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(960), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(963) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(984), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(990), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(996), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1001), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1006), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1012), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1017), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1019) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1023), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1025) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1029), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1034), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1040), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1045), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1051), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1056), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1061), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1067), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1072), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1074) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1077), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1083), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1088), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1094), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1096) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1099), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1104), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1109), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1115), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1120), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1126), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1131), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1136), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1142), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1147), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1152), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1158), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1163), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1168), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1174), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1176) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1179), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1181) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1184), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1190), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1196), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1201), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1204) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1207), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1212), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1218), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1220) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1223), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1226) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1229), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1231) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1234), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1239), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1245), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1250), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1256), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1261), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1266), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1272), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1274) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1277), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1283), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1293), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1298), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1304), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1309), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1315), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1320), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1326), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1332), new DateTime(2022, 2, 3, 21, 56, 21, 405, DateTimeKind.Local).AddTicks(1334) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 416, DateTimeKind.Local).AddTicks(2105), new DateTime(2022, 2, 3, 21, 56, 21, 416, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 418, DateTimeKind.Local).AddTicks(6103), new DateTime(2022, 2, 3, 21, 56, 21, 418, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 418, DateTimeKind.Local).AddTicks(6962), new DateTime(2022, 2, 3, 21, 56, 21, 418, DateTimeKind.Local).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 418, DateTimeKind.Local).AddTicks(6981), new DateTime(2022, 2, 3, 21, 56, 21, 418, DateTimeKind.Local).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 418, DateTimeKind.Local).AddTicks(6987), new DateTime(2022, 2, 3, 21, 56, 21, 418, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 418, DateTimeKind.Local).AddTicks(6992), new DateTime(2022, 2, 3, 21, 56, 21, 418, DateTimeKind.Local).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 418, DateTimeKind.Local).AddTicks(6997), new DateTime(2022, 2, 3, 21, 56, 21, 418, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 418, DateTimeKind.Local).AddTicks(7002), new DateTime(2022, 2, 3, 21, 56, 21, 418, DateTimeKind.Local).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(5883), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7507), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7526), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7532), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7537), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7544), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7550), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7556), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7561), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7567), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7572), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7578), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7670), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7676), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7682), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7759), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7766), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7772), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7778), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7783), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7789), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7795), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7800), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7806), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7812), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7817), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7823), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7828), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7834), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7840), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7846), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7851), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7857), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7862), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7868), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7873), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7880), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7885), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7891), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7896), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7902), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7908), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7913), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7919), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7925), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7931), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7937), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7942), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7948), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8022), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8028), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8035), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8040), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8046), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8052), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8057), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8063), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8068), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8074), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8080), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8086), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8088) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8091), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8097), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8102), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8108), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8113), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8119), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8124), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8130), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8136), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8141), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8147), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8152), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8158), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8163), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8170), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8175), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8181), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8187), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8189) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8193), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8199), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8204), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8207) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8210), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8215), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8221), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8296), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8302), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8308), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8314), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8319), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8325), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8330), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8336), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8341), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8347), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8352), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8358), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8364), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8369), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8375), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8380), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8386), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8391), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8397), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8402), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8417), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8422), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8428), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8433), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8439), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8445), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8451), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8456), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8462), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8467), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8473), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8478), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8484), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8495), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8501), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8507), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8586), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8589) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8592), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8598), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8603), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8609), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8614), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8625), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8631), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8637), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8643), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8648), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8654), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8661), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8668), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8674), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8680), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8686), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8692), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8698), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8704), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8709), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8715), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8721), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8726), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8732), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8737), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8746), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8752), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8757), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8763), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8768), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8774), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8779), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8785), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8791), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9031), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9052), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9066), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9073), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9080), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9086), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9094), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9102), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9109), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9115), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9123), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9130), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9137), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9144), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9151), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9158), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9165), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9173), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9180), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9198), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9217), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9236), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9256), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9275), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9294), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9304) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9310), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9317), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9324), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9344), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9354), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9364), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9371), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9378), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9399), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9418), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9429), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9437), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9571), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9585), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9607), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9618), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9639), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9647), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9654), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9658) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9662), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9671), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9679), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9686), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9692), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9709), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9725), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9732), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9745), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9764), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9782), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9800), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9807), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9814), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9825), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9843), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9862), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9877), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9883), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9891), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9898), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9906), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9925), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9937), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9944) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9957), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9967), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9975), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9982), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9989), new DateTime(2022, 2, 3, 21, 56, 21, 451, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(47), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(68), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(89), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(110), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(131), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(151), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(172), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(183) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(187), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(194), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(203), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(210), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(219), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(234), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(254), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(273), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(292), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(311), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(329), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(347), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(365), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(384), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(402), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(420), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(438), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(458), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(476), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(496), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(514), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(533), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(551), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(571), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(591), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(612), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(633), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(654), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(674), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(694), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(787), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(810), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(832), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(852), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(872), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(893), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(914), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(934), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(944) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(955), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(977), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(997), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1018), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1041), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1061), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1082), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1102), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1123), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1144), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1164), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1174) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1185), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1206), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1227), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1249), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1271), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1293), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1306), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1309) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1313), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1320), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1327), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1333), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1340), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1346), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1353), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1360), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1367), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1373), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1434), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1455), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1462), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1470), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1477), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1485), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1492), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1496) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1501), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1520), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1530), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1553), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1565), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1579), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1594), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1607), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1625), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1635), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1652), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1666), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1680), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1697), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1710), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1727), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1743), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1754), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1762) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1771), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1783), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1800), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1816), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1827), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1845), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1857), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1872), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1888), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1900), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1919), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1929), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2004), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2015), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2033), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2048), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2060), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2077), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2089), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2097), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2104), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2122), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2131), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2141), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2149), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2163), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2183), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2204), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2224), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2260), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2269), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2276), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2288), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2303), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2311), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2319), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2328), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2350), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2362), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2370), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2378), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2385), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2393), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2400), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2407), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2429), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2449), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2468), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2546), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2556), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2571), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2586), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2594), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2603) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2614), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2649), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2658), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2665), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2678), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2683), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2689), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2696), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2701), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2707), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2712), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2718), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2723), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2729), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2735), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2741), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2746), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2752), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2757), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2763), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2768), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2773), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2780), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2785), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2791), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2797), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2799) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2802), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2807), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2813), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2818), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2824), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2830), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2885), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2891), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2897), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2902), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2908), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2913), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2919), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2925), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2930), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2936), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2941), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2947), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2952), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2958), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2963), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2969), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2975), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2980), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2986), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2991), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(2998), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3003), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3008), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3014), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3019), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3025), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3030), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3036), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3042), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3051), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3059), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3067), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3075), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3082), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3117), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3125), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3129) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3192), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3211), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3219), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3237), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3245), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3254), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3272), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3280), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3288), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3303), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3324), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3338), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3348), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3366), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3378), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3395), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3407), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3422), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3436), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3449), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3467), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3477), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3487) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3495), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3506), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3522), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3537), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3549), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3566), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3571) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3576), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3596), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3605), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3624), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3633), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3650), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3660), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3670), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3794), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3818), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3830), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3850), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3858), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3866), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3879), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3897), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3910), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3919), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3927), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3934), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3948), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3963), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3973), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4012), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4026), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4035), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4041), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4046), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4052), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4057), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4063), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4069), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4074), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4080), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4085), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4091), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4096), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4102), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4107), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4113), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4118), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4124), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4130), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4135), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4141), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4195), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4202), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4208), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4213), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4215) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4219), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4224), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4229), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4235), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4241), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4246), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4252), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4257), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4263), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4268), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4274), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4279), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4285), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4302), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4307), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4313), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4319), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4324), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4330), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4335), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4341), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4347), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4353), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4358), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4364), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4370), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4375), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4382), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4387), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4393), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4398), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4404), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4446), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4452), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4458), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4463), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4469), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4475), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4480), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4486), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4488) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4491), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4498), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4506), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4514), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4522), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4530), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4538), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4573), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4582), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4590), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4603), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4622), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4642), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4651), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4667), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4677), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4693), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4703), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4712), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4731), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4751), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4762), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4771), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4789), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4799), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4809), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4817), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4839), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4860), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4888) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4967), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4982), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4990), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5001), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5019), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5032), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5041), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5050), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5058), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5071), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5087), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5096), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5106) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5136), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5149), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5157), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5163), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5169), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5175), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5181), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5186), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5192), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5197), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5203), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5208), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5214), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5217) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5220), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5226), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5228) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5231), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5237), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5242), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5247), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5253), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5259), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5264), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5270), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5275), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5329), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5335), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5341), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5347), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5352), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5358), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5363), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5369), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5374), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5379), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5385), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5387) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5391), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5397), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5403), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5408), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5414), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5419), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5425), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5427) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5431), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5437), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5443), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5449), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5455), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5461), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5468), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5474), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5479), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5482) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5485), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5491), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5497), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5502), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5508), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5513), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5519), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5524), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5530), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5535), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5538) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5578), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5584), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5590), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5595), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5602), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5607), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5613), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5618), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5624), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5629), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5635), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5640), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5646), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5651), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5657), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5663), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5671), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5679), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5687), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5695), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5703), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5738), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5746), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5754), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5764), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5785), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5807), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5815), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5836), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5857), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5879), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5892), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5908), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5917), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5935), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5949), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6041), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6063), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6072), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6086), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6099), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6111), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6127), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6137), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6154), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6164), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6174), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6193), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6202), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6221), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6233), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6247), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6262), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6274), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6286), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6301), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6312), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6320), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6339), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6360), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6400), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6406) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6410), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6428), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6435), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6444), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6454), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6475), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6483), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6491), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6506), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6525), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6534), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6543), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6638), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6660), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6666), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6672), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6677), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6683), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6688), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6694), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6700), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6706), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6711), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6717), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6723), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6728), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6734), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6740), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6746), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6751), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6757), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6762), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6768), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6774), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6780), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6785), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6791), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6796), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6802), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6807), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6813), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6819), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6825), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6831), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6836), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6841), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6847), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6852), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6926), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6933), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6939), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6944), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6946) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6950), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6955), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6961), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6966), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6972), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6977), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6983), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6991), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6996), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7001), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7007), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7013), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7023), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7029), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7035), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7040), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7046), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7051), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7057), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7062), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7068), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7073), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7079), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7084), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7090), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7095), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7101), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7106), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7112), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7117), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7123), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7125) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7128), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7134), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7175), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7181), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7187), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7192), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7200), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7208), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7216), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7224), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7232), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7266), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7275), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7284), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7292), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7300), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7318), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7339), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7377), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7388), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7394), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7400), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7405), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7411), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7416), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7422), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7428), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7433), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7439), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7444), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7450), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7455), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7460), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7466), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7472), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7477), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7482), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7488), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7560), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7566), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7572), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7578), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7583), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7589), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7594), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7600), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7605), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7611), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7617), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7622), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7628), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7633), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7639), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7645), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7650), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7657), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7704), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7709), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7715), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7720), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7726), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7731), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7737), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7743), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7748), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7754), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7759), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7765), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7770), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7776), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7781), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7788), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7793), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7799), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7804), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7852), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7861), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7869), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7877), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7911), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7921), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7924) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7935), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8303), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8323), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8333), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8340), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8345), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8351), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8356), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8362), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8367), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8373), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8378), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8384), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8390), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8395), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8401), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8406), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8412), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8417), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8423), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8430), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8433) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8436), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8438) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8441), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8447), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8452), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8458), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8463), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8469), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8475), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8683), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8716), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8734), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8747), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8762), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8777), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8789), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8806), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8817), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8834), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8845), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8861), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8875), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8891), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8899), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8917), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8927), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8937), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8946), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8967), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(8987), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9027), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9036), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9054), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9061), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9069), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9085), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9101), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9109), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9117), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9136), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9152), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9161), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9170), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9177), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9185), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9311), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9325) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9331), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9337), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9346), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9640), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9653), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9662), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9670), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9677), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9685), new DateTime(2022, 2, 3, 21, 56, 21, 452, DateTimeKind.Local).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 458, DateTimeKind.Local).AddTicks(3609), new DateTime(2022, 2, 3, 21, 56, 21, 458, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 458, DateTimeKind.Local).AddTicks(5000), new DateTime(2022, 2, 3, 21, 56, 21, 458, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 458, DateTimeKind.Local).AddTicks(5018), new DateTime(2022, 2, 3, 21, 56, 21, 458, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 458, DateTimeKind.Local).AddTicks(5024), new DateTime(2022, 2, 3, 21, 56, 21, 458, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 458, DateTimeKind.Local).AddTicks(5030), new DateTime(2022, 2, 3, 21, 56, 21, 458, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 458, DateTimeKind.Local).AddTicks(5035), new DateTime(2022, 2, 3, 21, 56, 21, 458, DateTimeKind.Local).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 459, DateTimeKind.Local).AddTicks(4066), new DateTime(2022, 2, 3, 21, 56, 21, 459, DateTimeKind.Local).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 459, DateTimeKind.Local).AddTicks(5903), new DateTime(2022, 2, 3, 21, 56, 21, 459, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.InsertData(
                table: "PermissionTypes",
                columns: new[] { "Id", "CreatedDate", "Description", "LastModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(7690), "Yıllık İzin", new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(7725) },
                    { 13, new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8613), "Ücretsiz İzin", new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8616) },
                    { 12, new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8607), "Hastalık İzni", new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8610) },
                    { 11, new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8602), "Yol İzni", new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8604) },
                    { 10, new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8596), "Babalık İzni", new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8599) },
                    { 9, new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8591), "Askerlik İzni", new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8593) },
                    { 8, new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8585), "Doğum İzni", new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8588) },
                    { 7, new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8575), "Evlilik İzni", new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8582) },
                    { 6, new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8564), "İş Arama İzni", new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8572) },
                    { 5, new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8559), "Mazeret İzni", new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8561) },
                    { 4, new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8553), "Süt İzni", new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8556) },
                    { 3, new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8548), "Vefat İzni", new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8550) },
                    { 2, new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8530), "Doğum Sonrası İzni", new DateTime(2022, 2, 3, 21, 56, 21, 461, DateTimeKind.Local).AddTicks(8542) }
                });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(4139), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5019), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5037), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5043), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5048), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5054), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5059), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5065), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5070), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5076), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5081), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5086), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5092), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5097), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5102), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5108), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5113), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5118), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5123), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5129), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5134), new DateTime(2022, 2, 3, 21, 56, 21, 463, DateTimeKind.Local).AddTicks(5137) });

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_EmployeeId",
                table: "Holidays",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ManagerId",
                table: "Comments",
                column: "ManagerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_EmployeeId",
                table: "Permissions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_PermissionTypeId",
                table: "Permissions",
                column: "PermissionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Employees_ManagerId",
                table: "Comments",
                column: "ManagerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Holidays_Employees_EmployeeId",
                table: "Holidays",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Employees_ManagerId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Holidays_Employees_EmployeeId",
                table: "Holidays");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "PermissionTypes");

            migrationBuilder.DropIndex(
                name: "IX_Holidays_EmployeeId",
                table: "Holidays");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ManagerId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "BirthDay",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CommentCount",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "384ec9fb-9d18-4205-b155-157bdb3c51fd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "02077072-7971-4185-aaeb-7d1bf8939839");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "428e3c74-0039-4683-9769-d68edb12af33");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "946d704c-3005-4fd2-b1df-0b918bfaa405", "AQAAAAEAACcQAAAAEAY3GAHxb5yRjZITE8TpqJSeu57LgSVTVZT1sv/RGeQpCvgvQbNIcPbA7zpcdepCQg==", "7a4e4945-d083-4067-b3df-2395d8cf2b47" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 932, DateTimeKind.Local).AddTicks(2582), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6395), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6422), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6428), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6434), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6441), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6446), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6449) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6452), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6457), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6462), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6465) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6468), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6473), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6476) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6479), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6485), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6491), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6496), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6501), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6507), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6512), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6515) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6518), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6523), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6528), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6534), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6539), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6545), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6550), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6662), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6665) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6669), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6675), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6681), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6683) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6686), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6691), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6697), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6702), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6707), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6714), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6719), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6725), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6730), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6735), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6741), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6746), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6752), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6757), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6762), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6768), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6773), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6778), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6784), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6789), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6794), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6800), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6805), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6810), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6816), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6821), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6827), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6832), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6838), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6843), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6848), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6854), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6859), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6865), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6870), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6873) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6878), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6883), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6888), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6891) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6894), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6899), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6905), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6910), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6916), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6921), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6926), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6932), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6937), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6942), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6948), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6953), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6959), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 940, DateTimeKind.Local).AddTicks(9560), new DateTime(2022, 1, 31, 22, 58, 51, 940, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(3359), new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4199), new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4218), new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4225), new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4230), new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4236), new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4241), new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 974, DateTimeKind.Local).AddTicks(9170), new DateTime(2022, 1, 31, 22, 58, 51, 974, DateTimeKind.Local).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6057), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6132), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6142), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6152), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6163), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6172), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6182), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6190), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6193) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6197), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6207), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6217), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6228), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6238), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6249), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6260), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6270), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6279), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6287), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6296), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6304), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6313), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6322), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6333), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6340), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6348), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6356), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6364), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6372), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6381), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6390), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6393) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6399), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6407), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6416), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6426), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6435), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6554), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6565), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6573), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6577) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6584), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6592), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6601), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6609), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6618), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6628), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6637), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6647), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6656), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6664), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6673), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6680), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6683) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6688), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6696), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6705), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6715), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6723), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6733), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6743), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6751), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6761), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6771), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6780), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6789), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6800), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6810), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6818), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6826), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6836), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6845), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6854), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6863), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6872), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6945), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6957), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6968), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6978), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6986), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6993), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7001), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7009), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7017), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7024), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7032), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7040), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7044) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7048), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7057), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7066), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7074), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7091), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7112), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7611), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7638), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7648), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7657), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7665), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7684), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7692), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7701), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7709), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7717), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7726), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7735), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7744), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7753), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7762), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7771), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7789), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7953), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7965), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7975), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7984), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7992), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8002), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8011), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8020), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8029), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8038), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8049), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8058), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8066), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8074), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8083), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8092), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8100), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8107), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8116), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8124), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8134), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8143), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8151), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8160), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8168), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8177), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8186), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8195), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8203), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8210), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8218), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8227), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8235), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8243), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8246) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8252), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8256) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8260), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8354), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8369), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8377), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8385), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8393), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8401), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8410), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8413) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8418), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8422) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8426), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8435), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8448), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8451) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8456), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8464), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8468) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8473), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8482), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8491), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8498), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8506), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8513), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8517) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8521), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8531), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8539), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8549), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8553) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8558), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8566), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8575), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8584), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8593), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8603), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8607) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8613), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8622), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8631), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8635) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8648), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8657), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8665), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8672), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8766), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8794), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8814), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8821), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8828), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8835), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8842), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8849), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8856), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8864), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8871), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8879), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8886), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8893), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8900), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8908), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8914), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8922), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8929), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8936), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8943), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8957), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8966), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8973), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8982), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8989), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8996), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9003), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9016), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9023), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9040), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9059), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9105), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9126), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9189), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9193) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9200), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9206), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9222), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9259), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9270), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9276), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9283), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9286) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9290), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9297), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9304), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9312), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9320), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9329), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9336), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9343), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9350), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9358), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9366), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9373), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9380), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9388), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9397), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9406), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9414), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9421), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9428), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9435), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9443), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9453), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9460), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9468), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9546), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9558), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9564), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9569), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9576), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9631), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9638), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9643), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9649), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9654), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9660), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9665), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9671), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9677), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9683), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9690), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9696), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9702), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9708), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9713), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9719), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9721) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9724), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9730), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9736), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9741), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9747), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9752), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9758), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9764), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9770), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9776), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9781), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9787), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9792), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9798), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9803), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9809), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9815), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9820), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9826), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9831), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9876), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9882), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9888), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9893), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9900), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9905), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9911), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9916), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9922), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9928), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9933), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9939), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9945), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9950), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9956), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9961), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9967), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9973), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9978), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9984), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9991), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9996), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(8), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(13), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(19), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(25), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(30), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(36), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(41), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(47), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(53), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(58), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(64), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(70), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(76), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(81), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(130), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(136), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(141), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(147), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(153), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(158), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(164), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(169), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(175), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(180), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(183) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(186), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(192), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(197), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(203), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(205) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(208), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(214), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(219), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(225), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(231), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(236), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(242), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(248), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(253), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(259), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(264), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(270), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(275), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(282), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(288), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(293), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(299), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(304), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(310), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(315), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(321), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(326), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(369), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(375), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(381), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(386), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(392), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(397), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(403), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(408), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(414), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(420), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(425), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(431), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(437), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(439) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(442), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(448), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(454), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(459), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(465), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(473), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(478), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(484), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(490), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(496), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(501), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(507), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(512), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(518), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(523), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(529), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(535), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(540), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(546), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(551), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(557), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(562), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(568), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(574), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(650), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(656), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(662), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(664) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(668), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(674), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(679), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(682) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(685), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(690), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(696), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(701), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(707), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(713), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(718), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(724), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(730), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(736), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(741), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(747), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(753), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(758), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(764), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(769), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(775), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(781), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(787), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(789) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(793), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(804), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(809), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(815), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(820), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(826), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(834), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(839), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(845), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(850), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(892), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(898), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(904), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(909), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(915), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(921), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(926), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(932), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(938), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(941) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(944), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(950), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(955), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(961), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(963) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(966), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(972), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(978), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(983), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(985) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(989), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(994), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1000), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1006), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1012), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1017), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1023), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1025) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1029), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1034), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1040), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1046), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1053), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1059), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1064), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1070), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1075), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1081), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1087), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1093), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1136), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1144), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1149), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1155), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1160), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1166), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1172), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1174) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1177), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1183), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1189), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1191) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1194), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1197) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1200), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1206), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1208) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1211), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1217), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1222), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1229), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1235), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1241), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1247), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1252), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1258), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1263), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1269), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1275), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1280), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1286), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1291), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1297), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1299) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1302), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1308), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1314), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1321), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1326), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1332), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1338), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1343), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1390), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1396), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1402), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1407), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1413), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1418), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1424), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1426) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1429), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1432) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1435), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1440), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1443) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1446), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1452), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1458), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1461) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1464), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1466) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1469), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1475), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1477) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1481), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1486), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1492), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1498), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1503), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1509), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1514), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1520), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1528), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1534), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1539), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1546), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1552), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1557), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1563), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1569), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1574), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1580), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1585), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1591), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1636), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1643), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1649), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1655), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1661), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1667), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1673), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1679), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1684), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1690), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1696), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1703), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1708), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1715), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1721), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1727), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1733), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1738), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1741) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1747), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1758), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1767), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1776), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1780) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1784), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1792), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1800), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1835), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1843), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1850), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1857), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1864), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1870), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1877), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1884), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1890), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1897), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1904), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1911), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2013), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2034), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2041), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2049), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2058), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2065), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2073), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2080), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2088), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2095), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2102), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2111), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2120), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2127), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2134), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2142), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2151), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2160), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2169), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2176), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2187), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2194), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2201), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2209), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2216), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2224), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2231), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2239), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2248), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2257), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2265), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2273), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2280), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2288), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2295), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2305), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2379), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2388), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2395), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2403), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2411), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2419), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2427), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2436), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2443), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2450), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2457), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2465), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2468) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2473), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2480), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2487), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2495), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2502), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2510), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2513) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2518), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2527), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2535), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2544), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2554), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2562), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2570), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2579), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2595), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2609), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2624), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2640), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2654), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2668), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2684), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2696), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2712), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2727), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2741), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2827), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2844), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2860), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2874), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2889), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2903), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2917), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2933), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2946), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2961), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2975), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2990), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3006), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3019), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3034), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3048), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3062), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3081), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3094), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3108), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3124), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3138), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3152), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3169), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3181), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3197), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3211), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3225), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3242), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3259), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3271), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3287), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3299), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3315), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3329), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3343), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3476), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3493), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3505), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3521), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3539), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3543) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3551), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3567), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3581), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3587) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3595), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3609), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3624), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3640), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3654), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3668), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3684), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3697), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3713), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3727), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3741), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3748) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3757), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3769), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3785), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3802), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3808) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3816), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3830), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3844), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3858), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3866) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3875), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3889), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3903), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3919), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3933), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3948), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3962), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3976), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3992), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4007), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4093), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4107), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4123), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4137), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4151), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4167), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4182), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4197), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4211), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4225), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4241), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4247) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4255), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4270), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4285), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4301), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4315), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4332), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4346), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4360), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4376), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4390), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4404), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4412) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4420), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4433), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4446), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4486), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4498), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4506), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4514), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4519) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4522), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4528), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4534), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4540), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4545), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4551), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4553) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4556), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4610), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4617), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4622), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4628), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4634), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4639), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4645), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4651), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4656), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4663), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4665) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4669), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4675), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4680), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4686), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4691), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4697), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4702), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4708), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4713), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4719), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4725), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4731), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4736), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4738) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4742), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4747), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4753), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4759), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4764), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4770), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4776), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4781), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4787), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4792), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4798), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4804), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4809), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4815), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4859), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4865), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4871), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4876), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4879) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4882), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4888), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4893), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4899), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4904), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4910), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4916), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4921), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4927), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4932), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4938), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4944), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4949), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4955), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4961), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4967), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4972), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4978), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4984), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4989), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4995), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5000), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5006), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5008) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5011), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5017), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5022), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5028), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5034), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5040), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5043) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5046), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5051), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5057), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5099), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5105), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5111), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5113) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5116), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5122), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5127), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5133), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5139), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5144), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5150), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5155), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5161), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5166), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5172), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5178), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5183), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5189), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5191) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5194), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5200), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5206), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5217), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5223), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5229), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5234), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5240), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5246), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5249) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5252), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5257), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5263), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5269), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5274), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5280), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5285), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5291), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5297), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5302), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5347), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5353), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5358), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5364), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5369), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5375), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5381), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5386), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5392), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5397), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5403), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5409), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5414), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5420), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5425), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5431), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5436), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5442), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5447), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5453), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5467), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5480), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5487), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5497), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5503), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5508), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5514), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5520), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5525), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5531), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5537), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5542), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5548), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5553), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5559), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5565), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5611), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5617), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5622), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5628), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5633), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5639), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5645), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5651), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5656), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5662), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5668), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5674), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5679), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5685), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5691), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5697), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5702), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5708), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5714), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5720), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5726), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5731), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5737), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5742), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5748), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5754), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5759), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5765), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5770), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5776), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5782), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5784) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5787), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5793), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5798), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5804), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5809), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5815), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5869), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5875), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5881), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5886), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5892), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5897), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5903), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5908), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5914), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5920), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5926), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5931), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5937), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5942), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5948), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5953), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5959), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5964), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5970), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5977), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5982), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5988), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(4268), new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(5495), new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(5516), new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(5522), new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(5529), new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(5534), new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 981, DateTimeKind.Local).AddTicks(4086), new DateTime(2022, 1, 31, 22, 58, 51, 981, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 981, DateTimeKind.Local).AddTicks(5864), new DateTime(2022, 1, 31, 22, 58, 51, 981, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(5791), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6614), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6632), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6638), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6644), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6650), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6656), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6661), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6667), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6672), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6678), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6683), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6688), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6694), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6699), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6705), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6763), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6770), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6775), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6780), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6786), new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CommentId",
                table: "Employees",
                column: "CommentId",
                unique: true,
                filter: "[CommentId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Comments_CommentId",
                table: "Employees",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
