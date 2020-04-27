using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormulaOneAPI.Models
{
    public class Circuit
    {
		public int circuitId { get; set; }
		public string circuitRef { get; set; }
		public string name { get; set; }
		public string location { get; set; }
		public string country { get; set; }
		public double? lat { get; set; }
		public double? lng { get; set; }
		public int? alt { get; set; }
		public string url { get; set; }
		public string PathImgSmall { get; set; }
	}
}