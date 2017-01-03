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
	public static partial class T_DepartmentService
	{
        public static T_Department AddT_Department(T_Department t_Department)
		{
            string sql =
				"INSERT T_Department (depart_id, depart_addr, depart_status)" +
				"VALUES (@depart_id, @depart_addr, @depart_status)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@depart_id", DBHelper.GetValueByWhetherNull(t_Department.depart_id)),
					new SqlParameter("@depart_addr", DBHelper.GetValueByWhetherNull(t_Department.depart_addr)),
					new SqlParameter("@depart_status", DBHelper.GetValueByWhetherNull(t_Department.depart_status))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetT_DepartmentByDepart_name(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteT_Department(T_Department t_Department)
		{
			DeleteT_DepartmentByDepart_name( t_Department.Depart_name );
		}

        public static void DeleteT_DepartmentByDepart_name(string depart_name)
		{
            string sql = "DELETE T_Department WHERE Depart_name = @Depart_name";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@depart_name", depart_name)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void ModifyT_Department(T_Department t_Department)
        {
            string sql =
                "UPDATE T_Department " +
                "SET " +
	                "depart_id = @depart_id, " +
	                "depart_addr = @depart_addr, " +
	                "depart_status = @depart_status " +
                "WHERE depart_name = @depart_name";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@depart_name", t_Department.depart_name),
					new SqlParameter("@depart_id", DBHelper.GetValueByWhetherNull(t_Department.depart_id)),
					new SqlParameter("@depart_addr", DBHelper.GetValueByWhetherNull(t_Department.depart_addr)),
					new SqlParameter("@depart_status", DBHelper.GetValueByWhetherNull(t_Department.depart_status))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<T_Department> GetAllT_Departments()
        {
            string sqlAll = "SELECT * FROM T_Department";
			return GetT_DepartmentsBySql( sqlAll );
        }
		
        public static T_Department GetT_DepartmentByDepart_name(string depart_name)
        {
            string sql = "SELECT * FROM T_Department WHERE Depart_name = @Depart_name";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Depart_name", depart_name));
                if (reader.Read())
                {
					
                    T_Department t_Department = new T_Department();

					try{
					t_Department.Depart_id = (int)reader["depart_id"];
					}catch
					{}
					try{
					t_Department.Depart_name = (string)reader["depart_name"];
					}catch
					{}
					try{
					t_Department.Depart_addr = (string)reader["depart_addr"];
					}catch
					{}
					try{
					t_Department.Depart_status = (bool)reader["depart_status"];
					}catch
					{}

                    reader.Close();
					
                    return t_Department;
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
		
		
		
		
        private static IList<T_Department> GetT_DepartmentsBySql( string safeSql )
        {
            List<T_Department> list = new List<T_Department>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					T_Department t_Department = new T_Department();
					
					try{
					t_Department.Depart_id = (int)row["depart_id"];
					}catch
					{}
					try{
					t_Department.Depart_name = (string)row["depart_name"];
					}catch
					{}
					try{
					t_Department.Depart_addr = (string)row["depart_addr"];
					}catch
					{}
					try{
					t_Department.Depart_status = (bool)row["depart_status"];
					}catch
					{}
	
					list.Add(t_Department);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static IList<T_Department> GetT_DepartmentsBySql( string sql, params SqlParameter[] values )
        {
            List<T_Department> list = new List<T_Department>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					T_Department t_Department = new T_Department();
					
					try{
					t_Department.Depart_id = (int)row["depart_id"];
					}catch
					{}
					try{
					t_Department.Depart_name = (string)row["depart_name"];
					}catch
					{}
					try{
					t_Department.Depart_addr = (string)row["depart_addr"];
					}catch
					{}
					try{
					t_Department.Depart_status = (bool)row["depart_status"];
					}catch
					{}
	
					list.Add(t_Department);
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