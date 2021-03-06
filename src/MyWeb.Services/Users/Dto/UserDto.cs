﻿using MyWeb.Models.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWeb.Services.Users.Dto
{
    public class UserDto
    {
        public long Id { get; set; }
        /// <summary>
        /// 登录名，需要验证唯一性
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 登录密码，需要Md5加密
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 最后一次登录的时间
        /// </summary>
        public DateTime? LastLoginTime { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户性别，默认值=GenderEnum.Unknown
        /// </summary>
        public GenderEnum Gender { get; set; }
        /// <summary>
        /// 用户生日，yyyy-MM-dd
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// 用户年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 用户头像图片链接
        /// </summary>
        public string HeadImgUrl { get; set; }
        /// <summary>
        /// 用户邮箱地址
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 是否已经验证邮箱，0=未验证，1=已经验证，默认值=0
        /// </summary>
        public bool? IsEmailConfirmed { get; set; }
        /// <summary>
        /// 用户手机号码，必填
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 是否已经验证手机号码，0=未验证，1=已经验证，默认值=0
        /// </summary>
        public bool IsPhoneNumberConfirmed { get; set; }
        /// <summary>
        /// 用户是否激活，0=未激活，1=已激活，默认值=0
        /// </summary>
        public bool IsActive { get; set; }
    }
}
