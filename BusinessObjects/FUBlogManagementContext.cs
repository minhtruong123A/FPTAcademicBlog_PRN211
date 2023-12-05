using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace BusinessObjects
{
    public partial class FUBlogManagementContext : DbContext
    {
        public FUBlogManagementContext()
        {
        }

        public FUBlogManagementContext(DbContextOptions<FUBlogManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<PostsTag> PostsTags { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }

        private string GetConnectionString()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true).Build();
            return configuration["ConnectionStrings:DefaultConnectionString"];
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("CategoryID");

                entity.Property(e => e.CategoryDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.Property(e => e.CommentId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CommentID");

                entity.Property(e => e.Author)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Context)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PublishTime)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.PostCommentNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.PostComment)
                    .HasConstraintName("FKlluak1psxp4nje4oi3vhyuq92");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FKigqv6cprourtqvptybe5no1wr");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post");

                entity.Property(e => e.PostId)
                    .ValueGeneratedNever()
                    .HasColumnName("PostID");

                entity.Property(e => e.AppovedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveTime)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostAuthor)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostCategoryId).HasColumnName("PostCategoryID");

                entity.Property(e => e.PostComment)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostContent)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostSubjectId).HasColumnName("PostSubjectID");

                entity.Property(e => e.PostTagId).HasColumnName("PostTagID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK36jgqcr5py0tmxem6hp1bv6kn");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK618uvsiqjb2htifcinxco1yfa");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FKl44jrpnfk8yihtl9bkxel8o9q");
            });

            modelBuilder.Entity<PostsTag>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Posts_Tags");

                entity.Property(e => e.PostTagId).HasColumnName("PostTagID");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.HasOne(d => d.PostTag)
                    .WithMany()
                    .HasForeignKey(d => d.PostTagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKf6omernef7n56i80hymcykraq");

                entity.HasOne(d => d.Tag)
                    .WithMany()
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK4fq7f5qspdb5b5ynu4c0fhjan");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("Subject");

                entity.Property(e => e.SubjectId)
                    .ValueGeneratedNever()
                    .HasColumnName("SubjectID");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SubjecName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("Tag");

                entity.Property(e => e.TagId)
                    .ValueGeneratedNever()
                    .HasColumnName("TagID");

                entity.Property(e => e.TagDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TagName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tblUser__1788CCACA6F9B4F2");

                entity.ToTable("tblUser");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.Birthdate)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Major)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RoleID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
