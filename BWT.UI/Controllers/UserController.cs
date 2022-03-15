using BWT.UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BWT.UI.Controllers
{
    public class UserController : Controller
    {
        public static string Usertoken { get; private set; }
        HttpClientHandler _hadler = new HttpClientHandler();
        private readonly IConfiguration _configuration;
        private string apiBaseUrl;
        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
            apiBaseUrl = _configuration.GetValue<string>("WebApiBaseUrl");
            _hadler.ServerCertificateCustomValidationCallback = (
                sender, cert, chain, ssLPolicyError) =>
            { return true; };

        }
        
        public IActionResult Register()
        {

            return View();
        }
        public IActionResult RegisterInfo()
        {

            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Register(Access access)
        {
            ApiResponse<bool> request;
            access.FkRol = 1;
            access.IsValid = true;
            using (var httpClient = new HttpClient(_hadler))
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(access), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync(apiBaseUrl + "access/new", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();                 
                    request = JsonConvert.DeserializeObject<ApiResponse<bool>>(apiResponse);

                }
            }
            if (request == null)
            {
                TempData["message"] = "Usuario no creado"; 
            }
            else
            {
                return Redirect("~/User/RegisterInfo");
            }
            return View();    
        }
        [HttpPost]
        public async Task<ActionResult> RegisterInfo(UserInfo userinfo)
        {
            ApiResponse<bool> request;
            userinfo.FkAccess = (int)HttpContext.Session.GetInt32("Id");
            userinfo.ImageProfile = "https://elcomercio.pe/resizer/pfVziOV4X8Vu9nwknDc-oNItlB8=/1200x900/smart/filters:format(jpeg):quality(75)/cloudfront-us-east-1.images.arcpublishing.com/elcomercio/6Y2EDIISGFGVFANEVDCR5LCG34.jpg";
            using (var httpClient = new HttpClient(_hadler))
            {
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));

                StringContent content = new StringContent(JsonConvert.SerializeObject(userinfo), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync(apiBaseUrl + "UserInfo/new", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    request = JsonConvert.DeserializeObject<ApiResponse<bool>>(apiResponse);

                }
            }
            if (request == null)
            {
                TempData["message"] = "Información no guardada";
            }
            else
            {
                //debe mandar a la vista del acmon
                return Redirect("https://www.youtube.com");
            }
            return View();
        }

    }

}
