using IdentityModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Security.Claims;

namespace Laison.Lapis.Host
{
    /// <summary>
    /// Sample2Controller
    /// </summary>
    [Route("api/sample2")]
    [ApiExplorerSettings(GroupName = "Role")]
    public class Sample2Controller : AbpController
    {

        /// <summary>
        /// /
        /// </summary>
        public Sample2Controller()
        {
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="formFile">文件</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<bool> test(IFormFile formFile)
        {
            using (var sr = new StreamReader(formFile.OpenReadStream()))
            {
                var content = await sr.ReadToEndAsync();

                return true;
            }
        }

    }

}