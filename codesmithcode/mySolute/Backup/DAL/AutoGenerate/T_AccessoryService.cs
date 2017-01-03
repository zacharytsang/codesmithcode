//============================================================
// Producnt name:		DAL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2016/12/19 16:30:05
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using Models;

namespace DAL
{
	public static partial class T_AccessoryService
	{
        public static T_Accessory AddT_Accessory(T_Accessory t_Accessory)
		{
            string sql =
				"INSERT T_Accessories (id, acc_category, acc_name, status)" +
				"VALUES (@id, @acc_category, @acc_name, @status)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@id", DBHelper.GetValueByWhetherNull(t_Accessory.id)),
					new SqlParameter("@acc_category", DBHelper.GetValueByWhetherNull(t_Accessory.acc_category)),
					new SqlParameter("@acc_name", DBHelper.GetValueByWhetherNull(t_Accessory.acc_name)),
					new SqlParameter("@status", DBHelper.GetValueByWhetherNull(t_Accessory.status))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetT_AccessoryByAcc_url(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteT_Accessory(T_Accessory t_Accessory)
		{
			DeleteT_AccessoryByAcc_url( t_Accessory.Acc_url );
		}

        public static void DeleteT_AccessoryByAcc_url(string acc_url)
		{
            string sql = "DELETE T_Accessories WHERE Acc_url = @Acc_url";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@acc_url", acc_url)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void ModifyT_Accessory(T_Accessory t_Accessory)
        {
            string sql =
                "UPDATE T_Accessories " +
                "SET " +
	                "id = @id, " +
	                "acc_category = @acc_category, " +
	                "acc_name = @acc_name, " +
	                "status = @status " +
                "WHERE acc_url = @acc_url";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@acc_url", t_Accessory.acc_url),
					new SqlParameter("@id", DBHelper.GetValueByWhetherNull(t_Accessory.id)),
					new SqlParameter("@acc_category", DBHelper.GetValueByWhetherNull(t_Accessory.acc_category)),
					new SqlParameter("@acc_name", DBHelper.GetValueByWhetherNull(t_Accessory.acc_name)),
					new SqlParameter("@status", DBHelper.GetValueByWhetherNull(t_Accessory.status))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<T_Accessory> GetAllT_Accessories()
        {
            string sqlAll = "SELECT * FROM T_Accessories";
			return GetT_AccessoriesBySql( sqlAll );
        }
		
        public static T_Accessory GetT_AccessoryByAcc_url(string acc_url)
        {
            string sql = "SELECT * FROM T_Accessories WHERE Acc_url = @Acc_url";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Acc_url", acc_url));
                if (reader.Read())
                {
					
                    T_Accessory t_Accessory = new T_Accessory();

					try{
					t_Accessory.Id = (int)reader["id"];
					}catch
					{}
					try{
					t_Accessory.Acc_category = (string)reader["acc_category"];
					}catch
					{}
					try{
					t_Accessory.Acc_name = (string)reader["acc_name"];
					}catch
					{}
					try{
					t_Accessory.Acc_url = (string)reader["acc_url"];
					}catch
					{}
					try{
					t_Accessory.Status = (bool)reader["status"];
					}catch
					{}

                    reader.Close();
					
                    return t_Accessory;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
		
		
		
		
        private static IList<T_Accessory> GetT_AccessoriesBySql( string safeSql )
        {
            List<T_Accessory> list = new List<T_Accessory>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					T_Accessory t_Accessory = new T_Accessory();
					
					try{
					t_Accessory.Id = (int)row["id"];
					}catch
					{}
					try{
					t_Accessory.Acc_category = (string)row["acc_category"];
					}catch
					{}
					try{
					t_Accessory.Acc_name = (string)row["acc_name"];
					}catch
					{}
					try{
					t_Accessory.Acc_url = (string)row["acc_url"];
					}catch
					{}
					try{
					t_Accessory.Status = (bool)row["status"];
					}catch
					{}
	
					list.Add(t_Accessory);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static IList<T_Accessory> GetT_AccessoriesBySql( string sql, params SqlParameter[] values )
        {
            List<T_Accessory> list = new List<T_Accessory>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					T_Accessory t_Accessory = new T_Accessory();
					
					try{
					t_Accessory.Id = (int)row["id"];
					}catch
					{}
					try{
					t_Accessory.Acc_category = (string)row["acc_category"];
					}catch
					{}
					try{
					t_Accessory.Acc_name = (string)row["acc_name"];
					}catch
					{}
					try{
					t_Accessory.Acc_url = (string)row["acc_url"];
					}catch
					{}
					try{
					t_Accessory.Status = (bool)row["status"];
					}catch
					{}
	
					list.Add(t_Accessory);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
			
        }
		
	}
}