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


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TeamApp.PageApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Food : Page
    {
        public Food()
        {
            this.InitializeComponent();
            var p1 = new Products() { ProductName = "Burger", Description = "Lorem ipsum is a dummy text which is used as a placeholder" ,Price="$13",Img =  new BitmapImage(new Uri("https://massageishealthy.com/wp-content/uploads/2019/06/hinh-anh-do-an-hinh-anh-mon-an-thuc-an-ngon-dep-viet-nam-the-gioi-4.png"))};
            var p2 = new Products() { ProductName = "Cake", Description = "Lorem ipsum is a dummy text which is used as a placeholder", Price = "$23", Img = new BitmapImage(new Uri("https://massageishealthy.com/wp-content/uploads/2019/06/hinh-anh-do-an-hinh-anh-mon-an-thuc-an-ngon-dep-viet-nam-the-gioi-4.png")) };
            var p3 = new Products() { ProductName = "Pizza", Description = "Lorem ipsum is a dummy text which is used as a placeholder", Price = "$33", Img = new BitmapImage(new Uri("https://massageishealthy.com/wp-content/uploads/2019/06/hinh-anh-do-an-hinh-anh-mon-an-thuc-an-ngon-dep-viet-nam-the-gioi-4.png")) };
            Product.Items.Add(p1);
            Product.Items.Add(p2);
            Product.Items.Add(p3);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Product_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
