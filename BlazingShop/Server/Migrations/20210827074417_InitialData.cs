using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazingShop.Server.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 1, "book", "Arena Of Valor", "aov" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 2, "aperture", "Leagua Of Legends", "lol" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 8, 27, 14, 44, 17, 20, DateTimeKind.Local).AddTicks(6013), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "How to play pro Murad...", "https://lienquan.garena.vn/files/skin/090d96a5955687155dc3e4c46d0e383f5b86850280f19.jpg", false, false, 10.0m, 5m, "Lien Quan Mobile - Murad Play Guide" },
                    { 2, 1, new DateTime(2021, 8, 27, 14, 44, 17, 21, DateTimeKind.Local).AddTicks(6550), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "How to play pro Xeniel...", "https://lienquan.garena.vn/files/skin/bd2414ce5bb59066b6815a233837857a5c2c715549ce3.jpg", false, false, 10.0m, 7m, "Lien Quan Mobile - Xeniel Play Guide" },
                    { 3, 1, new DateTime(2021, 8, 27, 14, 44, 17, 21, DateTimeKind.Local).AddTicks(6583), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "How to play pro Nakroth...", "https://lienquan.garena.vn/files/skin/b2dbfc69db9688c3295ec4f9880187125f0d1e4e449a7.jpg", false, false, 10.0m, 9m, "Lien Quan Mobile - Nakroth Play Guide" },
                    { 4, 1, new DateTime(2021, 8, 27, 14, 44, 17, 21, DateTimeKind.Local).AddTicks(6588), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "How to play pro TRIỆU VÂN...", "https://lienquan.garena.vn/files/skin/d7342b00ec05faf09f815c74ce8306eb59d1ad95a449a.jpg", false, false, 10.0m, 13m, "Lien Quan Mobile - TRIỆU VÂN Play Guide" },
                    { 5, 1, new DateTime(2021, 8, 27, 14, 44, 17, 21, DateTimeKind.Local).AddTicks(6594), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "How to play pro Taara...", "https://lienquan.garena.vn/files/skin/a25530a02bf4bc8f5b230b2a146928ae5ec912acedcc5.png", false, false, 10.0m, 9m, "Lien Quan Mobile - Taara Play Guide" },
                    { 6, 2, new DateTime(2021, 8, 27, 14, 44, 17, 21, DateTimeKind.Local).AddTicks(6599), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "How to play pro Ahri...", "https://cdngarenanow-a.akamaihd.net/webmain/static/pss/lol/items_splash/ahri_2.jpg", false, false, 10.0m, 45m, "Lien Minh Huyen Thoai - Ahri Play Guide" },
                    { 7, 2, new DateTime(2021, 8, 27, 14, 44, 17, 21, DateTimeKind.Local).AddTicks(6602), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "How to play pro Caitlyn...", "https://cdngarenanow-a.akamaihd.net/webmain/static/pss/lol/items_splash/caitlyn_11.jpg", false, false, 10.0m, 55m, "Lien Minh Huyen Thoai - Caitlyn Play Guide" },
                    { 8, 2, new DateTime(2021, 8, 27, 14, 44, 17, 21, DateTimeKind.Local).AddTicks(6607), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "How to play pro Fiora...", "https://cdngarenanow-a.akamaihd.net/webmain/static/pss/lol/items_splash/fiora_4.jpg", false, false, 10.0m, 65m, "Lien Minh Huyen Thoai - Fiora Play Guide" },
                    { 9, 2, new DateTime(2021, 8, 27, 14, 44, 17, 21, DateTimeKind.Local).AddTicks(6611), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "How to play pro Irelia...", "https://cdngarenanow-a.akamaihd.net/webmain/static/pss/lol/items_splash/irelia_26.jpg", false, false, 10.0m, 65m, "Lien Minh Huyen Thoai - Irelia Play Guide" },
                    { 10, 2, new DateTime(2021, 8, 27, 14, 44, 17, 21, DateTimeKind.Local).AddTicks(6615), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "How to play pro Vi...", "https://cdngarenanow-a.akamaihd.net/webmain/static/pss/lol/items_splash/vi_5.jpg", false, false, 10.0m, 65m, "Lien Minh Huyen Thoai - Vi Play Guide" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
