using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamApp.PageApp.Services;
using TeamApp.Model.Entity;
using SQLitePCL;
using TeamApp.Apdter;
namespace TeamApp.PageApp.Services
{
    interface ICartService
    {
        List<CartItem> GetCart();// cai nay goi la gi? // abtract method
        bool AddToCart(CartItem item);
        bool RemoveItem(CartItem item);
        bool UpdateItem(CartItem item, int newQty);
        bool ClearCart();
    }
    class CartService : ICartService
    {
        public bool AddToCart(CartItem item)
        {
            try
            {
                SQLiteConnection connection = SQLiteHelper.GetInstance().SQLiteConnection;
                var sql_txt = "insert into Cart(Id,Name,Image,Price,Qty) values(?,?,?,?,?)";
                var statement = connection.Prepare(sql_txt);
                statement.Bind(1, item.Id);
                statement.Bind(2, item.Name);
                statement.Bind(3, item.Image);
                statement.Bind(4, item.Price);
                statement.Bind(5, item.Qty);
                var rs = statement.Step();
                return rs == SQLiteResult.OK;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool ClearCart()
        {
            throw new NotImplementedException();
        }

        public List<CartItem> GetCart()
        {
            List<CartItem> cart = new List<CartItem>();
            try
            {
                SQLiteConnection connection = SQLiteHelper.GetInstance().SQLiteConnection;
                var sql_txt = "select * from Cart";
                var statement = connection.Prepare(sql_txt);
                while (SQLiteResult.ROW == statement.Step())
                {
                    CartItem item = new CartItem()
                    {
                        Id = Convert.ToInt32(statement[0]),
                        Name = statement[1] as string,
                        Image = statement[2] as string,
                        Price = Convert.ToInt32(statement[3]),
                        Qty = Convert.ToInt32(statement[4]),
                    };
                    cart.Add(item);
                }

            }
            catch (Exception e)
            {

            }
            return cart;
        }

        public bool RemoveItem(CartItem item)
        {
            throw new NotImplementedException();
        }

        public bool UpdateItem(CartItem item, int newQty)
        {
            try
            {
                SQLiteConnection connection = SQLiteHelper.GetInstance().SQLiteConnection;
                var sql_txt = "update Cart set Qty=? where Id = ?";
                var statement = connection.Prepare(sql_txt);
                statement.Bind(1, newQty);
                statement.Bind(2, item.Id);
                var rs = statement.Step();
                return rs == SQLiteResult.OK;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
