﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

public class MyOtherObject
{
    public string Property1 { get; set; }
    public int Property2 { get; set; }
}


namespace TherapyFM_Web.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyAction()
        {
            var user = new User { Id = 1, Name = "John Doe", Email = "john.doe@example.com" };
            var myOtherObject = new MyOtherObject { Property1 = "some value", Property2 = 123 };

            // Ana JSON nesnesini oluşturun ve kullanıcı ve diğer nesneyi içine yerleştirin
            var json = new JObject();
            json.Add("user", JObject.FromObject(user));
            json.Add("myOtherObject", JObject.FromObject(myOtherObject));

            // JSON verisini döndürün
            return Content(json.ToString(), "application/json");
        }
    }
}
