﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZswBlog.Entity
{
    /// <summary>
    /// 上传附件实体对象
    /// </summary>
    [Table("tab_file_attachment")]
    public class FileAttachmentEntity : BaseEntity
    {
        /// <summary>
        /// 附件id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        /// <summary>
        /// 附件上传时间
        /// </summary>
        public DateTime createDate { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        public int operatorId { get; set; }
        /// <summary>
        /// 附件名称
        /// </summary>
        public string fileName { get; set; }
        /// <summary>
        /// 附件后缀
        /// </summary>
        public string fileExt { get; set; }
        /// <summary>
        /// 附件路径
        /// </summary>
        public string path { get; set; }
        /// <summary>
        /// 关联外键
        /// </summary>
        public virtual List<TravelFileAttachmentEntity> travelFileAttachments { get; set; }

    }
}
