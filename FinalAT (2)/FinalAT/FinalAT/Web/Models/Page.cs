using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Page
    {
        public NumberPage selectedPage { get; set; }
    }
    public enum NumberPage
    {
        home,
        page1,
        page2,
        page3
    }
}
