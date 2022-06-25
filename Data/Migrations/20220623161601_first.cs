using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTLibrary.Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 200, nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Mobile = table.Column<string>(maxLength: 13, nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 200, nullable: false),
                    Mobile = table.Column<string>(maxLength: 13, nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Store_Owners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 200, nullable: false),
                    Mobile = table.Column<string>(maxLength: 13, nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Author = table.Column<string>(maxLength: 100, nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Published_Date = table.Column<DateTime>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "Id", "Email", "Image", "Mobile", "Name", "Password" },
                values: new object[] { 1, "admin@gmail.com", "https://guantanamocity.org/wp-content/uploads/2020/12/huong-dan-tao-anh-dai-dien-hoat-hinh-tren-facebook-cach-tao-avatar-facebook-1.png", "0321169923", "Admin", "admin@123" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "ff0c5a03-2657-4393-94e0-6e7a5131fbe8", "Admin", "ADMIN" },
                    { "2", "dee035fe-9d10-4018-b7e1-ebce200f2643", "Store Owner", "STORE OWNER" },
                    { "3", "287d51a5-56e2-4045-abb3-57a59b6d5995", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "https://cdn-amz.fadoglobal.io/images/I/81o791tFXeS.jpg", "Politics" },
                    { 2, "https://cdn2.f-cdn.com/contestentries/1121968/17989453/59a8471fb17b9_thumb900.jpg", "Horror" },
                    { 3, "https://www.inquirer.com/resizer/rJ2GQrjd5GR5ruMdmhLbBdJesCY=/filters:format(webp)/cloudfront-us-east-1.images.arcpublishing.com/pmn/SRCJLCGZVBBPTJSRAFMSX34GOM.jpg", "Romance" },
                    { 4, "https://cdn0.fahasa.com/media/catalog/product/t/h/the_science_book_big_ideas_simply_explained_1_2021_08_28_12_21_00.jpg", "Science" },
                    { 5, "https://m.media-amazon.com/images/I/41m0T7VZwAL.jpg", "Science fiction & mystery" },
                    { 6, "https://www.casino.org/news/wp-content/uploads/2021/06/Screen-Shot-2021-06-24-at-11.57.05-AM.png", "Sport" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Email", "FirstName", "Image", "LastName", "Mobile", "Password" },
                values: new object[,]
                {
                    { 1, "Tay Ho", "phamkhacthanhphong@gmail.com", "Phong", "https://guantanamocity.org/wp-content/uploads/2020/12/huong-dan-tao-anh-dai-dien-hoat-hinh-tren-facebook-cach-tao-avatar-facebook-1.png", "Pham", "0321169923", "phong" },
                    { 2, "Nam Dinh", "vubinhchuong@gmail.com", "Chuong", "https://static.toiimg.com/thumb/resizemode-4,msid-76729750,imgsize-249247,width-720/76729750.jpg", "Vu", "0324164953", "chuong" },
                    { 3, "Nam Dinh", "phamhoanglong@gmail.com", "Long", "https://guantanamocity.org/wp-content/uploads/2020/12/huong-dan-tao-anh-dai-dien-hoat-hinh-tren-facebook-cach-tao-avatar-facebook-1.png", "Pham", "0324664553", "long" }
                });

            migrationBuilder.InsertData(
                table: "Store_Owners",
                columns: new[] { "Id", "Address", "Email", "Image", "Mobile", "Name", "Password" },
                values: new object[] { 1, "Hanoi", "storeowner@gmail.com", "https://static2.yan.vn/YanNews/2167221/202102/facebook-cap-nhat-avatar-doi-voi-tai-khoan-khong-su-dung-anh-dai-dien-e4abd14d.jpg", "0324664553", "StoreOwner", "storeowner@123" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "Image", "Name", "Price", "Published_Date", "Quantity" },
                values: new object[,]
                {
                    { 3, "Rosalind S. Helderman", 1, "One of the most urgent and important investigations ever conducted, the Mueller inquiry focuses on Donald Trump, his presidential campaign, and Russian interference in the 2016 election, and draws on the testimony of dozens of witnesses and the work of some of the country’s most seasoned prosecutors.", "https://m.media-amazon.com/images/P/B07PB76691.01._SCLZZZZZZZ_SX500_.jpg", "The Mueller Report", 300.0, new DateTime(2013, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 2, "Bram Stoker", 2, "The novel has no single protagonist, but opens with solicitor Jonathan Harker taking a business trip to stay at the castle of a Transylvanian noble, Count Dracula. Harker escapes the castle after discovering that Dracula is a vampire, and the Count moves to England and plagues the seaside town of Whitby. A small group, led by Abraham Van Helsing, hunt Dracula and, in the end, kill him.", "https://thebookmarketng.com/wp-content/uploads/2020/08/dracula.jpg", "Dracula", 700.0, new DateTime(1897, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 4, "Stephen King", 2, "IT tells the story of seven friends who face an evil shape shifting entity that feeds on the fears of children. One of IT’s favorite disguises is a circus clown called Pennywise, otherwise known as 'Bob Gray'.", "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781982127794/it-9781982127794_hr.jpg", "IT", 800.0, new DateTime(1986, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { 1, "Makoto Shinkai", 3, "A comet appears and mysteriously affects and connects the lives of two teenagers of the same age, a boy in the big, bustling city of Tokyo and a girl in a country village where life is slow but idyllic. They find for unknown reasons, they wake up in each other's bodies for weeks at a time. At first, they both think these experiences are just vivid dreams, but when the reality of their situations sinks in, they learn to adjust and even enjoy it. Soon they start to communicate and try to leave notes about who they are and what they are doing. But as they discover more about each other and the other's life, they uncover some disturbing hints that their distance is more than just physical and tragedy haunts them.", "https://upload.wikimedia.org/wikipedia/vi/b/b3/Your_Name_novel.jpg", "Your Name", 500.0, new DateTime(2016, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 5, "Dan Simmons", 4, "On the world called Hyperion, beyond the reach of galactic law, waits a creature called the Shrike. There are those who worship it. There are those who fear it. And there are those who have vowed to destroy it. In the Valley of the Time Tombs, where huge, brooding structures move backward through time, the Shrike waits for them all. On the eve of Armageddon, with the entire galaxy at war, seven pilgrims set forth on a final voyage to Hyperion seeking the answers to the unsolved riddles of their lives. Each carries a desperate hope—and a terrible secret. And one may hold the fate of humanity in his hands.", "https://m.media-amazon.com/images/P/0399178619.01._SCLZZZZZZZ_SX500_.jpg", "Hyperion", 400.0, new DateTime(1990, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 6, "Orson Scott Card", 4, "In order to develop a secure defense against a hostile alien race's next attack, government agencies breed child geniuses and train them as soldiers. A brilliant young boy, Andrew Ender Wiggin lives with his kind but distant parents, his sadistic brother Peter, and the person he loves more than anyone else, his sister Valentine. Peter and Valentine were candidates for the soldier-training program but didn't make the cut--young Ender is the Wiggin drafted to the orbiting Battle School for rigorous military training. Ender's skills make him a leader in school and respected in the Battle Room, where children play at mock battles in zero gravity. Yet growing up in an artificial community of young soldiers, Ender suffers greatly from isolation, rivalry from his peers, pressure from the adult teachers, and an unsettling fear of the alien invaders. His psychological battles include loneliness, fear that he is becoming like the cruel brother he remembers, and fanning the flames of devotion to his beloved sister. Is Ender the general Earth needs? But Ender is not the only result of the genetic experiments. The war with the Buggers has been raging for a hundred years, and the quest for the perfect general has been underway for almost as long. Ender's two older siblings are every bit as unusual as he is, but in very different ways. Between the three of them lie the abilities to remake a world. If the world survives, that is. ", "https://images-na.ssl-images-amazon.com/images/I/81+IUsYtGTL.jpg", "Ender's Game", 350.0, new DateTime(1994, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 7, "Jeff Goldberg", 6, "The main subject of the book is the Big East Tournament championship game of 2001, although the book intersperses play by play coverage of the game with background information on the entire season, as well as commentary on the players, coaches and other aspects of the two programs. The game featured in the book was neither the first nor the last meeting of the two teams in the season.[3] In January, UConn played Notre Dame at Notre Dame. The UConn team was undefeated, and ranked number one in the country at the start of the game. Notre Dame won 92–76, remained undefeated, and moved from third to the number one ranking at the next poll.[4] Both teams would also meet in the semifinals of the NCAA Tournament, with Notre Dame prevailing and then going on to win the national championship. All of the meetings between the two teams that year were important games for each team, but the game in March had multiple story lines—a tournament championship at stake, a close game in which neither team led by more than eight points at any time, a devastating injury to one of the game's best players, and finally, a game that was decided by a single basket scored in the final moments, by one of the best players in the sport, Sue Bird.", "https://upload.wikimedia.org/wikipedia/en/a/a3/Bird_at_the_Buzzer_cover.jpg", "Bird at the Buzzer", 200.0, new DateTime(2011, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Store_Owners");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");
        }
    }
}
