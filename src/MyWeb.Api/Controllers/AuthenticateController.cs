using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWeb.Api.Controllers;
using MyWeb.Api.Helper;
using MyWeb.Api.Models;

namespace MyWeb.Api.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class AuthenticateController : ApiControllerBase
    {
        [HttpPost]
        [Route("login")]
        public JsonResult GetToken(string name, string pwd)
        {
            string jwtStr = string.Empty;
            bool suc = false;
            //TODO:完成登录操作
            //这里就是用户登陆以后，通过数据库去调取数据，分配权限的操作
            //这里直接写死了

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pwd))
            {
                return new JsonResult(new
                {
                    Status = false,
                    message = "用户名或密码不能为空"
                });
            }

            TokenModelJwt tokenModel = new TokenModelJwt();
            tokenModel.Uid = 1;
            tokenModel.Role = name;

            jwtStr = JwtHelper.IssueJwt(tokenModel);
            suc = true;
            return new JsonResult(new
            {
                success = suc,
                token = jwtStr
            });
        }
    }
}