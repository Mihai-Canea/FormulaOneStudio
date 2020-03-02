using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormulaOneASP_NetFW.MyComponents
{
    public partial class CardDriver : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public String CardImage
        {
            get { return imgDriver.ImageUrl; }
            set { imgDriver.ImageUrl = value; }
        }

        public string Name
        {
            get { return lblNome.Text; }
            set { lblNome.Text = value; }
        }

        public string Team
        {
            get { return lblTeam.Text; }
            set { lblTeam.Text = value; }
        }
    }
}