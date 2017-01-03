//============================================================
// Producnt name:		BLL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2016/12/19 16:30:05
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
		public static T_Accessory AddT_Accessory(int id,string acc_category,string acc_name,bool status)
		{
			Models.T_Accessory t_Accessory = new Models.T_Accessory();

			TransData_AddT_Accessory(id,acc_category,acc_name,status,  t_Accessory );
		
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

        public static void DeleteT_AccessoryById(string acc_url)
        {
            T_AccessoryService.DeleteT_AccessoryById(acc_url);
        }

		public static void ModifyT_Accessory(T_Accessory t_Accessory)
        {
            T_AccessoryService.ModifyT_Accessory(t_Accessory);
        }
		//overload
		public static void ModifyT_Accessory(int id,string acc_category,string acc_name,string acc_url,bool status)
        {
			Models.T_Accessory t_Accessory = new Models.T_Accessory();
	        //PK
			t_Accessory.Acc_url=Acc_url;
			TransData_ModifyT_Accessory(id,acc_category,acc_name,acc_url,status,t_Accessory);
		
			 T_AccessoryService.ModifyT_Accessory(t_Accessory);
		}

        public static IList<T_Accessory> GetAllT_Accessories()
        {
            return T_AccessoryService.GetAllT_Accessories();
        }

        public static T_Accessory GetT_AccessoryByAcc_url(string acc_url)
        {
            return T_AccessoryService.GetT_AccessoryByAcc_url(acc_url);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddT_Accessory(int id,string acc_category,string acc_name,bool status, Models.T_Accessory t_Accessory )
        {
			try{if (id.ToString() == "0001-1-1 0:00:00") t_Accessory.Id = null; else t_Accessory.Id = id;}catch{}
			try{if (acc_category.ToString() == "0001-1-1 0:00:00") t_Accessory.Acc_category = null; else t_Accessory.Acc_category = acc_category;}catch{}
			try{if (acc_name.ToString() == "0001-1-1 0:00:00") t_Accessory.Acc_name = null; else t_Accessory.Acc_name = acc_name;}catch{}

			try{if (status.ToString() == "0001-1-1 0:00:00") t_Accessory.Status = null; else t_Accessory.Status = status;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyT_Accessory(int id,string acc_category,string acc_name,string acc_url,bool status, Models.T_Accessory t_Accessory)
		{
			try{if (id.ToString() == "0001-1-1 0:00:00") t_Accessory.Id = null; else t_Accessory.Id = id;}catch{}
			try{if (acc_category.ToString() == "0001-1-1 0:00:00") t_Accessory.Acc_category = null; else t_Accessory.Acc_category = acc_category;}catch{}
			try{if (acc_name.ToString() == "0001-1-1 0:00:00") t_Accessory.Acc_name = null; else t_Accessory.Acc_name = acc_name;}catch{}

			try{if (status.ToString() == "0001-1-1 0:00:00") t_Accessory.Status = null; else t_Accessory.Status = status;}catch{}
		}
		#endregion
    }
}

