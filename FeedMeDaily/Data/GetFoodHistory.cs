using Dapper;
using FeedMeDaily.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FeedMeDaily.Data
{
    public class GetFoodHistory
    {
        public static List<FoodModel> FoodHistory()
        {
            var result = new List<FoodModel>();
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectToDb.Con("FeedMeDaily")))
                {

                    result = connection.Query<FoodModel>("spGetData").ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                var Err = ex.Message;
                return  result;
            }
        }
        public static string GetFoodHistoryByID(int id)
        {
            try
            {
                var result = string.Empty;
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectToDb.Con("FeedMeDaily")))
                {
                    FoodModel food = new FoodModel();
                    result = connection.Query<FoodModel>("spGetDataid @id").ToString();
                    return result;
                }
            }
            catch (Exception ex)
            {
                var Err = ex.Message;
                return Err;
            }
        }
    }
}