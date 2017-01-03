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
	public static partial class T_DistrictService
	{
        public static T_District AddT_District(T_District t_District)
		{
            string sql =
				"INSERT T_District (district_id, district_level, parent_district)" +
				"VALUES (@district_id, @district_level, @parent_district)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@district_id", DBHelper.GetValueByWhetherNull(t_District.district_id)),
					new SqlParameter("@district_level", DBHelper.GetValueByWhetherNull(t_District.district_level)),
					new SqlParameter("@parent_district", DBHelper.GetValueByWhetherNull(t_District.parent_district))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetT_DistrictByDistrict_name(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteT_District(T_District t_District)
		{
			DeleteT_DistrictByDistrict_name( t_District.District_name );
		}

        public static void DeleteT_DistrictByDistrict_name(string district_name)
		{
            string sql = "DELETE T_District WHERE District_name = @District_name";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@district_name", district_name)
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
	                "district_id = @district_id, " +
	                "district_level = @district_level, " +
	                "parent_district = @parent_district " +
                "WHERE district_name = @district_name";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@district_name", t_District.district_name),
					new SqlParameter("@district_id", DBHelper.GetValueByWhetherNull(t_District.district_id)),
					new SqlParameter("@district_level", DBHelper.GetValueByWhetherNull(t_District.district_level)),
					new SqlParameter("@parent_district", DBHelper.GetValueByWhetherNull(t_District.parent_district))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<T_District> GetAllT_Districts()
        {
            string sqlAll = "SELECT * FROM T_District";
			return GetT_DistrictsBySql( sqlAll );
        }
		
        public static T_District GetT_DistrictByDistrict_name(string district_name)
        {
            string sql = "SELECT * FROM T_District WHERE District_name = @District_name";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@District_name", district_name));
                if (reader.Read())
                {
					
                    T_District t_District = new T_District();

					try{
					t_District.District_id = (int)reader["district_id"];
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
		
		
		
		
        private static IList<T_District> GetT_DistrictsBySql( string safeSql )
        {
            List<T_District> list = new List<T_District>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					T_District t_District = new T_District();
					
					try{
					t_District.District_id = (int)row["district_id"];
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
		
        private static IList<T_District> GetT_DistrictsBySql( string sql, params SqlParameter[] values )
        {
            List<T_District> list = new List<T_District>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					T_District t_District = new T_District();
					
					try{
					t_District.District_id = (int)row["district_id"];
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