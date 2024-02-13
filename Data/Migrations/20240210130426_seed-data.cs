using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("2ed3ec85-5fc6-43d9-b2a3-19f8523b9eae"), "Admin", new DateTime(2024, 2, 10, 16, 4, 21, 665, DateTimeKind.Local).AddTicks(5819), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Node.Js", false },
                    { new Guid("7d2aae5f-547f-49ee-8ff4-15046c4f8cd8"), "Admin", new DateTime(2024, 2, 10, 16, 4, 21, 665, DateTimeKind.Local).AddTicks(5781), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.net Core", false },
                    { new Guid("942f9f84-6156-40c5-adb0-93970f70e720"), "Admin", new DateTime(2024, 2, 10, 16, 4, 21, 665, DateTimeKind.Local).AddTicks(5811), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spring Boot", false }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "ModifiedBy", "ModifiedDate", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("8f770e4d-85e5-4c28-9dd3-2ca7b30c8d8d"), "Admin", new DateTime(2024, 2, 10, 16, 4, 21, 665, DateTimeKind.Local).AddTicks(8500), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/testimage_1", "jpg", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { new Guid("b0ab9960-dcf0-49ca-a313-da0f42e5e1c5"), "Admin", new DateTime(2024, 2, 10, 16, 4, 21, 665, DateTimeKind.Local).AddTicks(8517), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/testimage_3", "jpg", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { new Guid("ddd58d89-c5b1-4ce6-89d4-de833e22cd06"), "Admin", new DateTime(2024, 2, 10, 16, 4, 21, 665, DateTimeKind.Local).AddTicks(8509), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/testimage_2", "jpg", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("0053b088-307f-4557-9e48-1579f70cae0c"), new Guid("7d2aae5f-547f-49ee-8ff4-15046c4f8cd8"), "About Asp.net Core...", "Admin", new DateTime(2024, 2, 10, 16, 4, 21, 665, DateTimeKind.Local).AddTicks(2445), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8f770e4d-85e5-4c28-9dd3-2ca7b30c8d8d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.net Core Example", 15, false },
                    { new Guid("413d7d62-74e8-434e-b62c-c0fe54bf37d6"), new Guid("942f9f84-6156-40c5-adb0-93970f70e720"), "About Spring Boot...", "Admin", new DateTime(2024, 2, 10, 16, 4, 21, 665, DateTimeKind.Local).AddTicks(2459), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddd58d89-c5b1-4ce6-89d4-de833e22cd06"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spring Boot Example", 10, false },
                    { new Guid("b61f767f-bbba-4f1d-94a2-dd05b774cdd0"), new Guid("2ed3ec85-5fc6-43d9-b2a3-19f8523b9eae"), "About Node.Js...", "Admin", new DateTime(2024, 2, 10, 16, 4, 21, 665, DateTimeKind.Local).AddTicks(2469), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b0ab9960-dcf0-49ca-a313-da0f42e5e1c5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Node.Js Example", 24, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0053b088-307f-4557-9e48-1579f70cae0c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("413d7d62-74e8-434e-b62c-c0fe54bf37d6"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b61f767f-bbba-4f1d-94a2-dd05b774cdd0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ed3ec85-5fc6-43d9-b2a3-19f8523b9eae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d2aae5f-547f-49ee-8ff4-15046c4f8cd8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("942f9f84-6156-40c5-adb0-93970f70e720"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("8f770e4d-85e5-4c28-9dd3-2ca7b30c8d8d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b0ab9960-dcf0-49ca-a313-da0f42e5e1c5"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ddd58d89-c5b1-4ce6-89d4-de833e22cd06"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
