using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
namespace TeamApp.Model.Entity
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }

    }
    public class Categories
    {
        public string message { get; set; }
        public List<Category> data { get; set; }
    }

    public class Food
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public string price { get; set; }
    }
    //FOOD 
    public class Foods
    {
        public string message { get; set; }
        public List<Food> data { get; set; }
    }
    //END FOOD

    //CATEGORY
    public class FoodOfCategory
    {
        public string message { get; set; }
        public List<Food> foods { get; set; }
    }
    public class CategoryDetail
    {
        public string message { get; set; }
        public FoodOfCategory data { get; set; }
    }
    //END CATEGORY


}
