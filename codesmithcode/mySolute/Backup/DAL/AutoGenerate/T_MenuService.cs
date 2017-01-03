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
	public static partial class T_MenuService
	{
        public static T_Menu AddT_Menu(T_Menu t_Menu)
		{
            string sql =
				"INSERT T_Menu (menu_id, menu_name, status, parent_menu_id)" +
				"VALUES (@menu_id, @menu_name, @status, @parent_menu_id)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@menu_id", DBHelper.GetValueByWhetherNull(t_Menu.menu_id)),
					new SqlParameter("@menu_name", DBHelper.GetValueByWhetherNull(t_Menu.menu_name)),
					new SqlParameter("@status", DBHelper.GetValueByWhetherNull(t_Menu.status)),
					new SqlParameter("@parent_menu_id", DBHelper.GetValueByWhetherNull(t_Menu.parent_menu_id))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetT_MenuByMenu_url(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteT_Menu(T_Menu t_Menu)
		{
			DeleteT_MenuByMenu_url( t_Menu.Menu_url );
		}

        public static void DeleteT_MenuByMenu_url(string menu_url)
		{
            string sql = "DELETE T_Menu WHERE Menu_url = @Menu_url";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@menu_url", menu_url)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void ModifyT_Menu(T_Menu t_Menu)
        {
            string sql =
                "UPDATE T_Menu " +
                "SET " +
	                "menu_id = @menu_id, " +
	                "menu_name = @menu_name, " +
	                "status = @status, " +
	                "parent_menu_id = @parent_menu_id " +
                "WHERE menu_url = @menu_url";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@menu_url", t_Menu.menu_url),
					new SqlParameter("@menu_id", DBHelper.GetValueByWhetherNull(t_Menu.menu_id)),
					new SqlParameter("@menu_name", DBHelper.GetValueByWhetherNull(t_Menu.menu_name)),
					new SqlParameter("@status", DBHelper.GetValueByWhetherNull(t_Menu.status)),
					new SqlParameter("@parent_menu_id", DBHelper.GetValueByWhetherNull(t_Menu.parent_menu_id))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<T_Menu> GetAllT_Menus()
        {
            string sqlAll = "SELECT * FROM T_Menu";
			return GetT_MenusBySql( sqlAll );
        }
		
        public static T_Menu GetT_MenuByMenu_url(string menu_url)
        {
            string sql = "SELECT * FROM T_Menu WHERE Menu_url = @Menu_url";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Menu_url", menu_url));
                if (reader.Read())
                {
					
                    T_Menu t_Menu = new T_Menu();

					try{
					t_Menu.Menu_id = (int)reader["menu_id"];
					}catch
					{}
					try{
					t_Menu.Menu_name = (string)reader["menu_name"];
					}catch
					{}
					try{
					t_Menu.Menu_url = (string)reader["menu_url"];
					}catch
					{}
					try{
					t_Menu.Status = (bool)reader["status"];
					}catch
					{}
					try{
					t_Menu.Parent_menu_id = (int)reader["parent_menu_id"];
					}catch
					{}

                    reader.Close();
					
                    return t_Menu;
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
		
		
		
		
        private static IList<T_Menu> GetT_MenusBySql( string safeSql )
        {
            List<T_Menu> list = new List<T_Menu>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					T_Menu t_Menu = new T_Menu();
					
					try{
					t_Menu.Menu_id = (int)row["menu_id"];
					}catch
					{}
					try{
					t_Menu.Menu_name = (string)row["menu_name"];
					}catch
					{}
					try{
					t_Menu.Menu_url = (string)row["menu_url"];
					}catch
					{}
					try{
					t_Menu.Status = (bool)row["status"];
					}catch
					{}
					try{
					t_Menu.Parent_menu_id = (int)row["parent_menu_id"];
					}catch
					{}
	
					list.Add(t_Menu);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static IList<T_Menu> GetT_MenusBySql( string sql, params SqlParameter[] values )
        {
            List<T_Menu> list = new List<T_Menu>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					T_Menu t_Menu = new T_Menu();
					
					try{
					t_Menu.Menu_id = (int)row["menu_id"];
					}catch
					{}
					try{
					t_Menu.Menu_name = (string)row["menu_name"];
					}catch
					{}
					try{
					t_Menu.Menu_url = (string)row["menu_url"];
					}catch
					{}
					try{
					t_Menu.Status = (bool)row["status"];
					}catch
					{}
					try{
					t_Menu.Parent_menu_id = (int)row["parent_menu_id"];
					}catch
					{}
	
					list.Add(t_Menu);
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