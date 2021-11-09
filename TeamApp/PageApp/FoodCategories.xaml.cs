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
using TeamApp.PageApp.Services;
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
    }
}
