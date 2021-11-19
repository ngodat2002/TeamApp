using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using TeamApp.Model.Entity;
using Windows.Web.Http;
using TeamApp.Apdter;
using Newtonsoft.Json;
using Windows.Storage.Streams;

namespace TeamApp.PageApp.Services
{
    class OrderService
    {
        public async Task<CreateOrder> CreateOrder()
        {
            CartService cs = new CartService();
            var items = cs.GetCart(); //list cart item
            if (items.Count > 0)
            {
                ApiURL apiURL = ApiURL.GetInstance();
                HttpClient httpClient = new HttpClient();
                Uri uri = new Uri(apiURL.GetApiCreateOrder());
                HttpStringContent content = new HttpStringContent( //nap partameters
                    "items:" + JsonConvert.SerializeObject(items),
                    UnicodeEncoding.Utf8,
                    "application/json"
                    );
                HttpResponseMessage msg = await httpClient.PostAsync(uri, content); //post api
                var rsBody = await msg.Content.ReadAsStringAsync(); //da post va nhan reponse -> bien thanh 1 string
                CreateOrder createOrder = JsonConvert.DeserializeObject<CreateOrder>(rsBody);
                return createOrder;
            }
            return null;
        }
    }
}
