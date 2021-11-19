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
    public sealed partial class Eat : Page
    {
        public Eat()
        {
            this.InitializeComponent();
            RenderCategoriesMenu();
        }

        public async void RenderCategoriesMenu()
        {
            ApiService apiService = new ApiService();
            Categories categories = await apiService.GetCategories();
            if (categories != null)
            {
                foreach (var c in categories.data)
                {
                    Product.Items.Add(new MenuItem() { Name = c.name, Icon = new BitmapImage(new Uri(c.icon)),MenuPage="category", Category=c });

                }
            }
        }

    }
}
