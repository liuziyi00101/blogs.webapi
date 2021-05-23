﻿using Microsoft.EntityFrameworkCore;
using ZswBlog.DTO;

namespace ZswBlog.Entity.DbContext
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ZswBlogDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public ZswBlogDbContext()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public ZswBlogDbContext(DbContextOptions options) : base(options)
        {
        }
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //          => optionsBuilder
        //              .UseMySql(@"Server=.;database=auto.blogs;uid=sa;pwd=a123456_;");
        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<ActionLogEntity> ActionLogEntities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<ArticleEntity> ArticleEntities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<ArticleTagEntity> ArticleTagEntities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<CommentEntity> CommentEntities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<FriendLinkEntity> FriendLinkEntities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<MessageEntity> MessageEntities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<SiteTagEntity> SiteTagEntities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<TagEntity> TagEntities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<TravelEntity> TravelEntities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<UserEntity> UserEntities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<TimeLineEntity> TimeLineEntities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<FileAttachmentEntity> FileAttachmentEntities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<QQUserInfoEntity> QQUserInfoEntities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<TravelFileAttachmentEntity> TravelFileAttachmentEntities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<CategoryEntity> CategoryEntities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<AnnouncementEntity> AnnouncementEntities { get; set; }
        /// <summary>
        /// 非模型实体
        /// </summary>
        public virtual DbSet<MessageDTO> MessageDTO { get; set; }
        /// <summary>
        /// 非模型实体
        /// </summary>
        public virtual DbSet<ArticleDTO> ArticleDTO { get; set; }
        /// <summary>
        /// 非模型实体
        /// </summary>
        public virtual DbSet<CommentDTO> CommentDTO { get; set; }
        /// <summary>
        /// Fluent API定义实体属性与关联
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //文章标签多对多外键关联
            modelBuilder.Entity<ArticleTagEntity>()
                .HasKey(t => new { t.articleId, t.tagId });

            modelBuilder.Entity<ArticleTagEntity>()
                .HasOne(pt => pt.article)
                .WithMany(p => p.articleTags)
                .HasForeignKey(pt => pt.articleId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ArticleTagEntity>()
                .HasOne(pt => pt.tag)
                .WithMany(t => t.articleTags)
                .HasForeignKey(pt => pt.tagId)
                .OnDelete(DeleteBehavior.NoAction);

            //旅行分享多对多外键关联
            modelBuilder.Entity<TravelFileAttachmentEntity>()
                .HasKey(t => new { t.travelId, t.fileAttachmentId });

            modelBuilder.Entity<TravelFileAttachmentEntity>()
                .HasOne(pt => pt.travel)
                .WithMany(p => p.imgList)
                .HasForeignKey(pt => pt.travelId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TravelFileAttachmentEntity>()
                .HasOne(pt => pt.fileAttachment)
                .WithMany(t => t.travelFileAttachments)
                .HasForeignKey(pt => pt.fileAttachmentId)
                .OnDelete(DeleteBehavior.NoAction);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}
