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
                    memberid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    membercode = table.Column<string>(maxLength: 20, nullable: false),
                    firstname = table.Column<string>(maxLength: 100, nullable: false),
                    middlename = table.Column<string>(maxLength: 100, nullable: false),
                    lastname = table.Column<string>(maxLength: 100, nullable: false),
                    dob = table.Column<DateTime>(nullable: true),
                    email = table.Column<string>(maxLength: 20, nullable: false),
                    mobileno = table.Column<string>(maxLength: 20, nullable: false),
                    gender = table.Column<string>(maxLength: 10, nullable: false),
                    isemailnotification = table.Column<bool>(nullable: true),
                    issmsnotification = table.Column<bool>(nullable: true),
                    isapproved = table.Column<bool>(nullable: true),
                    isactive = table.Column<bool>(nullable: true),
                    notes = table.Column<string>(nullable: true),
                    presentaddress = table.Column<string>(nullable: true),
                    homephone = table.Column<string>(maxLength: 20, nullable: false),
                    workphone = table.Column<string>(maxLength: 20, nullable: false),
                    bloodgroup = table.Column<string>(maxLength: 20, nullable: false),
                    occupation = table.Column<string>(maxLength: 50, nullable: false),
                    qualification = table.Column<string>(maxLength: 50, nullable: false),
                    permanentaddress = table.Column<string>(nullable: true),
                    joiningdate = table.Column<DateTime>(nullable: true),
                    ismarried = table.Column<bool>(nullable: true),
                    accoundcode = table.Column<string>(maxLength: 20, nullable: false),
                    country = table.Column<string>(maxLength: 50, nullable: false),
                    city = table.Column<string>(maxLength: 50, nullable: false),
                    street = table.Column<string>(maxLength: 100, nullable: false),
                    pincode = table.Column<string>(maxLength: 20, nullable: false),
                    state = table.Column<string>(maxLength: 20, nullable: false),
                    subscriptionamount = table.Column<decimal>(nullable: false),
                    profileimage = table.Column<string>(maxLength: 500, nullable: false),
                    weddingdate = table.Column<DateTime>(nullable: true),
                    homeparish = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.memberid);
                });

            migrationBuilder.CreateTable(
                name: "MemberFamilyDetail",
                columns: table => new
                {
                    memberfamilyid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    memberid = table.Column<int>(nullable: true),
                    relname = table.Column<string>(maxLength: 100, nullable: false),
                    reldob = table.Column<DateTime>(nullable: true),
                    relgender = table.Column<string>(maxLength: 20, nullable: true),
                    relmobileno = table.Column<string>(maxLength: 20, nullable: false),
                    address = table.Column<string>(nullable: false),
                    address1 = table.Column<string>(nullable: false),
                    state = table.Column<string>(maxLength: 20, nullable: false),
                    country = table.Column<string>(maxLength: 20, nullable: false),
                    isapproved = table.Column<bool>(nullable: true),
                    bloodgroup = table.Column<string>(maxLength: 20, nullable: false),
                    relation = table.Column<string>(maxLength: 50, nullable: false),
                    emailid = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberFamilyDetail", x => x.memberfamilyid);
                });

            migrationBuilder.CreateTable(
                name: "MST_Documents",
                columns: table => new
                {
                    docid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    docname = table.Column<string>(maxLength: 100, nullable: false),
                    docdate = table.Column<DateTime>(nullable: true),
                    docurl = table.Column<string>(maxLength: 500, nullable: false),
                    fileextension = table.Column<string>(maxLength: 20, nullable: false),
                    doccomment = table.Column<string>(nullable: false),
                    createddate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MST_Documents", x => x.docid);
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    usercode = table.Column<string>(maxLength: 20, nullable: false),
                    username = table.Column<string>(maxLength: 100, nullable: false),
                    password = table.Column<string>(maxLength: 100, nullable: false),
                    lastloggedin = table.Column<DateTime>(nullable: true),
                    usertype = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => x.usercode);
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
