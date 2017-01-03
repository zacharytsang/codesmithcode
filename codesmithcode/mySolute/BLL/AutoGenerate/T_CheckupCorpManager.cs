//============================================================
// Producnt name:		BLL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2016/12/20 14:30:26
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Models;

namespace BLL
{

    public static partial class T_CheckupCorpManager
    {

		
		//override
		public static T_CheckupCorp AddT_CheckupCorp(string corp_name,string corp_addr,string leading_official,string contacts,string contact_numbers,string remarks,bool status)
		{
			Models.T_CheckupCorp t_CheckupCorp = new Models.T_CheckupCorp();

			TransData_AddT_CheckupCorp(corp_name,corp_addr,leading_official,contacts,contact_numbers,remarks,status,  t_CheckupCorp );
		
			return T_CheckupCorpService.AddT_CheckupCorp(t_CheckupCorp);
		}
        public static T_CheckupCorp AddT_CheckupCorp(T_CheckupCorp t_CheckupCorp)
        {
            return T_CheckupCorpService.AddT_CheckupCorp(t_CheckupCorp);
        }

        public static void DeleteT_CheckupCorp(T_CheckupCorp t_CheckupCorp)
        {
            T_CheckupCorpService.DeleteT_CheckupCorp(t_CheckupCorp);
        }

        public static void DeleteT_CheckupCorpById(int id)
        {
            T_CheckupCorpService.DeleteT_CheckupCorpById(id);
        }

		public static void ModifyT_CheckupCorp(T_CheckupCorp t_CheckupCorp)
        {
            T_CheckupCorpService.ModifyT_CheckupCorp(t_CheckupCorp);
        }
		//overload
		public static void ModifyT_CheckupCorp(int Id,string corp_name,string corp_addr,string leading_official,string contacts,string contact_numbers,string remarks,bool status)
        {
			Models.T_CheckupCorp t_CheckupCorp = new Models.T_CheckupCorp();
	        //PK
			t_CheckupCorp.Id=Id;
			TransData_ModifyT_CheckupCorp(Id,corp_name,corp_addr,leading_official,contacts,contact_numbers,remarks,status,t_CheckupCorp);
		
			 T_CheckupCorpService.ModifyT_CheckupCorp(t_CheckupCorp);
		}

        public static List<T_CheckupCorp> GetAllT_CheckupCorps()
        {
            return T_CheckupCorpService.GetAllT_CheckupCorps();
        }
        
        
        public static List<T_CheckupCorp> GetAllT_CheckupCorpBySQLstring(string sqlstring)
        {
            return T_CheckupCorpService.GetAllT_CheckupCorpBySQLstring(sqlstring);
        }
        
        
        public static T_CheckupCorp GetT_CheckupCorpById(int id)
        {
            return T_CheckupCorpService.GetT_CheckupCorpById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddT_CheckupCorp(string corp_name,string corp_addr,string leading_official,string contacts,string contact_numbers,string remarks,bool status, Models.T_CheckupCorp t_CheckupCorp )
        {

			try{if (corp_name.ToString() == "0001-1-1 0:00:00") t_CheckupCorp.Corp_name = null; else t_CheckupCorp.Corp_name = corp_name;}catch{}
			try{if (corp_addr.ToString() == "0001-1-1 0:00:00") t_CheckupCorp.Corp_addr = null; else t_CheckupCorp.Corp_addr = corp_addr;}catch{}
			try{if (leading_official.ToString() == "0001-1-1 0:00:00") t_CheckupCorp.Leading_official = null; else t_CheckupCorp.Leading_official = leading_official;}catch{}
			try{if (contacts.ToString() == "0001-1-1 0:00:00") t_CheckupCorp.Contacts = null; else t_CheckupCorp.Contacts = contacts;}catch{}
			try{if (contact_numbers.ToString() == "0001-1-1 0:00:00") t_CheckupCorp.Contact_numbers = null; else t_CheckupCorp.Contact_numbers = contact_numbers;}catch{}
			try{if (remarks.ToString() == "0001-1-1 0:00:00") t_CheckupCorp.Remarks = null; else t_CheckupCorp.Remarks = remarks;}catch{}
			try{if (status.ToString() == "0001-1-1 0:00:00") t_CheckupCorp.Status = null; else t_CheckupCorp.Status = status;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyT_CheckupCorp(int Id,string corp_name,string corp_addr,string leading_official,string contacts,string contact_numbers,string remarks,bool status, Models.T_CheckupCorp t_CheckupCorp)
		{

			try{if (corp_name.ToString() == "0001-1-1 0:00:00") t_CheckupCorp.Corp_name = null; else t_CheckupCorp.Corp_name = corp_name;}catch{}
			try{if (corp_addr.ToString() == "0001-1-1 0:00:00") t_CheckupCorp.Corp_addr = null; else t_CheckupCorp.Corp_addr = corp_addr;}catch{}
			try{if (leading_official.ToString() == "0001-1-1 0:00:00") t_CheckupCorp.Leading_official = null; else t_CheckupCorp.Leading_official = leading_official;}catch{}
			try{if (contacts.ToString() == "0001-1-1 0:00:00") t_CheckupCorp.Contacts = null; else t_CheckupCorp.Contacts = contacts;}catch{}
			try{if (contact_numbers.ToString() == "0001-1-1 0:00:00") t_CheckupCorp.Contact_numbers = null; else t_CheckupCorp.Contact_numbers = contact_numbers;}catch{}
			try{if (remarks.ToString() == "0001-1-1 0:00:00") t_CheckupCorp.Remarks = null; else t_CheckupCorp.Remarks = remarks;}catch{}
			try{if (status.ToString() == "0001-1-1 0:00:00") t_CheckupCorp.Status = null; else t_CheckupCorp.Status = status;}catch{}
		}
		#endregion
    }
}

