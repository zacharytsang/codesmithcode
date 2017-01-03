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
	public partial class T_RoleMenuRelation
	{
	    #region private field
		
			private int id;
			private Nullable<int> role_id;
			private Nullable<int> menu_id;

        #endregion

        #region constructor

			public T_RoleMenuRelations() {
			}

        #endregion

        #region public property

			public int Id {
				get { return id; }
				set { id = value; }
			}
			
			public Nullable<int> Role_id {
				get { return role_id; }
				set { role_id = value; }
			}
			
			public Nullable<int> Menu_id {
				get { return menu_id; }
				set { menu_id = value; }
			}
			
			
        #endregion

	}
}

