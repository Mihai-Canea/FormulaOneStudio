using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormulaOneAPI.DTOs
{
    public class DriverDetailDto
    {
		public string forename { get; set; }
		public string surname { get; set; }
		public DateTime dob { get; set; }
		public string nationality { get; set; }
		public string url { get; set; }
		public string PathImgSmall { get; set; }
	}
}