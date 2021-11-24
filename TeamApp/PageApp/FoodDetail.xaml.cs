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
using TeamApp.Model.Entity;
using Windows.UI.Xaml.Media.Imaging;
using TeamApp.Apdter;
using TeamApp.Model;
using TeamApp.PageApp.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TeamApp.PageApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FoodDetail : Page
    {
        public FoodDetail()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Home home = e.Parameter as Home;
            RenderProductDetail(home);
        }
        private async void RenderProductDetail(Home home)
        {
            ApiService service = new ApiService();
            FoodDetails detail = await service.GetProduct(home);
            if (detail != null)
            {
                Products.Items.Add(detail.data);
            }
        }
    }
}
