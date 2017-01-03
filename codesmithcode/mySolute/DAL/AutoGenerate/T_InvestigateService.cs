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
	public static partial class T_InvestigateService
	{
        public static T_Investigate AddT_Investigate(T_Investigate t_Investigate)
		{
            string sql =
				"INSERT T_Investigates (building_id, building_code, building_name, building_owner, building_user, start_date, finish_date, design_corp, construct_corp, total_area, floors, struct_type, building_purpose, contacts, contact_numbers, problems, checkup_suggestions, rectifications, remarks, create_user, create_datetime, update_user, update_time, investigate_category)" +
				"VALUES (@building_id, @building_code, @building_name, @building_owner, @building_user, @start_date, @finish_date, @design_corp, @construct_corp, @total_area, @floors, @struct_type, @building_purpose, @contacts, @contact_numbers, @problems, @checkup_suggestions, @rectifications, @remarks, @create_user, @create_datetime, @update_user, @update_time, @investigate_category)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@building_id", DBHelper.GetValueByWhetherNull(t_Investigate.Building_id)),
					new SqlParameter("@building_code", DBHelper.GetValueByWhetherNull(t_Investigate.Building_code)),
					new SqlParameter("@building_name", DBHelper.GetValueByWhetherNull(t_Investigate.Building_name)),
					new SqlParameter("@building_owner", DBHelper.GetValueByWhetherNull(t_Investigate.Building_owner)),
					new SqlParameter("@building_user", DBHelper.GetValueByWhetherNull(t_Investigate.Building_user)),
					new SqlParameter("@start_date", DBHelper.GetValueByWhetherNull(t_Investigate.Start_date)),
					new SqlParameter("@finish_date", DBHelper.GetValueByWhetherNull(t_Investigate.Finish_date)),
					new SqlParameter("@design_corp", DBHelper.GetValueByWhetherNull(t_Investigate.Design_corp)),
					new SqlParameter("@construct_corp", DBHelper.GetValueByWhetherNull(t_Investigate.Construct_corp)),
					new SqlParameter("@total_area", DBHelper.GetValueByWhetherNull(t_Investigate.Total_area)),
					new SqlParameter("@floors", DBHelper.GetValueByWhetherNull(t_Investigate.Floors)),
					new SqlParameter("@struct_type", DBHelper.GetValueByWhetherNull(t_Investigate.Struct_type)),
					new SqlParameter("@building_purpose", DBHelper.GetValueByWhetherNull(t_Investigate.Building_purpose)),
					new SqlParameter("@contacts", DBHelper.GetValueByWhetherNull(t_Investigate.Contacts)),
					new SqlParameter("@contact_numbers", DBHelper.GetValueByWhetherNull(t_Investigate.Contact_numbers)),
					new SqlParameter("@problems", DBHelper.GetValueByWhetherNull(t_Investigate.Problems)),
					new SqlParameter("@checkup_suggestions", DBHelper.GetValueByWhetherNull(t_Investigate.Checkup_suggestions)),
					new SqlParameter("@rectifications", DBHelper.GetValueByWhetherNull(t_Investigate.Rectifications)),
					new SqlParameter("@remarks", DBHelper.GetValueByWhetherNull(t_Investigate.Remarks)),
					new SqlParameter("@create_user", DBHelper.GetValueByWhetherNull(t_Investigate.Create_user)),
					new SqlParameter("@create_datetime", DBHelper.GetValueByWhetherNull(t_Investigate.Create_datetime)),
					new SqlParameter("@update_user", DBHelper.GetValueByWhetherNull(t_Investigate.Update_user)),
					new SqlParameter("@update_time", DBHelper.GetValueByWhetherNull(t_Investigate.Update_time)),
					new SqlParameter("@investigate_category", DBHelper.GetValueByWhetherNull(t_Investigate.Investigate_category))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetT_InvestigateById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteT_Investigate(T_Investigate t_Investigate)
		{
			DeleteT_InvestigateById( t_Investigate.Id );
		}

        public static void DeleteT_InvestigateById(int id)
		{
            string sql = "DELETE T_Investigates WHERE Id = @Id";

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
						
        public static void ModifyT_Investigate(T_Investigate t_Investigate)
        {
            string sql =
                "UPDATE T_Investigates " +
                "SET " +
	                "building_id = @building_id, " +
	                "building_code = @building_code, " +
	                "building_name = @building_name, " +
	                "building_owner = @building_owner, " +
	                "building_user = @building_user, " +
	                "start_date = @start_date, " +
	                "finish_date = @finish_date, " +
	                "design_corp = @design_corp, " +
	                "construct_corp = @construct_corp, " +
	                "total_area = @total_area, " +
	                "floors = @floors, " +
	                "struct_type = @struct_type, " +
	                "building_purpose = @building_purpose, " +
	                "contacts = @contacts, " +
	                "contact_numbers = @contact_numbers, " +
	                "problems = @problems, " +
	                "checkup_suggestions = @checkup_suggestions, " +
	                "rectifications = @rectifications, " +
	                "remarks = @remarks, " +
	                "create_user = @create_user, " +
	                "create_datetime = @create_datetime, " +
	                "update_user = @update_user, " +
	                "update_time = @update_time, " +
	                "investigate_category = @investigate_category " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", t_Investigate.Id),
					new SqlParameter("@building_id", DBHelper.GetValueByWhetherNull(t_Investigate.Building_id)),
					new SqlParameter("@building_code", DBHelper.GetValueByWhetherNull(t_Investigate.Building_code)),
					new SqlParameter("@building_name", DBHelper.GetValueByWhetherNull(t_Investigate.Building_name)),
					new SqlParameter("@building_owner", DBHelper.GetValueByWhetherNull(t_Investigate.Building_owner)),
					new SqlParameter("@building_user", DBHelper.GetValueByWhetherNull(t_Investigate.Building_user)),
					new SqlParameter("@start_date", DBHelper.GetValueByWhetherNull(t_Investigate.Start_date)),
					new SqlParameter("@finish_date", DBHelper.GetValueByWhetherNull(t_Investigate.Finish_date)),
					new SqlParameter("@design_corp", DBHelper.GetValueByWhetherNull(t_Investigate.Design_corp)),
					new SqlParameter("@construct_corp", DBHelper.GetValueByWhetherNull(t_Investigate.Construct_corp)),
					new SqlParameter("@total_area", DBHelper.GetValueByWhetherNull(t_Investigate.Total_area)),
					new SqlParameter("@floors", DBHelper.GetValueByWhetherNull(t_Investigate.Floors)),
					new SqlParameter("@struct_type", DBHelper.GetValueByWhetherNull(t_Investigate.Struct_type)),
					new SqlParameter("@building_purpose", DBHelper.GetValueByWhetherNull(t_Investigate.Building_purpose)),
					new SqlParameter("@contacts", DBHelper.GetValueByWhetherNull(t_Investigate.Contacts)),
					new SqlParameter("@contact_numbers", DBHelper.GetValueByWhetherNull(t_Investigate.Contact_numbers)),
					new SqlParameter("@problems", DBHelper.GetValueByWhetherNull(t_Investigate.Problems)),
					new SqlParameter("@checkup_suggestions", DBHelper.GetValueByWhetherNull(t_Investigate.Checkup_suggestions)),
					new SqlParameter("@rectifications", DBHelper.GetValueByWhetherNull(t_Investigate.Rectifications)),
					new SqlParameter("@remarks", DBHelper.GetValueByWhetherNull(t_Investigate.Remarks)),
					new SqlParameter("@create_user", DBHelper.GetValueByWhetherNull(t_Investigate.Create_user)),
					new SqlParameter("@create_datetime", DBHelper.GetValueByWhetherNull(t_Investigate.Create_datetime)),
					new SqlParameter("@update_user", DBHelper.GetValueByWhetherNull(t_Investigate.Update_user)),
					new SqlParameter("@update_time", DBHelper.GetValueByWhetherNull(t_Investigate.Update_time)),
					new SqlParameter("@investigate_category", DBHelper.GetValueByWhetherNull(t_Investigate.Investigate_category))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static List<T_Investigate> GetAllT_Investigates()
        {
            string sqlAll = "SELECT * FROM T_Investigates";
			return GetT_InvestigatesBySql( sqlAll );
        }
        
        public static List<T_Investigate> GetAllT_InvestigateBySQLstring(string sqlstring)
        {
			return GetT_InvestigatesBySql( sqlstring );
        }
        
		
        public static T_Investigate GetT_InvestigateById(int id)
        {
            string sql = "SELECT * FROM T_Investigates WHERE Id = @Id";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    T_Investigate t_Investigate = new T_Investigate();

					try{
					t_Investigate.Id = (int)reader["Id"];
					}catch
					{}
					try{
					t_Investigate.Building_id = (string)reader["building_id"];
					}catch
					{}
					try{
					t_Investigate.Building_code = (string)reader["building_code"];
					}catch
					{}
					try{
					t_Investigate.Building_name = (string)reader["building_name"];
					}catch
					{}
					try{
					t_Investigate.Building_owner = (string)reader["building_owner"];
					}catch
					{}
					try{
					t_Investigate.Building_user = (string)reader["building_user"];
					}catch
					{}
					try{
					t_Investigate.Start_date = (DateTime)reader["start_date"];
					}catch
					{}
					try{
					t_Investigate.Finish_date = (DateTime)reader["finish_date"];
					}catch
					{}
					try{
					t_Investigate.Design_corp = (string)reader["design_corp"];
					}catch
					{}
					try{
					t_Investigate.Construct_corp = (string)reader["construct_corp"];
					}catch
					{}
					try{
					t_Investigate.Total_area = (int)reader["total_area"];
					}catch
					{}
					try{
					t_Investigate.Floors = (int)reader["floors"];
					}catch
					{}
					try{
					t_Investigate.Struct_type = (string)reader["struct_type"];
					}catch
					{}
					try{
					t_Investigate.Building_purpose = (string)reader["building_purpose"];
					}catch
					{}
					try{
					t_Investigate.Contacts = (string)reader["contacts"];
					}catch
					{}
					try{
					t_Investigate.Contact_numbers = (string)reader["contact_numbers"];
					}catch
					{}
					try{
					t_Investigate.Problems = (string)reader["problems"];
					}catch
					{}
					try{
					t_Investigate.Checkup_suggestions = (string)reader["checkup_suggestions"];
					}catch
					{}
					try{
					t_Investigate.Rectifications = (string)reader["rectifications"];
					}catch
					{}
					try{
					t_Investigate.Remarks = (string)reader["remarks"];
					}catch
					{}
					try{
					t_Investigate.Create_user = (string)reader["create_user"];
					}catch
					{}
					try{
					t_Investigate.Create_datetime = (DateTime)reader["create_datetime"];
					}catch
					{}
					try{
					t_Investigate.Update_user = (string)reader["update_user"];
					}catch
					{}
					try{
					t_Investigate.Update_time = (DateTime)reader["update_time"];
					}catch
					{}
					try{
					t_Investigate.Investigate_category = (string)reader["investigate_category"];
					}catch
					{}

                    reader.Close();
					
                    return t_Investigate;
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
		
		
		
		
        private static List<T_Investigate> GetT_InvestigatesBySql( string safeSql )
        {
            List<T_Investigate> list = new List<T_Investigate>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					T_Investigate t_Investigate = new T_Investigate();
					
					try{
					t_Investigate.Id = (int)row["Id"];
					}catch
					{}
					try{
					t_Investigate.Building_id = (string)row["building_id"];
					}catch
					{}
					try{
					t_Investigate.Building_code = (string)row["building_code"];
					}catch
					{}
					try{
					t_Investigate.Building_name = (string)row["building_name"];
					}catch
					{}
					try{
					t_Investigate.Building_owner = (string)row["building_owner"];
					}catch
					{}
					try{
					t_Investigate.Building_user = (string)row["building_user"];
					}catch
					{}
					try{
					t_Investigate.Start_date = (DateTime)row["start_date"];
					}catch
					{}
					try{
					t_Investigate.Finish_date = (DateTime)row["finish_date"];
					}catch
					{}
					try{
					t_Investigate.Design_corp = (string)row["design_corp"];
					}catch
					{}
					try{
					t_Investigate.Construct_corp = (string)row["construct_corp"];
					}catch
					{}
					try{
					t_Investigate.Total_area = (int)row["total_area"];
					}catch
					{}
					try{
					t_Investigate.Floors = (int)row["floors"];
					}catch
					{}
					try{
					t_Investigate.Struct_type = (string)row["struct_type"];
					}catch
					{}
					try{
					t_Investigate.Building_purpose = (string)row["building_purpose"];
					}catch
					{}
					try{
					t_Investigate.Contacts = (string)row["contacts"];
					}catch
					{}
					try{
					t_Investigate.Contact_numbers = (string)row["contact_numbers"];
					}catch
					{}
					try{
					t_Investigate.Problems = (string)row["problems"];
					}catch
					{}
					try{
					t_Investigate.Checkup_suggestions = (string)row["checkup_suggestions"];
					}catch
					{}
					try{
					t_Investigate.Rectifications = (string)row["rectifications"];
					}catch
					{}
					try{
					t_Investigate.Remarks = (string)row["remarks"];
					}catch
					{}
					try{
					t_Investigate.Create_user = (string)row["create_user"];
					}catch
					{}
					try{
					t_Investigate.Create_datetime = (DateTime)row["create_datetime"];
					}catch
					{}
					try{
					t_Investigate.Update_user = (string)row["update_user"];
					}catch
					{}
					try{
					t_Investigate.Update_time = (DateTime)row["update_time"];
					}catch
					{}
					try{
					t_Investigate.Investigate_category = (string)row["investigate_category"];
					}catch
					{}
	
					list.Add(t_Investigate);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static List<T_Investigate> GetT_InvestigatesBySql( string sql, params SqlParameter[] values )
        {
            List<T_Investigate> list = new List<T_Investigate>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					T_Investigate t_Investigate = new T_Investigate();
					
					try{
					t_Investigate.Id = (int)row["Id"];
					}catch
					{}
					try{
					t_Investigate.Building_id = (string)row["building_id"];
					}catch
					{}
					try{
					t_Investigate.Building_code = (string)row["building_code"];
					}catch
					{}
					try{
					t_Investigate.Building_name = (string)row["building_name"];
					}catch
					{}
					try{
					t_Investigate.Building_owner = (string)row["building_owner"];
					}catch
					{}
					try{
					t_Investigate.Building_user = (string)row["building_user"];
					}catch
					{}
					try{
					t_Investigate.Start_date = (DateTime)row["start_date"];
					}catch
					{}
					try{
					t_Investigate.Finish_date = (DateTime)row["finish_date"];
					}catch
					{}
					try{
					t_Investigate.Design_corp = (string)row["design_corp"];
					}catch
					{}
					try{
					t_Investigate.Construct_corp = (string)row["construct_corp"];
					}catch
					{}
					try{
					t_Investigate.Total_area = (int)row["total_area"];
					}catch
					{}
					try{
					t_Investigate.Floors = (int)row["floors"];
					}catch
					{}
					try{
					t_Investigate.Struct_type = (string)row["struct_type"];
					}catch
					{}
					try{
					t_Investigate.Building_purpose = (string)row["building_purpose"];
					}catch
					{}
					try{
					t_Investigate.Contacts = (string)row["contacts"];
					}catch
					{}
					try{
					t_Investigate.Contact_numbers = (string)row["contact_numbers"];
					}catch
					{}
					try{
					t_Investigate.Problems = (string)row["problems"];
					}catch
					{}
					try{
					t_Investigate.Checkup_suggestions = (string)row["checkup_suggestions"];
					}catch
					{}
					try{
					t_Investigate.Rectifications = (string)row["rectifications"];
					}catch
					{}
					try{
					t_Investigate.Remarks = (string)row["remarks"];
					}catch
					{}
					try{
					t_Investigate.Create_user = (string)row["create_user"];
					}catch
					{}
					try{
					t_Investigate.Create_datetime = (DateTime)row["create_datetime"];
					}catch
					{}
					try{
					t_Investigate.Update_user = (string)row["update_user"];
					}catch
					{}
					try{
					t_Investigate.Update_time = (DateTime)row["update_time"];
					}catch
					{}
					try{
					t_Investigate.Investigate_category = (string)row["investigate_category"];
					}catch
					{}
	
					list.Add(t_Investigate);
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