using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yemek_Tarif_Sitesi.Models;

namespace Yemek_Tarif_Sitesi.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public ActionResult Index()
        {
            // İlk açılışta comments listesini boş oluştur
            var comments = new List<Comment>();
            TempData["Comments"] = comments;

            return View();
        }

        [HttpPost]
        public ActionResult AddComment(Comment comment)
        {
            // Comment modelini kullanarak işlemleri gerçekleştir
            var comments = TempData["Comments"] as List<Comment> ?? new List<Comment>();
            comments.Add(comment);
            TempData["Comments"] = comments;

            return RedirectToAction("Index");
        }
    }
}