using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormulaOneAPI.DTOs
{
    public class RacesDto
    {
        public int year { get; set; }
        public int round { get; set; }
        public string name { get; set; }
        public DateTime? date { get; set; }
        public TimeSpan? time { get; set; }
        public string circuitName { get; set; }
        public string url { get; set; }
        public string PathImgSmall { get; set; }
    }
}