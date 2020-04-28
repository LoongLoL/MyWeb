using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWeb.Models.Entitys
{
    public class Entity : IEntity<long>
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        [Key]
        public virtual long Id { get; set; }
    }
}
