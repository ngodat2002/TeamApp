using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamApp.Apdter
{
    sealed class ApiURL
    {
        private readonly string baseURL = "http://foodgroup.herokuapp.com";

        private static ApiURL instance;

        private ApiURL()
        {

        }
        //singleton - parten -- "design pattern"
        public static ApiURL GetInstance()
        {
            if (instance == null)
            {
                instance = new ApiURL();
            }
            return instance;
        }
        public string GetFoodMenu()
        {
            return String.Format(baseURL + "/api/today-special");
        }
        public string GetApiCategories()
        {
            return String.Format(baseURL + "/api/menu");
        }
        public string GetApiProductDetail()
        {
            return String.Format(baseURL + "/api/food/1");
        }
        public string GetApiCategoryDetail(int id)
        {
            return String.Format(baseURL + "/api/category/" + Convert.ToString(id));
        }

        public string GetApiCreateOrder()
        {
            return String.Format(baseURL + "/api/create-order");
        }

    }
}
