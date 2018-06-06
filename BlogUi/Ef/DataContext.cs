//Copyright 2017 (c) SmartIT. All rights reserved.
//By John Kocer
// This file is for Swagger test, this application does not use this file
using BlogUi.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogUi.Ef
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        //var connection = @"Data Source=DESKTOP-4H6535A\NEWSQLSERVER;Initial Catalog=finConnectCF;Persist Security Info=True;User ID=sa;Password=sa";
     
        public DbSet<Agent> Agent { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<CountryCode> CountryCodes { get; set; }
        public DbSet<CreditTransferInstruction> creditTransferInstructions { get; set; }
        public DbSet<CreditTransferInstructionReturn> creditTransferInstructionReturns { get; set; }
        public DbSet<CreditTransferStatus> creditTransferStatuses { get; set; }
        public DbSet<Currency> currencies  { get; set; }
        public DbSet<GroupHeader> groupHeaders { get; set; }
            public DbSet<GroupHeaderReturn>  groupHeaderReturns { get; set; }
        public DbSet<GroupHeaderStatus> groupHeaderStatuses { get; set; }
        public DbSet<OrgMsgStatus>   orgMsgStatuses { get; set; }
        public DbSet<Party> Party { get; set; }
        //public DbSet<Post> Post { get; set; }
        public DbSet<ReasonCode> reasonCodes { get; set; }
        public DbSet<StatusCode> statusCodes { get; set; }
        public DbSet<XmlToDatabase> XmlDoc { get; set; }
        public DbSet<TransacrtionAgent> transacrtionAgents { get; set; }
        public DbSet<TransactionParty> transactionParties { get; set; }
        public DbSet<CraditTransferInstructionLogs> craditTransferInstructionLogs { get; set; }
        public DbSet<groupHeaderAgent> groupHeaderAgents { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GroupHeader>()
            .HasMany(c => c.creditTransferInstruction)
             .WithOne(e => e.GRPHID);

            modelBuilder.Entity<CreditTransferInstruction>().HasOne(c => c.CCYID);
        }
     
    }


}
