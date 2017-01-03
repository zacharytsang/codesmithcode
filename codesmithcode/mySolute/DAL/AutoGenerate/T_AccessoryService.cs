//============================================================
// Producnt name:		DAL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2016/12/20 14:30:26
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
				"INSERT T_Accessories (acc_category, acc_name, acc_url, status)" +
				"VALUES (@acc_category, @acc_name, @acc_url, @status)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@acc_category", DBHelper.GetValueByWhetherNull(t_Accessory.Acc_category)),
					new SqlParameter("@acc_name", DBHelper.GetValueByWhetherNull(t_Accessory.Acc_name)),
					new SqlParameter("@acc_url", DBHelper.GetValueByWhetherNull(t_Accessory.Acc_url)),
					new SqlParameter("@status", DBHelper.GetValueByWhetherNull(t_Accessory.Status))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetT_AccessoryById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteT_Accessory(T_Accessory t_Accessory)
		{
			DeleteT_AccessoryById( t_Accessory.Id );
		}

        public static void DeleteT_AccessoryById(int id)
		{
            string sql = "DELETE T_Accessories WHERE Id = @Id";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", id)
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
	                "acc_category = @acc_category, " +
	                "acc_name = @acc_name, " +
	                "acc_url = @acc_url, " +
	                "status = @status " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", t_Accessory.Id),
					new SqlParameter("@acc_category", DBHelper.GetValueByWhetherNull(t_Accessory.Acc_category)),
					new SqlParameter("@acc_name", DBHelper.GetValueByWhetherNull(t_Accessory.Acc_name)),
					new SqlParameter("@acc_url", DBHelper.GetValueByWhetherNull(t_Accessory.Acc_url)),
					new SqlParameter("@status", DBHelper.GetValueByWhetherNull(t_Accessory.Status))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static List<T_Accessory> GetAllT_Accessories()
        {
            string sqlAll = "SELECT * FROM T_Accessories";
			return GetT_AccessoriesBySql( sqlAll );
        }
        
        public static List<T_Accessory> GetAllT_AccessoryBySQLstring(string sqlstring)
        {
			return GetT_AccessoriesBySql( sqlstring );
        }
        
		
        public static T_Accessory GetT_AccessoryById(int id)
        {
            string sql = "SELECT * FROM T_Accessories WHERE Id = @Id";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    T_Accessory t_Accessory = new T_Accessory();

					try{
					t_Accessory.Id = (int)reader["Id"];
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
		
		
		
		
        private static List<T_Accessory> GetT_AccessoriesBySql( string safeSql )
        {
            List<T_Accessory> list = new List<T_Accessory>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					T_Accessory t_Accessory = new T_Accessory();
					
					try{
					t_Accessory.Id = (int)row["Id"];
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
		
        private static List<T_Accessory> GetT_AccessoriesBySql( string sql, params SqlParameter[] values )
        {
            List<T_Accessory> list = new List<T_Accessory>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					T_Accessory t_Accessory = new T_Accessory();
					
					try{
					t_Accessory.Id = (int)row["Id"];
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