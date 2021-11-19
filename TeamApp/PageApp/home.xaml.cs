using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using TeamApp.Model;
using Windows.UI.Xaml.Media.Imaging;
using TeamApp.Model.Entity;
using TeamApp.PageApp.Services;
using TeamApp.Apdter;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TeamApp.PageApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class home : Page
    {
        public home()
        {
            this.InitializeComponent();
            RenderFood();
            SQLiteHelper sQ = SQLiteHelper.GetInstance();

        }
        public async void RenderFood()
        {
            // if (categories != null)
            //     {
            //       foreach (var c in categories.data)
            //     {
            //       MenuSpl.Items.Add(new MenuItem() { Name = c.name, Icon = "\uF119", MenuPage = "take" });
            // }
            //  }
            ApiService apiService1 = new ApiService();
            Foods foods = await apiService1.GetFoods();
            if (foods != null)
            {
                foreach (var c in foods.data)
                {
                    Product.Items.Add(new Products() { id = c.id, ProductName = c.name, Description = c.description, Price = "$" + c.price, Img = new BitmapImage(new Uri(c.image)) });
                }
            }
        }

    

    }
}
