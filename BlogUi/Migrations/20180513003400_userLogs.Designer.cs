﻿// <auto-generated />
using BlogUi.Ef;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BlogUi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180513003400_userLogs")]
    partial class userLogs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogUi.Models.Agent", b =>
                {
                    b.Property<int>("agtCd")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CreditTransferInstructioncdTxId");

                    b.Property<string>("agtAccount");

                    b.Property<string>("agtAdrLine");

                    b.Property<string>("agtAdrTp");

                    b.Property<string>("agtBIC");

                    b.Property<string>("agtBldgNb");

                    b.Property<string>("agtBranchFlag");

                    b.Property<string>("agtBranchname");

                    b.Property<string>("agtBrnchId");

                    b.Property<int>("agtClrSystemID");

                    b.Property<int>("agtClrsSystemPrtry");

                    b.Property<string>("agtCtryDiv");

                    b.Property<string>("agtCtryName");

                    b.Property<string>("agtCtrySubDvsn");

                    b.Property<string>("agtDept");

                    b.Property<string>("agtIBAN");

                    b.Property<string>("agtName");

                    b.Property<string>("agtOthr");

                    b.Property<string>("agtPostCode");

                    b.Property<string>("agtPrtryID");

                    b.Property<string>("agtPrtryIssuer");

                    b.Property<string>("agtStreet");

                    b.Property<string>("agtSubDept");

                    b.Property<string>("agtTownName");

                    b.Property<string>("agtTypeFlag");

                    b.HasKey("agtCd");

                    b.HasIndex("CreditTransferInstructioncdTxId");

                    b.ToTable("Agent");
                });

            modelBuilder.Entity("BlogUi.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("BlogUi.Models.CountryCode", b =>
                {
                    b.Property<int>("ctryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ctryCode");

                    b.Property<string>("ctryNm");

                    b.HasKey("ctryId");

                    b.ToTable("CountryCodes");
                });

            modelBuilder.Entity("BlogUi.Models.CraditTransferInstructionLogs", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("creditTransferInstructioncdTxId");

                    b.Property<DateTime>("dateInserted");

                    b.Property<DateTime>("dateModified");

                    b.Property<int>("userInserted");

                    b.Property<int>("userModified");

                    b.HasKey("id");

                    b.HasIndex("creditTransferInstructioncdTxId");

                    b.ToTable("craditTransferInstructionLogs");
                });

            modelBuilder.Entity("BlogUi.Models.CreditTransferInstruction", b =>
                {
                    b.Property<int>("cdTxId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ccyId");

                    b.Property<string>("chrgBr");

                    b.Property<int?>("grpHId");

                    b.Property<string>("instInf");

                    b.Property<decimal>("intrBkSttlmAm");

                    b.Property<string>("msgDir");

                    b.Property<string>("pmtIdEndToEndId");

                    b.Property<string>("pmtIdTxId");

                    b.HasKey("cdTxId");

                    b.HasIndex("ccyId");

                    b.HasIndex("grpHId");

                    b.ToTable("creditTransferInstructions");
                });

            modelBuilder.Entity("BlogUi.Models.CreditTransferInstructionReturn", b =>
                {
                    b.Property<int>("cdrtxId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CreditTransferInstructioncdTxId");

                    b.Property<string>("msgDir");

                    b.Property<string>("ogrSvcLvlPrtry");

                    b.Property<string>("orgClrSysRef");

                    b.Property<DateTime>("orgDtTm");

                    b.Property<string>("orgEndToEndId");

                    b.Property<string>("orgMsgId");

                    b.Property<string>("orgMsgNmId");

                    b.Property<string>("orgTxId");

                    b.Property<decimal>("orgTxRefIntrBKSttlmAmt");

                    b.Property<DateTime>("orgTxRefIntrBKSttlmDt");

                    b.Property<string>("rtrId");

                    b.Property<string>("rtrRsnInfPrtry");

                    b.Property<decimal>("rtrdIntrBKSttlAmt");

                    b.HasKey("cdrtxId");

                    b.HasIndex("CreditTransferInstructioncdTxId");

                    b.ToTable("creditTransferInstructionReturns");
                });

            modelBuilder.Entity("BlogUi.Models.CreditTransferStatus", b =>
                {
                    b.Property<int>("txStsId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("clrSysRef");

                    b.Property<string>("orgEndToEndId");

                    b.Property<string>("orgTxId");

                    b.Property<string>("orgTxRefCdtrAgtBIC");

                    b.Property<string>("orgTxRefDbtrAgtBIC");

                    b.Property<decimal>("orgTxRefIntrBKSttlmAmt");

                    b.Property<DateTime>("orgTxRefIntrBkSttlDt");

                    b.Property<string>("stsId");

                    b.Property<string>("stsRsnPrtry");

                    b.HasKey("txStsId");

                    b.ToTable("creditTransferStatuses");
                });

            modelBuilder.Entity("BlogUi.Models.Currency", b =>
                {
                    b.Property<int>("ccyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ccyCd");

                    b.Property<decimal>("ccyExch");

                    b.Property<string>("ccyNm");

                    b.HasKey("ccyId");

                    b.ToTable("currencies");
                });

            modelBuilder.Entity("BlogUi.Models.GroupHeader", b =>
                {
                    b.Property<int>("grpHId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("GRPHRTRID");

                    b.Property<int?>("GRPHSTSID");

                    b.Property<bool>("GRPRTR");

                    b.Property<string>("GRPTYPE");

                    b.Property<int?>("_ORGMSGSTATUSIDorgMsgStatusId");

                    b.Property<DateTime>("creDtTm");

                    b.Property<DateTime>("intrBkSttlmDt");

                    b.Property<string>("msgId");

                    b.Property<decimal>("nbOfTxs");

                    b.Property<string>("sttlImInfSttlmMtd");

                    b.Property<string>("sttlInfPrtry");

                    b.Property<decimal>("ttlIntrBKSttlmAmt");

                    b.HasKey("grpHId");

                    b.HasIndex("_ORGMSGSTATUSIDorgMsgStatusId");

                    b.ToTable("groupHeaders");
                });

            modelBuilder.Entity("BlogUi.Models.GroupHeaderReturn", b =>
                {
                    b.Property<int>("grpHrtId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("GroupHeadergrpHId");

                    b.Property<DateTime>("creDtTm");

                    b.Property<bool>("grpRtr");

                    b.Property<DateTime>("intrBkSttlmDt");

                    b.Property<string>("msgId");

                    b.Property<decimal>("nbOfTxs");

                    b.Property<string>("sttlImInfSttlmMtd");

                    b.Property<string>("sttlInfPrtry");

                    b.Property<decimal>("ttlRtrdIntrBKSttlmAmt");

                    b.HasKey("grpHrtId");

                    b.HasIndex("GroupHeadergrpHId");

                    b.ToTable("groupHeaderReturns");
                });

            modelBuilder.Entity("BlogUi.Models.GroupHeaderStatus", b =>
                {
                    b.Property<int>("grpHStsId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("GroupHeadergrpHId");

                    b.Property<DateTime>("creDtTm");

                    b.Property<string>("msgId");

                    b.HasKey("grpHStsId");

                    b.HasIndex("GroupHeadergrpHId");

                    b.ToTable("groupHeaderStatuses");
                });

            modelBuilder.Entity("BlogUi.Models.OrgMsgStatus", b =>
                {
                    b.Property<int>("orgMsgStatusId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("dtldCtrlSum");

                    b.Property<decimal>("dtldNbOfTxs");

                    b.Property<string>("dtldSts");

                    b.Property<string>("orgMsgId");

                    b.Property<string>("orgMsgNmId");

                    b.Property<decimal>("orgNbOfTx");

                    b.Property<string>("stsRsnAddtlInf");

                    b.Property<string>("stsRsnInfPrtry");

                    b.HasKey("orgMsgStatusId");

                    b.ToTable("orgMsgStatuses");
                });

            modelBuilder.Entity("BlogUi.Models.Party", b =>
                {
                    b.Property<int>("prtyId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("creditTransferInstructionscdTxId");

                    b.Property<string>("prtyAcctIBAN");

                    b.Property<string>("prtyAcctOthrId");

                    b.Property<string>("prtyAddLine");

                    b.Property<string>("prtyBldgNb");

                    b.Property<string>("prtyCtryCd");

                    b.Property<string>("prtyCtrySubDvsn");

                    b.Property<string>("prtyDep");

                    b.Property<string>("prtyNm");

                    b.Property<string>("prtyPstCd");

                    b.Property<string>("prtyStrNm");

                    b.Property<string>("prtySubDep");

                    b.Property<string>("prtyTwnNm");

                    b.Property<string>("prtyType");

                    b.Property<string>("prtyadrTp");

                    b.HasKey("prtyId");

                    b.HasIndex("creditTransferInstructionscdTxId");

                    b.ToTable("Party");
                });

            modelBuilder.Entity("BlogUi.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogId");

                    b.Property<string>("Body");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("BlogUi.Models.ReasonCode", b =>
                {
                    b.Property<int>("rsnId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("rsnDesc");

                    b.Property<string>("rsnNm");

                    b.HasKey("rsnId");

                    b.ToTable("reasonCodes");
                });

            modelBuilder.Entity("BlogUi.Models.StatusCode", b =>
                {
                    b.Property<int>("stsCodeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("stsCode");

                    b.Property<string>("stsDesc");

                    b.Property<string>("stsName");

                    b.HasKey("stsCodeId");

                    b.ToTable("statusCodes");
                });

            modelBuilder.Entity("BlogUi.Models.TransacrtionAgent", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("agentagtCd");

                    b.Property<int?>("creditTransferInstructioncdTxId");

                    b.HasKey("id");

                    b.HasIndex("agentagtCd");

                    b.HasIndex("creditTransferInstructioncdTxId");

                    b.ToTable("transacrtionAgents");
                });

            modelBuilder.Entity("BlogUi.Models.TransactionParty", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("creditTransferInstructioncdTxId");

                    b.Property<int?>("partyprtyId");

                    b.HasKey("id");

                    b.HasIndex("creditTransferInstructioncdTxId");

                    b.HasIndex("partyprtyId");

                    b.ToTable("transactionParties");
                });

            modelBuilder.Entity("BlogUi.Models.XmlToDatabase", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("XmlGenerated");

                    b.Property<string>("fileName");

                    b.Property<int?>("grpHId");

                    b.HasKey("id");

                    b.HasIndex("grpHId");

                    b.ToTable("XmlDoc");
                });

            modelBuilder.Entity("BlogUi.Models.Agent", b =>
                {
                    b.HasOne("BlogUi.Models.CreditTransferInstruction")
                        .WithMany("agents")
                        .HasForeignKey("CreditTransferInstructioncdTxId");
                });

            modelBuilder.Entity("BlogUi.Models.CraditTransferInstructionLogs", b =>
                {
                    b.HasOne("BlogUi.Models.CreditTransferInstruction", "creditTransferInstruction")
                        .WithMany()
                        .HasForeignKey("creditTransferInstructioncdTxId");
                });

            modelBuilder.Entity("BlogUi.Models.CreditTransferInstruction", b =>
                {
                    b.HasOne("BlogUi.Models.Currency", "CCYID")
                        .WithMany()
                        .HasForeignKey("ccyId");

                    b.HasOne("BlogUi.Models.GroupHeader", "GRPHID")
                        .WithMany("creditTransferInstruction")
                        .HasForeignKey("grpHId");
                });

            modelBuilder.Entity("BlogUi.Models.CreditTransferInstructionReturn", b =>
                {
                    b.HasOne("BlogUi.Models.CreditTransferInstruction")
                        .WithMany("creditTransferInstructionReturn")
                        .HasForeignKey("CreditTransferInstructioncdTxId");
                });

            modelBuilder.Entity("BlogUi.Models.GroupHeader", b =>
                {
                    b.HasOne("BlogUi.Models.OrgMsgStatus", "_ORGMSGSTATUSID")
                        .WithMany()
                        .HasForeignKey("_ORGMSGSTATUSIDorgMsgStatusId");
                });

            modelBuilder.Entity("BlogUi.Models.GroupHeaderReturn", b =>
                {
                    b.HasOne("BlogUi.Models.GroupHeader")
                        .WithMany("groupHeaderReturn")
                        .HasForeignKey("GroupHeadergrpHId");
                });

            modelBuilder.Entity("BlogUi.Models.GroupHeaderStatus", b =>
                {
                    b.HasOne("BlogUi.Models.GroupHeader")
                        .WithMany("groupHeaderStatus")
                        .HasForeignKey("GroupHeadergrpHId");
                });

            modelBuilder.Entity("BlogUi.Models.Party", b =>
                {
                    b.HasOne("BlogUi.Models.CreditTransferInstruction", "creditTransferInstructions")
                        .WithMany("parties")
                        .HasForeignKey("creditTransferInstructionscdTxId");
                });

            modelBuilder.Entity("BlogUi.Models.Post", b =>
                {
                    b.HasOne("BlogUi.Models.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BlogUi.Models.TransacrtionAgent", b =>
                {
                    b.HasOne("BlogUi.Models.Agent", "agent")
                        .WithMany()
                        .HasForeignKey("agentagtCd");

                    b.HasOne("BlogUi.Models.CreditTransferInstruction", "creditTransferInstruction")
                        .WithMany()
                        .HasForeignKey("creditTransferInstructioncdTxId");
                });

            modelBuilder.Entity("BlogUi.Models.TransactionParty", b =>
                {
                    b.HasOne("BlogUi.Models.CreditTransferInstruction", "creditTransferInstruction")
                        .WithMany()
                        .HasForeignKey("creditTransferInstructioncdTxId");

                    b.HasOne("BlogUi.Models.Party", "party")
                        .WithMany()
                        .HasForeignKey("partyprtyId");
                });

            modelBuilder.Entity("BlogUi.Models.XmlToDatabase", b =>
                {
                    b.HasOne("BlogUi.Models.GroupHeader", "GRPHID")
                        .WithMany()
                        .HasForeignKey("grpHId");
                });
#pragma warning restore 612, 618
        }
    }
}
