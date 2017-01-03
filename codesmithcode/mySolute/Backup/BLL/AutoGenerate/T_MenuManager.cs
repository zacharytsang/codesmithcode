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

    public static partial class T_MenuManager
    {

		
		//override
		public static T_Menu AddT_Menu(int menu_id,string menu_name,bool status,int parent_menu_id)
		{
			Models.T_Menu t_Menu = new Models.T_Menu();

			TransData_AddT_Menu(menu_id,menu_name,status,parent_menu_id,  t_Menu );
		
			return T_MenuService.AddT_Menu(t_Menu);
		}
        public static T_Menu AddT_Menu(T_Menu t_Menu)
        {
            return T_MenuService.AddT_Menu(t_Menu);
        }

        public static void DeleteT_Menu(T_Menu t_Menu)
        {
            T_MenuService.DeleteT_Menu(t_Menu);
        }

        public static void DeleteT_MenuById(string menu_url)
        {
            T_MenuService.DeleteT_MenuById(menu_url);
        }

		public static void ModifyT_Menu(T_Menu t_Menu)
        {
            T_MenuService.ModifyT_Menu(t_Menu);
        }
		//overload
		public static void ModifyT_Menu(int menu_id,string menu_name,string menu_url,bool status,int parent_menu_id)
        {
			Models.T_Menu t_Menu = new Models.T_Menu();
	        //PK
			t_Menu.Menu_url=Menu_url;
			TransData_ModifyT_Menu(menu_id,menu_name,menu_url,status,parent_menu_id,t_Menu);
		
			 T_MenuService.ModifyT_Menu(t_Menu);
		}

        public static IList<T_Menu> GetAllT_Menus()
        {
            return T_MenuService.GetAllT_Menus();
        }

        public static T_Menu GetT_MenuByMenu_url(string menu_url)
        {
            return T_MenuService.GetT_MenuByMenu_url(menu_url);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddT_Menu(int menu_id,string menu_name,bool status,int parent_menu_id, Models.T_Menu t_Menu )
        {
			try{if (menu_id.ToString() == "0001-1-1 0:00:00") t_Menu.Menu_id = null; else t_Menu.Menu_id = menu_id;}catch{}
			try{if (menu_name.ToString() == "0001-1-1 0:00:00") t_Menu.Menu_name = null; else t_Menu.Menu_name = menu_name;}catch{}

			try{if (status.ToString() == "0001-1-1 0:00:00") t_Menu.Status = null; else t_Menu.Status = status;}catch{}
			try{if (parent_menu_id.ToString() == "0001-1-1 0:00:00") t_Menu.Parent_menu_id = null; else t_Menu.Parent_menu_id = parent_menu_id;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyT_Menu(int menu_id,string menu_name,string menu_url,bool status,int parent_menu_id, Models.T_Menu t_Menu)
		{
			try{if (menu_id.ToString() == "0001-1-1 0:00:00") t_Menu.Menu_id = null; else t_Menu.Menu_id = menu_id;}catch{}
			try{if (menu_name.ToString() == "0001-1-1 0:00:00") t_Menu.Menu_name = null; else t_Menu.Menu_name = menu_name;}catch{}

			try{if (status.ToString() == "0001-1-1 0:00:00") t_Menu.Status = null; else t_Menu.Status = status;}catch{}
			try{if (parent_menu_id.ToString() == "0001-1-1 0:00:00") t_Menu.Parent_menu_id = null; else t_Menu.Parent_menu_id = parent_menu_id;}catch{}
		}
		#endregion
    }
}

