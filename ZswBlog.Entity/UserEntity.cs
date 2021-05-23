﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZswBlog.Entity
{
    /// <summary>
    /// 用户实体对象
    /// </summary>
    [Table("tab_user")]
    public class UserEntity : BaseEntity
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string password { get; set; }
        /// <summary>
        /// 邮件地址
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string nickName { get; set; }
        /// <summary>
        /// 登录名
        /// </summary>
        public string loginName { get; set; }
        /// <summary>
        /// 首次登录
        /// </summary>
        public DateTime loginTime { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string portrait { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime createDate { get; set; }
        /// <summary>
        /// 上次登录
        /// </summary>
        public DateTime lastLoginDate { get; set; }
        /// <summary>
        /// 登录次数
        /// </summary>
        public int loginCount { get; set; }
        /// <summary>
        /// 是否禁用
        /// </summary>
        public bool disabled { get; set; }
    }
}
