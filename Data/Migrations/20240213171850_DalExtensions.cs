using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class DalExtensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Images",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Images",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Articles",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Articles",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("42bb230b-7ae4-4167-a920-78501cca15ce"), new Guid("2ed3ec85-5fc6-43d9-b2a3-19f8523b9eae"), "About Node.Js...", "Admin", new DateTime(2024, 2, 13, 20, 18, 45, 235, DateTimeKind.Local).AddTicks(458), null, null, new Guid("b0ab9960-dcf0-49ca-a313-da0f42e5e1c5"), null, null, "Node.Js Example", 24, false },
                    { new Guid("5a71a730-bd2a-4cfc-8c62-216a52cf2bd4"), new Guid("7d2aae5f-547f-49ee-8ff4-15046c4f8cd8"), "About Asp.net Core...", "Admin", new DateTime(2024, 2, 13, 20, 18, 45, 235, DateTimeKind.Local).AddTicks(413), null, null, new Guid("8f770e4d-85e5-4c28-9dd3-2ca7b30c8d8d"), null, null, "Asp.net Core Example", 15, false },
                    { new Guid("ae7e7f60-f8d0-4c1c-9e75-c5d1f7dd5ab2"), new Guid("942f9f84-6156-40c5-adb0-93970f70e720"), "About Spring Boot...", "Admin", new DateTime(2024, 2, 13, 20, 18, 45, 235, DateTimeKind.Local).AddTicks(426), null, null, new Guid("ddd58d89-c5b1-4ce6-89d4-de833e22cd06"), null, null, "Spring Boot Example", 10, false }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ed3ec85-5fc6-43d9-b2a3-19f8523b9eae"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 13, 20, 18, 45, 235, DateTimeKind.Local).AddTicks(3748), null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d2aae5f-547f-49ee-8ff4-15046c4f8cd8"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 13, 20, 18, 45, 235, DateTimeKind.Local).AddTicks(3732), null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("942f9f84-6156-40c5-adb0-93970f70e720"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 13, 20, 18, 45, 235, DateTimeKind.Local).AddTicks(3742), null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("8f770e4d-85e5-4c28-9dd3-2ca7b30c8d8d"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 13, 20, 18, 45, 235, DateTimeKind.Local).AddTicks(6640), null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b0ab9960-dcf0-49ca-a313-da0f42e5e1c5"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 13, 20, 18, 45, 235, DateTimeKind.Local).AddTicks(6657), null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ddd58d89-c5b1-4ce6-89d4-de833e22cd06"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 13, 20, 18, 45, 235, DateTimeKind.Local).AddTicks(6650), null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("42bb230b-7ae4-4167-a920-78501cca15ce"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5a71a730-bd2a-4cfc-8c62-216a52cf2bd4"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ae7e7f60-f8d0-4c1c-9e75-c5d1f7dd5ab2"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Articles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Articles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("0053b088-307f-4557-9e48-1579f70cae0c"), new Guid("7d2aae5f-547f-49ee-8ff4-15046c4f8cd8"), "About Asp.net Core...", "Admin", new DateTime(2024, 2, 10, 16, 4, 21, 665, DateTimeKind.Local).AddTicks(2445), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8f770e4d-85e5-4c28-9dd3-2ca7b30c8d8d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.net Core Example", 15, false },
                    { new Guid("413d7d62-74e8-434e-b62c-c0fe54bf37d6"), new Guid("942f9f84-6156-40c5-adb0-93970f70e720"), "About Spring Boot...", "Admin", new DateTime(2024, 2, 10, 16, 4, 21, 665, DateTimeKind.Local).AddTicks(2459), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddd58d89-c5b1-4ce6-89d4-de833e22cd06"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spring Boot Example", 10, false },
                    { new Guid("b61f767f-bbba-4f1d-94a2-dd05b774cdd0"), new Guid("2ed3ec85-5fc6-43d9-b2a3-19f8523b9eae"), "About Node.Js...", "Admin", new DateTime(2024, 2, 10, 16, 4, 21, 665, DateTimeKind.Local).AddTicks(2469), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b0ab9960-dcf0-49ca-a313-da0f42e5e1c5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Node.Js Example", 24, false }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ed3ec85-5fc6-43d9-b2a3-19f8523b9eae"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 16, 4, 21, 665, DateTimeKind.Local).AddTicks(5819), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d2aae5f-547f-49ee-8ff4-15046c4f8cd8"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 16, 4, 21, 665, DateTimeKind.Local).AddTicks(5781), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("942f9f84-6156-40c5-adb0-93970f70e720"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 16, 4, 21, 665, DateTimeKind.Local).AddTicks(5811), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("8f770e4d-85e5-4c28-9dd3-2ca7b30c8d8d"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 16, 4, 21, 665, DateTimeKind.Local).AddTicks(8500), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b0ab9960-dcf0-49ca-a313-da0f42e5e1c5"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 16, 4, 21, 665, DateTimeKind.Local).AddTicks(8517), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ddd58d89-c5b1-4ce6-89d4-de833e22cd06"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 16, 4, 21, 665, DateTimeKind.Local).AddTicks(8509), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
