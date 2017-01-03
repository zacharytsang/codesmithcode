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
	public partial class T_Department
	{
	    #region private field
		
			private Nullable<int> depart_id;
			private string depart_name;
			private string depart_addr;
			private Nullable<bool> depart_status;

        #endregion

        #region constructor

			public T_Department() {
			}

        #endregion

        #region public property

			public Nullable<int> Depart_id {
				get { return depart_id; }
				set { depart_id = value; }
			}
			
			public string Depart_name {
				get { return depart_name; }
				set { depart_name = value; }
			}
			
			public string Depart_addr {
				get { return depart_addr; }
				set { depart_addr = value; }
			}
			
			public Nullable<bool> Depart_status {
				get { return depart_status; }
				set { depart_status = value; }
			}
			
			
        #endregion

	}
}

