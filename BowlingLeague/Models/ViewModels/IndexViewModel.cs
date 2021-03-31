/*
 * Preston Loveland
 * Assignment 10
 * Section 1 Group 11
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingLeague.Models.ViewModels
{
    //helps store information passed to view in one easy bundle
    public class IndexViewModel
    {
        public List<Bowlers>Bowlers { get; set; }
        public PageNumberingInfo PageNumbering { get; set; }
        public string Team { get; set; }
    }
}
