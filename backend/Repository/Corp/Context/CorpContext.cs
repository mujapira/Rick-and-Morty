using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using tarefas.Corp.Entities;

namespace tarefas.Corp.Context
{
    public partial class CorpContext : DbContext
    {
        public CorpContext() { }

        public CorpContext(DbContextOptions<CorpContext> options) : base(options) { }

        public virtual DbSet<SessionEntity> Sessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AI");

            modelBuilder.Entity<SessionEntity>(entity =>
            {
                entity.HasKey(e => e.SessionId);
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}