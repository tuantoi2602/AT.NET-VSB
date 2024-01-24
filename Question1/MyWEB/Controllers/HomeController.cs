using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWEB.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace MyWEB.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        //Post Data Contact
        [HttpPost]
        public async Task<IActionResult> Page1Async(ContactForm contactForm)
        {
            //Valid Form
            if (ModelState.IsValid)
            {
                //Create contact List to save. Format Json
                List<ContactForm> contacts;
                //Check file contacts exist or not. If it has. Read the old contact
                if (System.IO.File.Exists("contacts.json"))
                {
                    string json = await System.IO.File.ReadAllTextAsync("contacts.json");

                    contacts = JsonConvert.DeserializeObject<List<ContactForm>>(json);
                    if (contacts == null)
                    {
                        contacts = new List<ContactForm>();
                    }
                }
                else
                {
                    contacts = new List<ContactForm>();
                }
                contacts.Add(contactForm);
                await System.IO.File.WriteAllTextAsync("contacts.json", JsonConvert.SerializeObject(contacts));
                //Return page success
                return RedirectToAction("Success");
            }
            return View();
        }

        //View all contacts
        public async Task<IActionResult> Page2Async()
        {
            //Create contact List to save. Format Json
            List<ContactForm> contacts;
            //Check file contacts exist or not. If it has. Read the old contact
            if (System.IO.File.Exists("contacts.json"))
            {
                string json = await System.IO.File.ReadAllTextAsync("contacts.json");

                contacts = JsonConvert.DeserializeObject<List<ContactForm>>(json);
                if (contacts == null)
                {
                    contacts = new List<ContactForm>();
                }
            }
            else
            {
                contacts = new List<ContactForm>();
            }
            //Add list contact to viewBag and show in page2
            ViewBag.Contacts = contacts;
            return View();
        }

        public IActionResult Page3()
        {
            //Get xml page
            string xmlPage = new Downloader().downloading("https://news.ycombinator.com/rss");
            //Convert string to xml
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlPage);
            //Get all node item. Because all node item contain each titel and link

            XmlNodeList nodes = xml.GetElementsByTagName("item");
            List<News> results = new List<News>();
            foreach (XmlElement item in nodes)
            {
                News news = new News();
                foreach (XmlNode itemChild in item.ChildNodes)
                {
                    if (itemChild.Name == "title")
                    {
                        news.Title = itemChild.InnerText;
                    }
                    if (itemChild.Name == "link")
                    {
                        news.Link = itemChild.InnerText;
                    }
                }

                results.Add(news);

            }
            //Return reuslt to ViewBag
            ViewBag.News = results;

            return View();
        }

        public IActionResult Success()
        {
            return View();
        }
        public IActionResult Page1()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
