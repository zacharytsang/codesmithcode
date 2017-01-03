//============================================================
// Producnt name:		Models
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2016/12/19 16:30:06
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
namespace Models
{
	
	[Serializable()]
	public partial class T_Menu
	{
	    #region private field
		
			private Nullable<int> menu_id;
			private string menu_name;
			private string menu_url;
			private Nullable<bool> status;
			private Nullable<int> parent_menu_id;

        #endregion

        #region constructor

			public T_Menu() {
			}

        #endregion

        #region public property

			public Nullable<int> Menu_id {
				get { return menu_id; }
				set { menu_id = value; }
			}
			
			public string Menu_name {
				get { return menu_name; }
				set { menu_name = value; }
			}
			
			public string Menu_url {
				get { return menu_url; }
				set { menu_url = value; }
			}
			
			public Nullable<bool> Status {
				get { return status; }
				set { status = value; }
			}
			
			public Nullable<int> Parent_menu_id {
				get { return parent_menu_id; }
				set { parent_menu_id = value; }
			}
			
			
        #endregion

	}
}

