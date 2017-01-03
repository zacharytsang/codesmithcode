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
	public static partial class T_MenuService
	{
        public static T_Menu AddT_Menu(T_Menu t_Menu)
		{
            string sql =
				"INSERT T_Menu (menu_name, menu_url, status, parent_menu_id)" +
				"VALUES (@menu_name, @menu_url, @status, @parent_menu_id)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@menu_name", DBHelper.GetValueByWhetherNull(t_Menu.Menu_name)),
					new SqlParameter("@menu_url", DBHelper.GetValueByWhetherNull(t_Menu.Menu_url)),
					new SqlParameter("@status", DBHelper.GetValueByWhetherNull(t_Menu.Status)),
					new SqlParameter("@parent_menu_id", DBHelper.GetValueByWhetherNull(t_Menu.Parent_menu_id))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetT_MenuById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteT_Menu(T_Menu t_Menu)
		{
			DeleteT_MenuById( t_Menu.Id );
		}

        public static void DeleteT_MenuById(int id)
		{
            string sql = "DELETE T_Menu WHERE Id = @Id";

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
						
        public static void ModifyT_Menu(T_Menu t_Menu)
        {
            string sql =
                "UPDATE T_Menu " +
                "SET " +
	                "menu_name = @menu_name, " +
	                "menu_url = @menu_url, " +
	                "status = @status, " +
	                "parent_menu_id = @parent_menu_id " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", t_Menu.Id),
					new SqlParameter("@menu_name", DBHelper.GetValueByWhetherNull(t_Menu.Menu_name)),
					new SqlParameter("@menu_url", DBHelper.GetValueByWhetherNull(t_Menu.Menu_url)),
					new SqlParameter("@status", DBHelper.GetValueByWhetherNull(t_Menu.Status)),
					new SqlParameter("@parent_menu_id", DBHelper.GetValueByWhetherNull(t_Menu.Parent_menu_id))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static List<T_Menu> GetAllT_Menus()
        {
            string sqlAll = "SELECT * FROM T_Menu";
			return GetT_MenusBySql( sqlAll );
        }
        
        public static List<T_Menu> GetAllT_MenuBySQLstring(string sqlstring)
        {
			return GetT_MenusBySql( sqlstring );
        }
        
		
        public static T_Menu GetT_MenuById(int id)
        {
            string sql = "SELECT * FROM T_Menu WHERE Id = @Id";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    T_Menu t_Menu = new T_Menu();

					try{
					t_Menu.Id = (int)reader["Id"];
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
		
		
		
		
        private static List<T_Menu> GetT_MenusBySql( string safeSql )
        {
            List<T_Menu> list = new List<T_Menu>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					T_Menu t_Menu = new T_Menu();
					
					try{
					t_Menu.Id = (int)row["Id"];
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
		
        private static List<T_Menu> GetT_MenusBySql( string sql, params SqlParameter[] values )
        {
            List<T_Menu> list = new List<T_Menu>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					T_Menu t_Menu = new T_Menu();
					
					try{
					t_Menu.Id = (int)row["Id"];
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