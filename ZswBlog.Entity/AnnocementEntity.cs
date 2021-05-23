﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZswBlog.Entity
{
    /// <summary>
    /// 通知公告
    /// </summary>
    [Table("tab_announcement")]
    public class AnnouncementEntity : BaseEntity
    {
        /// <summary>
        /// 操作id
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
        /// 公告内容
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 是否置顶
        /// </summary>
        public bool isTop { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int sort { get; set; }

        /// <summary>
        /// 结束推送时间
        /// </summary>
        public DateTime endPushDate { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        public bool isShow { get; set; }
    }
}
