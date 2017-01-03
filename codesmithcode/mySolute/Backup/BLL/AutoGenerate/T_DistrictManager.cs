//============================================================
// Producnt name:		BLL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2016/12/19 16:30:06
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
		public static T_District AddT_District(int district_id,int district_level,int parent_district)
		{
			Models.T_District t_District = new Models.T_District();

			TransData_AddT_District(district_id,district_level,parent_district,  t_District );
		
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

        public static void DeleteT_DistrictById(string district_name)
        {
            T_DistrictService.DeleteT_DistrictById(district_name);
        }

		public static void ModifyT_District(T_District t_District)
        {
            T_DistrictService.ModifyT_District(t_District);
        }
		//overload
		public static void ModifyT_District(int district_id,string district_name,int district_level,int parent_district)
        {
			Models.T_District t_District = new Models.T_District();
	        //PK
			t_District.District_name=District_name;
			TransData_ModifyT_District(district_id,district_name,district_level,parent_district,t_District);
		
			 T_DistrictService.ModifyT_District(t_District);
		}

        public static IList<T_District> GetAllT_Districts()
        {
            return T_DistrictService.GetAllT_Districts();
        }

        public static T_District GetT_DistrictByDistrict_name(string district_name)
        {
            return T_DistrictService.GetT_DistrictByDistrict_name(district_name);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddT_District(int district_id,int district_level,int parent_district, Models.T_District t_District )
        {
			try{if (district_id.ToString() == "0001-1-1 0:00:00") t_District.District_id = null; else t_District.District_id = district_id;}catch{}

			try{if (district_level.ToString() == "0001-1-1 0:00:00") t_District.District_level = null; else t_District.District_level = district_level;}catch{}
			try{if (parent_district.ToString() == "0001-1-1 0:00:00") t_District.Parent_district = null; else t_District.Parent_district = parent_district;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyT_District(int district_id,string district_name,int district_level,int parent_district, Models.T_District t_District)
		{
			try{if (district_id.ToString() == "0001-1-1 0:00:00") t_District.District_id = null; else t_District.District_id = district_id;}catch{}

			try{if (district_level.ToString() == "0001-1-1 0:00:00") t_District.District_level = null; else t_District.District_level = district_level;}catch{}
			try{if (parent_district.ToString() == "0001-1-1 0:00:00") t_District.Parent_district = null; else t_District.Parent_district = parent_district;}catch{}
		}
		#endregion
    }
}

