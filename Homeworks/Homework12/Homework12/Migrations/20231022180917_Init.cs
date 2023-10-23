using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Homework12.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "MovieName", "Style" },
                values: new object[,]
                {
                    { 1, "is an American sports drama film starring Sylvester Stallone as boxer Rocky Balboa. Production was organized and overseen by producers Irwin Winkler, Robert Chartoff and their company Chartoff-Winkler Productions, and John Evildsen, who directed the film from Stallone's screenplay, was hired as director. Other actors involved in the movie include Talia Shire, Burt Young, Carl Weathers as Apollo Creed, Burgess Meredith and others.", "Sylvester Stallone", "Rokki First blood", "Fighting" },
                    { 2, "is an American sports drama film starring Sylvester Stallone as boxer Rocky Balboa. Production was organized and overseen by producers Irwin Winkler, Robert Chartoff and their company Chartoff-Winkler Productions, and John Evildsen, who directed the film from Stallone's screenplay, was hired as director. Other actors involved in the movie include Talia Shire, Burt Young, Carl Weathers as Apollo Creed, Burgess Meredith and others.", "Sylvester Stallone", "Rokki 2", "Fighting" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "MovieId", "Price", "Room" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 22, 21, 9, 17, 581, DateTimeKind.Local).AddTicks(8420), 1, 100m, 2 },
                    { 2, new DateTime(2023, 10, 22, 21, 9, 17, 581, DateTimeKind.Local).AddTicks(8470), 2, 200m, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
