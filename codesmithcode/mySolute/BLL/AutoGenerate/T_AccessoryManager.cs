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

    public static partial class T_AccessoryManager
    {

		
		//override
		public static T_Accessory AddT_Accessory(string acc_category,string acc_name,string acc_url,bool status)
		{
			Models.T_Accessory t_Accessory = new Models.T_Accessory();

			TransData_AddT_Accessory(acc_category,acc_name,acc_url,status,  t_Accessory );
		
			return T_AccessoryService.AddT_Accessory(t_Accessory);
		}
        public static T_Accessory AddT_Accessory(T_Accessory t_Accessory)
        {
            return T_AccessoryService.AddT_Accessory(t_Accessory);
        }

        public static void DeleteT_Accessory(T_Accessory t_Accessory)
        {
            T_AccessoryService.DeleteT_Accessory(t_Accessory);
        }

        public static void DeleteT_AccessoryById(int id)
        {
            T_AccessoryService.DeleteT_AccessoryById(id);
        }

		public static void ModifyT_Accessory(T_Accessory t_Accessory)
        {
            T_AccessoryService.ModifyT_Accessory(t_Accessory);
        }
		//overload
		public static void ModifyT_Accessory(int Id,string acc_category,string acc_name,string acc_url,bool status)
        {
			Models.T_Accessory t_Accessory = new Models.T_Accessory();
	        //PK
			t_Accessory.Id=Id;
			TransData_ModifyT_Accessory(Id,acc_category,acc_name,acc_url,status,t_Accessory);
		
			 T_AccessoryService.ModifyT_Accessory(t_Accessory);
		}

        public static List<T_Accessory> GetAllT_Accessories()
        {
            return T_AccessoryService.GetAllT_Accessories();
        }
        
        
        public static List<T_Accessory> GetAllT_AccessoryBySQLstring(string sqlstring)
        {
            return T_AccessoryService.GetAllT_AccessoryBySQLstring(sqlstring);
        }
        
        
        public static T_Accessory GetT_AccessoryById(int id)
        {
            return T_AccessoryService.GetT_AccessoryById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddT_Accessory(string acc_category,string acc_name,string acc_url,bool status, Models.T_Accessory t_Accessory )
        {

			try{if (acc_category.ToString() == "0001-1-1 0:00:00") t_Accessory.Acc_category = null; else t_Accessory.Acc_category = acc_category;}catch{}
			try{if (acc_name.ToString() == "0001-1-1 0:00:00") t_Accessory.Acc_name = null; else t_Accessory.Acc_name = acc_name;}catch{}
			try{if (acc_url.ToString() == "0001-1-1 0:00:00") t_Accessory.Acc_url = null; else t_Accessory.Acc_url = acc_url;}catch{}
			try{if (status.ToString() == "0001-1-1 0:00:00") t_Accessory.Status = null; else t_Accessory.Status = status;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyT_Accessory(int Id,string acc_category,string acc_name,string acc_url,bool status, Models.T_Accessory t_Accessory)
		{

			try{if (acc_category.ToString() == "0001-1-1 0:00:00") t_Accessory.Acc_category = null; else t_Accessory.Acc_category = acc_category;}catch{}
			try{if (acc_name.ToString() == "0001-1-1 0:00:00") t_Accessory.Acc_name = null; else t_Accessory.Acc_name = acc_name;}catch{}
			try{if (acc_url.ToString() == "0001-1-1 0:00:00") t_Accessory.Acc_url = null; else t_Accessory.Acc_url = acc_url;}catch{}
			try{if (status.ToString() == "0001-1-1 0:00:00") t_Accessory.Status = null; else t_Accessory.Status = status;}catch{}
		}
		#endregion
    }
}

