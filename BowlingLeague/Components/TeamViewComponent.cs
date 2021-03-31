/*
 * Preston Loveland
 * Assignment 10
 * Section 1 Group 11
 */
using BowlingLeague.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingLeague.Components
{
    public class TeamViewComponent : ViewComponent
    {
        private BowlingLeagueContext context;

        public TeamViewComponent(BowlingLeagueContext ctx)
        {
            context = ctx;
        }

        //returns view with distinct list of teams from the database

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["teamname"];

            return View(context.Teams
                .Distinct()
                .OrderBy(x => x));
        }


    }
}
