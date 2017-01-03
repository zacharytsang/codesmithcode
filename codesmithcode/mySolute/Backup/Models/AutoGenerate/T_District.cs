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
	public partial class T_District
	{
	    #region private field
		
			private Nullable<int> district_id;
			private string district_name;
			private Nullable<int> district_level;
			private Nullable<int> parent_district;

        #endregion

        #region constructor

			public T_District() {
			}

        #endregion

        #region public property

			public Nullable<int> District_id {
				get { return district_id; }
				set { district_id = value; }
			}
			
			public string District_name {
				get { return district_name; }
				set { district_name = value; }
			}
			
			public Nullable<int> District_level {
				get { return district_level; }
				set { district_level = value; }
			}
			
			public Nullable<int> Parent_district {
				get { return parent_district; }
				set { parent_district = value; }
			}
			
			
        #endregion

	}
}

