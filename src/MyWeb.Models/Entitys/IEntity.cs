using System;
using System.Collections.Generic;
using System.Text;

namespace MyWeb.Models.Entitys
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
