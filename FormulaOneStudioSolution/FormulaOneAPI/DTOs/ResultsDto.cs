using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormulaOneAPI.DTOs
{
    public class ResultsDto
    {
        public string forename { get; set; }
        public string surname { get; set; }
        public int? number { get; set; }
        public int? position { get; set; }
        public string positionText { get; set; }
        public int positionOrder { get; set; }
        public int? laps { get; set; }
        public string fastestLapTime { get; set; }
        public string fastestLapSpeed { get; set; }
        public int? grid { get; set; }
        public double? points { get; set; }
    }
}