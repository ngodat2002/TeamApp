using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace TeamApp.Model.Entity
{
    public class Home
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public int price { get; set; }
    }

    public class Homes
    {
        public string message { get; set; }
        public List<Home> data { get; set; }
    }
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
        public int price { get; set; }
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
    public class OrderDetail
    {
        public int order_id { get; set; }
    }

    public class CreateOrder
    {
        public string message { get; set; }
        public OrderDetail data { get; set; }
    }
    //detail
    public class FoodDetail
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public int price { get; set; }
    }

    public class FoodDetails
    {
        public string message { get; set; }
        public FoodDetail data { get; set; }
    }
}
