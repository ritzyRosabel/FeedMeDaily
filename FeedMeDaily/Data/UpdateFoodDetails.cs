using Dapper;
using FeedMeDaily.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FeedMeDaily.Data
{
    public class UpdateFoodDetails
    {
        public static string Update(int platenum, string meal, DateTime date, int id)
        {
            var result = string.Empty;
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectToDb.Con("FeedMeDaily")))
                {
                    List<FoodModel> foods = new List<FoodModel>();
                    FoodModel foodModel = new FoodModel()
                    {
                        Date = date,
                        PlateNum = platenum,
                        Meal = meal
                    };
                    foods.Add(foodModel);
                    connection.Execute("spUpdatedb @id, @meal,@platenum,@date", foods);
                    return result = "successfulll";
                }
            }
            catch (Exception ex)
            {
                var Err = ex.Message;
                return result = "Failed";
            }
        }
    }
}