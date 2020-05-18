using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWeb.Host.Controllers;
using MyWeb.Host.Helper;
using MyWeb.Host.Models;
using MyWeb.Services.Dto;
using MyWeb.Services.Users;

namespace MyWeb.Host.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class AuthenticateController : ApiControllerBase
    {
        private readonly IUserAppService _userAppService;
        public AuthenticateController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }
        [HttpPost]
        [Route("login")]
        public ResponseDto GetToken(string name, string password)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
                return new ResponseDto
                {
                    Code = 0,
                    Message = "用户名或者密码不能为空！"
                };

            using (MD5 md5Hash = MD5.Create())
            {
                password = GetMd5Hash(md5Hash, password);
            }
            var response = _userAppService.GetUserByNamePwd(name, password);

            if (response.Code != 200)
                return new ResponseDto
                {
                    Code = 500,
                    Message = "找不到用户信息！"
                };

            string jwtStr = string.Empty;
            bool suc = false;

            TokenModelJwt tokenModel = new TokenModelJwt();
            tokenModel.Uid = response.Data.Id;
            tokenModel.Role = response.Data.Name;

            jwtStr = JwtHelper.IssueJwt(tokenModel);
            suc = true;
            return new ResponseDto
            {
                Code = 200,
                Data = jwtStr
            };
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}