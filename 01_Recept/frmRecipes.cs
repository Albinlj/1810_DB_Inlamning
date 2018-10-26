using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _01_Recept
{
    public partial class frmRecipes : Form
    {
        internal List<Recipe> Recipes { get; set; } = new List<Recipe>();
        internal List<Category> Categories { get; set; } = new List<Category>();
        internal DBManager Db { get; set; } = new DBManager();

        public frmRecipes()
        {
            InitializeComponent();
            LoadObjects();
            UpdateItemList();
        }

        private void LoadObjects()
        {
            Categories = Db.LoadCategories();
            Recipes = Db.LoadRecipes(Categories);
            cbSearchCategory.Items.Add("");
            cbSearchCategory.SelectedIndex = 0;
            foreach (Category category in Categories)
            {
                cbSearchCategory.Items.Add(category);
                cbCategory.Items.Add(category);
            }

        }


        private void UpdateItemList()
        {
            lstItems.Items.Clear();

            foreach (Recipe recipe in Recipes)
            {
                if (recipe.Title.ToLower().Contains(tbSearchTitle.Text.ToLower()))
                {
                    if (cbSearchCategory.SelectedIndex == 0 || cbSearchCategory.SelectedItem == recipe.Category)
                    {
                        lstItems.Items.Add(recipe);
                    }
                }
            }
        }



        private void UpdateDetailBoxes()
        {
            if (lstItems.SelectedItem == null)
            {
                return;
            }
            tbTitle.Text = ((Recipe)lstItems.SelectedItem).Title;
            cbCategory.SelectedItem = ((Recipe)lstItems.SelectedItem).Category;
            tbDescription.Text = ((Recipe)lstItems.SelectedItem).Description;
            tbIngredients.Text = ((Recipe)lstItems.SelectedItem).Ingredients;
            btnUpdate.Enabled = true;
        }

        private void DeleteSelectedRecipe()
        {
            Recipe recipe = (Recipe)lstItems.SelectedItem;
            if (recipe == null)
            {
                MessageBox.Show("No Recipe selected!");
            }
            Recipes.Remove(recipe);
            Db.DeleteRecipe(recipe.RecipeID);
            UpdateItemList();
            MessageBox.Show("Successfully deleted recipe.");
        }

        private void AddRecipe()
        {
            Recipe newRecipe = new Recipe();
            newRecipe.Title = tbTitle.Text;
            newRecipe.Category = (Category)cbCategory.SelectedItem;
            newRecipe.Description = tbDescription.Text;
            newRecipe.Ingredients = tbIngredients.Text;
            newRecipe.RecipeID = Db.AddRecipe(newRecipe);

            Recipes.Add(newRecipe);
            UpdateItemList();
        }

        private void UpdateRecipe()
        {
            Recipe recipe = (Recipe)lstItems.SelectedItem;
            if (recipe == null)
            {
                MessageBox.Show("No Recipe selected!");
                return;
            }

            recipe.Title = tbTitle.Text;
            recipe.Description = tbDescription.Text;
            recipe.Ingredients = tbIngredients.Text;
            recipe.Category = (Category)cbCategory.SelectedItem;

            Db.UpdateRecipe((Recipe)lstItems.SelectedItem);
            UpdateItemList();
        }



        private void tbSearchTitle_TextChanged(object sender, EventArgs e)
        {
            UpdateItemList();
        }

        private void cbSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateItemList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedRecipe();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRecipe();
            UpdateItemList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateRecipe();
        }

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDetailBoxes();
        }
    }
}
