﻿using System;
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

      
        protected void btnLookup_Click(object sender, EventArgs e)
        {
            // Declare a new array.
            String[] strCategoryArray = new String[2];
            // Get the array from the session variable.
            strCategoryArray = Session["strCategoryArray"] as String[];
            // Use the array as normal.
            Int32 i32Index = Convert.ToInt32(txtIndex.Text);
            lblCategory.Text = strCategoryArray[i32Index];

        }
    }
}