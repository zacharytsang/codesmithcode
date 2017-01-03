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
	public partial class T_User
	{
	    #region private field
		
			private Nullable<int> user_id;
			private string username;
			private string password;
			private Nullable<int> role_id;
			private Nullable<bool> status;
			private Nullable<DateTime> create_date;

        #endregion

        #region constructor

			public T_User() {
			}

        #endregion

        #region public property

			public Nullable<int> User_id {
				get { return user_id; }
				set { user_id = value; }
			}
			
			public string Username {
				get { return username; }
				set { username = value; }
			}
			
			public string Password {
				get { return password; }
				set { password = value; }
			}
			
			public Nullable<int> Role_id {
				get { return role_id; }
				set { role_id = value; }
			}
			
			public Nullable<bool> Status {
				get { return status; }
				set { status = value; }
			}
			
			public Nullable<DateTime> Create_date {
				get { return create_date; }
				set { create_date = value; }
			}
			
			
        #endregion

	}
}

