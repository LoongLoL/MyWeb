using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyWeb.Models.Entitys;
using MyWeb.Repository;
using MyWeb.Repository.IRepositorys;
using MyWeb.Services.Banners.Dto;
using MyWeb.Services.Dto;

namespace MyWeb.Services.Banners
{
    public class BannerAppService : AppServiceBase, IBannerAppService

    {
        private readonly IBannerRepository _bannerRepository;

        public BannerAppService(IBannerRepository bannerRepository)
        {
            _bannerRepository = bannerRepository;
        }

        /// <summary>
        /// 增加banner
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public ResponseDto AddBanner(AddBannerDto dto)
        {
            var banner = new Banner { CreationTime = DateTime.Now, CreatorUserId = 0, Remark = dto.Remark, Image = dto.Image, Url = dto.Url };
            _bannerRepository.Add(banner);
            if (_bannerRepository.SaveChanges() > 0)
                return new ResponseDto() { Code = 200, Message = "banner添加成功！" };
            return new ResponseDto() { Code = 0, Message = "banner添加失败！" };
        }

        /// <summary>
        /// 获取banner列表
        /// </summary>
        /// <returns></returns>
        public ResponseDto GetBannerList()
        {
            var bannerList = _bannerRepository.GetAll().OrderByDescending(c => c.CreationTime);
            var result = new ResponseDto { Code = 200, Message = "Banners获取成功！", Data = new List<BannerDto>() };
            foreach (var banner in bannerList)
            {
                result.Data.Add(new BannerDto
                {
                    Id = banner.Id,
                    Image = banner.Image,
                    CreationTime = banner.CreationTime,
                    Remark = banner.Remark,
                    Url = banner.Url
                });
            }
            return result;
        }


        /// <summary>
        /// 删除benner
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ResponseDto DeleteBanner(int id)
        {
            var banner = _bannerRepository.GetById(id);
            if (banner == null)
                return new ResponseDto { Code = 0, Message = $"不存在Id为{id}的数据！" };
            _bannerRepository.Remove(id);
            var i = _bannerRepository.SaveChanges();
            if (i > 0)
                return new ResponseDto { Code = 200, Message = $"删除Id为{id}的数据成功！" };
            return new ResponseDto { Code = 0, Message = $"删除Id为{id}的数据失败！" };
        }

        /// <summary>
        /// 更新banner
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public ResponseDto UpdateBanner(UpdateBannerDto dto)
        {
            var banner = _bannerRepository.GetById(dto.Id);
            if (banner == null)
                return new ResponseDto { Code = 0, Message = $"不存在Id为{dto.Id}的数据！" };
            banner.Remark = dto.Remark;
            banner.Image = dto.Image;
            banner.Url = dto.Url;
            _bannerRepository.Update(banner);
            var i = _bannerRepository.SaveChanges();
            if (i > 0)
                return new ResponseDto() { Code = 200, Message = "banner修改成功！" };
            return new ResponseDto() { Code = 0, Message = "banner修改失败！" };
        }
    }
}
