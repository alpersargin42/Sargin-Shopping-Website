﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Match
    {
        [Key] public int MatchID { get; set; }
        public int? HomeTeamID { get; set; }
        public int? GuestTeamID { get; set; }
        public string MatchDate { get; set; }
        public string Stadium { get; set; }
        public Team HomeTeam { get; set; }
        public Team GuesTeam { get; set; }
    }
}
