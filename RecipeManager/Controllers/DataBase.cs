using RecipeManager.Models;
using RecipeManager.Models.DataBaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RecipeManager.Controllers
{
    class DataBaseHandler
    {
        public static DataBaseContext DataBase { get; set; } = new DataBaseContext();



        public static Ingredient GetIngredientById(int id)
        {
            return DataBase.ingredients.First(p => p.idingredient == id);
        }

        public static Client GetClientById(int id)
        {
            return DataBase.clients.First(p => p.idclient == id);
        }

        public static SellsHistoryEntry GetSellsEntryById(int id)
        {
            return DataBase.history.First(p => p.idhistory == id);
        }

        public static List<SellsHistoryEntry> GetSellsEntryByClietnId(int id)
        {
            return new List<SellsHistoryEntry>(DataBase.history.Where(p => p.buyer == id));
        }

        public static void UpdateIngredient(Ingredient ingredient)
        {
            for (int i = 0; i < DataBase.ingredients.Count(); i++)
            {
                if (DataBase.ingredients.ToList()[i].idingredient == ingredient.idingredient)
                {
                    DataBase.ingredients.Local.ElementAtOrDefault(i).Name = ingredient.Name;
                    DataBase.ingredients.Local.ElementAtOrDefault(i).Price = ingredient.Price;
                    break;
                }
            }
            DataBase.SaveChanges();
        }

        public static void UpdateSellsProductHash(int oldHash, int newHash)
        {
            for (int i = 0; i < DataBase.history.Count(); i++)
            {
                if (Convert.ToInt32(DataBase.history.ToList()[i].recipe) == oldHash)
                {
                    DataBase.history.Local.ElementAtOrDefault(i).recipe = newHash.ToString();
                }
            }
            DataBase.SaveChanges();
        }

    }
}
