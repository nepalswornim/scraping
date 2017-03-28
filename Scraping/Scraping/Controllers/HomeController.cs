using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlAgilityPack;
using Scraping.Models;

namespace Scraping.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            HtmlWeb hWeb = new HtmlWeb();
            HtmlDocument doc = hWeb.Load("http://www.espncricinfo.com/ci/engine/match/index.html?view=live");
            HtmlModel ht = new HtmlModel();

            HtmlModel lstHtml = new HtmlModel();
            var header1 = doc.DocumentNode.SelectNodes("//section[@id='live-match-data']").ToList();
            var header = doc.DocumentNode.SelectSingleNode("//section[@id='live-match-data']");
            // var header = doc.DocumentNode.InnerHtml;
            //doc.DocumentNode.SelectNodes("//section[@id='live-match-data']").ToString();
            ht.Html = header.ToString();
          /*  lstHtml.Add(ht)*/;
            lstHtml.Html = header.InnerHtml.ToString();
            foreach (var item in header1) {
                Console.WriteLine(item.InnerHtml);
            }
            return View(lstHtml);
            
        }
    }
}