using Ex1.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1.Controllers
{
    public class ProductsController : Controller
    {
        //assign service

        private readonly ProductService myService;
        public ProductsController(ProductService myService)
        {
            this.myService = myService;
        }

        public IActionResult List()
        {

            ViewBag.Products = this.myService.List();

            return View();
        }

        public IActionResult Detail(int id )
        {
            Product product = this.myService.Detail(id);
            ViewBag.Product = product;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Detail(int id, OrderForm form)
        {
            //check if the data input is valid then store data to json
            if (ModelState.IsValid)
            {

                if(form.address.Length < 10)
                {
                    ModelState.AddModelError("address","Not validated address !");
                }

                if (ModelState.IsValid)
                {
                    List<OrderForm> orders;
                    if (System.IO.File.Exists("orders.json"))
                    {

                        string json = await System.IO.File.ReadAllTextAsync("orders.json");

                        orders = JsonConvert.DeserializeObject<List<OrderForm>>(json);
                    }
                    else
                    {
                        orders = new List<OrderForm>();
                    }
                    orders.Add(form);

                    await System.IO.File.WriteAllTextAsync("orders.json", JsonConvert.SerializeObject(orders));

                    return RedirectToAction("Success");
                }
            }

            Product product = this.myService.Detail(id);
            ViewBag.Product = product;

            return View();
        }

        public IActionResult Success()
        {
            return View();
        }

    }


}
