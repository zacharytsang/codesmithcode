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

    public static partial class T_RoleManager
    {

		
		//override
		public static T_Role AddT_Role(string role_name,bool role_pris)
		{
			Models.T_Role t_Role = new Models.T_Role();

			TransData_AddT_Role(role_name,role_pris,  t_Role );
		
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

        public static void DeleteT_RoleById(int id)
        {
            T_RoleService.DeleteT_RoleById(id);
        }

		public static void ModifyT_Role(T_Role t_Role)
        {
            T_RoleService.ModifyT_Role(t_Role);
        }
		//overload
		public static void ModifyT_Role(int Id,string role_name,bool role_pris)
        {
			Models.T_Role t_Role = new Models.T_Role();
	        //PK
			t_Role.Id=Id;
			TransData_ModifyT_Role(Id,role_name,role_pris,t_Role);
		
			 T_RoleService.ModifyT_Role(t_Role);
		}

        public static List<T_Role> GetAllT_Roles()
        {
            return T_RoleService.GetAllT_Roles();
        }
        
        
        public static List<T_Role> GetAllT_RoleBySQLstring(string sqlstring)
        {
            return T_RoleService.GetAllT_RoleBySQLstring(sqlstring);
        }
        
        
        public static T_Role GetT_RoleById(int id)
        {
            return T_RoleService.GetT_RoleById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddT_Role(string role_name,bool role_pris, Models.T_Role t_Role )
        {

			try{if (role_name.ToString() == "0001-1-1 0:00:00") t_Role.Role_name = null; else t_Role.Role_name = role_name;}catch{}
			try{if (role_pris.ToString() == "0001-1-1 0:00:00") t_Role.Role_pris = null; else t_Role.Role_pris = role_pris;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyT_Role(int Id,string role_name,bool role_pris, Models.T_Role t_Role)
		{

			try{if (role_name.ToString() == "0001-1-1 0:00:00") t_Role.Role_name = null; else t_Role.Role_name = role_name;}catch{}
			try{if (role_pris.ToString() == "0001-1-1 0:00:00") t_Role.Role_pris = null; else t_Role.Role_pris = role_pris;}catch{}
		}
		#endregion
    }
}

