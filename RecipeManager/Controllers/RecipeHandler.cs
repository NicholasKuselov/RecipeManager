using System.Text.Json;
using RecipeManager.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeManager.ViewModels;
using System.Windows;

namespace RecipeManager.Controllers
{
    class RecipeHandler
    {
        public static List<Recipe> Recipes { get; set; }

        public static void Load()
        {

            try
            {
                Recipes = JsonSerializer.Deserialize<List<Recipe>>(File.ReadAllText(FilePath.RecipesFilePath));
                if (Recipes == null)
                {
                    Recipes = new List<Recipe>();
                }
                else
                {
                    Update();
                }
            }
            catch
            {
                MessageBox.Show("Error with loading recipes");
                File.WriteAllText(FilePath.RecipesFilePath, JsonSerializer.Serialize(new List<Recipe>()));
                Recipes = new List<Recipe>();
            }
        }

        public static void AddRecipe(Recipe recipe)
        {
            Recipes.Add(recipe);
            Save();
        }

        public static void AddRecipe(Recipe recipe, int indx)
        {
            Recipes.Insert(indx,recipe);
            Save();
        }

        public static void DeleteRecipe(Recipe recipe)
        {
            for (int i = 0; i < Recipes.Count; i++)
            {
                if (Recipes[i].Name.Equals(recipe.Name))
                {
                    Recipes.RemoveAt(i);
                    Save();
                    ((RecipePageVM)(((MainViewModel)(App.Current.MainWindow.DataContext)).recipesPage.DataContext)).Recipes = new System.ComponentModel.BindingList<Recipe>(Recipes);
                    ((RecipePageVM)(((MainViewModel)(App.Current.MainWindow.DataContext)).recipesPage.DataContext)).GetTags();
                    return;
                }
            }
        }

        private static void Save()
        {
            File.WriteAllText(FilePath.RecipesFilePath, JsonSerializer.Serialize(Recipes));
        }

        public static void Update()
        {
            for (int i = 0; i < Recipes.Count; i++)
            {
                for (int j = 0; j < Recipes[i].Ingredients.Count; j++)
                {
                    try
                    {
                        Ingredient ingredient = DataBaseHandler.GetIngredientById(Recipes[i].Ingredients[j].id);
                        Recipes[i].Ingredients[j].Name = ingredient.Name;
                        Recipes[i].Ingredients[j].Price = ingredient.Price;
                    }
                    catch (Exception)
                    {
                        Recipes[i].Ingredients[j].Name = (string)Application.Current.Resources["NN"];
                        Recipes[i].Ingredients[j].Price = 0;
                    }
                }
                for (int j = 0; j < Recipes[i].InnerRecipes.Count; j++)
                {
                    for (int k= 0; k < Recipes[i].InnerRecipes[j].ARecipe.Ingredients.Count; k++)
                    {
                        try
                        {
                            Ingredient ingredient = DataBaseHandler.GetIngredientById(Recipes[i].InnerRecipes[j].ARecipe.Ingredients[k].id);
                            Recipes[i].InnerRecipes[j].ARecipe.Ingredients[k].Name = ingredient.Name;
                            Recipes[i].InnerRecipes[j].ARecipe.Ingredients[k].Price = ingredient.Price;
                        }
                        catch (Exception)
                        {
                            Recipes[i].InnerRecipes[j].ARecipe.Ingredients[k].Name = (string)Application.Current.Resources["NN"];
                            Recipes[i].InnerRecipes[j].ARecipe.Ingredients[k].Price = 0;
                        }
                    }
                }
            }
        }

        public static Recipe GetRecipeByNameHash(int hash)
        {
            for (int i = 0; i < Recipes.Count; i++)
            {
                if (Recipes[i].Name.GetHashCode() == hash)
                {
                    return Recipes[i];
                }
            }
            return new Recipe() {Name = (string)Application.Current.Resources["DeletedRecipe"] };
        }

        public static List<int> GetRecipesHash()
        {
            List<int> hashes = new List<int>();
            foreach (Recipe item in Recipes)
            {
                hashes.Add(item.Name.GetHashCode());
            }
            return hashes;
        }

        public static bool IsNameEmpty(string name)
        {
            if (Recipes.FindAll(p=> p.Name.ToLower().Equals(name.ToLower())).Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
