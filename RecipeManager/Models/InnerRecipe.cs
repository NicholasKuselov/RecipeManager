using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RecipeManager.Models
{
    public class InnerRecipe
    {
        public int Weigth { get; set; }
        public Recipe ARecipe { get; set; }

        public int Price
        {
            get
            {
                return GetCostPrice();
            }

        }
        public int GetCostPrice()
        {
            int price = 0;
            for (int i = 0; i < ARecipe.Ingredients.Count; i++)
            {
                int tmp = (int)(ARecipe.Ingredients[i].Price * (ARecipe.Ingredients[i].Weigth / 100.0));
                //MessageBox.Show(tmp.ToString());
                double proc = (double)Weigth / (double)ARecipe.Weigth;
                price += (int)(tmp * proc);
            }

            return price;
        }
    }
}
