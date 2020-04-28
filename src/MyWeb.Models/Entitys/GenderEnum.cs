using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MyWeb.Models.Entitys
{
    public enum GenderEnum
    {
        /// <summary>
        /// 未知
        /// </summary>
        [Description("未知")]
        Unknown = 0,
        /// <summary>
        /// 男性
        /// </summary>
        [Description("男性")]
        Male = 1,
        /// <summary>
        /// 女性
        /// </summary>
        [Description("女性")]
        Female = 2
    }
}
