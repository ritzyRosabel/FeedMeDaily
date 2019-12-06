using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FeedMeDaily.Data
{
    public class DeleteFoodDetails
    {

        public static string Delete(int platenum, string meal, DateTime date, int id)
        {
            var result = string.Empty;
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectToDb.Con("FeedMeDaily")))
                {
                    connection.Execute("spDeletedb");
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