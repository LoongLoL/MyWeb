using System;
using System.Collections.Generic;
using System.Text;

namespace MyWeb.Models.Models
{
    public class PageResultDto<T>
    {
        public int Total { get; set; }
        public T Data { get; set; }
    }
}
