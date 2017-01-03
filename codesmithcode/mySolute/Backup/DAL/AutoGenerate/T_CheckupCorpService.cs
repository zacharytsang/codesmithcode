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
	public static partial class T_CheckupCorpService
	{
        public static T_CheckupCorp AddT_CheckupCorp(T_CheckupCorp t_CheckupCorp)
		{
            string sql =
				"INSERT T_CheckupCorps (id, corp_addr, leading_official, contacts, contact_numbers, remarks, status)" +
				"VALUES (@id, @corp_addr, @leading_official, @contacts, @contact_numbers, @remarks, @status)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@id", DBHelper.GetValueByWhetherNull(t_CheckupCorp.id)),
					new SqlParameter("@corp_addr", DBHelper.GetValueByWhetherNull(t_CheckupCorp.corp_addr)),
					new SqlParameter("@leading_official", DBHelper.GetValueByWhetherNull(t_CheckupCorp.leading_official)),
					new SqlParameter("@contacts", DBHelper.GetValueByWhetherNull(t_CheckupCorp.contacts)),
					new SqlParameter("@contact_numbers", DBHelper.GetValueByWhetherNull(t_CheckupCorp.contact_numbers)),
					new SqlParameter("@remarks", DBHelper.GetValueByWhetherNull(t_CheckupCorp.remarks)),
					new SqlParameter("@status", DBHelper.GetValueByWhetherNull(t_CheckupCorp.status))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetT_CheckupCorpByCorp_name(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteT_CheckupCorp(T_CheckupCorp t_CheckupCorp)
		{
			DeleteT_CheckupCorpByCorp_name( t_CheckupCorp.Corp_name );
		}

        public static void DeleteT_CheckupCorpByCorp_name(string corp_name)
		{
            string sql = "DELETE T_CheckupCorps WHERE Corp_name = @Corp_name";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@corp_name", corp_name)
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
	                "id = @id, " +
	                "corp_addr = @corp_addr, " +
	                "leading_official = @leading_official, " +
	                "contacts = @contacts, " +
	                "contact_numbers = @contact_numbers, " +
	                "remarks = @remarks, " +
	                "status = @status " +
                "WHERE corp_name = @corp_name";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@corp_name", t_CheckupCorp.corp_name),
					new SqlParameter("@id", DBHelper.GetValueByWhetherNull(t_CheckupCorp.id)),
					new SqlParameter("@corp_addr", DBHelper.GetValueByWhetherNull(t_CheckupCorp.corp_addr)),
					new SqlParameter("@leading_official", DBHelper.GetValueByWhetherNull(t_CheckupCorp.leading_official)),
					new SqlParameter("@contacts", DBHelper.GetValueByWhetherNull(t_CheckupCorp.contacts)),
					new SqlParameter("@contact_numbers", DBHelper.GetValueByWhetherNull(t_CheckupCorp.contact_numbers)),
					new SqlParameter("@remarks", DBHelper.GetValueByWhetherNull(t_CheckupCorp.remarks)),
					new SqlParameter("@status", DBHelper.GetValueByWhetherNull(t_CheckupCorp.status))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<T_CheckupCorp> GetAllT_CheckupCorps()
        {
            string sqlAll = "SELECT * FROM T_CheckupCorps";
			return GetT_CheckupCorpsBySql( sqlAll );
        }
		
        public static T_CheckupCorp GetT_CheckupCorpByCorp_name(string corp_name)
        {
            string sql = "SELECT * FROM T_CheckupCorps WHERE Corp_name = @Corp_name";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Corp_name", corp_name));
                if (reader.Read())
                {
					
                    T_CheckupCorp t_CheckupCorp = new T_CheckupCorp();

					try{
					t_CheckupCorp.Id = (int)reader["id"];
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
		
		
		
		
        private static IList<T_CheckupCorp> GetT_CheckupCorpsBySql( string safeSql )
        {
            List<T_CheckupCorp> list = new List<T_CheckupCorp>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					T_CheckupCorp t_CheckupCorp = new T_CheckupCorp();
					
					try{
					t_CheckupCorp.Id = (int)row["id"];
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
		
        private static IList<T_CheckupCorp> GetT_CheckupCorpsBySql( string sql, params SqlParameter[] values )
        {
            List<T_CheckupCorp> list = new List<T_CheckupCorp>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					T_CheckupCorp t_CheckupCorp = new T_CheckupCorp();
					
					try{
					t_CheckupCorp.Id = (int)row["id"];
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