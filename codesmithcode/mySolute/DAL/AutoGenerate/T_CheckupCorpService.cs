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
	public static partial class T_CheckupCorpService
	{
        public static T_CheckupCorp AddT_CheckupCorp(T_CheckupCorp t_CheckupCorp)
		{
            string sql =
				"INSERT T_CheckupCorps (corp_name, corp_addr, leading_official, contacts, contact_numbers, remarks, status)" +
				"VALUES (@corp_name, @corp_addr, @leading_official, @contacts, @contact_numbers, @remarks, @status)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@corp_name", DBHelper.GetValueByWhetherNull(t_CheckupCorp.Corp_name)),
					new SqlParameter("@corp_addr", DBHelper.GetValueByWhetherNull(t_CheckupCorp.Corp_addr)),
					new SqlParameter("@leading_official", DBHelper.GetValueByWhetherNull(t_CheckupCorp.Leading_official)),
					new SqlParameter("@contacts", DBHelper.GetValueByWhetherNull(t_CheckupCorp.Contacts)),
					new SqlParameter("@contact_numbers", DBHelper.GetValueByWhetherNull(t_CheckupCorp.Contact_numbers)),
					new SqlParameter("@remarks", DBHelper.GetValueByWhetherNull(t_CheckupCorp.Remarks)),
					new SqlParameter("@status", DBHelper.GetValueByWhetherNull(t_CheckupCorp.Status))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetT_CheckupCorpById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteT_CheckupCorp(T_CheckupCorp t_CheckupCorp)
		{
			DeleteT_CheckupCorpById( t_CheckupCorp.Id );
		}

        public static void DeleteT_CheckupCorpById(int id)
		{
            string sql = "DELETE T_CheckupCorps WHERE Id = @Id";

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
						
        public static void ModifyT_CheckupCorp(T_CheckupCorp t_CheckupCorp)
        {
            string sql =
                "UPDATE T_CheckupCorps " +
                "SET " +
	                "corp_name = @corp_name, " +
	                "corp_addr = @corp_addr, " +
	                "leading_official = @leading_official, " +
	                "contacts = @contacts, " +
	                "contact_numbers = @contact_numbers, " +
	                "remarks = @remarks, " +
	                "status = @status " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", t_CheckupCorp.Id),
					new SqlParameter("@corp_name", DBHelper.GetValueByWhetherNull(t_CheckupCorp.Corp_name)),
					new SqlParameter("@corp_addr", DBHelper.GetValueByWhetherNull(t_CheckupCorp.Corp_addr)),
					new SqlParameter("@leading_official", DBHelper.GetValueByWhetherNull(t_CheckupCorp.Leading_official)),
					new SqlParameter("@contacts", DBHelper.GetValueByWhetherNull(t_CheckupCorp.Contacts)),
					new SqlParameter("@contact_numbers", DBHelper.GetValueByWhetherNull(t_CheckupCorp.Contact_numbers)),
					new SqlParameter("@remarks", DBHelper.GetValueByWhetherNull(t_CheckupCorp.Remarks)),
					new SqlParameter("@status", DBHelper.GetValueByWhetherNull(t_CheckupCorp.Status))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static List<T_CheckupCorp> GetAllT_CheckupCorps()
        {
            string sqlAll = "SELECT * FROM T_CheckupCorps";
			return GetT_CheckupCorpsBySql( sqlAll );
        }
        
        public static List<T_CheckupCorp> GetAllT_CheckupCorpBySQLstring(string sqlstring)
        {
			return GetT_CheckupCorpsBySql( sqlstring );
        }
        
		
        public static T_CheckupCorp GetT_CheckupCorpById(int id)
        {
            string sql = "SELECT * FROM T_CheckupCorps WHERE Id = @Id";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    T_CheckupCorp t_CheckupCorp = new T_CheckupCorp();

					try{
					t_CheckupCorp.Id = (int)reader["Id"];
					}catch
					{}
					try{
					t_CheckupCorp.Corp_name = (string)reader["corp_name"];
					}catch
					{}
					try{
					t_CheckupCorp.Corp_addr = (string)reader["corp_addr"];
					}catch
					{}
					try{
					t_CheckupCorp.Leading_official = (string)reader["leading_official"];
					}catch
					{}
					try{
					t_CheckupCorp.Contacts = (string)reader["contacts"];
					}catch
					{}
					try{
					t_CheckupCorp.Contact_numbers = (string)reader["contact_numbers"];
					}catch
					{}
					try{
					t_CheckupCorp.Remarks = (string)reader["remarks"];
					}catch
					{}
					try{
					t_CheckupCorp.Status = (bool)reader["status"];
					}catch
					{}

                    reader.Close();
					
                    return t_CheckupCorp;
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
		
		
		
		
        private static List<T_CheckupCorp> GetT_CheckupCorpsBySql( string safeSql )
        {
            List<T_CheckupCorp> list = new List<T_CheckupCorp>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					T_CheckupCorp t_CheckupCorp = new T_CheckupCorp();
					
					try{
					t_CheckupCorp.Id = (int)row["Id"];
					}catch
					{}
					try{
					t_CheckupCorp.Corp_name = (string)row["corp_name"];
					}catch
					{}
					try{
					t_CheckupCorp.Corp_addr = (string)row["corp_addr"];
					}catch
					{}
					try{
					t_CheckupCorp.Leading_official = (string)row["leading_official"];
					}catch
					{}
					try{
					t_CheckupCorp.Contacts = (string)row["contacts"];
					}catch
					{}
					try{
					t_CheckupCorp.Contact_numbers = (string)row["contact_numbers"];
					}catch
					{}
					try{
					t_CheckupCorp.Remarks = (string)row["remarks"];
					}catch
					{}
					try{
					t_CheckupCorp.Status = (bool)row["status"];
					}catch
					{}
	
					list.Add(t_CheckupCorp);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static List<T_CheckupCorp> GetT_CheckupCorpsBySql( string sql, params SqlParameter[] values )
        {
            List<T_CheckupCorp> list = new List<T_CheckupCorp>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					T_CheckupCorp t_CheckupCorp = new T_CheckupCorp();
					
					try{
					t_CheckupCorp.Id = (int)row["Id"];
					}catch
					{}
					try{
					t_CheckupCorp.Corp_name = (string)row["corp_name"];
					}catch
					{}
					try{
					t_CheckupCorp.Corp_addr = (string)row["corp_addr"];
					}catch
					{}
					try{
					t_CheckupCorp.Leading_official = (string)row["leading_official"];
					}catch
					{}
					try{
					t_CheckupCorp.Contacts = (string)row["contacts"];
					}catch
					{}
					try{
					t_CheckupCorp.Contact_numbers = (string)row["contact_numbers"];
					}catch
					{}
					try{
					t_CheckupCorp.Remarks = (string)row["remarks"];
					}catch
					{}
					try{
					t_CheckupCorp.Status = (bool)row["status"];
					}catch
					{}
	
					list.Add(t_CheckupCorp);
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