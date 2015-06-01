using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HockeyStatistics.Models
{
    public class Stats
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public double GamesPlayed { get; set; }
        public double Goals { get; set; }
        public double Wins { get; set; }
        public double Losses { get; set; }

        public double WinPercentage { get; set; }

        [Key]
        public int Rank { get; set; }
    }
}