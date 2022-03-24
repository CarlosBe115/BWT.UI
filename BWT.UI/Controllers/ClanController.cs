﻿using BWT.UI.Models;
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
                sender, cert, chain, ssLPolicyError) =>
            { return true; };
        }

        #region vista
        // GET: ClansController/
        public async Task<IActionResult> ListClans(Clans clan)
        {
            if (HttpContext.Session.GetString("Token") == null)
            {
                TempData["message"] = "Inicia sesión para acceder";
                return Redirect("~/User/Validation");
            }

            using (var httpClient = new HttpClient(_hadler))
            {
                string parameters = $"?NameClan={clan.NameClan}&DescriptionClan={clan.DescriptionClan}&CurrentUser={clan.CurrentUser}&Abbreviation={clan.Abbreviation}&LimitUser={clan.LimitUser}&FKUserCreator={clan.FKUserCreator}";
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
        public async Task<IActionResult> RegisterClans()
        {
            if (HttpContext.Session.GetString("Token") == null)
            {
                TempData["message"] = "Inicia sesión para acceder";
                return Redirect("~/User/Validation");
            }
            using (var httpClient = new HttpClient(_hadler))
            {
                string parameters = "?namegame=&descriptiongame=";
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
                using (var response = await httpClient.GetAsync(apiBaseUrl + "Games/all/" + parameters))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.listgames = JsonConvert.DeserializeObject<ApiResponse<IEnumerable<Games>>>(apiResponse);
                }

            }

            return View();
        }
        // GET: ClansController/
        public async Task<IActionResult> VerClan(int id)
        {
            if (HttpContext.Session.GetString("Token") == null)
            {
                TempData["message"] = "Inicia sesión para acceder";
                return Redirect("~/User/Validation");
            }
            using (var httpClient = new HttpClient(_hadler))
            {

                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));

                using (var response = await httpClient.GetAsync(apiBaseUrl + "Clans/one/?id=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.clanone = JsonConvert.DeserializeObject<ApiResponse<Clans>>(apiResponse);
                }
            }
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> addmembers(int id)
        {
            if (HttpContext.Session.GetString("Token") == null)
            {
                TempData["message"] = "Inicia sesión para acceder";
                return Redirect("~/User/Validation");
            }
            ApiResponse<bool> data;
            UserClan Members = new UserClan();
            Members.FkUser = (int)HttpContext.Session.GetInt32("Id");
            Members.FkClan = id;
            Members.myRange = 1;
            Members.DateRegister = DateTime.Now;
            Members.IsValid = true;
            using (var httpClient = new HttpClient(_hadler))
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(Members), Encoding.UTF8, "application/json");
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));

                using (var response = await httpClient.PostAsync(apiBaseUrl + "Clans/new/" , content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<ApiResponse<bool>>(apiResponse);
                }
            }
            if(data.Data == false)
            {
                TempData["message"] = "Error en el proceso";
                return Redirect("~/Clan/ListClan");
            }
            else 
                return Redirect("~/Clan/VerClan/" + id);
        }

        #endregion
        #region Consumo
        [HttpPost]
        public async Task<IActionResult> RegisterClans(Clans clan)
        {
            ApiResponse<bool> request;
            clan.FKUserCreator = (int)HttpContext.Session.GetInt32("Id");
            clan.CreationClan = DateTime.Now;
            
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

