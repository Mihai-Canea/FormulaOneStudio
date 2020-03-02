using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FormulaOneDLL;

namespace FormulaOneASP_NetFW.MyComponents
{
    public partial class TableDrivers : System.Web.UI.UserControl
    {
        DbTools db;

        protected void Page_Load(object sender, EventArgs e)
        {
            db = new DbTools();
            gridTable.DataSource = db.LoadTableDrivers();
            gridTable.DataBind();
        }

    }
}