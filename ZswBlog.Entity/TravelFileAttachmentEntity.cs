﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZswBlog.Entity
{
    /// <summary>
    /// 旅行附件中间实体对象
    /// </summary>
    [Table("tab_middle_travel_file_attachment")]
    public class TravelFileAttachmentEntity : BaseEntity
    {
        /// <summary>
        /// 中间表id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime createDate { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        public int operatorId { get; set; }
        /// <summary>
        /// 旅行分享id
        /// </summary>
        public int travelId { get; set; }
        /// <summary>
        /// 上传附件id
        /// </summary>
        public int fileAttachmentId { get; set; }

        /// <summary>
        /// 多对多外键
        /// </summary>
        [ForeignKey("travelId")]
        public virtual TravelEntity travel { get; set; }

        /// <summary>
        /// 多对多外键
        /// </summary>
        [ForeignKey("fileAttachmentId")]
        public virtual FileAttachmentEntity fileAttachment { get; set; }
    }
}
