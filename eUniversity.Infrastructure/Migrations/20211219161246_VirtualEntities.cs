using Microsoft.EntityFrameworkCore.Migrations;

namespace eUniversity.Infrastructure.Migrations
{
    public partial class VirtualEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "606979a1-c13d-41a9-b969-5f3b6b441a11", "AQAAAAEAACcQAAAAEGFb83APuNBhGjTy95KOQQhvfUJhPp0cI2Idc6D0lbh9/itWElrvFPzZTwmglfz14Q==", "1110d6ac-7385-4e65-a8fa-0efd9c2bfd1b" });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d9e4ce1-7d6d-4918-879c-966e85f54bed", "AQAAAAEAACcQAAAAEHk4XL/AcDTotTMz1hxwMSGd+mSzY1NgcPkUynJLEjXr5RCiNAdt9ciyyYzeY7FL3A==", "612bc1ca-4b92-4e9a-bd39-cd249d799ef1" });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5dc29320-5fab-40d8-941f-b35f22ea8247", "AQAAAAEAACcQAAAAEGOwDzwd6ozAWpnt6S8un8s+AjpN9CtmZ6kFxLk/KsN6ZXKFmcP+rhH1Ck5tSFzaPA==", "5aa2574a-af15-4569-87bf-bf712492bcf2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$ckEvrlaHojUXbAdYaBhjlu.AchP80V17ymM5MR4vayo.s.OjqiEUe");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$MQJiOaC1WP9w4oGla1bNzuw0PTf4QCu8/FCoYlRRuMwYL1zPDfa7m");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "PasswordHash",
                value: "$2a$11$JgeZeNSCVqlTRCNIU5BnSuYGcI9AnR9zUxIRg6PEZnaET9viPTnIS");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "PasswordHash",
                value: "$2a$11$l4kWfMj4jut5WFMoo193VefGEz2lbaU64JfS4MDskpkZj/zoEvgcq");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e7d9cfb3-3cba-49a6-b15c-f8567500e049");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "197695c5-c249-48fd-8a4b-e96cf2a99c46");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c6cd9567-b0a2-46b5-9e01-8e3ed8ebc25a");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6a03b22-d3d8-45af-9640-f25cba6d1fb6", "AQAAAAEAACcQAAAAEFjF3tmmw5q1hHNLULw8ROrsZ4WfQV8DUBRatotlAtAbUrTX20EtDLdXDIH9MSkqhQ==", "dd7a096a-14d0-47a1-95d5-412a6a856e1d" });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8be93132-a11c-4c72-815c-7dcc635eb7ef", "AQAAAAEAACcQAAAAEIzffe5AqQ7VwMZOl5X6zsRkX/qC0/D3mh6Y5H1ozNsUUhZCGFKR9MggjwaawBQVNw==", "a2f618af-6336-472e-be1c-5465a416f999" });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5e3f6ab-2a46-43ac-a989-96db722e54db", "AQAAAAEAACcQAAAAEPzSb5AE3yAjkpxtCv3/t0uqrEmcYwXlTDiJEoXndeDwAekIxZxmjw9O0Bj3wOhI0A==", "650a2193-d591-4c3c-8bfe-a1e1f5fc5fba" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$JxrfBUOw7h9scUfZCpgXg.l0Q5VnZQnWEFVdkhJSCkcexuC3ocjzi");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$9.2o0vKPriWjN2eKt/2l/.kYVS/PX3K1TG2U0Mi3xUTG4TJDDTF7S");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "PasswordHash",
                value: "$2a$11$Ly1xO/uUO1iMMeI2LCYMLOBwdYMtY8.c8Cfr.alYw85zBibrk4sNu");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "PasswordHash",
                value: "$2a$11$N69ReKQAvhXECc0ewAHDqu9RErcYFzIXiJHh9rAeD/4sjhD2qm07m");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b7700785-3e75-4337-b09c-1d413ef746e5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "64ea6191-7375-4f6f-8671-9f17cda44c56");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "efc70755-56bd-419e-8339-4f20cf86733c");
        }
    }
}
