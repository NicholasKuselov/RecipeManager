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

    }
}
