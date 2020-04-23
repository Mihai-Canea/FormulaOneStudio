using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDLL
{
    [DataContract(Name ="driver")]
    public class Driver
    {
        [DataMember (Name ="pathImage")]
        private string pathImage;
        [DataMember (Name ="name")]
        private string name;
        [DataMember (Name ="team")]
        private string team;

        public Driver()
        {

        }

        public Driver(string pathImage, string name, string team)
        {
            this.pathImage = pathImage;
            this.name = name;
            this.team = team;
        }

        public string PathImage { get => pathImage; set => pathImage = value; }
        public string Name { get => name; set => name = value; }
        public string Team { get => team; set => team = value; }
    }
}
