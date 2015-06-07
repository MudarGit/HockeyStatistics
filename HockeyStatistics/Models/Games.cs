using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HockeyStatistics.Models
{
    public class Games
    {


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public Boolean AddGame { get; set; }

        public DateTime Date { get; set; }
        
        public string Name { get; set; }

        public Boolean Win { get; set; }

        public double Goals { get; set; }


    }
}