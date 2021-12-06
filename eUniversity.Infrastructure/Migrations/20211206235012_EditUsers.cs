using Microsoft.EntityFrameworkCore.Migrations;

namespace eUniversity.Infrastructure.Migrations
{
    public partial class EditUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Teachers",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Students",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Admins",
                newName: "UserName");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Teachers",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Students",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Admins",
                newName: "Username");

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f94f4d8-bf91-4f0e-bea9-1982e0a3daf2", "AQAAAAEAACcQAAAAELHtdaF2BhEhRZ3zZSeOruII6vwSKxhWu0vYNeA0y3b6IODhmYY5eBw3F5XaErm4WA==", "ad116261-669f-487a-b351-cba107b73ae3" });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "301ed5ee-fbf1-47ee-a618-97a35b487c24", "AQAAAAEAACcQAAAAEO68iYSljcC0l3fBBwNFfnSFPtr+gNe/atpmVxcjbX/DaSd8xM8ws0gvyCbTOiBOjg==", "1493e23b-d4e4-4644-8821-f96dd6924418" });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4578b4d6-5045-4f50-bbe6-e60f7c8e42e2", "AQAAAAEAACcQAAAAELonVY/1YhkbXzZYvm8MMLEVBF2K0V689Jo/2NMV5uYw769yyl/ahypH915/I18x3w==", "2ff0531e-5dd1-4dbf-9f42-630f22ec15f9" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$aamtd6IlaXwoihfO0zAmj.Mek13GfiHDtIWDKT.p/Kis7C.lQANEO");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$/XfUh2ZbkdHXL6RfASSe2Oz.wjjl4IPyMv0aiGkW5v/QNRyBgAXvO");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "PasswordHash",
                value: "$2a$11$mhGYT9gM9kUw1xDbe2/oqegplfarVlvOb92z3slmRymmlEv8vdmm6");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "PasswordHash",
                value: "$2a$11$o45Al5kerbsSfBdjDaBPQu1/vAszCEgVthZ8u4CsAECifYZ4ZjDU6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e3304093-1c61-43e3-bffc-48de16bc2729");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "676b88ee-d1c4-4827-b6ec-3346eccfac58");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "d597e4da-2f16-4086-9a7b-49fafc7128e6");
        }
    }
}
