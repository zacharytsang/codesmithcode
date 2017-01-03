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
	public partial class T_Investigate
	{
	    #region private field
		
			private Nullable<int> id;
			private string building_id;
			private string building_name;
			private string building_owner;
			private string building_user;
			private Nullable<DateTime> start_date;
			private Nullable<DateTime> finish_date;
			private string design_corp;
			private string construct_corp;
			private Nullable<int> total_area;
			private Nullable<int> floors;
			private string struct_type;
			private string building_purpose;
			private string contacts;
			private string contact_numbers;
			private string problems;
			private string checkup_suggestions;
			private string rectifications;
			private string remarks;
			private string create_user;
			private Nullable<DateTime> create_datetime;
			private string update_user;
			private Nullable<DateTime> update_time;
			private string investigate_category;

        #endregion

        #region constructor

			public T_Investigates() {
			}

        #endregion

        #region public property

			public Nullable<int> Id {
				get { return id; }
				set { id = value; }
			}
			
			public string Building_id {
				get { return building_id; }
				set { building_id = value; }
			}
			
			public string Building_name {
				get { return building_name; }
				set { building_name = value; }
			}
			
			public string Building_owner {
				get { return building_owner; }
				set { building_owner = value; }
			}
			
			public string Building_user {
				get { return building_user; }
				set { building_user = value; }
			}
			
			public Nullable<DateTime> Start_date {
				get { return start_date; }
				set { start_date = value; }
			}
			
			public Nullable<DateTime> Finish_date {
				get { return finish_date; }
				set { finish_date = value; }
			}
			
			public string Design_corp {
				get { return design_corp; }
				set { design_corp = value; }
			}
			
			public string Construct_corp {
				get { return construct_corp; }
				set { construct_corp = value; }
			}
			
			public Nullable<int> Total_area {
				get { return total_area; }
				set { total_area = value; }
			}
			
			public Nullable<int> Floors {
				get { return floors; }
				set { floors = value; }
			}
			
			public string Struct_type {
				get { return struct_type; }
				set { struct_type = value; }
			}
			
			public string Building_purpose {
				get { return building_purpose; }
				set { building_purpose = value; }
			}
			
			public string Contacts {
				get { return contacts; }
				set { contacts = value; }
			}
			
			public string Contact_numbers {
				get { return contact_numbers; }
				set { contact_numbers = value; }
			}
			
			public string Problems {
				get { return problems; }
				set { problems = value; }
			}
			
			public string Checkup_suggestions {
				get { return checkup_suggestions; }
				set { checkup_suggestions = value; }
			}
			
			public string Rectifications {
				get { return rectifications; }
				set { rectifications = value; }
			}
			
			public string Remarks {
				get { return remarks; }
				set { remarks = value; }
			}
			
			public string Create_user {
				get { return create_user; }
				set { create_user = value; }
			}
			
			public Nullable<DateTime> Create_datetime {
				get { return create_datetime; }
				set { create_datetime = value; }
			}
			
			public string Update_user {
				get { return update_user; }
				set { update_user = value; }
			}
			
			public Nullable<DateTime> Update_time {
				get { return update_time; }
				set { update_time = value; }
			}
			
			public string Investigate_category {
				get { return investigate_category; }
				set { investigate_category = value; }
			}
			
			
        #endregion

	}
}

