
using HighscoreDisplayApp.Models;
using HighscoreDisplayApp.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HighscoreDisplayApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddScores(string username, string emailAddress, int highScore)
        {
            using (HighscoreEntities db = new HighscoreEntities())
            {
                var score = new Score { Username = username, EmailAddress = emailAddress, HighScore = highScore };
                db.Scores.Add(score);
                db.SaveChanges();
            }
            return View("Success");
        }

        public ActionResult Scores()
        {
            using(HighscoreEntities db = new HighscoreEntities())
            {
                return View(db.Scores.ToList());
            }
        }
    }
}