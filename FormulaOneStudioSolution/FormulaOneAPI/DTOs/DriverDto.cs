using FormulaOneAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormulaOneAPI.DTOs
{
    public class DriverDto
    {
        public int driverId { get; set; }
        public string forename { get; set; }
        public string surname { get; set; }
        public string constructor { get; set; }
        public int? number { get; set; }
        public string PathImgSmall { get; set; }
    }
}