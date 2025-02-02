using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplySignage.Migrations
{
    /// <inheritdoc />
    public partial class SignageContent_displays : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContentSchedule",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DisplayName = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DaysOfWeek = table.Column<string>(type: "TEXT", nullable: false),
                    TimeOfDay = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentSchedule", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ContentTemplate",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DisplayName = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    TemplateBody = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentTemplate", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Displays",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DisplayName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Displays", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SignageContent",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DisplayName = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    TemplateID = table.Column<long>(type: "INTEGER", nullable: false),
                    Expires = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Deleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignageContent", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SignageContent_ContentTemplate_TemplateID",
                        column: x => x.TemplateID,
                        principalTable: "ContentTemplate",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Playlist",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DisplayName = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ScheduleID = table.Column<long>(type: "INTEGER", nullable: false),
                    DisplayID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlist", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Playlist_ContentSchedule_ScheduleID",
                        column: x => x.ScheduleID,
                        principalTable: "ContentSchedule",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Playlist_Displays_DisplayID",
                        column: x => x.DisplayID,
                        principalTable: "Displays",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ContentTemplateParameter",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DisplayName = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Body = table.Column<string>(type: "TEXT", nullable: false),
                    Validation = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    ContentID = table.Column<long>(type: "INTEGER", nullable: true),
                    ContentTemplateID = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentTemplateParameter", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ContentTemplateParameter_ContentTemplate_ContentTemplateID",
                        column: x => x.ContentTemplateID,
                        principalTable: "ContentTemplate",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ContentTemplateParameter_SignageContent_ContentID",
                        column: x => x.ContentID,
                        principalTable: "SignageContent",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PlaylistItem",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemContentID = table.Column<long>(type: "INTEGER", nullable: false),
                    ScheduleID = table.Column<long>(type: "INTEGER", nullable: false),
                    PlaylistID = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PlaylistItem_ContentSchedule_ScheduleID",
                        column: x => x.ScheduleID,
                        principalTable: "ContentSchedule",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaylistItem_Playlist_PlaylistID",
                        column: x => x.PlaylistID,
                        principalTable: "Playlist",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PlaylistItem_SignageContent_ItemContentID",
                        column: x => x.ItemContentID,
                        principalTable: "SignageContent",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContentTemplateParameter_ContentID",
                table: "ContentTemplateParameter",
                column: "ContentID");

            migrationBuilder.CreateIndex(
                name: "IX_ContentTemplateParameter_ContentTemplateID",
                table: "ContentTemplateParameter",
                column: "ContentTemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_Playlist_DisplayID",
                table: "Playlist",
                column: "DisplayID");

            migrationBuilder.CreateIndex(
                name: "IX_Playlist_ScheduleID",
                table: "Playlist",
                column: "ScheduleID");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistItem_ItemContentID",
                table: "PlaylistItem",
                column: "ItemContentID");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistItem_PlaylistID",
                table: "PlaylistItem",
                column: "PlaylistID");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistItem_ScheduleID",
                table: "PlaylistItem",
                column: "ScheduleID");

            migrationBuilder.CreateIndex(
                name: "IX_SignageContent_TemplateID",
                table: "SignageContent",
                column: "TemplateID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContentTemplateParameter");

            migrationBuilder.DropTable(
                name: "PlaylistItem");

            migrationBuilder.DropTable(
                name: "Playlist");

            migrationBuilder.DropTable(
                name: "SignageContent");

            migrationBuilder.DropTable(
                name: "ContentSchedule");

            migrationBuilder.DropTable(
                name: "Displays");

            migrationBuilder.DropTable(
                name: "ContentTemplate");
        }
    }
}
