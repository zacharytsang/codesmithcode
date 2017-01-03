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
	public static partial class T_InvestigateService
	{
        public static T_Investigate AddT_Investigate(T_Investigate t_Investigate)
		{
            string sql =
				"INSERT T_Investigates (id, building_id, building_owner, building_user, start_date, finish_date, design_corp, construct_corp, total_area, floors, struct_type, building_purpose, contacts, contact_numbers, problems, checkup_suggestions, rectifications, remarks, create_user, create_datetime, update_user, update_time, investigate_category)" +
				"VALUES (@id, @building_id, @building_owner, @building_user, @start_date, @finish_date, @design_corp, @construct_corp, @total_area, @floors, @struct_type, @building_purpose, @contacts, @contact_numbers, @problems, @checkup_suggestions, @rectifications, @remarks, @create_user, @create_datetime, @update_user, @update_time, @investigate_category)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@id", DBHelper.GetValueByWhetherNull(t_Investigate.id)),
					new SqlParameter("@building_id", DBHelper.GetValueByWhetherNull(t_Investigate.building_id)),
					new SqlParameter("@building_owner", DBHelper.GetValueByWhetherNull(t_Investigate.building_owner)),
					new SqlParameter("@building_user", DBHelper.GetValueByWhetherNull(t_Investigate.building_user)),
					new SqlParameter("@start_date", DBHelper.GetValueByWhetherNull(t_Investigate.start_date)),
					new SqlParameter("@finish_date", DBHelper.GetValueByWhetherNull(t_Investigate.finish_date)),
					new SqlParameter("@design_corp", DBHelper.GetValueByWhetherNull(t_Investigate.design_corp)),
					new SqlParameter("@construct_corp", DBHelper.GetValueByWhetherNull(t_Investigate.construct_corp)),
					new SqlParameter("@total_area", DBHelper.GetValueByWhetherNull(t_Investigate.total_area)),
					new SqlParameter("@floors", DBHelper.GetValueByWhetherNull(t_Investigate.floors)),
					new SqlParameter("@struct_type", DBHelper.GetValueByWhetherNull(t_Investigate.struct_type)),
					new SqlParameter("@building_purpose", DBHelper.GetValueByWhetherNull(t_Investigate.building_purpose)),
					new SqlParameter("@contacts", DBHelper.GetValueByWhetherNull(t_Investigate.contacts)),
					new SqlParameter("@contact_numbers", DBHelper.GetValueByWhetherNull(t_Investigate.contact_numbers)),
					new SqlParameter("@problems", DBHelper.GetValueByWhetherNull(t_Investigate.problems)),
					new SqlParameter("@checkup_suggestions", DBHelper.GetValueByWhetherNull(t_Investigate.checkup_suggestions)),
					new SqlParameter("@rectifications", DBHelper.GetValueByWhetherNull(t_Investigate.rectifications)),
					new SqlParameter("@remarks", DBHelper.GetValueByWhetherNull(t_Investigate.remarks)),
					new SqlParameter("@create_user", DBHelper.GetValueByWhetherNull(t_Investigate.create_user)),
					new SqlParameter("@create_datetime", DBHelper.GetValueByWhetherNull(t_Investigate.create_datetime)),
					new SqlParameter("@update_user", DBHelper.GetValueByWhetherNull(t_Investigate.update_user)),
					new SqlParameter("@update_time", DBHelper.GetValueByWhetherNull(t_Investigate.update_time)),
					new SqlParameter("@investigate_category", DBHelper.GetValueByWhetherNull(t_Investigate.investigate_category))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetT_InvestigateByBuilding_name(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteT_Investigate(T_Investigate t_Investigate)
		{
			DeleteT_InvestigateByBuilding_name( t_Investigate.Building_name );
		}

        public static void DeleteT_InvestigateByBuilding_name(string building_name)
		{
            string sql = "DELETE T_Investigates WHERE Building_name = @Building_name";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@building_name", building_name)
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
	                "id = @id, " +
	                "building_id = @building_id, " +
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
                "WHERE building_name = @building_name";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@building_name", t_Investigate.building_name),
					new SqlParameter("@id", DBHelper.GetValueByWhetherNull(t_Investigate.id)),
					new SqlParameter("@building_id", DBHelper.GetValueByWhetherNull(t_Investigate.building_id)),
					new SqlParameter("@building_owner", DBHelper.GetValueByWhetherNull(t_Investigate.building_owner)),
					new SqlParameter("@building_user", DBHelper.GetValueByWhetherNull(t_Investigate.building_user)),
					new SqlParameter("@start_date", DBHelper.GetValueByWhetherNull(t_Investigate.start_date)),
					new SqlParameter("@finish_date", DBHelper.GetValueByWhetherNull(t_Investigate.finish_date)),
					new SqlParameter("@design_corp", DBHelper.GetValueByWhetherNull(t_Investigate.design_corp)),
					new SqlParameter("@construct_corp", DBHelper.GetValueByWhetherNull(t_Investigate.construct_corp)),
					new SqlParameter("@total_area", DBHelper.GetValueByWhetherNull(t_Investigate.total_area)),
					new SqlParameter("@floors", DBHelper.GetValueByWhetherNull(t_Investigate.floors)),
					new SqlParameter("@struct_type", DBHelper.GetValueByWhetherNull(t_Investigate.struct_type)),
					new SqlParameter("@building_purpose", DBHelper.GetValueByWhetherNull(t_Investigate.building_purpose)),
					new SqlParameter("@contacts", DBHelper.GetValueByWhetherNull(t_Investigate.contacts)),
					new SqlParameter("@contact_numbers", DBHelper.GetValueByWhetherNull(t_Investigate.contact_numbers)),
					new SqlParameter("@problems", DBHelper.GetValueByWhetherNull(t_Investigate.problems)),
					new SqlParameter("@checkup_suggestions", DBHelper.GetValueByWhetherNull(t_Investigate.checkup_suggestions)),
					new SqlParameter("@rectifications", DBHelper.GetValueByWhetherNull(t_Investigate.rectifications)),
					new SqlParameter("@remarks", DBHelper.GetValueByWhetherNull(t_Investigate.remarks)),
					new SqlParameter("@create_user", DBHelper.GetValueByWhetherNull(t_Investigate.create_user)),
					new SqlParameter("@create_datetime", DBHelper.GetValueByWhetherNull(t_Investigate.create_datetime)),
					new SqlParameter("@update_user", DBHelper.GetValueByWhetherNull(t_Investigate.update_user)),
					new SqlParameter("@update_time", DBHelper.GetValueByWhetherNull(t_Investigate.update_time)),
					new SqlParameter("@investigate_category", DBHelper.GetValueByWhetherNull(t_Investigate.investigate_category))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<T_Investigate> GetAllT_Investigates()
        {
            string sqlAll = "SELECT * FROM T_Investigates";
			return GetT_InvestigatesBySql( sqlAll );
        }
		
        public static T_Investigate GetT_InvestigateByBuilding_name(string building_name)
        {
            string sql = "SELECT * FROM T_Investigates WHERE Building_name = @Building_name";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Building_name", building_name));
                if (reader.Read())
                {
					
                    T_Investigate t_Investigate = new T_Investigate();

					try{
					t_Investigate.Id = (int)reader["id"];
					}catch
					{}
					try{
					t_Investigate.Building_id = (string)reader["building_id"];
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
		
		
		
		
        private static IList<T_Investigate> GetT_InvestigatesBySql( string safeSql )
        {
            List<T_Investigate> list = new List<T_Investigate>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					T_Investigate t_Investigate = new T_Investigate();
					
					try{
					t_Investigate.Id = (int)row["id"];
					}catch
					{}
					try{
					t_Investigate.Building_id = (string)row["building_id"];
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
		
        private static IList<T_Investigate> GetT_InvestigatesBySql( string sql, params SqlParameter[] values )
        {
            List<T_Investigate> list = new List<T_Investigate>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					T_Investigate t_Investigate = new T_Investigate();
					
					try{
					t_Investigate.Id = (int)row["id"];
					}catch
					{}
					try{
					t_Investigate.Building_id = (string)row["building_id"];
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