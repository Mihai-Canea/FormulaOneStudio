using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormulaOneAPI.Models
{
    public class Race
    {
        public int raceId { get; set; }
        public int year { get; set; }
        public int round { get; set; }
        public int circuitId { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }
        public TimeSpan time { get; set; }
        public string url { get; set; }
    }
}