using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AgentApi.Models
{
    public partial class gestionAgentdbContext : DbContext
    {
        public gestionAgentdbContext()
        {
        }

        public gestionAgentdbContext(DbContextOptions<gestionAgentdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agent> Agents { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agent>(entity =>
            {
                entity.ToTable("Agent");

                entity.Property(e => e.AgentId).HasColumnName("agentId");

                entity.Property(e => e.AgentAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("agentAddress");

                entity.Property(e => e.AgentEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("agentEmail");

                entity.Property(e => e.AgentMobile)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("agentMobile");

                entity.Property(e => e.AgentName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("agentName");

                entity.Property(e => e.AgentTele)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("agentTele");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
