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
	public static partial class T_DistrictService
	{
        public static T_District AddT_District(T_District t_District)
		{
            string sql =
				"INSERT T_District (district_name, district_level, parent_district)" +
				"VALUES (@district_name, @district_level, @parent_district)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@district_name", DBHelper.GetValueByWhetherNull(t_District.District_name)),
					new SqlParameter("@district_level", DBHelper.GetValueByWhetherNull(t_District.District_level)),
					new SqlParameter("@parent_district", DBHelper.GetValueByWhetherNull(t_District.Parent_district))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetT_DistrictById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteT_District(T_District t_District)
		{
			DeleteT_DistrictById( t_District.Id );
		}

        public static void DeleteT_DistrictById(int id)
		{
            string sql = "DELETE T_District WHERE Id = @Id";

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
						
        public static void ModifyT_District(T_District t_District)
        {
            string sql =
                "UPDATE T_District " +
                "SET " +
	                "district_name = @district_name, " +
	                "district_level = @district_level, " +
	                "parent_district = @parent_district " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", t_District.Id),
					new SqlParameter("@district_name", DBHelper.GetValueByWhetherNull(t_District.District_name)),
					new SqlParameter("@district_level", DBHelper.GetValueByWhetherNull(t_District.District_level)),
					new SqlParameter("@parent_district", DBHelper.GetValueByWhetherNull(t_District.Parent_district))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static List<T_District> GetAllT_Districts()
        {
            string sqlAll = "SELECT * FROM T_District";
			return GetT_DistrictsBySql( sqlAll );
        }
        
        public static List<T_District> GetAllT_DistrictBySQLstring(string sqlstring)
        {
			return GetT_DistrictsBySql( sqlstring );
        }
        
		
        public static T_District GetT_DistrictById(int id)
        {
            string sql = "SELECT * FROM T_District WHERE Id = @Id";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    T_District t_District = new T_District();

					try{
					t_District.Id = (int)reader["Id"];
					}catch
					{}
					try{
					t_District.District_name = (string)reader["district_name"];
					}catch
					{}
					try{
					t_District.District_level = (int)reader["district_level"];
					}catch
					{}
					try{
					t_District.Parent_district = (int)reader["parent_district"];
					}catch
					{}

                    reader.Close();
					
                    return t_District;
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
		
		
		
		
        private static List<T_District> GetT_DistrictsBySql( string safeSql )
        {
            List<T_District> list = new List<T_District>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					T_District t_District = new T_District();
					
					try{
					t_District.Id = (int)row["Id"];
					}catch
					{}
					try{
					t_District.District_name = (string)row["district_name"];
					}catch
					{}
					try{
					t_District.District_level = (int)row["district_level"];
					}catch
					{}
					try{
					t_District.Parent_district = (int)row["parent_district"];
					}catch
					{}
	
					list.Add(t_District);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static List<T_District> GetT_DistrictsBySql( string sql, params SqlParameter[] values )
        {
            List<T_District> list = new List<T_District>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					T_District t_District = new T_District();
					
					try{
					t_District.Id = (int)row["Id"];
					}catch
					{}
					try{
					t_District.District_name = (string)row["district_name"];
					}catch
					{}
					try{
					t_District.District_level = (int)row["district_level"];
					}catch
					{}
					try{
					t_District.Parent_district = (int)row["parent_district"];
					}catch
					{}
	
					list.Add(t_District);
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