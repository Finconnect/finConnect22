using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BlogUi.Migrations
{
    public partial class test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transacrtionAgents_Agent_agentagtCd",
                table: "transacrtionAgents");

            migrationBuilder.DropForeignKey(
                name: "FK_transacrtionAgents_creditTransferInstructions_creditTransferInstructioncdTxId",
                table: "transacrtionAgents");

            migrationBuilder.DropIndex(
                name: "IX_transacrtionAgents_agentagtCd",
                table: "transacrtionAgents");

            migrationBuilder.DropIndex(
                name: "IX_transacrtionAgents_creditTransferInstructioncdTxId",
                table: "transacrtionAgents");

            migrationBuilder.DropColumn(
                name: "agentagtCd",
                table: "transacrtionAgents");

            migrationBuilder.DropColumn(
                name: "creditTransferInstructioncdTxId",
                table: "transacrtionAgents");

            migrationBuilder.AddColumn<int>(
                name: "TransacrtionAgentid",
                table: "creditTransferInstructions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransacrtionAgentid",
                table: "Agent",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_creditTransferInstructions_TransacrtionAgentid",
                table: "creditTransferInstructions",
                column: "TransacrtionAgentid");

            migrationBuilder.CreateIndex(
                name: "IX_Agent_TransacrtionAgentid",
                table: "Agent",
                column: "TransacrtionAgentid");

            migrationBuilder.AddForeignKey(
                name: "FK_Agent_transacrtionAgents_TransacrtionAgentid",
                table: "Agent",
                column: "TransacrtionAgentid",
                principalTable: "transacrtionAgents",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_creditTransferInstructions_transacrtionAgents_TransacrtionAgentid",
                table: "creditTransferInstructions",
                column: "TransacrtionAgentid",
                principalTable: "transacrtionAgents",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agent_transacrtionAgents_TransacrtionAgentid",
                table: "Agent");

            migrationBuilder.DropForeignKey(
                name: "FK_creditTransferInstructions_transacrtionAgents_TransacrtionAgentid",
                table: "creditTransferInstructions");

            migrationBuilder.DropIndex(
                name: "IX_creditTransferInstructions_TransacrtionAgentid",
                table: "creditTransferInstructions");

            migrationBuilder.DropIndex(
                name: "IX_Agent_TransacrtionAgentid",
                table: "Agent");

            migrationBuilder.DropColumn(
                name: "TransacrtionAgentid",
                table: "creditTransferInstructions");

            migrationBuilder.DropColumn(
                name: "TransacrtionAgentid",
                table: "Agent");

            migrationBuilder.AddColumn<int>(
                name: "agentagtCd",
                table: "transacrtionAgents",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "creditTransferInstructioncdTxId",
                table: "transacrtionAgents",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_transacrtionAgents_agentagtCd",
                table: "transacrtionAgents",
                column: "agentagtCd");

            migrationBuilder.CreateIndex(
                name: "IX_transacrtionAgents_creditTransferInstructioncdTxId",
                table: "transacrtionAgents",
                column: "creditTransferInstructioncdTxId");

            migrationBuilder.AddForeignKey(
                name: "FK_transacrtionAgents_Agent_agentagtCd",
                table: "transacrtionAgents",
                column: "agentagtCd",
                principalTable: "Agent",
                principalColumn: "agtCd",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_transacrtionAgents_creditTransferInstructions_creditTransferInstructioncdTxId",
                table: "transacrtionAgents",
                column: "creditTransferInstructioncdTxId",
                principalTable: "creditTransferInstructions",
                principalColumn: "cdTxId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
