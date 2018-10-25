using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recipe;
using RecipeStorageCSV;
using RecipeTestApp;
using Recipe;

namespace RecipeGUI
{
    public partial class RecipeGui : Form
    {
        List<Recipe.Recipe> allRecipes = new List<Recipe.Recipe>();

        public RecipeGui()
        {
            InitializeComponent();
            init();
        }

        private static readonly String[] TEST_ING_NAMES = {
                "Pfeffer",
                "Salz",
                "Mehl",
                "Zucker",
                "Hefe",
                "Wasser"
        };

        private void init()
        {
            RecipeDataProviderImpl rsStorage = new RecipeDataProviderImpl("test.csv");
            if (rsStorage.Ingredients.Count == 0)
            {
                foreach (String ingName in TEST_ING_NAMES)
                {
                    Ingredient tmpIng = new Ingredient();
                    tmpIng.Name = ingName;
                    System.Console.WriteLine("Add Ingredient: " + tmpIng);
                    rsStorage.AddIngredient(tmpIng);
                }
            }
            if (rsStorage.Recipes.Count == 0)
            {
                Recipe.Recipe kuchenRcp = new Recipe.Recipe();
                kuchenRcp.Name = "Kuchen";
                kuchenRcp.Text = "Zubereitung";
                RecipeItem mehlItem = new RecipeItem();
                mehlItem.Count = 1;
                mehlItem.Unit = "Tasse";
                mehlItem.Ingredient = rsStorage.Ingredients[2];
                RecipeItem backPulverItem = new RecipeItem();
                backPulverItem.Count = 2;
                backPulverItem.Unit = "Messerspitze";
                backPulverItem.Ingredient = new Ingredient();
                backPulverItem.Ingredient.Name = "Backpulver";
                kuchenRcp.addIngredient(mehlItem);
                kuchenRcp.addIngredient(backPulverItem);
                rsStorage.AddRecipe(kuchenRcp);
                System.Console.WriteLine("Add Recipe: " + kuchenRcp);
            }
            foreach (Recipe.Recipe rcp in rsStorage.Recipes)
            {
                RecipeList.Items.Add(rcp.Name);
                allRecipes.Add(rcp);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditForm addForm = new AddEditForm();
            addForm.ShowDialog();
        }

        public void addRecipt(Recipe.Recipe recipe)
        {
            RecipeList.Items.Add(recipe);
            allRecipes.Add(recipe);
        }

        private void RecipeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RecipeList.SelectedIndex < 0)
            {
                return;
            }
            Recipe.Recipe item = allRecipes[RecipeList.SelectedIndex];
            rtb_output.Text = item.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = RecipeList.SelectedIndex;
            allRecipes.RemoveAt(index);
            RecipeList.Items.RemoveAt(index);
            rtb_output.Text = "";
        }
    }
}