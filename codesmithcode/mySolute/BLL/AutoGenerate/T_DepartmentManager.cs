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

    public static partial class T_DepartmentManager
    {

		
		//override
		public static T_Department AddT_Department(string depart_name,string depart_addr,bool depart_status)
		{
			Models.T_Department t_Department = new Models.T_Department();

			TransData_AddT_Department(depart_name,depart_addr,depart_status,  t_Department );
		
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

        public static void DeleteT_DepartmentById(int id)
        {
            T_DepartmentService.DeleteT_DepartmentById(id);
        }

		public static void ModifyT_Department(T_Department t_Department)
        {
            T_DepartmentService.ModifyT_Department(t_Department);
        }
		//overload
		public static void ModifyT_Department(int Id,string depart_name,string depart_addr,bool depart_status)
        {
			Models.T_Department t_Department = new Models.T_Department();
	        //PK
			t_Department.Id=Id;
			TransData_ModifyT_Department(Id,depart_name,depart_addr,depart_status,t_Department);
		
			 T_DepartmentService.ModifyT_Department(t_Department);
		}

        public static List<T_Department> GetAllT_Departments()
        {
            return T_DepartmentService.GetAllT_Departments();
        }
        
        
        public static List<T_Department> GetAllT_DepartmentBySQLstring(string sqlstring)
        {
            return T_DepartmentService.GetAllT_DepartmentBySQLstring(sqlstring);
        }
        
        
        public static T_Department GetT_DepartmentById(int id)
        {
            return T_DepartmentService.GetT_DepartmentById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddT_Department(string depart_name,string depart_addr,bool depart_status, Models.T_Department t_Department )
        {

			try{if (depart_name.ToString() == "0001-1-1 0:00:00") t_Department.Depart_name = null; else t_Department.Depart_name = depart_name;}catch{}
			try{if (depart_addr.ToString() == "0001-1-1 0:00:00") t_Department.Depart_addr = null; else t_Department.Depart_addr = depart_addr;}catch{}
			try{if (depart_status.ToString() == "0001-1-1 0:00:00") t_Department.Depart_status = null; else t_Department.Depart_status = depart_status;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyT_Department(int Id,string depart_name,string depart_addr,bool depart_status, Models.T_Department t_Department)
		{

			try{if (depart_name.ToString() == "0001-1-1 0:00:00") t_Department.Depart_name = null; else t_Department.Depart_name = depart_name;}catch{}
			try{if (depart_addr.ToString() == "0001-1-1 0:00:00") t_Department.Depart_addr = null; else t_Department.Depart_addr = depart_addr;}catch{}
			try{if (depart_status.ToString() == "0001-1-1 0:00:00") t_Department.Depart_status = null; else t_Department.Depart_status = depart_status;}catch{}
		}
		#endregion
    }
}

