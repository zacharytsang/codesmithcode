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

    public static partial class T_RoleManager
    {

		
		//override
		public static T_Role AddT_Role(int role_id,bool role_pris)
		{
			Models.T_Role t_Role = new Models.T_Role();

			TransData_AddT_Role(role_id,role_pris,  t_Role );
		
			return T_RoleService.AddT_Role(t_Role);
		}
        public static T_Role AddT_Role(T_Role t_Role)
        {
            return T_RoleService.AddT_Role(t_Role);
        }

        public static void DeleteT_Role(T_Role t_Role)
        {
            T_RoleService.DeleteT_Role(t_Role);
        }

        public static void DeleteT_RoleById(string role_name)
        {
            T_RoleService.DeleteT_RoleById(role_name);
        }

		public static void ModifyT_Role(T_Role t_Role)
        {
            T_RoleService.ModifyT_Role(t_Role);
        }
		//overload
		public static void ModifyT_Role(int role_id,string role_name,bool role_pris)
        {
			Models.T_Role t_Role = new Models.T_Role();
	        //PK
			t_Role.Role_name=Role_name;
			TransData_ModifyT_Role(role_id,role_name,role_pris,t_Role);
		
			 T_RoleService.ModifyT_Role(t_Role);
		}

        public static IList<T_Role> GetAllT_Roles()
        {
            return T_RoleService.GetAllT_Roles();
        }

        public static T_Role GetT_RoleByRole_name(string role_name)
        {
            return T_RoleService.GetT_RoleByRole_name(role_name);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddT_Role(int role_id,bool role_pris, Models.T_Role t_Role )
        {
			try{if (role_id.ToString() == "0001-1-1 0:00:00") t_Role.Role_id = null; else t_Role.Role_id = role_id;}catch{}

			try{if (role_pris.ToString() == "0001-1-1 0:00:00") t_Role.Role_pris = null; else t_Role.Role_pris = role_pris;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyT_Role(int role_id,string role_name,bool role_pris, Models.T_Role t_Role)
		{
			try{if (role_id.ToString() == "0001-1-1 0:00:00") t_Role.Role_id = null; else t_Role.Role_id = role_id;}catch{}

			try{if (role_pris.ToString() == "0001-1-1 0:00:00") t_Role.Role_pris = null; else t_Role.Role_pris = role_pris;}catch{}
		}
		#endregion
    }
}

