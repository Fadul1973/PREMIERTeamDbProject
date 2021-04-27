using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using PREMIERTeamDbProject.Models;

namespace PREMIERTeamDbProject.Controllers
{
    public class PlayerController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;
       
        public PlayerController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllPlayers()
        {
            List<Player> model = _context.Players.ToList();
            return View(model);
        }

        public IActionResult Search2(String SearchString, String certType)
        {

            var players = from m in _context.Players

                        select m;

            if (!string.IsNullOrEmpty(SearchString))

            {

                players = players.Where(s => s.PlayerName.Contains(SearchString));

            }

            if (!string.IsNullOrEmpty(certType))
            {
                players = players.Where(x => x.PlayerClub == certType);
            }

            var playerCerts = _context.Players.Select(m => m.PlayerClub).Distinct();


            List<Player> model = players.ToList();
            ViewData["SearchString"] = SearchString;
            ViewData["FilterPlayerCert"] = certType;
            ViewData["playerCerts"] = playerCerts.ToList();
            ViewData["playerCertsSelectList"] = new SelectList(playerCerts.ToList());
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
