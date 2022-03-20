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
    public class ClanController : Controller
    {
        HttpClientHandler _hadler = new HttpClientHandler();
        private readonly IConfiguration _configuration;
        private string apiBaseUrl;

        public ClanController(IConfiguration configuration)
        {
            _configuration = configuration;
            apiBaseUrl = _configuration.GetValue<string>("WebApiBaseUrl");
            _hadler.ServerCertificateCustomValidationCallback = (
                sender, cert, chain, ssLPolicyError) => { return true; };
        }

        #region vista
        // GET: ClansController/
        public async Task<IActionResult> ListClans(Clans clan)
        {

            using (var httpClient = new HttpClient(_hadler))
            {
                string parameters = $"?NameClan={clan.NameClan}&DescriptionClan={clan.DescriptionClan}&CurrentUser={clan.CurrentUser}&Abbreviation={clan.Abbreviation}&LimitUser={clan.LimitUser}";
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));


                using (var response = await httpClient.GetAsync(apiBaseUrl + "Clans/all/" + parameters))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.listclan = JsonConvert.DeserializeObject<ApiResponse<IEnumerable<Clans>>>(apiResponse);
                }
            }

            return View();
        }
        [HttpGet]
        // GET: ClanController/Create
        public IActionResult RegisterClans()
        {
            return View();
        }
        #endregion
        #region Consumo
        [HttpPost]
        public async Task<IActionResult> RegisterClans(Clans clan)
        {
            ApiResponse<bool> request;
            
            using (var httpClient = new HttpClient(_hadler))
            {
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));

                StringContent content = new StringContent(JsonConvert.SerializeObject(clan), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync(apiBaseUrl + "Clans/new", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    request = JsonConvert.DeserializeObject<ApiResponse<bool>>(apiResponse);
                }
            }
            if (request.Data == false) TempData["message"] = "Clan no creado";
            else return Redirect("~/Clan/ListClans");
            return View();
        }


        #endregion

    }
}
