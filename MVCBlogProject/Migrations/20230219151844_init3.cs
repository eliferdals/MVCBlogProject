using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCBlogProject.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c6316c44-65e1-4879-80e4-9bf8894cfcd3", "3ec98f66-93f8-4940-9b78-21597a33af01" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6c7e1527-eaad-4c73-91da-a060aaeb865a", "fb40a4cc-e191-4521-8dd4-3120a358bb44" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c7e1527-eaad-4c73-91da-a060aaeb865a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6316c44-65e1-4879-80e4-9bf8894cfcd3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ec98f66-93f8-4940-9b78-21597a33af01");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb40a4cc-e191-4521-8dd4-3120a358bb44");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Article",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3db9bd14-d0e1-40f4-b884-1f70d4fffe2d", "87459e58-394e-47f2-a89f-0898cb4cbb2f", "Visitor", "VISITOR" },
                    { "7f5f294b-536d-4b11-9e62-9bd84a25fb4a", "785becd9-bba2-4281-a839-24467fc4fe9c", "Writer", "WRITER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Description", "Email", "EmailConfirmed", "FirstName", "ImagePath", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1123b88b-e9eb-4e99-9968-d507658335d6", 0, "1023e1fe-9cda-41bc-9274-3dfd6734ac04", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "writer@writer.com", true, "Writer", null, "Writer", false, null, "WRITER@WRITER.COM", "WRITER@WRITER.COM", "AQAAAAEAACcQAAAAECbnc+tceyCc3V/rwMIYouow1UYQgHTp0GZlapQYi9Q6xkCAV90YYxwr0PF4qaZ1rQ==", null, false, "251f78f4-cf63-4f0c-96e7-3ef43f599fa9", false, "writer@writer.com" },
                    { "4e844ced-6701-4ec3-bf8b-077b160915af", 0, "c0ca0443-2ab4-4c80-8b9f-5d3211add58e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "visitor@visitor.com", true, "Visitor", null, "Visitor", false, null, "VISITOR@VISITOR.COM", "VISITOR@VISITOR.COM", "AQAAAAEAACcQAAAAEDJ8+oQ+BEwJWVlv13Sz2EUhjJP2qx17LlHoq3Hf8fL7InRAuAfdEU8WZfSGiN5nPQ==", null, false, "2529901c-d1ea-4899-9352-2cf3d64e4df7", false, "visitor@visitor.com" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "1123b88b-e9eb-4e99-9968-d507658335d6");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7f5f294b-536d-4b11-9e62-9bd84a25fb4a", "1123b88b-e9eb-4e99-9968-d507658335d6" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3db9bd14-d0e1-40f4-b884-1f70d4fffe2d", "4e844ced-6701-4ec3-bf8b-077b160915af" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7f5f294b-536d-4b11-9e62-9bd84a25fb4a", "1123b88b-e9eb-4e99-9968-d507658335d6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3db9bd14-d0e1-40f4-b884-1f70d4fffe2d", "4e844ced-6701-4ec3-bf8b-077b160915af" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3db9bd14-d0e1-40f4-b884-1f70d4fffe2d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f5f294b-536d-4b11-9e62-9bd84a25fb4a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1123b88b-e9eb-4e99-9968-d507658335d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e844ced-6701-4ec3-bf8b-077b160915af");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Article");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6c7e1527-eaad-4c73-91da-a060aaeb865a", "50ed66da-fce5-4169-9001-fa76987471e2", "Visitor", "VISITOR" },
                    { "c6316c44-65e1-4879-80e4-9bf8894cfcd3", "5f3b49de-609a-42f6-a4b3-77ab3d224b06", "Writer", "WRITER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Description", "Email", "EmailConfirmed", "FirstName", "ImagePath", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3ec98f66-93f8-4940-9b78-21597a33af01", 0, "b9332693-7fd5-438f-a4e2-feeef72c28e0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "writer@writer.com", true, "Writer", null, "Writer", false, null, "WRITER@WRITER.COM", "WRITER@WRITER.COM", "AQAAAAEAACcQAAAAEHFYP0fcoAQigWbagpg9xZwbKvO1US8SiHb/27acrBvkHWzDbCCcNGoBPnP6rLuvxQ==", null, false, "82088918-1068-4a2c-80b4-1d155bbf32b2", false, "writer@writer.com" },
                    { "fb40a4cc-e191-4521-8dd4-3120a358bb44", 0, "bd5b53b3-f8e9-4762-9a49-9de5b6ad4e22", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "visitor@visitor.com", true, "Visitor", null, "Visitor", false, null, "VISITOR@VISITOR.COM", "VISITOR@VISITOR.COM", "AQAAAAEAACcQAAAAEMmgJg98CJEHcAkdo5CLVdUxOQQGjGbod9FTNYDaQ5Nk+onWbTUQQ3ksaq6jCXl/xA==", null, false, "8a171b62-69df-40cb-9555-d3e68e8dd77e", false, "visitor@visitor.com" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "3ec98f66-93f8-4940-9b78-21597a33af01");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c6316c44-65e1-4879-80e4-9bf8894cfcd3", "3ec98f66-93f8-4940-9b78-21597a33af01" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6c7e1527-eaad-4c73-91da-a060aaeb865a", "fb40a4cc-e191-4521-8dd4-3120a358bb44" });
        }
    }
}
