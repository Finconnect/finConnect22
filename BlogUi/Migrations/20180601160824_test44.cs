using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BlogUi.Migrations
{
    public partial class test44 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "groupHeaderAgents",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    agentagtCd = table.Column<int>(type: "int", nullable: true),
                    headergrpHId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groupHeaderAgents", x => x.id);
                    table.ForeignKey(
                        name: "FK_groupHeaderAgents_Agent_agentagtCd",
                        column: x => x.agentagtCd,
                        principalTable: "Agent",
                        principalColumn: "agtCd",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_groupHeaderAgents_groupHeaders_headergrpHId",
                        column: x => x.headergrpHId,
                        principalTable: "groupHeaders",
                        principalColumn: "grpHId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_groupHeaderAgents_agentagtCd",
                table: "groupHeaderAgents",
                column: "agentagtCd");

            migrationBuilder.CreateIndex(
                name: "IX_groupHeaderAgents_headergrpHId",
                table: "groupHeaderAgents",
                column: "headergrpHId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "groupHeaderAgents");
        }
    }
}
