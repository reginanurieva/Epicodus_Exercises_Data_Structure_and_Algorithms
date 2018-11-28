using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Hangman.Models;

namespace Hangman.Controllers
{
    public class HangmanController : Controller
    {
        [HttpGet("/hangman")]
        public ActionResult Index()
        {
            Random rand = new Random();
            HangmanGame newHangman = new HangmanGame(HangmanGame.wordArray[rand.Next(0,3)]);
            return View();
        }

        [HttpPost("/hangman")]
        public ActionResult Create()
        {
            .SetUserGuess(Request.Form["user-guess"]);
            return View("Index", newHangman);
        }
    }
}
