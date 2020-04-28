using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWeb.Models.Entitys
{
    public class EntityWithDelModAdd<T> : IEntity<T>
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        [Key]
        public virtual T Id { get; set; }
        /// <summary>
        /// 软删除，是否删除，0=未删除，1=已删除，默认值=0
        /// </summary>
        public virtual bool IsDeleted { get; set; }
        /// <summary>
        /// 删除操作者的用户Id
        /// </summary>
        public virtual long? DeleterUserId { get; set; }
        /// <summary>
        /// 删除操作的时间
        /// </summary>
        public virtual DateTime? DeletionTime { get; set; }
        /// <summary>
        /// 创建操作者的Id
        /// </summary>
        public virtual long CreatorUserId { get; set; }
        /// <summary>
        /// 创建操作的时间
        /// </summary>
        public virtual DateTime CreationTime { get; set; }
        /// <summary>
        /// 最后一次修改操作者的Id
        /// </summary>
        public virtual long? LastModifierUserId { get; set; }
        /// <summary>
        /// 最后一次修改操作的时间
        /// </summary>
        public virtual DateTime? LastModificationTime { get; set; }
    }
}
