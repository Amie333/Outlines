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

        public ActionResult disney()
        {
            return View("disney");
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
                    case "animal1":


                        result.ImageUrl = "/content/images/animals/animal1.png";
                        result.Description = "" ;
                        result.Title = "";

                        break;

                    case "animal2":

                    result.ImageUrl = "/content/images/animals/animal2.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal3":

                    result.ImageUrl = "/content/images/animals/animal3.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal4":

                    result.ImageUrl = "/content/images/animals/animal4.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal5":

                    result.ImageUrl = "/content/images/animals/animal5.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal6":

                    result.ImageUrl = "/content/images/animals/animal6.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal7":

                    result.ImageUrl = "/content/images/animals/animal7.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal8":

                    result.ImageUrl = "/content/images/animals/animal8.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal9":

                    result.ImageUrl = "/content/images/animals/animal9.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal10":

                    result.ImageUrl = "/content/images/animals/animal10.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal11":

                    result.ImageUrl = "/content/images/animals/animal11.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal12":

                    result.ImageUrl = "/content/images/animals/animal12.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal13":

                    result.ImageUrl = "/content/images/animals/animal13.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal14":

                    result.ImageUrl = "/content/images/animals/animal14.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal15":

                    result.ImageUrl = "/content/images/animals/animal15.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal16":

                    result.ImageUrl = "/content/images/animals/animal16.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal17":

                    result.ImageUrl = "/content/images/animals/animal17.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal18":

                    result.ImageUrl = "/content/images/animals/animal18.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal19":

                    result.ImageUrl = "/content/images/animals/animal19.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal20":

                    result.ImageUrl = "/content/images/animals/animal20.png";
                    result.Description = "";
                    result.Title = "";

           
                    break;

                case "animal21":

                    result.ImageUrl = "/content/images/animals/animal21.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal22":

                    result.ImageUrl = "/content/images/animals/animal22.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal23":

                    result.ImageUrl = "/content/images/animals/animal23.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal24":

                    result.ImageUrl = "/content/images/animals/animal24.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal25":

                    result.ImageUrl = "/content/images/animals/animal25.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal26":

                    result.ImageUrl = "/content/images/animals/animal26.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "animal27":

                    result.ImageUrl = "/content/images/animals/animal27.png";
                    result.Description = "";
                    result.Title = "";

                    break;


                case "1":

                    result.ImageUrl = "/content/images/plants/1.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "2":

                    result.ImageUrl = "/content/images/plants/2.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "3":

                    result.ImageUrl = "/content/images/plants/3.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "4":

                    result.ImageUrl = "/content/images/plants/4.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "5":

                    result.ImageUrl = "/content/images/plants/5.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "6":

                    result.ImageUrl = "/content/images/plants/6.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "7":

                    result.ImageUrl = "/content/images/plants/7.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "8":

                    result.ImageUrl = "/content/images/plants/8.png";
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

                case "trans7":

                    result.ImageUrl = "/content/images/transport/trans7.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "trans8":

                    result.ImageUrl = "/content/images/transport/trans8.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "trans9":

                    result.ImageUrl = "/content/images/transport/trans9.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "trans10":

                    result.ImageUrl = "/content/images/transport/trans10.png";
                    result.Description = "";
                    result.Title = "";

                    break;


                case "trans11":

                    result.ImageUrl = "/content/images/transport/trans11.png";
                    result.Description = "";
                    result.Title = "";

                    break;


                case "dis1":

                    result.ImageUrl = "/content/images/disney/dis1.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "dis2":

                    result.ImageUrl = "/content/images/disney/dis2.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "dis3":

                    result.ImageUrl = "/content/images/disney/dis3.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "dis4":

                    result.ImageUrl = "/content/images/disney/dis4.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "dis5":

                    result.ImageUrl = "/content/images/disney/dis5.png";
                    result.Description = "";
                    result.Title = "";

                    break;

                case "dis6":

                    result.ImageUrl = "/content/images/disney/dis6.png";
                    result.Description = "";
                    result.Title = "";

                    break;


                case "dis7":

                    result.ImageUrl = "/content/images/disney/dis7.png";
                    result.Description = "";
                    result.Title = "";

                    break;


                case "dis8":

                    result.ImageUrl = "/content/images/disney/dis8.png";
                    result.Description = "";
                    result.Title = "";

                    break;


                case "dis9":

                    result.ImageUrl = "/content/images/disney/dis9.png";
                    result.Description = "";
                    result.Title = "";

                    break;


                case "dis10":

                    result.ImageUrl = "/content/images/disney/dis10.png";
                    result.Description = "";
                    result.Title = "";

                    break;



                case "dis11":

                    result.ImageUrl = "/content/images/disney/dis11.png";
                    result.Description = "";
                    result.Title = "";

                    break;


                case "dis12":

                    result.ImageUrl = "/content/images/disney/dis12.png";
                    result.Description = "";
                    result.Title = "";

                    break;
            }

            
            
       
                return View(result);
            }
        }
    
}

