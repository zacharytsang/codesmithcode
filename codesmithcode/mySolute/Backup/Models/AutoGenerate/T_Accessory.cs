//============================================================
// Producnt name:		Models
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2016/12/19 16:30:05
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
namespace Models
{
	
	[Serializable()]
	public partial class T_Accessory
	{
	    #region private field
		
			private Nullable<int> id;
			private string acc_category;
			private string acc_name;
			private string acc_url;
			private Nullable<bool> status;

        #endregion

        #region constructor

			public T_Accessories() {
			}

        #endregion

        #region public property

			public Nullable<int> Id {
				get { return id; }
				set { id = value; }
			}
			
			public string Acc_category {
				get { return acc_category; }
				set { acc_category = value; }
			}
			
			public string Acc_name {
				get { return acc_name; }
				set { acc_name = value; }
			}
			
			public string Acc_url {
				get { return acc_url; }
				set { acc_url = value; }
			}
			
			public Nullable<bool> Status {
				get { return status; }
				set { status = value; }
			}
			
			
        #endregion

	}
}

