using fatmee.Models;
using System.Collections.Generic;
using Firebase.Database;
using System.Threading.Tasks;
using Firebase.Database.Query;
using System;
using Xamarin.Forms;

namespace fatmee.ViewModels
{
    internal class AddCategoryData
    {
        public List<category> Categories { get; set; }
        public FirebaseClient client;

        public AddCategoryData ()
        {
            client = new FirebaseClient ("https://fatme-d8735-default-rtdb.firebaseio.com/");
            Categories = new List<category> ()
            {
                  new category ()
                {
                    CategoryId =1,
                    CatagoryName= "Ăn vặt",
                    CatagoryImg ="anvat.png"
                },
                  new category ()
                {
                    CategoryId =2,
                    CatagoryName= "Ăn nhanh",
                    CatagoryImg ="annhanh.png"
                },
                  new category ()
                {
                    CategoryId =3,
                    CatagoryName= "Cơm",
                    CatagoryImg ="com.png"
                },
                  new category ()
                {
                    CategoryId =3,
                    CatagoryName= "Healthy",
                    CatagoryImg ="healthy.png"
                },
                  new category ()
                {
                    CategoryId =4,
                    CatagoryName= "Tráng miệng",
                    CatagoryImg ="trangmieng.png"
                },
                  new category ()
                {
                    CategoryId =5,
                    CatagoryName= "Ăn kiêng",
                    CatagoryImg ="anvat.png"
                },
                  new category ()
                {
                    CategoryId =6,
                    CatagoryName= "Ăn kiêng",
                    CatagoryImg ="ankieng.png"
                },
                  new category ()
                {
                    CategoryId =7,
                    CatagoryName= "Trà sữa",
                    CatagoryImg ="trasua.png"
                }
            };
        }

        public async Task AddCategoriesAsync ()
        {
            try
            {
                foreach (var Item in Categories)
                    await client.Child ("categort").PostAsync (new category ()
                    {
                        CategoryId = Item.CategoryId,
                        CatagoryName = Item.CatagoryName,
                        CatagoryImg = Item.CatagoryImg
                    });
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert ("Error", ex.Message, "OK");
            }
        }
    }
}