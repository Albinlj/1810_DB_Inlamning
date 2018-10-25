using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _01_Recept
{
    class DBManager
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=RecipesDB;Integrated Security=true";

        public List<Recipe> LoadRecipes()
        {
            List<Recipe> recipeList = new List<Recipe>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataReader reader = null;
                string commandString = "SELECT * FROM Recipes";

                SqlCommand command = new SqlCommand(commandString, conn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    recipeList.Add(new Recipe()
                    {
                        RecipeID = int.Parse(reader["RecipeID"].ToString()),
                        Title = reader["Title"].ToString(),
                        Description = reader["Description"].ToString(),
                        Ingredients = reader["Ingredients"].ToString(),
                        CategoryID = int.Parse(reader["CategoryID"].ToString())
                    });
                }
                reader.Close();
            }

            return recipeList;
        }

        public List<Category> LoadCategories()
        {
            List<Category> recipeList = new List<Category>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataReader reader = null;
                string commandString = "SELECT * FROM Categories";

                SqlCommand command = new SqlCommand(commandString, conn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    recipeList.Add(new Category()
                    {
                        CategoryID = int.Parse(reader["CategoryID"].ToString()),
                        Name = reader["Name"].ToString()
                    });
                }
                reader.Close();
            }

            return recipeList;
        }
    }
}
