using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using Pollpular.Models;
using Microsoft.EntityFrameworkCore;

namespace Pollpular.Controllers
{
    public class HomeController : Controller
    {
        private Context dbContext;
        public HomeController(Context context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            int? userid = HttpContext.Session.GetInt32("sessionid");
            if(userid != null)
            {
                User LoggedUser = dbContext.Users.FirstOrDefault(u => u.UserId == (int)userid);
                ViewBag.UserId = (int)userid;
                ViewBag.LoggedUser = LoggedUser;
                ViewBag.Polls = dbContext.Polls.ToList();
                return View(LoggedUser); 
            }
            return RedirectToAction("Index");
        }
        [HttpGet("poll/{id}")]
        public IActionResult OnePoll(int id)
        {
            Poll ThisPoll = dbContext.Polls.FirstOrDefault(p => p.PollId == id);
            ViewBag.PollId = ThisPoll.PollId;
            return View("OnePoll", ThisPoll);
        }
        [HttpGet("poll/results/{id}")]
        public IActionResult PollResults(int id)
        {
            Poll ThisPoll = dbContext.Polls.FirstOrDefault(p => p.PollId == id);
            return View("Results", ThisPoll);
        }
        [HttpGet("newpoll")]
        public IActionResult CreatePollPage()
        {
            int? userid = HttpContext.Session.GetInt32("sessionid");
            ViewBag.UserId = (int)userid;
            return View("CreatePoll");
        }
        [HttpPost("newpollnow")]
        public IActionResult CreatePoll(Poll newpoll)
        {
            dbContext.Polls.Add(newpoll);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            Poll RemovePoll = dbContext.Polls.Include(p => p.Answers).FirstOrDefault(p => p.PollId == id);
            dbContext.Polls.Remove(RemovePoll);
            dbContext.Answers.RemoveRange(RemovePoll.Answers);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        [HttpGet("newpollanswers")]
        public IActionResult CreatePollAnswersPage(Poll newpoll)
        {
            return View("CreatePollAnswers");
        }
        [HttpPost("newpollanswernow")]
        public IActionResult CreatePollAnswers(Answer newanswer)
        {
            return RedirectToAction("CreatePollAnswers");
        }
        [HttpGet("register")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost("registernow")]
        public IActionResult RegisterNow(User user)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Username == user.Username))
                {
                    ModelState.AddModelError("Username","Username already in use");
                    return View("Register");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                dbContext.Add(user);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("sessionid",user.UserId);
                return RedirectToAction("Dashboard");
            }
            return View("Register");
        }
        [HttpPost("login")]
        public IActionResult Login(User user)
        {
            User UserInDb = dbContext.Users.FirstOrDefault(u => u.Username == user.Username);
            if(UserInDb == null)
            {
                ModelState.AddModelError("Username", "Username is invalid");
                return View("Index");
            }
            PasswordHasher<User> hasher = new PasswordHasher<User>();
            PasswordVerificationResult result = hasher.VerifyHashedPassword(user, UserInDb.Password, user.Password);
            if(result == 0)
            {
                ModelState.AddModelError("Password","Password entered is incorrect");
                return View("Index");
            }
            HttpContext.Session.SetInt32("sessionid",UserInDb.UserId);
            return RedirectToAction("Dashboard");
        }
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}