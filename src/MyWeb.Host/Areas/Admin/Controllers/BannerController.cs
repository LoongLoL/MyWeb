using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.IO;
using MyWeb.Host.Areas.Admin.Controllers;
using MyWeb.Services.Banners;
using MyWeb.Services.Banners.Dto;
using MyWeb.Services.Dto;

namespace MyWeb.Host.Areas.Admin.Controllers
{
    public class BannerController : AdminControllerBase
    {
        IBannerAppService _bannerAppService;
        IHostEnvironment _hostEnvironment;

        public BannerController(IBannerAppService bannerAppService, IHostEnvironment hostEnvironment)
        {
            _bannerAppService = bannerAppService;
            _hostEnvironment = hostEnvironment;
        }
        // GET: Banner
        public IActionResult Index()
        {
            var bannerList = _bannerAppService.GetBannerList();
            return View(bannerList);
        }

        // GET: Banner/Details/5
        public IActionResult BannerAdd(int id)
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> AddBanner(AddBannerDto dto, IFormFile uploadFile)
        {
            if (uploadFile == null)
                return Json(new ResponseDto { Code = 0, Message = "请上传图片！" });

            var webRootPath = _hostEnvironment.ContentRootPath;
            var relativeDirPath = "wwwroot\\UploadFiles\\BannerPic";
            var absolutePath = Path.Combine(webRootPath, relativeDirPath);

            var fileTypes = new string[] { ".gif", ".jpg", ".jpeg", ".png", ".bmp" };
            var extension = Path.GetExtension(uploadFile.FileName);
            if (!fileTypes.Contains(extension.ToLower()))
                return Json(new ResponseDto { Code = 0, Message = "图片格式有误！" });

            if (!Directory.Exists(absolutePath)) Directory.CreateDirectory(absolutePath);

            var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + extension;
            var filePath = Path.Combine(absolutePath, fileName);
            await using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await uploadFile.CopyToAsync(stream);
            }
            dto.Image = Path.Combine("/UploadFiles/BannerPic/", fileName);
            return Json(_bannerAppService.AddBanner(dto));
        }

        [HttpDelete]
        public JsonResult DelBanner(int id)
        {
            if (id <= 0)
                return Json(new ResponseDto { Code = 0, Message = "参数错误！" });
            return Json(_bannerAppService.DeleteBanner(id));
        }
    }
}