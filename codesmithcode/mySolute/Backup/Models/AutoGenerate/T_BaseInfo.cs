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
	public partial class T_BaseInfo
	{
	    #region private field
		
			private int config_id;
			private string config_name;
			private string config_value;
			private Nullable<bool> config_status;

        #endregion

        #region constructor

			public T_BaseInfo() {
			}

        #endregion

        #region public property

			public int Config_id {
				get { return config_id; }
				set { config_id = value; }
			}
			
			public string Config_name {
				get { return config_name; }
				set { config_name = value; }
			}
			
			public string Config_value {
				get { return config_value; }
				set { config_value = value; }
			}
			
			public Nullable<bool> Config_status {
				get { return config_status; }
				set { config_status = value; }
			}
			
			
        #endregion

	}
}

