using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RedRiverTechnicalWebApp
{
    public partial class RecipeDropdown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitRecipe(object sender, EventArgs e)
        {
            if (RecipeDropdownList.SelectedValue == null || RecipeDropdownList.SelectedValue == "")
            {
                L1.Text = "Please select a recipe.";
            }
            else
            {
                L1.Text = "You selected: " + RecipeDropdownList.SelectedValue;
            }
        }
    }
}