using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class TagsRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tag_Schedule_ScheduleId",
                table: "Tag");

            migrationBuilder.DropIndex(
                name: "IX_Tag_ScheduleId",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "Tag");

            migrationBuilder.CreateTable(
                name: "ScheduleTag",
                columns: table => new
                {
                    SchedulesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagsDescription = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleTag", x => new { x.SchedulesId, x.TagsDescription });
                    table.ForeignKey(
                        name: "FK_ScheduleTag_Schedule_SchedulesId",
                        column: x => x.SchedulesId,
                        principalTable: "Schedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleTag_Tag_TagsDescription",
                        column: x => x.TagsDescription,
                        principalTable: "Tag",
                        principalColumn: "Description",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleTag_TagsDescription",
                table: "ScheduleTag",
                column: "TagsDescription");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScheduleTag");

            migrationBuilder.AddColumn<Guid>(
                name: "ScheduleId",
                table: "Tag",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tag_ScheduleId",
                table: "Tag",
                column: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_Schedule_ScheduleId",
                table: "Tag",
                column: "ScheduleId",
                principalTable: "Schedule",
                principalColumn: "Id");
        }
    }
}
