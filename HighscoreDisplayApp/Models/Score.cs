﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HighscoreDisplayApp.Models
{
    public class Score
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public int HighScore { get; set; }
    }
}