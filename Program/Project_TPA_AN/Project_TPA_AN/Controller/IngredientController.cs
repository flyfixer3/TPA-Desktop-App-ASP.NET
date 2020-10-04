using Project_TPA_AN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TPA_AN.Controller
{
    class IngredientController
    {
        public static void addIngredient(Ingredient newIngredient)
        {
            newIngredient.IngredientStatus = "Active";
            DatabaseSingleton.GetInstance().Ingredients.Add(newIngredient);
            DatabaseSingleton.GetInstance().SaveChanges();
        }

        public static void Update(Ingredient newIngredient)
        {
            Ingredient rd = DatabaseSingleton.GetInstance().Ingredients.Where(x => x.IngredientID == newIngredient.IngredientID).FirstOrDefault();
            rd.IngredientName = newIngredient.IngredientName;
            rd.IngredientStock = newIngredient.IngredientStock;
            rd.IngredientStatus = "Active";
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static void Delete(Ingredient newIngredient)
        {
            var rslt = DatabaseSingleton.GetInstance().Ingredients.Where(x => x.IngredientID == newIngredient.IngredientID).FirstOrDefault();
            rslt.IngredientStatus = "Deleted";
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static Ingredient SearchByID(int id)
        {
            return DatabaseSingleton.GetInstance().Ingredients.Where(x => x.IngredientID == id).FirstOrDefault();
        }
    }
}
