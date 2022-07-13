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

            MakeRecipe(RecipeDropdownList.SelectedValue);
        }

        /* Determines which recipe the user selected and begins 
         * preparations dependent on that order
         */
        private void MakeRecipe(string recipe)
        { 
            // Begins the process in a given order based on the recipe
            BoilWater(recipe);

            if (recipe == "Chocolate")
            {
                // Add the chocolate powder to the Chocolate
                AddToDrink(recipe);
                // Pour the chocolate into the cup
                PourDrink(recipe);
            }
            else
            {
                // Steeps/Brews the tea or coffee
                SteepDrink(recipe);
                // Pours the tea or coffee into a cup
                PourDrink(recipe);
                // Adds lemon or milk and sugar to the cup
                AddToDrink(recipe);
            }
        }

        /* Boils the water for the given recipe
         */
        private void BoilWater(string recipe)
        {
            throw new NotImplementedException();
        }

        /* Steeps the tea or coffee for three minutes
        */
        private void SteepDrink(string recipe)
        {
            throw new NotImplementedException();
        }

        /* Pours the selected drink into a cup
         */
        private void PourDrink(string recipe)
        {
            throw new NotImplementedException();
        }

        /* Adds lemon, milk and sugar, or drinking chocolate to 
         * the drink
         */
        private void AddToDrink(string recipe)
        {
            throw new NotImplementedException();
        }

    }
}