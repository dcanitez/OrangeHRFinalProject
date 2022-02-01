using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrangeHRFinalProject.DAL.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FieldName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Holidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Memberships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memberships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sector = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    NumberOfEmployees = table.Column<int>(type: "int", nullable: false),
                    CompanyLogoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MembershipStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MembershipEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: true),
                    MembershipId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Memberships_MembershipId",
                        column: x => x.MembershipId,
                        principalTable: "Memberships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorporateEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorporatePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FieldName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDataProtectionRead = table.Column<bool>(type: "bit", nullable: false),
                    PhotoFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentId = table.Column<int>(type: "int", nullable: true),
                    ManagerId = table.Column<int>(type: "int", nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    TitleId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "384ec9fb-9d18-4205-b155-157bdb3c51fd", "admin", "ADMIN" },
                    { 2, "02077072-7971-4185-aaeb-7d1bf8939839", "manager", "MANAGER" },
                    { 3, "428e3c74-0039-4683-9769-d68edb12af33", "personel", "PERSONEL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FieldName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "946d704c-3005-4fd2-b1df-0b918bfaa405", "admin@mail.com", true, null, null, null, false, null, "admin@mail.com", "ADMIN", "AQAAAAEAACcQAAAAEAY3GAHxb5yRjZITE8TpqJSeu57LgSVTVZT1sv/RGeQpCvgvQbNIcPbA7zpcdepCQg==", null, false, "7a4e4945-d083-4067-b3df-2395d8cf2b47", false, "admin" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[] { 1, new DateTime(2022, 1, 31, 22, 58, 51, 940, DateTimeKind.Local).AddTicks(9560), new DateTime(2022, 1, 31, 22, 58, 51, 940, DateTimeKind.Local).AddTicks(9608), "Türkiye" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "Description", "LastModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(3359), "Bilgi İşlem", new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(3397) },
                    { 2, new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4199), "Halkla İlişkiler", new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4212) },
                    { 3, new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4218), "İnsan Kaynakları", new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4221) },
                    { 4, new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4225), "Muhasebe ve Finans", new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4227) },
                    { 5, new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4230), "Müşteri Hizmetleri", new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4233) },
                    { 6, new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4236), "Satış Pazarlama", new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4238) },
                    { 7, new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4241), "Yönetim", new DateTime(2022, 1, 31, 22, 58, 51, 942, DateTimeKind.Local).AddTicks(4243) }
                });

            migrationBuilder.InsertData(
                table: "Holidays",
                columns: new[] { "Id", "CreatedDate", "Description", "EndDate", "LastModifiedDate", "StartDate" },
                values: new object[,]
                {
                    { 6, new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(5534), "Kurban Bayramı", new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(5537), new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(5529), "Atatürk'ü Anma Gençlik ve Spor Bayramı", new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(5531), new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(5522), "Ramazan Bayramı", new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(5525), new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(5516), "Emek ve Dayanışma Günü", new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(5519), new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(5495), "Ulusal Egemenlik ve Çocuk Bayramı", new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(5511), new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(4268), "Yeni Yıl Tatili", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 31, 22, 58, 51, 980, DateTimeKind.Local).AddTicks(4317), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "Id", "CreatedDate", "Description", "Duration", "LastModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 31, 22, 58, 51, 981, DateTimeKind.Local).AddTicks(4086), "Aylık Üyelik", 30, new DateTime(2022, 1, 31, 22, 58, 51, 981, DateTimeKind.Local).AddTicks(4117) },
                    { 2, new DateTime(2022, 1, 31, 22, 58, 51, 981, DateTimeKind.Local).AddTicks(5864), "Yıllık Üyelik", 365, new DateTime(2022, 1, 31, 22, 58, 51, 981, DateTimeKind.Local).AddTicks(5879) }
                });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "Id", "CreatedDate", "Description", "LastModifiedDate" },
                values: new object[,]
                {
                    { 19, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6775), "Teknik Destek Uzmanı", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6778) },
                    { 18, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6770), "Sistem Yöneticisi", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6772) },
                    { 17, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6763), "Satış Temsilcisi", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6766) },
                    { 16, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6705), "Personel Müdürü", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6707) },
                    { 15, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6699), "Müşteri İlişkileri Sorumlusu", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6702) },
                    { 14, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6694), "Muhasebe Sorumlusu", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6696) },
                    { 13, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6688), "Muhasebe Asistanı", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6691) },
                    { 12, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6683), "Maliye Sorumlusu", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6686) },
                    { 11, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6678), "Kurumsal Satış Sorumlusu", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6680) },
                    { 1, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(5791), "Araştırma Mühendisi", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(5815) },
                    { 9, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6667), "Kurumsal İletişim Uzmanı", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6669) },
                    { 8, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6661), "İnsan Kaynakları Direktörü", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6664) },
                    { 7, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6656), "İnsan Kaynakları Asistanı", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6658) },
                    { 6, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6650), "Hesap Yöneticisi", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6652) },
                    { 5, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6644), "Halkla İlişkiler Uzmanı", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6647) },
                    { 4, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6638), "Genel Müdür Yardımcısı", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6641) },
                    { 3, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6632), "Genel Müdür", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6635) },
                    { 2, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6614), "Destek Uzmanı", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6627) },
                    { 20, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6780), "Veritabanı Uzmanı", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6783) },
                    { 10, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6672), "Kurumsal Satış Müdürü", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6675) },
                    { 21, new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6786), "Yazılım Mühendisi", new DateTime(2022, 1, 31, 22, 58, 51, 982, DateTimeKind.Local).AddTicks(6788) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityName", "CountryId", "CreatedDate", "LastModifiedDate" },
                values: new object[,]
                {
                    { 58, "Sivas", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6832), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6835) },
                    { 57, "Sinop", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6827), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6829) },
                    { 56, "Siirt", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6821), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6824) },
                    { 55, "Samsun", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6816), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6818) },
                    { 54, "Sakarya", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6810), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6813) },
                    { 53, "Rize", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6805), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6808) },
                    { 52, "Ordu", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6800), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6802) },
                    { 59, "Tekirdağ", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6838), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6840) },
                    { 51, "Niğde", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6794), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6797) },
                    { 49, "Muş", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6784), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6786) },
                    { 48, "Muğla", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6778), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6781) },
                    { 47, "Mardin", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6773), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6775) },
                    { 46, "Kahramanmaraş", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6768), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6770) },
                    { 45, "Manisa", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6762), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6765) },
                    { 44, "Malatya", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6757), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6759) },
                    { 43, "Kütahya", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6752), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6754) },
                    { 50, "Nevşehir", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6789), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6792) },
                    { 60, "Tokat", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6843), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6845) },
                    { 61, "Trabzon", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6848), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6851) },
                    { 62, "Tunceli", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6854), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6856) },
                    { 79, "Kilis", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6948), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6950) },
                    { 78, "Karabük", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6942), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6945) },
                    { 77, "Yalova", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6937), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6940) },
                    { 76, "Iğdır", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6932), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6934) },
                    { 75, "Ardahan", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6926), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6929) },
                    { 74, "Bartın", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6921), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6923) },
                    { 73, "Şırnak", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6916), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6918) },
                    { 72, "Batman", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6910), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6913) },
                    { 71, "Kırıkkale", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6905), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6907) },
                    { 70, "Karaman", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6899), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6902) },
                    { 69, "Bayburt", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6894), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6896) },
                    { 68, "Aksaray", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6888), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6891) },
                    { 67, "Zonguldak", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6883), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6885) },
                    { 66, "Yozgat", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6878), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6880) },
                    { 65, "Van", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6870), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6873) },
                    { 64, "Uşak", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6865), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6867) },
                    { 63, "Şanlıurfa", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6859), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6862) },
                    { 42, "Konya", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6746), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6749) },
                    { 41, "Kocaeli", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6741), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6743) },
                    { 40, "Kırşehir", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6735), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6738) },
                    { 39, "Kırklareli", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6730), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6733) }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityName", "CountryId", "CreatedDate", "LastModifiedDate" },
                values: new object[,]
                {
                    { 17, "Çanakkale", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6501), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6504) },
                    { 16, "Bursa", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6496), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6498) },
                    { 15, "Burdur", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6491), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6493) },
                    { 14, "Bolu", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6485), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6487) },
                    { 13, "Bitlis", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6479), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6481) },
                    { 12, "Bingöl", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6473), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6476) },
                    { 11, "Bilecik", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6468), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6470) },
                    { 10, "Balıkesir", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6462), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6465) },
                    { 9, "Aydın", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6457), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6459) },
                    { 8, "Artvin", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6452), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6454) },
                    { 7, "Antalya", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6446), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6449) },
                    { 6, "Ankara", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6441), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6443) },
                    { 5, "Amasya", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6434), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6436) },
                    { 4, "Ağrı", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6428), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6431) },
                    { 3, "Afyonkarahisar", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6422), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6425) },
                    { 2, "Adıyaman", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6395), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6415) },
                    { 1, "Adana", 1, new DateTime(2022, 1, 31, 22, 58, 51, 932, DateTimeKind.Local).AddTicks(2582), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(4391) },
                    { 18, "Çankırı", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6507), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6509) },
                    { 80, "Osmaniye", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6953), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6956) },
                    { 19, "Çorum", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6512), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6515) },
                    { 21, "Diyarbakır", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6523), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6525) },
                    { 38, "Kayseri", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6725), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6727) },
                    { 37, "Kastamonu", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6719), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6722) },
                    { 36, "Kars", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6714), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6716) },
                    { 35, "İzmir", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6707), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6710) },
                    { 34, "İstanbul", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6702), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6704) },
                    { 33, "Mersin", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6697), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6699) },
                    { 32, "Isparta", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6691), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6694) },
                    { 31, "Hatay", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6686), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6688) },
                    { 30, "Hakkari", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6681), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6683) },
                    { 29, "Gümüşhane", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6675), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6678) },
                    { 28, "Giresun", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6669), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6672) },
                    { 27, "Gaziantep", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6662), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6665) },
                    { 26, "Eskişehir", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6550), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6552) },
                    { 25, "Erzurum", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6545), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6547) },
                    { 24, "Erzincan", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6539), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6542) },
                    { 23, "Elazığ", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6534), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6536) },
                    { 22, "Edirne", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6528), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6531) },
                    { 20, "Denizli", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6518), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6520) },
                    { 81, "Düzce", 1, new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6959), new DateTime(2022, 1, 31, 22, 58, 51, 935, DateTimeKind.Local).AddTicks(6961) }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 1, 31, 22, 58, 51, 974, DateTimeKind.Local).AddTicks(9170), new DateTime(2022, 1, 31, 22, 58, 51, 974, DateTimeKind.Local).AddTicks(9239), "Seyhan" },
                    { 639, 46, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2527), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2530), "Türkoğlu" },
                    { 640, 46, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2535), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2539), "Çağlayancerit" },
                    { 641, 46, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2544), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2548), "Ekinözü" },
                    { 642, 46, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2554), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2557), "Nurhak" },
                    { 643, 46, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2562), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2565), "Dulkadiroğlu" },
                    { 644, 46, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2570), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2573), "Onikişubat" },
                    { 645, 47, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2579), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2586), "Derik" },
                    { 646, 47, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2595), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2602), "Kızıltepe" },
                    { 647, 47, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2609), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2614), "Mazıdağı" },
                    { 648, 47, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2624), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2631), "Midyat" },
                    { 649, 47, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2640), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2646), "Nusaybin" },
                    { 650, 47, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2654), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2660), "Ömerli" },
                    { 638, 46, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2518), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2522), "Pazarcık" },
                    { 651, 47, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2668), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2676), "Savur" },
                    { 653, 47, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2696), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2704), "Yeşilli" },
                    { 654, 47, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2712), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2718), "Artuklu" },
                    { 655, 48, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2727), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2732), "Bodrum" },
                    { 656, 48, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2741), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2748), "Datça" },
                    { 657, 48, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2827), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2835), "Fethiye" },
                    { 658, 48, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2844), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2852), "Köyceğiz" },
                    { 659, 48, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2860), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2866), "Marmaris" },
                    { 660, 48, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2874), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2880), "Milas" },
                    { 661, 48, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2889), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2896), "Ula" },
                    { 662, 48, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2903), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2908), "Yatağan" },
                    { 663, 48, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2917), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2924), "Dalaman" },
                    { 664, 48, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2933), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2939), "Ortaca" },
                    { 652, 47, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2684), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2689), "Dargeçit" },
                    { 665, 48, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2946), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2953), "Kavaklıdere" },
                    { 637, 46, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2510), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2513), "Göksun" },
                    { 635, 46, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2495), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2498), "Andırın" },
                    { 609, 44, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2224), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2227), "Hekimhan" },
                    { 610, 44, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2231), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2235), "Pütürge" },
                    { 611, 44, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2239), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2243), "Yeşilyurt / Malatya" },
                    { 612, 44, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2248), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2251), "Battalgazi" },
                    { 613, 44, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2257), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2260), "Doğanyol" },
                    { 614, 44, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2265), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2269), "Kale / Malatya" },
                    { 615, 44, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2273), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2276), "Kuluncak" },
                    { 616, 44, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2280), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2284), "Yazıhan" },
                    { 617, 45, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2288), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2291), "Akhisar" },
                    { 618, 45, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2295), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2298), "Alaşehir" },
                    { 619, 45, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2305), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2313), "Demirci" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 620, 45, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2379), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2383), "Gördes" },
                    { 636, 46, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2502), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2505), "Elbistan" },
                    { 621, 45, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2388), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2391), "Kırkağaç" },
                    { 623, 45, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2403), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2406), "Salihli" },
                    { 624, 45, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2411), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2414), "Sarıgöl" },
                    { 625, 45, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2419), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2423), "Saruhanlı" },
                    { 626, 45, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2427), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2430), "Selendi" },
                    { 627, 45, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2436), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2439), "Soma" },
                    { 628, 45, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2443), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2446), "Turgutlu" },
                    { 629, 45, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2450), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2454), "Ahmetli" },
                    { 630, 45, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2457), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2461), "Gölmarmara" },
                    { 631, 45, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2465), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2468), "Köprübaşı / Manisa" },
                    { 632, 45, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2473), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2476), "Şehzadeler" },
                    { 633, 45, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2480), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2484), "Yunusemre" },
                    { 634, 46, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2487), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2491), "Afşin" },
                    { 622, 45, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2395), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2399), "Kula" },
                    { 666, 48, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2961), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2969), "Menteşe" },
                    { 667, 48, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2975), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2981), "Seydikemer" },
                    { 668, 49, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2990), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2997), "Bulanık" },
                    { 700, 52, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3581), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3587), "Çamaş" },
                    { 701, 52, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3595), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3603), "Çatalpınar" },
                    { 702, 52, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3609), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3615), "Çaybaşı" },
                    { 703, 52, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3624), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3631), "İkizce" },
                    { 704, 52, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3640), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3646), "Kabadüz" },
                    { 705, 52, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3654), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3660), "Kabataş" },
                    { 706, 52, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3668), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3676), "Altınordu" },
                    { 707, 53, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3684), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3689), "Ardeşen" },
                    { 708, 53, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3697), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3704), "Çamlıhemşin" },
                    { 709, 53, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3713), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3719), "Çayeli" },
                    { 710, 53, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3727), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3732), "Fındıklı" },
                    { 711, 53, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3741), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3748), "İkizdere" },
                    { 699, 52, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3567), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3573), "Gürgentepe" },
                    { 712, 53, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3757), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3762), "Kalkandere" },
                    { 714, 53, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3785), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3791), "Rize Merkez" },
                    { 715, 53, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3802), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3808), "Güneysu" },
                    { 716, 53, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3816), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3822), "Derepazarı" },
                    { 717, 53, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3830), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3838), "Hemşin" },
                    { 718, 53, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3844), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3850), "İyidere" },
                    { 719, 54, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3858), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3866), "Akyazı" },
                    { 720, 54, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3875), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3880), "Geyve" },
                    { 721, 54, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3889), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3894), "Hendek" },
                    { 722, 54, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3903), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3911), "Karasu" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 723, 54, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3919), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3925), "Kaynarca" },
                    { 724, 54, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3933), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3939), "Sapanca" },
                    { 725, 54, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3948), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3955), "Kocaali" },
                    { 713, 53, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3769), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3777), "Pazar / Rize" },
                    { 698, 52, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3551), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3559), "Gülyalı" },
                    { 697, 52, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3539), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3543), "Ünye" },
                    { 696, 52, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3521), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3527), "Ulubey / Ordu" },
                    { 669, 49, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3006), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3012), "Malazgirt" },
                    { 670, 49, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3019), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3026), "Muş Merkez" },
                    { 671, 49, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3034), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3041), "Varto" },
                    { 672, 49, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3048), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3054), "Hasköy" },
                    { 673, 49, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3062), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3071), "Korkut" },
                    { 674, 50, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3081), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3088), "Avanos" },
                    { 675, 50, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3094), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3100), "Derinkuyu" },
                    { 676, 50, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3108), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3116), "Gülşehir" },
                    { 677, 50, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3124), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3130), "Hacıbektaş" },
                    { 678, 50, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3138), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3144), "Kozaklı" },
                    { 679, 50, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3152), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3160), "Nevşehir Merkez" },
                    { 680, 50, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3169), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3173), "Ürgüp" },
                    { 681, 50, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3181), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3188), "Acıgöl" },
                    { 682, 51, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3197), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3203), "Bor" },
                    { 683, 51, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3211), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3217), "Çamardı" },
                    { 684, 51, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3225), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3233), "Niğde Merkez" },
                    { 685, 51, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3242), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3250), "Ulukışla" },
                    { 686, 51, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3259), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3262), "Altunhisar" },
                    { 687, 51, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3271), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3278), "Çiftlik" },
                    { 688, 52, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3287), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3293), "Akkuş" },
                    { 689, 52, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3299), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3306), "Aybastı" },
                    { 690, 52, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3315), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3321), "Fatsa" },
                    { 691, 52, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3329), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3334), "Gölköy" },
                    { 692, 52, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3343), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3350), "Korgan" },
                    { 693, 52, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3476), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3484), "Kumru" },
                    { 694, 52, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3493), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3497), "Mesudiye" },
                    { 695, 52, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3505), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3513), "Perşembe" },
                    { 608, 44, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2216), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2219), "Doğanşehir" },
                    { 726, 54, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3962), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3967), "Pamukova" },
                    { 607, 44, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2209), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2212), "Darende" },
                    { 605, 44, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2194), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2197), "Arapgir" },
                    { 518, 38, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1429), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1432), "Develi" },
                    { 519, 38, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1435), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1437), "Felahiye" },
                    { 520, 38, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1440), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1443), "İncesu" },
                    { 521, 38, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1446), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1449), "Pınarbaşı / Kayseri" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 522, 38, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1452), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1454), "Sarıoğlan" },
                    { 523, 38, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1458), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1461), "Sarız" },
                    { 524, 38, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1464), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1466), "Tomarza" },
                    { 525, 38, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1469), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1472), "Yahyalı" },
                    { 526, 38, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1475), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1477), "Yeşilhisar" },
                    { 527, 38, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1481), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1483), "Akkışla" },
                    { 528, 38, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1486), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1489), "Talas" },
                    { 529, 38, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1492), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1494), "Kocasinan" },
                    { 517, 38, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1424), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1426), "Bünyan" },
                    { 530, 38, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1498), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1500), "Melikgazi" },
                    { 532, 38, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1509), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1511), "Özvatan" },
                    { 533, 39, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1514), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1517), "Babaeski" },
                    { 534, 39, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1520), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1524), "Demirköy" },
                    { 535, 39, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1528), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1531), "Kırklareli Merkez" },
                    { 536, 39, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1534), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1536), "Kofçaz" },
                    { 537, 39, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1539), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1543), "Lüleburgaz" },
                    { 538, 39, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1546), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1548), "Pehlivanköy" },
                    { 539, 39, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1552), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1554), "Pınarhisar" },
                    { 540, 39, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1557), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1560), "Vize" },
                    { 541, 40, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1563), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1565), "Çiçekdağı" },
                    { 542, 40, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1569), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1571), "Kaman" },
                    { 543, 40, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1574), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1577), "Kırşehir Merkez" },
                    { 531, 38, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1503), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1506), "Hacılar" },
                    { 544, 40, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1580), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1582), "Mucur" },
                    { 516, 37, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1418), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1421), "Seydiler" },
                    { 514, 37, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1407), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1410), "Doğanyurt" },
                    { 488, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1217), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1219), "Karabağlar" },
                    { 489, 36, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1222), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1225), "Arpaçay" },
                    { 490, 36, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1229), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1232), "Digor" },
                    { 491, 36, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1235), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1237), "Kağızman" },
                    { 492, 36, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1241), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1244), "Kars Merkez" },
                    { 493, 36, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1247), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1249), "Sarıkamış" },
                    { 494, 36, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1252), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1255), "Selim" },
                    { 495, 36, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1258), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1260), "Susuz" },
                    { 496, 36, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1263), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1266), "Akyaka" },
                    { 497, 37, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1269), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1272), "Abana" },
                    { 498, 37, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1275), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1277), "Araç" },
                    { 499, 37, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1280), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1283), "Azdavay" },
                    { 515, 37, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1413), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1415), "Hanönü" },
                    { 500, 37, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1286), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1288), "Bozkurt / Kastamonu" },
                    { 502, 37, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1297), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1299), "Çatalzeytin" },
                    { 503, 37, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1302), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1305), "Daday" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 504, 37, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1308), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1310), "Devrekani" },
                    { 505, 37, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1314), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1317), "İnebolu" },
                    { 506, 37, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1321), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1323), "Kastamonu Merkez" },
                    { 507, 37, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1326), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1329), "Küre" },
                    { 508, 37, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1332), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1335), "Taşköprü" },
                    { 509, 37, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1338), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1340), "Tosya" },
                    { 510, 37, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1343), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1346), "İhsangazi" },
                    { 511, 37, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1390), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1393), "Pınarbaşı / Kastamonu" },
                    { 512, 37, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1396), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1398), "Şenpazar" },
                    { 513, 37, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1402), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1404), "Ağlı" },
                    { 501, 37, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1291), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1294), "Cide" },
                    { 545, 40, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1585), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1588), "Akpınar" },
                    { 546, 40, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1591), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1593), "Akçakent" },
                    { 547, 40, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1636), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1639), "Boztepe" },
                    { 579, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1884), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1887), "Karatay" },
                    { 580, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1890), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1893), "Meram" },
                    { 581, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1897), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1900), "Selçuklu" },
                    { 582, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1904), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1907), "Taşkent" },
                    { 583, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1911), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1914), "Ahırlı" },
                    { 584, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2013), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2024), "Çeltik" },
                    { 585, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2034), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2037), "Derbent" },
                    { 586, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2041), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2044), "Emirgazi" },
                    { 587, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2049), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2052), "Güneysınır" },
                    { 588, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2058), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2061), "Halkapınar" },
                    { 589, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2065), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2068), "Tuzlukçu" },
                    { 590, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2073), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2077), "Yalıhüyük" },
                    { 578, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1877), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1880), "Hüyük" },
                    { 591, 43, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2080), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2084), "Altıntaş" },
                    { 593, 43, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2095), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2098), "Emet" },
                    { 594, 43, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2102), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2105), "Gediz" },
                    { 595, 43, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2111), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2114), "Kütahya Merkez" },
                    { 596, 43, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2120), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2123), "Simav" },
                    { 597, 43, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2127), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2130), "Tavşanlı" },
                    { 598, 43, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2134), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2138), "Aslanapa" },
                    { 599, 43, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2142), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2146), "Dumlupınar" },
                    { 600, 43, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2151), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2155), "Hisarcık" },
                    { 601, 43, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2160), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2164), "Şaphane" },
                    { 602, 43, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2169), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2172), "Çavdarhisar" },
                    { 603, 43, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2176), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2182), "Pazarlar" },
                    { 604, 44, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2187), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2190), "Akçadağ" },
                    { 592, 43, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2088), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2091), "Domaniç" },
                    { 577, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1870), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1873), "Derebucak" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 576, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1864), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1867), "Altınekin" },
                    { 575, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1857), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1860), "Akören" },
                    { 548, 41, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1643), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1646), "Gebze" },
                    { 549, 41, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1649), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1651), "Gölcük" },
                    { 550, 41, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1655), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1657), "Kandıra" },
                    { 551, 41, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1661), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1664), "Karamürsel" },
                    { 552, 41, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1667), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1670), "Körfez" },
                    { 553, 41, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1673), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1675), "Derince" },
                    { 554, 41, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1679), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1681), "Başiskele" },
                    { 555, 41, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1684), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1687), "Çayırova" },
                    { 556, 41, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1690), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1692), "Darıca" },
                    { 557, 41, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1696), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1700), "Dilovası" },
                    { 558, 41, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1703), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1705), "İzmit" },
                    { 559, 41, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1708), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1711), "Kartepe" },
                    { 560, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1715), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1718), "Akşehir" },
                    { 561, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1721), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1723), "Beyşehir" },
                    { 562, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1727), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1730), "Bozkır" },
                    { 563, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1733), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1735), "Cihanbeyli" },
                    { 564, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1738), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1741), "Çumra" },
                    { 565, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1747), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1751), "Doğanhisar" },
                    { 566, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1758), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1761), "Ereğli / Konya" },
                    { 567, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1767), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1772), "Hadim" },
                    { 568, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1776), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1780), "Ilgın" },
                    { 569, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1784), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1788), "Kadınhanı" },
                    { 570, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1792), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1796), "Karapınar" },
                    { 571, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1800), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1826), "Kulu" },
                    { 572, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1835), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1839), "Sarayönü" },
                    { 573, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1843), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1846), "Seydişehir" },
                    { 574, 42, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1850), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1853), "Yunak" },
                    { 606, 44, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2201), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2205), "Arguvan" },
                    { 727, 54, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3976), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3983), "Taraklı" },
                    { 728, 54, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(3992), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4000), "Ferizli" },
                    { 729, 54, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4007), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4012), "Karapürçek" },
                    { 882, 67, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5381), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5383), "Ereğli / Zonguldak" },
                    { 883, 67, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5386), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5389), "Zonguldak Merkez" },
                    { 884, 67, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5392), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5394), "Alaplı" },
                    { 885, 67, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5397), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5400), "Gökçebey" },
                    { 886, 67, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5403), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5405), "Kilimli" },
                    { 887, 67, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5409), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5411), "Kozlu" },
                    { 888, 68, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5414), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5417), "Aksaray Merkez" },
                    { 889, 68, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5420), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5422), "Ortaköy / Aksaray" },
                    { 890, 68, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5425), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5428), "Ağaçören" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 891, 68, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5431), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5433), "Güzelyurt" },
                    { 892, 68, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5436), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5439), "Sarıyahşi" },
                    { 893, 68, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5442), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5444), "Eskil" },
                    { 881, 67, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5375), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5378), "Devrek" },
                    { 894, 68, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5447), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5450), "Gülağaç" },
                    { 896, 69, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5467), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5477), "Aydıntepe" },
                    { 897, 69, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5480), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5483), "Demirözü" },
                    { 898, 70, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5487), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5494), "Ermenek" },
                    { 899, 70, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5497), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5500), "Karaman Merkez" },
                    { 900, 70, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5503), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5505), "Ayrancı" },
                    { 901, 70, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5508), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5511), "Kazımkarabekir" },
                    { 902, 70, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5514), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5516), "Başyayla" },
                    { 903, 70, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5520), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5522), "Sarıveliler" },
                    { 904, 71, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5525), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5528), "Delice" },
                    { 905, 71, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5531), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5533), "Keskin" },
                    { 906, 71, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5537), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5539), "Kırıkkale Merkez" },
                    { 907, 71, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5542), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5545), "Sulakyurt" },
                    { 895, 69, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5453), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5456), "Bayburt Merkez" },
                    { 908, 71, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5548), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5550), "Bahşili" },
                    { 880, 67, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5369), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5372), "Çaycuma" },
                    { 878, 66, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5358), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5361), "Saraykent" },
                    { 852, 64, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5172), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5175), "Uşak Merkez" },
                    { 853, 65, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5178), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5180), "Başkale" },
                    { 854, 65, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5183), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5186), "Çatak" },
                    { 855, 65, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5189), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5191), "Erciş" },
                    { 856, 65, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5194), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5197), "Gevaş" },
                    { 857, 65, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5200), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5203), "Gürpınar" },
                    { 858, 65, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5206), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5208), "Muradiye" },
                    { 859, 65, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5214), "Özalp" },
                    { 860, 65, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5217), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5220), "Bahçesaray" },
                    { 861, 65, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5223), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5226), "Çaldıran" },
                    { 862, 65, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5229), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5231), "Edremit / Van" },
                    { 863, 65, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5234), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5237), "Saray / Van" },
                    { 879, 66, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5364), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5366), "Yenifakılı" },
                    { 864, 65, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5240), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5242), "İpekyolu" },
                    { 866, 66, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5252), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5254), "Akdağmadeni" },
                    { 867, 66, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5257), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5260), "Boğazlıyan" },
                    { 868, 66, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5263), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5265), "Çayıralan" },
                    { 869, 66, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5269), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5271), "Çekerek" },
                    { 870, 66, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5274), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5277), "Sarıkaya" },
                    { 871, 66, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5280), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5282), "Sorgun" },
                    { 872, 66, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5285), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5288), "Şefaatli" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 873, 66, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5291), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5293), "Yerköy" },
                    { 874, 66, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5297), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5299), "Yozgat Merkez" },
                    { 875, 66, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5302), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5305), "Aydıncık / Yozgat" },
                    { 876, 66, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5347), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5349), "Çandır" },
                    { 877, 66, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5353), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5355), "Kadışehri" },
                    { 865, 65, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5246), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5249), "Tuşba" },
                    { 909, 71, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5553), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5556), "Balışeyh" },
                    { 910, 71, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5559), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5562), "Çelebi" },
                    { 911, 71, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5565), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5567), "Karakeçili" },
                    { 943, 77, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5787), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5790), "Çınarcık" },
                    { 944, 77, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5793), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5795), "Çiftlikköy" },
                    { 945, 77, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5798), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5801), "Termal" },
                    { 946, 78, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5804), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5806), "Eflani" },
                    { 947, 78, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5809), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5812), "Eskipazar" },
                    { 948, 78, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5815), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5817), "Karabük Merkez" },
                    { 949, 78, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5869), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5872), "Ovacık / Karabük" },
                    { 950, 78, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5875), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5877), "Safranbolu" },
                    { 951, 78, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5881), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5883), "Yenice / Karabük" },
                    { 952, 79, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5886), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5889), "Kilis Merkez" },
                    { 953, 79, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5892), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5894), "Elbeyli" },
                    { 954, 79, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5897), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5900), "Musabeyli" },
                    { 942, 77, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5782), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5784), "Armutlu" },
                    { 955, 79, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5903), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5905), "Polateli" },
                    { 957, 80, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5914), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5917), "Kadirli" },
                    { 958, 80, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5920), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5922), "Osmaniye Merkez" },
                    { 959, 80, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5926), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5928), "Düziçi" },
                    { 960, 80, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5931), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5934), "Hasanbeyli" },
                    { 961, 80, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5937), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5939), "Sumbas" },
                    { 962, 80, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5942), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5945), "Toprakkale" },
                    { 963, 81, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5948), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5950), "Akçakoca" },
                    { 964, 81, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5953), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5956), "Düzce Merkez" },
                    { 965, 81, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5959), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5961), "Yığılca" },
                    { 966, 81, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5964), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5967), "Cumayeri" },
                    { 967, 81, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5970), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5973), "Gölyaka" },
                    { 968, 81, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5977), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5979), "Çilimli" },
                    { 956, 80, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5908), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5911), "Bahçe" },
                    { 941, 77, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5776), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5778), "Altınova" },
                    { 940, 77, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5770), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5773), "Yalova Merkez" },
                    { 939, 76, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5765), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5767), "Karakoyunlu" },
                    { 912, 71, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5611), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5613), "Yahşihan" },
                    { 913, 72, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5617), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5619), "Batman Merkez" },
                    { 914, 72, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5622), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5625), "Beşiri" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 915, 72, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5628), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5630), "Gercüş" },
                    { 916, 72, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5633), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5636), "Kozluk" },
                    { 917, 72, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5639), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5642), "Sason" },
                    { 918, 72, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5645), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5647), "Hasankeyf" },
                    { 919, 73, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5651), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5653), "Beytüşşebap" },
                    { 920, 73, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5656), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5659), "Cizre" },
                    { 921, 73, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5662), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5665), "İdil" },
                    { 922, 73, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5668), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5670), "Silopi" },
                    { 923, 73, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5674), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5676), "Şırnak Merkez" },
                    { 924, 73, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5679), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5681), "Uludere" },
                    { 925, 73, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5685), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5687), "Güçlükonak" },
                    { 926, 74, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5691), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5693), "Bartın Merkez" },
                    { 927, 74, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5697), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5699), "Kurucaşile" },
                    { 928, 74, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5702), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5705), "Ulus" },
                    { 929, 74, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5708), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5711), "Amasra" },
                    { 930, 75, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5714), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5717), "Ardahan Merkez" },
                    { 931, 75, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5720), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5722), "Çıldır" },
                    { 932, 75, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5726), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5728), "Göle" },
                    { 933, 75, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5731), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5734), "Hanak" },
                    { 934, 75, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5737), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5739), "Posof" },
                    { 935, 75, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5742), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5745), "Damal" },
                    { 936, 76, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5748), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5750), "Aralık" },
                    { 937, 76, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5754), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5756), "Iğdır Merkez" },
                    { 938, 76, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5759), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5762), "Tuzluca" },
                    { 851, 64, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5166), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5169), "Ulubey / Uşak" },
                    { 850, 64, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5161), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5163), "Sivaslı" },
                    { 849, 64, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5155), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5158), "Karahallı" },
                    { 848, 64, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5150), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5152), "Eşme" },
                    { 761, 57, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4534), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4536), "Durağan" },
                    { 762, 57, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4540), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4542), "Erfelek" },
                    { 763, 57, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4545), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4548), "Gerze" },
                    { 764, 57, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4551), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4553), "Sinop Merkez" },
                    { 765, 57, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4556), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4559), "Türkeli" },
                    { 766, 57, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4610), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4613), "Dikmen" },
                    { 767, 57, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4617), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4619), "Saraydüzü" },
                    { 768, 58, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4622), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4625), "Divriği" },
                    { 769, 58, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4628), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4631), "Gemerek" },
                    { 770, 58, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4634), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4636), "Gürün" },
                    { 771, 58, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4639), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4642), "Hafik" },
                    { 772, 58, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4645), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4647), "İmranlı" },
                    { 760, 57, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4528), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4531), "Boyabat" },
                    { 773, 58, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4651), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4653), "Kangal" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 775, 58, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4663), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4665), "Sivas Merkez" },
                    { 776, 58, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4669), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4671), "Suşehri" },
                    { 777, 58, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4675), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4677), "Şarkışla" },
                    { 778, 58, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4680), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4683), "Yıldızeli" },
                    { 779, 58, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4686), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4688), "Zara" },
                    { 780, 58, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4691), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4694), "Akıncılar" },
                    { 781, 58, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4697), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4699), "Altınyayla / Sivas" },
                    { 782, 58, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4702), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4705), "Doğanşar" },
                    { 783, 58, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4708), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4710), "Gölova" },
                    { 784, 58, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4713), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4716), "Ulaş" },
                    { 785, 59, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4719), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4722), "Çerkezköy" },
                    { 786, 59, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4725), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4727), "Çorlu" },
                    { 774, 58, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4656), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4659), "Koyulhisar" },
                    { 759, 57, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4522), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4525), "Ayancık" },
                    { 758, 56, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4514), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4519), "Tillo" },
                    { 757, 56, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4506), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4510), "Şirvan" },
                    { 730, 54, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4093), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4100), "Söğütlü" },
                    { 731, 54, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4107), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4115), "Adapazarı" },
                    { 732, 54, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4123), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4129), "Arifiye" },
                    { 733, 54, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4137), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4143), "Erenler" },
                    { 734, 54, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4151), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4159), "Serdivan" },
                    { 735, 55, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4167), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4174), "Alaçam" },
                    { 736, 55, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4182), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4189), "Bafra" },
                    { 737, 55, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4197), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4205), "Çarşamba" },
                    { 738, 55, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4211), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4217), "Havza" },
                    { 739, 55, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4225), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4233), "Kavak" },
                    { 740, 55, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4241), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4247), "Ladik" },
                    { 741, 55, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4255), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4261), "Terme" },
                    { 742, 55, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4270), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4277), "Vezirköprü" },
                    { 743, 55, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4285), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4291), "Asarcık" },
                    { 744, 55, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4301), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4306), "19-May" },
                    { 745, 55, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4315), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4323), "Salıpazarı" },
                    { 746, 55, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4332), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4339), "Tekkeköy" },
                    { 747, 55, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4346), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4352), "Ayvacık / Samsun" },
                    { 748, 55, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4360), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4368), "Yakakent" },
                    { 749, 55, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4376), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4382), "Atakum" },
                    { 750, 55, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4390), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4396), "Canik" },
                    { 751, 55, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4404), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4412), "İlkadım" },
                    { 752, 56, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4420), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4425), "Baykan" },
                    { 753, 56, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4433), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4440), "Eruh" },
                    { 754, 56, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4446), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4456), "Kurtalan" },
                    { 755, 56, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4486), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4492), "Pervari" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 756, 56, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4498), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4503), "Siirt Merkez" },
                    { 787, 59, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4731), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4733), "Hayrabolu" },
                    { 487, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1211), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1214), "Bayraklı" },
                    { 788, 59, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4736), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4738), "Malkara" },
                    { 790, 59, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4747), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4750), "Saray / Tekirdağ" },
                    { 822, 61, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4967), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4969), "Düzköy" },
                    { 823, 61, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4972), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4975), "Hayrat" },
                    { 824, 61, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4978), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4980), "Köprübaşı / Trabzon" },
                    { 825, 61, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4984), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4986), "Ortahisar" },
                    { 826, 62, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4989), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4991), "Çemişgezek" },
                    { 827, 62, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4995), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4997), "Hozat" },
                    { 828, 62, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5000), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5003), "Mazgirt" },
                    { 829, 62, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5006), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5008), "Nazımiye" },
                    { 830, 62, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5011), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5014), "Ovacık / Tunceli" },
                    { 831, 62, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5017), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5019), "Pertek" },
                    { 832, 62, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5022), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5025), "Pülümür" },
                    { 833, 62, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5028), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5031), "Tunceli Merkez" },
                    { 821, 61, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4961), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4963), "Dernekpazarı" },
                    { 834, 63, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5034), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5036), "Akçakale" },
                    { 836, 63, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5046), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5048), "Bozova" },
                    { 837, 63, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5051), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5054), "Ceylanpınar" },
                    { 838, 63, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5057), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5059), "Halfeti" },
                    { 839, 63, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5099), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5102), "Hilvan" },
                    { 840, 63, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5105), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5107), "Siverek" },
                    { 841, 63, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5111), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5113), "Suruç" },
                    { 842, 63, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5116), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5119), "Viranşehir" },
                    { 843, 63, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5122), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5124), "Harran" },
                    { 844, 63, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5127), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5130), "Eyyübiye" },
                    { 845, 63, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5133), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5135), "Haliliye" },
                    { 846, 63, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5139), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5141), "Karaköprü" },
                    { 847, 64, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5144), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5146), "Banaz" },
                    { 835, 63, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5040), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5043), "Birecik" },
                    { 820, 61, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4955), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4957), "Çarşıbaşı" },
                    { 819, 61, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4949), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4951), "Şalpazarı" },
                    { 818, 61, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4944), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4946), "Beşikdüzü" },
                    { 791, 59, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4753), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4755), "Şarköy" },
                    { 792, 59, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4759), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4761), "Marmaraereğlisi" },
                    { 793, 59, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4764), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4767), "Ergene" },
                    { 794, 59, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4770), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4773), "Kapaklı" },
                    { 795, 59, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4776), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4778), "Süleymanpaşa" },
                    { 796, 60, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4781), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4784), "Almus" },
                    { 797, 60, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4787), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4789), "Artova" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 798, 60, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4792), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4795), "Erbaa" },
                    { 799, 60, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4798), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4800), "Niksar" },
                    { 800, 60, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4804), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4806), "Reşadiye" },
                    { 801, 60, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4809), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4811), "Tokat Merkez" },
                    { 802, 60, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4815), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4817), "Turhal" },
                    { 803, 60, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4859), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4861), "Zile" },
                    { 804, 60, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4865), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4867), "Pazar / Tokat" },
                    { 805, 60, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4871), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4873), "Yeşilyurt / Tokat" },
                    { 806, 60, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4876), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4879), "Başçiftlik" },
                    { 807, 60, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4882), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4884), "Sulusaray" },
                    { 808, 61, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4888), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4890), "Akçaabat" },
                    { 809, 61, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4893), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4896), "Araklı" },
                    { 810, 61, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4899), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4901), "Arsin" },
                    { 811, 61, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4904), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4907), "Çaykara" },
                    { 812, 61, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4910), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4912), "Maçka" },
                    { 813, 61, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4916), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4918), "Of" },
                    { 814, 61, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4921), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4923), "Sürmene" },
                    { 815, 61, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4927), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4929), "Tonya" },
                    { 816, 61, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4932), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4935), "Vakfıkebir" },
                    { 817, 61, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4938), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4940), "Yomra" },
                    { 789, 59, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4742), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(4744), "Muratlı" },
                    { 486, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1206), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1208), "Güzelbahçe" },
                    { 485, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1200), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1203), "Narlıdere" },
                    { 484, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1194), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1197), "Gaziemir" },
                    { 154, 11, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8426), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8430), "İnhisar" },
                    { 155, 12, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8435), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8439), "Bingöl Merkez" },
                    { 156, 12, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8448), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8451), "Genç" },
                    { 157, 12, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8456), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8459), "Karlıova" },
                    { 158, 12, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8464), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8468), "Kiğı" },
                    { 159, 12, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8473), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8477), "Solhan" },
                    { 160, 12, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8482), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8486), "Adaklı" },
                    { 161, 12, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8491), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8494), "Yayladere" },
                    { 162, 12, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8498), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8501), "Yedisu" },
                    { 163, 13, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8506), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8509), "Adilcevaz" },
                    { 164, 13, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8513), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8517), "Ahlat" },
                    { 165, 13, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8521), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8526), "Bitlis Merkez" },
                    { 153, 11, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8418), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8422), "Yenipazar / Bilecik" },
                    { 166, 13, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8531), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8534), "Hizan" },
                    { 168, 13, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8549), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8553), "Tatvan" },
                    { 169, 13, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8558), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8562), "Güroymak" },
                    { 170, 14, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8566), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8571), "Bolu Merkez" },
                    { 171, 14, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8575), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8579), "Gerede" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 172, 14, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8584), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8588), "Göynük" },
                    { 173, 14, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8593), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8597), "Kıbrıscık" },
                    { 174, 14, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8603), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8607), "Mengen" },
                    { 175, 14, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8613), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8616), "Mudurnu" },
                    { 176, 14, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8622), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8626), "Seben" },
                    { 177, 14, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8631), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8635), "Dörtdivan" },
                    { 178, 14, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8644), "Yeniçağa" },
                    { 179, 15, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8648), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8652), "Ağlasun" },
                    { 167, 13, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8539), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8543), "Mutki" },
                    { 180, 15, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8657), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8661), "Bucak" },
                    { 152, 11, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8410), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8413), "Söğüt" },
                    { 150, 11, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8393), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8397), "Osmaneli" },
                    { 124, 9, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8083), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8087), "Köşk" },
                    { 125, 9, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8092), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8095), "Didim" },
                    { 126, 9, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8100), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8103), "Efeler" },
                    { 127, 10, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8107), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8110), "Ayvalık" },
                    { 128, 10, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8116), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8120), "Balya" },
                    { 129, 10, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8124), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8128), "Bandırma" },
                    { 130, 10, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8134), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8137), "Bigadiç" },
                    { 131, 10, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8143), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8146), "Burhaniye" },
                    { 132, 10, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8151), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8155), "Dursunbey" },
                    { 133, 10, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8160), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8164), "Edremit / Balıkesir" },
                    { 134, 10, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8168), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8172), "Erdek" },
                    { 135, 10, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8177), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8181), "Gönen / Balıkesir" },
                    { 151, 11, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8401), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8404), "Pazaryeri" },
                    { 136, 10, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8186), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8190), "Havran" },
                    { 138, 10, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8203), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8206), "Kepsut" },
                    { 139, 10, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8210), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8214), "Manyas" },
                    { 140, 10, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8218), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8222), "Savaştepe" },
                    { 141, 10, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8227), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8231), "Sındırgı" },
                    { 142, 10, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8235), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8238), "Susurluk" },
                    { 143, 10, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8243), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8246), "Marmara" },
                    { 144, 10, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8252), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8256), "Gömeç" },
                    { 145, 10, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8260), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8264), "Altıeylül" },
                    { 146, 10, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8354), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8360), "Karesi" },
                    { 147, 11, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8369), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8373), "Bilecik Merkez" },
                    { 148, 11, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8377), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8380), "Bozüyük" },
                    { 149, 11, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8385), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8388), "Gölpazarı" },
                    { 137, 10, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8195), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8198), "İvrindi" },
                    { 181, 15, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8665), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8668), "Burdur Merkez" },
                    { 182, 15, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8672), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8675), "Gölhisar" },
                    { 183, 15, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8766), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8779), "Tefenni" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 215, 17, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9040), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9049), "Gelibolu" },
                    { 216, 17, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9059), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9094), "Gökçeada" },
                    { 217, 17, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9105), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9114), "Lapseki" },
                    { 218, 17, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9126), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9130), "Yenice / Çanakkale" },
                    { 219, 18, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9189), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9193), "Çankırı Merkez" },
                    { 220, 18, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9200), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9203), "Çerkeş" },
                    { 221, 18, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9206), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9210), "Eldivan" },
                    { 222, 18, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9222), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9230), "Ilgaz" },
                    { 223, 18, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9259), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9264), "Kurşunlu" },
                    { 224, 18, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9270), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9273), "Orta" },
                    { 225, 18, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9276), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9280), "Şabanözü" },
                    { 226, 18, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9283), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9286), "Yapraklı" },
                    { 214, 17, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9023), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9030), "Ezine" },
                    { 227, 18, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9290), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9293), "Atkaracalar" },
                    { 229, 18, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9304), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9308), "Bayramören" },
                    { 230, 18, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9312), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9315), "Korgun" },
                    { 231, 19, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9320), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9324), "Alaca" },
                    { 232, 19, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9329), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9332), "Bayat / Çorum" },
                    { 233, 19, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9336), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9339), "Çorum Merkez" },
                    { 234, 19, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9343), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9346), "İskilip" },
                    { 235, 19, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9350), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9353), "Kargı" },
                    { 236, 19, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9358), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9361), "Mecitözü" },
                    { 237, 19, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9366), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9369), "Ortaköy / Çorum" },
                    { 238, 19, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9373), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9376), "Osmancık" },
                    { 239, 19, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9380), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9383), "Sungurlu" },
                    { 240, 19, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9388), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9392), "Boğazkale" },
                    { 228, 18, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9297), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9300), "Kızılırmak" },
                    { 213, 17, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9016), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9019), "Eceabat" },
                    { 212, 17, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9013), "Çanakkale Merkez" },
                    { 211, 17, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9003), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9006), "Çan" },
                    { 184, 15, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8794), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8804), "Yeşilova" },
                    { 185, 15, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8814), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8818), "Karamanlı" },
                    { 186, 15, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8821), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8824), "Kemer / Burdur" },
                    { 187, 15, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8828), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8831), "Altınyayla / Burdur" },
                    { 188, 15, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8835), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8838), "Çavdır" },
                    { 189, 15, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8842), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8845), "Çeltikçi" },
                    { 190, 16, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8849), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8852), "Gemlik" },
                    { 191, 16, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8856), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8859), "İnegöl" },
                    { 192, 16, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8864), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8867), "İznik" },
                    { 193, 16, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8871), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8874), "Karacabey" },
                    { 194, 16, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8879), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8882), "Keles" },
                    { 195, 16, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8886), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8889), "Mudanya" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 196, 16, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8893), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8896), "Mustafakemalpaşa" },
                    { 197, 16, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8900), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8904), "Orhaneli" },
                    { 198, 16, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8908), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8910), "Orhangazi" },
                    { 199, 16, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8914), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8917), "Yenişehir / Bursa" },
                    { 200, 16, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8922), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8925), "Büyükorhan" },
                    { 201, 16, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8929), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8932), "Harmancık" },
                    { 202, 16, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8936), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8939), "Nilüfer" },
                    { 203, 16, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8943), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8946), "Osmangazi" },
                    { 204, 16, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8953), "Yıldırım" },
                    { 205, 16, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8957), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8960), "Gürsu" },
                    { 206, 16, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8966), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8969), "Kestel" },
                    { 207, 17, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8973), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8977), "Ayvacık / Çanakkale" },
                    { 208, 17, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8982), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8985), "Bayramiç" },
                    { 209, 17, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8989), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8992), "Biga" },
                    { 210, 17, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8996), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8999), "Bozcaada" },
                    { 123, 9, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8074), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8078), "Karpuzlu" },
                    { 122, 9, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8066), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8070), "İncirliova" },
                    { 121, 9, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8058), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8062), "Buharkent" },
                    { 120, 9, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8049), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8053), "Yenipazar / Aydın" },
                    { 33, 3, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6407), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6411), "Sinanpaşa" },
                    { 34, 3, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6416), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6420), "Sultandağı" },
                    { 35, 3, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6426), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6430), "Şuhut" },
                    { 36, 3, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6435), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6438), "Başmakçı" },
                    { 37, 3, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6554), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6560), "Bayat / Afyonkarahisar" },
                    { 38, 3, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6565), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6569), "İscehisar" },
                    { 39, 3, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6573), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6577), "Çobanlar" },
                    { 40, 3, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6584), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6587), "Evciler" },
                    { 41, 3, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6592), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6596), "Hocalar" },
                    { 42, 3, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6601), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6604), "Kızılören" },
                    { 43, 4, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6609), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6613), "Ağrı Merkez" },
                    { 44, 4, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6618), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6623), "Diyadin" },
                    { 32, 3, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6399), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6402), "Sandıklı" },
                    { 45, 4, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6628), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6633), "Doğubayazıt" },
                    { 47, 4, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6647), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6651), "Hamur" },
                    { 48, 4, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6656), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6660), "Patnos" },
                    { 49, 4, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6664), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6668), "Taşlıçay" },
                    { 50, 4, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6673), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6676), "Tutak" },
                    { 51, 5, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6680), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6683), "Amasya Merkez" },
                    { 52, 5, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6688), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6691), "Göynücek" },
                    { 53, 5, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6696), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6700), "Gümüşhacıköy" },
                    { 54, 5, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6705), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6709), "Merzifon" },
                    { 55, 5, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6715), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6718), "Suluova" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 56, 5, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6723), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6727), "Taşova" },
                    { 57, 5, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6733), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6737), "Hamamözü" },
                    { 58, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6743), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6746), "Altındağ" },
                    { 46, 4, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6637), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6641), "Eleşkirt" },
                    { 31, 3, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6390), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6393), "İhsaniye" },
                    { 30, 3, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6381), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6385), "Emirdağ" },
                    { 29, 3, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6372), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6376), "Dinar" },
                    { 2, 1, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6057), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6113), "Ceyhan" },
                    { 3, 1, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6132), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6136), "Feke" },
                    { 4, 1, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6142), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6147), "Karaisalı" },
                    { 5, 1, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6152), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6156), "Karataş" },
                    { 6, 1, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6163), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6167), "Kozan" },
                    { 7, 1, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6172), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6177), "Pozantı" },
                    { 8, 1, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6182), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6186), "Saimbeyli" },
                    { 9, 1, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6190), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6193), "Tufanbeyli" },
                    { 10, 1, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6197), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6201), "Yumurtalık" },
                    { 11, 1, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6207), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6211), "Yüreğir" },
                    { 12, 1, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6217), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6222), "Aladağ" },
                    { 13, 1, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6228), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6233), "İmamoğlu" },
                    { 14, 1, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6238), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6243), "Sarıçam" },
                    { 15, 1, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6249), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6254), "Çukurova" },
                    { 16, 2, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6260), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6264), "Adıyaman Merkez" },
                    { 17, 2, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6270), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6274), "Besni" },
                    { 18, 2, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6279), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6282), "Çelikhan" },
                    { 19, 2, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6287), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6290), "Gerger" },
                    { 20, 2, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6296), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6299), "Gölbaşı / Adıyaman" },
                    { 21, 2, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6304), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6308), "Kahta" },
                    { 22, 2, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6313), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6317), "Samsat" },
                    { 23, 2, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6322), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6326), "Sincik" },
                    { 24, 2, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6333), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6336), "Tut" },
                    { 25, 3, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6340), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6344), "Afyonkarahisar Merkez" },
                    { 26, 3, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6348), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6351), "Bolvadin" },
                    { 27, 3, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6356), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6359), "Çay" },
                    { 28, 3, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6364), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6367), "Dazkırı" },
                    { 59, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6751), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6756), "Ayaş" },
                    { 241, 19, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9397), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9401), "Uğurludağ" },
                    { 60, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6761), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6766), "Bala" },
                    { 62, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6780), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6784), "Çamlıdere" },
                    { 94, 7, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7657), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7661), "Demre" },
                    { 95, 7, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7665), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7669), "İbradı" },
                    { 96, 7, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7679), "Kemer / Antalya" },
                    { 97, 7, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7684), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7688), "Aksu / Antalya" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 98, 7, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7692), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7696), "Döşemealtı" },
                    { 99, 7, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7701), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7705), "Kepez" },
                    { 100, 7, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7709), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7712), "Konyaaltı" },
                    { 101, 7, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7717), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7721), "Muratpaşa" },
                    { 102, 8, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7726), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7730), "Ardanuç" },
                    { 103, 8, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7735), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7739), "Arhavi" },
                    { 104, 8, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7744), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7748), "Artvin Merkez" },
                    { 105, 8, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7753), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7757), "Borçka" },
                    { 93, 7, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7648), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7652), "Serik" },
                    { 106, 8, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7762), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7767), "Hopa" },
                    { 108, 8, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7784), "Yusufeli" },
                    { 109, 8, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7789), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7794), "Murgul" },
                    { 110, 9, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7953), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7960), "Bozdoğan" },
                    { 111, 9, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7965), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7970), "Çine" },
                    { 112, 9, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7975), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7979), "Germencik" },
                    { 113, 9, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7984), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7988), "Karacasu" },
                    { 114, 9, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7992), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7997), "Koçarlı" },
                    { 115, 9, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8002), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8006), "Kuşadası" },
                    { 116, 9, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8011), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8014), "Kuyucak" },
                    { 117, 9, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8020), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8024), "Nazilli" },
                    { 118, 9, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8029), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8033), "Söke" },
                    { 119, 9, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8038), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(8043), "Sultanhisar" },
                    { 107, 8, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7771), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7774), "Şavşat" },
                    { 92, 7, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7638), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7642), "Manavgat" },
                    { 91, 7, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7611), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7633), "Kumluca" },
                    { 90, 7, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7112), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7121), "Korkuteli" },
                    { 63, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6789), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6794), "Çankaya" },
                    { 64, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6800), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6804), "Çubuk" },
                    { 65, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6810), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6813), "Elmadağ" },
                    { 66, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6818), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6822), "Güdül" },
                    { 67, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6826), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6830), "Haymana" },
                    { 68, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6836), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6840), "Kalecik" },
                    { 69, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6845), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6849), "Kızılcahamam" },
                    { 70, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6854), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6858), "Nallıhan" },
                    { 71, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6863), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6866), "Polatlı" },
                    { 72, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6872), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6877), "Şereflikoçhisar" },
                    { 73, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6945), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6951), "Yenimahalle" },
                    { 74, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6957), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6962), "Gölbaşı / Ankara" },
                    { 75, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6968), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6972), "Keçiören" },
                    { 76, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6978), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6981), "Mamak" },
                    { 77, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6986), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6989), "Sincan" },
                    { 78, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6993), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6996), "Kazan" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 79, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7001), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7004), "Akyurt" },
                    { 80, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7009), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7012), "Etimesgut" },
                    { 81, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7017), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7020), "Evren" },
                    { 82, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7024), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7028), "Pursaklar" },
                    { 83, 7, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7032), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7035), "Akseki" },
                    { 84, 7, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7040), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7044), "Alanya" },
                    { 85, 7, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7048), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7052), "Elmalı" },
                    { 86, 7, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7057), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7060), "Finike" },
                    { 87, 7, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7066), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7069), "Gazipaşa" },
                    { 88, 7, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7074), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7080), "Gündoğmuş" },
                    { 89, 7, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7091), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(7100), "Kaş" },
                    { 61, 6, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6771), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(6775), "Beypazarı" },
                    { 969, 81, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5982), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5985), "Gümüşova" },
                    { 242, 19, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9406), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9410), "Dodurga" },
                    { 244, 19, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9421), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9424), "Oğuzlar" },
                    { 397, 32, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(551), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(554), "Isparta Merkez" },
                    { 398, 32, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(557), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(559), "Keçiborlu" },
                    { 399, 32, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(562), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(565), "Senirkent" },
                    { 400, 32, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(568), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(571), "Sütçüler" },
                    { 401, 32, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(574), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(576), "Şarkikaraağaç" },
                    { 402, 32, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(650), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(653), "Uluborlu" },
                    { 403, 32, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(656), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(659), "Yalvaç" },
                    { 404, 32, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(662), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(664), "Aksu / Isparta" },
                    { 405, 32, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(668), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(671), "Gönen / Isparta" },
                    { 406, 32, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(674), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(676), "Yenişarbademli" },
                    { 407, 33, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(679), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(682), "Anamur" },
                    { 408, 33, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(685), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(687), "Erdemli" },
                    { 396, 32, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(546), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(548), "Gelendost" },
                    { 409, 33, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(690), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(693), "Gülnar" },
                    { 411, 33, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(701), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(704), "Silifke" },
                    { 412, 33, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(707), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(709), "Tarsus" },
                    { 413, 33, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(713), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(715), "Aydıncık / Mersin" },
                    { 414, 33, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(718), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(721), "Bozyazı" },
                    { 415, 33, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(724), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(726), "Çamlıyayla" },
                    { 416, 33, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(730), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(732), "Akdeniz" },
                    { 417, 33, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(736), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(738), "Mezitli" },
                    { 418, 33, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(741), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(743), "Toroslar" },
                    { 419, 33, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(747), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(749), "Yenişehir / Mersin" },
                    { 420, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(753), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(755), "Adalar" },
                    { 421, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(758), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(761), "Bakırköy" },
                    { 422, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(764), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(766), "Beşiktaş" },
                    { 410, 33, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(696), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(698), "Mut" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 423, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(769), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(772), "Beykoz" },
                    { 395, 32, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(540), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(543), "Eğirdir" },
                    { 393, 31, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(529), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(531), "Payas" },
                    { 367, 28, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(381), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(383), "Doğankent" },
                    { 368, 28, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(386), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(389), "Güce" },
                    { 369, 29, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(392), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(394), "Gümüşhane Merkez" },
                    { 370, 29, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(397), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(400), "Kelkit" },
                    { 371, 29, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(403), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(405), "Şiran" },
                    { 372, 29, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(408), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(411), "Torul" },
                    { 373, 29, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(414), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(416), "Köse" },
                    { 374, 29, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(420), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(422), "Kürtün" },
                    { 375, 30, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(425), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(428), "Çukurca" },
                    { 376, 30, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(431), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(433), "Hakkari Merkez" },
                    { 377, 30, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(437), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(439), "Şemdinli" },
                    { 378, 30, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(442), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(445), "Yüksekova" },
                    { 394, 32, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(535), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(537), "Atabey" },
                    { 379, 31, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(448), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(451), "Altınözü" },
                    { 381, 31, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(459), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(462), "Hassa" },
                    { 382, 31, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(465), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(469), "İskenderun" },
                    { 383, 31, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(473), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(475), "Kırıkhan" },
                    { 384, 31, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(478), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(481), "Reyhanlı" },
                    { 385, 31, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(484), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(486), "Samandağ" },
                    { 386, 31, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(490), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(493), "Yayladağı" },
                    { 387, 31, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(496), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(498), "Erzin" },
                    { 388, 31, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(501), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(504), "Belen" },
                    { 389, 31, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(507), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(509), "Kumlu" },
                    { 390, 31, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(512), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(515), "Antakya" },
                    { 391, 31, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(518), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(520), "Arsuz" },
                    { 392, 31, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(523), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(526), "Defne" },
                    { 380, 31, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(454), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(456), "Dörtyol" },
                    { 424, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(775), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(777), "Beyoğlu" },
                    { 425, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(781), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(784), "Çatalca" },
                    { 426, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(787), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(789), "Eyüp" },
                    { 458, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1006), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1008), "Sultangazi" },
                    { 459, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1012), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1014), "Aliağa" },
                    { 460, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1017), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1020), "Bayındır" },
                    { 461, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1023), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1025), "Bergama" },
                    { 462, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1029), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1031), "Bornova" },
                    { 463, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1034), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1037), "Çeşme" },
                    { 464, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1040), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1043), "Dikili" },
                    { 465, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1046), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1050), "Foça" },
                    { 466, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1053), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1055), "Karaburun" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 467, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1059), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1061), "Karşıyaka" },
                    { 468, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1064), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1067), "Kemalpaşa / İzmir" },
                    { 469, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1070), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1072), "Kınık" },
                    { 457, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1000), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1003), "Sancaktepe" },
                    { 470, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1075), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1078), "Kiraz" },
                    { 472, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1087), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1090), "Ödemiş" },
                    { 473, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1093), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1095), "Seferihisar" },
                    { 474, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1136), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1139), "Selçuk" },
                    { 475, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1144), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1146), "Tire" },
                    { 476, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1149), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1152), "Torbalı" },
                    { 477, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1155), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1157), "Urla" },
                    { 478, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1160), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1163), "Beydağ" },
                    { 479, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1166), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1168), "Buca" },
                    { 480, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1172), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1174), "Konak" },
                    { 481, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1177), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1180), "Menderes" },
                    { 482, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1183), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1185), "Balçova" },
                    { 483, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1189), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1191), "Çiğli" },
                    { 471, 35, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1081), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(1083), "Menemen" },
                    { 456, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(994), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(997), "Esenyurt" },
                    { 455, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(989), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(991), "Çekmeköy" },
                    { 454, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(983), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(985), "Beylikdüzü" },
                    { 427, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(793), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(795), "Fatih" },
                    { 428, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(801), "Gaziosmanpaşa" },
                    { 429, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(804), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(806), "Kadıköy" },
                    { 430, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(809), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(812), "Kartal" },
                    { 431, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(815), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(817), "Sarıyer" },
                    { 432, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(820), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(823), "Silivri" },
                    { 433, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(826), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(828), "Şile" },
                    { 434, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(834), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(836), "Şişli" },
                    { 435, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(839), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(842), "Üsküdar" },
                    { 436, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(845), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(847), "Zeytinburnu" },
                    { 437, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(850), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(853), "Büyükçekmece" },
                    { 438, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(892), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(895), "Kağıthane" },
                    { 439, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(898), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(901), "Küçükçekmece" },
                    { 440, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(904), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(906), "Pendik" },
                    { 441, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(909), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(912), "Ümraniye" },
                    { 442, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(915), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(917), "Bayrampaşa" },
                    { 443, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(921), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(923), "Avcılar" },
                    { 444, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(926), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(929), "Bağcılar" },
                    { 445, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(932), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(934), "Bahçelievler" },
                    { 446, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(938), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(941), "Güngören" },
                    { 447, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(944), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(946), "Maltepe" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 448, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(950), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(952), "Sultanbeyli" },
                    { 449, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(955), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(958), "Tuzla" },
                    { 450, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(961), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(963), "Esenler" },
                    { 451, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(966), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(969), "Arnavutköy" },
                    { 452, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(972), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(974), "Ataşehir" },
                    { 453, 34, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(978), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(980), "Başakşehir" },
                    { 366, 28, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(375), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(378), "Çanakçı" },
                    { 365, 28, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(369), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(372), "Çamoluk" },
                    { 364, 28, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(326), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(329), "Yağlıdere" },
                    { 363, 28, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(321), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(323), "Piraziz" },
                    { 276, 21, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9747), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9749), "Kocaköy" },
                    { 277, 21, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9752), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9755), "Bağlar" },
                    { 278, 21, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9758), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9761), "Kayapınar" },
                    { 279, 21, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9764), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9766), "Sur" },
                    { 280, 21, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9770), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9772), "Yenişehir / Diyarbakır" },
                    { 281, 22, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9776), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9778), "Edirne Merkez" },
                    { 282, 22, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9781), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9783), "Enez" },
                    { 283, 22, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9787), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9789), "Havsa" },
                    { 284, 22, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9792), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9795), "İpsala" },
                    { 285, 22, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9798), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9800), "Keşan" },
                    { 286, 22, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9803), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9806), "Lalapaşa" },
                    { 287, 22, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9809), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9812), "Meriç" },
                    { 275, 21, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9741), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9744), "Eğil" },
                    { 288, 22, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9815), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9817), "Uzunköprü" },
                    { 290, 23, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9826), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9828), "Ağın" },
                    { 291, 23, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9831), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9834), "Baskil" },
                    { 292, 23, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9876), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9879), "Elazığ Merkez" },
                    { 293, 23, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9882), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9885), "Karakoçan" },
                    { 294, 23, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9888), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9890), "Keban" },
                    { 295, 23, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9893), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9896), "Maden" },
                    { 296, 23, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9900), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9902), "Palu" },
                    { 297, 23, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9905), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9908), "Sivrice" },
                    { 298, 23, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9911), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9913), "Arıcak" },
                    { 299, 23, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9916), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9919), "Kovancılar" },
                    { 300, 23, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9922), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9924), "Alacakaya" },
                    { 301, 24, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9928), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9930), "Çayırlı" },
                    { 289, 22, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9820), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9823), "Süloğlu" },
                    { 274, 21, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9736), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9738), "Silvan" },
                    { 273, 21, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9730), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9732), "Lice" },
                    { 272, 21, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9724), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9727), "Kulp" },
                    { 245, 20, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9428), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9431), "Acıpayam" },
                    { 246, 20, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9435), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9439), "Buldan" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 247, 20, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9443), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9447), "Çal" },
                    { 248, 20, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9453), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9456), "Çameli" },
                    { 249, 20, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9460), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9463), "Çardak" },
                    { 250, 20, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9468), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9471), "Çivril" },
                    { 251, 20, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9546), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9550), "Güney" },
                    { 252, 20, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9558), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9560), "Kale / Denizli" },
                    { 253, 20, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9564), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9566), "Sarayköy" },
                    { 254, 20, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9569), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9572), "Tavas" },
                    { 255, 20, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9576), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9578), "Babadağ" },
                    { 256, 20, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9631), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9634), "Bekilli" },
                    { 257, 20, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9638), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9640), "Honaz" },
                    { 258, 20, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9643), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9646), "Serinhisar" },
                    { 259, 20, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9649), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9651), "Pamukkale" },
                    { 260, 20, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9654), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9657), "Baklan" },
                    { 261, 20, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9660), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9662), "Beyağaç" },
                    { 262, 20, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9665), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9668), "Bozkurt / Denizli" },
                    { 263, 20, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9671), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9674), "Merkezefendi" },
                    { 264, 21, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9677), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9680), "Bismil" },
                    { 265, 21, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9683), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9686), "Çermik" },
                    { 266, 21, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9690), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9693), "Çınar" },
                    { 267, 21, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9696), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9698), "Çüngüş" },
                    { 268, 21, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9702), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9704), "Dicle" },
                    { 269, 21, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9708), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9710), "Ergani" },
                    { 270, 21, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9713), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9716), "Hani" },
                    { 271, 21, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9719), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9721), "Hazro" },
                    { 302, 24, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9933), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9936), "Erzincan Merkez" },
                    { 243, 19, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9414), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9417), "Laçin" },
                    { 303, 24, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9939), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9941), "İliç" },
                    { 305, 24, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9950), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9953), "Kemaliye" },
                    { 337, 26, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(175), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(177), "Beylikova" },
                    { 338, 26, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(180), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(183), "İnönü" },
                    { 339, 26, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(186), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(188), "Günyüzü" },
                    { 340, 26, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(192), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(194), "Han" },
                    { 341, 26, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(197), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(200), "Mihalgazi" },
                    { 342, 26, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(203), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(205), "Odunpazarı" },
                    { 343, 26, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(208), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(211), "Tepebaşı" },
                    { 344, 27, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(214), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(216), "Araban" },
                    { 345, 27, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(219), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(222), "İslahiye" },
                    { 346, 27, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(225), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(227), "Nizip" },
                    { 347, 27, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(231), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(233), "Oğuzeli" },
                    { 348, 27, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(236), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(239), "Yavuzeli" },
                    { 336, 26, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(169), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(172), "Alpu" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 349, 27, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(242), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(244), "Şahinbey" },
                    { 351, 27, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(253), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(256), "Karkamış" },
                    { 352, 27, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(259), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(261), "Nurdağı" },
                    { 353, 28, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(264), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(267), "Alucra" },
                    { 354, 28, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(270), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(272), "Bulancak" },
                    { 355, 28, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(275), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(278), "Dereli" },
                    { 356, 28, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(282), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(284), "Espiye" },
                    { 357, 28, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(288), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(290), "Eynesil" },
                    { 358, 28, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(293), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(296), "Giresun Merkez" },
                    { 359, 28, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(299), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(301), "Görele" },
                    { 360, 28, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(304), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(307), "Keşap" },
                    { 361, 28, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(310), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(312), "Şebinkarahisar" },
                    { 362, 28, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(315), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(318), "Tirebolu" },
                    { 350, 27, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(248), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(250), "Şehitkamil" },
                    { 335, 26, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(164), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(166), "Sivrihisar" },
                    { 334, 26, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(158), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(161), "Seyitgazi" },
                    { 333, 26, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(153), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(155), "Sarıcakaya" },
                    { 306, 24, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9956), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9958), "Refahiye" },
                    { 307, 24, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9961), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9964), "Tercan" },
                    { 308, 24, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9967), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9970), "Üzümlü" },
                    { 309, 24, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9973), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9975), "Otlukbeli" },
                    { 310, 25, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9978), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9981), "Aşkale" },
                    { 311, 25, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9984), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9986), "Çat" },
                    { 312, 25, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9991), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9993), "Hınıs" },
                    { 313, 25, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9996), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9999), "Horasan" },
                    { 314, 25, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(2), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5), "İspir" },
                    { 315, 25, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(8), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(10), "Karayazı" },
                    { 316, 25, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(13), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(16), "Narman" },
                    { 317, 25, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(19), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(21), "Oltu" },
                    { 318, 25, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(25), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(27), "Olur" },
                    { 319, 25, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(30), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(33), "Pasinler" },
                    { 320, 25, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(36), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(38), "Şenkaya" },
                    { 321, 25, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(41), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(44), "Tekman" },
                    { 322, 25, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(47), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(49), "Tortum" },
                    { 323, 25, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(53), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(55), "Karaçoban" },
                    { 324, 25, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(58), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(61), "Uzundere" },
                    { 325, 25, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(64), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(66), "Pazaryolu" },
                    { 326, 25, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(70), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(73), "Aziziye" },
                    { 327, 25, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(76), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(78), "Köprüköy" },
                    { 328, 25, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(81), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(84), "Palandöken" },
                    { 329, 25, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(130), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(133), "Yakutiye" },
                    { 330, 26, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(136), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(138), "Çifteler" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 331, 26, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(141), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(144), "Mahmudiye" },
                    { 332, 26, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(147), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(149), "Mihalıççık" },
                    { 304, 24, new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9945), new DateTime(2022, 1, 31, 22, 58, 51, 975, DateTimeKind.Local).AddTicks(9947), "Kemah" },
                    { 970, 81, new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5988), new DateTime(2022, 1, 31, 22, 58, 51, 976, DateTimeKind.Local).AddTicks(5990), "Kaynaşlı" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_DistrictId",
                table: "Companies",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_MembershipId",
                table: "Companies",
                column: "MembershipId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CityId",
                table: "Districts",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CommentId",
                table: "Employees",
                column: "CommentId",
                unique: true,
                filter: "[CommentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CompanyId",
                table: "Employees",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DistrictId",
                table: "Employees",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ManagerId",
                table: "Employees",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TitleId",
                table: "Employees",
                column: "TitleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Holidays");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Memberships");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
