using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PREMIERTeamDbProject.Models;

namespace PREMIERTeamDbProject.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllTeams()
        {
            List<Team> model = _context.Teams.ToList();
            return View(model);
        }

        [Produces("application/json")]
        public IActionResult ApiData()
        {
            List<Team> model = _context.Teams.ToList();
            return Json(model, new JsonSerializerOptions
            {
                WriteIndented = true,
            });
        }

        [Produces("application/json")]
        public IActionResult ApiDataDetails(int id)
        {
            Team model = _context.Teams.Find(id);
            return Json(model, new JsonSerializerOptions
            {
                WriteIndented = true,
            });
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Team>>> ApiDataV2()
        {
            return await _context.Teams.ToListAsync();
        }


        public IActionResult Search(String SearchString, String certType)
        {

            var teams = from m in _context.Teams

                         select m;

            if (!string.IsNullOrEmpty(SearchString))

            {

                teams = teams.Where(s => s.TeamTitle.Contains(SearchString));

            }

            if (!string.IsNullOrEmpty(certType))
            {
                teams = teams.Where(x => x.TeamCertificate == certType);
            }

            var teamCerts = _context.Teams.Select(m => m.TeamCertificate).Distinct();


            List<Team> model = teams.ToList();
            ViewData["SearchString"] = SearchString;
            ViewData["FilterTeamCert"] = certType;
            ViewData["teamCerts"] = teamCerts.ToList();
            ViewData["teamCertsSelectList"] = new SelectList(teamCerts.ToList());
            return View(model);
        }


        // note uses id because of routing in startup.cs
        [HttpGet]
        public IActionResult TeamDetails(int id)
        {
            //List<Film> model = _context.Films.Find(FilmID);
            Team model = _context.Teams.Find(id);
            return View(model);
        }

        [HttpGet]
        public IActionResult PlayerDetails(int id)
        {
            //List<Player> model = _context.Players.Find(PlayerID);
            Player model = _context.Players.Find(id);
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
