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
	public static partial class T_RoleService
	{
        public static T_Role AddT_Role(T_Role t_Role)
		{
            string sql =
				"INSERT T_Role (role_name, role_pris)" +
				"VALUES (@role_name, @role_pris)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@role_name", DBHelper.GetValueByWhetherNull(t_Role.Role_name)),
					new SqlParameter("@role_pris", DBHelper.GetValueByWhetherNull(t_Role.Role_pris))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetT_RoleById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteT_Role(T_Role t_Role)
		{
			DeleteT_RoleById( t_Role.Id );
		}

        public static void DeleteT_RoleById(int id)
		{
            string sql = "DELETE T_Role WHERE Id = @Id";

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
						
        public static void ModifyT_Role(T_Role t_Role)
        {
            string sql =
                "UPDATE T_Role " +
                "SET " +
	                "role_name = @role_name, " +
	                "role_pris = @role_pris " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", t_Role.Id),
					new SqlParameter("@role_name", DBHelper.GetValueByWhetherNull(t_Role.Role_name)),
					new SqlParameter("@role_pris", DBHelper.GetValueByWhetherNull(t_Role.Role_pris))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static List<T_Role> GetAllT_Roles()
        {
            string sqlAll = "SELECT * FROM T_Role";
			return GetT_RolesBySql( sqlAll );
        }
        
        public static List<T_Role> GetAllT_RoleBySQLstring(string sqlstring)
        {
			return GetT_RolesBySql( sqlstring );
        }
        
		
        public static T_Role GetT_RoleById(int id)
        {
            string sql = "SELECT * FROM T_Role WHERE Id = @Id";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    T_Role t_Role = new T_Role();

					try{
					t_Role.Id = (int)reader["Id"];
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
		
		
		
		
        private static List<T_Role> GetT_RolesBySql( string safeSql )
        {
            List<T_Role> list = new List<T_Role>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					T_Role t_Role = new T_Role();
					
					try{
					t_Role.Id = (int)row["Id"];
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
		
        private static List<T_Role> GetT_RolesBySql( string sql, params SqlParameter[] values )
        {
            List<T_Role> list = new List<T_Role>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					T_Role t_Role = new T_Role();
					
					try{
					t_Role.Id = (int)row["Id"];
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