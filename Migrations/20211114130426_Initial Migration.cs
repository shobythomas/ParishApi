using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParishApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    MemberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberCode = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: true),
                    EmailId = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    IsEmailNotification = table.Column<bool>(nullable: true),
                    IsSMSNotification = table.Column<bool>(nullable: true),
                    IsApproved = table.Column<bool>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Present_Address = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    WorkPhone = table.Column<string>(nullable: true),
                    BloodGroup = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    Qualification = table.Column<string>(nullable: true),
                    Permenant_Address = table.Column<string>(nullable: true),
                    JoiningDate = table.Column<DateTime>(nullable: true),
                    IsMarried = table.Column<bool>(nullable: true),
                    Account_Code = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    PinCode = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Subscription_Amount = table.Column<decimal>(nullable: true),
                    ProfileImage = table.Column<string>(nullable: true),
                    WeddingDate = table.Column<DateTime>(nullable: true),
                    HomeParish = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.MemberID);
                });

            migrationBuilder.CreateTable(
                name: "MemberFamilyDetail",
                columns: table => new
                {
                    MemberFamilyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(nullable: true),
                    RelName = table.Column<string>(nullable: true),
                    RelDOB = table.Column<DateTime>(nullable: true),
                    RelGender = table.Column<string>(nullable: true),
                    RelMobileNo = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Address1 = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    IsApproved = table.Column<bool>(nullable: true),
                    BloodGroup = table.Column<string>(nullable: true),
                    Relation = table.Column<string>(nullable: true),
                    EmailID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberFamilyDetail", x => x.MemberFamilyId);
                });

            migrationBuilder.CreateTable(
                name: "MST_Documents",
                columns: table => new
                {
                    DocId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocName = table.Column<string>(nullable: true),
                    DocDate = table.Column<DateTime>(nullable: true),
                    Docurl = table.Column<string>(nullable: true),
                    FileExtension = table.Column<string>(nullable: true),
                    DocComment = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MST_Documents", x => x.DocId);
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    UserCode = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    LastLoggedIn = table.Column<DateTime>(nullable: true),
                    userType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => x.UserCode);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "MemberFamilyDetail");

            migrationBuilder.DropTable(
                name: "MST_Documents");

            migrationBuilder.DropTable(
                name: "UserLogin");
        }
    }
}
