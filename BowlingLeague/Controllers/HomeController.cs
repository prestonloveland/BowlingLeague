/*
 * Preston Loveland
 * Assignment 10
 * Section 1 Group 11
 */
using BowlingLeague.Models;
using BowlingLeague.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingLeague.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //creates database context to access db records
        private BowlingLeagueContext _context { get; set; }

        public HomeController(ILogger<HomeController> logger, BowlingLeagueContext ctx)
        {
            _logger = logger;
            _context = ctx;
        }
        //action for calling the index page, passing in below parameters, creating instance of an IndexViewModel in order to easily pass the information to the view

        public IActionResult Index(long? teamid, string teamname, int pageNum = 0)
        {
            int pageSize = 5;
            ViewBag.TeamName = teamname;

            return View(new IndexViewModel
            {
                //LINQ to return db records
                Bowlers = (_context.Bowlers
                .Where(x => x.TeamId == teamid || teamid == null)
                .OrderBy(x => x.BowlerLastName)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize)
                .ToList()),

                PageNumbering = new PageNumberingInfo
                {
                    NumItemsPerPage = pageSize,
                    CurrentPage = pageNum,

                    //if statment to allow for teams being selected and count still working
                    TotalNumItems = (teamid == null ? _context.Bowlers.Count() :
                    _context.Bowlers.Where(x => x.TeamId == teamid).Count())
                },
                Team = teamname
            }
                
                );
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
