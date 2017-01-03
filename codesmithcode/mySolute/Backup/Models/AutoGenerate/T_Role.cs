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
	public partial class T_Role
	{
	    #region private field
		
			private Nullable<int> role_id;
			private string role_name;
			private Nullable<bool> role_pris;

        #endregion

        #region constructor

			public T_Role() {
			}

        #endregion

        #region public property

			public Nullable<int> Role_id {
				get { return role_id; }
				set { role_id = value; }
			}
			
			public string Role_name {
				get { return role_name; }
				set { role_name = value; }
			}
			
			public Nullable<bool> Role_pris {
				get { return role_pris; }
				set { role_pris = value; }
			}
			
			
        #endregion

	}
}

