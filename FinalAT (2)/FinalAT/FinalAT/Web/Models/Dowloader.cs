using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Dowloader
    {
        public string dowloading(string url)
        {
            using (WebClient client = new WebClient())
            {
                string html = client.DownloadString(url);
                return html;
            }
        }
    }
}
