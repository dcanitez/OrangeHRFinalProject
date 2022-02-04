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
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
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
                name: "ExpenseTypes",
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
                    table.PrimaryKey("PK_ExpenseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LiabilityCategories",
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
                    table.PrimaryKey("PK_LiabilityCategories", x => x.Id);
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
                    CommentCount = table.Column<int>(type: "int", nullable: false),
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
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    MaritalStatus = table.Column<int>(type: "int", nullable: true),
                    EducationStatus = table.Column<int>(type: "int", nullable: true),
                    GraduatedSchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraduatedDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: true),
                    NumberOfChildren = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorporateEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorporatePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FieldName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JobStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AccessType = table.Column<int>(type: "int", nullable: false),
                    ContractType = table.Column<int>(type: "int", nullable: true),
                    ContractEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Comments_Employees_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovedBy = table.Column<int>(type: "int", nullable: true),
                    ManagerFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ExpenseTypeId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 2),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_Employees_ApprovedBy",
                        column: x => x.ApprovedBy,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Expenses_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Expenses_ExpenseTypes_ExpenseTypeId",
                        column: x => x.ExpenseTypeId,
                        principalTable: "ExpenseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Holidays_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Liabilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    GivenDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TakenDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: true),
                    ManagerFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liabilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Liabilities_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Liabilities_Employees_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Liabilities_LiabilityCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "LiabilityCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermissionTypeId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 2),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false),
                    ManagerFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        name: "FK_Permissions_Employees_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Permissions_PermissionTypes_PermissionTypeId",
                        column: x => x.PermissionTypeId,
                        principalTable: "PermissionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ShiftStartDate = table.Column<DateTime>(type: "date", nullable: false),
                    ShiftEndDate = table.Column<DateTime>(type: "date", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false),
                    ManagerFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shifts_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shifts_Employees_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpenseId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receipts_Expenses_ExpenseId",
                        column: x => x.ExpenseId,
                        principalTable: "Expenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Breaks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ShiftId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breaks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Breaks_Shifts_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "afa88c7a-aa9e-4051-b5c9-9c63d6dc0941", "admin", "ADMIN" },
                    { 2, "b7f21495-73f2-4d87-a3f5-241dfea25890", "manager", "MANAGER" },
                    { 3, "1ba81670-0e44-4aff-b913-c7dda7b670b6", "personel", "PERSONEL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FieldName", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "74f0dc6d-27b5-4bc9-9bd1-bbb289961a82", "admin@mail.com", true, null, null, true, null, false, null, "admin@mail.com", "ADMIN", "AQAAAAEAACcQAAAAEE6gZJjIUxD+Kmt9CDovomLotN/yY6PIStuO9VAabVmiax0/64x9249dhQ38YbcbSw==", null, false, "df350028-d905-4886-98cb-3e800e7fe423", false, "admin" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[] { 1, new DateTime(2022, 2, 4, 21, 10, 32, 255, DateTimeKind.Local).AddTicks(9267), new DateTime(2022, 2, 4, 21, 10, 32, 255, DateTimeKind.Local).AddTicks(9321), "Türkiye" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "Description", "LastModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 4, 21, 10, 32, 258, DateTimeKind.Local).AddTicks(1292), "Bilgi İşlem", new DateTime(2022, 2, 4, 21, 10, 32, 258, DateTimeKind.Local).AddTicks(1344) },
                    { 2, new DateTime(2022, 2, 4, 21, 10, 32, 258, DateTimeKind.Local).AddTicks(2389), "Halkla İlişkiler", new DateTime(2022, 2, 4, 21, 10, 32, 258, DateTimeKind.Local).AddTicks(2408) },
                    { 3, new DateTime(2022, 2, 4, 21, 10, 32, 258, DateTimeKind.Local).AddTicks(2416), "İnsan Kaynakları", new DateTime(2022, 2, 4, 21, 10, 32, 258, DateTimeKind.Local).AddTicks(2420) },
                    { 4, new DateTime(2022, 2, 4, 21, 10, 32, 258, DateTimeKind.Local).AddTicks(2426), "Muhasebe ve Finans", new DateTime(2022, 2, 4, 21, 10, 32, 258, DateTimeKind.Local).AddTicks(2430) },
                    { 5, new DateTime(2022, 2, 4, 21, 10, 32, 258, DateTimeKind.Local).AddTicks(2435), "Müşteri Hizmetleri", new DateTime(2022, 2, 4, 21, 10, 32, 258, DateTimeKind.Local).AddTicks(2440) },
                    { 6, new DateTime(2022, 2, 4, 21, 10, 32, 258, DateTimeKind.Local).AddTicks(2445), "Satış Pazarlama", new DateTime(2022, 2, 4, 21, 10, 32, 258, DateTimeKind.Local).AddTicks(2449) },
                    { 7, new DateTime(2022, 2, 4, 21, 10, 32, 258, DateTimeKind.Local).AddTicks(2454), "Yönetim", new DateTime(2022, 2, 4, 21, 10, 32, 258, DateTimeKind.Local).AddTicks(2458) }
                });

            migrationBuilder.InsertData(
                table: "ExpenseTypes",
                columns: new[] { "Id", "CreatedDate", "Description", "LastModifiedDate" },
                values: new object[,]
                {
                    { 8, new DateTime(2022, 2, 4, 21, 10, 32, 354, DateTimeKind.Local).AddTicks(4100), "Yakacak Yardımı", new DateTime(2022, 2, 4, 21, 10, 32, 354, DateTimeKind.Local).AddTicks(4104) },
                    { 6, new DateTime(2022, 2, 4, 21, 10, 32, 354, DateTimeKind.Local).AddTicks(4080), "Askerlik Yardımı", new DateTime(2022, 2, 4, 21, 10, 32, 354, DateTimeKind.Local).AddTicks(4084) },
                    { 5, new DateTime(2022, 2, 4, 21, 10, 32, 354, DateTimeKind.Local).AddTicks(4070), "İcra", new DateTime(2022, 2, 4, 21, 10, 32, 354, DateTimeKind.Local).AddTicks(4075) },
                    { 7, new DateTime(2022, 2, 4, 21, 10, 32, 354, DateTimeKind.Local).AddTicks(4090), "Bayram Yardımı", new DateTime(2022, 2, 4, 21, 10, 32, 354, DateTimeKind.Local).AddTicks(4094) },
                    { 3, new DateTime(2022, 2, 4, 21, 10, 32, 354, DateTimeKind.Local).AddTicks(4049), "Prim", new DateTime(2022, 2, 4, 21, 10, 32, 354, DateTimeKind.Local).AddTicks(4054) },
                    { 2, new DateTime(2022, 2, 4, 21, 10, 32, 354, DateTimeKind.Local).AddTicks(4021), "Avans", new DateTime(2022, 2, 4, 21, 10, 32, 354, DateTimeKind.Local).AddTicks(4041) },
                    { 1, new DateTime(2022, 2, 4, 21, 10, 32, 354, DateTimeKind.Local).AddTicks(2827), "Harcama", new DateTime(2022, 2, 4, 21, 10, 32, 354, DateTimeKind.Local).AddTicks(2884) },
                    { 4, new DateTime(2022, 2, 4, 21, 10, 32, 354, DateTimeKind.Local).AddTicks(4059), "Mesai", new DateTime(2022, 2, 4, 21, 10, 32, 354, DateTimeKind.Local).AddTicks(4064) }
                });

            migrationBuilder.InsertData(
                table: "Holidays",
                columns: new[] { "Id", "CreatedDate", "Description", "EmployeeId", "EndDate", "LastModifiedDate", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 4, 21, 10, 32, 355, DateTimeKind.Local).AddTicks(9936), "Yeni Yıl Tatili", null, new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 4, 21, 10, 32, 355, DateTimeKind.Local).AddTicks(9994), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2022, 2, 4, 21, 10, 32, 356, DateTimeKind.Local).AddTicks(2134), "Ulusal Egemenlik ve Çocuk Bayramı", null, new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 4, 21, 10, 32, 356, DateTimeKind.Local).AddTicks(2163), new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2022, 2, 4, 21, 10, 32, 356, DateTimeKind.Local).AddTicks(2168), "Emek ve Dayanışma Günü", null, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 4, 21, 10, 32, 356, DateTimeKind.Local).AddTicks(2171), new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2022, 2, 4, 21, 10, 32, 356, DateTimeKind.Local).AddTicks(2175), "Ramazan Bayramı", null, new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 4, 21, 10, 32, 356, DateTimeKind.Local).AddTicks(2177), new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2022, 2, 4, 21, 10, 32, 356, DateTimeKind.Local).AddTicks(2180), "Atatürk'ü Anma Gençlik ve Spor Bayramı", null, new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 4, 21, 10, 32, 356, DateTimeKind.Local).AddTicks(2183), new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2022, 2, 4, 21, 10, 32, 356, DateTimeKind.Local).AddTicks(2186), "Kurban Bayramı", null, new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 4, 21, 10, 32, 356, DateTimeKind.Local).AddTicks(2188), new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LiabilityCategories",
                columns: new[] { "Id", "CreatedDate", "Description", "LastModifiedDate" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 2, 4, 21, 10, 32, 358, DateTimeKind.Local).AddTicks(1686), "Araç", new DateTime(2022, 2, 4, 21, 10, 32, 358, DateTimeKind.Local).AddTicks(1690) },
                    { 1, new DateTime(2022, 2, 4, 21, 10, 32, 358, DateTimeKind.Local).AddTicks(415), "Bilgisayar", new DateTime(2022, 2, 4, 21, 10, 32, 358, DateTimeKind.Local).AddTicks(472) },
                    { 2, new DateTime(2022, 2, 4, 21, 10, 32, 358, DateTimeKind.Local).AddTicks(1657), "Cep Telefonu", new DateTime(2022, 2, 4, 21, 10, 32, 358, DateTimeKind.Local).AddTicks(1678) }
                });

            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "Id", "CreatedDate", "Description", "Duration", "LastModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 4, 21, 10, 32, 360, DateTimeKind.Local).AddTicks(9848), "Aylık Üyelik", 30, new DateTime(2022, 2, 4, 21, 10, 32, 360, DateTimeKind.Local).AddTicks(9896) },
                    { 2, new DateTime(2022, 2, 4, 21, 10, 32, 361, DateTimeKind.Local).AddTicks(1839), "Yıllık Üyelik", 365, new DateTime(2022, 2, 4, 21, 10, 32, 361, DateTimeKind.Local).AddTicks(1858) }
                });

            migrationBuilder.InsertData(
                table: "PermissionTypes",
                columns: new[] { "Id", "CreatedDate", "Description", "LastModifiedDate" },
                values: new object[,]
                {
                    { 9, new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6584), "Askerlik İzni", new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6592) },
                    { 13, new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6650), "Ücretsiz İzin", new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6658) },
                    { 12, new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6633), "Hastalık İzni", new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6640) },
                    { 11, new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6617), "Yol İzni", new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6625) },
                    { 10, new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6599), "Babalık İzni", new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6609) },
                    { 8, new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6568), "Doğum İzni", new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6574) },
                    { 2, new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6494), "Doğum Sonrası İzni", new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6516) },
                    { 6, new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6551), "İş Arama İzni", new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6554) },
                    { 5, new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6542), "Mazeret İzni", new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6546) },
                    { 4, new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6534), "Süt İzni", new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6537) },
                    { 3, new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6526), "Vefat İzni", new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6530) }
                });

            migrationBuilder.InsertData(
                table: "PermissionTypes",
                columns: new[] { "Id", "CreatedDate", "Description", "LastModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(5174), "Yıllık İzin", new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(5233) },
                    { 7, new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6560), "Evlilik İzni", new DateTime(2022, 2, 4, 21, 10, 32, 365, DateTimeKind.Local).AddTicks(6564) }
                });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "Id", "CreatedDate", "Description", "LastModifiedDate" },
                values: new object[,]
                {
                    { 19, new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1582), "Teknik Destek Uzmanı", new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1587) },
                    { 18, new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1484), "Sistem Yöneticisi", new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1492) },
                    { 17, new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1467), "Satış Temsilcisi", new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1475) },
                    { 16, new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1409), "Personel Müdürü", new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1453) },
                    { 15, new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1388), "Müşteri İlişkileri Sorumlusu", new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1395) },
                    { 14, new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1375), "Muhasebe Sorumlusu", new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1379) },
                    { 13, new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1367), "Muhasebe Asistanı", new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1371) },
                    { 12, new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1359), "Maliye Sorumlusu", new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1363) },
                    { 11, new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1350), "Kurumsal Satış Sorumlusu", new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1355) },
                    { 8, new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1326), "İnsan Kaynakları Direktörü", new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1330) },
                    { 9, new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1334), "Kurumsal İletişim Uzmanı", new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1338) },
                    { 7, new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1317), "İnsan Kaynakları Asistanı", new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1321) },
                    { 6, new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1308), "Hesap Yöneticisi", new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1312) },
                    { 5, new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1299), "Halkla İlişkiler Uzmanı", new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1303) },
                    { 4, new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1291), "Genel Müdür Yardımcısı", new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1295) },
                    { 3, new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1282), "Genel Müdür", new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1285) },
                    { 2, new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1254), "Destek Uzmanı", new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1273) },
                    { 1, new DateTime(2022, 2, 4, 21, 10, 32, 372, DateTimeKind.Local).AddTicks(9903), "Araştırma Mühendisi", new DateTime(2022, 2, 4, 21, 10, 32, 372, DateTimeKind.Local).AddTicks(9975) },
                    { 20, new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1592), "Veritabanı Uzmanı", new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1595) },
                    { 10, new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1342), "Kurumsal Satış Müdürü", new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1346) },
                    { 21, new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1600), "Yazılım Mühendisi", new DateTime(2022, 2, 4, 21, 10, 32, 373, DateTimeKind.Local).AddTicks(1603) }
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
                    { 58, "Sivas", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7832), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7836) },
                    { 57, "Sinop", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7825), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7828) },
                    { 56, "Siirt", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7817), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7820) },
                    { 55, "Samsun", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7809), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7812) },
                    { 54, "Sakarya", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7800), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7804) },
                    { 53, "Rize", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7792), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7796) },
                    { 52, "Ordu", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7785), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7788) },
                    { 59, "Tekirdağ", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7840), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7843) },
                    { 51, "Niğde", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7778), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7782) },
                    { 49, "Muş", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7762), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7765) },
                    { 48, "Muğla", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7755), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7758) },
                    { 47, "Mardin", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7748), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7752) },
                    { 46, "Kahramanmaraş", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7741), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7745) },
                    { 45, "Manisa", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7729), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7737) },
                    { 44, "Malatya", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7688), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7698) },
                    { 43, "Kütahya", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7674), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7677) },
                    { 50, "Nevşehir", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7770), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7774) },
                    { 60, "Tokat", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7847), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7850) },
                    { 61, "Trabzon", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7855), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7858) },
                    { 62, "Tunceli", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7862), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7867) },
                    { 79, "Kilis", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8177), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8187) },
                    { 78, "Karabük", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8138), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8148) },
                    { 77, "Yalova", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8118), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8128) },
                    { 76, "Iğdır", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8112), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8115) },
                    { 75, "Ardahan", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8105), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8108) },
                    { 74, "Bartın", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8098), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8101) },
                    { 73, "Şırnak", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8090), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8094) },
                    { 72, "Batman", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8082), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8086) },
                    { 71, "Kırıkkale", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8073), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8077) },
                    { 70, "Karaman", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8065), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8069) },
                    { 69, "Bayburt", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8053), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8060) },
                    { 68, "Aksaray", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7909), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7913) },
                    { 67, "Zonguldak", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7902), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7905) },
                    { 66, "Yozgat", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7895), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7898) },
                    { 65, "Van", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7886), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7889) },
                    { 64, "Uşak", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7878), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7882) },
                    { 63, "Şanlıurfa", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7871), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7874) },
                    { 42, "Konya", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7667), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7670) },
                    { 41, "Kocaeli", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7651), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7658) },
                    { 40, "Kırşehir", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7644), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7647) },
                    { 39, "Kırklareli", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7636), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7640) }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityName", "CountryId", "CreatedDate", "LastModifiedDate" },
                values: new object[,]
                {
                    { 17, "Çanakkale", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7449), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7452) },
                    { 16, "Bursa", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7442), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7445) },
                    { 15, "Burdur", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7436), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7439) },
                    { 14, "Bolu", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7429), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7432) },
                    { 13, "Bitlis", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7421), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7424) },
                    { 12, "Bingöl", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7401), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7412) },
                    { 11, "Bilecik", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7232), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7235) },
                    { 10, "Balıkesir", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7224), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7228) },
                    { 9, "Aydın", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7215), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7219) },
                    { 8, "Artvin", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7207), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7210) },
                    { 7, "Antalya", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7199), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7203) },
                    { 6, "Ankara", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7192), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7195) },
                    { 5, "Amasya", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7183), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7187) },
                    { 4, "Ağrı", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7175), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7179) },
                    { 3, "Afyonkarahisar", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(6913), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7160) },
                    { 2, "Adıyaman", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(6858), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(6900) },
                    { 1, "Adana", 1, new DateTime(2022, 2, 4, 21, 10, 32, 241, DateTimeKind.Local).AddTicks(8622), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(3556) },
                    { 18, "Çankırı", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7464), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7467) },
                    { 80, "Osmaniye", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8193), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8197) },
                    { 19, "Çorum", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7471), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7474) },
                    { 21, "Diyarbakır", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7484), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7487) },
                    { 38, "Kayseri", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7628), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7631) },
                    { 37, "Kastamonu", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7621), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7624) },
                    { 36, "Kars", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7614), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7617) },
                    { 35, "İzmir", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7606), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7609) },
                    { 34, "İstanbul", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7598), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7601) },
                    { 33, "Mersin", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7590), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7594) },
                    { 32, "Isparta", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7582), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7585) },
                    { 31, "Hatay", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7575), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7578) },
                    { 30, "Hakkari", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7569), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7572) },
                    { 29, "Gümüşhane", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7556), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7564) },
                    { 28, "Giresun", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7542), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7545) },
                    { 27, "Gaziantep", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7535), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7537) },
                    { 26, "Eskişehir", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7528), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7531) },
                    { 25, "Erzurum", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7521), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7524) },
                    { 24, "Erzincan", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7514), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7517) },
                    { 23, "Elazığ", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7507), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7510) },
                    { 22, "Edirne", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7491), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7495) },
                    { 20, "Denizli", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7477), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(7480) },
                    { 81, "Düzce", 1, new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8201), new DateTime(2022, 2, 4, 21, 10, 32, 247, DateTimeKind.Local).AddTicks(8205) }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(655), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(716), "Seyhan" },
                    { 639, 46, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(708), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(711), "Türkoğlu" },
                    { 640, 46, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(718), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(721), "Çağlayancerit" },
                    { 641, 46, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(726), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(730), "Ekinözü" },
                    { 642, 46, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(735), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(739), "Nurhak" },
                    { 643, 46, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(744), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(747), "Dulkadiroğlu" },
                    { 644, 46, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(754), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(758), "Onikişubat" },
                    { 645, 47, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(763), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(767), "Derik" },
                    { 646, 47, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(772), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(776), "Kızıltepe" },
                    { 647, 47, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(781), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(785), "Mazıdağı" },
                    { 648, 47, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(790), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(794), "Midyat" },
                    { 649, 47, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(803), "Nusaybin" },
                    { 650, 47, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(808), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(813), "Ömerli" },
                    { 638, 46, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(700), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(704), "Pazarcık" },
                    { 651, 47, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(817), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(821), "Savur" },
                    { 653, 47, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(835), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(839), "Yeşilli" },
                    { 654, 47, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(845), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(849), "Artuklu" },
                    { 655, 48, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(854), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(858), "Bodrum" },
                    { 656, 48, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(864), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(868), "Datça" },
                    { 657, 48, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(874), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(879), "Fethiye" },
                    { 658, 48, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(885), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(889), "Köyceğiz" },
                    { 659, 48, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(894), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(898), "Marmaris" },
                    { 660, 48, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(903), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(907), "Milas" },
                    { 661, 48, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(912), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(915), "Ula" },
                    { 662, 48, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(920), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(923), "Yatağan" },
                    { 663, 48, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(928), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(931), "Dalaman" },
                    { 664, 48, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(938), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(941), "Ortaca" },
                    { 652, 47, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(826), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(830), "Dargeçit" },
                    { 665, 48, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(945), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(948), "Kavaklıdere" },
                    { 637, 46, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(692), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(695), "Göksun" },
                    { 635, 46, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(675), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(679), "Andırın" },
                    { 609, 44, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(381), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(385), "Hekimhan" },
                    { 610, 44, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(391), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(394), "Pütürge" },
                    { 611, 44, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(399), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(403), "Yeşilyurt / Malatya" },
                    { 612, 44, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(408), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(412), "Battalgazi" },
                    { 613, 44, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(418), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(422), "Doğanyol" },
                    { 614, 44, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(428), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(431), "Kale / Malatya" },
                    { 615, 44, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(437), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(440), "Kuluncak" },
                    { 616, 44, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(445), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(449), "Yazıhan" },
                    { 617, 45, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(454), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(459), "Akhisar" },
                    { 618, 45, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(464), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(468), "Alaşehir" },
                    { 619, 45, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(473), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(477), "Demirci" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 620, 45, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(482), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(486), "Gördes" },
                    { 636, 46, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(684), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(687), "Elbistan" },
                    { 621, 45, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(490), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(493), "Kırkağaç" },
                    { 623, 45, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(507), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(512), "Salihli" },
                    { 624, 45, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(518), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(522), "Sarıgöl" },
                    { 625, 45, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(527), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(531), "Saruhanlı" },
                    { 626, 45, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(537), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(541), "Selendi" },
                    { 627, 45, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(547), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(551), "Soma" },
                    { 628, 45, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(555), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(559), "Turgutlu" },
                    { 629, 45, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(565), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(569), "Ahmetli" },
                    { 630, 45, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(574), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(579), "Gölmarmara" },
                    { 631, 45, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(585), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(588), "Köprübaşı / Manisa" },
                    { 632, 45, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(594), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(598), "Şehzadeler" },
                    { 633, 45, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(603), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(607), "Yunusemre" },
                    { 634, 46, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(664), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(670), "Afşin" },
                    { 622, 45, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(498), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(503), "Kula" },
                    { 666, 48, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(953), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(957), "Menteşe" },
                    { 667, 48, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(963), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(967), "Seydikemer" },
                    { 668, 49, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(971), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(974), "Bulanık" },
                    { 700, 52, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1223), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1226), "Çamaş" },
                    { 701, 52, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1229), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1231), "Çatalpınar" },
                    { 702, 52, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1234), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1237), "Çaybaşı" },
                    { 703, 52, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1240), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1242), "İkizce" },
                    { 704, 52, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1246), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1248), "Kabadüz" },
                    { 705, 52, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1251), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1254), "Kabataş" },
                    { 706, 52, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1257), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1259), "Altınordu" },
                    { 707, 53, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1303), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1306), "Ardeşen" },
                    { 708, 53, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1309), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1312), "Çamlıhemşin" },
                    { 709, 53, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1315), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1317), "Çayeli" },
                    { 710, 53, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1320), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1323), "Fındıklı" },
                    { 711, 53, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1326), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1328), "İkizdere" },
                    { 699, 52, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1218), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1220), "Gürgentepe" },
                    { 712, 53, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1331), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1334), "Kalkandere" },
                    { 714, 53, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1342), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1345), "Rize Merkez" },
                    { 715, 53, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1348), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1350), "Güneysu" },
                    { 716, 53, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1354), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1356), "Derepazarı" },
                    { 717, 53, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1359), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1361), "Hemşin" },
                    { 718, 53, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1365), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1367), "İyidere" },
                    { 719, 54, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1370), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1373), "Akyazı" },
                    { 720, 54, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1376), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1379), "Geyve" },
                    { 721, 54, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1382), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1384), "Hendek" },
                    { 722, 54, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1387), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1390), "Karasu" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 723, 54, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1393), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1395), "Kaynarca" },
                    { 724, 54, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1398), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1401), "Sapanca" },
                    { 725, 54, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1404), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1406), "Kocaali" },
                    { 713, 53, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1337), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1339), "Pazar / Rize" },
                    { 698, 52, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1211), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1214), "Gülyalı" },
                    { 697, 52, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1206), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1208), "Ünye" },
                    { 696, 52, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1200), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1203), "Ulubey / Ordu" },
                    { 669, 49, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(979), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(982), "Malazgirt" },
                    { 670, 49, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(986), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(990), "Muş Merkez" },
                    { 671, 49, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1053), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1057), "Varto" },
                    { 672, 49, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1061), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1064), "Hasköy" },
                    { 673, 49, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1067), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1070), "Korkut" },
                    { 674, 50, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1074), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1077), "Avanos" },
                    { 675, 50, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1080), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1082), "Derinkuyu" },
                    { 676, 50, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1085), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1088), "Gülşehir" },
                    { 677, 50, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1091), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1094), "Hacıbektaş" },
                    { 678, 50, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1097), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1100), "Kozaklı" },
                    { 679, 50, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1103), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1105), "Nevşehir Merkez" },
                    { 680, 50, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1109), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1112), "Ürgüp" },
                    { 681, 50, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1115), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1117), "Acıgöl" },
                    { 682, 51, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1121), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1123), "Bor" },
                    { 683, 51, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1126), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1129), "Çamardı" },
                    { 684, 51, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1132), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1134), "Niğde Merkez" },
                    { 685, 51, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1137), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1140), "Ulukışla" },
                    { 686, 51, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1143), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1145), "Altunhisar" },
                    { 687, 51, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1148), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1151), "Çiftlik" },
                    { 688, 52, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1154), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1156), "Akkuş" },
                    { 689, 52, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1159), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1162), "Aybastı" },
                    { 690, 52, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1165), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1167), "Fatsa" },
                    { 691, 52, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1171), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1173), "Gölköy" },
                    { 692, 52, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1176), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1179), "Korgan" },
                    { 693, 52, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1182), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1184), "Kumru" },
                    { 694, 52, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1188), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1190), "Mesudiye" },
                    { 695, 52, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1193), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1196), "Perşembe" },
                    { 608, 44, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(371), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(376), "Doğanşehir" },
                    { 726, 54, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1409), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1412), "Pamukova" },
                    { 607, 44, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(361), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(365), "Darende" },
                    { 605, 44, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(343), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(347), "Arapgir" },
                    { 518, 38, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9365), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9369), "Develi" },
                    { 519, 38, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9374), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9378), "Felahiye" },
                    { 520, 38, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9384), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9388), "İncesu" },
                    { 521, 38, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9392), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9396), "Pınarbaşı / Kayseri" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 522, 38, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9402), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9406), "Sarıoğlan" },
                    { 523, 38, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9411), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9415), "Sarız" },
                    { 524, 38, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9420), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9424), "Tomarza" },
                    { 525, 38, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9487), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9493), "Yahyalı" },
                    { 526, 38, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9499), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9503), "Yeşilhisar" },
                    { 527, 38, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9508), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9513), "Akkışla" },
                    { 528, 38, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9519), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9523), "Talas" },
                    { 529, 38, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9527), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9531), "Kocasinan" },
                    { 517, 38, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9356), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9360), "Bünyan" },
                    { 530, 38, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9535), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9538), "Melikgazi" },
                    { 532, 38, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9551), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9555), "Özvatan" },
                    { 533, 39, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9560), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9564), "Babaeski" },
                    { 534, 39, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9568), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9572), "Demirköy" },
                    { 535, 39, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9576), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9580), "Kırklareli Merkez" },
                    { 536, 39, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9585), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9589), "Kofçaz" },
                    { 537, 39, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9593), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9597), "Lüleburgaz" },
                    { 538, 39, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9602), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9606), "Pehlivanköy" },
                    { 539, 39, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9610), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9614), "Pınarhisar" },
                    { 540, 39, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9619), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9622), "Vize" },
                    { 541, 40, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9627), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9631), "Çiçekdağı" },
                    { 542, 40, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9636), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9640), "Kaman" },
                    { 543, 40, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9645), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9649), "Kırşehir Merkez" },
                    { 531, 38, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9543), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9546), "Hacılar" },
                    { 544, 40, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9655), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9659), "Mucur" },
                    { 516, 37, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9347), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9351), "Seydiler" },
                    { 514, 37, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9330), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9334), "Doğanyurt" },
                    { 488, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9040), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9044), "Karabağlar" },
                    { 489, 36, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9102), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9108), "Arpaçay" },
                    { 490, 36, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9114), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9118), "Digor" },
                    { 491, 36, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9123), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9127), "Kağızman" },
                    { 492, 36, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9132), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9136), "Kars Merkez" },
                    { 493, 36, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9140), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9144), "Sarıkamış" },
                    { 494, 36, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9149), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9153), "Selim" },
                    { 495, 36, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9160), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9165), "Susuz" },
                    { 496, 36, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9171), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9174), "Akyaka" },
                    { 497, 37, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9179), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9183), "Abana" },
                    { 498, 37, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9188), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9192), "Araç" },
                    { 499, 37, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9197), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9201), "Azdavay" },
                    { 515, 37, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9338), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9342), "Hanönü" },
                    { 500, 37, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9206), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9210), "Bozkurt / Kastamonu" },
                    { 502, 37, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9223), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9229), "Çatalzeytin" },
                    { 503, 37, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9234), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9238), "Daday" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 504, 37, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9244), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9247), "Devrekani" },
                    { 505, 37, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9252), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9256), "İnebolu" },
                    { 506, 37, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9261), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9265), "Kastamonu Merkez" },
                    { 507, 37, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9270), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9273), "Küre" },
                    { 508, 37, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9278), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9282), "Taşköprü" },
                    { 509, 37, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9287), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9290), "Tosya" },
                    { 510, 37, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9295), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9299), "İhsangazi" },
                    { 511, 37, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9303), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9307), "Pınarbaşı / Kastamonu" },
                    { 512, 37, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9313), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9316), "Şenpazar" },
                    { 513, 37, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9321), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9325), "Ağlı" },
                    { 501, 37, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9214), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9218), "Cide" },
                    { 545, 40, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9664), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9668), "Akpınar" },
                    { 546, 40, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9673), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9678), "Akçakent" },
                    { 547, 40, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9683), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9687), "Boztepe" },
                    { 579, 42, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(53), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(57), "Karatay" },
                    { 580, 42, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(62), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(65), "Meram" },
                    { 581, 42, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(70), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(75), "Selçuklu" },
                    { 582, 42, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(79), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(83), "Taşkent" },
                    { 583, 42, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(88), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(92), "Ahırlı" },
                    { 584, 42, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(100), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(104), "Çeltik" },
                    { 585, 42, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(108), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(112), "Derbent" },
                    { 586, 42, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(117), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(121), "Emirgazi" },
                    { 587, 42, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(126), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(130), "Güneysınır" },
                    { 588, 42, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(135), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(139), "Halkapınar" },
                    { 589, 42, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(144), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(148), "Tuzlukçu" },
                    { 590, 42, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(153), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(157), "Yalıhüyük" },
                    { 578, 42, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(44), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(48), "Hüyük" },
                    { 591, 43, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(163), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(166), "Altıntaş" },
                    { 593, 43, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(181), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(185), "Emet" },
                    { 594, 43, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(190), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(194), "Gediz" },
                    { 595, 43, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(200), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(204), "Kütahya Merkez" },
                    { 596, 43, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(209), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(213), "Simav" },
                    { 597, 43, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(218), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(222), "Tavşanlı" },
                    { 598, 43, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(281), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(287), "Aslanapa" },
                    { 599, 43, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(292), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(296), "Dumlupınar" },
                    { 600, 43, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(301), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(305), "Hisarcık" },
                    { 601, 43, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(309), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(312), "Şaphane" },
                    { 602, 43, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(318), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(322), "Çavdarhisar" },
                    { 603, 43, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(326), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(330), "Pazarlar" },
                    { 604, 44, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(335), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(338), "Akçadağ" },
                    { 592, 43, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(172), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(177), "Domaniç" },
                    { 577, 42, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(35), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(39), "Derebucak" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 576, 42, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(27), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(30), "Altınekin" },
                    { 575, 42, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(18), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(22), "Akören" },
                    { 548, 41, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9693), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9697), "Gebze" },
                    { 549, 41, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9702), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9706), "Gölcük" },
                    { 550, 41, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9712), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9716), "Kandıra" },
                    { 551, 41, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9722), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9725), "Karamürsel" },
                    { 552, 41, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9730), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9734), "Körfez" },
                    { 553, 41, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9739), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9743), "Derince" },
                    { 554, 41, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9749), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9753), "Başiskele" },
                    { 555, 41, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9758), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9762), "Çayırova" },
                    { 556, 41, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9767), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9771), "Darıca" },
                    { 557, 41, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9776), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9779), "Dilovası" },
                    { 558, 41, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9784), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9787), "İzmit" },
                    { 559, 41, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9793), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9796), "Kartepe" },
                    { 560, 42, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9802), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9806), "Akşehir" },
                    { 561, 42, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9895), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9901), "Beyşehir" },
                    { 562, 42, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9907), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9910), "Bozkır" },
                    { 563, 42, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9916), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9920), "Cihanbeyli" },
                    { 564, 42, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9925), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9929), "Çumra" },
                    { 565, 42, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9933), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9937), "Doğanhisar" },
                    { 566, 42, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9942), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9946), "Ereğli / Konya" },
                    { 567, 42, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9951), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9955), "Hadim" },
                    { 568, 42, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9960), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9965), "Ilgın" },
                    { 569, 42, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9969), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9973), "Kadınhanı" },
                    { 570, 42, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9978), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9981), "Karapınar" },
                    { 571, 42, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9986), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9990), "Kulu" },
                    { 572, 42, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9995), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9998), "Sarayönü" },
                    { 573, 42, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(6), "Seydişehir" },
                    { 574, 42, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(10), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(14), "Yunak" },
                    { 606, 44, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(352), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(356), "Arguvan" },
                    { 727, 54, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1415), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1417), "Taraklı" },
                    { 728, 54, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1420), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1423), "Ferizli" },
                    { 729, 54, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1426), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1428), "Karapürçek" },
                    { 882, 67, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2469), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2471), "Ereğli / Zonguldak" },
                    { 883, 67, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2475), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2477), "Zonguldak Merkez" },
                    { 884, 67, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2480), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2483), "Alaplı" },
                    { 885, 67, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2486), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2489), "Gökçebey" },
                    { 886, 67, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2492), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2494), "Kilimli" },
                    { 887, 67, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2498), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2500), "Kozlu" },
                    { 888, 68, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2503), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2506), "Aksaray Merkez" },
                    { 889, 68, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2509), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2511), "Ortaköy / Aksaray" },
                    { 890, 68, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2552), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2555), "Ağaçören" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 891, 68, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2558), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2561), "Güzelyurt" },
                    { 892, 68, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2564), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2566), "Sarıyahşi" },
                    { 893, 68, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2569), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2572), "Eskil" },
                    { 881, 67, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2463), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2466), "Devrek" },
                    { 894, 68, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2575), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2577), "Gülağaç" },
                    { 896, 69, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2586), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2589), "Aydıntepe" },
                    { 897, 69, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2592), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2594), "Demirözü" },
                    { 898, 70, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2597), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2600), "Ermenek" },
                    { 899, 70, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2603), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2605), "Karaman Merkez" },
                    { 900, 70, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2609), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2611), "Ayrancı" },
                    { 901, 70, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2614), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2617), "Kazımkarabekir" },
                    { 902, 70, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2620), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2622), "Başyayla" },
                    { 903, 70, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2625), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2628), "Sarıveliler" },
                    { 904, 71, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2631), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2634), "Delice" },
                    { 905, 71, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2637), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2639), "Keskin" },
                    { 906, 71, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2642), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2645), "Kırıkkale Merkez" },
                    { 907, 71, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2648), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2651), "Sulakyurt" },
                    { 895, 69, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2580), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2583), "Bayburt Merkez" },
                    { 908, 71, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2654), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2656), "Bahşili" },
                    { 880, 67, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2457), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2460), "Çaycuma" },
                    { 878, 66, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2446), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2448), "Saraykent" },
                    { 852, 64, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2236), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2239), "Uşak Merkez" },
                    { 853, 65, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2304), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2307), "Başkale" },
                    { 854, 65, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2310), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2313), "Çatak" },
                    { 855, 65, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2317), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2319), "Erciş" },
                    { 856, 65, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2322), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2325), "Gevaş" },
                    { 857, 65, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2328), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2331), "Gürpınar" },
                    { 858, 65, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2334), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2336), "Muradiye" },
                    { 859, 65, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2339), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2342), "Özalp" },
                    { 860, 65, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2345), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2347), "Bahçesaray" },
                    { 861, 65, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2351), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2353), "Çaldıran" },
                    { 862, 65, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2356), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2359), "Edremit / Van" },
                    { 863, 65, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2362), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2364), "Saray / Van" },
                    { 879, 66, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2451), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2454), "Yenifakılı" },
                    { 864, 65, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2367), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2370), "İpekyolu" },
                    { 866, 66, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2379), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2381), "Akdağmadeni" },
                    { 867, 66, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2384), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2387), "Boğazlıyan" },
                    { 868, 66, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2390), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2392), "Çayıralan" },
                    { 869, 66, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2395), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2398), "Çekerek" },
                    { 870, 66, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2401), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2403), "Sarıkaya" },
                    { 871, 66, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2406), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2409), "Sorgun" },
                    { 872, 66, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2412), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2415), "Şefaatli" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 873, 66, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2418), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2421), "Yerköy" },
                    { 874, 66, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2424), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2426), "Yozgat Merkez" },
                    { 875, 66, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2429), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2431), "Aydıncık / Yozgat" },
                    { 876, 66, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2435), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2437), "Çandır" },
                    { 877, 66, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2440), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2443), "Kadışehri" },
                    { 865, 65, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2373), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2376), "Tuşba" },
                    { 909, 71, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2660), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2662), "Balışeyh" },
                    { 910, 71, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2665), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2668), "Çelebi" },
                    { 911, 71, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2671), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2673), "Karakeçili" },
                    { 943, 77, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2889), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2891), "Çınarcık" },
                    { 944, 77, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2894), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2897), "Çiftlikköy" },
                    { 945, 77, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2900), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2903), "Termal" },
                    { 946, 78, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2906), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2908), "Eflani" },
                    { 947, 78, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2911), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2914), "Eskipazar" },
                    { 948, 78, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2917), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2920), "Karabük Merkez" },
                    { 949, 78, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2923), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2925), "Ovacık / Karabük" },
                    { 950, 78, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2928), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2931), "Safranbolu" },
                    { 951, 78, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2934), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2936), "Yenice / Karabük" },
                    { 952, 79, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2939), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2942), "Kilis Merkez" },
                    { 953, 79, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2945), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2947), "Elbeyli" },
                    { 954, 79, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2951), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2953), "Musabeyli" },
                    { 942, 77, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2883), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2886), "Armutlu" },
                    { 955, 79, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2956), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2959), "Polateli" },
                    { 957, 80, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2968), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2970), "Kadirli" },
                    { 958, 80, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2973), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2976), "Osmaniye Merkez" },
                    { 959, 80, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2979), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2981), "Düziçi" },
                    { 960, 80, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2984), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2987), "Hasanbeyli" },
                    { 961, 80, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2990), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2992), "Sumbas" },
                    { 962, 80, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2995), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2998), "Toprakkale" },
                    { 963, 81, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(3038), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(3041), "Akçakoca" },
                    { 964, 81, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(3044), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(3046), "Düzce Merkez" },
                    { 965, 81, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(3049), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(3052), "Yığılca" },
                    { 966, 81, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(3055), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(3057), "Cumayeri" },
                    { 967, 81, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(3060), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(3063), "Gölyaka" },
                    { 968, 81, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(3066), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(3068), "Çilimli" },
                    { 956, 80, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2962), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2965), "Bahçe" },
                    { 941, 77, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2878), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2880), "Altınova" },
                    { 940, 77, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2872), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2875), "Yalova Merkez" },
                    { 939, 76, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2866), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2869), "Karakoyunlu" },
                    { 912, 71, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2676), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2679), "Yahşihan" },
                    { 913, 72, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2682), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2685), "Batman Merkez" },
                    { 914, 72, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2688), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2690), "Beşiri" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 915, 72, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2694), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2696), "Gercüş" },
                    { 916, 72, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2699), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2702), "Kozluk" },
                    { 917, 72, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2705), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2708), "Sason" },
                    { 918, 72, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2711), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2713), "Hasankeyf" },
                    { 919, 73, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2716), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2719), "Beytüşşebap" },
                    { 920, 73, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2722), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2725), "Cizre" },
                    { 921, 73, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2728), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2730), "İdil" },
                    { 922, 73, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2733), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2736), "Silopi" },
                    { 923, 73, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2739), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2742), "Şırnak Merkez" },
                    { 924, 73, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2745), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2747), "Uludere" },
                    { 925, 73, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2750), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2753), "Güçlükonak" },
                    { 926, 74, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2792), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2795), "Bartın Merkez" },
                    { 927, 74, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2798), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2801), "Kurucaşile" },
                    { 928, 74, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2804), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2806), "Ulus" },
                    { 929, 74, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2810), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2812), "Amasra" },
                    { 930, 75, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2815), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2818), "Ardahan Merkez" },
                    { 931, 75, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2821), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2823), "Çıldır" },
                    { 932, 75, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2826), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2829), "Göle" },
                    { 933, 75, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2832), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2834), "Hanak" },
                    { 934, 75, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2837), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2840), "Posof" },
                    { 935, 75, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2843), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2845), "Damal" },
                    { 936, 76, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2848), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2852), "Aralık" },
                    { 937, 76, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2855), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2857), "Iğdır Merkez" },
                    { 938, 76, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2860), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2863), "Tuzluca" },
                    { 851, 64, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2231), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2233), "Ulubey / Uşak" },
                    { 850, 64, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2224), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2227), "Sivaslı" },
                    { 849, 64, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2219), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2221), "Karahallı" },
                    { 848, 64, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2213), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2216), "Eşme" },
                    { 761, 57, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1643), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1645), "Durağan" },
                    { 762, 57, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1648), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1650), "Erfelek" },
                    { 763, 57, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1654), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1656), "Gerze" },
                    { 764, 57, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1660), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1663), "Sinop Merkez" },
                    { 765, 57, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1666), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1668), "Türkeli" },
                    { 766, 57, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1672), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1674), "Dikmen" },
                    { 767, 57, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1677), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1680), "Saraydüzü" },
                    { 768, 58, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1683), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1685), "Divriği" },
                    { 769, 58, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1688), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1691), "Gemerek" },
                    { 770, 58, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1694), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1696), "Gürün" },
                    { 771, 58, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1699), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1702), "Hafik" },
                    { 772, 58, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1705), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1707), "İmranlı" },
                    { 760, 57, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1637), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1639), "Boyabat" },
                    { 773, 58, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1710), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1713), "Kangal" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 775, 58, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1721), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1724), "Sivas Merkez" },
                    { 776, 58, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1727), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1729), "Suşehri" },
                    { 777, 58, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1732), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1735), "Şarkışla" },
                    { 778, 58, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1738), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1740), "Yıldızeli" },
                    { 779, 58, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1743), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1746), "Zara" },
                    { 780, 58, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1785), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1787), "Akıncılar" },
                    { 781, 58, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1791), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1793), "Altınyayla / Sivas" },
                    { 782, 58, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1797), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1800), "Doğanşar" },
                    { 783, 58, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1805), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1807), "Gölova" },
                    { 784, 58, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1810), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1813), "Ulaş" },
                    { 785, 59, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1816), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1818), "Çerkezköy" },
                    { 786, 59, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1822), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1824), "Çorlu" },
                    { 774, 58, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1716), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1718), "Koyulhisar" },
                    { 759, 57, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1631), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1634), "Ayancık" },
                    { 758, 56, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1626), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1628), "Tillo" },
                    { 757, 56, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1620), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1623), "Şirvan" },
                    { 730, 54, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1431), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1434), "Söğütlü" },
                    { 731, 54, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1437), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1439), "Adapazarı" },
                    { 732, 54, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1442), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1445), "Arifiye" },
                    { 733, 54, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1448), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1451), "Erenler" },
                    { 734, 54, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1455), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1457), "Serdivan" },
                    { 735, 55, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1460), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1463), "Alaçam" },
                    { 736, 55, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1466), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1469), "Bafra" },
                    { 737, 55, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1472), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1474), "Çarşamba" },
                    { 738, 55, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1477), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1480), "Havza" },
                    { 739, 55, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1483), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1485), "Kavak" },
                    { 740, 55, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1488), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1491), "Ladik" },
                    { 741, 55, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1494), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1496), "Terme" },
                    { 742, 55, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1499), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1502), "Vezirköprü" },
                    { 743, 55, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1505), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1507), "Asarcık" },
                    { 744, 55, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1547), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1550), "19-May" },
                    { 745, 55, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1553), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1555), "Salıpazarı" },
                    { 746, 55, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1558), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1561), "Tekkeköy" },
                    { 747, 55, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1564), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1566), "Ayvacık / Samsun" },
                    { 748, 55, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1569), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1572), "Yakakent" },
                    { 749, 55, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1575), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1577), "Atakum" },
                    { 750, 55, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1580), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1583), "Canik" },
                    { 751, 55, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1586), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1588), "İlkadım" },
                    { 752, 56, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1591), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1594), "Baykan" },
                    { 753, 56, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1597), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1599), "Eruh" },
                    { 754, 56, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1603), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1606), "Kurtalan" },
                    { 755, 56, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1609), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1611), "Pervari" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 756, 56, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1614), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1617), "Siirt Merkez" },
                    { 787, 59, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1827), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1829), "Hayrabolu" },
                    { 487, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9031), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9035), "Bayraklı" },
                    { 788, 59, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1833), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1835), "Malkara" },
                    { 790, 59, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1844), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1847), "Saray / Tekirdağ" },
                    { 822, 61, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2064), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2066), "Düzköy" },
                    { 823, 61, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2069), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2072), "Hayrat" },
                    { 824, 61, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2076), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2078), "Köprübaşı / Trabzon" },
                    { 825, 61, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2081), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2084), "Ortahisar" },
                    { 826, 62, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2087), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2089), "Çemişgezek" },
                    { 827, 62, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2093), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2095), "Hozat" },
                    { 828, 62, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2098), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2100), "Mazgirt" },
                    { 829, 62, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2104), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2106), "Nazımiye" },
                    { 830, 62, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2109), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2112), "Ovacık / Tunceli" },
                    { 831, 62, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2115), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2117), "Pertek" },
                    { 832, 62, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2120), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2126), "Pülümür" },
                    { 833, 62, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2129), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2132), "Tunceli Merkez" },
                    { 821, 61, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2058), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2061), "Dernekpazarı" },
                    { 834, 63, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2135), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2137), "Akçakale" },
                    { 836, 63, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2146), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2148), "Bozova" },
                    { 837, 63, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2151), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2154), "Ceylanpınar" },
                    { 838, 63, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2157), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2159), "Halfeti" },
                    { 839, 63, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2162), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2165), "Hilvan" },
                    { 840, 63, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2168), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2171), "Siverek" },
                    { 841, 63, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2174), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2176), "Suruç" },
                    { 842, 63, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2179), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2182), "Viranşehir" },
                    { 843, 63, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2185), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2187), "Harran" },
                    { 844, 63, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2190), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2193), "Eyyübiye" },
                    { 845, 63, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2196), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2198), "Haliliye" },
                    { 846, 63, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2201), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2204), "Karaköprü" },
                    { 847, 64, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2207), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2210), "Banaz" },
                    { 835, 63, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2140), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2143), "Birecik" },
                    { 820, 61, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2053), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2055), "Çarşıbaşı" },
                    { 819, 61, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2047), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2050), "Şalpazarı" },
                    { 818, 61, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2042), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2044), "Beşikdüzü" },
                    { 791, 59, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1850), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1852), "Şarköy" },
                    { 792, 59, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1855), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1858), "Marmaraereğlisi" },
                    { 793, 59, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1861), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1863), "Ergene" },
                    { 794, 59, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1868), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1870), "Kapaklı" },
                    { 795, 59, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1873), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1875), "Süleymanpaşa" },
                    { 796, 60, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1879), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1881), "Almus" },
                    { 797, 60, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1884), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1886), "Artova" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 798, 60, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1890), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1892), "Erbaa" },
                    { 799, 60, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1895), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1898), "Niksar" },
                    { 800, 60, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1901), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1903), "Reşadiye" },
                    { 801, 60, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1907), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1909), "Tokat Merkez" },
                    { 802, 60, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1912), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1915), "Turhal" },
                    { 803, 60, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1918), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1920), "Zile" },
                    { 804, 60, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1923), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1926), "Pazar / Tokat" },
                    { 805, 60, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1929), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1931), "Yeşilyurt / Tokat" },
                    { 806, 60, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1934), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1937), "Başçiftlik" },
                    { 807, 60, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1940), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1942), "Sulusaray" },
                    { 808, 61, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1945), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1948), "Akçaabat" },
                    { 809, 61, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1952), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1955), "Araklı" },
                    { 810, 61, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1958), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1960), "Arsin" },
                    { 811, 61, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1963), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1966), "Çaykara" },
                    { 812, 61, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1969), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1972), "Maçka" },
                    { 813, 61, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1975), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1977), "Of" },
                    { 814, 61, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1980), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1983), "Sürmene" },
                    { 815, 61, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1986), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1988), "Tonya" },
                    { 816, 61, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1992), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1994), "Vakfıkebir" },
                    { 817, 61, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2035), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(2038), "Yomra" },
                    { 789, 59, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1839), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(1841), "Muratlı" },
                    { 486, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9022), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9026), "Güzelbahçe" },
                    { 485, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9013), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9017), "Narlıdere" },
                    { 484, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9005), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9008), "Gaziemir" },
                    { 154, 11, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5440), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5444), "İnhisar" },
                    { 155, 12, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5450), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5454), "Bingöl Merkez" },
                    { 156, 12, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5460), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5464), "Genç" },
                    { 157, 12, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5470), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5475), "Karlıova" },
                    { 158, 12, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5481), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5484), "Kiğı" },
                    { 159, 12, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5490), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5494), "Solhan" },
                    { 160, 12, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5548), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5559), "Adaklı" },
                    { 161, 12, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5567), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5570), "Yayladere" },
                    { 162, 12, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5574), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5577), "Yedisu" },
                    { 163, 13, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5582), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5585), "Adilcevaz" },
                    { 164, 13, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5589), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5592), "Ahlat" },
                    { 165, 13, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5596), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5600), "Bitlis Merkez" },
                    { 153, 11, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5431), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5435), "Yenipazar / Bilecik" },
                    { 166, 13, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5605), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5608), "Hizan" },
                    { 168, 13, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5620), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5623), "Tatvan" },
                    { 169, 13, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5626), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5630), "Güroymak" },
                    { 170, 14, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5635), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5639), "Bolu Merkez" },
                    { 171, 14, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5643), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5646), "Gerede" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 172, 14, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5649), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5653), "Göynük" },
                    { 173, 14, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5657), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5660), "Kıbrıscık" },
                    { 174, 14, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5665), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5669), "Mengen" },
                    { 175, 14, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5673), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5677), "Mudurnu" },
                    { 176, 14, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5682), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5686), "Seben" },
                    { 177, 14, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5690), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5694), "Dörtdivan" },
                    { 178, 14, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5698), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5703), "Yeniçağa" },
                    { 179, 15, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5708), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5712), "Ağlasun" },
                    { 167, 13, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5612), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5615), "Mutki" },
                    { 180, 15, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5715), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5719), "Bucak" },
                    { 152, 11, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5421), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5425), "Söğüt" },
                    { 150, 11, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5401), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5405), "Osmaneli" },
                    { 124, 9, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5143), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5149), "Köşk" },
                    { 125, 9, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5155), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5159), "Didim" },
                    { 126, 9, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5164), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5169), "Efeler" },
                    { 127, 10, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5174), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5179), "Ayvalık" },
                    { 128, 10, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5184), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5188), "Balya" },
                    { 129, 10, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5194), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5199), "Bandırma" },
                    { 130, 10, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5204), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5209), "Bigadiç" },
                    { 131, 10, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5214), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5218), "Burhaniye" },
                    { 132, 10, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5224), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5228), "Dursunbey" },
                    { 133, 10, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5234), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5238), "Edremit / Balıkesir" },
                    { 134, 10, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5244), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5247), "Erdek" },
                    { 135, 10, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5253), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5257), "Gönen / Balıkesir" },
                    { 151, 11, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5411), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5415), "Pazaryeri" },
                    { 136, 10, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5263), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5268), "Havran" },
                    { 138, 10, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5284), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5289), "Kepsut" },
                    { 139, 10, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5294), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5298), "Manyas" },
                    { 140, 10, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5304), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5309), "Savaştepe" },
                    { 141, 10, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5314), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5319), "Sındırgı" },
                    { 142, 10, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5324), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5328), "Susurluk" },
                    { 143, 10, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5333), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5338), "Marmara" },
                    { 144, 10, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5343), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5347), "Gömeç" },
                    { 145, 10, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5353), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5357), "Altıeylül" },
                    { 146, 10, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5363), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5366), "Karesi" },
                    { 147, 11, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5372), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5376), "Bilecik Merkez" },
                    { 148, 11, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5382), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5386), "Bozüyük" },
                    { 149, 11, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5391), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5395), "Gölpazarı" },
                    { 137, 10, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5274), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5278), "İvrindi" },
                    { 181, 15, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5724), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5727), "Burdur Merkez" },
                    { 182, 15, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5732), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5736), "Gölhisar" },
                    { 183, 15, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5742), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5746), "Tefenni" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 215, 17, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6126), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6129), "Gelibolu" },
                    { 216, 17, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6134), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6138), "Gökçeada" },
                    { 217, 17, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6142), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6145), "Lapseki" },
                    { 218, 17, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6150), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6154), "Yenice / Çanakkale" },
                    { 219, 18, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6159), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6162), "Çankırı Merkez" },
                    { 220, 18, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6167), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6171), "Çerkeş" },
                    { 221, 18, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6176), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6180), "Eldivan" },
                    { 222, 18, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6185), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6188), "Ilgaz" },
                    { 223, 18, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6193), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6197), "Kurşunlu" },
                    { 224, 18, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6202), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6206), "Orta" },
                    { 225, 18, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6211), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6215), "Şabanözü" },
                    { 226, 18, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6221), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6225), "Yapraklı" },
                    { 214, 17, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6118), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6122), "Ezine" },
                    { 227, 18, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6230), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6234), "Atkaracalar" },
                    { 229, 18, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6248), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6252), "Bayramören" },
                    { 230, 18, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6256), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6260), "Korgun" },
                    { 231, 19, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6265), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6268), "Alaca" },
                    { 232, 19, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6275), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6279), "Bayat / Çorum" },
                    { 233, 19, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6348), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6355), "Çorum Merkez" },
                    { 234, 19, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6361), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6365), "İskilip" },
                    { 235, 19, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6369), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6373), "Kargı" },
                    { 236, 19, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6379), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6382), "Mecitözü" },
                    { 237, 19, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6388), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6391), "Ortaköy / Çorum" },
                    { 238, 19, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6395), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6399), "Osmancık" },
                    { 239, 19, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6403), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6406), "Sungurlu" },
                    { 240, 19, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6410), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6414), "Boğazkale" },
                    { 228, 18, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6239), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6244), "Kızılırmak" },
                    { 213, 17, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6111), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6115), "Eceabat" },
                    { 212, 17, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6103), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6107), "Çanakkale Merkez" },
                    { 211, 17, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6065), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6091), "Çan" },
                    { 184, 15, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5750), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5754), "Yeşilova" },
                    { 185, 15, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5758), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5762), "Karamanlı" },
                    { 186, 15, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5766), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5770), "Kemer / Burdur" },
                    { 187, 15, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5775), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5779), "Altınyayla / Burdur" },
                    { 188, 15, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5783), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5787), "Çavdır" },
                    { 189, 15, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5792), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5795), "Çeltikçi" },
                    { 190, 16, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5798), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5801), "Gemlik" },
                    { 191, 16, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5805), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5809), "İnegöl" },
                    { 192, 16, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5812), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5815), "İznik" },
                    { 193, 16, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5819), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5822), "Karacabey" },
                    { 194, 16, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5826), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5830), "Keles" },
                    { 195, 16, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5834), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5837), "Mudanya" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 196, 16, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5842), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5845), "Mustafakemalpaşa" },
                    { 197, 16, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5904), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5916), "Orhaneli" },
                    { 198, 16, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5928), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5931), "Orhangazi" },
                    { 199, 16, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5936), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5947), "Yenişehir / Bursa" },
                    { 200, 16, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5952), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5955), "Büyükorhan" },
                    { 201, 16, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5959), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5966), "Harmancık" },
                    { 202, 16, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5973), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5981), "Nilüfer" },
                    { 203, 16, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5992), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5999), "Osmangazi" },
                    { 204, 16, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6003), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6007), "Yıldırım" },
                    { 205, 16, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6011), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6014), "Gürsu" },
                    { 206, 16, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6018), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6021), "Kestel" },
                    { 207, 17, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6025), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6028), "Ayvacık / Çanakkale" },
                    { 208, 17, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6033), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6036), "Bayramiç" },
                    { 209, 17, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6040), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6043), "Biga" },
                    { 210, 17, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6048), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6053), "Bozcaada" },
                    { 123, 9, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5086), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5090), "Karpuzlu" },
                    { 122, 9, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5076), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5081), "İncirliova" },
                    { 121, 9, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5068), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5071), "Buharkent" },
                    { 120, 9, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5058), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5062), "Yenipazar / Aydın" },
                    { 33, 3, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3982), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3985), "Sinanpaşa" },
                    { 34, 3, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3990), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3993), "Sultandağı" },
                    { 35, 3, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3997), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4000), "Şuhut" },
                    { 36, 3, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4004), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4007), "Başmakçı" },
                    { 37, 3, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4011), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4014), "Bayat / Afyonkarahisar" },
                    { 38, 3, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4026), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4036), "İscehisar" },
                    { 39, 3, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4047), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4053), "Çobanlar" },
                    { 40, 3, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4061), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4065), "Evciler" },
                    { 41, 3, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4070), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4074), "Hocalar" },
                    { 42, 3, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4080), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4084), "Kızılören" },
                    { 43, 4, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4089), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4093), "Ağrı Merkez" },
                    { 44, 4, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4105), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4115), "Diyadin" },
                    { 32, 3, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3975), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3978), "Sandıklı" },
                    { 45, 4, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4126), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4136), "Doğubayazıt" },
                    { 47, 4, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4156), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4161), "Hamur" },
                    { 48, 4, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4166), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4170), "Patnos" },
                    { 49, 4, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4174), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4177), "Taşlıçay" },
                    { 50, 4, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4181), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4184), "Tutak" },
                    { 51, 5, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4265), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4271), "Amasya Merkez" },
                    { 52, 5, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4275), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4278), "Göynücek" },
                    { 53, 5, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4283), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4286), "Gümüşhacıköy" },
                    { 54, 5, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4290), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4294), "Merzifon" },
                    { 55, 5, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4298), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4301), "Suluova" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 56, 5, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4306), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4310), "Taşova" },
                    { 57, 5, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4313), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4317), "Hamamözü" },
                    { 58, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4322), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4326), "Altındağ" },
                    { 46, 4, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4143), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4146), "Eleşkirt" },
                    { 31, 3, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3968), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3970), "İhsaniye" },
                    { 30, 3, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3960), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3963), "Emirdağ" },
                    { 29, 3, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3919), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3949), "Dinar" },
                    { 2, 1, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2875), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2898), "Ceyhan" },
                    { 3, 1, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2906), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2911), "Feke" },
                    { 4, 1, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2917), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2921), "Karaisalı" },
                    { 5, 1, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2926), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2930), "Karataş" },
                    { 6, 1, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2936), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2940), "Kozan" },
                    { 7, 1, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2946), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2951), "Pozantı" },
                    { 8, 1, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2957), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2961), "Saimbeyli" },
                    { 9, 1, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2966), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2971), "Tufanbeyli" },
                    { 10, 1, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2976), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2980), "Yumurtalık" },
                    { 11, 1, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2985), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2990), "Yüreğir" },
                    { 12, 1, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2994), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(2999), "Aladağ" },
                    { 13, 1, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3003), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3007), "İmamoğlu" },
                    { 14, 1, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3074), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3079), "Sarıçam" },
                    { 15, 1, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3085), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3089), "Çukurova" },
                    { 16, 2, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3096), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3101), "Adıyaman Merkez" },
                    { 17, 2, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3108), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3113), "Besni" },
                    { 18, 2, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3120), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3125), "Çelikhan" },
                    { 19, 2, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3130), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3136), "Gerger" },
                    { 20, 2, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3141), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3149), "Gölbaşı / Adıyaman" },
                    { 21, 2, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3155), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3160), "Kahta" },
                    { 22, 2, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3202), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3208), "Samsat" },
                    { 23, 2, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3213), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3218), "Sincik" },
                    { 24, 2, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3224), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3228), "Tut" },
                    { 25, 3, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3234), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3238), "Afyonkarahisar Merkez" },
                    { 26, 3, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3244), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3248), "Bolvadin" },
                    { 27, 3, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3252), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3256), "Çay" },
                    { 28, 3, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3262), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(3266), "Dazkırı" },
                    { 59, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4331), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4334), "Ayaş" },
                    { 241, 19, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6418), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6421), "Uğurludağ" },
                    { 60, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4339), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4342), "Bala" },
                    { 62, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4353), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4356), "Çamlıdere" },
                    { 94, 7, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4817), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4821), "Demre" },
                    { 95, 7, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4826), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4830), "İbradı" },
                    { 96, 7, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4836), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4841), "Kemer / Antalya" },
                    { 97, 7, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4846), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4850), "Aksu / Antalya" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 98, 7, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4855), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4859), "Döşemealtı" },
                    { 99, 7, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4864), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4868), "Kepez" },
                    { 100, 7, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4874), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4878), "Konyaaltı" },
                    { 101, 7, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4883), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4887), "Muratpaşa" },
                    { 102, 8, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4892), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4896), "Ardanuç" },
                    { 103, 8, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4902), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4906), "Arhavi" },
                    { 104, 8, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4911), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4915), "Artvin Merkez" },
                    { 105, 8, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4920), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4925), "Borçka" },
                    { 93, 7, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4808), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4812), "Serik" },
                    { 106, 8, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4930), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4934), "Hopa" },
                    { 108, 8, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4946), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4949), "Yusufeli" },
                    { 109, 8, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4953), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4957), "Murgul" },
                    { 110, 9, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4962), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4965), "Bozdoğan" },
                    { 111, 9, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4971), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4975), "Çine" },
                    { 112, 9, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4980), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4985), "Germencik" },
                    { 113, 9, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4990), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4994), "Karacasu" },
                    { 114, 9, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4999), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5004), "Koçarlı" },
                    { 115, 9, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5009), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5014), "Kuşadası" },
                    { 116, 9, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5019), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5023), "Kuyucak" },
                    { 117, 9, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5029), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5033), "Nazilli" },
                    { 118, 9, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5039), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5043), "Söke" },
                    { 119, 9, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5048), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(5053), "Sultanhisar" },
                    { 107, 8, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4938), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4942), "Şavşat" },
                    { 92, 7, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4799), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4803), "Manavgat" },
                    { 91, 7, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4789), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4794), "Kumluca" },
                    { 90, 7, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4781), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4785), "Korkuteli" },
                    { 63, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4360), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4368), "Çankaya" },
                    { 64, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4380), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4389), "Çubuk" },
                    { 65, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4401), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4411), "Elmadağ" },
                    { 66, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4422), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4431), "Güdül" },
                    { 67, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4443), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4452), "Haymana" },
                    { 68, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4467), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4477), "Kalecik" },
                    { 69, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4490), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4493), "Kızılcahamam" },
                    { 70, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4498), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4502), "Nallıhan" },
                    { 71, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4508), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4512), "Polatlı" },
                    { 72, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4517), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4521), "Şereflikoçhisar" },
                    { 73, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4526), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4529), "Yenimahalle" },
                    { 74, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4534), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4538), "Gölbaşı / Ankara" },
                    { 75, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4542), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4545), "Keçiören" },
                    { 76, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4551), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4557), "Mamak" },
                    { 77, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4569), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4579), "Sincan" },
                    { 78, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4591), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4601), "Kazan" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 79, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4613), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4623), "Akyurt" },
                    { 80, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4630), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4635), "Etimesgut" },
                    { 81, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4640), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4644), "Evren" },
                    { 82, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4649), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4653), "Pursaklar" },
                    { 83, 7, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4658), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4663), "Akseki" },
                    { 84, 7, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4669), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4673), "Alanya" },
                    { 85, 7, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4678), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4682), "Elmalı" },
                    { 86, 7, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4687), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4692), "Finike" },
                    { 87, 7, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4750), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4755), "Gazipaşa" },
                    { 88, 7, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4761), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4765), "Gündoğmuş" },
                    { 89, 7, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4770), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4775), "Kaş" },
                    { 61, 6, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4346), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(4349), "Beypazarı" },
                    { 969, 81, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(3072), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(3074), "Gümüşova" },
                    { 242, 19, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6425), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6428), "Dodurga" },
                    { 244, 19, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6440), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6445), "Oğuzlar" },
                    { 397, 32, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8093), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8097), "Isparta Merkez" },
                    { 398, 32, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8103), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8106), "Keçiborlu" },
                    { 399, 32, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8111), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8115), "Senirkent" },
                    { 400, 32, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8120), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8123), "Sütçüler" },
                    { 401, 32, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8128), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8132), "Şarkikaraağaç" },
                    { 402, 32, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8137), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8140), "Uluborlu" },
                    { 403, 32, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8145), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8149), "Yalvaç" },
                    { 404, 32, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8154), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8158), "Aksu / Isparta" },
                    { 405, 32, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8164), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8168), "Gönen / Isparta" },
                    { 406, 32, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8173), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8177), "Yenişarbademli" },
                    { 407, 33, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8182), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8187), "Anamur" },
                    { 408, 33, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8192), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8196), "Erdemli" },
                    { 396, 32, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8085), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8088), "Gelendost" },
                    { 409, 33, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8202), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8206), "Gülnar" },
                    { 411, 33, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8224), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8229), "Silifke" },
                    { 412, 33, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8234), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8238), "Tarsus" },
                    { 413, 33, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8243), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8248), "Aydıncık / Mersin" },
                    { 414, 33, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8253), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8257), "Bozyazı" },
                    { 415, 33, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8262), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8266), "Çamlıyayla" },
                    { 416, 33, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8326), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8332), "Akdeniz" },
                    { 417, 33, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8337), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8341), "Mezitli" },
                    { 418, 33, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8345), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8348), "Toroslar" },
                    { 419, 33, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8353), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8357), "Yenişehir / Mersin" },
                    { 420, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8362), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8366), "Adalar" },
                    { 421, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8371), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8375), "Bakırköy" },
                    { 422, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8380), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8384), "Beşiktaş" },
                    { 410, 33, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8212), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8217), "Mut" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 423, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8390), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8394), "Beykoz" },
                    { 395, 32, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8077), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8080), "Eğirdir" },
                    { 393, 31, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8058), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8063), "Payas" },
                    { 367, 28, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7761), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7764), "Doğankent" },
                    { 368, 28, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7770), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7773), "Güce" },
                    { 369, 29, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7778), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7782), "Gümüşhane Merkez" },
                    { 370, 29, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7787), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7791), "Kelkit" },
                    { 371, 29, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7796), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7800), "Şiran" },
                    { 372, 29, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7805), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7809), "Torul" },
                    { 373, 29, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7813), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7818), "Köse" },
                    { 374, 29, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7823), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7827), "Kürtün" },
                    { 375, 30, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7833), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7837), "Çukurca" },
                    { 376, 30, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7842), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7846), "Hakkari Merkez" },
                    { 377, 30, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7851), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7855), "Şemdinli" },
                    { 378, 30, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7861), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7865), "Yüksekova" },
                    { 394, 32, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8068), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8072), "Atabey" },
                    { 379, 31, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7925), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7931), "Altınözü" },
                    { 381, 31, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7946), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7950), "Hassa" },
                    { 382, 31, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7955), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7958), "İskenderun" },
                    { 383, 31, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7962), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7966), "Kırıkhan" },
                    { 384, 31, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7972), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7976), "Reyhanlı" },
                    { 385, 31, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7981), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7986), "Samandağ" },
                    { 386, 31, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7991), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7995), "Yayladağı" },
                    { 387, 31, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8000), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8004), "Erzin" },
                    { 388, 31, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8010), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8014), "Belen" },
                    { 389, 31, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8019), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8023), "Kumlu" },
                    { 390, 31, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8029), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8034), "Antakya" },
                    { 391, 31, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8039), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8043), "Arsuz" },
                    { 392, 31, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8049), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8053), "Defne" },
                    { 380, 31, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7938), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7941), "Dörtyol" },
                    { 424, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8399), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8403), "Beyoğlu" },
                    { 425, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8408), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8413), "Çatalca" },
                    { 426, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8418), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8422), "Eyüp" },
                    { 458, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8768), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8772), "Sultangazi" },
                    { 459, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8778), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8783), "Aliağa" },
                    { 460, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8788), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8792), "Bayındır" },
                    { 461, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8796), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8801), "Bergama" },
                    { 462, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8806), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8810), "Bornova" },
                    { 463, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8815), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8819), "Çeşme" },
                    { 464, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8824), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8828), "Dikili" },
                    { 465, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8833), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8836), "Foça" },
                    { 466, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8841), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8844), "Karaburun" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 467, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8849), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8853), "Karşıyaka" },
                    { 468, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8858), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8861), "Kemalpaşa / İzmir" },
                    { 469, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8865), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8869), "Kınık" },
                    { 457, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8759), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8763), "Sancaktepe" },
                    { 470, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8874), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8877), "Kiraz" },
                    { 472, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8891), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8895), "Ödemiş" },
                    { 473, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8901), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8904), "Seferihisar" },
                    { 474, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8910), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8914), "Selçuk" },
                    { 475, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8919), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8924), "Tire" },
                    { 476, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8929), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8932), "Torbalı" },
                    { 477, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8937), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8942), "Urla" },
                    { 478, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8947), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8951), "Beydağ" },
                    { 479, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8957), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8961), "Buca" },
                    { 480, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8968), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8972), "Konak" },
                    { 481, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8977), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8981), "Menderes" },
                    { 482, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8987), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8990), "Balçova" },
                    { 483, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8995), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(9000), "Çiğli" },
                    { 471, 35, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8882), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8885), "Menemen" },
                    { 456, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8754), "Esenyurt" },
                    { 455, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8744), "Çekmeköy" },
                    { 454, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8735), "Beylikdüzü" },
                    { 427, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8427), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8431), "Fatih" },
                    { 428, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8436), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8441), "Gaziosmanpaşa" },
                    { 429, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8446), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8451), "Kadıköy" },
                    { 430, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8456), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8460), "Kartal" },
                    { 431, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8464), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8468), "Sarıyer" },
                    { 432, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8473), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8478), "Silivri" },
                    { 433, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8483), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8487), "Şile" },
                    { 434, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8492), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8495), "Şişli" },
                    { 435, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8501), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8505), "Üsküdar" },
                    { 436, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8510), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8514), "Zeytinburnu" },
                    { 437, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8519), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8523), "Büyükçekmece" },
                    { 438, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8529), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8533), "Kağıthane" },
                    { 439, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8537), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8541), "Küçükçekmece" },
                    { 440, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8547), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8551), "Pendik" },
                    { 441, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8556), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8559), "Ümraniye" },
                    { 442, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8564), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8568), "Bayrampaşa" },
                    { 443, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8573), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8576), "Avcılar" },
                    { 444, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8581), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8585), "Bağcılar" },
                    { 445, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8589), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8593), "Bahçelievler" },
                    { 446, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8598), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8602), "Güngören" },
                    { 447, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8607), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8611), "Maltepe" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 448, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8616), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8620), "Sultanbeyli" },
                    { 449, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8625), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8629), "Tuzla" },
                    { 450, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8634), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8639), "Esenler" },
                    { 451, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8643), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8647), "Arnavutköy" },
                    { 452, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8709), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8716), "Ataşehir" },
                    { 453, 34, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8722), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(8725), "Başakşehir" },
                    { 366, 28, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7752), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7756), "Çanakçı" },
                    { 365, 28, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7743), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7747), "Çamoluk" },
                    { 364, 28, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7733), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7737), "Yağlıdere" },
                    { 363, 28, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7723), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7727), "Piraziz" },
                    { 276, 21, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6828), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6831), "Kocaköy" },
                    { 277, 21, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6836), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6839), "Bağlar" },
                    { 278, 21, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6844), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6847), "Kayapınar" },
                    { 279, 21, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6852), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6856), "Sur" },
                    { 280, 21, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6861), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6865), "Yenişehir / Diyarbakır" },
                    { 281, 22, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6870), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6874), "Edirne Merkez" },
                    { 282, 22, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6878), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6882), "Enez" },
                    { 283, 22, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6887), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6890), "Havsa" },
                    { 284, 22, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6895), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6898), "İpsala" },
                    { 285, 22, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6904), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6908), "Keşan" },
                    { 286, 22, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6913), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6916), "Lalapaşa" },
                    { 287, 22, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6921), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6925), "Meriç" },
                    { 275, 21, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6820), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6823), "Eğil" },
                    { 288, 22, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6931), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6935), "Uzunköprü" },
                    { 290, 23, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6948), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6952), "Ağın" },
                    { 291, 23, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6958), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6961), "Baskil" },
                    { 292, 23, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6966), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6971), "Elazığ Merkez" },
                    { 293, 23, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6975), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6979), "Karakoçan" },
                    { 294, 23, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6983), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6987), "Keban" },
                    { 295, 23, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6992), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6996), "Maden" },
                    { 296, 23, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7002), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7006), "Palu" },
                    { 297, 23, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7010), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7014), "Sivrice" },
                    { 298, 23, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7019), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7022), "Arıcak" },
                    { 299, 23, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7027), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7031), "Kovancılar" },
                    { 300, 23, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7035), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7039), "Alacakaya" },
                    { 301, 24, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7044), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7048), "Çayırlı" },
                    { 289, 22, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6939), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6943), "Süloğlu" },
                    { 274, 21, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6812), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6815), "Silvan" },
                    { 273, 21, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6804), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6808), "Lice" },
                    { 272, 21, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6797), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6800), "Kulp" },
                    { 245, 20, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6450), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6453), "Acıpayam" },
                    { 246, 20, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6457), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6460), "Buldan" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 247, 20, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6464), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6468), "Çal" },
                    { 248, 20, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6474), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6478), "Çameli" },
                    { 249, 20, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6483), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6487), "Çardak" },
                    { 250, 20, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6492), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6496), "Çivril" },
                    { 251, 20, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6500), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6503), "Güney" },
                    { 252, 20, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6508), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6511), "Kale / Denizli" },
                    { 253, 20, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6517), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6521), "Sarayköy" },
                    { 254, 20, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6525), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6530), "Tavas" },
                    { 255, 20, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6537), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6541), "Babadağ" },
                    { 256, 20, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6546), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6550), "Bekilli" },
                    { 257, 20, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6555), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6559), "Honaz" },
                    { 258, 20, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6564), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6569), "Serinhisar" },
                    { 259, 20, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6574), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6578), "Pamukkale" },
                    { 260, 20, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6583), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6586), "Baklan" },
                    { 261, 20, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6591), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6595), "Beyağaç" },
                    { 262, 20, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6600), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6605), "Bozkurt / Denizli" },
                    { 263, 20, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6610), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6615), "Merkezefendi" },
                    { 264, 21, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6620), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6624), "Bismil" },
                    { 265, 21, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6629), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6633), "Çermik" },
                    { 266, 21, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6637), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6640), "Çınar" },
                    { 267, 21, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6645), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6649), "Çüngüş" },
                    { 268, 21, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6654), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6658), "Dicle" },
                    { 269, 21, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6663), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6667), "Ergani" },
                    { 270, 21, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6776), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6783), "Hani" },
                    { 271, 21, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6788), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6792), "Hazro" },
                    { 302, 24, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7054), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7058), "Erzincan Merkez" },
                    { 243, 19, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6432), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(6436), "Laçin" },
                    { 303, 24, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7063), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7067), "İliç" },
                    { 305, 24, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7082), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7086), "Kemaliye" },
                    { 337, 26, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7432), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7435), "Beylikova" },
                    { 338, 26, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7439), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7443), "İnönü" },
                    { 339, 26, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7448), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7452), "Günyüzü" },
                    { 340, 26, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7457), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7460), "Han" },
                    { 341, 26, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7464), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7467), "Mihalgazi" },
                    { 342, 26, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7471), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7475), "Odunpazarı" },
                    { 343, 26, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7533), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7539), "Tepebaşı" },
                    { 344, 27, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7545), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7549), "Araban" },
                    { 345, 27, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7555), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7559), "İslahiye" },
                    { 346, 27, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7565), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7568), "Nizip" },
                    { 347, 27, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7574), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7578), "Oğuzeli" },
                    { 348, 27, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7584), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7588), "Yavuzeli" },
                    { 336, 26, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7421), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7426), "Alpu" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 349, 27, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7593), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7597), "Şahinbey" },
                    { 351, 27, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7612), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7616), "Karkamış" },
                    { 352, 27, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7622), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7626), "Nurdağı" },
                    { 353, 28, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7631), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7635), "Alucra" },
                    { 354, 28, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7640), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7644), "Bulancak" },
                    { 355, 28, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7650), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7654), "Dereli" },
                    { 356, 28, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7659), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7663), "Espiye" },
                    { 357, 28, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7669), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7672), "Eynesil" },
                    { 358, 28, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7676), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7680), "Giresun Merkez" },
                    { 359, 28, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7685), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7690), "Görele" },
                    { 360, 28, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7695), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7699), "Keşap" },
                    { 361, 28, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7704), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7707), "Şebinkarahisar" },
                    { 362, 28, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7713), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7717), "Tirebolu" },
                    { 350, 27, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7602), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7607), "Şehitkamil" },
                    { 335, 26, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7401), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7404), "Sivrihisar" },
                    { 334, 26, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7393), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7396), "Seyitgazi" },
                    { 333, 26, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7386), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7389), "Sarıcakaya" },
                    { 306, 24, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7143), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7150), "Refahiye" },
                    { 307, 24, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7156), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7160), "Tercan" },
                    { 308, 24, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7165), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7169), "Üzümlü" },
                    { 309, 24, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7173), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7177), "Otlukbeli" },
                    { 310, 25, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7182), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7185), "Aşkale" },
                    { 311, 25, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7190), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7193), "Çat" },
                    { 312, 25, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7198), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7201), "Hınıs" },
                    { 313, 25, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7205), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7209), "Horasan" },
                    { 314, 25, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7213), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7218), "İspir" },
                    { 315, 25, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7224), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7227), "Karayazı" },
                    { 316, 25, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7232), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7236), "Narman" },
                    { 317, 25, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7240), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7243), "Oltu" },
                    { 318, 25, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7247), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7251), "Olur" },
                    { 319, 25, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7256), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7259), "Pasinler" },
                    { 320, 25, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7264), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7268), "Şenkaya" },
                    { 321, 25, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7273), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7277), "Tekman" },
                    { 322, 25, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7282), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7286), "Tortum" },
                    { 323, 25, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7291), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7295), "Karaçoban" },
                    { 324, 25, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7301), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7305), "Uzundere" },
                    { 325, 25, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7310), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7315), "Pazaryolu" },
                    { 326, 25, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7320), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7324), "Aziziye" },
                    { 327, 25, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7328), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7333), "Köprüköy" },
                    { 328, 25, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7344), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7349), "Palandöken" },
                    { 329, 25, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7354), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7358), "Yakutiye" },
                    { 330, 26, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7362), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7365), "Çifteler" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 331, 26, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7370), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7374), "Mahmudiye" },
                    { 332, 26, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7378), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7382), "Mihalıççık" },
                    { 304, 24, new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7072), new DateTime(2022, 2, 4, 21, 10, 32, 308, DateTimeKind.Local).AddTicks(7076), "Kemah" },
                    { 970, 81, new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(3077), new DateTime(2022, 2, 4, 21, 10, 32, 309, DateTimeKind.Local).AddTicks(3079), "Kaynaşlı" }
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
                name: "IX_Breaks_ShiftId",
                table: "Breaks",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ManagerId",
                table: "Comments",
                column: "ManagerId",
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ApprovedBy",
                table: "Expenses",
                column: "ApprovedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_EmployeeId",
                table: "Expenses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpenseTypeId",
                table: "Expenses",
                column: "ExpenseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_EmployeeId",
                table: "Holidays",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Liabilities_CategoryId",
                table: "Liabilities",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Liabilities_EmployeeId",
                table: "Liabilities",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Liabilities_ManagerId",
                table: "Liabilities",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_EmployeeId",
                table: "Permissions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_ManagerId",
                table: "Permissions",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_PermissionTypeId",
                table: "Permissions",
                column: "PermissionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_ExpenseId",
                table: "Receipts",
                column: "ExpenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_EmployeeId",
                table: "Shifts",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_ManagerId",
                table: "Shifts",
                column: "ManagerId");
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
                name: "Breaks");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Holidays");

            migrationBuilder.DropTable(
                name: "Liabilities");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "LiabilityCategories");

            migrationBuilder.DropTable(
                name: "PermissionTypes");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "ExpenseTypes");

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
