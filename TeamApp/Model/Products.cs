﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
namespace TeamApp.Model
{
    class Products
    {
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public BitmapImage Img { get; set; }
    }
}
