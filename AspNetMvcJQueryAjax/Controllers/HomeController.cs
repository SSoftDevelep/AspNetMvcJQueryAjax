using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcJQueryAjax.Controllers
{
    public class HomeController : Controller
    {
        private List<string> listem = new List<string>() { "turkiye", "cumhuriyeti", "merkez", "bankasi" };
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Index2()
        {

            return View();
        }

        public ActionResult Index3()
        {
            return View();
        }

        public ActionResult Index4()
        {
            return View();
        }

        public PartialViewResult VerileriGetir(string veri = "")

        {
            if (string.IsNullOrEmpty(veri)==false)   //bosluk yada bos degilse
            {
                listem.Add(veri);
            }
            
            //veriler db'den cekilir.
            System.Threading.Thread.Sleep(3000);  //3 sn beklettik.
            return PartialView("_DataItemPartial", listem);
        }

        public JsonResult VerileriGetir2(string veri = "")
        {
            if (string.IsNullOrEmpty(veri) == false)   //bosluk yada bos degilse
            {
                listem.Add(veri);
            }

            System.Threading.Thread.Sleep(3000);
            return Json(listem,JsonRequestBehavior.AllowGet);  //bilincli olarak datayi disariya aciyorum demek. Bunu yapmazsak get talebiyle action sonucunu json olarak alamayiz.
        }

        //public PartialViewResult VerileriGetir(string veri)
        //{
        //    listem.Add(veri);
        //    //veriler db'den cekilir.
        //    System.Threading.Thread.Sleep(3000);  //3 sn beklettik.
        //    return PartialView("_DataItemPartial", listem);
        //}
    }
}