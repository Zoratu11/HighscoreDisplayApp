using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HighscoreDisplayApp.Models;

namespace HighscoreDisplayApp.Models.Context
{
    public partial class HighscoreEntities : DbContext
    {
        public virtual DbSet<Score> Scores { get; set; }
    }
}