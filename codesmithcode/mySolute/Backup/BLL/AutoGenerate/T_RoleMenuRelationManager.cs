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

    public static partial class T_RoleMenuRelationManager
    {

		
		//override
		public static T_RoleMenuRelation AddT_RoleMenuRelation(int role_id,int menu_id)
		{
			Models.T_RoleMenuRelation t_RoleMenuRelation = new Models.T_RoleMenuRelation();

			TransData_AddT_RoleMenuRelation(role_id,menu_id,  t_RoleMenuRelation );
		
			return T_RoleMenuRelationService.AddT_RoleMenuRelation(t_RoleMenuRelation);
		}
        public static T_RoleMenuRelation AddT_RoleMenuRelation(T_RoleMenuRelation t_RoleMenuRelation)
        {
            return T_RoleMenuRelationService.AddT_RoleMenuRelation(t_RoleMenuRelation);
        }

        public static void DeleteT_RoleMenuRelation(T_RoleMenuRelation t_RoleMenuRelation)
        {
            T_RoleMenuRelationService.DeleteT_RoleMenuRelation(t_RoleMenuRelation);
        }

        public static void DeleteT_RoleMenuRelationById(int id)
        {
            T_RoleMenuRelationService.DeleteT_RoleMenuRelationById(id);
        }

		public static void ModifyT_RoleMenuRelation(T_RoleMenuRelation t_RoleMenuRelation)
        {
            T_RoleMenuRelationService.ModifyT_RoleMenuRelation(t_RoleMenuRelation);
        }
		//overload
		public static void ModifyT_RoleMenuRelation(int id,int role_id,int menu_id)
        {
			Models.T_RoleMenuRelation t_RoleMenuRelation = new Models.T_RoleMenuRelation();
	        //PK
			t_RoleMenuRelation.Id=Id;
			TransData_ModifyT_RoleMenuRelation(id,role_id,menu_id,t_RoleMenuRelation);
		
			 T_RoleMenuRelationService.ModifyT_RoleMenuRelation(t_RoleMenuRelation);
		}

        public static IList<T_RoleMenuRelation> GetAllT_RoleMenuRelations()
        {
            return T_RoleMenuRelationService.GetAllT_RoleMenuRelations();
        }

        public static T_RoleMenuRelation GetT_RoleMenuRelationById(int id)
        {
            return T_RoleMenuRelationService.GetT_RoleMenuRelationById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddT_RoleMenuRelation(int role_id,int menu_id, Models.T_RoleMenuRelation t_RoleMenuRelation )
        {

			try{if (role_id.ToString() == "0001-1-1 0:00:00") t_RoleMenuRelation.Role_id = null; else t_RoleMenuRelation.Role_id = role_id;}catch{}
			try{if (menu_id.ToString() == "0001-1-1 0:00:00") t_RoleMenuRelation.Menu_id = null; else t_RoleMenuRelation.Menu_id = menu_id;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyT_RoleMenuRelation(int id,int role_id,int menu_id, Models.T_RoleMenuRelation t_RoleMenuRelation)
		{

			try{if (role_id.ToString() == "0001-1-1 0:00:00") t_RoleMenuRelation.Role_id = null; else t_RoleMenuRelation.Role_id = role_id;}catch{}
			try{if (menu_id.ToString() == "0001-1-1 0:00:00") t_RoleMenuRelation.Menu_id = null; else t_RoleMenuRelation.Menu_id = menu_id;}catch{}
		}
		#endregion
    }
}

