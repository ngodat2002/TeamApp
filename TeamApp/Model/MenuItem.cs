using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamApp.Model
{
    class MenuItem
    {
        public string Name { get; set; } //abtract property -- Khi nao nap data vao thi moi ton o nho --> thich hop dung cho cac model-entity - DTO 
        public string MenuPage { get; set; }
        public string Icon { get; set; }
    }
}
