using fatmee.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace fatmee.ViewModels
{
    internal class AddRestauratData
    {
        public List<Restaurant> Restaurants { get; set; }
        public FirebaseClient client;

        public AddRestauratData ()
        {
            client = new FirebaseClient ("https://fatme-d8735-default-rtdb.firebaseio.com/");
            Restaurants = new List<Restaurant> ()
            {
                  new Restaurant ()
                  {
                    RestaurantId =1,
                    RestaurantName= "Starbucks ",
                    RestaurantImg ="Starbucks .png",
                    RestaurantDc ="10 Ngõ 282 Kim Giang, Hoàng Mai, Hà Nội",
                    RestaurantKc ="1.5km"
                  },

                  new Restaurant ()
                  {
                    RestaurantId =2,
                    RestaurantName= "McDonald's",
                    RestaurantImg ="McDonald's.png",
                    RestaurantDc ="80C Đường Số 49, P. Tân Quy, Quận 7, TP. HCM",
                    RestaurantKc ="3.0km"
                  },

                  new Restaurant ()
                  {
                    RestaurantId =3,
                    RestaurantName= "Domino's",
                    RestaurantImg ="Domino's.png",
                    RestaurantDc ="341/19/129 Khuông Việt, P. Phú Trung, Tân Phú, TP. HCM",
                    RestaurantKc ="0.7km"
                  },

                  new Restaurant ()
                  {
                    RestaurantId =4,
                    RestaurantName= "Jollibee",
                    RestaurantImg ="Jollibee.png",
                    RestaurantDc ="162 Phan Huy Ích, P.12, Gò Vấp, TP. HCM",
                    RestaurantKc ="5km"
                  },
            };
        }

        public async Task AddRestaurantAsync ()
        {
            try
            {
                foreach (var Item in Restaurants)
                    await client.Child ("restaurant").PostAsync (new Restaurant ()
                    {
                        RestaurantId = Item.RestaurantId,
                        RestaurantName = Item.RestaurantName,
                        RestaurantImg = Item.RestaurantImg,
                        RestaurantDc = Item.RestaurantKc,
                        RestaurantKc = Item.RestaurantKc,
                    });
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert ("Error", ex.Message, "OK");
            }
        }
    }
}