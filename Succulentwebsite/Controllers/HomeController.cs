using System;
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

                case "rabbit":

                    result.ImageUrl = "/content/images/animals/rabbit.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "fish":

                    result.ImageUrl = "/content/images/animals/fish.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "fish2":

                    result.ImageUrl = "/content/images/animals/fish2.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "tortiose":

                    result.ImageUrl = "/content/images/animals/tortiose.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "whales":

                    result.ImageUrl = "/content/images/animals/whales.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "lizards":

                    result.ImageUrl = "/content/images/animals/lizards.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "insects":

                    result.ImageUrl = "/content/images/animals/insects.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "horses":

                    result.ImageUrl = "/content/images/animals/horses.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "pigs":

                    result.ImageUrl = "/content/images/animals/pigs.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "lions":

                    result.ImageUrl = "/content/images/animals/lions.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "cacti":

                    result.ImageUrl = "/content/images/plants/cacti.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "palm":

                    result.ImageUrl = "/content/images/plants/palm.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "lillies":

                    result.ImageUrl = "/content/images/plants/lillies.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "rose":

                    result.ImageUrl = "/content/images/plants/rose.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "succulent":

                    result.ImageUrl = "/content/images/plants/succulent.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "wildherbs":

                    result.ImageUrl = "/content/images/plants/wildherbs.png";
                    result.Description = "";
                    result.Title = "";

                    break;
            }

            
            
       
                return View(result);
            }
        }
    
}
