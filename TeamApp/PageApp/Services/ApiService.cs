using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamApp.Model.Entity;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using TeamApp.Apdter;
using Windows.UI.Xaml.Media.Imaging;
namespace TeamApp.PageApp.Services
{
    class ApiService
    {
        public async Task<Categories> GetCategories()
        {
            HttpClient client = new HttpClient();//lo viec ket noi api va lay du lieu ve 
            ApiURL uRL1 = ApiURL.GetInstance();

            var rs = await client.GetAsync(uRL1.GetApiCategories()); // lấy data từ api về
            if (rs.StatusCode == HttpStatusCode.OK)
            {
                var rsContent = await rs.Content.ReadAsStringAsync();//Chuyen du lieu thanh 1 string 
                //tim cac convert string o tren thanh 1 object Categories
                Categories categories = JsonConvert.DeserializeObject<Categories>(rsContent);
                return categories;
            }
            return null;
        }

        public async Task<CategoryDetail> CategoryDetail(Category category)
        {
            HttpClient client = new HttpClient();// lo việc kết nối api và lấy dữ liệu về (shipper)
            ApiURL uRL = ApiURL.GetInstance();
            var rs = await client.GetAsync(uRL.GetApiCategoryDetail(category.id)); // lấy data từ api về
            if (rs.StatusCode == HttpStatusCode.OK)
            {
                string rsContent = await rs.Content.ReadAsStringAsync();// chuyeenr dữ liệu thành 1 string
                                                                        // timf cách convert string ở trên thành 1 object Categories
                CategoryDetail detail = JsonConvert.DeserializeObject<CategoryDetail>(rsContent);
                return detail;
            }
            return null;
        }

        public async Task<Foods> GetFoods()
        {
            HttpClient client1 = new HttpClient();
            ApiURL uRL2 = ApiURL.GetInstance();
            var rd = await client1.GetAsync(uRL2.GetFoodMenu());
            if(rd.StatusCode == HttpStatusCode.OK)
            {
                var rdContent = await rd.Content.ReadAsStringAsync();
                Foods foods = JsonConvert.DeserializeObject<Foods>(rdContent);
                return foods;
            }
            return null;
        }
    }
}
