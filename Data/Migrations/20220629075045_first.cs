using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTLibrary.Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74aebc4e-c1ee-4a08-b98d-762ad99cbeb0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95dac70e-2e8b-4c07-88f9-6652570cbc35");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4c1a9b9e-a783-4bd7-8bbf-7cb14293f54c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2c295ebe-5635-4b1a-973a-4868f3f137fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "95dbb73f-903c-44f1-bd2f-5bca1a5831b2");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Roles", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4067588a-dc81-4e3d-a48b-6fe2c02cd626", 0, "75cc6d22-1089-40fd-8037-daf653d8ca07", "admin@gmail.com", false, "https://guantanamocity.org/wp-content/uploads/2020/12/huong-dan-tao-anh-dai-dien-hoat-hinh-tren-facebook-cach-tao-avatar-facebook-1.png", false, null, "Admin", null, null, null, "0321169923", false, "Admin", "b5d68d6a-1a84-4deb-baae-3accc253fa41", false, null },
                    { "41333015-2332-4b20-995f-2b70f0defca0", 0, "5d51e398-7088-4435-8608-c4b1ee894955", "customer@gmail.com", false, "https://guantanamocity.org/wp-content/uploads/2020/12/huong-dan-tao-anh-dai-dien-hoat-hinh-tren-facebook-cach-tao-avatar-facebook-1.png", false, null, "Customer", null, null, null, "0321333923", false, "Customer", "6e6dfd21-ac94-4a93-9d04-e45368e258c0", false, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4067588a-dc81-4e3d-a48b-6fe2c02cd626");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41333015-2332-4b20-995f-2b70f0defca0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5d1de023-c296-4e83-9c27-299f003b34e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1d24ea5d-0a3e-4880-a36a-c4e5e717304b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "551c5186-5b99-41d7-9433-f83c2b5274ca");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Roles", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "95dac70e-2e8b-4c07-88f9-6652570cbc35", 0, "5635c502-cbfb-43ea-98a0-58cba79038a5", "admin@gmail.com", false, "https://guantanamocity.org/wp-content/uploads/2020/12/huong-dan-tao-anh-dai-dien-hoat-hinh-tren-facebook-cach-tao-avatar-facebook-1.png", false, null, "Admin", null, null, null, "0321169923", false, "Admin", "659184ef-8cc5-4f7c-9cae-0b490e019342", false, null },
                    { "74aebc4e-c1ee-4a08-b98d-762ad99cbeb0", 0, "6c6d980a-0d6f-4435-bfc9-96555eae2264", "customer@gmail.com", false, "https://guantanamocity.org/wp-content/uploads/2020/12/huong-dan-tao-anh-dai-dien-hoat-hinh-tren-facebook-cach-tao-avatar-facebook-1.png", false, null, "Customer", null, null, null, "0321333923", false, "Customer", "53ea6b52-54e4-4be9-ad82-2d654149f626", false, null }
                });
        }
    }
}
