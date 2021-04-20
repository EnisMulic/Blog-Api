using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Database.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Body", "CreatedAt", "Description", "Slug", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Et aspernatur inventore delectus sit reprehenderit commodi explicabo repudiandae odit. Vitae voluptas impedit est dolore nostrum beatae. Eaque aliquid voluptatem et mollitia numquam labore nobis iure. Quisquam nostrum reprehenderit nihil aut ut magnam. Laborum ut laborum est.", new DateTime(2020, 4, 21, 10, 50, 0, 961, DateTimeKind.Local).AddTicks(6945), "At eum corrupti odit deleniti sed aut quaerat. Aut aliquid corporis in ut alias ab explicabo nemo optio. Corrupti laborum ratione aspernatur occaecati possimus et porro.", "temporibus-vel-beatae", "Et enim illum sunt ducimus blanditiis omnis.", new DateTime(2021, 4, 20, 14, 43, 23, 980, DateTimeKind.Local).AddTicks(5070) },
                    { 9, "Quia laudantium aut voluptatem. Nisi laboriosam et consequatur ratione at. Deleniti veritatis omnis quisquam ducimus ut dolorem. Et ipsam cupiditate ea tenetur ducimus itaque. Iusto voluptas veritatis reprehenderit cum quas ut est exercitationem amet. Dolor ea illum et cumque possimus numquam nobis.", new DateTime(2020, 8, 4, 5, 4, 15, 280, DateTimeKind.Local).AddTicks(7101), "Hic et nostrum. Ullam ullam consequatur ut. Laborum quo et debitis facilis ea cumque animi. Distinctio quasi in quas aut quia optio et. Nulla est est dolorem est dolore odio aut exercitationem enim.", "architecto-illo-qui", "Perferendis quas iste aut amet est.", new DateTime(2021, 4, 20, 7, 31, 7, 203, DateTimeKind.Local).AddTicks(1864) },
                    { 8, "Vero reprehenderit aut cupiditate qui ducimus quo rem et. Exercitationem porro magni sint. Non fugit iusto voluptatum enim corporis maxime sed vitae ut. Et amet dolor veniam non repellat. Neque quo aliquid et accusamus. Eum hic animi qui et quam eum.", new DateTime(2021, 3, 26, 0, 26, 45, 161, DateTimeKind.Local).AddTicks(8310), "Excepturi qui possimus aspernatur autem reprehenderit non. Ducimus tempore aut tempora ducimus voluptatibus eos corrupti neque. Optio quod nemo. Ratione minima temporibus quasi facilis est. Unde sed excepturi ipsa ut cumque recusandae corrupti.", "dolore-voluptatem-id", "Quaerat praesentium et sint deleniti dicta dolor aut voluptatem non.", new DateTime(2021, 4, 20, 0, 15, 29, 948, DateTimeKind.Local).AddTicks(2339) },
                    { 7, "Ea sint id ullam debitis accusantium qui reiciendis tempora consectetur. Qui architecto magnam earum veritatis voluptates. Ea id at maiores consequuntur. Et molestiae ex quisquam placeat dolor non sint et.", new DateTime(2020, 5, 23, 5, 53, 17, 19, DateTimeKind.Local).AddTicks(2725), "Id et deserunt omnis inventore ut at. Amet quae qui tempore praesentium. A ea sequi assumenda molestiae aut maiores.", "vel-modi-est", "Ut magni quibusdam enim perferendis iure possimus officiis occaecati quia.", new DateTime(2021, 4, 20, 18, 36, 2, 682, DateTimeKind.Local).AddTicks(5862) },
                    { 6, "Tempore quam at. Ipsam aut enim ut repellendus id. Iusto quis debitis totam itaque nulla.", new DateTime(2020, 8, 6, 5, 45, 22, 836, DateTimeKind.Local).AddTicks(3333), "Porro vitae beatae et. Sed quasi autem perspiciatis. A laboriosam voluptatibus eveniet dolore vero necessitatibus.", "possimus-laborum-asperiores", "Consequatur minus velit ducimus velit.", new DateTime(2021, 4, 20, 21, 17, 45, 171, DateTimeKind.Local).AddTicks(5902) },
                    { 10, "Quidem quis sit quidem sit et exercitationem vel impedit. Placeat ullam ipsum et. Dolore quis aut fugit eos fuga magnam sit aperiam. Ut est non similique consequatur temporibus. Officiis odio quaerat perferendis qui.", new DateTime(2020, 11, 21, 9, 46, 20, 914, DateTimeKind.Local).AddTicks(398), "Perferendis voluptate laboriosam dolor animi. Praesentium fugiat reiciendis. Rerum nihil quaerat saepe iure nesciunt ab. Dolorem id id omnis modi corporis quo sit. Dolore ut dolorem minus libero.", "quisquam-et-possimus", "Voluptate suscipit aut itaque.", new DateTime(2021, 4, 20, 7, 51, 24, 446, DateTimeKind.Local).AddTicks(9582) },
                    { 4, "In rerum iusto. Aut et veniam eius libero nihil nemo. Illo quo fugiat pariatur illo in.", new DateTime(2021, 4, 4, 17, 31, 16, 341, DateTimeKind.Local).AddTicks(5319), "Quos soluta nesciunt consequatur aliquid facere. Ad non dolores. Occaecati quas nam tenetur laborum illo nam veritatis ducimus. Expedita fugiat odit ut nemo numquam saepe. Ex sit reiciendis veritatis blanditiis soluta facere incidunt dolor quae.", "dolorum-nesciunt-hic", "Veniam deleniti aut dolores.", new DateTime(2021, 4, 20, 11, 9, 42, 907, DateTimeKind.Local).AddTicks(1375) },
                    { 3, "Facilis veritatis delectus. Ea provident ea ea at laudantium neque et. Fugiat nesciunt voluptatum error. Ipsum et reprehenderit officia qui et sit at officiis.", new DateTime(2020, 9, 24, 14, 9, 59, 708, DateTimeKind.Local).AddTicks(9050), "Et iste cumque molestias dolor natus nostrum quia. Laudantium magni temporibus. Vitae natus nam. Sint sit ducimus omnis exercitationem quaerat vitae ut fugiat.", "tenetur-adipisci-earum", "Harum consectetur sint tenetur aliquam non qui commodi.", new DateTime(2021, 4, 20, 17, 0, 47, 895, DateTimeKind.Local).AddTicks(8911) },
                    { 2, "Sit enim magnam quia. Amet aliquid occaecati eius repellendus eos. Et porro corrupti velit est voluptatibus accusantium et a. Ad temporibus asperiores cumque dolorem ut a iste ut earum.", new DateTime(2020, 9, 4, 8, 41, 15, 10, DateTimeKind.Local).AddTicks(5588), "Placeat explicabo impedit aut molestias adipisci. Consequuntur vel accusamus voluptatum voluptatum repellat soluta quia sed. Ex possimus voluptatum corrupti consequatur.", "officia-odit-ea", "Iusto quis ad totam dolorem ut sint dolorum porro.", new DateTime(2021, 4, 20, 13, 9, 4, 6, DateTimeKind.Local).AddTicks(2500) },
                    { 5, "Sed quasi dolorum nemo unde. Suscipit voluptates aut atque ab et expedita molestiae dolor. Accusantium nisi possimus porro.", new DateTime(2020, 11, 8, 21, 19, 7, 43, DateTimeKind.Local).AddTicks(949), "Qui deserunt magni expedita non tempore numquam non. Perspiciatis aut dolorum nulla ut dolor sed alias est. Sit autem atque impedit facilis id ullam sit quis. Est occaecati libero eos. Blanditiis laudantium dignissimos reprehenderit. Omnis quia rerum architecto voluptatem ducimus et.", "tempora-reprehenderit-sunt", "Aut blanditiis ab maiores sed eum ad dolorum repudiandae iure.", new DateTime(2021, 4, 20, 7, 2, 54, 168, DateTimeKind.Local).AddTicks(5929) }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 9, new DateTime(2021, 2, 6, 14, 52, 27, 806, DateTimeKind.Local).AddTicks(8514), "pariatur", new DateTime(2021, 4, 20, 14, 44, 55, 1, DateTimeKind.Local).AddTicks(2210) },
                    { 1, new DateTime(2020, 11, 17, 8, 44, 22, 743, DateTimeKind.Local).AddTicks(5053), "et", new DateTime(2021, 4, 20, 18, 49, 33, 755, DateTimeKind.Local).AddTicks(2654) },
                    { 2, new DateTime(2021, 1, 3, 6, 34, 2, 120, DateTimeKind.Local).AddTicks(2190), "eveniet", new DateTime(2021, 4, 20, 7, 23, 46, 747, DateTimeKind.Local).AddTicks(6075) },
                    { 3, new DateTime(2021, 1, 18, 10, 9, 45, 289, DateTimeKind.Local).AddTicks(173), "laboriosam", new DateTime(2021, 4, 20, 4, 8, 50, 60, DateTimeKind.Local).AddTicks(7015) },
                    { 4, new DateTime(2020, 5, 6, 19, 22, 27, 523, DateTimeKind.Local).AddTicks(9273), "ea", new DateTime(2021, 4, 20, 19, 56, 49, 379, DateTimeKind.Local).AddTicks(8143) },
                    { 5, new DateTime(2020, 9, 5, 15, 11, 21, 386, DateTimeKind.Local).AddTicks(4107), "quasi", new DateTime(2021, 4, 20, 10, 46, 38, 660, DateTimeKind.Local).AddTicks(8448) },
                    { 6, new DateTime(2020, 8, 29, 0, 28, 40, 414, DateTimeKind.Local).AddTicks(3076), "sed", new DateTime(2021, 4, 20, 14, 1, 11, 621, DateTimeKind.Local).AddTicks(5977) },
                    { 7, new DateTime(2020, 6, 10, 19, 50, 23, 483, DateTimeKind.Local).AddTicks(2619), "voluptatem", new DateTime(2021, 4, 20, 17, 23, 40, 995, DateTimeKind.Local).AddTicks(7391) },
                    { 8, new DateTime(2021, 2, 11, 12, 0, 57, 928, DateTimeKind.Local).AddTicks(8409), "libero", new DateTime(2021, 4, 20, 18, 53, 52, 198, DateTimeKind.Local).AddTicks(4995) },
                    { 10, new DateTime(2020, 9, 3, 22, 27, 33, 494, DateTimeKind.Local).AddTicks(6876), "rerum", new DateTime(2021, 4, 20, 15, 54, 3, 799, DateTimeKind.Local).AddTicks(6838) }
                });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
