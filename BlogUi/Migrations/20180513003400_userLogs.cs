using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BlogUi.Migrations
{
    public partial class userLogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "craditTransferInstructionLogs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    creditTransferInstructioncdTxId = table.Column<int>(type: "int", nullable: true),
                    dateInserted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userInserted = table.Column<int>(type: "int", nullable: false),
                    userModified = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_craditTransferInstructionLogs", x => x.id);
                    table.ForeignKey(
                        name: "FK_craditTransferInstructionLogs_creditTransferInstructions_creditTransferInstructioncdTxId",
                        column: x => x.creditTransferInstructioncdTxId,
                        principalTable: "creditTransferInstructions",
                        principalColumn: "cdTxId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_craditTransferInstructionLogs_creditTransferInstructioncdTxId",
                table: "craditTransferInstructionLogs",
                column: "creditTransferInstructioncdTxId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "craditTransferInstructionLogs");
        }
    }
}
