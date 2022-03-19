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
        HttpClientHandler _hadler = new HttpClientHandler();
        private readonly IConfiguration _configuration;
        private string apiBaseUrl;

        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
            apiBaseUrl = _configuration.GetValue<string>("WebApiBaseUrl");
            _hadler.ServerCertificateCustomValidationCallback = (
                sender, cert, chain, ssLPolicyError) => { return true; };
        }

        #region Vistas

        public IActionResult Validation()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult RegisterInfo()
        {
            return View();
        }
        public IActionResult Recover()
        {
            return View();
        }
        public IActionResult Restore(string token)
        {
            ViewBag.Token = token;
            return View();
        }

        #endregion

        #region Consumo
        //INICIO DE SESION
        [HttpPost]
        public async Task<IActionResult> Validation(Access access)
        {
            ApiResponse<Access> data;
            using (var httpClient = new HttpClient(_hadler))
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(access), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync(apiBaseUrl + "access/validation", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<ApiResponse<Access>>(apiResponse);

                }
            }

            if (data.Data != null) { FillData(data.Data); return Redirect("~/Dash/Index"); }
            else { TempData["message"] = "Usuario no valido"; return Redirect("~/User/Validation"); }

        }
        //REGISTRO DE SESION
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
            if (request == null) TempData["message"] = "Usuario no creado";
            else return Redirect("~/User/Validation");

            return View();
        }
        //REGISTRAR INFORMACION PERSONAL
        [HttpPost]
        public async Task<ActionResult> RegisterInfo(UserInfo userinfo)
        {
            ApiResponse<bool> request;
            userinfo.FkAccess = (int)HttpContext.Session.GetInt32("Id");
            userinfo.ImageProfile = "https://cdn3.iconfinder.com/data/icons/avatars-9/145/Avatar_Cat-512.png";
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
            if (request == null) TempData["message"] = "Información no guardada";
            else return Redirect("~/Dash/Index");
            
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Recover(Access access)
        {
            ApiResponse<string> data;
            using (var httpClient = new HttpClient(_hadler))
            {
                using (var response = await httpClient.GetAsync(apiBaseUrl + "access/initialpr/?email=" + access.EmailAddress))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<ApiResponse<string>>(apiResponse);
                }
            }

            if (data.Data != null) return RedirectToAction("Restore", "User", new { @token = data.Data });
            else return View("Recover");

        }

        [HttpPost]
        public async Task<ActionResult> Restore(string TokenValidation, string EmailPassword1, string EmailPassword2)
        {
            string parameters = $"?token={TokenValidation}&password1={EmailPassword1}&password2={EmailPassword2}";
            ApiResponse<bool> data;

            using (var httpClient = new HttpClient(_hadler))
            {
                using (var response = await httpClient.GetAsync(apiBaseUrl + "access/finalpr/" + parameters))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<ApiResponse<bool>>(apiResponse);
                }
            }

            if (data.Data) return RedirectToAction("Validation", "User");
            else return RedirectToAction("Restore", "User", new { @token = TokenValidation });

        }

        #endregion

        #region Metodos

        public void FillData(Access data)
        {
            HttpContext.Session.SetString("Token", data.TokenValidation);
            HttpContext.Session.SetInt32("Id", data.Id);
            HttpContext.Session.SetString("Email", data.EmailAddress);
            HttpContext.Session.SetInt32("Rol", data.FkRol);
        }

        #endregion
    }

}
