using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstructuraDatos6370812
{
	public partial class EstructuraDatos : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void Button1_Click(object sender, EventArgs e)
        {
          
            String[] strCategoryArray = new String[5];
            strCategoryArray[0] = "Postre";
            strCategoryArray[1] = "Frutas";
           
            Session["strCategoryArray"] = strCategoryArray;

            Response.Redirect("CategoryUseArraySessionVariables.aspx");

        }
    }
}