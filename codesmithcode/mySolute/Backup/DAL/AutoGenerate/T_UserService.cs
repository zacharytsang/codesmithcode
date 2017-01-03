//============================================================
// Producnt name:		DAL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2016/12/19 16:30:06
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using Models;

namespace DAL
{
	public static partial class T_UserService
	{
        public static T_User AddT_User(T_User t_User)
		{
            string sql =
				"INSERT T_User (user_id, password, role_id, status, create_date)" +
				"VALUES (@user_id, @password, @role_id, @status, @create_date)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@user_id", DBHelper.GetValueByWhetherNull(t_User.user_id)),
					new SqlParameter("@password", DBHelper.GetValueByWhetherNull(t_User.password)),
					new SqlParameter("@role_id", DBHelper.GetValueByWhetherNull(t_User.role_id)),
					new SqlParameter("@status", DBHelper.GetValueByWhetherNull(t_User.status)),
					new SqlParameter("@create_date", DBHelper.GetValueByWhetherNull(t_User.create_date))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetT_UserByUsername(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteT_User(T_User t_User)
		{
			DeleteT_UserByUsername( t_User.Username );
		}

        public static void DeleteT_UserByUsername(string username)
		{
            string sql = "DELETE T_User WHERE Username = @Username";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@username", username)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void ModifyT_User(T_User t_User)
        {
            string sql =
                "UPDATE T_User " +
                "SET " +
	                "user_id = @user_id, " +
	                "password = @password, " +
	                "role_id = @role_id, " +
	                "status = @status, " +
	                "create_date = @create_date " +
                "WHERE username = @username";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@username", t_User.username),
					new SqlParameter("@user_id", DBHelper.GetValueByWhetherNull(t_User.user_id)),
					new SqlParameter("@password", DBHelper.GetValueByWhetherNull(t_User.password)),
					new SqlParameter("@role_id", DBHelper.GetValueByWhetherNull(t_User.role_id)),
					new SqlParameter("@status", DBHelper.GetValueByWhetherNull(t_User.status)),
					new SqlParameter("@create_date", DBHelper.GetValueByWhetherNull(t_User.create_date))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<T_User> GetAllT_Users()
        {
            string sqlAll = "SELECT * FROM T_User";
			return GetT_UsersBySql( sqlAll );
        }
		
        public static T_User GetT_UserByUsername(string username)
        {
            string sql = "SELECT * FROM T_User WHERE Username = @Username";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Username", username));
                if (reader.Read())
                {
					
                    T_User t_User = new T_User();

					try{
					t_User.User_id = (int)reader["user_id"];
					}catch
					{}
					try{
					t_User.Username = (string)reader["username"];
					}catch
					{}
					try{
					t_User.Password = (string)reader["password"];
					}catch
					{}
					try{
					t_User.Role_id = (int)reader["role_id"];
					}catch
					{}
					try{
					t_User.Status = (bool)reader["status"];
					}catch
					{}
					try{
					t_User.Create_date = (DateTime)reader["create_date"];
					}catch
					{}

                    reader.Close();
					
                    return t_User;
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
		
		
		
		
        private static IList<T_User> GetT_UsersBySql( string safeSql )
        {
            List<T_User> list = new List<T_User>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					T_User t_User = new T_User();
					
					try{
					t_User.User_id = (int)row["user_id"];
					}catch
					{}
					try{
					t_User.Username = (string)row["username"];
					}catch
					{}
					try{
					t_User.Password = (string)row["password"];
					}catch
					{}
					try{
					t_User.Role_id = (int)row["role_id"];
					}catch
					{}
					try{
					t_User.Status = (bool)row["status"];
					}catch
					{}
					try{
					t_User.Create_date = (DateTime)row["create_date"];
					}catch
					{}
	
					list.Add(t_User);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static IList<T_User> GetT_UsersBySql( string sql, params SqlParameter[] values )
        {
            List<T_User> list = new List<T_User>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					T_User t_User = new T_User();
					
					try{
					t_User.User_id = (int)row["user_id"];
					}catch
					{}
					try{
					t_User.Username = (string)row["username"];
					}catch
					{}
					try{
					t_User.Password = (string)row["password"];
					}catch
					{}
					try{
					t_User.Role_id = (int)row["role_id"];
					}catch
					{}
					try{
					t_User.Status = (bool)row["status"];
					}catch
					{}
					try{
					t_User.Create_date = (DateTime)row["create_date"];
					}catch
					{}
	
					list.Add(t_User);
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