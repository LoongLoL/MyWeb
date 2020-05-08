namespace MyWeb.Services.Dto
{
    public class ResponseDto
    {
        /// <summary>
        /// 请求结果代码
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// 返回的说明信息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 返回的数据
        /// </summary>
        public dynamic Data { get; set; }
    }
}
