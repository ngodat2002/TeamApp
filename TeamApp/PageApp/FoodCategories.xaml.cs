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
    public sealed partial class FoodCategories : Page
    {
        public FoodCategories()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Category category = e.Parameter as Category;
            CategoryName.Text = category.name;
            RenderCategoryDetails(category);
        }

        private async void RenderCategoryDetails(Category category)
        {
            ApiService service = new ApiService();
            CategoryDetail categoryDetail = await service.CategoryDetail(category);
            if (categoryDetail != null)
            {
                foreach(var f in categoryDetail.data.foods)
                {
                    Products.Items.Add(f);
                }
            }
        }

        private void Add_To_Cart(object sender, RoutedEventArgs e)
        {
            var id = ((Button)sender).Tag;
            Food f = new Food() {id =1,name="Demo food",image="...",price=12000};
            CartItem item = new CartItem() { Id = f.id, Name = f.name, Image=f.image,Price=f.price,Qty=1 };
            CartService service = new CartService();
            service.AddToCart(item);

            var list = service.GetCart();
        }
    }
}
