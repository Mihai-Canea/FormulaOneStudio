using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Web;

namespace FormulaOneAPI.Models
{
    public class Result
    {
		public int resultId { get; set; }
		public int raceId { get; set; }
		public int driverId { get; set; }
		public int constructorId { get; set; }
		public int? number { get; set; }
		public int grid { get; set; }
		public int? position { get; set; }
		public string positionText { get; set; }
		public int positionOrder { get; set; }
		public double? points { get; set; }
		public int laps { get; set; }
		public string time{ get; set; }
		public int? milliseconds{ get; set; }
		public int? fastestLap{ get; set; }
		public int? rank{ get; set; }
		public string fastestLapTime{ get; set; }
		public string fastestLapSpeed{ get; set; }
		public int statusId{ get; set; }
	}
}