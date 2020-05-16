﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Succulentwebsite.Models;

namespace Succulentwebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Plants()
        {
            return View("Plants");
        }



        public ActionResult Animals()
        {
            return View("Animals");
        }

        public ActionResult fruitandvegetables()
        {
            return View("fruitandvegetables");
        }

        public ActionResult dog()
        {
            return View("dog");
        }




            public ActionResult ImagePage(string id)
            {
           
                ContentPage result = new ContentPage();

                switch (id)
                {
                    case "dog":


                        result.ImageUrl = "/content/images/animals/dog.png";
                        result.Description = "";
                        result.Title = "";

                        break;

                    case "cat":

                    result.ImageUrl = "/content/images/animals/cat.png";
                    result.Description = "";
                    result.Title = "";

                    break;
                }

                return View(result);
            }
        }
    
}
