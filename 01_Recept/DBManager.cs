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

        public List<Recipe> LoadRecipes(List<Category> categories)
        {
            List<Recipe> recipeList = new List<Recipe>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string commandString = "SELECT * FROM Recipes";
                SqlCommand command = new SqlCommand(commandString, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var newRecipe = new Recipe();
                    newRecipe.RecipeID = int.Parse(reader["RecipeID"].ToString());
                    newRecipe.Title = reader["Title"].ToString();
                    newRecipe.Description = reader["Description"].ToString();
                    newRecipe.Ingredients = reader["Ingredients"].ToString();
                    if (reader["CategoryID"] == DBNull.Value)
                    {
                        newRecipe.Category = null;
                    }
                    else
                    {
                        newRecipe.Category = categories.Find(x => x.CategoryID == int.Parse(reader["CategoryID"].ToString()));
                    }
                    recipeList.Add(newRecipe);
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

        public void DeleteRecipe(int recipeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string commandString = $"DELETE FROM Recipes " +
                                       $"WHERE RecipeID = {recipeId}";

                SqlCommand command = new SqlCommand(commandString, conn);
                command.ExecuteNonQuery();
            }
        }

        public int AddRecipe(Recipe recipe)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string insertString = $"INSERT INTO Recipes " +
                                      $"(Title, Description, Ingredients, CategoryID) " +
                                      $"VALUES (@Title, @Description, @Ingredients, @CategoryID)";
                SqlCommand insertCommand = new SqlCommand(insertString, conn);
                insertCommand.Parameters.AddWithValue("@Title", recipe.Title);
                insertCommand.Parameters.AddWithValue("@Description", recipe.Description);
                insertCommand.Parameters.AddWithValue("@Ingredients", recipe.Ingredients);
                if (recipe.Category == null)
                    insertCommand.Parameters.AddWithValue("@CategoryID", DBNull.Value);
                else
                    insertCommand.Parameters.AddWithValue("@CategoryID", recipe.Category.CategoryID);
                insertCommand.ExecuteNonQuery();

                string identityString = $"SELECT @@IDENTITY";
                SqlCommand identityCommand = new SqlCommand(identityString, conn);
                return Convert.ToInt32(identityCommand.ExecuteScalar());
            }
        }


        public void UpdateRecipe(Recipe recipe)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string updateString = $"UPDATE Recipes " +
                                     $"SET Title = @Title, Description = @Description, Ingredients = @Ingredients, CategoryID = @CategoryID " +
                                     $"WHERE RecipeID = @RecipeID";
                SqlCommand command = new SqlCommand(updateString, conn);
                command.Parameters.AddWithValue("@Title", recipe.Title);
                command.Parameters.AddWithValue("@Description", recipe.Description);
                command.Parameters.AddWithValue("@Ingredients", recipe.Ingredients);

                if (recipe.Category == null)
                    command.Parameters.AddWithValue("@CategoryID", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@CategoryID", recipe.Category.CategoryID);
                command.Parameters.AddWithValue("@RecipeID", recipe.RecipeID);
                command.ExecuteNonQuery();
            }
        }
    }
}