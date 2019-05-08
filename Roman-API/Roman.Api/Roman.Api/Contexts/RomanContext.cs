using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Roman.Api.Domains
{
    public partial class RomanContext : DbContext
    {
        public RomanContext()
        {
        }

        public RomanContext(DbContextOptions<RomanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Equipe> Equipe { get; set; }
        public virtual DbSet<Projeto> Projeto { get; set; }
        public virtual DbSet<Tema> Tema { get; set; }
        public virtual DbSet<TipoUsuarios> TipoUsuarios { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\SqlExpress; Initial Catalog= TRABALHO_ROMAN; user id=sa; pwd=132");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipe>(entity =>
            {
                entity.HasKey(e => e.IdEquipe);

                entity.ToTable("EQUIPE");

                entity.Property(e => e.IdEquipe).HasColumnName("id_equipe");

                entity.Property(e => e.DsEquipe)
                    .IsRequired()
                    .HasColumnName("ds_equipe")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Projeto>(entity =>
            {
                entity.HasKey(e => e.IdProjeto);

                entity.ToTable("PROJETO");

                entity.Property(e => e.IdProjeto).HasColumnName("id_projeto");

                entity.Property(e => e.IdTema).HasColumnName("id_tema");

                entity.Property(e => e.NmProjeto)
                    .IsRequired()
                    .HasColumnName("nm_projeto")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTemaNavigation)
                    .WithMany(p => p.Projeto)
                    .HasForeignKey(d => d.IdTema)
                    .HasConstraintName("FK__PROJETO__id_tema__4F7CD00D");
            });

            modelBuilder.Entity<Tema>(entity =>
            {
                entity.HasKey(e => e.IdTema);

                entity.ToTable("TEMA");

                entity.Property(e => e.IdTema).HasColumnName("id_tema");

                entity.Property(e => e.DsTema)
                    .IsRequired()
                    .HasColumnName("ds_tema")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoUsuarios>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario);

                entity.ToTable("TIPO_USUARIOS");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("id_tipo_usuario");

                entity.Property(e => e.NmTipoUsuario)
                    .IsRequired()
                    .HasColumnName("nm_tipo_usuario")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuarios);

                entity.ToTable("USUARIOS");

                entity.Property(e => e.IdUsuarios).HasColumnName("id_usuarios");

                entity.Property(e => e.DsEMail)
                    .IsRequired()
                    .HasColumnName("ds_e_mail")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsSenha)
                    .HasColumnName("ds_senha")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdEquipe).HasColumnName("id_equipe");

                entity.Property(e => e.IdProjeto).HasColumnName("id_projeto");

                entity.Property(e => e.IdTipoUsuarios).HasColumnName("id_tipo_usuarios");

                entity.Property(e => e.NmUsuarios)
                    .IsRequired()
                    .HasColumnName("nm_usuarios")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumTelefone)
                    .IsRequired()
                    .HasColumnName("num_telefone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEquipeNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdEquipe)
                    .HasConstraintName("FK__USUARIOS__id_equ__534D60F1");

                entity.HasOne(d => d.IdProjetoNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdProjeto)
                    .HasConstraintName("FK__USUARIOS__id_pro__5441852A");

                entity.HasOne(d => d.IdTipoUsuariosNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuarios)
                    .HasConstraintName("FK__USUARIOS__id_tip__52593CB8");
            });
        }
    }
}
