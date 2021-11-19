using Microsoft.EntityFrameworkCore.Migrations;

namespace ParishApi.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Account_Code",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "Permenant_Address",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "Present_Address",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "Subscription_Amount",
                table: "Member");

            migrationBuilder.RenameColumn(
                name: "userType",
                table: "UserLogin",
                newName: "usertype");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "UserLogin",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "UserLogin",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "LastLoggedIn",
                table: "UserLogin",
                newName: "lastloggedin");

            migrationBuilder.RenameColumn(
                name: "UserCode",
                table: "UserLogin",
                newName: "usercode");

            migrationBuilder.RenameColumn(
                name: "FileExtension",
                table: "MST_Documents",
                newName: "fileextension");

            migrationBuilder.RenameColumn(
                name: "Docurl",
                table: "MST_Documents",
                newName: "docurl");

            migrationBuilder.RenameColumn(
                name: "DocName",
                table: "MST_Documents",
                newName: "docname");

            migrationBuilder.RenameColumn(
                name: "DocDate",
                table: "MST_Documents",
                newName: "docdate");

            migrationBuilder.RenameColumn(
                name: "DocComment",
                table: "MST_Documents",
                newName: "doccomment");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "MST_Documents",
                newName: "createddate");

            migrationBuilder.RenameColumn(
                name: "DocId",
                table: "MST_Documents",
                newName: "docid");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "MemberFamilyDetail",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "Relation",
                table: "MemberFamilyDetail",
                newName: "relation");

            migrationBuilder.RenameColumn(
                name: "RelName",
                table: "MemberFamilyDetail",
                newName: "relname");

            migrationBuilder.RenameColumn(
                name: "RelMobileNo",
                table: "MemberFamilyDetail",
                newName: "relmobileno");

            migrationBuilder.RenameColumn(
                name: "RelGender",
                table: "MemberFamilyDetail",
                newName: "relgender");

            migrationBuilder.RenameColumn(
                name: "RelDOB",
                table: "MemberFamilyDetail",
                newName: "reldob");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "MemberFamilyDetail",
                newName: "memberid");

            migrationBuilder.RenameColumn(
                name: "IsApproved",
                table: "MemberFamilyDetail",
                newName: "isapproved");

            migrationBuilder.RenameColumn(
                name: "EmailID",
                table: "MemberFamilyDetail",
                newName: "emailid");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "MemberFamilyDetail",
                newName: "country");

            migrationBuilder.RenameColumn(
                name: "BloodGroup",
                table: "MemberFamilyDetail",
                newName: "bloodgroup");

            migrationBuilder.RenameColumn(
                name: "Address1",
                table: "MemberFamilyDetail",
                newName: "address1");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "MemberFamilyDetail",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "MemberFamilyId",
                table: "MemberFamilyDetail",
                newName: "memberfamilyid");

            migrationBuilder.RenameColumn(
                name: "WorkPhone",
                table: "Member",
                newName: "workphone");

            migrationBuilder.RenameColumn(
                name: "WeddingDate",
                table: "Member",
                newName: "weddingdate");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Member",
                newName: "street");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Member",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "Qualification",
                table: "Member",
                newName: "qualification");

            migrationBuilder.RenameColumn(
                name: "ProfileImage",
                table: "Member",
                newName: "profileimage");

            migrationBuilder.RenameColumn(
                name: "PinCode",
                table: "Member",
                newName: "pincode");

            migrationBuilder.RenameColumn(
                name: "Occupation",
                table: "Member",
                newName: "occupation");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "Member",
                newName: "notes");

            migrationBuilder.RenameColumn(
                name: "MobileNo",
                table: "Member",
                newName: "mobileno");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "Member",
                newName: "middlename");

            migrationBuilder.RenameColumn(
                name: "MemberCode",
                table: "Member",
                newName: "membercode");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Member",
                newName: "lastname");

            migrationBuilder.RenameColumn(
                name: "JoiningDate",
                table: "Member",
                newName: "joiningdate");

            migrationBuilder.RenameColumn(
                name: "IsSMSNotification",
                table: "Member",
                newName: "issmsnotification");

            migrationBuilder.RenameColumn(
                name: "IsMarried",
                table: "Member",
                newName: "ismarried");

            migrationBuilder.RenameColumn(
                name: "IsEmailNotification",
                table: "Member",
                newName: "isemailnotification");

            migrationBuilder.RenameColumn(
                name: "IsApproved",
                table: "Member",
                newName: "isapproved");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Member",
                newName: "isactive");

            migrationBuilder.RenameColumn(
                name: "HomePhone",
                table: "Member",
                newName: "homephone");

            migrationBuilder.RenameColumn(
                name: "HomeParish",
                table: "Member",
                newName: "homeparish");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Member",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Member",
                newName: "firstname");

            migrationBuilder.RenameColumn(
                name: "DOB",
                table: "Member",
                newName: "dob");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Member",
                newName: "country");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Member",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "BloodGroup",
                table: "Member",
                newName: "bloodgroup");

            migrationBuilder.RenameColumn(
                name: "MemberID",
                table: "Member",
                newName: "memberid");

            migrationBuilder.AlterColumn<string>(
                name: "workphone",
                table: "Member",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "street",
                table: "Member",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "state",
                table: "Member",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "qualification",
                table: "Member",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "profileimage",
                table: "Member",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "pincode",
                table: "Member",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "occupation",
                table: "Member",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "mobileno",
                table: "Member",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "middlename",
                table: "Member",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "membercode",
                table: "Member",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "lastname",
                table: "Member",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "homephone",
                table: "Member",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "homeparish",
                table: "Member",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "gender",
                table: "Member",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "firstname",
                table: "Member",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "country",
                table: "Member",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "city",
                table: "Member",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "bloodgroup",
                table: "Member",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "accoundcode",
                table: "Member",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Member",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "permanentaddress",
                table: "Member",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "presentaddress",
                table: "Member",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "subscriptionamount",
                table: "Member",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "accoundcode",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "permanentaddress",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "presentaddress",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "subscriptionamount",
                table: "Member");

            migrationBuilder.RenameColumn(
                name: "usertype",
                table: "UserLogin",
                newName: "userType");

            migrationBuilder.RenameColumn(
                name: "username",
                table: "UserLogin",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "UserLogin",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "lastloggedin",
                table: "UserLogin",
                newName: "LastLoggedIn");

            migrationBuilder.RenameColumn(
                name: "usercode",
                table: "UserLogin",
                newName: "UserCode");

            migrationBuilder.RenameColumn(
                name: "fileextension",
                table: "MST_Documents",
                newName: "FileExtension");

            migrationBuilder.RenameColumn(
                name: "docurl",
                table: "MST_Documents",
                newName: "Docurl");

            migrationBuilder.RenameColumn(
                name: "docname",
                table: "MST_Documents",
                newName: "DocName");

            migrationBuilder.RenameColumn(
                name: "docdate",
                table: "MST_Documents",
                newName: "DocDate");

            migrationBuilder.RenameColumn(
                name: "doccomment",
                table: "MST_Documents",
                newName: "DocComment");

            migrationBuilder.RenameColumn(
                name: "createddate",
                table: "MST_Documents",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "docid",
                table: "MST_Documents",
                newName: "DocId");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "MemberFamilyDetail",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "relname",
                table: "MemberFamilyDetail",
                newName: "RelName");

            migrationBuilder.RenameColumn(
                name: "relmobileno",
                table: "MemberFamilyDetail",
                newName: "RelMobileNo");

            migrationBuilder.RenameColumn(
                name: "relgender",
                table: "MemberFamilyDetail",
                newName: "RelGender");

            migrationBuilder.RenameColumn(
                name: "reldob",
                table: "MemberFamilyDetail",
                newName: "RelDOB");

            migrationBuilder.RenameColumn(
                name: "relation",
                table: "MemberFamilyDetail",
                newName: "Relation");

            migrationBuilder.RenameColumn(
                name: "memberid",
                table: "MemberFamilyDetail",
                newName: "MemberId");

            migrationBuilder.RenameColumn(
                name: "isapproved",
                table: "MemberFamilyDetail",
                newName: "IsApproved");

            migrationBuilder.RenameColumn(
                name: "emailid",
                table: "MemberFamilyDetail",
                newName: "EmailID");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "MemberFamilyDetail",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "bloodgroup",
                table: "MemberFamilyDetail",
                newName: "BloodGroup");

            migrationBuilder.RenameColumn(
                name: "address1",
                table: "MemberFamilyDetail",
                newName: "Address1");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "MemberFamilyDetail",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "memberfamilyid",
                table: "MemberFamilyDetail",
                newName: "MemberFamilyId");

            migrationBuilder.RenameColumn(
                name: "workphone",
                table: "Member",
                newName: "WorkPhone");

            migrationBuilder.RenameColumn(
                name: "weddingdate",
                table: "Member",
                newName: "WeddingDate");

            migrationBuilder.RenameColumn(
                name: "street",
                table: "Member",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "Member",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "qualification",
                table: "Member",
                newName: "Qualification");

            migrationBuilder.RenameColumn(
                name: "profileimage",
                table: "Member",
                newName: "ProfileImage");

            migrationBuilder.RenameColumn(
                name: "pincode",
                table: "Member",
                newName: "PinCode");

            migrationBuilder.RenameColumn(
                name: "occupation",
                table: "Member",
                newName: "Occupation");

            migrationBuilder.RenameColumn(
                name: "notes",
                table: "Member",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "mobileno",
                table: "Member",
                newName: "MobileNo");

            migrationBuilder.RenameColumn(
                name: "middlename",
                table: "Member",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "membercode",
                table: "Member",
                newName: "MemberCode");

            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "Member",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "joiningdate",
                table: "Member",
                newName: "JoiningDate");

            migrationBuilder.RenameColumn(
                name: "issmsnotification",
                table: "Member",
                newName: "IsSMSNotification");

            migrationBuilder.RenameColumn(
                name: "ismarried",
                table: "Member",
                newName: "IsMarried");

            migrationBuilder.RenameColumn(
                name: "isemailnotification",
                table: "Member",
                newName: "IsEmailNotification");

            migrationBuilder.RenameColumn(
                name: "isapproved",
                table: "Member",
                newName: "IsApproved");

            migrationBuilder.RenameColumn(
                name: "isactive",
                table: "Member",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "homephone",
                table: "Member",
                newName: "HomePhone");

            migrationBuilder.RenameColumn(
                name: "homeparish",
                table: "Member",
                newName: "HomeParish");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "Member",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "firstname",
                table: "Member",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "dob",
                table: "Member",
                newName: "DOB");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "Member",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Member",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "bloodgroup",
                table: "Member",
                newName: "BloodGroup");

            migrationBuilder.RenameColumn(
                name: "memberid",
                table: "Member",
                newName: "MemberID");

            migrationBuilder.AlterColumn<string>(
                name: "WorkPhone",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Qualification",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ProfileImage",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "PinCode",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Occupation",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "MobileNo",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "MemberCode",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "HomePhone",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "HomeParish",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "BloodGroup",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "Account_Code",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailId",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Permenant_Address",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Present_Address",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Subscription_Amount",
                table: "Member",
                type: "decimal(18,2)",
                nullable: true);
        }
    }
}
