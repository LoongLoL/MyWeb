﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWeb.Host.Controllers;
using MyWeb.Host.Helper;
using MyWeb.Host.Models;
using MyWeb.Services.Dto;

namespace MyWeb.Host.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class AuthenticateController : ApiControllerBase
    {
        [HttpPost]
        [Route("login")]
        public JsonResult GetToken(string name, string password)
        {
            string jwtStr = string.Empty;
            bool suc = false;
            //TODO:完成登录操作
            //这里就是用户登陆以后，通过数据库去调取数据，分配权限的操作
            //这里直接写死了

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
                return new JsonResult(new ResponseDto
                {
                    Code = 0,
                    Message = "用户名或者密码不能为空！"
                });

            TokenModelJwt tokenModel = new TokenModelJwt();
            tokenModel.Uid = 1;
            tokenModel.Role = name;

            jwtStr = JwtHelper.IssueJwt(tokenModel);
            suc = true;
            return new JsonResult(new ResponseDto
            {
                Code = 0,
                Data = jwtStr
            });
        }
    }
}