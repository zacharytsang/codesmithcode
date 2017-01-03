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
	public static partial class T_RoleService
	{
        public static T_Role AddT_Role(T_Role t_Role)
		{
            string sql =
				"INSERT T_Role (role_id, role_pris)" +
				"VALUES (@role_id, @role_pris)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@role_id", DBHelper.GetValueByWhetherNull(t_Role.role_id)),
					new SqlParameter("@role_pris", DBHelper.GetValueByWhetherNull(t_Role.role_pris))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetT_RoleByRole_name(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteT_Role(T_Role t_Role)
		{
			DeleteT_RoleByRole_name( t_Role.Role_name );
		}

        public static void DeleteT_RoleByRole_name(string role_name)
		{
            string sql = "DELETE T_Role WHERE Role_name = @Role_name";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@role_name", role_name)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void ModifyT_Role(T_Role t_Role)
        {
            string sql =
                "UPDATE T_Role " +
                "SET " +
	                "role_id = @role_id, " +
	                "role_pris = @role_pris " +
                "WHERE role_name = @role_name";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@role_name", t_Role.role_name),
					new SqlParameter("@role_id", DBHelper.GetValueByWhetherNull(t_Role.role_id)),
					new SqlParameter("@role_pris", DBHelper.GetValueByWhetherNull(t_Role.role_pris))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<T_Role> GetAllT_Roles()
        {
            string sqlAll = "SELECT * FROM T_Role";
			return GetT_RolesBySql( sqlAll );
        }
		
        public static T_Role GetT_RoleByRole_name(string role_name)
        {
            string sql = "SELECT * FROM T_Role WHERE Role_name = @Role_name";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Role_name", role_name));
                if (reader.Read())
                {
					
                    T_Role t_Role = new T_Role();

					try{
					t_Role.Role_id = (int)reader["role_id"];
					}catch
					{}
					try{
					t_Role.Role_name = (string)reader["role_name"];
					}catch
					{}
					try{
					t_Role.Role_pris = (bool)reader["role_pris"];
					}catch
					{}

                    reader.Close();
					
                    return t_Role;
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
		
		
		
		
        private static IList<T_Role> GetT_RolesBySql( string safeSql )
        {
            List<T_Role> list = new List<T_Role>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					T_Role t_Role = new T_Role();
					
					try{
					t_Role.Role_id = (int)row["role_id"];
					}catch
					{}
					try{
					t_Role.Role_name = (string)row["role_name"];
					}catch
					{}
					try{
					t_Role.Role_pris = (bool)row["role_pris"];
					}catch
					{}
	
					list.Add(t_Role);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static IList<T_Role> GetT_RolesBySql( string sql, params SqlParameter[] values )
        {
            List<T_Role> list = new List<T_Role>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					T_Role t_Role = new T_Role();
					
					try{
					t_Role.Role_id = (int)row["role_id"];
					}catch
					{}
					try{
					t_Role.Role_name = (string)row["role_name"];
					}catch
					{}
					try{
					t_Role.Role_pris = (bool)row["role_pris"];
					}catch
					{}
	
					list.Add(t_Role);
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