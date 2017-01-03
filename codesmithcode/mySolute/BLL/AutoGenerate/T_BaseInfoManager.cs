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

    public static partial class T_BaseInfoManager
    {

		
		//override
		public static T_BaseInfo AddT_BaseInfo(string config_name,string config_value,bool config_status)
		{
			Models.T_BaseInfo t_BaseInfo = new Models.T_BaseInfo();

			TransData_AddT_BaseInfo(config_name,config_value,config_status,  t_BaseInfo );
		
			return T_BaseInfoService.AddT_BaseInfo(t_BaseInfo);
		}
        public static T_BaseInfo AddT_BaseInfo(T_BaseInfo t_BaseInfo)
        {
            return T_BaseInfoService.AddT_BaseInfo(t_BaseInfo);
        }

        public static void DeleteT_BaseInfo(T_BaseInfo t_BaseInfo)
        {
            T_BaseInfoService.DeleteT_BaseInfo(t_BaseInfo);
        }

        public static void DeleteT_BaseInfoById(int id)
        {
            T_BaseInfoService.DeleteT_BaseInfoById(id);
        }

		public static void ModifyT_BaseInfo(T_BaseInfo t_BaseInfo)
        {
            T_BaseInfoService.ModifyT_BaseInfo(t_BaseInfo);
        }
		//overload
		public static void ModifyT_BaseInfo(int Id,string config_name,string config_value,bool config_status)
        {
			Models.T_BaseInfo t_BaseInfo = new Models.T_BaseInfo();
	        //PK
			t_BaseInfo.Id=Id;
			TransData_ModifyT_BaseInfo(Id,config_name,config_value,config_status,t_BaseInfo);
		
			 T_BaseInfoService.ModifyT_BaseInfo(t_BaseInfo);
		}

        public static List<T_BaseInfo> GetAllT_BaseInfos()
        {
            return T_BaseInfoService.GetAllT_BaseInfos();
        }
        
        
        public static List<T_BaseInfo> GetAllT_BaseInfoBySQLstring(string sqlstring)
        {
            return T_BaseInfoService.GetAllT_BaseInfoBySQLstring(sqlstring);
        }
        
        
        public static T_BaseInfo GetT_BaseInfoById(int id)
        {
            return T_BaseInfoService.GetT_BaseInfoById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddT_BaseInfo(string config_name,string config_value,bool config_status, Models.T_BaseInfo t_BaseInfo )
        {

			try{if (config_name.ToString() == "0001-1-1 0:00:00") t_BaseInfo.Config_name = null; else t_BaseInfo.Config_name = config_name;}catch{}
			try{if (config_value.ToString() == "0001-1-1 0:00:00") t_BaseInfo.Config_value = null; else t_BaseInfo.Config_value = config_value;}catch{}
			try{if (config_status.ToString() == "0001-1-1 0:00:00") t_BaseInfo.Config_status = null; else t_BaseInfo.Config_status = config_status;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyT_BaseInfo(int Id,string config_name,string config_value,bool config_status, Models.T_BaseInfo t_BaseInfo)
		{

			try{if (config_name.ToString() == "0001-1-1 0:00:00") t_BaseInfo.Config_name = null; else t_BaseInfo.Config_name = config_name;}catch{}
			try{if (config_value.ToString() == "0001-1-1 0:00:00") t_BaseInfo.Config_value = null; else t_BaseInfo.Config_value = config_value;}catch{}
			try{if (config_status.ToString() == "0001-1-1 0:00:00") t_BaseInfo.Config_status = null; else t_BaseInfo.Config_status = config_status;}catch{}
		}
		#endregion
    }
}

