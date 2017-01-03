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
	public partial class T_CheckupCorp
	{
	    #region private field
		
			private Nullable<int> id;
			private string corp_name;
			private string corp_addr;
			private string leading_official;
			private string contacts;
			private string contact_numbers;
			private string remarks;
			private Nullable<bool> status;

        #endregion

        #region constructor

			public T_CheckupCorps() {
			}

        #endregion

        #region public property

			public Nullable<int> Id {
				get { return id; }
				set { id = value; }
			}
			
			public string Corp_name {
				get { return corp_name; }
				set { corp_name = value; }
			}
			
			public string Corp_addr {
				get { return corp_addr; }
				set { corp_addr = value; }
			}
			
			public string Leading_official {
				get { return leading_official; }
				set { leading_official = value; }
			}
			
			public string Contacts {
				get { return contacts; }
				set { contacts = value; }
			}
			
			public string Contact_numbers {
				get { return contact_numbers; }
				set { contact_numbers = value; }
			}
			
			public string Remarks {
				get { return remarks; }
				set { remarks = value; }
			}
			
			public Nullable<bool> Status {
				get { return status; }
				set { status = value; }
			}
			
			
        #endregion

	}
}

