using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDLL
{
    public class CardDriverDLL
    {
        private string pathImage;
        private string name;
        private string team;

        public CardDriverDLL(string pathImage, string name, string team)
        {
            this.PathImage = pathImage;
            this.Name = name;
            this.Team = team;
        }

        public string PathImage { get => pathImage; set => pathImage = value; }
        public string Name { get => name; set => name = value; }
        public string Team { get => team; set => team = value; }
    }
}
