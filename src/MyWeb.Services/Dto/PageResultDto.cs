namespace MyWeb.Services.Dto
{
    public class PageResultDto<T>
    {
        public int Total { get; set; }
        public T Data { get; set; }
    }
}
