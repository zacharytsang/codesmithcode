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

    public static partial class T_CheckupManager
    {

		
		//override
		public static T_Checkup AddT_Checkup(int investigate_id,string off_grades,string rank_scores,string anti_seismics,string repairables,string checkup_suggestions,string evaluate_suggestions,string solutions,string remakes,string create_user,DateTime create_time,string update_user,DateTime update_time,bool status,string checkup_category)
		{
			Models.T_Checkup t_Checkup = new Models.T_Checkup();

			TransData_AddT_Checkup(investigate_id,off_grades,rank_scores,anti_seismics,repairables,checkup_suggestions,evaluate_suggestions,solutions,remakes,create_user,create_time,update_user,update_time,status,checkup_category,  t_Checkup );
		
			return T_CheckupService.AddT_Checkup(t_Checkup);
		}
        public static T_Checkup AddT_Checkup(T_Checkup t_Checkup)
        {
            return T_CheckupService.AddT_Checkup(t_Checkup);
        }

        public static void DeleteT_Checkup(T_Checkup t_Checkup)
        {
            T_CheckupService.DeleteT_Checkup(t_Checkup);
        }

        public static void DeleteT_CheckupById(int id)
        {
            T_CheckupService.DeleteT_CheckupById(id);
        }

		public static void ModifyT_Checkup(T_Checkup t_Checkup)
        {
            T_CheckupService.ModifyT_Checkup(t_Checkup);
        }
		//overload
		public static void ModifyT_Checkup(int Id,int investigate_id,string off_grades,string rank_scores,string anti_seismics,string repairables,string checkup_suggestions,string evaluate_suggestions,string solutions,string remakes,string create_user,DateTime create_time,string update_user,DateTime update_time,bool status,string checkup_category)
        {
			Models.T_Checkup t_Checkup = new Models.T_Checkup();
	        //PK
			t_Checkup.Id=Id;
			TransData_ModifyT_Checkup(Id,investigate_id,off_grades,rank_scores,anti_seismics,repairables,checkup_suggestions,evaluate_suggestions,solutions,remakes,create_user,create_time,update_user,update_time,status,checkup_category,t_Checkup);
		
			 T_CheckupService.ModifyT_Checkup(t_Checkup);
		}

        public static List<T_Checkup> GetAllT_Checkups()
        {
            return T_CheckupService.GetAllT_Checkups();
        }
        
        
        public static List<T_Checkup> GetAllT_CheckupBySQLstring(string sqlstring)
        {
            return T_CheckupService.GetAllT_CheckupBySQLstring(sqlstring);
        }
        
        
        public static T_Checkup GetT_CheckupById(int id)
        {
            return T_CheckupService.GetT_CheckupById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddT_Checkup(int investigate_id,string off_grades,string rank_scores,string anti_seismics,string repairables,string checkup_suggestions,string evaluate_suggestions,string solutions,string remakes,string create_user,DateTime create_time,string update_user,DateTime update_time,bool status,string checkup_category, Models.T_Checkup t_Checkup )
        {

			try{if (investigate_id.ToString() == "0001-1-1 0:00:00") t_Checkup.Investigate_id = null; else t_Checkup.Investigate_id = investigate_id;}catch{}
			try{if (off_grades.ToString() == "0001-1-1 0:00:00") t_Checkup.Off_grades = null; else t_Checkup.Off_grades = off_grades;}catch{}
			try{if (rank_scores.ToString() == "0001-1-1 0:00:00") t_Checkup.Rank_scores = null; else t_Checkup.Rank_scores = rank_scores;}catch{}
			try{if (anti_seismics.ToString() == "0001-1-1 0:00:00") t_Checkup.Anti_seismics = null; else t_Checkup.Anti_seismics = anti_seismics;}catch{}
			try{if (repairables.ToString() == "0001-1-1 0:00:00") t_Checkup.Repairables = null; else t_Checkup.Repairables = repairables;}catch{}
			try{if (checkup_suggestions.ToString() == "0001-1-1 0:00:00") t_Checkup.Checkup_suggestions = null; else t_Checkup.Checkup_suggestions = checkup_suggestions;}catch{}
			try{if (evaluate_suggestions.ToString() == "0001-1-1 0:00:00") t_Checkup.Evaluate_suggestions = null; else t_Checkup.Evaluate_suggestions = evaluate_suggestions;}catch{}
			try{if (solutions.ToString() == "0001-1-1 0:00:00") t_Checkup.Solutions = null; else t_Checkup.Solutions = solutions;}catch{}
			try{if (remakes.ToString() == "0001-1-1 0:00:00") t_Checkup.Remakes = null; else t_Checkup.Remakes = remakes;}catch{}
			try{if (create_user.ToString() == "0001-1-1 0:00:00") t_Checkup.Create_user = null; else t_Checkup.Create_user = create_user;}catch{}
			try{if (create_time.ToString() == "0001-1-1 0:00:00") t_Checkup.Create_time = null; else t_Checkup.Create_time = create_time;}catch{}
			try{if (update_user.ToString() == "0001-1-1 0:00:00") t_Checkup.Update_user = null; else t_Checkup.Update_user = update_user;}catch{}
			try{if (update_time.ToString() == "0001-1-1 0:00:00") t_Checkup.Update_time = null; else t_Checkup.Update_time = update_time;}catch{}
			try{if (status.ToString() == "0001-1-1 0:00:00") t_Checkup.Status = null; else t_Checkup.Status = status;}catch{}
			try{if (checkup_category.ToString() == "0001-1-1 0:00:00") t_Checkup.Checkup_category = null; else t_Checkup.Checkup_category = checkup_category;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyT_Checkup(int Id,int investigate_id,string off_grades,string rank_scores,string anti_seismics,string repairables,string checkup_suggestions,string evaluate_suggestions,string solutions,string remakes,string create_user,DateTime create_time,string update_user,DateTime update_time,bool status,string checkup_category, Models.T_Checkup t_Checkup)
		{

			try{if (investigate_id.ToString() == "0001-1-1 0:00:00") t_Checkup.Investigate_id = null; else t_Checkup.Investigate_id = investigate_id;}catch{}
			try{if (off_grades.ToString() == "0001-1-1 0:00:00") t_Checkup.Off_grades = null; else t_Checkup.Off_grades = off_grades;}catch{}
			try{if (rank_scores.ToString() == "0001-1-1 0:00:00") t_Checkup.Rank_scores = null; else t_Checkup.Rank_scores = rank_scores;}catch{}
			try{if (anti_seismics.ToString() == "0001-1-1 0:00:00") t_Checkup.Anti_seismics = null; else t_Checkup.Anti_seismics = anti_seismics;}catch{}
			try{if (repairables.ToString() == "0001-1-1 0:00:00") t_Checkup.Repairables = null; else t_Checkup.Repairables = repairables;}catch{}
			try{if (checkup_suggestions.ToString() == "0001-1-1 0:00:00") t_Checkup.Checkup_suggestions = null; else t_Checkup.Checkup_suggestions = checkup_suggestions;}catch{}
			try{if (evaluate_suggestions.ToString() == "0001-1-1 0:00:00") t_Checkup.Evaluate_suggestions = null; else t_Checkup.Evaluate_suggestions = evaluate_suggestions;}catch{}
			try{if (solutions.ToString() == "0001-1-1 0:00:00") t_Checkup.Solutions = null; else t_Checkup.Solutions = solutions;}catch{}
			try{if (remakes.ToString() == "0001-1-1 0:00:00") t_Checkup.Remakes = null; else t_Checkup.Remakes = remakes;}catch{}
			try{if (create_user.ToString() == "0001-1-1 0:00:00") t_Checkup.Create_user = null; else t_Checkup.Create_user = create_user;}catch{}
			try{if (create_time.ToString() == "0001-1-1 0:00:00") t_Checkup.Create_time = null; else t_Checkup.Create_time = create_time;}catch{}
			try{if (update_user.ToString() == "0001-1-1 0:00:00") t_Checkup.Update_user = null; else t_Checkup.Update_user = update_user;}catch{}
			try{if (update_time.ToString() == "0001-1-1 0:00:00") t_Checkup.Update_time = null; else t_Checkup.Update_time = update_time;}catch{}
			try{if (status.ToString() == "0001-1-1 0:00:00") t_Checkup.Status = null; else t_Checkup.Status = status;}catch{}
			try{if (checkup_category.ToString() == "0001-1-1 0:00:00") t_Checkup.Checkup_category = null; else t_Checkup.Checkup_category = checkup_category;}catch{}
		}
		#endregion
    }
}

