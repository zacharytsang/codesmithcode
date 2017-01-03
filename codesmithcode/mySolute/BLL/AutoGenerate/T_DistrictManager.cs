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

    public static partial class T_DistrictManager
    {

		
		//override
		public static T_District AddT_District(string district_name,int district_level,int parent_district)
		{
			Models.T_District t_District = new Models.T_District();

			TransData_AddT_District(district_name,district_level,parent_district,  t_District );
		
			return T_DistrictService.AddT_District(t_District);
		}
        public static T_District AddT_District(T_District t_District)
        {
            return T_DistrictService.AddT_District(t_District);
        }

        public static void DeleteT_District(T_District t_District)
        {
            T_DistrictService.DeleteT_District(t_District);
        }

        public static void DeleteT_DistrictById(int id)
        {
            T_DistrictService.DeleteT_DistrictById(id);
        }

		public static void ModifyT_District(T_District t_District)
        {
            T_DistrictService.ModifyT_District(t_District);
        }
		//overload
		public static void ModifyT_District(int Id,string district_name,int district_level,int parent_district)
        {
			Models.T_District t_District = new Models.T_District();
	        //PK
			t_District.Id=Id;
			TransData_ModifyT_District(Id,district_name,district_level,parent_district,t_District);
		
			 T_DistrictService.ModifyT_District(t_District);
		}

        public static List<T_District> GetAllT_Districts()
        {
            return T_DistrictService.GetAllT_Districts();
        }
        
        
        public static List<T_District> GetAllT_DistrictBySQLstring(string sqlstring)
        {
            return T_DistrictService.GetAllT_DistrictBySQLstring(sqlstring);
        }
        
        
        public static T_District GetT_DistrictById(int id)
        {
            return T_DistrictService.GetT_DistrictById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddT_District(string district_name,int district_level,int parent_district, Models.T_District t_District )
        {

			try{if (district_name.ToString() == "0001-1-1 0:00:00") t_District.District_name = null; else t_District.District_name = district_name;}catch{}
			try{if (district_level.ToString() == "0001-1-1 0:00:00") t_District.District_level = null; else t_District.District_level = district_level;}catch{}
			try{if (parent_district.ToString() == "0001-1-1 0:00:00") t_District.Parent_district = null; else t_District.Parent_district = parent_district;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyT_District(int Id,string district_name,int district_level,int parent_district, Models.T_District t_District)
		{

			try{if (district_name.ToString() == "0001-1-1 0:00:00") t_District.District_name = null; else t_District.District_name = district_name;}catch{}
			try{if (district_level.ToString() == "0001-1-1 0:00:00") t_District.District_level = null; else t_District.District_level = district_level;}catch{}
			try{if (parent_district.ToString() == "0001-1-1 0:00:00") t_District.Parent_district = null; else t_District.Parent_district = parent_district;}catch{}
		}
		#endregion
    }
}

