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
    internal class AddFoodItemData
    {
        public List<FoodItem> Foods { get; set; }
        public FirebaseClient client;

        public AddFoodItemData ()
        {
            client = new FirebaseClient ("https://fatme-d8735-default-rtdb.firebaseio.com/");

            Foods = new List<FoodItem> ()
            {
                new FoodItem ()
                {
                    FoodItemId = 1,
                    FoodItemImg= "ma1.png",
                    FoodItemName="Duo Waffle Dog",
                    FoodItemRestaurentId=1,
                    FoodItemCategory= 2,
                    FoodItemPrice=100
                },

                new FoodItem ()
                {
                    FoodItemId = 2,
                    FoodItemImg= "ma2.png",
                    FoodItemName="Iced Asian Dolce Latte",
                    FoodItemRestaurentId=1,
                    FoodItemCategory=7,
                    FoodItemPrice=95
                },

                new FoodItem ()
                {
                    FoodItemId = 3,
                    FoodItemImg= "ma3.png",
                    FoodItemName="Mon Red Velvet Muffin",
                    FoodItemRestaurentId=1,
                    FoodItemCategory=2,
                    FoodItemPrice=90
                },

                new FoodItem ()
                {
                    FoodItemId = 4,
                    FoodItemImg= "ma4.png",
                    FoodItemName="Raspberry Black Currant",
                    FoodItemRestaurentId=1,
                    FoodItemCategory= 7,
                    FoodItemPrice=85
                },

                new FoodItem ()
                {
                    FoodItemId = 5,
                    FoodItemImg= "ma5.png",
                    FoodItemName="Phần Ăn Cỡ Vừa 2 Miếng Gà Rán",
                    FoodItemRestaurentId=2,
                    FoodItemCategory=2,
                    FoodItemPrice=119
                },

                new FoodItem ()
                {
                    FoodItemId = 6,
                    FoodItemImg= "ma6.png",
                    FoodItemName="Happy Meal Chicken Burger - kèm đồ chơi hoặc sách",
                    FoodItemRestaurentId=2,
                    FoodItemCategory=2,
                    FoodItemPrice=89
                },

                new FoodItem ()
                {
                    FoodItemId = 7,
                    FoodItemImg= "ma7.png",
                    FoodItemName="Coca-Cola Cỡ Lớn",
                    FoodItemRestaurentId=2,
                    FoodItemCategory=7,
                    FoodItemPrice=29
                },

                new FoodItem ()
                {
                    FoodItemId = 8,
                    FoodItemImg= "ma8.png",
                    FoodItemName="Big Breakfast",
                    FoodItemRestaurentId=2,
                    FoodItemCategory=5,
                    FoodItemPrice=79
                },

                new FoodItem ()
                {
                    FoodItemId = 9,
                    FoodItemImg= "ma9.png",
                    FoodItemName="Bắp Ngô Tách Hạt cỡ Lớn",
                    FoodItemRestaurentId=2,
                    FoodItemCategory=1,
                    FoodItemPrice=40
                },

                new FoodItem ()
                {
                    FoodItemId = 10,
                    FoodItemImg= "ma10.png",
                    FoodItemName="Pizza Bò Beefsteak Phô Mai Kiểu New York Cỡ Vừa/ New York CheeseSteak Pizza Size M",
                    FoodItemRestaurentId=3,
                    FoodItemCategory=2,
                    FoodItemPrice=209                },

                new FoodItem ()
                {
                    FoodItemId = 11,
                    FoodItemImg= "ma11.png",
                    FoodItemName="Pizza Hải Sản Xốt Cà Chua Cỡ Vừa/ Seafood Delight Pizza Size M",
                    FoodItemRestaurentId=3,
                    FoodItemCategory=2,
                    FoodItemPrice=189
                },

                new FoodItem ()
                {
                    FoodItemId = 12,
                    FoodItemImg= "ma12.png",
                    FoodItemName="Pizza Sô-Cô-La/ Choco Pizza",
                    FoodItemRestaurentId=3,
                    FoodItemCategory=2,
                    FoodItemPrice=89
                },

                new FoodItem ()
                {
                    FoodItemId = 13,
                    FoodItemImg= "ma13.png",
                    FoodItemName="Soup bí đỏ",
                    FoodItemRestaurentId=4,
                    FoodItemCategory=3,
                    FoodItemPrice=80
                },

                new FoodItem ()
                {
                    FoodItemId = 14,
                    FoodItemImg= "ma14.png",
                    FoodItemName="1 Miếng Gà Giòn Vui Vẻ",
                    FoodItemRestaurentId=4,
                    FoodItemCategory=4,
                    FoodItemPrice= 39
                },

                new FoodItem ()
                {
                    FoodItemId = 15,
                    FoodItemImg= "ma15.png",
                    FoodItemName="2 Miếng Gà Giòn Vui Vẻ + 1 Bánh xoài đào1 Nước ngọt lớn",
                    FoodItemRestaurentId=4,
                    FoodItemCategory=6,
                    FoodItemPrice=145
                },
                  new FoodItem ()
                {
                    FoodItemId = 16,
                    FoodItemImg= "ma16.png",
                    FoodItemName="Trà Đào lớn",
                    FoodItemRestaurentId=4,
                    FoodItemCategory=7,
                    FoodItemPrice= 45
                },
            };
        }

        public async Task AddFoodItemAsync ()
        {
            try
            {
                foreach (var Item in Foods)
                    await client.Child ("FoodItem").PostAsync (new FoodItem ()
                    {
                        FoodItemId = Item.FoodItemId,
                        FoodItemImg = Item.FoodItemImg,
                        FoodItemName = Item.FoodItemName,
                        FoodItemRestaurentId = Item.FoodItemRestaurentId,
                        FoodItemCategory = Item.FoodItemCategory,
                        FoodItemPrice = Item.FoodItemPrice
                    });
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert ("Error", ex.Message, "OK");
            }
        }
    }
}