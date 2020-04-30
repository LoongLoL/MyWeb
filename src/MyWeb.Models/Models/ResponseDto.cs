using System;
using System.Collections.Generic;
using System.Text;

namespace MyWeb.Models.Models
{
    public class ResponseDto : ResponseDto<bool>
    {

    }
    public class ResponseDto<T>
    {
        /// <summary>
        /// 请求结果代码
        /// </summary>
        public ResponseCodeEnum Code { get; set; }
        /// <summary>
        /// 返回的说明信息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 返回的数据
        /// </summary>
        public T Data { get; set; }
    }
}
