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
    class CategoryMenu
    {
        public string Name { get; set; } //abtract property -- Khi nao nap data vao thi moi ton o nho --> thich hop dung cho cac model-entity - DTO 
        public string MenuPage { get; set; }
        public BitmapImage Icon { get; set; }

        public Category Category { get; set; }
    }
}
