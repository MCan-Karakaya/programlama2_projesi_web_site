using System.IO;
using System.Web;
using System.Web.Mvc;
using Yemek_Tarif_Sitesi.Models;

namespace Yemek_Tarif_Sitesi.Controllers
{
    public class ResimController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DosyaYukleme(DosyaModel model)
        {
            if (model.Dosya != null && model.Dosya.ContentLength > 0)
            {
                // Resmi App_Data klasörüne kaydet
                var fileName = Path.Combine(Server.MapPath("~/Images"), model.Dosya.FileName);
                model.Dosya.SaveAs(fileName);

                ViewBag.Message = "Resim başarıyla yüklendi!";
            }
            else
            {
                ViewBag.Message = "Lütfen bir resim seçin.";
            }

            return View("Index");
        }
    }
}