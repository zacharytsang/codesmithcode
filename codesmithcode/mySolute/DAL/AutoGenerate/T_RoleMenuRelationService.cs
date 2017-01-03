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
	public static partial class T_RoleMenuRelationService
	{
        public static T_RoleMenuRelation AddT_RoleMenuRelation(T_RoleMenuRelation t_RoleMenuRelation)
		{
            string sql =
				"INSERT T_RoleMenuRelations (role_id, menu_id)" +
				"VALUES (@role_id, @menu_id)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@role_id", DBHelper.GetValueByWhetherNull(t_RoleMenuRelation.Role_id)),
					new SqlParameter("@menu_id", DBHelper.GetValueByWhetherNull(t_RoleMenuRelation.Menu_id))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetT_RoleMenuRelationById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteT_RoleMenuRelation(T_RoleMenuRelation t_RoleMenuRelation)
		{
			DeleteT_RoleMenuRelationById( t_RoleMenuRelation.Id );
		}

        public static void DeleteT_RoleMenuRelationById(int id)
		{
            string sql = "DELETE T_RoleMenuRelations WHERE Id = @Id";

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
						
        public static void ModifyT_RoleMenuRelation(T_RoleMenuRelation t_RoleMenuRelation)
        {
            string sql =
                "UPDATE T_RoleMenuRelations " +
                "SET " +
	                "role_id = @role_id, " +
	                "menu_id = @menu_id " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", t_RoleMenuRelation.Id),
					new SqlParameter("@role_id", DBHelper.GetValueByWhetherNull(t_RoleMenuRelation.Role_id)),
					new SqlParameter("@menu_id", DBHelper.GetValueByWhetherNull(t_RoleMenuRelation.Menu_id))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static List<T_RoleMenuRelation> GetAllT_RoleMenuRelations()
        {
            string sqlAll = "SELECT * FROM T_RoleMenuRelations";
			return GetT_RoleMenuRelationsBySql( sqlAll );
        }
        
        public static List<T_RoleMenuRelation> GetAllT_RoleMenuRelationBySQLstring(string sqlstring)
        {
			return GetT_RoleMenuRelationsBySql( sqlstring );
        }
        
		
        public static T_RoleMenuRelation GetT_RoleMenuRelationById(int id)
        {
            string sql = "SELECT * FROM T_RoleMenuRelations WHERE Id = @Id";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    T_RoleMenuRelation t_RoleMenuRelation = new T_RoleMenuRelation();

					try{
					t_RoleMenuRelation.Id = (int)reader["Id"];
					}catch
					{}
					try{
					t_RoleMenuRelation.Role_id = (int)reader["role_id"];
					}catch
					{}
					try{
					t_RoleMenuRelation.Menu_id = (int)reader["menu_id"];
					}catch
					{}

                    reader.Close();
					
                    return t_RoleMenuRelation;
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
		
		
		
		
        private static List<T_RoleMenuRelation> GetT_RoleMenuRelationsBySql( string safeSql )
        {
            List<T_RoleMenuRelation> list = new List<T_RoleMenuRelation>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					T_RoleMenuRelation t_RoleMenuRelation = new T_RoleMenuRelation();
					
					try{
					t_RoleMenuRelation.Id = (int)row["Id"];
					}catch
					{}
					try{
					t_RoleMenuRelation.Role_id = (int)row["role_id"];
					}catch
					{}
					try{
					t_RoleMenuRelation.Menu_id = (int)row["menu_id"];
					}catch
					{}
	
					list.Add(t_RoleMenuRelation);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static List<T_RoleMenuRelation> GetT_RoleMenuRelationsBySql( string sql, params SqlParameter[] values )
        {
            List<T_RoleMenuRelation> list = new List<T_RoleMenuRelation>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					T_RoleMenuRelation t_RoleMenuRelation = new T_RoleMenuRelation();
					
					try{
					t_RoleMenuRelation.Id = (int)row["Id"];
					}catch
					{}
					try{
					t_RoleMenuRelation.Role_id = (int)row["role_id"];
					}catch
					{}
					try{
					t_RoleMenuRelation.Menu_id = (int)row["menu_id"];
					}catch
					{}
	
					list.Add(t_RoleMenuRelation);
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