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

        public ActionResult mythicalcreatures()
        {
            return View("mythicalcreatures");
        }

        public ActionResult transport()
        {
            return View("transport");
        }

        public ActionResult termsandconditions()
        {
            return View("termsandconditions");
        }

        public ActionResult privacypolicy()
        {
            return View("privacypolicy");
        }




        public ActionResult ImagePage(string id)
            {
           
                ContentPage result = new ContentPage();

                switch (id)
                {
                    case "dog":


                        result.ImageUrl = "/content/images/animals/dog.png";
                        result.Description = "" ;
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

                case "sea1":

                    result.ImageUrl = "/content/images/animals/sea1.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "sea2":

                    result.ImageUrl = "/content/images/animals/sea2.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "sea3":

                    result.ImageUrl = "/content/images/animals/sea3.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "sea4":

                    result.ImageUrl = "/content/images/animals/sea4.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "sea5":

                    result.ImageUrl = "/content/images/animals/sea5.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "sea6":

                    result.ImageUrl = "/content/images/animals/sea6.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "sea7":

                    result.ImageUrl = "/content/images/animals/sea7.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "sea8":

                    result.ImageUrl = "/content/images/animals/sea8.png";
                    result.Description = "";
                    result.Title = "";

           
                    break;

                case "bird1":

                    result.ImageUrl = "/content/images/animals/bird1.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "bird2":

                    result.ImageUrl = "/content/images/animals/bird2.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "ins1":

                    result.ImageUrl = "/content/images/animals/ins1.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "ins2":

                    result.ImageUrl = "/content/images/animals/ins2.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "ins4":

                    result.ImageUrl = "/content/images/animals/ins4.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "ins5":

                    result.ImageUrl = "/content/images/animals/ins5.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "ins6":

                    result.ImageUrl = "/content/images/animals/ins6.png";
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

                case "fruit1":

                    result.ImageUrl = "/content/images/fruitandvegetables/fruit1.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "fruit2":

                    result.ImageUrl = "/content/images/fruitandvegetables/fruit2.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "fruit3":

                    result.ImageUrl = "/content/images/fruitandvegetables/fruit3.png";
                    result.Description = "";
                    result.Title = "";

                    break;


                case "fruit4":

                    result.ImageUrl = "/content/images/fruitandvegetables/fruit4.png";
                    result.Description = "";
                    result.Title = "";

                    break;


                case "fruit5":

                    result.ImageUrl = "/content/images/fruitandvegetables/fruit5.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "uni1":

                    result.ImageUrl = "/content/images/mythicalcreatures/uni1.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "uni2":

                    result.ImageUrl = "/content/images/mythicalcreatures/uni2.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "uni3":

                    result.ImageUrl = "/content/images/mythicalcreatures/uni3.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "uni4":

                    result.ImageUrl = "/content/images/mythicalcreatures/uni4.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "drag1":

                    result.ImageUrl = "/content/images/mythicalcreatures/drag1.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "drag2":

                    result.ImageUrl = "/content/images/mythicalcreatures/drag2.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "drag3":

                    result.ImageUrl = "/content/images/mythicalcreatures/drag3.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "fairy1":

                    result.ImageUrl = "/content/images/mythicalcreatures/fairy1.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "mer1":

                    result.ImageUrl = "/content/images/mythicalcreatures/mer1.png";
                    result.Description = "";
                    result.Title = "";

                    break;


                case "trans1":

                    result.ImageUrl = "/content/images/transport/trans1.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "trans2":

                    result.ImageUrl = "/content/images/transport/trans2.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "trans3":

                    result.ImageUrl = "/content/images/transport/trans3.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "trans4":

                    result.ImageUrl = "/content/images/transport/trans4.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "trans5":

                    result.ImageUrl = "/content/images/transport/trans5.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "trans6":

                    result.ImageUrl = "/content/images/transport/trans6.png";
                    result.Description = "";
                    result.Title = "";

                    break;
            }

            
            
       
                return View(result);
            }
        }
    
}

