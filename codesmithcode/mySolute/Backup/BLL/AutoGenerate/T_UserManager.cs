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

    public static partial class T_UserManager
    {

		
		//override
		public static T_User AddT_User(int user_id,string password,int role_id,bool status,DateTime create_date)
		{
			Models.T_User t_User = new Models.T_User();

			TransData_AddT_User(user_id,password,role_id,status,create_date,  t_User );
		
			return T_UserService.AddT_User(t_User);
		}
        public static T_User AddT_User(T_User t_User)
        {
            return T_UserService.AddT_User(t_User);
        }

        public static void DeleteT_User(T_User t_User)
        {
            T_UserService.DeleteT_User(t_User);
        }

        public static void DeleteT_UserById(string username)
        {
            T_UserService.DeleteT_UserById(username);
        }

		public static void ModifyT_User(T_User t_User)
        {
            T_UserService.ModifyT_User(t_User);
        }
		//overload
		public static void ModifyT_User(int user_id,string username,string password,int role_id,bool status,DateTime create_date)
        {
			Models.T_User t_User = new Models.T_User();
	        //PK
			t_User.Username=Username;
			TransData_ModifyT_User(user_id,username,password,role_id,status,create_date,t_User);
		
			 T_UserService.ModifyT_User(t_User);
		}

        public static IList<T_User> GetAllT_Users()
        {
            return T_UserService.GetAllT_Users();
        }

        public static T_User GetT_UserByUsername(string username)
        {
            return T_UserService.GetT_UserByUsername(username);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddT_User(int user_id,string password,int role_id,bool status,DateTime create_date, Models.T_User t_User )
        {
			try{if (user_id.ToString() == "0001-1-1 0:00:00") t_User.User_id = null; else t_User.User_id = user_id;}catch{}

			try{if (password.ToString() == "0001-1-1 0:00:00") t_User.Password = null; else t_User.Password = password;}catch{}
			try{if (role_id.ToString() == "0001-1-1 0:00:00") t_User.Role_id = null; else t_User.Role_id = role_id;}catch{}
			try{if (status.ToString() == "0001-1-1 0:00:00") t_User.Status = null; else t_User.Status = status;}catch{}
			try{if (create_date.ToString() == "0001-1-1 0:00:00") t_User.Create_date = null; else t_User.Create_date = create_date;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyT_User(int user_id,string username,string password,int role_id,bool status,DateTime create_date, Models.T_User t_User)
		{
			try{if (user_id.ToString() == "0001-1-1 0:00:00") t_User.User_id = null; else t_User.User_id = user_id;}catch{}

			try{if (password.ToString() == "0001-1-1 0:00:00") t_User.Password = null; else t_User.Password = password;}catch{}
			try{if (role_id.ToString() == "0001-1-1 0:00:00") t_User.Role_id = null; else t_User.Role_id = role_id;}catch{}
			try{if (status.ToString() == "0001-1-1 0:00:00") t_User.Status = null; else t_User.Status = status;}catch{}
			try{if (create_date.ToString() == "0001-1-1 0:00:00") t_User.Create_date = null; else t_User.Create_date = create_date;}catch{}
		}
		#endregion
    }
}

