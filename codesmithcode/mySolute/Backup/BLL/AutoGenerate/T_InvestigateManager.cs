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

    public static partial class T_InvestigateManager
    {

		
		//override
		public static T_Investigate AddT_Investigate(int id,string building_id,string building_owner,string building_user,DateTime start_date,DateTime finish_date,string design_corp,string construct_corp,int total_area,int floors,string struct_type,string building_purpose,string contacts,string contact_numbers,string problems,string checkup_suggestions,string rectifications,string remarks,string create_user,DateTime create_datetime,string update_user,DateTime update_time,string investigate_category)
		{
			Models.T_Investigate t_Investigate = new Models.T_Investigate();

			TransData_AddT_Investigate(id,building_id,building_owner,building_user,start_date,finish_date,design_corp,construct_corp,total_area,floors,struct_type,building_purpose,contacts,contact_numbers,problems,checkup_suggestions,rectifications,remarks,create_user,create_datetime,update_user,update_time,investigate_category,  t_Investigate );
		
			return T_InvestigateService.AddT_Investigate(t_Investigate);
		}
        public static T_Investigate AddT_Investigate(T_Investigate t_Investigate)
        {
            return T_InvestigateService.AddT_Investigate(t_Investigate);
        }

        public static void DeleteT_Investigate(T_Investigate t_Investigate)
        {
            T_InvestigateService.DeleteT_Investigate(t_Investigate);
        }

        public static void DeleteT_InvestigateById(string building_name)
        {
            T_InvestigateService.DeleteT_InvestigateById(building_name);
        }

		public static void ModifyT_Investigate(T_Investigate t_Investigate)
        {
            T_InvestigateService.ModifyT_Investigate(t_Investigate);
        }
		//overload
		public static void ModifyT_Investigate(int id,string building_id,string building_name,string building_owner,string building_user,DateTime start_date,DateTime finish_date,string design_corp,string construct_corp,int total_area,int floors,string struct_type,string building_purpose,string contacts,string contact_numbers,string problems,string checkup_suggestions,string rectifications,string remarks,string create_user,DateTime create_datetime,string update_user,DateTime update_time,string investigate_category)
        {
			Models.T_Investigate t_Investigate = new Models.T_Investigate();
	        //PK
			t_Investigate.Building_name=Building_name;
			TransData_ModifyT_Investigate(id,building_id,building_name,building_owner,building_user,start_date,finish_date,design_corp,construct_corp,total_area,floors,struct_type,building_purpose,contacts,contact_numbers,problems,checkup_suggestions,rectifications,remarks,create_user,create_datetime,update_user,update_time,investigate_category,t_Investigate);
		
			 T_InvestigateService.ModifyT_Investigate(t_Investigate);
		}

        public static IList<T_Investigate> GetAllT_Investigates()
        {
            return T_InvestigateService.GetAllT_Investigates();
        }

        public static T_Investigate GetT_InvestigateByBuilding_name(string building_name)
        {
            return T_InvestigateService.GetT_InvestigateByBuilding_name(building_name);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddT_Investigate(int id,string building_id,string building_owner,string building_user,DateTime start_date,DateTime finish_date,string design_corp,string construct_corp,int total_area,int floors,string struct_type,string building_purpose,string contacts,string contact_numbers,string problems,string checkup_suggestions,string rectifications,string remarks,string create_user,DateTime create_datetime,string update_user,DateTime update_time,string investigate_category, Models.T_Investigate t_Investigate )
        {
			try{if (id.ToString() == "0001-1-1 0:00:00") t_Investigate.Id = null; else t_Investigate.Id = id;}catch{}
			try{if (building_id.ToString() == "0001-1-1 0:00:00") t_Investigate.Building_id = null; else t_Investigate.Building_id = building_id;}catch{}

			try{if (building_owner.ToString() == "0001-1-1 0:00:00") t_Investigate.Building_owner = null; else t_Investigate.Building_owner = building_owner;}catch{}
			try{if (building_user.ToString() == "0001-1-1 0:00:00") t_Investigate.Building_user = null; else t_Investigate.Building_user = building_user;}catch{}
			try{if (start_date.ToString() == "0001-1-1 0:00:00") t_Investigate.Start_date = null; else t_Investigate.Start_date = start_date;}catch{}
			try{if (finish_date.ToString() == "0001-1-1 0:00:00") t_Investigate.Finish_date = null; else t_Investigate.Finish_date = finish_date;}catch{}
			try{if (design_corp.ToString() == "0001-1-1 0:00:00") t_Investigate.Design_corp = null; else t_Investigate.Design_corp = design_corp;}catch{}
			try{if (construct_corp.ToString() == "0001-1-1 0:00:00") t_Investigate.Construct_corp = null; else t_Investigate.Construct_corp = construct_corp;}catch{}
			try{if (total_area.ToString() == "0001-1-1 0:00:00") t_Investigate.Total_area = null; else t_Investigate.Total_area = total_area;}catch{}
			try{if (floors.ToString() == "0001-1-1 0:00:00") t_Investigate.Floors = null; else t_Investigate.Floors = floors;}catch{}
			try{if (struct_type.ToString() == "0001-1-1 0:00:00") t_Investigate.Struct_type = null; else t_Investigate.Struct_type = struct_type;}catch{}
			try{if (building_purpose.ToString() == "0001-1-1 0:00:00") t_Investigate.Building_purpose = null; else t_Investigate.Building_purpose = building_purpose;}catch{}
			try{if (contacts.ToString() == "0001-1-1 0:00:00") t_Investigate.Contacts = null; else t_Investigate.Contacts = contacts;}catch{}
			try{if (contact_numbers.ToString() == "0001-1-1 0:00:00") t_Investigate.Contact_numbers = null; else t_Investigate.Contact_numbers = contact_numbers;}catch{}
			try{if (problems.ToString() == "0001-1-1 0:00:00") t_Investigate.Problems = null; else t_Investigate.Problems = problems;}catch{}
			try{if (checkup_suggestions.ToString() == "0001-1-1 0:00:00") t_Investigate.Checkup_suggestions = null; else t_Investigate.Checkup_suggestions = checkup_suggestions;}catch{}
			try{if (rectifications.ToString() == "0001-1-1 0:00:00") t_Investigate.Rectifications = null; else t_Investigate.Rectifications = rectifications;}catch{}
			try{if (remarks.ToString() == "0001-1-1 0:00:00") t_Investigate.Remarks = null; else t_Investigate.Remarks = remarks;}catch{}
			try{if (create_user.ToString() == "0001-1-1 0:00:00") t_Investigate.Create_user = null; else t_Investigate.Create_user = create_user;}catch{}
			try{if (create_datetime.ToString() == "0001-1-1 0:00:00") t_Investigate.Create_datetime = null; else t_Investigate.Create_datetime = create_datetime;}catch{}
			try{if (update_user.ToString() == "0001-1-1 0:00:00") t_Investigate.Update_user = null; else t_Investigate.Update_user = update_user;}catch{}
			try{if (update_time.ToString() == "0001-1-1 0:00:00") t_Investigate.Update_time = null; else t_Investigate.Update_time = update_time;}catch{}
			try{if (investigate_category.ToString() == "0001-1-1 0:00:00") t_Investigate.Investigate_category = null; else t_Investigate.Investigate_category = investigate_category;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyT_Investigate(int id,string building_id,string building_name,string building_owner,string building_user,DateTime start_date,DateTime finish_date,string design_corp,string construct_corp,int total_area,int floors,string struct_type,string building_purpose,string contacts,string contact_numbers,string problems,string checkup_suggestions,string rectifications,string remarks,string create_user,DateTime create_datetime,string update_user,DateTime update_time,string investigate_category, Models.T_Investigate t_Investigate)
		{
			try{if (id.ToString() == "0001-1-1 0:00:00") t_Investigate.Id = null; else t_Investigate.Id = id;}catch{}
			try{if (building_id.ToString() == "0001-1-1 0:00:00") t_Investigate.Building_id = null; else t_Investigate.Building_id = building_id;}catch{}

			try{if (building_owner.ToString() == "0001-1-1 0:00:00") t_Investigate.Building_owner = null; else t_Investigate.Building_owner = building_owner;}catch{}
			try{if (building_user.ToString() == "0001-1-1 0:00:00") t_Investigate.Building_user = null; else t_Investigate.Building_user = building_user;}catch{}
			try{if (start_date.ToString() == "0001-1-1 0:00:00") t_Investigate.Start_date = null; else t_Investigate.Start_date = start_date;}catch{}
			try{if (finish_date.ToString() == "0001-1-1 0:00:00") t_Investigate.Finish_date = null; else t_Investigate.Finish_date = finish_date;}catch{}
			try{if (design_corp.ToString() == "0001-1-1 0:00:00") t_Investigate.Design_corp = null; else t_Investigate.Design_corp = design_corp;}catch{}
			try{if (construct_corp.ToString() == "0001-1-1 0:00:00") t_Investigate.Construct_corp = null; else t_Investigate.Construct_corp = construct_corp;}catch{}
			try{if (total_area.ToString() == "0001-1-1 0:00:00") t_Investigate.Total_area = null; else t_Investigate.Total_area = total_area;}catch{}
			try{if (floors.ToString() == "0001-1-1 0:00:00") t_Investigate.Floors = null; else t_Investigate.Floors = floors;}catch{}
			try{if (struct_type.ToString() == "0001-1-1 0:00:00") t_Investigate.Struct_type = null; else t_Investigate.Struct_type = struct_type;}catch{}
			try{if (building_purpose.ToString() == "0001-1-1 0:00:00") t_Investigate.Building_purpose = null; else t_Investigate.Building_purpose = building_purpose;}catch{}
			try{if (contacts.ToString() == "0001-1-1 0:00:00") t_Investigate.Contacts = null; else t_Investigate.Contacts = contacts;}catch{}
			try{if (contact_numbers.ToString() == "0001-1-1 0:00:00") t_Investigate.Contact_numbers = null; else t_Investigate.Contact_numbers = contact_numbers;}catch{}
			try{if (problems.ToString() == "0001-1-1 0:00:00") t_Investigate.Problems = null; else t_Investigate.Problems = problems;}catch{}
			try{if (checkup_suggestions.ToString() == "0001-1-1 0:00:00") t_Investigate.Checkup_suggestions = null; else t_Investigate.Checkup_suggestions = checkup_suggestions;}catch{}
			try{if (rectifications.ToString() == "0001-1-1 0:00:00") t_Investigate.Rectifications = null; else t_Investigate.Rectifications = rectifications;}catch{}
			try{if (remarks.ToString() == "0001-1-1 0:00:00") t_Investigate.Remarks = null; else t_Investigate.Remarks = remarks;}catch{}
			try{if (create_user.ToString() == "0001-1-1 0:00:00") t_Investigate.Create_user = null; else t_Investigate.Create_user = create_user;}catch{}
			try{if (create_datetime.ToString() == "0001-1-1 0:00:00") t_Investigate.Create_datetime = null; else t_Investigate.Create_datetime = create_datetime;}catch{}
			try{if (update_user.ToString() == "0001-1-1 0:00:00") t_Investigate.Update_user = null; else t_Investigate.Update_user = update_user;}catch{}
			try{if (update_time.ToString() == "0001-1-1 0:00:00") t_Investigate.Update_time = null; else t_Investigate.Update_time = update_time;}catch{}
			try{if (investigate_category.ToString() == "0001-1-1 0:00:00") t_Investigate.Investigate_category = null; else t_Investigate.Investigate_category = investigate_category;}catch{}
		}
		#endregion
    }
}

