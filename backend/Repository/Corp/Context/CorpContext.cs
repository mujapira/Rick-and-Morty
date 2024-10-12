using Microsoft.EntityFrameworkCore;
using Repository.Corp.Entities;
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
        public virtual DbSet<CharacterEntity> Characters { get; set; }
        public virtual DbSet<EpisodeEntity> Episodes { get; set; }
        public virtual DbSet<LocationEntity> Locations { get; set; }
        public virtual DbSet<CharacterEpisodeCharacterEntity> CharacterEpisodes { get; set; }
        public virtual DbSet<LocationResidentEntity> LocationResidents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AI");

            modelBuilder.Entity<SessionEntity>(entity =>
            {
                entity.HasKey(e => e.SessionId);
            });

            modelBuilder.Entity<CharacterEpisodeCharacterEntity>(entity =>
            {
                entity.HasKey(ce => new { ce.CharacterId, ce.EpisodeId });

                entity.HasOne(ce => ce.Character)
                    .WithMany(c => c.CharacterEpisodes)
                    .HasForeignKey(ce => ce.CharacterId)
                    .HasConstraintName("FK_CharacterEpisodes_Character");

                entity.HasOne(ce => ce.Episode)
                    .WithMany(e => e.CharacterEpisodes)
                    .HasForeignKey(ce => ce.EpisodeId)
                    .HasConstraintName("FK_CharacterEpisodes_Episode");
            });

            modelBuilder.Entity<LocationResidentEntity>(entity =>
            {
                entity.HasKey(lr => new { lr.LocationId, lr.ResidentId });

                entity.HasOne(lr => lr.Location)
                    .WithMany(l => l.Residents)
                    .HasForeignKey(lr => lr.LocationId)
                    .HasConstraintName("FK_LocationResidents_Location");

                entity.HasOne(lr => lr.Resident)
                    .WithMany()
                    .HasForeignKey(lr => lr.ResidentId)
                    .HasConstraintName("FK_LocationResidents_Resident");
            });

            modelBuilder.Entity<CharacterEnity>(entity =>
            {
                entity.HasOne(c => c.Origin)
                    .WithMany()
                    .HasForeignKey(c => c.OriginId)
                    .HasConstraintName("FK_Characters_Origin_Location");

                entity.HasOne(c => c.Location)
                    .WithMany()
                    .HasForeignKey(c => c.LocationId)
                    .HasConstraintName("FK_Characters_Current_Location");
            });


            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}