using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PREMIERTeamDbProject.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PREMIERTeamDbProject.Controllers
{
    [Authorize(Roles = "Manager")]
    public class CMSController : Controller
    {
        private readonly ILogger<CMSController> _logger;

        private readonly ApplicationDbContext _context;
        private Player editPlayer;

        public CMSController(ILogger<CMSController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Team> model = _context.Teams.ToList();
            return View(model);
        }

        public IActionResult Index2()
        {
            List<Player> model = _context.Players.ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddTeam()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddPlayer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTeam(TeamForm model)
        {
            if (ModelState.IsValid)
            {

                Team newTeam = new Team
                {
                    TeamTitle = model.TeamTitle,
                    TeamCertificate = model.TeamCertificate,
                    TeamDescription = model.TeamDescription,
                    TeamImage = model.TeamImage,
                    TeamPrice = model.TeamPrice,
                    Stars = model.Stars,
                    ReleaseDate = DateTime.Now,
                };
                _context.Add(newTeam);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();

        }

        [HttpPost]
        public IActionResult AddPlayer(PlayerForm model)
        {
            if (ModelState.IsValid)
            {

                Player newPlayer = new Player
                {
                    PlayerName = model.PlayerName,
                    PlayerClub = model.PlayerClub,
                    PlayerDescription = model.PlayerDescription,
                    PlayerImage = model.PlayerImage,
                    PlayerPrice = model.PlayerPrice,
                    PlayerStatus = model.PlayerStatus,
                    DOB = DateTime.Now,
                };
                _context.Add(newPlayer);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index2));
            }
            return View();

        }

        [HttpGet]
        public IActionResult UpdateTeam(int id)
        {
            Team model = _context.Teams.Find(id);
            TeamForm formModel = new TeamForm
            {
                TeamID = model.TeamID,
                TeamTitle = model.TeamTitle,
                TeamCertificate = model.TeamCertificate,
                TeamDescription = model.TeamDescription,
                TeamImage = model.TeamImage,
                TeamPrice = model.TeamPrice,
                Stars = model.Stars,
                ReleaseDate = model.ReleaseDate,
            };
            ViewBag.ImageName = model.TeamImage;
            return View(formModel);
        }

        [HttpGet]
        public IActionResult UpdatePlayer(int id)
        {
            Player model = _context.Players.Find(id);
            PlayerForm formModel = new PlayerForm
            {
                PlayerID = model.PlayerID,
                PlayerName = model.PlayerName,
                PlayerClub = model.PlayerClub,
                PlayerDescription = model.PlayerDescription,
                PlayerImage = model.PlayerImage,
                PlayerPrice = model.PlayerPrice,
                PlayerStatus = model.PlayerStatus,
                DOB = model.DOB,
            };
            ViewBag.ImageName = model.PlayerImage;
            return View(formModel);
        }

        [HttpPost]
        public IActionResult UpdateTeam(TeamForm model)
        {
            if (ModelState.IsValid)
            {
                Team editTeam = new Team
                {
                    TeamID = model.TeamID,
                    TeamTitle = model.TeamTitle,
                    TeamCertificate = model.TeamCertificate,
                    TeamDescription = model.TeamDescription,
                    TeamImage = model.TeamImage,
                    TeamPrice = model.TeamPrice,
                    Stars = model.Stars,
                    ReleaseDate = model.ReleaseDate
                };
                _context.Teams.Update(editTeam);

                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }


        [HttpPost]
        public IActionResult UpdatePlayer(PlayerForm model)
        {
            if (ModelState.IsValid)
            {
                Player editTeam = new Player
                {
                    PlayerID = model.PlayerID,
                    PlayerName = model.PlayerName,
                    PlayerClub = model.PlayerClub,
                    PlayerDescription = model.PlayerDescription,
                    PlayerImage = model.PlayerImage,
                    PlayerPrice = model.PlayerPrice,
                    PlayerStatus = model.PlayerStatus,
                    DOB = model.DOB
                };
                _context.Players.Update(editPlayer);

                _context.SaveChanges();
                return RedirectToAction("Index2");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult DeleteTeam(int Id)
        {
            Team model = _context.Teams.Find(Id);
            return View(model);
        }


        [HttpGet]
        public IActionResult DeletePlayer(int Id)
        {
            Player model = _context.Players.Find(Id);
            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteTeam(Team model)
        {
            _context.Teams.Remove(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeletePlayer(Player model)
        {
            _context.Players.Remove(model);
            _context.SaveChanges();
            return RedirectToAction("Index2");
        }


    }
}