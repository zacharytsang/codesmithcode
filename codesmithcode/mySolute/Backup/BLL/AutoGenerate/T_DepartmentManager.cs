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

    public static partial class T_DepartmentManager
    {

		
		//override
		public static T_Department AddT_Department(int depart_id,string depart_addr,bool depart_status)
		{
			Models.T_Department t_Department = new Models.T_Department();

			TransData_AddT_Department(depart_id,depart_addr,depart_status,  t_Department );
		
			return T_DepartmentService.AddT_Department(t_Department);
		}
        public static T_Department AddT_Department(T_Department t_Department)
        {
            return T_DepartmentService.AddT_Department(t_Department);
        }

        public static void DeleteT_Department(T_Department t_Department)
        {
            T_DepartmentService.DeleteT_Department(t_Department);
        }

        public static void DeleteT_DepartmentById(string depart_name)
        {
            T_DepartmentService.DeleteT_DepartmentById(depart_name);
        }

		public static void ModifyT_Department(T_Department t_Department)
        {
            T_DepartmentService.ModifyT_Department(t_Department);
        }
		//overload
		public static void ModifyT_Department(int depart_id,string depart_name,string depart_addr,bool depart_status)
        {
			Models.T_Department t_Department = new Models.T_Department();
	        //PK
			t_Department.Depart_name=Depart_name;
			TransData_ModifyT_Department(depart_id,depart_name,depart_addr,depart_status,t_Department);
		
			 T_DepartmentService.ModifyT_Department(t_Department);
		}

        public static IList<T_Department> GetAllT_Departments()
        {
            return T_DepartmentService.GetAllT_Departments();
        }

        public static T_Department GetT_DepartmentByDepart_name(string depart_name)
        {
            return T_DepartmentService.GetT_DepartmentByDepart_name(depart_name);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddT_Department(int depart_id,string depart_addr,bool depart_status, Models.T_Department t_Department )
        {
			try{if (depart_id.ToString() == "0001-1-1 0:00:00") t_Department.Depart_id = null; else t_Department.Depart_id = depart_id;}catch{}

			try{if (depart_addr.ToString() == "0001-1-1 0:00:00") t_Department.Depart_addr = null; else t_Department.Depart_addr = depart_addr;}catch{}
			try{if (depart_status.ToString() == "0001-1-1 0:00:00") t_Department.Depart_status = null; else t_Department.Depart_status = depart_status;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyT_Department(int depart_id,string depart_name,string depart_addr,bool depart_status, Models.T_Department t_Department)
		{
			try{if (depart_id.ToString() == "0001-1-1 0:00:00") t_Department.Depart_id = null; else t_Department.Depart_id = depart_id;}catch{}

			try{if (depart_addr.ToString() == "0001-1-1 0:00:00") t_Department.Depart_addr = null; else t_Department.Depart_addr = depart_addr;}catch{}
			try{if (depart_status.ToString() == "0001-1-1 0:00:00") t_Department.Depart_status = null; else t_Department.Depart_status = depart_status;}catch{}
		}
		#endregion
    }
}

