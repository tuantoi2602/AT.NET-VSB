using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MyWEB.Models
{
    public class Downloader
    {
        public string downloading(string url)
        {
            using (WebClient client = new WebClient())
            {
                string html = client.DownloadString(url);
                return html;
            }
        }
    }
}
