using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// DLL
using FormulaOneDLL;

namespace FormulaOneASP_NetFW
{   
    public partial class Default : System.Web.UI.Page
    {
        DbTools db;

        protected void Page_Load(object sender, EventArgs e)
        {
            db = new DbTools();
            List<CardDriverDLL> driver = new List<CardDriverDLL>();
            driver = db.LoadDrivers();

            //for (int i = 0; i < driver.Count; i++)
            //{
            //    MyComponents.CardDriver card = new MyComponents.CardDriver();
            //    card.CardImage = driver[i].PathImage;
            //    card.Name = driver[i].Name;
            //    card.Team = driver[i].Team;
            //    CardContainer.Controls.Add(card);
            //}
        }

        protected void btnDrivers_Click(object sender, EventArgs e)
        {
            MyComponents.CardDriver card = new MyComponents.CardDriver();
            //card.CardImage = "SAS";
            //card.Name = "SES";
            //card.Team = "SAS";
            CardContainer.Controls.Add(card);
        }
    }
}