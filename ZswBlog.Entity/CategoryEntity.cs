﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZswBlog.Entity
{
    /// <summary>
    /// 分类实体对象
    /// </summary>
    [Table("tab_category")]
    public class CategoryEntity : BaseEntity
    {

        /// <summary>
        /// 分类主键
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        public int operatorId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime createDate { get; set; }

        /// <summary>
        /// 分类描述
        /// </summary>
        public string description { get; set; }
    }
}