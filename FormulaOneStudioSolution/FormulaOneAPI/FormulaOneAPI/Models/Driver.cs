using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormulaOneAPI.Models
{
    public class Driver
    {
		public int driverId { get; set; }
		public string driverRef { get; set; }
		//public int number { get; set; }
		public string code { get; set; }
		[Required]
		public string forename { get; set; }
		public string surname { get; set; }
		public DateTime dob { get; set; }
		public string nationality { get; set; }
		public string url { get; set; }
		public string PathImgSmall { get; set; }
	}
}