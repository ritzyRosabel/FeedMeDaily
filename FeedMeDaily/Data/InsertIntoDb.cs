using Dapper;
using FeedMeDaily.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FeedMeDaily.Data
{
    public class InsertIntoDb
    {
        public static string Insert(int platenum, string meal, DateTime date)
        {
        
            var result = string.Empty;
            //  DateTime date;
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectToDb.Con("FeedMeDaily")))
                {
                    //  food.Date = date;
                    FoodModel food = new FoodModel()
                    {
                        Date = date,
                        PlateNum = platenum,
                        Meal = meal
                    };
                    List<FoodModel> foods = new List<FoodModel>();
                    foods.Add(food);
                    connection.Execute("spinsertfood @meal, @platenum, @date", foods);

                }
                result = "success";
            }
            catch (Exception ex)
            {
                var err = ex.Message;
                result = "failed";
            
            }

            return result;

            }
        }

}
