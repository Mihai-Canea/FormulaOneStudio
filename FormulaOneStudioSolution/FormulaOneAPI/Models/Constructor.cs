using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormulaOneAPI.Models
{
    public class Constructor
    {
		public int constructorId { get; set; }
		public string constructorRef { get; set; }
		public string name { get; set; }
		public string nationality { get; set; }
		public string url { get; set; }
		public string PathImgSmall { get; set; }
	}
}