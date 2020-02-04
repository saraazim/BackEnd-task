using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using trialApp.Models;

namespace trialApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public  ActionResult Details()
        {
            Root t = new Root();

            HttpClientHandler handler = new HttpClientHandler();
            //to clear the response from any symbol
            handler.AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate;
            HttpClient client = new HttpClient(handler);
            
            var handlerResponse = client.GetAsync("https://api.stackexchange.com/2.2/questions?page=1&pagesize=50&order=desc&sort=creation&site=stackoverflow");
            handlerResponse.Wait();
            var result = handlerResponse.Result;
            if (result.IsSuccessStatusCode)
            {
                var responseData = result.Content.ReadAsStringAsync().Result;
                t = JsonConvert.DeserializeObject<Root>(responseData);

                ViewData["result"] = t.items;
            }


            return View();
        }
    }
}