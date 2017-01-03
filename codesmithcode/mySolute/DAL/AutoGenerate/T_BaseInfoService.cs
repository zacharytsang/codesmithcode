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
	public static partial class T_BaseInfoService
	{
        public static T_BaseInfo AddT_BaseInfo(T_BaseInfo t_BaseInfo)
		{
            string sql =
				"INSERT T_BaseInfo (config_name, config_value, config_status)" +
				"VALUES (@config_name, @config_value, @config_status)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@config_name", DBHelper.GetValueByWhetherNull(t_BaseInfo.Config_name)),
					new SqlParameter("@config_value", DBHelper.GetValueByWhetherNull(t_BaseInfo.Config_value)),
					new SqlParameter("@config_status", DBHelper.GetValueByWhetherNull(t_BaseInfo.Config_status))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetT_BaseInfoById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteT_BaseInfo(T_BaseInfo t_BaseInfo)
		{
			DeleteT_BaseInfoById( t_BaseInfo.Id );
		}

        public static void DeleteT_BaseInfoById(int id)
		{
            string sql = "DELETE T_BaseInfo WHERE Id = @Id";

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
						
        public static void ModifyT_BaseInfo(T_BaseInfo t_BaseInfo)
        {
            string sql =
                "UPDATE T_BaseInfo " +
                "SET " +
	                "config_name = @config_name, " +
	                "config_value = @config_value, " +
	                "config_status = @config_status " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", t_BaseInfo.Id),
					new SqlParameter("@config_name", DBHelper.GetValueByWhetherNull(t_BaseInfo.Config_name)),
					new SqlParameter("@config_value", DBHelper.GetValueByWhetherNull(t_BaseInfo.Config_value)),
					new SqlParameter("@config_status", DBHelper.GetValueByWhetherNull(t_BaseInfo.Config_status))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static List<T_BaseInfo> GetAllT_BaseInfos()
        {
            string sqlAll = "SELECT * FROM T_BaseInfo";
			return GetT_BaseInfosBySql( sqlAll );
        }
        
        public static List<T_BaseInfo> GetAllT_BaseInfoBySQLstring(string sqlstring)
        {
			return GetT_BaseInfosBySql( sqlstring );
        }
        
		
        public static T_BaseInfo GetT_BaseInfoById(int id)
        {
            string sql = "SELECT * FROM T_BaseInfo WHERE Id = @Id";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    T_BaseInfo t_BaseInfo = new T_BaseInfo();

					try{
					t_BaseInfo.Id = (int)reader["Id"];
					}catch
					{}
					try{
					t_BaseInfo.Config_name = (string)reader["config_name"];
					}catch
					{}
					try{
					t_BaseInfo.Config_value = (string)reader["config_value"];
					}catch
					{}
					try{
					t_BaseInfo.Config_status = (bool)reader["config_status"];
					}catch
					{}

                    reader.Close();
					
                    return t_BaseInfo;
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
		
		
		
		
        private static List<T_BaseInfo> GetT_BaseInfosBySql( string safeSql )
        {
            List<T_BaseInfo> list = new List<T_BaseInfo>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					T_BaseInfo t_BaseInfo = new T_BaseInfo();
					
					try{
					t_BaseInfo.Id = (int)row["Id"];
					}catch
					{}
					try{
					t_BaseInfo.Config_name = (string)row["config_name"];
					}catch
					{}
					try{
					t_BaseInfo.Config_value = (string)row["config_value"];
					}catch
					{}
					try{
					t_BaseInfo.Config_status = (bool)row["config_status"];
					}catch
					{}
	
					list.Add(t_BaseInfo);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static List<T_BaseInfo> GetT_BaseInfosBySql( string sql, params SqlParameter[] values )
        {
            List<T_BaseInfo> list = new List<T_BaseInfo>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					T_BaseInfo t_BaseInfo = new T_BaseInfo();
					
					try{
					t_BaseInfo.Id = (int)row["Id"];
					}catch
					{}
					try{
					t_BaseInfo.Config_name = (string)row["config_name"];
					}catch
					{}
					try{
					t_BaseInfo.Config_value = (string)row["config_value"];
					}catch
					{}
					try{
					t_BaseInfo.Config_status = (bool)row["config_status"];
					}catch
					{}
	
					list.Add(t_BaseInfo);
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