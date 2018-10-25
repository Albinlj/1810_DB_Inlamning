using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _01_Recept
{
    public partial class Form1 : Form
    {
        internal List<Recipe> Recipes { get; set; } = new List<Recipe>();
        internal List<Category> Categories { get; set; } = new List<Category>();
        internal DBManager Db { get; set; } = new DBManager();

        public Form1()
        {
            InitializeComponent();
            LoadObjects();
            UpdateMe();
        }

        private void LoadObjects()
        {
            Recipes = Db.LoadRecipes();
            //Categories = Db.LoadCategories();
        }


        private void UpdateMe()
        {
            lstItems.Items.Clear();
            
            foreach (Recipe recipe in Recipes)
            {
                lstItems.Items.Add(recipe);
            }
        }

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTitle.Text = ((Recipe)lstItems.SelectedItem).Title;
            cbCategory.Text = ((Recipe)lstItems.SelectedItem).CategoryID.ToString();
            tbDescription.Text = ((Recipe)lstItems.SelectedItem).Description;
            tbIngredients.Text = ((Recipe)lstItems.SelectedItem).Ingredients;
        }
    }
}
