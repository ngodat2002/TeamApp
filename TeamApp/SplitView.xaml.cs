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
using TeamApp.Model.Entity;
using TeamApp.PageApp.Services;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TeamApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SplitView : Page
    {
        public SplitView()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(PageApp.home));
            var menu1 = new MenuItem() { Name = "Home", MenuPage = "homepage", Icon = "\uE80F" };
            var menu2 = new MenuItem() { Name = "Eat-In", MenuPage = "eat", Icon = "\uED56" };
            var menu3 = new MenuItem() { Name = "Collection", MenuPage = "collection", Icon = "\uE7AC" };
            var menu4 = new MenuItem() { Name = "Delivery", MenuPage = "delivery", Icon = "\uEA5E" };
            var menu5 = new MenuItem() { Name = "Take Away", MenuPage = "take", Icon = "\uF119" };
            var menu6 = new MenuItem() { Name = "Driver Payment", MenuPage = "payment", Icon = "\uEC5C" };
            var menu7 = new MenuItem() { Name = "Customers", MenuPage = "customer", Icon = "\uE8D4" };

            MenuSpl.Items.Add(menu1);
            MenuSpl.Items.Add(menu2);
            MenuSpl.Items.Add(menu3);
            MenuSpl.Items.Add(menu4);
            MenuSpl.Items.Add(menu5);
            MenuSpl.Items.Add(menu6);
            MenuSpl.Items.Add(menu7);

            RenderDerCategoriesToMenu();
        }
        
        public async void RenderDerCategoriesToMenu()
        {
            ApiService apiService = new ApiService();
            Categories categories = await apiService.GetCategories();
            if (categories != null)
            {
                foreach(var c in categories.data)
                {
                    MenuSpl.Items.Add(new MenuItem() { Name = c.name, Icon = "\uED56",MenuPage ="categories" ,Category = c});
                    }
            }
        }

        private void FontIcon_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Splv.IsPaneOpen = !Splv.IsPaneOpen;
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selected = (MenuItem)MenuSpl.SelectedItem;
            switch (selected.MenuPage)
            {
                case "homepage":
                    MainFrame.Navigate(typeof(PageApp.home));
                    break;
                case "eat":
                    MainFrame.Navigate(typeof(PageApp.Food));
                    break;
                case "collection":
                    MainFrame.Navigate(typeof(PageApp.collection));
                    break;
                case "delivery":
                    MainFrame.Navigate(typeof(PageApp.delivery));
                    break;
                case "take":
                    MainFrame.Navigate(typeof(PageApp.take));
                    break;
                case "payment":
                    MainFrame.Navigate(typeof(PageApp.payment));
                    break;
                case "customer":
                    MainFrame.Navigate(typeof(PageApp.customer));
                    break;
                case "categories":
                    MainFrame.Navigate(typeof(PageApp.FoodCategories),selected.Category);
                    break;
            }
        }
    }
}