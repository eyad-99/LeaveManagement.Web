using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddPeriodToLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "a4c3bcb7-effe-4003-8890-abbf6d3796c7", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "59d34e09-aeb3-4bf4-9db6-1ae066f9654e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04298b12-3824-422f-bcb0-64a2da87c1e3", "AQAAAAEAACcQAAAAEPM01rq8yWZJTQcqIDuiBq07jNNEWaQA8WhBTCg0Ui6qdKYJpeFEt0sgVV6J2L7OYA==", "266ce406-3995-4384-8b69-12f0c280d047" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d236aa8-4692-4c70-be61-e30546727dc3", "AQAAAAEAACcQAAAAEAyX13+nPFycCmqEddAsS4iJy19dAjw8EmzJuJ4riCk8xjC2JGxAe12OZdaQigPEPw==", "af93f630-3068-4683-8674-6f7b024574a6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "3769d5aa-b26a-430f-8f11-7ed3ee97077e", "ADMINSTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "6700b464-7b5a-4d5b-8d44-ec95832ed197");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26665c83-bcc1-4ac9-b4fc-373b5275777b", "AQAAAAEAACcQAAAAEJaBkEjWdsWDX0ZEk8Y05NoBllyZq4djOS9KSV8nHsclw8wBitkQmTiTbOnUtGmivQ==", "45ce6bb3-8d65-4023-b171-051ede75cb0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12d30e55-7a55-4066-a6fe-f6d684f1ba1f", "AQAAAAEAACcQAAAAEBhCtBxcEwHQS8pMF6SihzCGW/2siTyvhZxpROo7gkq5G2Yhh/Xvv5+etEvDf6sxtA==", "d5105b20-c2a2-43c7-8961-5e1e3cff9a7e" });
        }
    }
}
