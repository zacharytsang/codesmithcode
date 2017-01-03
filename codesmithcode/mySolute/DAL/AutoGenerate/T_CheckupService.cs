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
	public static partial class T_CheckupService
	{
        public static T_Checkup AddT_Checkup(T_Checkup t_Checkup)
		{
            string sql =
				"INSERT T_Checkups (investigate_id, off_grades, rank_scores, anti_seismics, repairables, checkup_suggestions, evaluate_suggestions, solutions, remakes, create_user, create_time, update_user, update_time, status, checkup_category)" +
				"VALUES (@investigate_id, @off_grades, @rank_scores, @anti_seismics, @repairables, @checkup_suggestions, @evaluate_suggestions, @solutions, @remakes, @create_user, @create_time, @update_user, @update_time, @status, @checkup_category)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@investigate_id", DBHelper.GetValueByWhetherNull(t_Checkup.Investigate_id)),
					new SqlParameter("@off_grades", DBHelper.GetValueByWhetherNull(t_Checkup.Off_grades)),
					new SqlParameter("@rank_scores", DBHelper.GetValueByWhetherNull(t_Checkup.Rank_scores)),
					new SqlParameter("@anti_seismics", DBHelper.GetValueByWhetherNull(t_Checkup.Anti_seismics)),
					new SqlParameter("@repairables", DBHelper.GetValueByWhetherNull(t_Checkup.Repairables)),
					new SqlParameter("@checkup_suggestions", DBHelper.GetValueByWhetherNull(t_Checkup.Checkup_suggestions)),
					new SqlParameter("@evaluate_suggestions", DBHelper.GetValueByWhetherNull(t_Checkup.Evaluate_suggestions)),
					new SqlParameter("@solutions", DBHelper.GetValueByWhetherNull(t_Checkup.Solutions)),
					new SqlParameter("@remakes", DBHelper.GetValueByWhetherNull(t_Checkup.Remakes)),
					new SqlParameter("@create_user", DBHelper.GetValueByWhetherNull(t_Checkup.Create_user)),
					new SqlParameter("@create_time", DBHelper.GetValueByWhetherNull(t_Checkup.Create_time)),
					new SqlParameter("@update_user", DBHelper.GetValueByWhetherNull(t_Checkup.Update_user)),
					new SqlParameter("@update_time", DBHelper.GetValueByWhetherNull(t_Checkup.Update_time)),
					new SqlParameter("@status", DBHelper.GetValueByWhetherNull(t_Checkup.Status)),
					new SqlParameter("@checkup_category", DBHelper.GetValueByWhetherNull(t_Checkup.Checkup_category))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetT_CheckupById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteT_Checkup(T_Checkup t_Checkup)
		{
			DeleteT_CheckupById( t_Checkup.Id );
		}

        public static void DeleteT_CheckupById(int id)
		{
            string sql = "DELETE T_Checkups WHERE Id = @Id";

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
						
        public static void ModifyT_Checkup(T_Checkup t_Checkup)
        {
            string sql =
                "UPDATE T_Checkups " +
                "SET " +
	                "investigate_id = @investigate_id, " +
	                "off_grades = @off_grades, " +
	                "rank_scores = @rank_scores, " +
	                "anti_seismics = @anti_seismics, " +
	                "repairables = @repairables, " +
	                "checkup_suggestions = @checkup_suggestions, " +
	                "evaluate_suggestions = @evaluate_suggestions, " +
	                "solutions = @solutions, " +
	                "remakes = @remakes, " +
	                "create_user = @create_user, " +
	                "create_time = @create_time, " +
	                "update_user = @update_user, " +
	                "update_time = @update_time, " +
	                "status = @status, " +
	                "checkup_category = @checkup_category " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", t_Checkup.Id),
					new SqlParameter("@investigate_id", DBHelper.GetValueByWhetherNull(t_Checkup.Investigate_id)),
					new SqlParameter("@off_grades", DBHelper.GetValueByWhetherNull(t_Checkup.Off_grades)),
					new SqlParameter("@rank_scores", DBHelper.GetValueByWhetherNull(t_Checkup.Rank_scores)),
					new SqlParameter("@anti_seismics", DBHelper.GetValueByWhetherNull(t_Checkup.Anti_seismics)),
					new SqlParameter("@repairables", DBHelper.GetValueByWhetherNull(t_Checkup.Repairables)),
					new SqlParameter("@checkup_suggestions", DBHelper.GetValueByWhetherNull(t_Checkup.Checkup_suggestions)),
					new SqlParameter("@evaluate_suggestions", DBHelper.GetValueByWhetherNull(t_Checkup.Evaluate_suggestions)),
					new SqlParameter("@solutions", DBHelper.GetValueByWhetherNull(t_Checkup.Solutions)),
					new SqlParameter("@remakes", DBHelper.GetValueByWhetherNull(t_Checkup.Remakes)),
					new SqlParameter("@create_user", DBHelper.GetValueByWhetherNull(t_Checkup.Create_user)),
					new SqlParameter("@create_time", DBHelper.GetValueByWhetherNull(t_Checkup.Create_time)),
					new SqlParameter("@update_user", DBHelper.GetValueByWhetherNull(t_Checkup.Update_user)),
					new SqlParameter("@update_time", DBHelper.GetValueByWhetherNull(t_Checkup.Update_time)),
					new SqlParameter("@status", DBHelper.GetValueByWhetherNull(t_Checkup.Status)),
					new SqlParameter("@checkup_category", DBHelper.GetValueByWhetherNull(t_Checkup.Checkup_category))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static List<T_Checkup> GetAllT_Checkups()
        {
            string sqlAll = "SELECT * FROM T_Checkups";
			return GetT_CheckupsBySql( sqlAll );
        }
        
        public static List<T_Checkup> GetAllT_CheckupBySQLstring(string sqlstring)
        {
			return GetT_CheckupsBySql( sqlstring );
        }
        
		
        public static T_Checkup GetT_CheckupById(int id)
        {
            string sql = "SELECT * FROM T_Checkups WHERE Id = @Id";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    T_Checkup t_Checkup = new T_Checkup();

					try{
					t_Checkup.Id = (int)reader["Id"];
					}catch
					{}
					try{
					t_Checkup.Investigate_id = (int)reader["investigate_id"];
					}catch
					{}
					try{
					t_Checkup.Off_grades = (string)reader["off_grades"];
					}catch
					{}
					try{
					t_Checkup.Rank_scores = (string)reader["rank_scores"];
					}catch
					{}
					try{
					t_Checkup.Anti_seismics = (string)reader["anti_seismics"];
					}catch
					{}
					try{
					t_Checkup.Repairables = (string)reader["repairables"];
					}catch
					{}
					try{
					t_Checkup.Checkup_suggestions = (string)reader["checkup_suggestions"];
					}catch
					{}
					try{
					t_Checkup.Evaluate_suggestions = (string)reader["evaluate_suggestions"];
					}catch
					{}
					try{
					t_Checkup.Solutions = (string)reader["solutions"];
					}catch
					{}
					try{
					t_Checkup.Remakes = (string)reader["remakes"];
					}catch
					{}
					try{
					t_Checkup.Create_user = (string)reader["create_user"];
					}catch
					{}
					try{
					t_Checkup.Create_time = (DateTime)reader["create_time"];
					}catch
					{}
					try{
					t_Checkup.Update_user = (string)reader["update_user"];
					}catch
					{}
					try{
					t_Checkup.Update_time = (DateTime)reader["update_time"];
					}catch
					{}
					try{
					t_Checkup.Status = (bool)reader["status"];
					}catch
					{}
					try{
					t_Checkup.Checkup_category = (string)reader["checkup_category"];
					}catch
					{}

                    reader.Close();
					
                    return t_Checkup;
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
		
		
		
		
        private static List<T_Checkup> GetT_CheckupsBySql( string safeSql )
        {
            List<T_Checkup> list = new List<T_Checkup>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					T_Checkup t_Checkup = new T_Checkup();
					
					try{
					t_Checkup.Id = (int)row["Id"];
					}catch
					{}
					try{
					t_Checkup.Investigate_id = (int)row["investigate_id"];
					}catch
					{}
					try{
					t_Checkup.Off_grades = (string)row["off_grades"];
					}catch
					{}
					try{
					t_Checkup.Rank_scores = (string)row["rank_scores"];
					}catch
					{}
					try{
					t_Checkup.Anti_seismics = (string)row["anti_seismics"];
					}catch
					{}
					try{
					t_Checkup.Repairables = (string)row["repairables"];
					}catch
					{}
					try{
					t_Checkup.Checkup_suggestions = (string)row["checkup_suggestions"];
					}catch
					{}
					try{
					t_Checkup.Evaluate_suggestions = (string)row["evaluate_suggestions"];
					}catch
					{}
					try{
					t_Checkup.Solutions = (string)row["solutions"];
					}catch
					{}
					try{
					t_Checkup.Remakes = (string)row["remakes"];
					}catch
					{}
					try{
					t_Checkup.Create_user = (string)row["create_user"];
					}catch
					{}
					try{
					t_Checkup.Create_time = (DateTime)row["create_time"];
					}catch
					{}
					try{
					t_Checkup.Update_user = (string)row["update_user"];
					}catch
					{}
					try{
					t_Checkup.Update_time = (DateTime)row["update_time"];
					}catch
					{}
					try{
					t_Checkup.Status = (bool)row["status"];
					}catch
					{}
					try{
					t_Checkup.Checkup_category = (string)row["checkup_category"];
					}catch
					{}
	
					list.Add(t_Checkup);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static List<T_Checkup> GetT_CheckupsBySql( string sql, params SqlParameter[] values )
        {
            List<T_Checkup> list = new List<T_Checkup>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					T_Checkup t_Checkup = new T_Checkup();
					
					try{
					t_Checkup.Id = (int)row["Id"];
					}catch
					{}
					try{
					t_Checkup.Investigate_id = (int)row["investigate_id"];
					}catch
					{}
					try{
					t_Checkup.Off_grades = (string)row["off_grades"];
					}catch
					{}
					try{
					t_Checkup.Rank_scores = (string)row["rank_scores"];
					}catch
					{}
					try{
					t_Checkup.Anti_seismics = (string)row["anti_seismics"];
					}catch
					{}
					try{
					t_Checkup.Repairables = (string)row["repairables"];
					}catch
					{}
					try{
					t_Checkup.Checkup_suggestions = (string)row["checkup_suggestions"];
					}catch
					{}
					try{
					t_Checkup.Evaluate_suggestions = (string)row["evaluate_suggestions"];
					}catch
					{}
					try{
					t_Checkup.Solutions = (string)row["solutions"];
					}catch
					{}
					try{
					t_Checkup.Remakes = (string)row["remakes"];
					}catch
					{}
					try{
					t_Checkup.Create_user = (string)row["create_user"];
					}catch
					{}
					try{
					t_Checkup.Create_time = (DateTime)row["create_time"];
					}catch
					{}
					try{
					t_Checkup.Update_user = (string)row["update_user"];
					}catch
					{}
					try{
					t_Checkup.Update_time = (DateTime)row["update_time"];
					}catch
					{}
					try{
					t_Checkup.Status = (bool)row["status"];
					}catch
					{}
					try{
					t_Checkup.Checkup_category = (string)row["checkup_category"];
					}catch
					{}
	
					list.Add(t_Checkup);
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