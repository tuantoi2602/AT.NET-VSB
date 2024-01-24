using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Go(Page p)
        {
            if(p.selectedPage == NumberPage.home)
            {
                return RedirectToAction("Index");
            }
            if(p.selectedPage == NumberPage.page1)
            {
                return RedirectToAction("Page1");
            }
            if (p.selectedPage == NumberPage.page2)
            {
                return RedirectToAction("Page2");
            }
            if (p.selectedPage == NumberPage.page3)
            {
                return RedirectToAction("Page3");
            }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Page1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Page1(ContactForm ct)
        {
            if (ModelState.IsValid)
            {
                List<ContactForm> contactList;
                if (System.IO.File.Exists("Contact.json"))
                {
                    string json = System.IO.File.ReadAllText("Contact.json");
                    contactList = JsonConvert.DeserializeObject<List<ContactForm>>(json);
                }
                else
                {
                    contactList = new List<ContactForm>();
                }
                contactList.Add(ct);
                System.IO.File.WriteAllText("Contact.json", JsonConvert.SerializeObject(contactList));
                return RedirectToAction("Success");
            }
            return View();
            
        }

        public IActionResult Success()
        {
            return View();
        }

        public IActionResult Page2()
        {
            List<ContactForm> contactList;
            if (System.IO.File.Exists("Contact.json"))
            {
                string json = System.IO.File.ReadAllText("Contact.json");
                contactList = JsonConvert.DeserializeObject<List<ContactForm>>(json);
            }
            else
            {
                contactList = new List<ContactForm>();
            }
            ViewBag.Contact = contactList;
            return View();
        }

        public IActionResult Page3()
        {
            string xmlPage = new Dowloader().dowloading("https://news.ycombinator.com/rss");

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlPage);
            XmlNodeList nodes = xml.GetElementsByTagName("item");
            List<News> result = new List<News>();
            foreach(XmlElement item in nodes)
            {
                News news = new News();
                foreach(XmlNode itemChild in item.ChildNodes)
                {
                    if(itemChild.Name == "title")
                    {
                        news.Title = itemChild.InnerText;
                    }
                    if(itemChild.Name == "link")
                    {
                        news.Link = itemChild.InnerText;
                    }
                }
                result.Add(news);
            }
            ViewBag.News = result;
            return View();
        }
    }
}
