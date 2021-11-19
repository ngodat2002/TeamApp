using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamApp.Model;
using TeamApp.Model.Entity;
using Windows.UI.Xaml.Media.Imaging;

namespace TeamApp.Model
{
    class MenuCategory
    {
        public string Name { get; set; }
        public string MenuPage { get; set; }
        public BitmapImage Icon { get; set; }
        public Category Category { get; set; }
    }
}
