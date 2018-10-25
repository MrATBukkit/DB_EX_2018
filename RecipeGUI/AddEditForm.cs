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

namespace RecipeGUI
{
    public partial class AddEditForm : Form
    {
        RecipeDataProviderImpl rsStorage = new RecipeDataProviderImpl("test.csv");


        public AddEditForm()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            foreach (Ingredient ingredient in rsStorage.Ingredients)
            {
                cb_ingredient.Items.Add(ingredient);
            }
        }

        private void btn_addReciptItem_Click(object sender, EventArgs e)
        {
            RecipeItem newReciptItem = new RecipeItem();
            Ingredient selectedIngredient = (Ingredient)cb_ingredient.SelectedItem;
            if (selectedIngredient == null)
            {
                MessageBox.Show("Bitte eine Zutat wählen");
                return;
            }
            else
            {
                newReciptItem.Ingredient = selectedIngredient;
            }
            newReciptItem.Count = (uint)num_ammount.Value;
            newReciptItem.Unit = tb_RecipeName.Text;
            lb_reciptItems.Items.Add(newReciptItem);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Recipe.Recipe newRecipe = new Recipe.Recipe();
            newRecipe.Name = tb_RecipeName.Text;
            newRecipe.Text = rtb_Zubereitung.Text;
            foreach (RecipeItem item in lb_reciptItems.Items)
            {
                newRecipe.addIngredient(item);
            }
            RecipeGui form = (RecipeGui)this.Owner;
            form.addRecipt(newRecipe);
            this.Close();
        }
    }
}
